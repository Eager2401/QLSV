using BussinessLogic;
using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FormReportAvgScore : Form
    {
        public FormReportAvgScore()
        {
            InitializeComponent();
        }

        private void FormReportAvgScore_Load(object sender, EventArgs e)
        {
            BLL_Enrollments  bLL_Enrollments = new BLL_Enrollments();
            DataTable table_enrollments = bLL_Enrollments.ReportAVGScore();

            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("C:\\Users\\Admin\\source\\repos\\QLSV\\CRAVGSccore.rpt"); // Đường dẫn đến file .rpt

            // Đưa dữ liệu vào báo cáo
            reportDocument.SetDataSource(table_enrollments);
            crVReportAvgScore.ReportSource = reportDocument;
            crVReportAvgScore.Refresh();
        }
    }
}
