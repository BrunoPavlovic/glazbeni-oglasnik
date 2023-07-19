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

        private void FrmRegistracija_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
