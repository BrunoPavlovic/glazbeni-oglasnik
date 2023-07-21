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
        public int brojac = 0;

        public FrmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            ValidateInput(txtIme.Text, txtPrezime.Text, txtKorime.Text, txtLozinka.Text, txtBrojTelefona.Text);
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

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();

            this.Close();
        }

        private bool ValidateInput(string ime, string prezime, string korime, string lozinka, string brojTelefona)
        {
            if (ValidateImePrezime(ime) && ValidateImePrezime(prezime) && ValidateKorime(korime) && ValidateLozinka(lozinka) && ValidateBrojTelefona(brojTelefona))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateBrojTelefona(string brojTelefona)
        {
            if (string.IsNullOrWhiteSpace(brojTelefona) || brojTelefona.Length < 9 || brojTelefona.Length > 13)
                return false;

            return Regex.IsMatch(brojTelefona, @"^\+?[0-9]+$");
        }

        private bool ValidateLozinka(string lozinka)
        {
            if (string.IsNullOrWhiteSpace(lozinka) || lozinka.Length < 6)
                return false;

            return true;
        }

        private bool ValidateKorime(string korime)
        {
            if (string.IsNullOrWhiteSpace(korime) || korime.Length < 6 || korime.Length > 50)
                return false;

            return true;
        }

        private bool ValidateImePrezime(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            return Regex.IsMatch(name, @"^[a-zA-Z]{1,50}$");
        }

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
