using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ToolIca.Securite
{
    public static class Cryptage
    {
        public static byte[] MotDePasseSHA512(string mdp)
        {
            byte[] result = Encoding.UTF8.GetBytes(mdp);
            SHA512 sha = new SHA512Managed();
            result = sha.ComputeHash(result);
            return result;
        }

        public static byte[] MotDePasseSHA256<T>(
            T userModel, 
            string password, 
            Func<T, string> saltSelector)
        {
            string salt = saltSelector(userModel);
            string result = salt.Substring(0, salt.Length / 2) + password + salt.Substring(salt.Length / 2);
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(result));
            }
        }
    }
}
