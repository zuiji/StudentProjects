using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace StudentCSV.Helpers
{
    public static class PasswordHelper
    {
        private static byte[] salt = Encoding.UTF8.GetBytes("MyAwsomeSalt");

        public static string HashPassword(string password)
        {
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, salt , 10000))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, salt.Length);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[salt.Length];
            Buffer.BlockCopy(src, 1, dst, 0, salt.Length);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, salt.Length+5, buffer3, 0, 32);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 10000))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return buffer3.SequenceEqual(buffer4);
        }
    }
}