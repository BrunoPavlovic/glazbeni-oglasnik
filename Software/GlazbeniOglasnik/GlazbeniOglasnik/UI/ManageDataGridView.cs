using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazbeniOglasnik.UI
{
    public class ManageDataGridView
    {
        public DataGridView dgv { get; set; }

        public ManageDataGridView(DataGridView dataGridView)
        {
            this.dgv = dataGridView;
            RenameDgvHeaders();
            HideAttributes();

            if (dgv.Rows.Count > 0)
            {
                dgv.Rows[0].Selected = false;
            }
            
            dgv.Columns["Naziv_oglasa"].Width = 130;
            dgv.Columns["Cijena"].Width = 65;
        }

        private void RenameDgvHeaders()
        {
            dgv.Columns["Naziv_oglasa"].HeaderText = "Naziv oglasa";
            dgv.Columns["Datum_objave"].HeaderText = "Datum objave";
        }

        private void HideAttributes()
        {
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Korisnik_id"].Visible = false;
            dgv.Columns["Korisnik"].Visible = false;
            dgv.Columns["Korisnik1"].Visible = false;
            dgv.Columns["Slike"].Visible = false;
            dgv.Columns["Prodano"].Visible = false;
            dgv.Columns["Opis"].Visible = false;
            dgv.Columns["Broj_pregleda"].Visible = false;
        }
    }
}
