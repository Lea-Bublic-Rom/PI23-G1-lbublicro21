using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EvaluationManager
{
    public partial class FrmLogin : Form
    {
       public static Teacher LoggedTeacher { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblKorIme_Click(object sender, EventArgs e)
        {

        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKorIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                LoggedTeacher = TeacherRepository.GetTeacher(txtKorIme.Text);
                if (LoggedTeacher != null && LoggedTeacher.Password == txtLozinka.Text)
                {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmStudents frmStudents = new FrmStudents();
                    Hide();
                    frmStudents.Text = $"{LoggedTeacher.FirstName} {LoggedTeacher.LastName}";
                    Hide();

                    frmStudents.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
