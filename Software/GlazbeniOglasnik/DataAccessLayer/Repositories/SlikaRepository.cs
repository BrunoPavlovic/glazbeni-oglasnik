using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class SlikaRepository : Repository<Slike>
    {
        public SlikaRepository() : base(new DBModel())
        {
        }

        public IQueryable<Slike> GetSlikeForOglas(int idOglasa)
        {
            var query = from e in Entities
                        where e.Oglas_id == idOglasa
                        select e;

            return query;
        }

        public override int Update(Slike entity, bool saveChanges = true)
        {
            var slika = Entities.SingleOrDefault(s => s.Id == entity.Id);

            slika.Oglas_id = entity.Oglas_id;
            slika.Slika = entity.Slika;

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
