using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EF_leer.util
{
    public static class PasswordHelper
    {
        public static string hashPassword(string password)
        {
            using(SHA1 hasher =  SHA1.Create())
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
    }
}
