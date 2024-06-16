using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using Evaluation_Manager.Models;

namespace Evaluation_Manager.Repositories
{
    public class StudentRepository
    {
        public static Student GetStudent(int id)
        {
            Student student = null;
            string sql = $"SELECT * FROM Students WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return student;
        }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student> ();
            string sql = "SELECT * FROM Students";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Student student = CreateObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        public static List<Student> GetStudentsWithoutGrade()
        {
            List<Student> students = new List<Student>();
            string sql = "SELECT * FROM Students WHERE Grade = 0";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Student student = CreateObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        public static List<Student> GetStudentsWithParameters(string name, string surname, int grade)
        {
            List<Student> students = new List<Student>();
            bool isCriteriaAppended = false;

            string sql = "SELECT * FROM Students WHERE";

            if (name != null)
            {
                sql += $" FirstName = '{name}'";
                isCriteriaAppended = true;
            }
            if (surname != null)
            {
                if (isCriteriaAppended)
                {
                    sql += " AND";
                }
                sql += $" LastName = '{surname}'";
                isCriteriaAppended = true;
            }
            if (grade != -1)
            {
                if (isCriteriaAppended)
                {
                    sql += " AND";
                }
                sql += $" Grade = {grade}";
            }

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Student student = CreateObject(reader);
                students.Add(student);
            }
            reader.Close();
            DB.CloseConnection();
            return students;
        }

        public static void InsertStudent(string firstName, string lastName)
        {
            string sql = $"INSERT INTO Students (FirstName, LastName, Grade) VALUES('{firstName}', '{lastName}', 0)";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Student CreateObject (SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            int grade = int.Parse(reader["Grade"].ToString());

            var student = new Student
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Grade = grade,
            };
            return student;
        }
    }
}
