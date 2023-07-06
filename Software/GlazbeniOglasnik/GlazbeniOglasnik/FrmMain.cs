using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazbeniOglasnik
{
    public partial class FrmMain : Form
    {
        public Button currentButton;

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

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnPregledOglasa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnNoviOglas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ActivateButton(btnPocetna);
        }
    }
}
