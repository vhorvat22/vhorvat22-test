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
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowStudents(List<Student> students)
        {
            dgvStudents.DataSource = students;

            dgvStudents.Columns["Id"].DisplayIndex = 0;
            dgvStudents.Columns["FirstName"].DisplayIndex = 1;
            dgvStudents.Columns["LastName"].DisplayIndex = 2;
            dgvStudents.Columns["Grade"].DisplayIndex = 3;
        }

        private void prikažiSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudents(StudentRepository.GetStudents());
        }

        private void prikažiNeocijenjeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudents(StudentRepository.GetStudentsWithoutGrade());
        }

        private void pretražiStudenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.ShowDialog();

            string searchName = null;
            string searchSurname = null;
            int searchGrade = -1;
            bool shouldSearch = false;

            if (frmSearch.chkName.Checked)
            {
                string enteredText = frmSearch.txtName.Text;
                if (!string.IsNullOrWhiteSpace(enteredText))
                {
                    searchName = enteredText;
                    shouldSearch = true;
                }
            }

            if (frmSearch.chkSurname.Checked)
            {
                string enteredText = frmSearch.txtSurname.Text;
                if (!string.IsNullOrWhiteSpace(enteredText))
                {
                    searchSurname = enteredText;
                    shouldSearch = true;
                }
            }

            if (frmSearch.chkGrade.Checked)
            {
                string enteredText = frmSearch.txtGrade.Text;
                if (!string.IsNullOrWhiteSpace (enteredText))
                {
                    if (int.TryParse(enteredText, out searchGrade))
                    {
                        shouldSearch = true;
                    }
                }
            }

            if (shouldSearch)
            {
                ShowStudents(StudentRepository.GetStudentsWithParameters(searchName,searchSurname, searchGrade));
            }
            else
            {
                MessageBox.Show("Odaberite barem jedan kriterij za pretragu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEvaluateStudent_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (selectedStudent != null)
            {
                FrmEvaluation frmEvaluation = new FrmEvaluation(selectedStudent);
                frmEvaluation.ShowDialog();
            }
        }

        private void prikažiSveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmActivities frmActivities = new FrmActivities();
            frmActivities.ShowDialog();
        }

        private void btnStudentEvaluations_Click(object sender, EventArgs e)
        {
            Student selectedStudent = dgvStudents.CurrentRow.DataBoundItem as Student;
            if (selectedStudent != null)
            {
                FrmStudentEvaluations studentEvaluations = new FrmStudentEvaluations(selectedStudent);
                studentEvaluations.ShowDialog();
            }
        }

        private void noviNastavnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeacher frmTeacher = new FrmTeacher();
            frmTeacher.ShowDialog();
        }

        private void noviStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var form = new FrmFinalReport();
            form.ShowDialog();
        }
    }
}
