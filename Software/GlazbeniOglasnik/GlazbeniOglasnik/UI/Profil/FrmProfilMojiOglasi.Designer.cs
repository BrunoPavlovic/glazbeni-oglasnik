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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPregledOdabranog = new System.Windows.Forms.Button();
            this.btnObrisiOglas = new System.Windows.Forms.Button();
            this.btnUrediOglas = new System.Windows.Forms.Button();
            this.dgvMojiOglasi = new System.Windows.Forms.DataGridView();
            this.SlikeOglasa = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelObavijest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojiOglasi)).BeginInit();
            this.SuspendLayout();
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
            this.btnPregledOdabranog.Click += new System.EventHandler(this.btnPregledOdabranog_Click);
            // 
            // btnObrisiOglas
            // 
            this.btnObrisiOglas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiOglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnObrisiOglas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiOglas.ForeColor = System.Drawing.Color.White;
            this.btnObrisiOglas.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisiOglas.Image")));
            this.btnObrisiOglas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiOglas.Location = new System.Drawing.Point(583, 57);
            this.btnObrisiOglas.Name = "btnObrisiOglas";
            this.btnObrisiOglas.Size = new System.Drawing.Size(205, 35);
            this.btnObrisiOglas.TabIndex = 22;
            this.btnObrisiOglas.Text = "Obriši odabrani";
            this.btnObrisiOglas.UseVisualStyleBackColor = false;
            this.btnObrisiOglas.Click += new System.EventHandler(this.btnObrisiOglas_Click);
            // 
            // btnUrediOglas
            // 
            this.btnUrediOglas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUrediOglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnUrediOglas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrediOglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrediOglas.ForeColor = System.Drawing.Color.White;
            this.btnUrediOglas.Image = ((System.Drawing.Image)(resources.GetObject("btnUrediOglas.Image")));
            this.btnUrediOglas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrediOglas.Location = new System.Drawing.Point(359, 57);
            this.btnUrediOglas.Name = "btnUrediOglas";
            this.btnUrediOglas.Size = new System.Drawing.Size(205, 35);
            this.btnUrediOglas.TabIndex = 23;
            this.btnUrediOglas.Text = "Uredi odabrani";
            this.btnUrediOglas.UseVisualStyleBackColor = false;
            // 
            // dgvMojiOglasi
            // 
            this.dgvMojiOglasi.AllowUserToAddRows = false;
            this.dgvMojiOglasi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMojiOglasi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMojiOglasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMojiOglasi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.dgvMojiOglasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMojiOglasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMojiOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojiOglasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlikeOglasa});
            this.dgvMojiOglasi.EnableHeadersVisualStyles = false;
            this.dgvMojiOglasi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.dgvMojiOglasi.Location = new System.Drawing.Point(12, 98);
            this.dgvMojiOglasi.MultiSelect = false;
            this.dgvMojiOglasi.Name = "dgvMojiOglasi";
            this.dgvMojiOglasi.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMojiOglasi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMojiOglasi.RowHeadersVisible = false;
            this.dgvMojiOglasi.RowHeadersWidth = 51;
            this.dgvMojiOglasi.RowTemplate.Height = 50;
            this.dgvMojiOglasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMojiOglasi.Size = new System.Drawing.Size(776, 294);
            this.dgvMojiOglasi.TabIndex = 24;
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
            // labelObavijest
            // 
            this.labelObavijest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelObavijest.AutoSize = true;
            this.labelObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObavijest.ForeColor = System.Drawing.Color.White;
            this.labelObavijest.Location = new System.Drawing.Point(276, 217);
            this.labelObavijest.Name = "labelObavijest";
            this.labelObavijest.Size = new System.Drawing.Size(274, 25);
            this.labelObavijest.TabIndex = 27;
            this.labelObavijest.Text = "Nemate nijedan kreirani oglas!";
            this.labelObavijest.Visible = false;
            // 
            // FrmProfilMojiOglasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelObavijest);
            this.Controls.Add(this.dgvMojiOglasi);
            this.Controls.Add(this.btnUrediOglas);
            this.Controls.Add(this.btnObrisiOglas);
            this.Controls.Add(this.btnPregledOdabranog);
            this.Controls.Add(this.label1);
            this.Name = "FrmProfilMojiOglasi";
            this.Text = "FrmProfilMojiOglasi";
            this.Load += new System.EventHandler(this.FrmProfilMojiOglasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojiOglasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPregledOdabranog;
        private System.Windows.Forms.Button btnObrisiOglas;
        private System.Windows.Forms.Button btnUrediOglas;
        private System.Windows.Forms.DataGridView dgvMojiOglasi;
        private System.Windows.Forms.DataGridViewImageColumn SlikeOglasa;
        private System.Windows.Forms.Label labelObavijest;
    }
}