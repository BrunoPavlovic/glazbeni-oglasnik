using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public class SlikaServices
    {
        public List<Slike> GetSlikeForOglas(int oglasId)
        {
            using (var repo = new SlikaRepository())
            {
                List<Slike> slike = repo.GetSlikeForOglas(oglasId).ToList();
                return slike;
            }
        }

        public bool AddSlika(Slike slika)
        {
            bool isSuccesful = false;
            using (var repo = new SlikaRepository())
            {
                int affectedRow = repo.Add(slika);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateSlika(Slike slika)
        {
            bool isSuccesful = false;
            using (var repo = new SlikaRepository())
            {
                int affectedRow = repo.Update(slika);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveSlika(Slike slika)
        {
            bool isSuccesful = false;
            using (var repo = new SlikaRepository())
            {
                int affectedRow = repo.Remove(slika);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
