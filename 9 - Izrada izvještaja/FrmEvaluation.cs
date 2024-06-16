using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmEvaluation : Form
    {
        private Student SelectedStudent;
        public FrmEvaluation(Student selectedStudent)
        {
            
            InitializeComponent();
            SelectedStudent = selectedStudent;
        }

        private void FrmEvaluation_Load(object sender, EventArgs e)
        {
            SetFormText();
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;
        }

        private void SetFormText()
        {
            Text = SelectedStudent.FirstName + " " + SelectedStudent.LastName;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoints;
            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;

            var evaluation = EvaluationRepository.GetEvaluation(SelectedStudent, currentActivity);
            if (evaluation != null)
            {
                txtTeacher.Text = evaluation.Evaluator.ToString();
                txtEvaluationDate.Text = evaluation.EvaluationDate.ToString();
                numPoints.Value = evaluation.Points;
            }
            else
            {
                txtTeacher.Text = FrmLogin.LoggedTeacher.ToString();
                txtEvaluationDate.Text = "-";
                numPoints.Value = 0;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var activity = cboActivities.SelectedItem as Activity;
            var teacher = FrmLogin.LoggedTeacher;
            int points = (int)numPoints.Value;
            teacher.PerformEvaluation(SelectedStudent, activity, points);
            Close();

        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            var activity = cboActivities.SelectedItem as Activity;
            var teacher = FrmLogin.LoggedTeacher;
            int points = (int)numPoints.Value;
            teacher.PerformEvaluationLocal(SelectedStudent, activity, points);
            Close();
        }

        private void btnFileLoad_Click(object sender, EventArgs e)
        {
            string[] DisplayData;
            string filePath = @"C:\Users\Korisnik\Documents\Evaluations.csv";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string header = reader.ReadLine();
                string dataRow = reader.ReadLine();
                DisplayData = dataRow.Split(',');
            }
            int idStudent = int.Parse(DisplayData[1]);
            if (idStudent == SelectedStudent.Id)
            {
                int idActivity = int.Parse(DisplayData[0]);
                int idTeacher = int.Parse(DisplayData[2]);
                DateTime evaluationDate = DateTime.Parse(DisplayData[3]);
                int points = int.Parse(DisplayData[4]);
                Activity fileActivity = ActivityRepository.GetActivity(idActivity);
                Teacher fileTeacher = TeacherRepository.GetTeacher(idTeacher);
                cboActivities.SelectedIndex = cboActivities.FindStringExact(fileActivity.ToString());
                txtTeacher.Text = fileTeacher.ToString();
                numPoints.Value = points;
                txtEvaluationDate.Text = evaluationDate.ToString();
            }
            else
            {
                MessageBox.Show("U datoteci ne postoji evaluacija za odabranog studenta!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
