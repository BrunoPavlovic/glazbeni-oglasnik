using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ZanimljiviOglasiRepository : Repository<Zanimljivi_oglasi>
    {
        public ZanimljiviOglasiRepository() : base(new DBModel())
        {
        }

        public IQueryable<Zanimljivi_oglasi> GetForUser(int id)
        {
            var query = from e in Entities
                        where e.Korisnik_id == id
                        select e;

            return query;
        }

        public override int Update(Zanimljivi_oglasi entity, bool saveChanges = true)
        {
            var zanimljiviOglasi = Entities.SingleOrDefault(z => z.Oglas_id == entity.Oglas_id);

            zanimljiviOglasi.Korisnik_id = entity.Korisnik_id;
            zanimljiviOglasi.Oglas_id = entity.Oglas_id;

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
