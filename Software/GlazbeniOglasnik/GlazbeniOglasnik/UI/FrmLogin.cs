using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using GlazbeniOglasnik.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazbeniOglasnik.UI
{
    public partial class FrmLogin : Form
    {
        public KorisnikServices korisnikServices = new KorisnikServices();
        public LozinkaHash lozinkaHash = new LozinkaHash();
        public PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
        public InputValidator inputValidator = new InputValidator();
        public FrmMain frmMain = new FrmMain();

        public FrmLogin(FrmMain frmMainCurrent)
        {
            InitializeComponent();
            this.frmMain = frmMainCurrent;
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistracija frmRegistracija = new FrmRegistracija();
            frmRegistracija.ShowDialog();

            this.Close();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Show();
            frmMain.CheckLoggedUser();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            bool isFormValid = ValidateForm(txtKorime.Text, txtLozinka.Text);
            if (isFormValid)
            {
                PrijavaKorisnika();
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke!");
            }
        }

        private void PrijavaKorisnika()
        {
            string lozinka = lozinkaHash.HashirajLozinku(txtLozinka.Text);
            Korisnik korisnik = korisnikServices.PrijaviKorisnika(txtKorime.Text, lozinka);

            if (korisnik != null)
            {
                prijavljeniKorisnik.PrijaviKorisnika(korisnik);
                MessageBox.Show("Uspješno ste se prijavili!", "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                frmMain.Refresh();
            }
            else
            {
                PostaviZastavice();

                MessageBox.Show("Neispravno korisničko ime ili lozinka!", "Pogrešni podaci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PostaviZastavice()
        {
            txtKorime.Text = "";
            txtLozinka.Text = "";

            errorProvider.SetError(txtLozinka, "Lozinka mora biti duža od 6 znakova!");
            errorProvider.SetError(txtKorime, "Korisničko ime mora biti u rasponu od 6-50 znakova!");
            correctProvider.SetError(txtKorime, null);
            correctProvider.SetError(txtLozinka, null);
        }

        private bool ValidateForm(string korime, string lozinka)
        {
            if (inputValidator.ValidateKorime(korime) && inputValidator.ValidateLozinka(lozinka))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtKorime_Validating(object sender, CancelEventArgs e)
        {
            bool valid = inputValidator.ValidateKorime(txtKorime.Text);
            if (!valid)
            {
                errorProvider.SetError(txtKorime, "Korisničko ime mora biti u rasponu od 6-50 znakova");
                correctProvider.SetError(txtKorime, null);
            }
            else
            {
                errorProvider.SetError(txtKorime, null);
                correctProvider.SetError(txtKorime, "Ispravno!");
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            bool valid = inputValidator.ValidateLozinka(txtLozinka.Text);
            if (!valid)
            {
                errorProvider.SetError(txtLozinka, "Lozinka mora biti duža od 6 znakova");
                correctProvider.SetError(txtLozinka, null);
            }
            else
            {
                errorProvider.SetError(txtLozinka, null);
                correctProvider.SetError(txtLozinka, "Ispravno!");
            }
        }
    }
}
