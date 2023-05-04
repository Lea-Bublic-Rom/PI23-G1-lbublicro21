namespace EvaluationManager
{
    partial class Form1
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
            this.lblKorIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Location = new System.Drawing.Point(16, 31);
            this.lblKorIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(94, 16);
            this.lblKorIme.TabIndex = 0;
            this.lblKorIme.Text = "Korisničko ime";
            this.lblKorIme.Click += new System.EventHandler(this.lblKorIme_Click);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(16, 82);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(53, 16);
            this.lblLozinka.TabIndex = 2;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(124, 27);
            this.txtKorIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(193, 22);
            this.txtKorIme.TabIndex = 3;
            this.txtKorIme.TextChanged += new System.EventHandler(this.txtKorIme_TextChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(124, 79);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(193, 22);
            this.txtLozinka.TabIndex = 4;
            this.txtLozinka.UseSystemPasswordChar = true;
            this.txtLozinka.TextChanged += new System.EventHandler(this.txtLozinka_TextChanged);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(219, 133);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(100, 28);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 191);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorIme);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
    }
}

