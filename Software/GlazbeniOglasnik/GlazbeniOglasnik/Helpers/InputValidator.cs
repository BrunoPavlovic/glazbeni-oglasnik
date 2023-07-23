using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GlazbeniOglasnik.Helpers
{
    public class InputValidator
    {
        public bool ValidateBrojTelefona(string brojTelefona)
        {
            if (string.IsNullOrWhiteSpace(brojTelefona) || brojTelefona.Length < 9 || brojTelefona.Length > 13)
                return false;

            return Regex.IsMatch(brojTelefona, @"^\+?[0-9]+$");
        }

        public bool ValidateLozinka(string lozinka)
        {
            if (string.IsNullOrWhiteSpace(lozinka) || lozinka.Length < 6)
                return false;

            return true;
        }

        public bool ValidateKorime(string korime)
        {
            if (string.IsNullOrWhiteSpace(korime) || korime.Length < 6 || korime.Length > 50)
                return false;

            return true;
        }

        public bool ValidateImePrezime(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            return Regex.IsMatch(name, @"^[a-zA-Z]{1,50}$");
        }
    }
}
