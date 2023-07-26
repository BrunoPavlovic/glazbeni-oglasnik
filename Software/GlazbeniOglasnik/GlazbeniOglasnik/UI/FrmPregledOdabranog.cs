using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using GlazbeniOglasnik.Helpers;
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
        public OglasServices oglasServices = new OglasServices();
        public ZanimljiviOglasiServices zanimljiviOglasiServices = new ZanimljiviOglasiServices();
        public PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
        public Korisnik korisnik = new Korisnik();

        public int brojac = 0;
        public List<byte[]> slike = new List<byte[]>();

        public FrmPregledOdabranog(Oglas odabraniOglas)
        {
            InitializeComponent();
            this.oglas = odabraniOglas;
        }

        private void pictureBoxUnchecked_Click(object sender, EventArgs e)
        {
            if (prijavljeniKorisnik.DohvatiPrijavljenogKorisnika() != null)
            {
                pictureBoxUnchecked.Visible = false;
                pictureBoxChecked.Visible = true;

                DodajOglasUZanimljive();
            }
            else
            {
                MessageBox.Show("Morate biti prijavljeni kako bi mogli označiti oglas kao zanimljivi!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DodajOglasUZanimljive()
        {
                try
                {
                    Zanimljivi_oglasi zanimljivi = new Zanimljivi_oglasi
                    {
                        Korisnik_id = korisnik.Id,
                        Oglas_id = oglas.Id
                    };

                    zanimljiviOglasiServices.AddZanimljiviOglas(zanimljivi);

                    MessageBox.Show("Oglas je označen zanimljivim, popis možete pogledati na stranici profila", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void CheckZanimljivi(Korisnik korisnik)
        {
            var korisnikoviOglasi = oglasServices.GetOglasForKorisnik(korisnik.Id);

            foreach (var item in korisnikoviOglasi)
            {
                if (item.Id == oglas.Id)
                {
                    pictureBoxUnchecked.Visible = false;
                    pictureBoxChecked.Visible = false;
                }
            }

            var zanimljiviOglasiKorisnika = zanimljiviOglasiServices.GetZanimljiviOglasiForUser(korisnik.Id);
            foreach (var item in zanimljiviOglasiKorisnika)
            {
                if (item.Oglas_id == oglas.Id)
                {
                    pictureBoxUnchecked.Visible = false;
                    pictureBoxChecked.Visible = true;
                }
            }
        }

        private void pictureBoxChecked_Click(object sender, EventArgs e)
        {
            pictureBoxChecked.Visible = false;
            pictureBoxUnchecked.Visible = true;

            RemoveZanimljivi();
        }

        private void RemoveZanimljivi()
        {
            throw new NotImplementedException();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPregledOdabranog_Load(object sender, EventArgs e)
        {
            FillDetail();
            btnBack.Enabled = false;

            korisnik = prijavljeniKorisnik.DohvatiPrijavljenogKorisnika();
            CheckZanimljivi(korisnik);
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
            if (slikeOglasa.Count == 1)
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
