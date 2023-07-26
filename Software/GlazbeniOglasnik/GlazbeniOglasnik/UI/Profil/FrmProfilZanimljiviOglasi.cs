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
        }

        private void ShowZanimljivi(int id)
        {
            var zanimljivi = zanimljiviOglasiServices.GetZanimljiviOglasiForUser(id);
            if (zanimljivi != null)
            {
                foreach (var item in zanimljivi)
                {
                    oglasi.Add(oglasServices.GetOglasById(item.Oglas_id));
                }

                dgvZanimljivi.DataSource = oglasi;
                new ManageDataGridView(dgvZanimljivi);
            }
        }
    }
}
