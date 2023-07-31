namespace GlazbeniOglasnik
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pbLogOut = new System.Windows.Forms.PictureBox();
            this.pbLogIn = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.tablePanelIzbornik = new System.Windows.Forms.TableLayoutPanel();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnNoviOglas = new System.Windows.Forms.Button();
            this.btnPregledOglasa = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.dgvNajtrazeniji = new System.Windows.Forms.DataGridView();
            this.SlikeOglasa = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelOglasi = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogIn)).BeginInit();
            this.tablePanelIzbornik.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajtrazeniji)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.panelTitle.Controls.Add(this.pbLogOut);
            this.panelTitle.Controls.Add(this.pbLogIn);
            this.panelTitle.Controls.Add(this.title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1262, 52);
            this.panelTitle.TabIndex = 1;
            // 
            // pbLogOut
            // 
            this.pbLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogOut.Image = ((System.Drawing.Image)(resources.GetObject("pbLogOut.Image")));
            this.pbLogOut.Location = new System.Drawing.Point(1162, 0);
            this.pbLogOut.Name = "pbLogOut";
            this.pbLogOut.Size = new System.Drawing.Size(100, 50);
            this.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogOut.TabIndex = 2;
            this.pbLogOut.TabStop = false;
            this.pbLogOut.Visible = false;
            this.pbLogOut.Click += new System.EventHandler(this.pbLogOut_Click);
            // 
            // pbLogIn
            // 
            this.pbLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbLogIn.Image = ((System.Drawing.Image)(resources.GetObject("pbLogIn.Image")));
            this.pbLogIn.Location = new System.Drawing.Point(1162, 0);
            this.pbLogIn.Name = "pbLogIn";
            this.pbLogIn.Size = new System.Drawing.Size(100, 52);
            this.pbLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogIn.TabIndex = 1;
            this.pbLogIn.TabStop = false;
            this.pbLogIn.Click += new System.EventHandler(this.pbLogIn_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(578, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(113, 29);
            this.title.TabIndex = 0;
            this.title.Text = "Početna";
            // 
            // tablePanelIzbornik
            // 
            this.tablePanelIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.tablePanelIzbornik.ColumnCount = 4;
            this.tablePanelIzbornik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelIzbornik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelIzbornik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelIzbornik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanelIzbornik.Controls.Add(this.btnProfil, 3, 0);
            this.tablePanelIzbornik.Controls.Add(this.btnNoviOglas, 2, 0);
            this.tablePanelIzbornik.Controls.Add(this.btnPregledOglasa, 1, 0);
            this.tablePanelIzbornik.Controls.Add(this.btnPocetna, 0, 0);
            this.tablePanelIzbornik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablePanelIzbornik.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanelIzbornik.Location = new System.Drawing.Point(0, 52);
            this.tablePanelIzbornik.Name = "tablePanelIzbornik";
            this.tablePanelIzbornik.RowCount = 1;
            this.tablePanelIzbornik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelIzbornik.Size = new System.Drawing.Size(1262, 75);
            this.tablePanelIzbornik.TabIndex = 2;
            // 
            // btnProfil
            // 
            this.btnProfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnProfil.Image")));
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(948, 3);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(311, 69);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnNoviOglas
            // 
            this.btnNoviOglas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNoviOglas.FlatAppearance.BorderSize = 0;
            this.btnNoviOglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviOglas.ForeColor = System.Drawing.Color.White;
            this.btnNoviOglas.Image = ((System.Drawing.Image)(resources.GetObject("btnNoviOglas.Image")));
            this.btnNoviOglas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviOglas.Location = new System.Drawing.Point(633, 3);
            this.btnNoviOglas.Name = "btnNoviOglas";
            this.btnNoviOglas.Size = new System.Drawing.Size(309, 69);
            this.btnNoviOglas.TabIndex = 2;
            this.btnNoviOglas.Text = "Novi oglas";
            this.btnNoviOglas.UseVisualStyleBackColor = true;
            this.btnNoviOglas.Click += new System.EventHandler(this.btnNoviOglas_Click);
            // 
            // btnPregledOglasa
            // 
            this.btnPregledOglasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPregledOglasa.FlatAppearance.BorderSize = 0;
            this.btnPregledOglasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledOglasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledOglasa.ForeColor = System.Drawing.Color.White;
            this.btnPregledOglasa.Image = ((System.Drawing.Image)(resources.GetObject("btnPregledOglasa.Image")));
            this.btnPregledOglasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregledOglasa.Location = new System.Drawing.Point(318, 3);
            this.btnPregledOglasa.Name = "btnPregledOglasa";
            this.btnPregledOglasa.Size = new System.Drawing.Size(309, 69);
            this.btnPregledOglasa.TabIndex = 1;
            this.btnPregledOglasa.Text = "Pregled oglasa";
            this.btnPregledOglasa.UseVisualStyleBackColor = true;
            this.btnPregledOglasa.Click += new System.EventHandler(this.btnPregledOglasa_Click);
            // 
            // btnPocetna
            // 
            this.btnPocetna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.Color.White;
            this.btnPocetna.Image = ((System.Drawing.Image)(resources.GetObject("btnPocetna.Image")));
            this.btnPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.Location = new System.Drawing.Point(3, 3);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(309, 69);
            this.btnPocetna.TabIndex = 0;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.dgvNajtrazeniji);
            this.panelForm.Controls.Add(this.labelOglasi);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 127);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1262, 546);
            this.panelForm.TabIndex = 3;
            // 
            // dgvNajtrazeniji
            // 
            this.dgvNajtrazeniji.AllowUserToAddRows = false;
            this.dgvNajtrazeniji.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNajtrazeniji.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNajtrazeniji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNajtrazeniji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNajtrazeniji.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.dgvNajtrazeniji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNajtrazeniji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNajtrazeniji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNajtrazeniji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlikeOglasa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNajtrazeniji.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNajtrazeniji.EnableHeadersVisualStyles = false;
            this.dgvNajtrazeniji.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.dgvNajtrazeniji.Location = new System.Drawing.Point(85, 122);
            this.dgvNajtrazeniji.MultiSelect = false;
            this.dgvNajtrazeniji.Name = "dgvNajtrazeniji";
            this.dgvNajtrazeniji.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNajtrazeniji.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNajtrazeniji.RowHeadersVisible = false;
            this.dgvNajtrazeniji.RowHeadersWidth = 51;
            this.dgvNajtrazeniji.RowTemplate.Height = 50;
            this.dgvNajtrazeniji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNajtrazeniji.Size = new System.Drawing.Size(1098, 400);
            this.dgvNajtrazeniji.TabIndex = 9;
            this.dgvNajtrazeniji.Visible = false;
            this.dgvNajtrazeniji.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNajtrazeniji_CellDoubleClick);
            this.dgvNajtrazeniji.VisibleChanged += new System.EventHandler(this.dgvNajtrazeniji_VisibleChanged);
            // 
            // SlikeOglasa
            // 
            this.SlikeOglasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SlikeOglasa.HeaderText = "Slika oglasa";
            this.SlikeOglasa.Image = ((System.Drawing.Image)(resources.GetObject("SlikeOglasa.Image")));
            this.SlikeOglasa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.SlikeOglasa.MinimumWidth = 6;
            this.SlikeOglasa.Name = "SlikeOglasa";
            this.SlikeOglasa.ReadOnly = true;
            this.SlikeOglasa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // labelOglasi
            // 
            this.labelOglasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOglasi.AutoSize = true;
            this.labelOglasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOglasi.ForeColor = System.Drawing.Color.White;
            this.labelOglasi.Location = new System.Drawing.Point(553, 25);
            this.labelOglasi.Name = "labelOglasi";
            this.labelOglasi.Size = new System.Drawing.Size(223, 29);
            this.labelOglasi.TabIndex = 6;
            this.labelOglasi.Text = "Najtraženiji oglasi";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.tablePanelIzbornik);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glazbeni oglasnik";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogIn)).EndInit();
            this.tablePanelIzbornik.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajtrazeniji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TableLayoutPanel tablePanelIzbornik;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnNoviOglas;
        private System.Windows.Forms.Button btnPregledOglasa;
        private System.Windows.Forms.Label labelOglasi;
        private System.Windows.Forms.DataGridView dgvNajtrazeniji;
        private System.Windows.Forms.DataGridViewImageColumn SlikeOglasa;
        private System.Windows.Forms.PictureBox pbLogIn;
        private System.Windows.Forms.PictureBox pbLogOut;
    }
}

