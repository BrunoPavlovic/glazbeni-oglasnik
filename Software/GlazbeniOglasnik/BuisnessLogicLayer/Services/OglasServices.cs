using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public class OglasServices
    {
        public List<Oglas> GetOglas()
        {
            using (var repo = new OglasRepository())
            {
                List<Oglas> oglasi = repo.GetAll().ToList();
                return oglasi;
            }
        }

        public List<Oglas> GetMostWantedOglas()
        {
            using (var repo = new OglasRepository())
            {
                List<Oglas> oglasi = repo.GetMostWantedOglas().ToList();
                return oglasi;
            }
        }

        public bool AddOglas(Oglas oglas)
        {
            bool isSuccesful = false;
            using (var repo = new OglasRepository())
            {
                int affectedRow = repo.Add(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateOglas(Oglas oglas)
        {
            bool isSuccesful = false;
            using (var repo = new OglasRepository())
            {
                int affectedRow = repo.Update(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool UpdateOglasView(Oglas oglas)
        {
            bool isSuccesful = false;
            using (var repo = new OglasRepository())
            {
                int affectedRow = repo.UpdateViewCount(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }

        public bool RemoveOglas(Oglas oglas)
        {
            bool isSuccesful = false;
            using (var repo = new OglasRepository())
            {
                int affectedRow = repo.Remove(oglas);
                isSuccesful = affectedRow > 0;
            }

            return isSuccesful;
        }
    }
}
