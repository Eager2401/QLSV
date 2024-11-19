using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccss
{
    public class DA_Departments
    {
        Database db = new Database();
        SqlDataAdapter SqlDataAdapter = new SqlDataAdapter();
        public DataTable LoadListDepartment()
        {
            SqlDataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter.SelectCommand = command;
            command.CommandText = "SELECT DepartmentID, DepartmentName FROM Departments";
            command.Connection = db.Connection;

            DataTable List_Departments = new DataTable();
            SqlDataAdapter.Fill(List_Departments);

            return List_Departments;
        }

        public int Delete(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE Departments WHERE DepartmentID=@DepartmentID";
            command.Connection = db.Connection;
            command.Parameters.AddWithValue("@DepartmentID", id);

            db.Connection.Open();

            int res = command.ExecuteNonQuery();
            db.Connection.Close();

            return res;
        }

        public int Update(Departments departments)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Departments SET DepartmentName=@DepartmentName WHERE DepartmentID=@DepartmentID";
            cmd.Connection = db.Connection;
            cmd.Parameters.AddWithValue("@DepartmentID", departments.DepartmentID);
            cmd.Parameters.AddWithValue("@DepartmentName", departments.DepartmentName);

            db.Connection.Open();
            int res = cmd.ExecuteNonQuery();
            db.Connection.Close();

            return res;
        }

        public bool Add(Departments departments)
        {
            string query = "INSERT INTO Departments(DepartmentID, DepartmentName) VALUES (@DepartmentID, @DepartmentName)";

            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@DepartmentID", departments.DepartmentID);
            cmd.Parameters.AddWithValue("@DepartmentName", departments.DepartmentName);

            db.Connection.Open(); // Open the connection
            int res = cmd.ExecuteNonQuery(); // Execute the query
            db.Connection.Close(); // Ensure the connection is closed after operation
            return res > 0; // Return true if rows were affected, else false
        }

        public bool CheckIDExist(int ID)
        {
            string query = "SELECT * FROM Departments WHERE DepartmentID = @DepartmentID";

            SqlCommand cmd = new SqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@DepartmentID", ID); // Tránh SQL Injection
            db.Connection.Open();
            var exists = cmd.ExecuteScalar();
            db.Connection.Close();
            if (exists != null)
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
            SqlDataAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter.SelectCommand = command;
            command.CommandText = "SELECT * FROM Departments WHERE DepartmentName = @DepartmentName";

            command.Parameters.AddWithValue("@DepartmentName", departments);
            command.Connection = db.Connection;

            DataTable List_Students_By_D = new DataTable();
            SqlDataAdapter.Fill(List_Students_By_D);
            return List_Students_By_D;
        }

        public DataTable GetCourseCount()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM View_CourseCountByDepartment";
            SqlDataAdapter adapter = new SqlDataAdapter(query, db.Connection);
            adapter.Fill(dt);

            return dt;
        }
    }
}
