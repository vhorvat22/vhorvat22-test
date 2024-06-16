using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class Teacher : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }

        public void PerformEvaluation(Student student, Activity activity,int points)
        {
            var evaluation = EvaluationRepository.GetEvaluation(student, activity);
            if (evaluation == null)
            {
                EvaluationRepository.InsertEvaluation(student, activity, this, points);
            }
            else
            {
                EvaluationRepository.UpdateEvaluation(evaluation, this, points);
            }
        }

        public void PerformEvaluationLocal(Student student, Activity activity,int points)
        {
            string idStudent = student.Id.ToString();
            string idActivity = activity.Id.ToString();
            string idTeacher = this.Id.ToString();
            string evaluationDate = DateTime.Now.ToString();
            string stringPoints = points.ToString(); string filePath = @"C:\Users\Korisnik\Documents\Evaluations.csv"; string dataRow = idActivity + "," + idStudent + "," + idTeacher + "," + evaluationDate + "," + stringPoints;
            using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite)))
            {
                writer.WriteLine("sep=,");
                writer.WriteLine(dataRow);
            }
        }
    }
}
