namespace GlazbeniOglasnik.UI
{
    partial class FrmPregledOdabranog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledOdabranog));
            this.panelNaslov = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panelDetalji = new System.Windows.Forms.Panel();
            this.pictureBoxCijena = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrojPregleda = new System.Windows.Forms.PictureBox();
            this.pictureBoxChecked = new System.Windows.Forms.PictureBox();
            this.pictureBoxUnchecked = new System.Windows.Forms.PictureBox();
            this.labelBrojPregleda = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.richTextOpis = new System.Windows.Forms.RichTextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelLokacija = new System.Windows.Forms.Label();
            this.labelKorime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbOglas = new System.Windows.Forms.PictureBox();
            this.panelNaslov.SuspendLayout();
            this.panelDetalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrojPregleda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnchecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOglas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNaslov
            // 
            this.panelNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.panelNaslov.Controls.Add(this.btnClose);
            this.panelNaslov.Controls.Add(this.title);
            this.panelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNaslov.Location = new System.Drawing.Point(0, 0);
            this.panelNaslov.Name = "panelNaslov";
            this.panelNaslov.Size = new System.Drawing.Size(1280, 81);
            this.panelNaslov.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1180, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 63);
            this.btnClose.TabIndex = 36;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(551, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(171, 29);
            this.title.TabIndex = 1;
            this.title.Text = "Naziv oglasa";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDetalji
            // 
            this.panelDetalji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panelDetalji.Controls.Add(this.pictureBoxCijena);
            this.panelDetalji.Controls.Add(this.pictureBoxBrojPregleda);
            this.panelDetalji.Controls.Add(this.pictureBoxChecked);
            this.panelDetalji.Controls.Add(this.pictureBoxUnchecked);
            this.panelDetalji.Controls.Add(this.labelBrojPregleda);
            this.panelDetalji.Controls.Add(this.labelCijena);
            this.panelDetalji.Controls.Add(this.richTextOpis);
            this.panelDetalji.Controls.Add(this.txtLokacija);
            this.panelDetalji.Controls.Add(this.labelOpis);
            this.panelDetalji.Controls.Add(this.labelLokacija);
            this.panelDetalji.Controls.Add(this.labelKorime);
            this.panelDetalji.Controls.Add(this.pictureBox2);
            this.panelDetalji.Controls.Add(this.btnNext);
            this.panelDetalji.Controls.Add(this.btnBack);
            this.panelDetalji.Controls.Add(this.pbOglas);
            this.panelDetalji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalji.Location = new System.Drawing.Point(0, 81);
            this.panelDetalji.Name = "panelDetalji";
            this.panelDetalji.Size = new System.Drawing.Size(1280, 639);
            this.panelDetalji.TabIndex = 1;
            // 
            // pictureBoxCijena
            // 
            this.pictureBoxCijena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCijena.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCijena.Image")));
            this.pictureBoxCijena.Location = new System.Drawing.Point(504, 251);
            this.pictureBoxCijena.Name = "pictureBoxCijena";
            this.pictureBoxCijena.Size = new System.Drawing.Size(45, 54);
            this.pictureBoxCijena.TabIndex = 35;
            this.pictureBoxCijena.TabStop = false;
            // 
            // pictureBoxBrojPregleda
            // 
            this.pictureBoxBrojPregleda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBrojPregleda.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBrojPregleda.Image")));
            this.pictureBoxBrojPregleda.Location = new System.Drawing.Point(511, 190);
            this.pictureBoxBrojPregleda.Name = "pictureBoxBrojPregleda";
            this.pictureBoxBrojPregleda.Size = new System.Drawing.Size(38, 41);
            this.pictureBoxBrojPregleda.TabIndex = 34;
            this.pictureBoxBrojPregleda.TabStop = false;
            // 
            // pictureBoxChecked
            // 
            this.pictureBoxChecked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxChecked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxChecked.Image")));
            this.pictureBoxChecked.Location = new System.Drawing.Point(1230, 574);
            this.pictureBoxChecked.Name = "pictureBoxChecked";
            this.pictureBoxChecked.Size = new System.Drawing.Size(38, 41);
            this.pictureBoxChecked.TabIndex = 33;
            this.pictureBoxChecked.TabStop = false;
            this.pictureBoxChecked.Visible = false;
            this.pictureBoxChecked.Click += new System.EventHandler(this.pictureBoxChecked_Click);
            // 
            // pictureBoxUnchecked
            // 
            this.pictureBoxUnchecked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxUnchecked.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnchecked.Image")));
            this.pictureBoxUnchecked.Location = new System.Drawing.Point(1230, 574);
            this.pictureBoxUnchecked.Name = "pictureBoxUnchecked";
            this.pictureBoxUnchecked.Size = new System.Drawing.Size(38, 41);
            this.pictureBoxUnchecked.TabIndex = 32;
            this.pictureBoxUnchecked.TabStop = false;
            this.pictureBoxUnchecked.Click += new System.EventHandler(this.pictureBoxUnchecked_Click);
            // 
            // labelBrojPregleda
            // 
            this.labelBrojPregleda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBrojPregleda.AutoSize = true;
            this.labelBrojPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBrojPregleda.ForeColor = System.Drawing.Color.White;
            this.labelBrojPregleda.Location = new System.Drawing.Point(555, 190);
            this.labelBrojPregleda.Name = "labelBrojPregleda";
            this.labelBrojPregleda.Size = new System.Drawing.Size(126, 25);
            this.labelBrojPregleda.TabIndex = 31;
            this.labelBrojPregleda.Text = "112 pregleda";
            // 
            // labelCijena
            // 
            this.labelCijena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCijena.AutoSize = true;
            this.labelCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCijena.ForeColor = System.Drawing.Color.White;
            this.labelCijena.Location = new System.Drawing.Point(555, 251);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(69, 29);
            this.labelCijena.TabIndex = 30;
            this.labelCijena.Text = "112$";
            // 
            // richTextOpis
            // 
            this.richTextOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextOpis.Location = new System.Drawing.Point(556, 31);
            this.richTextOpis.Name = "richTextOpis";
            this.richTextOpis.Size = new System.Drawing.Size(641, 57);
            this.richTextOpis.TabIndex = 29;
            this.richTextOpis.Text = "";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLokacija.Location = new System.Drawing.Point(556, 128);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(236, 27);
            this.txtLokacija.TabIndex = 28;
            // 
            // labelOpis
            // 
            this.labelOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOpis.ForeColor = System.Drawing.Color.White;
            this.labelOpis.Location = new System.Drawing.Point(349, 31);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(190, 25);
            this.labelOpis.TabIndex = 27;
            this.labelOpis.Text = "Dodatne informacije:";
            // 
            // labelLokacija
            // 
            this.labelLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLokacija.AutoSize = true;
            this.labelLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLokacija.ForeColor = System.Drawing.Color.White;
            this.labelLokacija.Location = new System.Drawing.Point(449, 130);
            this.labelLokacija.Name = "labelLokacija";
            this.labelLokacija.Size = new System.Drawing.Size(90, 25);
            this.labelLokacija.TabIndex = 26;
            this.labelLokacija.Text = "Lokacija:";
            // 
            // labelKorime
            // 
            this.labelKorime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKorime.AutoSize = true;
            this.labelKorime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorime.ForeColor = System.Drawing.Color.White;
            this.labelKorime.Location = new System.Drawing.Point(584, 567);
            this.labelKorime.Name = "labelKorime";
            this.labelKorime.Size = new System.Drawing.Size(97, 29);
            this.labelKorime.TabIndex = 25;
            this.labelKorime.Text = "Korime";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(537, 567);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(208, 286);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 30);
            this.btnNext.TabIndex = 23;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(152, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 30);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbOglas
            // 
            this.pbOglas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbOglas.Image = ((System.Drawing.Image)(resources.GetObject("pbOglas.Image")));
            this.pbOglas.Location = new System.Drawing.Point(76, 30);
            this.pbOglas.Name = "pbOglas";
            this.pbOglas.Size = new System.Drawing.Size(250, 250);
            this.pbOglas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOglas.TabIndex = 21;
            this.pbOglas.TabStop = false;
            // 
            // FrmPregledOdabranog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelDetalji);
            this.Controls.Add(this.panelNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmPregledOdabranog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPregledOdabranog";
            this.Load += new System.EventHandler(this.FrmPregledOdabranog_Load);
            this.panelNaslov.ResumeLayout(false);
            this.panelNaslov.PerformLayout();
            this.panelDetalji.ResumeLayout(false);
            this.panelDetalji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrojPregleda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnchecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOglas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNaslov;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panelDetalji;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbOglas;
        private System.Windows.Forms.Label labelKorime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextOpis;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelLokacija;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelBrojPregleda;
        private System.Windows.Forms.PictureBox pictureBoxUnchecked;
        private System.Windows.Forms.PictureBox pictureBoxChecked;
        private System.Windows.Forms.PictureBox pictureBoxCijena;
        private System.Windows.Forms.PictureBox pictureBoxBrojPregleda;
        private System.Windows.Forms.Button btnClose;
    }
}