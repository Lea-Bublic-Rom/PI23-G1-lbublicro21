using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager {
    public partial class FrmStudents : Form {

        public FrmStudents(Student selectedStudent) {
            InitializeComponent();
        }

        public FrmStudents() {
        }

        private void FrmStudents_Load(object sender, EventArgs e) {
            ShowStudents();
        }

        private void ShowStudents() {
            List<Student> students = StudentRepoisitory.GetStudents();
            dgvStudents.DataSource = students;
            dgvStudents.Columns["Id"].DisplayIndex = 0;
            dgvStudents.Columns["FirstName"].DisplayIndex = 1;
            dgvStudents.Columns["LastName"].DisplayIndex = 2;
            dgvStudents.Columns["Grade"].DisplayIndex = 3;
        }

        private void bttnEvaluateStudent_Click(object sender, EventArgs e) {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (selectedStudent != null) {
                FrmEvaluation frmEvaluation = new FrmEvaluation(selectedStudent);
                frmEvaluation.ShowDialog();
            }
        }
    }
}