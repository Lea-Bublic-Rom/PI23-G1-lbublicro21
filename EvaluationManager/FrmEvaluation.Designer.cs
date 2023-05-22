namespace EvaluationManager {
    partial class FrmEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtActivityDescription = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.txtAktivnost = new System.Windows.Forms.Label();
            this.txtMinForSignature = new System.Windows.Forms.Label();
            this.txtMinForGrade = new System.Windows.Forms.Label();
            this.lblOcjenjivac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(38, 37);
            this.cboActivities.Margin = new System.Windows.Forms.Padding(2);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(135, 21);
            this.cboActivities.TabIndex = 0;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(38, 76);
            this.txtActivityDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(388, 199);
            this.txtActivityDescription.TabIndex = 1;
            this.txtActivityDescription.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 37);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(200, 307);
            this.txtTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(76, 20);
            this.txtTeacher.TabIndex = 4;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(287, 307);
            this.txtEvaluationDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.Size = new System.Drawing.Size(82, 20);
            this.txtEvaluationDate.TabIndex = 5;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(384, 308);
            this.numPoints.Margin = new System.Windows.Forms.Padding(2);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(40, 20);
            this.numPoints.TabIndex = 6;
            // 
            // txtAktivnost
            // 
            this.txtAktivnost.AutoSize = true;
            this.txtAktivnost.Location = new System.Drawing.Point(38, 19);
            this.txtAktivnost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAktivnost.Name = "txtAktivnost";
            this.txtAktivnost.Size = new System.Drawing.Size(51, 13);
            this.txtAktivnost.TabIndex = 7;
            this.txtAktivnost.Text = "Aktivnost";
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.AutoSize = true;
            this.txtMinForSignature.Location = new System.Drawing.Point(229, 7);
            this.txtMinForSignature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.Size = new System.Drawing.Size(77, 13);
            this.txtMinForSignature.TabIndex = 8;
            this.txtMinForSignature.Text = "Uvjet za potpis";
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.AutoSize = true;
            this.txtMinForGrade.Location = new System.Drawing.Point(347, 7);
            this.txtMinForGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.Size = new System.Drawing.Size(81, 13);
            this.txtMinForGrade.TabIndex = 9;
            this.txtMinForGrade.Text = "Uvjet za ocjenu";
            // 
            // lblOcjenjivac
            // 
            this.lblOcjenjivac.AutoSize = true;
            this.lblOcjenjivac.Location = new System.Drawing.Point(197, 284);
            this.lblOcjenjivac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOcjenjivac.Name = "lblOcjenjivac";
            this.lblOcjenjivac.Size = new System.Drawing.Size(57, 13);
            this.lblOcjenjivac.TabIndex = 10;
            this.lblOcjenjivac.Text = "Ocjenjivač";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datum evaluacije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bodovi";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(292, 344);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 344);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 384);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOcjenjivac);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.txtAktivnost);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.cboActivities);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.RichTextBox txtActivityDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label txtAktivnost;
        private System.Windows.Forms.Label txtMinForSignature;
        private System.Windows.Forms.Label txtMinForGrade;
        private System.Windows.Forms.Label lblOcjenjivac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}