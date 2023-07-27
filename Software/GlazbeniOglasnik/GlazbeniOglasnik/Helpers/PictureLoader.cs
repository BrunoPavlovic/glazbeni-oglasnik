using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazbeniOglasnik.Helpers
{
    public class PictureLoader
    {
        public SlikaServices slikaServices = new SlikaServices();

        public void LoadPictures(List<Oglas> oglasi, DataGridView dgv)
        {
            int brojac = -1;
            try
            {
                List<int> slikeOglasId = slikaServices.GetSlikaOglasId();
                foreach (var item in oglasi)
                {
                    brojac++;
                    if (slikeOglasId.Contains(item.Id))
                    {
                        var slikeOglasa = slikaServices.GetSlikeForOglas(item.Id);
                        if (slikeOglasa.Count > 0)
                        {
                            Slike slika = slikeOglasa[0];
                            byte[] imageBytes = slika.Slika;

                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }

                            dgv.Rows[brojac].Cells[0].Value = image;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
