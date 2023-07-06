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
            ((System.ComponentModel.ISupportInitialize)(this.pbOglas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNaziv.ForeColor = System.Drawing.Color.White;
            this.labelNaziv.Location = new System.Drawing.Point(35, 35);
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
            this.labelCijena.Location = new System.Drawing.Point(28, 81);
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
            this.labelLokacija.Location = new System.Drawing.Point(12, 120);
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
            this.labelOpis.Location = new System.Drawing.Point(43, 160);
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
            this.btnSlika.Location = new System.Drawing.Point(568, 239);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(165, 30);
            this.btnSlika.TabIndex = 9;
            this.btnSlika.Text = "Postavi sliku";
            this.btnSlika.UseVisualStyleBackColor = false;
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdbaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnOdbaci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdbaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdbaci.ForeColor = System.Drawing.Color.White;
            this.btnOdbaci.Location = new System.Drawing.Point(440, 408);
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
            this.btnSpremi.Location = new System.Drawing.Point(623, 408);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(165, 30);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(108, 38);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(236, 22);
            this.txtNaziv.TabIndex = 12;
            // 
            // txtCijena
            // 
            this.txtCijena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCijena.Location = new System.Drawing.Point(108, 81);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(236, 22);
            this.txtCijena.TabIndex = 13;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLokacija.Location = new System.Drawing.Point(108, 120);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(236, 22);
            this.txtLokacija.TabIndex = 14;
            // 
            // richTextOpis
            // 
            this.richTextOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextOpis.Location = new System.Drawing.Point(108, 164);
            this.richTextOpis.Name = "richTextOpis";
            this.richTextOpis.Size = new System.Drawing.Size(236, 105);
            this.richTextOpis.TabIndex = 15;
            this.richTextOpis.Text = "";
            // 
            // pbOglas
            // 
            this.pbOglas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbOglas.Image = ((System.Drawing.Image)(resources.GetObject("pbOglas.Image")));
            this.pbOglas.Location = new System.Drawing.Point(545, 21);
            this.pbOglas.Name = "pbOglas";
            this.pbOglas.Size = new System.Drawing.Size(210, 210);
            this.pbOglas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOglas.TabIndex = 16;
            this.pbOglas.TabStop = false;
            // 
            // FrmNoviOglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}