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

namespace GlazbeniOglasnik.UI
{
    public partial class FrmPregledOglasa : Form
    {
        public OglasServices oglasServices = new OglasServices();
        public SlikaServices slikaServices = new SlikaServices();
        public bool isEverythingSelected = false;

        public FrmPregledOglasa()
        {
            InitializeComponent();
        }

        private void FrmPregledOglasa_Load(object sender, EventArgs e)
        {
            dgvOglasi.DataSource = oglasServices.GetOglas();
            new ManageDataGridView(dgvOglasi);

            dgvOglasi.Visible = true;
            cmbSortiraj.SelectedIndex = 0;
            cmbKategorija.SelectedIndex = 0;
        }

        private void LoadPictures(List<Oglas> oglasi)
        {
            int brojac = -1;
            try
            {
                List<int> slikeOglasId = slikaServices.GetSlikaOglasId();
                foreach (var item in oglasi)
                {
                    brojac++;
                    if (slikeOglasId.Contains(item.Id))
                    {
                        var slikeOglasa = slikaServices.GetSlikeForOglas(item.Id);
                        if (slikeOglasa.Count > 0)
                        {
                            Slike slika = slikeOglasa[0];
                            byte[] imageBytes = slika.Slika;

                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }

                            dgvOglasi.Rows[brojac].Cells[0].Value = image;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPregledOdabranog_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOglasi.CurrentRow != null)
                {
                    Oglas odabrani = dgvOglasi.CurrentRow.DataBoundItem as Oglas;
                    if (odabrani != null)
                    {
                        odabrani.Broj_pregleda = odabrani.Broj_pregleda + 1;
                        oglasServices.UpdateOglasView(odabrani);
                    }

                    FrmPregledOdabranog frmPregledOdabranog = new FrmPregledOdabranog(odabrani);
                    frmPregledOdabranog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Odaberite jedan oglas!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOglasi_VisibleChanged(object sender, EventArgs e)
        {
            LoadPictures(dgvOglasi.DataSource as List<Oglas>);
        }

        private void cmbSortiraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEverythingSelected)
            {
                txtSearch.Text = "";

                dgvOglasi.DataSource = oglasServices.FilterOglas(cmbSortiraj.SelectedItem.ToString(), cmbKategorija.SelectedItem.ToString());
                new ManageDataGridView(dgvOglasi);
                LoadPictures(dgvOglasi.DataSource as List<Oglas>);
            }
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEverythingSelected)
            {
                txtSearch.Text = "";
                dgvOglasi.DataSource = oglasServices.FilterOglas(cmbSortiraj.SelectedItem.ToString(), cmbKategorija.SelectedItem.ToString());
                new ManageDataGridView(dgvOglasi);
                LoadPictures(dgvOglasi.DataSource as List<Oglas>);
            }
            else
                isEverythingSelected = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvOglasi.DataSource = oglasServices.SearchOglas(txtSearch.Text);

            cmbKategorija.SelectedIndex = 0;
            cmbSortiraj.SelectedIndex = 0;

            if (dgvOglasi.Rows.Count == 0)
            {
                txtSearch.Text = "";
                MessageBox.Show("Ne postoji oglas koji sadrži pretraženu frazu!","Upozorenje",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new ManageDataGridView(dgvOglasi);
                LoadPictures(dgvOglasi.DataSource as List<Oglas>);
            }
        }
    }
}
