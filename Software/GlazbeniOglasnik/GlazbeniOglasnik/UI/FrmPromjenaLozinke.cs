using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using GlazbeniOglasnik.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazbeniOglasnik.UI
{
    public partial class FrmPromjenaLozinke : Form
    {
        public InputValidator inputValidator = new InputValidator();
        public PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
        public LozinkaHash lozinkaHash = new LozinkaHash();
        public KorisnikServices korisnikServices = new KorisnikServices();

        public FrmPromjenaLozinke()
        {
            InitializeComponent();
        }

        private void txtTrenutnaLozinka_Validating(object sender, CancelEventArgs e)
        {
            LozinkaValidation(txtTrenutnaLozinka);
        }

        private void LozinkaValidation(TextBox txtLozinka)
        {
            bool valid = inputValidator.ValidateLozinka(txtLozinka.Text);
            if (!valid)
            {
                errorProvider.SetError(txtLozinka, "Lozinka mora biti duža od 6 znakova!");
                correctProvider.SetError(txtLozinka, null);
            }
            else
            {
                errorProvider.SetError(txtLozinka, null);
                correctProvider.SetError(txtLozinka, "Ispravno!");
            }
        }

        private void txtNovaLozinka_Validating(object sender, CancelEventArgs e)
        {
            LozinkaValidation(txtNovaLozinka);
        }

        private void txtPonovnaLozinka_Validating(object sender, CancelEventArgs e)
        {
            LozinkaValidation(txtPonovnaLozinka);
        }

        private void btnPromijeniLozinku_Click(object sender, EventArgs e)
        {
            string staraLozinka = lozinkaHash.HashirajLozinku(txtTrenutnaLozinka.Text);
            var korisnik = korisnikServices.PrijaviKorisnika(prijavljeniKorisnik.DohvatiPrijavljenogKorisnika().Korime, staraLozinka);

            bool provjera = ProvjeriStaruLozinku(korisnik);
            bool isValid = ValidateForm(txtTrenutnaLozinka.Text, txtNovaLozinka.Text, txtPonovnaLozinka.Text);

            if (provjera && isValid)
            {
                if (txtNovaLozinka.Text == txtPonovnaLozinka.Text)
                {
                    SpremiNovuLozinku(korisnik);
                }
                else
                {
                    MessageBox.Show("Lozinke se ne podudaraju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CleanForm();
                }
            }
            else
            {
                MessageBox.Show("Unijeli ste krivu lozinku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanForm();
            }
        }

        private void CleanForm()
        {
            txtTrenutnaLozinka.Text = "";
            txtNovaLozinka.Text = "";
            txtPonovnaLozinka.Text = "";
        }

        private bool ValidateForm(string lozinka, string novaLozinka, string ponovljenaLozinka)
        {
            if (inputValidator.ValidateLozinka(lozinka)
                && inputValidator.ValidateLozinka(novaLozinka)
                && inputValidator.ValidateLozinka(ponovljenaLozinka))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ProvjeriStaruLozinku(Korisnik korisnik)
        {
            if (korisnik != null)
                return true;

            return false;
        }

        private void SpremiNovuLozinku(Korisnik korisnik)
        {
            string lozinka = lozinkaHash.HashirajLozinku(txtNovaLozinka.Text);
            korisnik.Lozinka = lozinka;

            korisnikServices.UpdateKorisnik(korisnik);
            MessageBox.Show("Uspješno ste promijenili lozinku!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
