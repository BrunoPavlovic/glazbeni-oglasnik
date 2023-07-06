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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(71, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // dgvOglasi
            // 
            this.dgvOglasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOglasi.Location = new System.Drawing.Point(61, 77);
            this.dgvOglasi.Name = "dgvOglasi";
            this.dgvOglasi.RowHeadersWidth = 51;
            this.dgvOglasi.RowTemplate.Height = 24;
            this.dgvOglasi.Size = new System.Drawing.Size(695, 265);
            this.dgvOglasi.TabIndex = 1;
            // 
            // btnPregledOdabranog
            // 
            this.btnPregledOdabranog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPregledOdabranog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnPregledOdabranog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPregledOdabranog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPregledOdabranog.ForeColor = System.Drawing.Color.White;
            this.btnPregledOdabranog.Location = new System.Drawing.Point(603, 355);
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
            this.pbSearch.Location = new System.Drawing.Point(339, 28);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(32, 33);
            this.pbSearch.TabIndex = 3;
            this.pbSearch.TabStop = false;
            // 
            // cmbSortiraj
            // 
            this.cmbSortiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSortiraj.FormattingEnabled = true;
            this.cmbSortiraj.Items.AddRange(new object[] {
            "Datum objave uzlazno",
            "Datum objave silazno",
            "Cijena uzlazno",
            "Cijena silazno"});
            this.cmbSortiraj.Location = new System.Drawing.Point(592, 28);
            this.cmbSortiraj.Name = "cmbSortiraj";
            this.cmbSortiraj.Size = new System.Drawing.Size(164, 24);
            this.cmbSortiraj.TabIndex = 4;
            // 
            // FrmPregledOglasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(847, 410);
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
    }
}