using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager
{
    public partial class FrmFinalReport : Form
    {
        public FrmFinalReport()
        {
            InitializeComponent();
        }

        private void FrmFinalReport_Load(object sender, EventArgs e)
        {
            var results = GenerateStudentReport();
            dgvResults.DataSource = results;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var form = new FrmFinalReport();
            form.ShowDialog();
        }
    }
}
