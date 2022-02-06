using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop.Controllers
{
    internal class SecurityController
    {
        public static string Encrypt(string stringToEncrypt)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(stringToEncrypt);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public static string Decrypt(string stringToDecrypt)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(stringToDecrypt);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
