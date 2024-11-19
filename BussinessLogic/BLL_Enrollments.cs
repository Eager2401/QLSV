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
    public class BLL_Enrollments
    {
        private DA_Enrollments dal = new DA_Enrollments();

        public DataTable GetEnrollments()
        {
            return dal.LoadListEnrollments();
        }

        // Add a new enrollment
        public bool AddEnrollment(Enrollments enrollment)
        {
            return dal.AddEnrollment(enrollment);
        }

        // Update an existing enrollment
        public bool UpdateEnrollment(Enrollments enrollment)
        {
            return dal.UpdateEnrollment(enrollment) > 0;
        }

        // Delete an enrollment by ID
        public bool DeleteEnrollment(int enrollmentID)
        {
            return dal.DeleteEnrollment(enrollmentID) > 0;
        }

        // Search enrollments by CourseID
        public DataTable SearchByCourseID(int courseID)
        {
            return dal.SearchByCourseID(courseID);
        }

        // Search enrollments by StudentID
        public DataTable SearchByStudentID(int studentID)
        {
            return dal.SearchByStudentID(studentID);
        }

        public DataTable ReportAVGScore()
        {
            return dal.GetAvgScoreByCourse();
        }
    }
}
