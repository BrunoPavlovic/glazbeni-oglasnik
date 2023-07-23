using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GlazbeniOglasnik.Helpers
{
    public class LozinkaHash
    {
        public string HashirajLozinku(string lozinka)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] lozinkaBytes = Encoding.UTF8.GetBytes(lozinka);
                byte[] hashBytes = sha256.ComputeHash(lozinkaBytes);
                string hash = Convert.ToBase64String(hashBytes);
                
                return hash;
            }
        }
    }
}
