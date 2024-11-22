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
    public class DA_Students
    {
        Database db = new Database();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapterDepartment = new SqlDataAdapter();

        public DataTable LoadListStudents()
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT StudentID, FirstName, LastName, DateOfBirth, Gender, Students.DepartmentID" +
                " FROM Students INNER JOIN Departments " +
                "ON Students.DepartmentID = Departments.DepartmentID";
            command.Connection = db.Connection;

            DataTable List_Students = new DataTable();
            adapter.Fill(List_Students);
            return List_Students;
        }

        public DataTable LoadListDepartment()
        {
            adapterDepartment = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapterDepartment.SelectCommand = command;
            command.CommandText = "SELECT DepartmentID, DepartmentName FROM Departments";
            command.Connection = db.Connection;

            DataTable List_Departments = new DataTable();
            adapterDepartment.Fill(List_Departments);

            return List_Departments;
        }

        public int DeleteStudents(int ID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE Students WHERE StudentID=@StudentID";
            command.Connection = db.Connection;
            command.Parameters.AddWithValue("@StudentID", ID);

            db.Connection.Open();

            int res = command.ExecuteNonQuery();
            db.Connection.Close();

            return res;
        }
        public int UpdateStudents(Students students)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Students SET FirstName=@FirstName, LastName=@LastName," +
                "DateOfBirth=@DateOfBirth, Gender=@Gender, DepartmentID=@DepartmentID WHERE StudentID=@StudentID";
            cmd.Connection = db.Connection;
            cmd.Parameters.AddWithValue("@StudentID", students.StudentID);
            cmd.Parameters.AddWithValue("@FirstName", students.FirstName);
            cmd.Parameters.AddWithValue("@LastName", students.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", students.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", students.Gender);
            cmd.Parameters.AddWithValue("@DepartmentId", students.DepartmentID);

            db.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return res;
        }

        public bool AddStudents(Students students)
        {
            string query = "INSERT INTO Students(StudentID, FirstName, LastName, DateOfBirth, Gender," +
                "DepartmentID) VALUES (@StudentID, @FirstName, @LastName, @DateOfBirth, @Gender, @DepartmentID)";

            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@StudentID", students.StudentID);
            cmd.Parameters.AddWithValue("@FirstName", students.FirstName);
            cmd.Parameters.AddWithValue("@LastName", students.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", students.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", students.Gender);
            cmd.Parameters.AddWithValue("@DepartmentID", students.DepartmentID);
            db.Connection.Open(); // Open the connection
            int res = cmd.ExecuteNonQuery(); // Execute the query
            db.Connection.Close(); // Ensure the connection is closed after operation
            return res > 0; // Return true if rows were affected, else false
        }
        public bool CheckIDExist(int ID)
        {
            string query = "SELECT * FROM Students WHERE StudentID = @StudentID";

            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@StudentID", ID); // Tránh SQL Injection
            db.Connection.Open();
            var exists = cmd.ExecuteScalar();
            db.Connection.Close();
            if(exists != null)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public DataTable SearchByDeparment(string departments)
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT StudentID, FirstName, LastName, DateOfBirth, Gender, Students.DepartmentID" +
                " FROM (Students INNER JOIN Departments " +
                "ON Students.DepartmentID = Departments.DepartmentID) WHERE " +
                "Departments.DepartmentName = @DepartmentName";

            command.Parameters.AddWithValue("@DepartmentName", departments);
            command.Connection = db.Connection;

            DataTable List_Students_By_D = new DataTable();
            adapter.Fill(List_Students_By_D);
            return List_Students_By_D;
        }

        public DataTable GetStudentsByDepartment()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT StudentID, FirstName, LastName, Gender, DepartmentID FROM Students", db.Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }


        public DataTable SearchByLastName(string name)
        {
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            command.CommandText = "SELECT StudentID, FirstName, LastName, DateOfBirth, Gender, Students.DepartmentID" +
                " FROM Students WHERE " +
                "FirstName = @FirstName";

            command.Parameters.AddWithValue("@FirstName", name);
            command.Connection = db.Connection;

            DataTable List_Students_By_N = new DataTable();
            adapter.Fill(List_Students_By_N);
            return List_Students_By_N;
        }

        public DataTable GetStudentCount()
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM View_StudentCountByDepartment";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.Connection);
            adapter.Fill(data);

            return data;

        }
    }
}

