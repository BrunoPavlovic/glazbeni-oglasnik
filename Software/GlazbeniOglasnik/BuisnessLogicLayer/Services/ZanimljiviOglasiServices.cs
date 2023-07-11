using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public class ZanimljiviOglasiServices
    {
        public List<Zanimljivi_oglasi> GetZanimljiviOglasiForUser(int userId)
        {
            using (var repo = new ZanimljiviOglasiRepository())
            {
                List<Zanimljivi_oglasi> zanimljiviOglasi = repo.GetForUser(userId).ToList();
                return zanimljiviOglasi;
            }
        }

        public bool AddZanimljiviOglas(Zanimljivi_oglasi zanimljivi)
        {
            bool isSuccesful = false;
            using (var repo = new ZanimljiviOglasiRepository())
            {
                int affectedRow = repo.Add(zanimljivi);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveZanimljiviOglas(Zanimljivi_oglasi oglas)
        {
            bool isSuccesful = false;
            using (var repo = new ZanimljiviOglasiRepository())
            {
                int affectedRow = repo.Remove(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
