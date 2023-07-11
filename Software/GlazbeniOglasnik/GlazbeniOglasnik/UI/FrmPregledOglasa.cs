using BuisnessLogicLayer.Services;
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
    public partial class FrmPregledOglasa : Form
    {
        public OglasServices oglasServices = new OglasServices();

        public FrmPregledOglasa()
        {
            InitializeComponent();
        }

        private void FrmPregledOglasa_Load(object sender, EventArgs e)
        {
            dgvOglasi.DataSource = oglasServices.GetOglas();
            new ManageDataGridView(dgvOglasi);
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
