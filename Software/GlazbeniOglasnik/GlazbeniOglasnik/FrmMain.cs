using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using GlazbeniOglasnik.Helpers;
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
        public PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
        public SlikaServices slikaServices = new SlikaServices();
        public PictureLoader pictureLoader = new PictureLoader();
        private ManageDataGridView manageDataGridView;

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
            LoadPocetna(sender);
        }

        private void LoadPocetna(object sender)
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
            if (prijavljeniKorisnik.DohvatiPrijavljenogKorisnika() == null)
            {
                MessageBox.Show("Morate biti prijavljeni kako bi mogli kreirati oglas", "Kreiranje oglasa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin frmLogin = new FrmLogin(this);
                frmLogin.Show();

                this.Hide();
            }
            else
            {
                LoadAnotherForm(new UI.FrmNoviOglas(), sender, false);
                title.Text = "Novi oglas";
            }
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            if (prijavljeniKorisnik.DohvatiPrijavljenogKorisnika() == null)
            {
                MessageBox.Show("Morate biti prijavljeni kako bi mogli pristupiti profilu","Profil",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmLogin frmLogin = new FrmLogin(this);
                frmLogin.Show();

                this.Hide();
            }
            else
            {
                LoadAnotherForm(new UI.FrmProfil(), sender, false);
                title.Text = "Profil";
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ActivateButton(btnPocetna);
            LoadMostWantedOglas();
            manageDataGridView = new ManageDataGridView(dgvNajtrazeniji);
            CheckLoggedUser();
            dgvNajtrazeniji.Visible = true;
        }

        public void CheckLoggedUser()
        {
            if (prijavljeniKorisnik.DohvatiPrijavljenogKorisnika() == null)
            {
                pbLogIn.Visible = true;
                pbLogOut.Visible = false;
            }
            else
            {
                pbLogIn.Visible = false;
                pbLogOut.Visible = true;
            }
        }

        private void LoadMostWantedOglas()
        {
            dgvNajtrazeniji.DataSource = oglasServices.GetMostWantedOglas();
        }

        private void pbLogIn_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(this);
            frmLogin.Show();

            this.Hide();
        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            prijavljeniKorisnik.OdjaviKorisnika();
            LoadPocetna(btnPocetna);
            MessageBox.Show("Uspješno ste se odjavili!", "Odjava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CheckLoggedUser();
        }

        private void dgvNajtrazeniji_VisibleChanged(object sender, EventArgs e)
        {
            pictureLoader.LoadPictures(dgvNajtrazeniji.DataSource as List<Oglas>, dgvNajtrazeniji);
        }

        private void dgvNajtrazeniji_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (manageDataGridView != null)
            {
                manageDataGridView.CheckFormSize(dgvNajtrazeniji, this.WindowState == FormWindowState.Maximized);
            }
        }
    }
}
