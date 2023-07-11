using EntitiesLayer.Entities;
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
    public partial class FrmPregledOdabranog : Form
    {
        public Oglas oglas;

        public FrmPregledOdabranog(Oglas odabraniOglas)
        {
            InitializeComponent();
            this.oglas = odabraniOglas;
        }

        private void pictureBoxUnchecked_Click(object sender, EventArgs e)
        {
            pictureBoxUnchecked.Visible = false;
            pictureBoxChecked.Visible = true;
        }

        private void pictureBoxChecked_Click(object sender, EventArgs e)
        {
            pictureBoxChecked.Visible = false;
            pictureBoxUnchecked.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPregledOdabranog_Load(object sender, EventArgs e)
        {
            FillDetail();
        }

        private void FillDetail()
        {
            title.Text = oglas.Naziv_oglasa;
            richTextOpis.Text = oglas.Opis;
            txtLokacija.Text = oglas.Lokacija;
            labelCijena.Text = oglas.Cijena.ToString() + "$";
            labelBrojPregleda.Text = oglas.Broj_pregleda.ToString();
            labelKorime.Text = oglas.Korisnik.Korime;
        }
    }
}
