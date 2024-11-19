using BussinessLogic;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FormCourCountByDepartment : Form
    {
        public FormCourCountByDepartment()
        {
            InitializeComponent();
        }

        private void crVCourseCount_Load(object sender, EventArgs e)
        {
            BLL_Departments bLL_Departments = new BLL_Departments();
            DataTable table_courseCount = bLL_Departments.GetCourseCount();

            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Admin\\source\\repos\\QLSV\\CRCourseCountByDepartment.rpt");

            report.SetDataSource(table_courseCount);
            crVCourseCount.ReportSource = report;
            crVCourseCount.Refresh();

        }
    }
}
