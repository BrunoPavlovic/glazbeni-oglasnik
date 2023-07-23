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

        public FrmPregledOglasa()
        {
            InitializeComponent();
        }

        private void FrmPregledOglasa_Load(object sender, EventArgs e)
        {
            var oglasi = oglasServices.GetOglas();
            dgvOglasi.DataSource = oglasi;
            LoadPictures(oglasi);
            new ManageDataGridView(dgvOglasi);
            cmbSortiraj.SelectedIndex = 1;
            cmbKategorija.SelectedIndex = 0;
        }

        private void LoadPictures(List<Oglas> oglasi)
        {
            int brojac = -1;
            try
            {
                foreach (var item in oglasi)
                {
                    brojac++;
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

                       // dgvOglasi.Rows[brojac].Cells[0].Value = image;
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
    }
}
