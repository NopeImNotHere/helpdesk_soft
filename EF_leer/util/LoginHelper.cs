using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EF_leer.util
{
    public static class LoginHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA1 hasher = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] outputBytes = hasher.ComputeHash(inputBytes);

                StringBuilder hashStringBuilder = new StringBuilder();
                foreach (byte b in outputBytes)
                {
                    hashStringBuilder.Append(b.ToString("x2"));
                }

                return hashStringBuilder.ToString();
            }
        }

        public static string CreateSessionHash(int userID, string passwordHash)
        {
            using (SHA256 hasher = SHA256.Create())
            {
                byte[] userIdBytes = Encoding.UTF8.GetBytes(userID.ToString());
                byte[] passwordHashBytes = Encoding.UTF8.GetBytes(passwordHash);
                byte[] timestampBytes = Encoding.UTF8.GetBytes(DateTime.UtcNow.ToLongTimeString());
                List<byte> byteList = new List<byte>();
                byteList.AddRange(userIdBytes);
                byteList.AddRange(passwordHashBytes);
                byteList.AddRange(timestampBytes);

                byte[] outputBytes = hasher.ComputeHash(byteList.ToArray());
                StringBuilder hashStringBuilder = new StringBuilder();
                foreach (byte b in outputBytes)
                {
                    hashStringBuilder.Append(b.ToString("x2"));
                }

                return hashStringBuilder.ToString();
            }
        }
    }
}
