using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class KorisnikRepository : Repository<Korisnik>
    {
        public KorisnikRepository() : base(new DBModel())
        {
        }

        public IQueryable<Korisnik> GetKorisnikById(int id)
        {
            var query = from e in Entities
                        where e.Id == id
                        select e;

            return query;
        }

        public override int Add(Korisnik entity, bool saveChanges = true)
        {
            var korisnikk = new Korisnik
            {
                Ime = entity.Ime,
                Prezime = entity.Prezime,
                Korime = entity.Korime,
                Lozinka = entity.Lozinka,
                Broj_telefona = entity.Broj_telefona
            };

            Entities.Add(korisnikk);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Korisnik entity, bool saveChanges = true)
        {
            var korisnik = Entities.SingleOrDefault(k => k.Id == entity.Id);

            korisnik.Id = entity.Id;
            korisnik.Ime = entity.Ime;
            korisnik.Prezime = entity.Prezime;
            korisnik.Korime = entity.Korime;
            korisnik.Lozinka = entity.Lozinka;
            korisnik.Broj_telefona = entity.Broj_telefona;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

    }
}
