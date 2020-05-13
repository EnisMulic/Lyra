using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Lyra.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class UserService : CRUDService<Model.User, UserSearchRequest, Database.User, UserInsertRequest, UserUpdateRequest>, IUserService
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public UserService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.User>> Get(UserSearchRequest request)
        {
            var query = _context.Users.Include(i => i.UserRoles).AsQueryable();

            bool isRequestNull = !string.IsNullOrWhiteSpace(request.FirstName) || 
                                 !string.IsNullOrWhiteSpace(request.LastName) ||
                                 !string.IsNullOrWhiteSpace(request.Username) ||
                                 !string.IsNullOrWhiteSpace(request.Email);

            if (isRequestNull)
            {
                query = query.Where(i =>
                    (
                        !string.IsNullOrWhiteSpace(request.FirstName) &&
                        i.FirstName.StartsWith(request.FirstName)
                    ) ||
                    (
                        !string.IsNullOrWhiteSpace(request.LastName) &&
                        i.LastName.StartsWith(request.LastName)
                    ) ||
                    (
                        !string.IsNullOrWhiteSpace(request.Username) &&
                        i.Username.Equals(request.Username)
                    ) ||
                    (
                        !string.IsNullOrWhiteSpace(request.Email) &&
                        i.Email.Equals(request.Email)
                    )
                );
            }
            

            query = query.Skip((request.Page - 1) * request.ItemsPerPage);
            if(request.ItemsPerPage > 0)
            {
                query = query.Take(request.ItemsPerPage);
            }

            var list = await query.ToListAsync();
            return _mapper.Map<List<Model.User>>(list);
        }

        public override async Task<Model.User> GetById(int id)
        {
            var entity =  await _context.Set<Database.User>()
                .Include(i => i.UserRoles)
                .Where(i => i.ID == id)
                .SingleOrDefaultAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public async Task<Model.User> Authenticate(UserAuthenticationRequest request)
        {
            var user = await _context.Users
                .Include(i => i.UserRoles)
                .ThenInclude(j => j.Role)
                .FirstOrDefaultAsync(i => i.Username == request.Username);

            
            if (user != null)
            {
                var hash = GenerateHash(user.PasswordSalt, request.Password);
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

        public override async Task<Model.User> Insert(UserInsertRequest request)
        {
            if(request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            if(!await IsEmailUnique(request.Email))
            {
                throw new UserException("Email is taken!");
            }

            if(!await IsUsernameUnique(request.Username))
            {
                throw new UserException("Username is taken");
            }
            
            var entity = _mapper.Map<Database.User>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach(var roleID in request.Roles)
            {
                var role = new Database.UserRole()
                {
                    UserID = entity.ID,
                    RoleID = roleID
                };

                await _context.UserRoles.AddAsync(role);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public override async Task<Model.User> Update(int id, UserUpdateRequest request)
        {
            if (!await IsEmailUniqueForUser(id, request.Email))
            {
                throw new UserException("Email is taken!");
            }

            if (!await IsUsernameUniqueForUser(id, request.Username))
            {
                throw new UserException("Username is taken");
            }


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

            foreach(var RoleID in request.Roles)
            {
                var userRole = await _context.UserRoles
                    .Where(i => i.RoleID == RoleID && i.UserID == id)
                    .SingleOrDefaultAsync();

                if(userRole == null)
                {
                    var newRole = new Database.UserRole()
                    {
                        UserID = id,
                        RoleID = RoleID
                    };
                    await _context.Set<Database.UserRole>().AddAsync(newRole);
                }
            }


            foreach (var RoleID in request.RolesToDelete)
            {
                var userRole = await _context.UserRoles
                    .Where(i => i.RoleID == RoleID && i.UserID == id)
                    .SingleOrDefaultAsync();

                if (userRole != null)
                {
                    _context.Set<Database.UserRole>().Remove(userRole);
                }
            }

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public async Task<Model.User> SignUp(UserInsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            var entity = _mapper.Map<Database.User>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            var role = await _context.Roles
                .Where(i => i.Name == "User")
                .SingleAsync();


            var userRole = new Database.UserRole()
            {
                UserID = entity.ID,
                RoleID = role.ID
            };

            await _context.UserRoles.AddAsync(userRole);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.User>(entity);
        }

        public async Task<bool> IsEmailUnique(string Email)
        {
            return !await _context.Users.AnyAsync(i => i.Email == Email);
        }

        public async Task<bool> IsEmailUniqueForUser(int ID, string Email)
        {
            var user = await _context.Users.FindAsync(ID);
            return await IsEmailUnique(Email) && Email != user.Email;
        }

        public async Task<bool> IsUsernameUnique(string Username)
        {
            return !await _context.Users.AnyAsync(i => i.Username == Username);
        }

        public async Task<bool> IsUsernameUniqueForUser(int ID, string Username)
        {
            var user = await _context.Users.FindAsync(ID);
            return await IsUsernameUnique(Username) && Username != user.Username;
        }
    }
}
