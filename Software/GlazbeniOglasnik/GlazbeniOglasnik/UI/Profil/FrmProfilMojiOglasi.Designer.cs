namespace GlazbeniOglasnik.UI.Profil
{
    partial class FrmProfilMojiOglasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfilMojiOglasi));
            this.dgvMojiOglasi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPregledOdabranog = new System.Windows.Forms.Button();
            this.btnObrisiSliku = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojiOglasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMojiOglasi
            // 
            this.dgvMojiOglasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMojiOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojiOglasi.Location = new System.Drawing.Point(17, 98);
            this.dgvMojiOglasi.Name = "dgvMojiOglasi";
            this.dgvMojiOglasi.RowHeadersWidth = 51;
            this.dgvMojiOglasi.RowTemplate.Height = 24;
            this.dgvMojiOglasi.Size = new System.Drawing.Size(771, 241);
            this.dgvMojiOglasi.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Moji oglasi:";
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
            this.btnPregledOdabranog.TabIndex = 14;
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
            this.btnObrisiSliku.Location = new System.Drawing.Point(583, 57);
            this.btnObrisiSliku.Name = "btnObrisiSliku";
            this.btnObrisiSliku.Size = new System.Drawing.Size(205, 35);
            this.btnObrisiSliku.TabIndex = 22;
            this.btnObrisiSliku.Text = "Obriši odabrani";
            this.btnObrisiSliku.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(359, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Uredi odabrani";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmProfilMojiOglasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObrisiSliku);
            this.Controls.Add(this.btnPregledOdabranog);
            this.Controls.Add(this.dgvMojiOglasi);
            this.Controls.Add(this.label1);
            this.Name = "FrmProfilMojiOglasi";
            this.Text = "FrmProfilMojiOglasi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojiOglasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMojiOglasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPregledOdabranog;
        private System.Windows.Forms.Button btnObrisiSliku;
        private System.Windows.Forms.Button button1;
    }
}