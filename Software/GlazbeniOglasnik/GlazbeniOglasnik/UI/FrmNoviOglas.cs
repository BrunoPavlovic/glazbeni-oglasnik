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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GlazbeniOglasnik.UI
{
    public partial class FrmNoviOglas : Form
    {
        public SlikaServices slikaServices = new SlikaServices();
        public OglasServices oglasServices = new OglasServices();
        public int brojac = 0;
        public List<byte[]> slike = new List<byte[]>();

        public FrmNoviOglas()
        {
            InitializeComponent();
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbOglas.SizeMode = PictureBoxSizeMode.Zoom;
                pbOglas.Image = Image.FromFile(openFileDialog.FileName);

                byte[] imageBytes = ConvertToBytes();

                slike.Add(imageBytes);
                brojac = slike.Count - 1;

                if (brojac > 0)
                {
                    btnBack.Enabled = true;
                }

                ShowPicture();
            }
        }

        private byte[] ConvertToBytes()
        {
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                pbOglas.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }

            return imageBytes;
        }

        private void ShowPicture()
        {
            if (slike.Count > 0 && brojac >= 0 && brojac < slike.Count)
            {
                pbOglas.SizeMode = PictureBoxSizeMode.Zoom;
                pbOglas.Image = Image.FromStream(new MemoryStream(slike[brojac]));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            brojac--;
            btnNext.Enabled = true;
            CheckIfFirst();
            ShowPicture();
        }

        private void CheckIfFirst()
        {
            if (brojac == 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            brojac++;
            btnBack.Enabled = true;
            CheckIfLast();
            ShowPicture();
        }

        private void CheckIfLast()
        {
            if (brojac == slike.Count - 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnObrisiSliku_Click(object sender, EventArgs e)
        {
            if (slike.Count > 0)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati odabranu sliku?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeletePicture();
                }
            }
            else
            {
                MessageBox.Show("Nema slika za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeletePicture()
        {
            slike.RemoveAt(brojac);
            brojac--;

            if (slike.Count == 0)
            {
                pbOglas.Image = null;
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
            else if (slike.Count == 1)
            {
                ShowPicture();
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                ShowPicture();
                CheckIfFirst();
                CheckIfLast();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateInput(txtNaziv.Text, txtCijena.Text, txtLokacija.Text, cmbKategorija.Text);
            if (isValid)
            {
                SaveOglas();
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke!","Upozorenje",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveOglas()
        {
            try
            {
                Oglas oglas = new Oglas
                {
                    Naziv_oglasa = txtNaziv.Text,
                    Opis = richTextOpis.Text,
                    Cijena = Convert.ToDecimal(txtCijena.Text),
                    Lokacija = txtLokacija.Text,
                    Kategorija = cmbKategorija.SelectedItem.ToString(),
                    Datum_objave = DateTime.Now,
                    Prodano = 0,
                    Broj_pregleda = 0,
                    Korisnik_id = 1
                };

                oglasServices.AddOglas(oglas);
                SavePictures();
                CleanForm();

            }
            catch
            {
                MessageBox.Show("Greška prilikom spremanja oglasa!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput(string naziv, string cijena, string lokacija, string kategorija)
        {
            if (ValidateNaziv(naziv) && ValidateCijena(cijena) && ValidateLokacija(lokacija) && ValidateKategorija(kategorija))
            {
                return true;
            }

            return false;
        }

        private bool ValidateKategorija(string kategorija)
        {
            if (string.IsNullOrEmpty(kategorija))
                return false;

            return true;
        }

        private bool ValidateLokacija(string lokacija)
        {
            if (string.IsNullOrEmpty(lokacija) || lokacija.Length>50)
                return false;

            return true;
        }

        private bool ValidateCijena(string cijena)
        {
            if (!decimal.TryParse(cijena, out decimal cijenaParsed))
                return false;

            if (cijenaParsed < 0)
                return false;

            return true;
        }

        private bool ValidateNaziv(string naziv)
        {
            if (string.IsNullOrEmpty(naziv) || naziv.Length>100)
                return false;

            return true;
        }

        private void SavePictures()
        {
            Oglas zadnjiOglas = oglasServices.GetOglas().ToList()[0];

            if (slike.Count>0)
            {
                foreach (var item in slike)
                {
                    Slike slika = new Slike
                    {
                        Oglas_id = zadnjiOglas.Id,
                        Slika = item
                    };

                    slikaServices.AddSlika(slika);
                }
            }
            /*else
            {
                Slike slika = new Slike
                {
                    Oglas_id = zadnjiOglas.Id,
                    Slika = ConvertToBytes()
                };

                slikaServices.AddSlika(slika);
            }*/
        }

        private void CleanForm()
        {
            txtNaziv.Text= "";
            richTextOpis.Text = "";
            txtCijena.Text= "";
            txtLokacija.Text = "";
            cmbKategorija.SelectedIndex = -1;
            pbOglas.Image = null;

            CleanProviders();
        }

        private void CleanProviders()
        {
            errorProvider.SetError(txtNaziv, null);
            correctProvider.SetError(txtNaziv, null);

            errorProvider.SetError(txtCijena, null);
            correctProvider.SetError(txtCijena, null);

            errorProvider.SetError(txtLokacija, null);
            correctProvider.SetError(txtLokacija, null);

            errorProvider.SetError(cmbKategorija, null);
            correctProvider.SetError(cmbKategorija, null);
        }

        private void btnOdbaci_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            bool valid = ValidateNaziv(txtNaziv.Text);
            if (!valid)
            {
                errorProvider.SetError(txtNaziv, "Naziv oglasa je obavezan i broj znakova mora biti manji ili jednak 100!");
                correctProvider.SetError(txtNaziv, null);
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
                correctProvider.SetError(txtNaziv, "Ispravno!");
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            bool valid = ValidateCijena(txtCijena.Text);
            if (!valid)
            {
                errorProvider.SetError(txtCijena, "Cijena oglasa je obavezna , mora biti pozitivan broj te u slučaju decimala sa zarezom!");
                correctProvider.SetError(txtCijena, null);
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
                correctProvider.SetError(txtCijena, "Ispravno!");
            }
        }

        private void txtLokacija_Validating(object sender, CancelEventArgs e)
        {
            bool valid = ValidateLokacija(txtLokacija.Text);
            if (!valid)
            {
                errorProvider.SetError(txtLokacija, "Lokacija je obavezna i smije sadržavati do 50 znakova");
                correctProvider.SetError(txtLokacija, null);
            }
            else
            {
                errorProvider.SetError(txtLokacija, null);
                correctProvider.SetError(txtLokacija, "Ispravno!");
            }
        }

        private void cmbKategorija_Validating(object sender, CancelEventArgs e)
        {
            bool valid = ValidateKategorija(cmbKategorija.Text);
            if (!valid)
            {
                errorProvider.SetError(cmbKategorija, "Kategorija je obavezna!");
                correctProvider.SetError(cmbKategorija, null);
            }
            else
            {
                errorProvider.SetError(cmbKategorija, null);
                correctProvider.SetError(cmbKategorija, "Ispravno!");
            }
        }
    }
}
