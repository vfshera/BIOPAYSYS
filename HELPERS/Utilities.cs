using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BiometricPayroll.HELPERS
{
    class Utilities
    {

        public string HashPassword(String pass)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] pass_bytes = Encoding.ASCII.GetBytes(pass);
            byte[] encrypted_bytes = sha1.ComputeHash(pass_bytes);

            return Convert.ToBase64String(encrypted_bytes);
        }
    }
}
