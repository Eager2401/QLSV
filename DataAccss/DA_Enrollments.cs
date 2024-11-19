using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccss
{
    public class DA_Enrollments
    {
        Database db = new Database();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable LoadListEnrollments()
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT EnrollmentID, Enrollments.StudentID, Students.FirstName, Students.LastName, Enrollments.CourseID, EnrollmentDate, Grade " +
                "FROM Enrollments INNER JOIN Students ON Enrollments.StudentID = Students.StudentID " +
                "INNER JOIN Courses ON Enrollments.CourseID = Courses.CourseID";
            command.Connection = db.Connection;

            DataTable List_Enrollments = new DataTable();
            adapter.Fill(List_Enrollments);
            return List_Enrollments;
        }

        public int DeleteEnrollment(int enrollmentID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Enrollments WHERE EnrollmentID=@EnrollmentID";
            command.Connection = db.Connection;
            command.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

            db.Connection.Open();
            int res = command.ExecuteNonQuery();
            db.Connection.Close();

            return res;
        }

        public int UpdateEnrollment(Enrollments enrollment)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Enrollments SET StudentID=@StudentID, CourseID=@CourseID, " +
                "EnrollmentDate=@EnrollmentDate, Grade=@Grade WHERE EnrollmentID=@EnrollmentID";
            cmd.Connection = db.Connection;
            cmd.Parameters.AddWithValue("@EnrollmentID", enrollment.EnrollmentID);
            cmd.Parameters.AddWithValue("@StudentID", enrollment.StudentID);
            cmd.Parameters.AddWithValue("@CourseID", enrollment.CourseID);
            cmd.Parameters.AddWithValue("@EnrollmentDate", enrollment.EnrollmentDate);
            cmd.Parameters.AddWithValue("@Grade", enrollment.Grade);

            db.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return res;
        }

        public bool AddEnrollment(Enrollments enrollment)
        {
            string query = "INSERT INTO Enrollments(EnrollmentID, StudentID, CourseID, EnrollmentDate, Grade) " +
                "VALUES (@EnrollmentID, @StudentID, @CourseID, @EnrollmentDate, @Grade)";

            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@EnrollmentID", enrollment.EnrollmentID);
            cmd.Parameters.AddWithValue("@StudentID", enrollment.StudentID);
            cmd.Parameters.AddWithValue("@CourseID", enrollment.CourseID);
            cmd.Parameters.AddWithValue("@EnrollmentDate", enrollment.EnrollmentDate);
            cmd.Parameters.AddWithValue("@Grade", enrollment.Grade);

            db.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return res > 0;
        }


        public DataTable SearchByCourseID(int courseID)
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT EnrollmentID, StudentID, CourseID, EnrollmentDate, Grade FROM Enrollments " +
                "WHERE CourseID = @CourseID";

            command.Parameters.AddWithValue("@CourseID", courseID);
            command.Connection = db.Connection;

            DataTable List_Enrollments_By_Course = new DataTable();
            adapter.Fill(List_Enrollments_By_Course);
            return List_Enrollments_By_Course;
        }

        public DataTable SearchByStudentID(int studentID)
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT EnrollmentID, StudentID, CourseID, EnrollmentDate, Grade FROM Enrollments " +
                "WHERE StudentID = @StudentID";

            command.Parameters.AddWithValue("@StudentID", studentID);
            command.Connection = db.Connection;

            DataTable List_Enrollments_By_Student = new DataTable();
            adapter.Fill(List_Enrollments_By_Student);
            return List_Enrollments_By_Student;
        }

        public DataTable GetAvgScoreByCourse()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM View_AverageGradeByStudentAndCourse";

            SqlCommand cmd = new SqlCommand(query, db.Connection);
            db.Connection.Open();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.Connection.Close();
            return dt;

        }
    }
}
