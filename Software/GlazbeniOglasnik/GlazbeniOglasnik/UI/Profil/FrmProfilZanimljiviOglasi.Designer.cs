namespace GlazbeniOglasnik.UI.Profil
{
    partial class FrmProfilZanimljiviOglasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfilZanimljiviOglasi));
            this.dgvZanimljivi = new System.Windows.Forms.DataGridView();
            this.labelOglasi = new System.Windows.Forms.Label();
            this.btnPregledOdabranog = new System.Windows.Forms.Button();
            this.btnObrisiSliku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanimljivi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZanimljivi
            // 
            this.dgvZanimljivi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvZanimljivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanimljivi.Location = new System.Drawing.Point(17, 76);
            this.dgvZanimljivi.Name = "dgvZanimljivi";
            this.dgvZanimljivi.RowHeadersWidth = 51;
            this.dgvZanimljivi.RowTemplate.Height = 24;
            this.dgvZanimljivi.Size = new System.Drawing.Size(771, 292);
            this.dgvZanimljivi.TabIndex = 8;
            // 
            // labelOglasi
            // 
            this.labelOglasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOglasi.AutoSize = true;
            this.labelOglasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOglasi.ForeColor = System.Drawing.Color.White;
            this.labelOglasi.Location = new System.Drawing.Point(12, 27);
            this.labelOglasi.Name = "labelOglasi";
            this.labelOglasi.Size = new System.Drawing.Size(154, 25);
            this.labelOglasi.TabIndex = 7;
            this.labelOglasi.Text = "Zanimljivi oglasi:";
            // 
            // btnPregledOdabranog
            // 
            this.btnPregledOdabranog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPregledOdabranog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnPregledOdabranog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPregledOdabranog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledOdabranog.ForeColor = System.Drawing.Color.White;
            this.btnPregledOdabranog.Location = new System.Drawing.Point(583, 398);
            this.btnPregledOdabranog.Name = "btnPregledOdabranog";
            this.btnPregledOdabranog.Size = new System.Drawing.Size(205, 40);
            this.btnPregledOdabranog.TabIndex = 9;
            this.btnPregledOdabranog.Text = "Pregled odabranog";
            this.btnPregledOdabranog.UseVisualStyleBackColor = false;
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
            this.btnObrisiSliku.Location = new System.Drawing.Point(355, 398);
            this.btnObrisiSliku.Name = "btnObrisiSliku";
            this.btnObrisiSliku.Size = new System.Drawing.Size(215, 40);
            this.btnObrisiSliku.TabIndex = 23;
            this.btnObrisiSliku.Text = "Ukloni sa popisa";
            this.btnObrisiSliku.UseVisualStyleBackColor = false;
            // 
            // FrmProfilZanimljiviOglasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiSliku);
            this.Controls.Add(this.btnPregledOdabranog);
            this.Controls.Add(this.dgvZanimljivi);
            this.Controls.Add(this.labelOglasi);
            this.Name = "FrmProfilZanimljiviOglasi";
            this.Text = "FrmProfilZanimljiviOglasi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanimljivi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZanimljivi;
        private System.Windows.Forms.Label labelOglasi;
        private System.Windows.Forms.Button btnPregledOdabranog;
        private System.Windows.Forms.Button btnObrisiSliku;
    }
}