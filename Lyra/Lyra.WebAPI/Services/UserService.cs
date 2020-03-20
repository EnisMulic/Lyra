using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Lyra.WebAPI.Services
{
    public class UserService : CRUDService<Model.User, UserSearchRequest, Database.User, UserUpsertRequest, UserUpsertRequest>
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public UserService(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
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

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);

            return Convert.ToBase64String(inArray);
        }

        public override Model.User Insert(UserUpsertRequest request)
        {
            if(request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }
            
            var entity = _mapper.Map<Database.User>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.Users.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }

        public override Model.User Update(int id, UserUpsertRequest request)
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
            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }
    }
}
