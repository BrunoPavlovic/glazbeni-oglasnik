using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
using GlazbeniOglasnik.Helpers;
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
    public partial class FrmNoviOglas : Form
    {
        public SlikaServices slikaServices = new SlikaServices();
        public int brojac = 0;
        public List<byte[]> slike = new List<byte[]>();

        public FrmNoviOglas()
        {
            InitializeComponent();
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbOglas.SizeMode = PictureBoxSizeMode.Zoom;
                pbOglas.Image = Image.FromFile(openFileDialog.FileName);

                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pbOglas.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }

                slike.Add(imageBytes);
                brojac = slike.Count - 1;

                if (brojac > 0)
                {
                    btnBack.Enabled = true;
                }

                ShowPicture();
            }
        }

        private void ShowPicture()
        {
            if (slike.Count > 0 && brojac >= 0 && brojac < slike.Count)
            {
                pbOglas.SizeMode = PictureBoxSizeMode.Zoom;
                pbOglas.Image = Image.FromStream(new MemoryStream(slike[brojac]));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            brojac--;
            btnNext.Enabled = true;
            CheckIfFirst();
            ShowPicture();
        }

        private void CheckIfFirst()
        {
            if (brojac == 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            brojac++;
            btnBack.Enabled = true;
            CheckIfLast();
            ShowPicture();
        }

        private void CheckIfLast()
        {
            if (brojac == slike.Count - 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnObrisiSliku_Click(object sender, EventArgs e)
        {
            if (slike.Count > 0)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati odabranu sliku?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeletePicture();
                }
            }
            else
            {
                MessageBox.Show("Nema slika za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeletePicture()
        {
            slike.RemoveAt(brojac);
            brojac--;

            if (slike.Count == 0)
            {
                pbOglas.Image = null;
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
            else if (slike.Count == 1)
            {
                ShowPicture();
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                ShowPicture();
                CheckIfFirst();
                CheckIfLast();
            }
        }

        private void FrmNoviOglas_Load(object sender, EventArgs e)
        {
            if (PrijavljeniKorisnik.prijavljeniKorisnik != null)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
            }
        }
    }
}
