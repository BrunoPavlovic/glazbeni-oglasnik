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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelOglasi = new System.Windows.Forms.Label();
            this.btnObrisiZanimljivi = new System.Windows.Forms.Button();
            this.dgvZanimljivi = new System.Windows.Forms.DataGridView();
            this.SlikeOglasa = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelObavijest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanimljivi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOglasi
            // 
            this.labelOglasi.AutoSize = true;
            this.labelOglasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOglasi.ForeColor = System.Drawing.Color.White;
            this.labelOglasi.Location = new System.Drawing.Point(12, 27);
            this.labelOglasi.Name = "labelOglasi";
            this.labelOglasi.Size = new System.Drawing.Size(154, 25);
            this.labelOglasi.TabIndex = 7;
            this.labelOglasi.Text = "Zanimljivi oglasi:";
            // 
            // btnObrisiZanimljivi
            // 
            this.btnObrisiZanimljivi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiZanimljivi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnObrisiZanimljivi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiZanimljivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZanimljivi.ForeColor = System.Drawing.Color.White;
            this.btnObrisiZanimljivi.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisiZanimljivi.Image")));
            this.btnObrisiZanimljivi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiZanimljivi.Location = new System.Drawing.Point(573, 398);
            this.btnObrisiZanimljivi.Name = "btnObrisiZanimljivi";
            this.btnObrisiZanimljivi.Size = new System.Drawing.Size(215, 40);
            this.btnObrisiZanimljivi.TabIndex = 23;
            this.btnObrisiZanimljivi.Text = "Ukloni sa popisa";
            this.btnObrisiZanimljivi.UseVisualStyleBackColor = false;
            this.btnObrisiZanimljivi.Click += new System.EventHandler(this.btnObrisiZanimljivi_Click);
            // 
            // dgvZanimljivi
            // 
            this.dgvZanimljivi.AllowUserToAddRows = false;
            this.dgvZanimljivi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvZanimljivi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZanimljivi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvZanimljivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZanimljivi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.dgvZanimljivi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZanimljivi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZanimljivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanimljivi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlikeOglasa});
            this.dgvZanimljivi.EnableHeadersVisualStyles = false;
            this.dgvZanimljivi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.dgvZanimljivi.Location = new System.Drawing.Point(12, 78);
            this.dgvZanimljivi.MultiSelect = false;
            this.dgvZanimljivi.Name = "dgvZanimljivi";
            this.dgvZanimljivi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZanimljivi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZanimljivi.RowHeadersVisible = false;
            this.dgvZanimljivi.RowHeadersWidth = 51;
            this.dgvZanimljivi.RowTemplate.Height = 50;
            this.dgvZanimljivi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZanimljivi.Size = new System.Drawing.Size(776, 294);
            this.dgvZanimljivi.TabIndex = 25;
            this.dgvZanimljivi.Visible = false;
            this.dgvZanimljivi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZanimljivi_CellDoubleClick);
            this.dgvZanimljivi.VisibleChanged += new System.EventHandler(this.dgvZanimljivi_VisibleChanged);
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
            this.labelObavijest.Location = new System.Drawing.Point(175, 205);
            this.labelObavijest.Name = "labelObavijest";
            this.labelObavijest.Size = new System.Drawing.Size(484, 25);
            this.labelObavijest.TabIndex = 26;
            this.labelObavijest.Text = "Ne postoji nijedan oglas koji ste označili kao zanimljivi! ";
            this.labelObavijest.Visible = false;
            // 
            // FrmProfilZanimljiviOglasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelObavijest);
            this.Controls.Add(this.dgvZanimljivi);
            this.Controls.Add(this.btnObrisiZanimljivi);
            this.Controls.Add(this.labelOglasi);
            this.Name = "FrmProfilZanimljiviOglasi";
            this.Text = "FrmProfilZanimljiviOglasi";
            this.Load += new System.EventHandler(this.FrmProfilZanimljiviOglasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanimljivi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOglasi;
        private System.Windows.Forms.Button btnObrisiZanimljivi;
        private System.Windows.Forms.DataGridView dgvZanimljivi;
        private System.Windows.Forms.DataGridViewImageColumn SlikeOglasa;
        private System.Windows.Forms.Label labelObavijest;
    }
}