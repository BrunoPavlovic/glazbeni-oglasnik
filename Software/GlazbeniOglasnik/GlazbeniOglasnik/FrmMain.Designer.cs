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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.tablePanelIzbornik = new System.Windows.Forms.TableLayoutPanel();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnNoviOglas = new System.Windows.Forms.Button();
            this.btnPregledOglasa = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.btnPregledOdabranog = new System.Windows.Forms.Button();
            this.dgvNajtrazeniji = new System.Windows.Forms.DataGridView();
            this.labelOglasi = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.tablePanelIzbornik.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajtrazeniji)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.panelTitle.Controls.Add(this.title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(832, 52);
            this.panelTitle.TabIndex = 1;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(363, 9);
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
            this.tablePanelIzbornik.Size = new System.Drawing.Size(832, 75);
            this.tablePanelIzbornik.TabIndex = 2;
            // 
            // btnProfil
            // 
            this.btnProfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnProfil.Image")));
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(627, 3);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(202, 69);
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
            this.btnNoviOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviOglas.ForeColor = System.Drawing.Color.White;
            this.btnNoviOglas.Image = ((System.Drawing.Image)(resources.GetObject("btnNoviOglas.Image")));
            this.btnNoviOglas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoviOglas.Location = new System.Drawing.Point(419, 3);
            this.btnNoviOglas.Name = "btnNoviOglas";
            this.btnNoviOglas.Size = new System.Drawing.Size(202, 69);
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
            this.btnPregledOglasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledOglasa.ForeColor = System.Drawing.Color.White;
            this.btnPregledOglasa.Image = ((System.Drawing.Image)(resources.GetObject("btnPregledOglasa.Image")));
            this.btnPregledOglasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregledOglasa.Location = new System.Drawing.Point(211, 3);
            this.btnPregledOglasa.Name = "btnPregledOglasa";
            this.btnPregledOglasa.Size = new System.Drawing.Size(202, 69);
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
            this.btnPocetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetna.ForeColor = System.Drawing.Color.White;
            this.btnPocetna.Image = ((System.Drawing.Image)(resources.GetObject("btnPocetna.Image")));
            this.btnPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.Location = new System.Drawing.Point(3, 3);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(202, 69);
            this.btnPocetna.TabIndex = 0;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.labelOglasi);
            this.panelForm.Controls.Add(this.btnPregledOdabranog);
            this.panelForm.Controls.Add(this.dgvNajtrazeniji);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 127);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(832, 426);
            this.panelForm.TabIndex = 3;
            // 
            // btnPregledOdabranog
            // 
            this.btnPregledOdabranog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPregledOdabranog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnPregledOdabranog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPregledOdabranog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledOdabranog.ForeColor = System.Drawing.Color.White;
            this.btnPregledOdabranog.Location = new System.Drawing.Point(601, 374);
            this.btnPregledOdabranog.Name = "btnPregledOdabranog";
            this.btnPregledOdabranog.Size = new System.Drawing.Size(219, 40);
            this.btnPregledOdabranog.TabIndex = 1;
            this.btnPregledOdabranog.Text = "Pregled odabranog";
            this.btnPregledOdabranog.UseVisualStyleBackColor = false;
            // 
            // dgvNajtrazeniji
            // 
            this.dgvNajtrazeniji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNajtrazeniji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNajtrazeniji.Location = new System.Drawing.Point(26, 70);
            this.dgvNajtrazeniji.Name = "dgvNajtrazeniji";
            this.dgvNajtrazeniji.RowHeadersWidth = 51;
            this.dgvNajtrazeniji.RowTemplate.Height = 24;
            this.dgvNajtrazeniji.Size = new System.Drawing.Size(794, 261);
            this.dgvNajtrazeniji.TabIndex = 0;
            // 
            // labelOglasi
            // 
            this.labelOglasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOglasi.AutoSize = true;
            this.labelOglasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOglasi.ForeColor = System.Drawing.Color.White;
            this.labelOglasi.Location = new System.Drawing.Point(339, 32);
            this.labelOglasi.Name = "labelOglasi";
            this.labelOglasi.Size = new System.Drawing.Size(163, 25);
            this.labelOglasi.TabIndex = 6;
            this.labelOglasi.Text = "Najtraženiji oglasi";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.tablePanelIzbornik);
            this.Controls.Add(this.panelTitle);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glazbeni oglasnik";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvNajtrazeniji;
        private System.Windows.Forms.Button btnPregledOdabranog;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnNoviOglas;
        private System.Windows.Forms.Button btnPregledOglasa;
        private System.Windows.Forms.Label labelOglasi;
    }
}

