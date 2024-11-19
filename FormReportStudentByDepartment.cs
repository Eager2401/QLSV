using BussinessLogic;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class FormReportStudentByDepartment : Form
    {
        BLLStudents bll_students = new BLLStudents();
        public FormReportStudentByDepartment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Students students = new Students();
            
            DataTable table_students = bll_students.ReportStudentByDepartment();
            DataTable table_report = new DataTable();

            ReportDataSource rds = new ReportDataSource("StudentDataSet", table_students);
            this.rpVStudentByDepartment.LocalReport.DataSources.Clear();
            this.rpVStudentByDepartment.LocalReport.DataSources.Add(rds);
            this.rpVStudentByDepartment.LocalReport.ReportPath = "C:\\Users\\Admin\\source\\repos\\QLSV\\ReportSinhvienTheoKhoa.rdlc";

            this.rpVStudentByDepartment.RefreshReport();
        }

    }
}
