using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Helper
{
    public class HashHelper
    {
        public static string GenerateSalt()
        {
            byte[] array = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(array);
            return Convert.ToBase64String(array);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passBytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[passBytes.Length + saltBytes.Length];

            Buffer.BlockCopy(passBytes, 0, dst, 0, passBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, dst, passBytes.Length, saltBytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA256");
            byte[] hashArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(hashArray);
        }

    }
}
