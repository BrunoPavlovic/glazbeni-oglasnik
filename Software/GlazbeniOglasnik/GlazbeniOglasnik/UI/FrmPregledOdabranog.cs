using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazbeniOglasnik.UI
{
    public partial class FrmPregledOdabranog : Form
    {
        public Oglas oglas;
        public SlikaServices slikaServices = new SlikaServices();
        public int brojac = 0;
        public List<byte[]> slike = new List<byte[]>();

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
            btnBack.Enabled = false;
        }

        private void FillDetail()
        {
            title.Text = oglas.Naziv_oglasa;
            richTextOpis.Text = string.IsNullOrWhiteSpace(oglas.Opis) ? "Nema dodatnih informacija za oglas :)" : oglas.Opis;
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

                CheckPictures(slikeOglasa);
            }
            catch (Exception)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
        }

        private void CheckPictures(List<Slike> slikeOglasa)
        {
            if (slikeOglasa.Count==1)
                btnNext.Enabled = false;
            else
            {
                btnNext.Enabled = true;
                foreach (var item in slikeOglasa)
                {
                    slike.Add(item.Slika);
                }
            }
        }

        private void ShowPicture()
        {
           pbOglas.SizeMode = PictureBoxSizeMode.Zoom;
           pbOglas.Image = Image.FromStream(new MemoryStream(slike[brojac]));
        }

        private void CheckIfFirst()
        {
            if (brojac == 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void CheckIfLast()
        {
            if (brojac == slike.Count - 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            brojac++;
            btnBack.Enabled = true;
            CheckIfLast();
            ShowPicture();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            brojac--;
            btnNext.Enabled = true;
            CheckIfFirst();
            ShowPicture();
        }
    }
}
