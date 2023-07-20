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
    public partial class FrmLogin : Form
    {
        public KorisnikServices korisnikServices = new KorisnikServices();
        public LozinkaHash lozinkaHash = new LozinkaHash();
        public PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
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
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Show();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string lozinka = lozinkaHash.HashirajLozinku(txtLozinka.Text);
            Korisnik korisnik = korisnikServices.PrijaviKorisnika(txtKorime.Text, lozinka);

            if (korisnik!=null)
            {
                prijavljeniKorisnik.PrijaviKorisnika(korisnik);
                this.Close();

                frmMain.Refresh();
            }
            else
            {
                txtKorime.Text = "";
                txtLozinka.Text = "";

                MessageBox.Show("Neispravno korisničko ime ili lozinka!", "Pogrešni podaci" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
