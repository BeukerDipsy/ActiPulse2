using System.Text;
using Konscious.Security.Cryptography;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Security.Policy;
using System.Runtime.CompilerServices;

namespace Test
{
    internal class Encrypt
    {
        public static byte[] CreateHash(byte[] password, byte[] salt)
        {
            using var argon2 = new Argon2id(password);
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 8;
            argon2.Iterations = 4;
            argon2.MemorySize = 1024 * 128;

            return argon2.GetBytes(32);
        }

        public static bool VerifyHash(byte[] password, byte[] salt, byte[] hash) =>
            CreateHash(password, salt).SequenceEqual(hash);

        public static byte[] GenerateSalt()
        {
            var buffer = new byte[32];
            using var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);
            return buffer;
        }
    }
}
