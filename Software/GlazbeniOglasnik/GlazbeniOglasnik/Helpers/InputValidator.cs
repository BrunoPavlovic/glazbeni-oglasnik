using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public bool ValidateKategorija(string kategorija)
        {
            if (string.IsNullOrEmpty(kategorija))
                return false;

            return true;
        }

        public bool ValidateLokacija(string lokacija)
        {
            if (string.IsNullOrEmpty(lokacija))
                return false;

            return Regex.IsMatch(lokacija, @"^[a-zA-Z]{1,50}$");
        }

        public bool ValidateCijena(string cijena)
        {
            if (!decimal.TryParse(cijena, out decimal cijenaParsed) || cijena.Contains("."))
                return false;

            if (cijenaParsed < 0)
                return false;

            return true;
        }

        public bool ValidateNaziv(string naziv)
        {
            if (string.IsNullOrEmpty(naziv) || naziv.Length > 100)
                return false;

            return true;
        }
    }
}
