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
    public class BLL_Departments
    {
        DA_Departments _Departments = new DA_Departments();

        public DataTable GetDepartment()
        {
            return _Departments.LoadListDepartment();
        }
        public int Delete(string ID)
        {
            return _Departments.Delete(int.Parse(ID));
        }

        public int Update(Departments d)
        {
            return _Departments.Update(d);
        }

        public bool Add(Departments d)
        {
            bool IDExist = _Departments.CheckIDExist(d.DepartmentID);
            if (IDExist)
            {
                return false;
            }
            else
            {
                return _Departments.Add(d);
            }
        }

        public DataTable SearchByDepartment(string departments)
        {
            return _Departments.SearchByDeparment(departments);
        }

        public DataTable GetCourseCount()
        {
            return _Departments.GetCourseCount();
        }
    }
}
