using BuisnessLogicLayer.Services;
using EntitiesLayer.Entities;
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
    public partial class FrmProfilMojiOglasi : Form
    {
        public OglasServices oglasServices = new OglasServices();
        public SlikaServices slikaServices = new SlikaServices();
        public PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
        public PictureLoader pictureLoader = new PictureLoader();
        public Korisnik korisnik = new Korisnik();
        public ManageDataGridView manageDataGridView;

        public FrmProfilMojiOglasi()
        {
            InitializeComponent();
        }

        private void FrmProfilMojiOglasi_Load(object sender, EventArgs e)
        {
            korisnik = prijavljeniKorisnik.DohvatiPrijavljenogKorisnika();
            SetData();
        }

        private void SetData()
        {
            dgvMojiOglasi.DataSource = oglasServices.GetOglasForKorisnik(korisnik.Id);
            manageDataGridView = new ManageDataGridView(dgvMojiOglasi);
            CheckData();
        }

        private void CheckData()
        {
            if (dgvMojiOglasi.Rows.Count == 0)
            {
                SetVisibility();
                return;
            }

            dgvMojiOglasi.Visible = true;
        }

        private void SetVisibility()
        {
            btnObrisiOglas.Visible = false;
            btnUrediOglas.Visible = false;

            labelObavijest.Visible = true;
        }

        private void btnObrisiOglas_Click(object sender, EventArgs e)
        {
            var oglas = dgvMojiOglasi.CurrentRow.DataBoundItem as Oglas;
            if (oglas != null)
            {
                RemovePicturesForOglas(oglas.Id);
                RemoveMyOglas(oglas);
            }
            else
            {
                MessageBox.Show("Niste odabrali oglas za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemovePicturesForOglas(int id)
        {
            var slikeOglasa = slikaServices.GetSlikeForOglas(id);
            foreach (var slika in slikeOglasa)
            {
                slikaServices.RemoveSlika(slika);
            }
        }

        private void RemoveMyOglas(Oglas oglas)
        {
            oglasServices.RemoveOglas(oglas);

            dgvMojiOglasi.Visible = false;
            SetData();
        }

        private void btnUrediOglas_Click(object sender, EventArgs e)
        {
            if (dgvMojiOglasi.CurrentRow != null)
            {
                Oglas odabrani = dgvMojiOglasi.CurrentRow.DataBoundItem as Oglas;

                FrmNoviOglas frmNovi = new FrmNoviOglas(odabrani);
                frmNovi.ShowDialog();

                dgvMojiOglasi.Visible = false;
                SetData();
            }
            else
            {
                MessageBox.Show("Odaberite oglas za uređivanje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMojiOglasi_VisibleChanged(object sender, EventArgs e)
        {
            pictureLoader.LoadPictures(dgvMojiOglasi.DataSource as List<Oglas>, dgvMojiOglasi);
        }

        private void dgvMojiOglasi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMojiOglasi.CurrentRow != null)
            {
                Oglas odabrani = dgvMojiOglasi.CurrentRow.DataBoundItem as Oglas;

                FrmPregledOdabranog frmPregledOdabranog = new FrmPregledOdabranog(odabrani);
                frmPregledOdabranog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Odaberite oglas!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProfilMojiOglasi_Resize(object sender, EventArgs e)
        {
            manageDataGridView?.CheckFormSize(dgvMojiOglasi, FrmMain.ActiveForm.WindowState == FormWindowState.Maximized);
        }
    }
}
