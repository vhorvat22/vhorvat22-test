using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudentEvaluations : Form
    {
        private Student SelectedStudent;
        public FrmStudentEvaluations(Student selectedStudent)
        {
            InitializeComponent();
            SelectedStudent = selectedStudent;
        }

        private void FrmStudentEvaluations_Load(object sender, EventArgs e)
        {
            SetFormText();
            dgvStudentEvaluations.DataSource = EvaluationRepository.GetEvaluations(SelectedStudent);
        }

        private void SetFormText()
        {
            Text = SelectedStudent.FirstName + " " + SelectedStudent.LastName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
