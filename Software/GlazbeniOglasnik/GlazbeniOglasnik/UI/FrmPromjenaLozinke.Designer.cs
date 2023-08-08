namespace GlazbeniOglasnik.UI
{
    partial class FrmPromjenaLozinke
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPromjenaLozinke));
            this.btnPromijeniLozinku = new System.Windows.Forms.Button();
            this.txtPonovnaLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrenutnaLozinka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.correctProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPromijeniLozinku
            // 
            this.btnPromijeniLozinku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPromijeniLozinku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnPromijeniLozinku.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPromijeniLozinku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromijeniLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromijeniLozinku.ForeColor = System.Drawing.Color.White;
            this.btnPromijeniLozinku.Location = new System.Drawing.Point(327, 241);
            this.btnPromijeniLozinku.Name = "btnPromijeniLozinku";
            this.btnPromijeniLozinku.Size = new System.Drawing.Size(165, 37);
            this.btnPromijeniLozinku.TabIndex = 28;
            this.btnPromijeniLozinku.Text = "Promijeni lozinku";
            this.btnPromijeniLozinku.UseVisualStyleBackColor = false;
            this.btnPromijeniLozinku.Click += new System.EventHandler(this.btnPromijeniLozinku_Click);
            // 
            // txtPonovnaLozinka
            // 
            this.txtPonovnaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPonovnaLozinka.Location = new System.Drawing.Point(251, 127);
            this.txtPonovnaLozinka.Name = "txtPonovnaLozinka";
            this.txtPonovnaLozinka.Size = new System.Drawing.Size(236, 27);
            this.txtPonovnaLozinka.TabIndex = 27;
            this.txtPonovnaLozinka.UseSystemPasswordChar = true;
            this.txtPonovnaLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtPonovnaLozinka_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ponovna nova lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Trenutna lozinka:";
            // 
            // txtTrenutnaLozinka
            // 
            this.txtTrenutnaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrenutnaLozinka.Location = new System.Drawing.Point(251, 29);
            this.txtTrenutnaLozinka.Name = "txtTrenutnaLozinka";
            this.txtTrenutnaLozinka.Size = new System.Drawing.Size(236, 27);
            this.txtTrenutnaLozinka.TabIndex = 27;
            this.txtTrenutnaLozinka.UseSystemPasswordChar = true;
            this.txtTrenutnaLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrenutnaLozinka_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nova lozinka:";
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaLozinka.Location = new System.Drawing.Point(251, 77);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.Size = new System.Drawing.Size(236, 27);
            this.txtNovaLozinka.TabIndex = 27;
            this.txtNovaLozinka.UseSystemPasswordChar = true;
            this.txtNovaLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtNovaLozinka_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // correctProvider
            // 
            this.correctProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.correctProvider.ContainerControl = this;
            this.correctProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("correctProvider.Icon")));
            // 
            // FrmPromjenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(525, 314);
            this.Controls.Add(this.btnPromijeniLozinku);
            this.Controls.Add(this.txtTrenutnaLozinka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaLozinka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPonovnaLozinka);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPromjenaLozinke";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena lozinke";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromijeniLozinku;
        private System.Windows.Forms.TextBox txtPonovnaLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrenutnaLozinka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider correctProvider;
    }
}