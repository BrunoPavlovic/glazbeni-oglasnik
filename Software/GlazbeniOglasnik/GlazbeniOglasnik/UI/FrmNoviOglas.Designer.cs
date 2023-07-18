namespace GlazbeniOglasnik.UI
{
    partial class FrmNoviOglas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoviOglas));
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelLokacija = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.btnSlika = new System.Windows.Forms.Button();
            this.btnOdbaci = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.richTextOpis = new System.Windows.Forms.RichTextBox();
            this.pbOglas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnObrisiSliku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOglas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNaziv.ForeColor = System.Drawing.Color.White;
            this.labelNaziv.Location = new System.Drawing.Point(45, 9);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(67, 25);
            this.labelNaziv.TabIndex = 3;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelCijena
            // 
            this.labelCijena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCijena.AutoSize = true;
            this.labelCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCijena.ForeColor = System.Drawing.Color.White;
            this.labelCijena.Location = new System.Drawing.Point(38, 45);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(74, 25);
            this.labelCijena.TabIndex = 4;
            this.labelCijena.Text = "Cijena:";
            // 
            // labelLokacija
            // 
            this.labelLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLokacija.AutoSize = true;
            this.labelLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLokacija.ForeColor = System.Drawing.Color.White;
            this.labelLokacija.Location = new System.Drawing.Point(22, 89);
            this.labelLokacija.Name = "labelLokacija";
            this.labelLokacija.Size = new System.Drawing.Size(90, 25);
            this.labelLokacija.TabIndex = 5;
            this.labelLokacija.Text = "Lokacija:";
            // 
            // labelOpis
            // 
            this.labelOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOpis.ForeColor = System.Drawing.Color.White;
            this.labelOpis.Location = new System.Drawing.Point(53, 184);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(59, 25);
            this.labelOpis.TabIndex = 6;
            this.labelOpis.Text = "Opis:";
            // 
            // btnSlika
            // 
            this.btnSlika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSlika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnSlika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlika.ForeColor = System.Drawing.Color.White;
            this.btnSlika.Image = ((System.Drawing.Image)(resources.GetObject("btnSlika.Image")));
            this.btnSlika.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSlika.Location = new System.Drawing.Point(620, 302);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(170, 35);
            this.btnSlika.TabIndex = 9;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = false;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdbaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnOdbaci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdbaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdbaci.ForeColor = System.Drawing.Color.White;
            this.btnOdbaci.Location = new System.Drawing.Point(896, 444);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(165, 30);
            this.btnOdbaci.TabIndex = 10;
            this.btnOdbaci.Text = "Odbaci";
            this.btnOdbaci.UseVisualStyleBackColor = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(1067, 444);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(165, 30);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(132, 7);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(236, 27);
            this.txtNaziv.TabIndex = 12;
            // 
            // txtCijena
            // 
            this.txtCijena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijena.Location = new System.Drawing.Point(132, 46);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(236, 27);
            this.txtCijena.TabIndex = 13;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLokacija.Location = new System.Drawing.Point(132, 90);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(236, 27);
            this.txtLokacija.TabIndex = 14;
            // 
            // richTextOpis
            // 
            this.richTextOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextOpis.Location = new System.Drawing.Point(132, 184);
            this.richTextOpis.Name = "richTextOpis";
            this.richTextOpis.Size = new System.Drawing.Size(236, 148);
            this.richTextOpis.TabIndex = 15;
            this.richTextOpis.Text = "";
            // 
            // pbOglas
            // 
            this.pbOglas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbOglas.Image = ((System.Drawing.Image)(resources.GetObject("pbOglas.Image")));
            this.pbOglas.Location = new System.Drawing.Point(676, 7);
            this.pbOglas.Name = "pbOglas";
            this.pbOglas.Size = new System.Drawing.Size(275, 275);
            this.pbOglas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOglas.TabIndex = 16;
            this.pbOglas.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kategorija";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Items.AddRange(new object[] {
            "Kupujem",
            "Prodajem"});
            this.cmbKategorija.Location = new System.Drawing.Point(133, 129);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(235, 28);
            this.cmbKategorija.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnBack.Enabled = false;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(620, 127);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 30);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(957, 127);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 30);
            this.btnNext.TabIndex = 20;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnObrisiSliku
            // 
            this.btnObrisiSliku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiSliku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnObrisiSliku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSliku.ForeColor = System.Drawing.Color.White;
            this.btnObrisiSliku.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisiSliku.Image")));
            this.btnObrisiSliku.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiSliku.Location = new System.Drawing.Point(796, 302);
            this.btnObrisiSliku.Name = "btnObrisiSliku";
            this.btnObrisiSliku.Size = new System.Drawing.Size(195, 35);
            this.btnObrisiSliku.TabIndex = 21;
            this.btnObrisiSliku.Text = "Obriši trenutnu";
            this.btnObrisiSliku.UseVisualStyleBackColor = false;
            this.btnObrisiSliku.Click += new System.EventHandler(this.btnObrisiSliku_Click);
            // 
            // FrmNoviOglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1244, 499);
            this.Controls.Add(this.btnObrisiSliku);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbOglas);
            this.Controls.Add(this.richTextOpis);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelLokacija);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelNaziv);
            this.Name = "FrmNoviOglas";
            this.Text = "FrmNoviOglas";
            this.Load += new System.EventHandler(this.FrmNoviOglas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOglas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelLokacija;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Button btnOdbaci;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.RichTextBox richTextOpis;
        private System.Windows.Forms.PictureBox pbOglas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnObrisiSliku;
    }
}