namespace GlazbeniOglasnik
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnPregledOglasa = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.btnProfil);
            this.panelMenu.Controls.Add(this.btnNovi);
            this.panelMenu.Controls.Add(this.btnPregledOglasa);
            this.panelMenu.Controls.Add(this.btnPocetna);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 100);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPocetna
            // 
            this.btnPocetna.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPocetna.Image = ((System.Drawing.Image)(resources.GetObject("btnPocetna.Image")));
            this.btnPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.Location = new System.Drawing.Point(0, 0);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(200, 100);
            this.btnPocetna.TabIndex = 0;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            // 
            // btnPregledOglasa
            // 
            this.btnPregledOglasa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPregledOglasa.FlatAppearance.BorderSize = 0;
            this.btnPregledOglasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledOglasa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPregledOglasa.Image = ((System.Drawing.Image)(resources.GetObject("btnPregledOglasa.Image")));
            this.btnPregledOglasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregledOglasa.Location = new System.Drawing.Point(200, 0);
            this.btnPregledOglasa.Name = "btnPregledOglasa";
            this.btnPregledOglasa.Size = new System.Drawing.Size(200, 100);
            this.btnPregledOglasa.TabIndex = 1;
            this.btnPregledOglasa.Text = "Pregled oglasa";
            this.btnPregledOglasa.UseVisualStyleBackColor = true;
            // 
            // btnNovi
            // 
            this.btnNovi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovi.FlatAppearance.BorderSize = 0;
            this.btnNovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNovi.Image = ((System.Drawing.Image)(resources.GetObject("btnNovi.Image")));
            this.btnNovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovi.Location = new System.Drawing.Point(400, 0);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(200, 100);
            this.btnNovi.TabIndex = 2;
            this.btnNovi.Text = "Kreiranje novog oglasa";
            this.btnNovi.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            this.btnProfil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnProfil.Image")));
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(600, 0);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(200, 100);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Početna";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmMain";
            this.Text = "Glazbeni oglasnik";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnPregledOglasa;
        private System.Windows.Forms.Label label1;
    }
}

