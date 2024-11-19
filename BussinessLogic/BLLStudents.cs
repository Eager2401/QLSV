using DataAccss;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class BLLStudents
    {
        DA_Students da_students = new DA_Students();

        public DataTable GetAllStudents()
        {
            return da_students.LoadListStudents();
        }

        public DataTable GetDepartment()
        {
            return da_students.LoadListDepartment();
        }
        public int DeleteStudents(string ID)
        {
            return da_students.DeleteStudents(int.Parse(ID));
        }

        public int UpdateStudent(Students s)
        {
            return da_students.UpdateStudents(s);
        }

        public bool AddStudents(Students s)
        {
            bool IDExist = da_students.CheckIDExist(s.StudentID);
            if (IDExist)
            {
                return false;
            }
            else
            {
                return da_students.AddStudents(s);
            }
        }

        public DataTable SearchByDepartment(string departments)
        {
            return da_students.SearchByDeparment(departments);
        }

        public DataTable SearchByLastName(string lastName)
        {
            return da_students.SearchByLastName(lastName);
        }

        public DataTable ReportStudentByDepartment() 
        {
            return da_students.GetStudentsByDepartment();
        }


        public DataTable ReportStudentCount()
        {
            return da_students.GetStudentCount();
        }
    }
}
