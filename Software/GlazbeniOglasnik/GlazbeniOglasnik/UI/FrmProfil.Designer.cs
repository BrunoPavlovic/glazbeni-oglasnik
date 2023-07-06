namespace GlazbeniOglasnik.UI
{
    partial class FrmProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelKorime = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelOglasi = new System.Windows.Forms.Label();
            this.dgvZanimljivi = new System.Windows.Forms.DataGridView();
            this.btnPregledOdabranog = new System.Windows.Forms.Button();
            this.btnUrediProfil = new System.Windows.Forms.Button();
            this.btnPromijeniLozinku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanimljivi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelKorime
            // 
            this.labelKorime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKorime.AutoSize = true;
            this.labelKorime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKorime.ForeColor = System.Drawing.Color.White;
            this.labelKorime.Location = new System.Drawing.Point(60, 36);
            this.labelKorime.Name = "labelKorime";
            this.labelKorime.Size = new System.Drawing.Size(97, 29);
            this.labelKorime.TabIndex = 1;
            this.labelKorime.Text = "Korime";
            // 
            // labelIme
            // 
            this.labelIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIme.ForeColor = System.Drawing.Color.White;
            this.labelIme.Location = new System.Drawing.Point(12, 90);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(44, 25);
            this.labelIme.TabIndex = 2;
            this.labelIme.Text = "Ime";
            // 
            // labelPrezime
            // 
            this.labelPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPrezime.ForeColor = System.Drawing.Color.White;
            this.labelPrezime.Location = new System.Drawing.Point(109, 90);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(83, 25);
            this.labelPrezime.TabIndex = 3;
            this.labelPrezime.Text = "Prezime";
            // 
            // labelTelefon
            // 
            this.labelTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTelefon.ForeColor = System.Drawing.Color.White;
            this.labelTelefon.Location = new System.Drawing.Point(12, 130);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(144, 25);
            this.labelTelefon.TabIndex = 4;
            this.labelTelefon.Text = "+385 000 1111";
            // 
            // labelOglasi
            // 
            this.labelOglasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOglasi.AutoSize = true;
            this.labelOglasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOglasi.ForeColor = System.Drawing.Color.White;
            this.labelOglasi.Location = new System.Drawing.Point(16, 216);
            this.labelOglasi.Name = "labelOglasi";
            this.labelOglasi.Size = new System.Drawing.Size(154, 25);
            this.labelOglasi.TabIndex = 5;
            this.labelOglasi.Text = "Zanimljivi oglasi:";
            // 
            // dgvZanimljivi
            // 
            this.dgvZanimljivi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvZanimljivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanimljivi.Location = new System.Drawing.Point(21, 254);
            this.dgvZanimljivi.Name = "dgvZanimljivi";
            this.dgvZanimljivi.RowHeadersWidth = 51;
            this.dgvZanimljivi.RowTemplate.Height = 24;
            this.dgvZanimljivi.Size = new System.Drawing.Size(767, 113);
            this.dgvZanimljivi.TabIndex = 6;
            // 
            // btnPregledOdabranog
            // 
            this.btnPregledOdabranog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPregledOdabranog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnPregledOdabranog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPregledOdabranog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledOdabranog.ForeColor = System.Drawing.Color.White;
            this.btnPregledOdabranog.Location = new System.Drawing.Point(583, 384);
            this.btnPregledOdabranog.Name = "btnPregledOdabranog";
            this.btnPregledOdabranog.Size = new System.Drawing.Size(205, 40);
            this.btnPregledOdabranog.TabIndex = 7;
            this.btnPregledOdabranog.Text = "Pregled odabranog";
            this.btnPregledOdabranog.UseVisualStyleBackColor = false;
            // 
            // btnUrediProfil
            // 
            this.btnUrediProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUrediProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnUrediProfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrediProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediProfil.ForeColor = System.Drawing.Color.White;
            this.btnUrediProfil.Location = new System.Drawing.Point(623, 42);
            this.btnUrediProfil.Name = "btnUrediProfil";
            this.btnUrediProfil.Size = new System.Drawing.Size(165, 30);
            this.btnUrediProfil.TabIndex = 8;
            this.btnUrediProfil.Text = "Uredi profil";
            this.btnUrediProfil.UseVisualStyleBackColor = false;
            // 
            // btnPromijeniLozinku
            // 
            this.btnPromijeniLozinku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPromijeniLozinku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnPromijeniLozinku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPromijeniLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromijeniLozinku.ForeColor = System.Drawing.Color.White;
            this.btnPromijeniLozinku.Location = new System.Drawing.Point(623, 93);
            this.btnPromijeniLozinku.Name = "btnPromijeniLozinku";
            this.btnPromijeniLozinku.Size = new System.Drawing.Size(165, 30);
            this.btnPromijeniLozinku.TabIndex = 9;
            this.btnPromijeniLozinku.Text = "Promijeni lozinku";
            this.btnPromijeniLozinku.UseVisualStyleBackColor = false;
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromijeniLozinku);
            this.Controls.Add(this.btnUrediProfil);
            this.Controls.Add(this.btnPregledOdabranog);
            this.Controls.Add(this.dgvZanimljivi);
            this.Controls.Add(this.labelOglasi);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.labelKorime);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmProfil";
            this.Text = "FrmProfil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanimljivi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelKorime;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelOglasi;
        private System.Windows.Forms.DataGridView dgvZanimljivi;
        private System.Windows.Forms.Button btnPregledOdabranog;
        private System.Windows.Forms.Button btnUrediProfil;
        private System.Windows.Forms.Button btnPromijeniLozinku;
    }
}