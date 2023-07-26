using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class OglasRepository : Repository<Oglas>
    {
        public OglasRepository() : base(new DBModel())
        {
        }

        public override IQueryable<Oglas> GetAll()
        {
            var query = from e in Entities
                        .Include("Korisnik")
                        select e;

            return query;
        }

        public IQueryable<Oglas> GetOglasById(int oglasId)
        {
            var query = from e in Entities
                        .Include("Korisnik")
                        where e.Id == oglasId
                        select e;

            return query;
        }

        public IQueryable<Oglas> GetMostWantedOglas()
        {
            var query = from e in Entities
                        .Include("Korisnik")
                        orderby e.Broj_pregleda descending
                        select e;

            return query.Take(5);
        }

        public IQueryable<Oglas> GetOglasByName(string nazivOglasa)
        {
              var query = from e in Entities
                        .Include("Korisnik")
                        where e.Naziv_oglasa.Contains(nazivOglasa)
                        orderby e.Datum_objave descending
                        select e;

            return query;
        }

        public IQueryable<Oglas> FilterOglas(string filter, string kategorija) 
        {
            var query = GetOglasByKategorija(kategorija);

            switch (filter)
            {
                case "Datum objave silazno":
                    query = query.OrderByDescending(e => e.Datum_objave);
                    break;
                case "Datum objave uzlazno":
                    query = query.OrderBy(e => e.Datum_objave);
                    break;
                case "Cijena silazno":
                    query = query.OrderByDescending(e => e.Cijena);
                    break;
                case "Cijena uzlazno":
                    query = query.OrderBy(e => e.Cijena);
                    break;
            }

            return query;
        }

        public IQueryable<Oglas> GetOglasByKategorija(string kategorija)
        {
            if (kategorija == "Svi")
            {
                var query = GetAll();
                
                return query;
            }
            else
            {
                var query = from e in Entities
                            .Include("Korisnik")
                            where e.Kategorija.Contains(kategorija)
                            select e;

                return query;
            }
        }

        public IQueryable<Oglas> GetOglasForKorisnik(int id)
        {
            var query = from e in Entities
                        .Include("Korisnik")
                        where e.Korisnik.Id == id
                        select e;

            return query;
        }

        public override int Update(Oglas entity, bool saveChanges = true)
        {
            var oglas = Entities.SingleOrDefault(o => o.Id == entity.Id);

            oglas.Naziv_oglasa = entity.Naziv_oglasa;
            oglas.Opis = entity.Opis;
            oglas.Cijena = entity.Cijena;
            oglas.Lokacija = entity.Lokacija;
            oglas.Kategorija = entity.Kategorija;
            oglas.Datum_objave = entity.Datum_objave;
            oglas.Prodano = entity.Prodano;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int UpdateViewCount(Oglas entity, bool saveChanges = true)
        {
            var oglass = Entities.SingleOrDefault(o => o.Id == entity.Id);
            oglass.Broj_pregleda = entity.Broj_pregleda;

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
