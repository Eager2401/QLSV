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
    public partial class FormReportCountStudent : Form
    {
        public FormReportCountStudent()
        {
            InitializeComponent();
        }


        private void crystalReportViewerCountStudent_Load(object sender, EventArgs e)
        {
            BLLStudents bLLStudents = new BLLStudents();
            DataTable table_CountStudent = bLLStudents.ReportStudentCount();

            ReportDocument report = new ReportDocument();
            report.Load("C:\\Users\\Admin\\source\\repos\\QLSV\\CRCountStudent.rpt");

            report.SetDataSource(table_CountStudent);
            crystalReportViewerCountStudent.ReportSource = report;
            crystalReportViewerCountStudent.Refresh();

        }
    }
}
