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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GlazbeniOglasnik.UI
{
    public partial class FrmRegistracija : Form
    {
        public KorisnikServices korisnikServices = new KorisnikServices();
        public LozinkaHash lozinkaHash = new LozinkaHash();
        public InputValidator inputValidator = new InputValidator();
        public int brojac = 0;

        public FrmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateInput(txtIme.Text, txtPrezime.Text, txtKorime.Text, txtLozinka.Text, txtBrojTelefona.Text);
            if (isValid)
            {
                try
                {
                    RegistrirajKorisnika();

                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke!");
            }
        }

        private void RegistrirajKorisnika()
        {
            string lozinka = lozinkaHash.HashirajLozinku(txtLozinka.Text);

            Korisnik noviKorisnik = new Korisnik
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Korime = txtKorime.Text,
                Lozinka = lozinka,
                Broj_telefona = txtBrojTelefona.Text,
            };

            korisnikServices.AddKorisnik(noviKorisnik);
            MessageBox.Show("Uspješno ste se registrirali!");
        }

        private bool ValidateInput(string ime, string prezime, string korime, string lozinka, string brojTelefona)
        {
            if (inputValidator.ValidateImePrezime(ime) &&
                inputValidator.ValidateImePrezime(prezime) &&
                inputValidator.ValidateKorime(korime) &&
                inputValidator.ValidateLozinka(lozinka) && 
                inputValidator.ValidateBrojTelefona(brojTelefona))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            bool valid = inputValidator.ValidateImePrezime(txtIme.Text);
            if (!valid)
            {
                errorProvider.SetError(txtIme, "Ime mora sadržavati samo slova!");
                correctProvider.SetError(txtIme, null);
            }
            else
            {
                errorProvider.SetError(txtIme, null);
                correctProvider.SetError(txtIme, "Ispravno!");
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            bool valid = inputValidator.ValidateImePrezime(txtPrezime.Text);
            if (!valid)
            {
                errorProvider.SetError(txtPrezime, "Prezime mora sadržavati samo slova!");
                correctProvider.SetError(txtPrezime, null);
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
                correctProvider.SetError(txtPrezime, "Ispravno!");
            }
        }

        private void txtBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            bool valid = inputValidator.ValidateBrojTelefona(txtBrojTelefona.Text);
            if (!valid)
            {
                errorProvider.SetError(txtBrojTelefona, "Broj telefona mora biti u ispravnom formatu (npr. +385XXXXXXXXX ili 0XXXXXXXXX)!");
                correctProvider.SetError(txtBrojTelefona, null);
            }
            else
            {
                errorProvider.SetError(txtBrojTelefona, null);
                correctProvider.SetError(txtBrojTelefona, "Ispravno!");
            }
        }

        private void txtKorime_Validating(object sender, CancelEventArgs e)
        {
            bool valid = inputValidator.ValidateKorime(txtKorime.Text);
            if (!valid)
            {
                errorProvider.SetError(txtKorime, "Korisničko ime mora biti u rasponu od 6-50 znakova!");
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
                errorProvider.SetError(txtLozinka, "Lozinka mora biti duža od 6 znakova!");
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
