using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class UserService : CRUDService<Model.User, UserSearchRequest, User, UserUpsertRequest, UserUpsertRequest>, IUserService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public UserService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.User>> Get(UserSearchRequest search)
        {
            var query = _context.Users.AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.FirstName))
            {
                query = query.Where(i => i.FirstName.StartsWith(search.FirstName));
            }


            if (!string.IsNullOrWhiteSpace(search?.LastName))
            {
                query = query.Where(i => i.FirstName.StartsWith(search.LastName));
            }

            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.User>>(list);
        }

        public async Task<Model.User> Authenticate(string username, string password)
        {
            var user = _context.Users
                .Include(i => i.UserRoles)
                .ThenInclude(j => j.Role)
                .FirstOrDefault(i => i.Username == username);

            
            if (user != null)
            {
                var hash = GenerateHash(user.PasswordSalt, password);
                if(hash == user.PasswordHash)
                {
                    return _mapper.Map<Model.User>(user);
                }
            }

            return null;
        }

        public static string GenerateSalt()
        {
            var buffer = new byte[16];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);

            return Convert.ToBase64String(buffer);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA512");
            byte[] inArray = algorithm.ComputeHash(dst);

            return Convert.ToBase64String(inArray);
        }

        public override async Task<Model.User> Insert(UserUpsertRequest request)
        {
            if(request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }
            
            var entity = _mapper.Map<Database.User>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach(var roleID in request.Roles)
            {
                var role = new Database.UserRoles()
                {
                    UserID = entity.ID,
                    RoleID = roleID
                };

                await _context.UserRoles.AddAsync(role);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public override async Task<Model.User> Update(int id, UserUpsertRequest request)
        {
            var entity = _context.Users.Find(id);
            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            if(!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwords do not match!");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.User>(entity);
        }

        
    }
}
