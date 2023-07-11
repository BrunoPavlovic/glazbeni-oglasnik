using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using GlazbeniOglasnik.UI;
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

namespace GlazbeniOglasnik
{
    public partial class FrmMain : Form
    {
        public Button currentButton;
        public Form currentForm;
        public bool isCurrentFormMain = true;
        public OglasServices oglasServices = new OglasServices();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != btnSender as Button)
                {
                    DisableButton();
                    currentButton = btnSender as Button;
                    currentButton.BackColor = Color.FromArgb(100, 204, 197);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in tablePanelIzbornik.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 28, 48);
                }
            }
        }

        public void LoadAnotherForm(Form frm, object sender, bool isMainForm)
        {
            if (currentForm!= null && isCurrentFormMain==false)
                currentForm.Close();

            ActivateButton(sender);

            if (isMainForm)
            {
                currentForm = this;
                isCurrentFormMain = true;
            }
            else 
            {
                currentForm = frm;
                isCurrentFormMain = false;

                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panelForm.Controls.Add(frm);
                panelForm.Tag = frm;
                panelForm.Height = frm.Height;
                panelForm.Width = frm.Width;
                frm.BringToFront();
                frm.Show();
            }

        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            LoadAnotherForm(new FrmMain(), sender, true);
            title.Text = "Početna";
        }

        private void btnPregledOglasa_Click(object sender, EventArgs e)
        {
            LoadAnotherForm(new UI.FrmPregledOglasa(), sender, false);
            title.Text = "Pregled oglasa";
        }

        private void btnNoviOglas_Click(object sender, EventArgs e)
        {
            LoadAnotherForm(new UI.FrmNoviOglas(), sender, false);
            title.Text = "Novi oglas";
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            LoadAnotherForm(new UI.FrmProfil(), sender, false);
            title.Text = "Profil";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ActivateButton(btnPocetna);
            LoadMostWantedOglas();
            HideAttributes();
            RenameDgvHeaders();
        }

        private void RenameDgvHeaders()
        {
            dgvNajtrazeniji.Columns["Naziv_oglasa"].HeaderText = "Naziv oglasa";
            dgvNajtrazeniji.Columns["Datum_objave"].HeaderText = "Datum objave";
        }

        private void HideAttributes()
        {
            dgvNajtrazeniji.Columns["Id"].Visible = false;
            dgvNajtrazeniji.Columns["Korisnik_id"].Visible = false;
            dgvNajtrazeniji.Columns["Korisnik"].Visible = false;
            dgvNajtrazeniji.Columns["Korisnik1"].Visible = false;
            dgvNajtrazeniji.Columns["Slike"].Visible = false;
            dgvNajtrazeniji.Columns["Prodano"].Visible = false;
            dgvNajtrazeniji.Columns["Opis"].Visible = false;
            dgvNajtrazeniji.Columns["Broj_pregleda"].Visible = false;
        }

        private void LoadMostWantedOglas()
        {
            dgvNajtrazeniji.DataSource = oglasServices.GetMostWantedOglas();
            dgvNajtrazeniji.Rows[0].Selected = false;
        }

        private void btnPregledOdabranog_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNajtrazeniji.CurrentRow != null)
                {
                    Oglas odabrani = dgvNajtrazeniji.CurrentRow.DataBoundItem as Oglas;
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
