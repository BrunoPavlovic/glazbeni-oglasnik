namespace GlazbeniOglasnik.UI
{
    partial class FrmPregledOglasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPregledOglasa));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvOglasi = new System.Windows.Forms.DataGridView();
            this.btnPregledOdabranog = new System.Windows.Forms.Button();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.cmbSortiraj = new System.Windows.Forms.ComboBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 27);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvOglasi
            // 
            this.dgvOglasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOglasi.Location = new System.Drawing.Point(12, 129);
            this.dgvOglasi.Name = "dgvOglasi";
            this.dgvOglasi.RowHeadersWidth = 51;
            this.dgvOglasi.RowTemplate.Height = 24;
            this.dgvOglasi.Size = new System.Drawing.Size(1209, 312);
            this.dgvOglasi.TabIndex = 1;
            // 
            // btnPregledOdabranog
            // 
            this.btnPregledOdabranog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPregledOdabranog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnPregledOdabranog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPregledOdabranog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledOdabranog.ForeColor = System.Drawing.Color.White;
            this.btnPregledOdabranog.Location = new System.Drawing.Point(1007, 447);
            this.btnPregledOdabranog.Name = "btnPregledOdabranog";
            this.btnPregledOdabranog.Size = new System.Drawing.Size(214, 40);
            this.btnPregledOdabranog.TabIndex = 2;
            this.btnPregledOdabranog.Text = "Pregled odabranog";
            this.btnPregledOdabranog.UseVisualStyleBackColor = false;
            // 
            // pbSearch
            // 
            this.pbSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbSearch.InitialImage")));
            this.pbSearch.Location = new System.Drawing.Point(275, 20);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(32, 33);
            this.pbSearch.TabIndex = 3;
            this.pbSearch.TabStop = false;
            // 
            // cmbSortiraj
            // 
            this.cmbSortiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortiraj.FormattingEnabled = true;
            this.cmbSortiraj.Items.AddRange(new object[] {
            "Datum objave uzlazno",
            "Datum objave silazno",
            "Cijena uzlazno",
            "Cijena silazno"});
            this.cmbSortiraj.Location = new System.Drawing.Point(975, 20);
            this.cmbSortiraj.Name = "cmbSortiraj";
            this.cmbSortiraj.Size = new System.Drawing.Size(246, 28);
            this.cmbSortiraj.TabIndex = 4;
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Items.AddRange(new object[] {
            "Svi",
            "Kupujem",
            "Prodajem"});
            this.cmbKategorija.Location = new System.Drawing.Point(975, 78);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(246, 28);
            this.cmbKategorija.TabIndex = 5;
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNaziv.ForeColor = System.Drawing.Color.White;
            this.labelNaziv.Location = new System.Drawing.Point(896, 21);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(73, 25);
            this.labelNaziv.TabIndex = 6;
            this.labelNaziv.Text = "Sortiraj";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(869, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategorija";
            // 
            // FrmPregledOglasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1244, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.cmbSortiraj);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.btnPregledOdabranog);
            this.Controls.Add(this.dgvOglasi);
            this.Controls.Add(this.txtSearch);
            this.Name = "FrmPregledOglasa";
            this.Text = "FrmPregledOglasa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvOglasi;
        private System.Windows.Forms.Button btnPregledOdabranog;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.ComboBox cmbSortiraj;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label label1;
    }
}