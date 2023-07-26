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

        public FrmProfilPodaci()
        {
            InitializeComponent();
        }

        private void FrmProfilPodaci_Load(object sender, EventArgs e)
        {
            FillDetail();
        }

        private void FillDetail()
        {
            var korisnik = prijavljeniKorisnik.DohvatiPrijavljenogKorisnika();

            labelKorime.Text = korisnik.Korime;
            labelIme.Text = korisnik.Ime;
            labelPrezime.Text = korisnik.Prezime;
            labelTelefon.Text = korisnik.Broj_telefona;
        }
    }
}
