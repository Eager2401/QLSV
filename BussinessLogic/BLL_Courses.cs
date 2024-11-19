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
    public class BLL_Courses
    {
        DA_Courses _Courses = new DA_Courses();

        public DataTable GetCourses()
        {
            return _Courses.LoadListCourses();
        }
        public DataTable GetDepartment()
        {
            return _Courses.LoadListDepartment();
        }
        public int DeleteCourses(string ID)
        {
            return _Courses.DeleteCourses(int.Parse(ID));
        }

        public int UpdateCourses(Courses c)
        {
            return _Courses.UpdateCourses(c);
        }

        public bool AddCourses(Courses c)
        {
            return _Courses.AddCourses(c);

        }

        public DataTable SearchByDepartment(string departments)
        {
            return _Courses.SearchByDeparment(departments);
        }

        public DataTable SearchByCourseName(string CourseName)
        {
            return _Courses.SearchByCourseName(CourseName);
        }

        public DataTable SearchCourseInEnrollment(string name)
        {
            return _Courses.SearchByCoursenameInEnrollment(name);
        }
    }
}
