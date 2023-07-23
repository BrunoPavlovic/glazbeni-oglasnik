using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public class KorisnikServices
    {
        public Korisnik GetKorisnikById(int id)
        {
            using (var repo = new KorisnikRepository())
            {
                Korisnik korisnik = repo.GetKorisnikById(id).FirstOrDefault();

                return korisnik;
            }
        }

        public Korisnik PrijaviKorisnika(string korime, string lozinka)
        {
            using (var repo = new KorisnikRepository())
            {
                Korisnik korisnik = repo.PrijaviKorisnika(korime, lozinka).FirstOrDefault();

                return korisnik;
            }
        }

        public bool AddKorisnik(Korisnik korisnik)
        {
            bool isSuccesful = false;
            using (var repo = new KorisnikRepository())
            {
                int affectedRow = repo.Add(korisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateKorisnik(Korisnik korisnik)
        {
            bool isSuccesful = false;
            using (var repo = new KorisnikRepository())
            {
                int affectedRow = repo.Update(korisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveKorisnik(Korisnik korisnik)
        {
            bool isSuccesful = false;
            using (var repo = new KorisnikRepository())
            {
                int affectedRow = repo.Remove(korisnik);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
