using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazbeniOglasnik.UI
{
    public partial class FrmPregledOdabranog : Form
    {
        public Oglas oglas;
        public SlikaServices slikaServices = new SlikaServices();

        public FrmPregledOdabranog(Oglas odabraniOglas)
        {
            InitializeComponent();
            this.oglas = odabraniOglas;
        }

        private void pictureBoxUnchecked_Click(object sender, EventArgs e)
        {
            pictureBoxUnchecked.Visible = false;
            pictureBoxChecked.Visible = true;
        }

        private void pictureBoxChecked_Click(object sender, EventArgs e)
        {
            pictureBoxChecked.Visible = false;
            pictureBoxUnchecked.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPregledOdabranog_Load(object sender, EventArgs e)
        {
            FillDetail();
        }

        private void FillDetail()
        {
            title.Text = oglas.Naziv_oglasa;
            richTextOpis.Text = oglas.Opis;
            txtLokacija.Text = oglas.Lokacija;
            labelCijena.Text = oglas.Cijena.ToString() + "$";
            labelBrojPregleda.Text = oglas.Broj_pregleda.ToString();
            labelKorime.Text = oglas.Korisnik.Korime;

            ShowPicturesForOglas();
        }

        private void ShowPicturesForOglas()
        {
            try
            {
                var slikeOglasa = slikaServices.GetSlikeForOglas(oglas.Id);
                Slike slika = slikeOglasa[0];
                byte[] imageBytes = slika.Slika;

                Image image;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    image = Image.FromStream(ms);
                }

                pbOglas.SizeMode = PictureBoxSizeMode.Zoom;
                pbOglas.Image = image;
            }
            catch (Exception)
            {
                MessageBox.Show("Ne postoji slika za odabrani oglas!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
