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

namespace GlazbeniOglasnik.UI.Profil
{
    public partial class FrmProfilPodaci : Form
    {
        public PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
        public Korisnik korisnik = new Korisnik();

        public FrmProfilPodaci()
        {
            InitializeComponent();
            korisnik = prijavljeniKorisnik.DohvatiPrijavljenogKorisnika();
        }

        public FrmProfilPodaci(Korisnik korisnikProdavatelj)
        {
            InitializeComponent();
            korisnik = korisnikProdavatelj;

            btnUrediProfil.Visible = false;
            btnPromijeniLozinku.Visible = false;
            this.Width = 400;
            this.Height = 400;
        }

        private void FrmProfilPodaci_Load(object sender, EventArgs e)
        {
            FillDetail(korisnik);
        }

        private void FillDetail(Korisnik korisnik)
        {

            labelKorime.Text = korisnik.Korime;
            labelIme.Text = korisnik.Ime;
            labelPrezime.Text = korisnik.Prezime;
            labelTelefon.Text = korisnik.Broj_telefona;
        }

        private void btnUrediProfil_Click(object sender, EventArgs e)
        {
            FrmRegistracija frmRegistracija = new FrmRegistracija(korisnik);
            frmRegistracija.ShowDialog();

            korisnik = prijavljeniKorisnik.DohvatiPrijavljenogKorisnika();
            FillDetail(korisnik);
        }

        private void btnPromijeniLozinku_Click(object sender, EventArgs e)
        {
            FrmPromjenaLozinke frmPromjenaLozinke = new FrmPromjenaLozinke();
            frmPromjenaLozinke.ShowDialog();
        }
    }
}
