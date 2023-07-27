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
    public partial class FrmProfilZanimljiviOglasi : Form
    {
        public ZanimljiviOglasiServices zanimljiviOglasiServices = new ZanimljiviOglasiServices();
        public OglasServices oglasServices = new OglasServices();
        public PrijavljeniKorisnik prijavljeniKorisnik = new PrijavljeniKorisnik();
        public PictureLoader pictureLoader = new PictureLoader();
        public Korisnik korisnik = new Korisnik();
        public List<Oglas> oglasi = new List<Oglas>();


        public FrmProfilZanimljiviOglasi()
        {
            InitializeComponent();
        }

        private void FrmProfilZanimljiviOglasi_Load(object sender, EventArgs e)
        {
            korisnik = prijavljeniKorisnik.DohvatiPrijavljenogKorisnika();
            ShowZanimljivi(korisnik.Id);

            dgvZanimljivi.Visible = true;
        }

        private void ShowZanimljivi(int korisnikId)
        {
            var zanimljivi = zanimljiviOglasiServices.GetZanimljiviOglasiForUser(korisnikId);
            if (zanimljivi != null)
            {
                foreach (var item in zanimljivi)
                {
                    oglasi.Add(oglasServices.GetOglasById(item.Oglas_id));
                }

                if (oglasi.Count == 0)
                {
                    SetVisibility();
                    return;
                }

                dgvZanimljivi.DataSource = oglasi;
                new ManageDataGridView(dgvZanimljivi);
            }
        }

        private void SetVisibility()
        {
            btnObrisiZanimljivi.Visible = false;
            btnPregledOdabranog.Visible = false;
            labelObavijest.Visible = true;
        }

        private void btnObrisiZanimljivi_Click(object sender, EventArgs e)
        {
            var oglas = dgvZanimljivi.CurrentRow.DataBoundItem as Oglas;
            if (oglas != null)
            {
                RemoveZanimljivi(oglas);
            }
            else
            {
                MessageBox.Show("Niste odabrali zanimljivi oglas!","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void RemoveZanimljivi(Oglas oglas)
        {
            var zanimljiviOglas = new Zanimljivi_oglasi
            {
                Korisnik_id = korisnik.Id,
                Oglas_id = oglas.Id
            };

            zanimljiviOglasiServices.RemoveZanimljiviOglas(zanimljiviOglas);

            MessageBox.Show("Uspješno ste uklonili zanimljivi oglas!", "Brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshZanimljivi();
        }

        private void RefreshZanimljivi()
        {
            oglasi.Clear();
            dgvZanimljivi.DataSource = null;

            ShowZanimljivi(korisnik.Id);
            pictureLoader.LoadPictures(dgvZanimljivi.DataSource as List<Oglas>, dgvZanimljivi);
        }

        private void btnPregledOdabranog_Click(object sender, EventArgs e)
        {
            if (dgvZanimljivi.CurrentRow != null)
            {
                Oglas odabrani = dgvZanimljivi.CurrentRow.DataBoundItem as Oglas;
                if (odabrani != null)
                {
                    odabrani.Broj_pregleda = odabrani.Broj_pregleda + 1;
                    oglasServices.UpdateOglasView(odabrani);
                }

                FrmPregledOdabranog frmPregledOdabranog = new FrmPregledOdabranog(odabrani);
                frmPregledOdabranog.ShowDialog();

                RefreshZanimljivi();
            }
            else
            {
                MessageBox.Show("Odaberite oglas!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvZanimljivi_VisibleChanged(object sender, EventArgs e)
        {
            pictureLoader.LoadPictures(dgvZanimljivi.DataSource as List<Oglas>, dgvZanimljivi);
        }
    }
}
