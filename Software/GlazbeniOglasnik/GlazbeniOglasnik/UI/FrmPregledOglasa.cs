﻿using BuisnessLogicLayer.Services;
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
    }
}
