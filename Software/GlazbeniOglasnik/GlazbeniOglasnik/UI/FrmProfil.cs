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
    public partial class FrmProfil : Form
    {
        public Form currentForm;
        bool isSidebarExpand = true;
        public FrmProfil()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpand)
            {
                sidebarMenu.Width -= 10;
                if(sidebarMenu.Width == sidebarMenu.MinimumSize.Width)
                {
                    sidebarTimer.Stop();
                    isSidebarExpand = false;
                }
            }
            else
            {
                sidebarMenu.Width += 10;
                if (sidebarMenu.Width == sidebarMenu.MaximumSize.Width)
                {
                    sidebarTimer.Stop();
                    isSidebarExpand = true;
                }
            }
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        public void LoadAnotherForm(Form frm, object sender)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = frm;

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelProfilForm.Controls.Add(frm);
            panelProfilForm.Tag = frm;
            panelProfilForm.Height = frm.Height;
            panelProfilForm.Width = frm.Width;
            frm.BringToFront();
            frm.Show();

        }

        private void btnProfilPodaci_Click(object sender, EventArgs e)
        {
            LoadAnotherForm(new UI.Profil.FrmProfilPodaci(), sender);
        }

        private void btnMojiOglasi_Click(object sender, EventArgs e)
        {
            LoadAnotherForm(new UI.Profil.FrmProfilMojiOglasi(), sender);
        }

        private void btnZanimljiviOglasi_Click(object sender, EventArgs e)
        {
            LoadAnotherForm(new UI.Profil.FrmProfilZanimljiviOglasi(), sender);
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            LoadAnotherForm(new UI.Profil.FrmProfilPodaci(), sender);
        }
    }
}
