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
    public class DA_Courses
    {
        Database db = new Database();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable LoadListCourses()
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT CourseID, CourseName, Courses.DepartmentID " +
                "FROM Courses INNER JOIN Departments ON Courses.DepartmentID = Departments.DepartmentID";
            command.Connection = db.Connection;

            DataTable List_Courses = new DataTable();
            adapter.Fill(List_Courses);
            return List_Courses;
        }

        public DataTable LoadListDepartment()
        {
            SqlDataAdapter dataAdapter= new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            dataAdapter.SelectCommand = command;
            command.CommandText = "SELECT DepartmentID, DepartmentName FROM Departments";
            command.Connection = db.Connection;

            DataTable List_Departments = new DataTable();
            dataAdapter.Fill(List_Departments);

            return List_Departments;
        }


        public int DeleteCourses(int ID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE Courses WHERE CoursesID=@CoursesID";
            command.Connection = db.Connection;
            command.Parameters.AddWithValue("@CoursesID", ID);

            db.Connection.Open();

            int res = command.ExecuteNonQuery();
            db.Connection.Close();

            return res;
        }
        public int UpdateCourses(Courses courses)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Courses SET  CourseName=@CourseName," +
                "DepartmentID=@DepartmentID WHERE CourseID=@CourseID";
            cmd.Connection = db.Connection;
            cmd.Parameters.AddWithValue("@CourseID", courses.CoursesID);
            cmd.Parameters.AddWithValue("@CourseName", courses.CoursesName);
            cmd.Parameters.AddWithValue("@DepartmentID", courses.DepartmentID);

            db.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return res;
        }

        public bool AddCourses(Courses c)
        {
            string query = "INSERT INTO Courses ( CourseName, " +
                "DepartmentID) VALUES ( @CourseName, @DepartmentID)";

            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@CourseName", c.CoursesName);
            cmd.Parameters.AddWithValue("@DepartmentID", c.DepartmentID);
            db.Connection.Open(); // Open the connection
            int res = cmd.ExecuteNonQuery(); // Execute the query
            db.Connection.Close(); // Ensure the connection is closed after operation
            return res > 0; // Return true if rows were affected, else false
        }

        public DataTable SearchByDeparment(string departments)
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT CourseID, CourseName, Courses.DepartmentID" +
                " FROM (Courses INNER JOIN Departments " +
                "ON Courses.DepartmentID = Departments.DepartmentID) WHERE " +
                "Departments.DepartmentName = @DepartmentName";

            command.Parameters.AddWithValue("@DepartmentName", departments);
            command.Connection = db.Connection;

            DataTable List_Students_By_D = new DataTable();
            adapter.Fill(List_Students_By_D);
            return List_Students_By_D;
        }

        public DataTable SearchByCourseName(string name)
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT CourseID, CourseName, DepartmentID " +
                "FROM Courses WHERE CourseName = @CourseName";

            command.Parameters.AddWithValue("@CourseName", name);
            command.Connection = db.Connection;

            DataTable List_Students_By_N = new DataTable();
            adapter.Fill(List_Students_By_N);
            return List_Students_By_N;
        }

        public DataTable SearchByCoursenameInEnrollment(string name)
        {
            adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            adapter.SelectCommand = cmd;
            cmd.CommandText = "SELECT EnrollmentID, Enrollments.StudentID, Students.FirstName, Students.LastName, Enrollments.CourseID, EnrollmentDate, Grade " +
                "FROM Enrollments INNER JOIN Students ON Enrollments.StudentID = Students.StudentID " +
                "INNER JOIN Courses ON Enrollments.CourseID = Courses.CourseID WHERE Courses.CourseName = @CourseName";

            cmd.Parameters.AddWithValue ("@CourseName", name);
            cmd.Connection = db.Connection;

            DataTable list_course_name = new DataTable();
            adapter.Fill(list_course_name);
            return list_course_name;
        }
    }
}
