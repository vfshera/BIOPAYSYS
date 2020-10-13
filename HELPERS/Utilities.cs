using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

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

        public void TextOnly(System.Windows.Forms.KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)){
                e.Handled = true;
            }
        }  
        public void NumbersOnly(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public bool ValidateEmail(string mail)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

           return Regex.IsMatch(mail, pattern);
        }
    }
}
