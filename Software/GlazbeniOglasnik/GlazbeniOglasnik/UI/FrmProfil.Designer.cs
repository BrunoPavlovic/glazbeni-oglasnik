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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelProfil = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenuProfil = new System.Windows.Forms.Panel();
            this.btnProfilPodaci = new System.Windows.Forms.Button();
            this.btnZanimljiviOglasi = new System.Windows.Forms.Button();
            this.btnMojiOglasi = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelProfil.SuspendLayout();
            this.panelMenuProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.panelMenuProfil);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelProfil);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 499);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelProfil
            // 
            this.tableLayoutPanelProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.tableLayoutPanelProfil.ColumnCount = 1;
            this.tableLayoutPanelProfil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProfil.Controls.Add(this.btnMojiOglasi, 0, 1);
            this.tableLayoutPanelProfil.Controls.Add(this.btnZanimljiviOglasi, 0, 1);
            this.tableLayoutPanelProfil.Controls.Add(this.btnProfilPodaci, 0, 0);
            this.tableLayoutPanelProfil.Location = new System.Drawing.Point(3, 101);
            this.tableLayoutPanelProfil.Name = "tableLayoutPanelProfil";
            this.tableLayoutPanelProfil.RowCount = 1;
            this.tableLayoutPanelProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelProfil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelProfil.Size = new System.Drawing.Size(348, 150);
            this.tableLayoutPanelProfil.TabIndex = 1;
            // 
            // panelMenuProfil
            // 
            this.panelMenuProfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuProfil.Controls.Add(this.label1);
            this.panelMenuProfil.Controls.Add(this.pbMenu);
            this.panelMenuProfil.Location = new System.Drawing.Point(3, 3);
            this.panelMenuProfil.Name = "panelMenuProfil";
            this.panelMenuProfil.Size = new System.Drawing.Size(348, 92);
            this.panelMenuProfil.TabIndex = 2;
            // 
            // btnProfilPodaci
            // 
            this.btnProfilPodaci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnProfilPodaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfilPodaci.FlatAppearance.BorderSize = 0;
            this.btnProfilPodaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilPodaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilPodaci.ForeColor = System.Drawing.Color.White;
            this.btnProfilPodaci.Image = ((System.Drawing.Image)(resources.GetObject("btnProfilPodaci.Image")));
            this.btnProfilPodaci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfilPodaci.Location = new System.Drawing.Point(3, 3);
            this.btnProfilPodaci.Name = "btnProfilPodaci";
            this.btnProfilPodaci.Size = new System.Drawing.Size(342, 44);
            this.btnProfilPodaci.TabIndex = 4;
            this.btnProfilPodaci.Text = "Podaci";
            this.btnProfilPodaci.UseVisualStyleBackColor = false;
            // 
            // btnZanimljiviOglasi
            // 
            this.btnZanimljiviOglasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnZanimljiviOglasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZanimljiviOglasi.FlatAppearance.BorderSize = 0;
            this.btnZanimljiviOglasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZanimljiviOglasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZanimljiviOglasi.ForeColor = System.Drawing.Color.White;
            this.btnZanimljiviOglasi.Image = ((System.Drawing.Image)(resources.GetObject("btnZanimljiviOglasi.Image")));
            this.btnZanimljiviOglasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZanimljiviOglasi.Location = new System.Drawing.Point(3, 103);
            this.btnZanimljiviOglasi.Name = "btnZanimljiviOglasi";
            this.btnZanimljiviOglasi.Size = new System.Drawing.Size(342, 44);
            this.btnZanimljiviOglasi.TabIndex = 5;
            this.btnZanimljiviOglasi.Text = "Zanimljivi oglasi";
            this.btnZanimljiviOglasi.UseVisualStyleBackColor = false;
            // 
            // btnMojiOglasi
            // 
            this.btnMojiOglasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnMojiOglasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMojiOglasi.FlatAppearance.BorderSize = 0;
            this.btnMojiOglasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMojiOglasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMojiOglasi.ForeColor = System.Drawing.Color.White;
            this.btnMojiOglasi.Image = ((System.Drawing.Image)(resources.GetObject("btnMojiOglasi.Image")));
            this.btnMojiOglasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMojiOglasi.Location = new System.Drawing.Point(3, 53);
            this.btnMojiOglasi.Name = "btnMojiOglasi";
            this.btnMojiOglasi.Size = new System.Drawing.Size(342, 44);
            this.btnMojiOglasi.TabIndex = 6;
            this.btnMojiOglasi.Text = "Moji oglasi";
            this.btnMojiOglasi.UseVisualStyleBackColor = false;
            // 
            // pbMenu
            // 
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(9, 22);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(58, 50);
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1244, 499);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmProfil";
            this.Text = "FrmProfil";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelProfil.ResumeLayout(false);
            this.panelMenuProfil.ResumeLayout(false);
            this.panelMenuProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelMenuProfil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProfil;
        private System.Windows.Forms.Button btnProfilPodaci;
        private System.Windows.Forms.Button btnMojiOglasi;
        private System.Windows.Forms.Button btnZanimljiviOglasi;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label label1;
    }
}