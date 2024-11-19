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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btQLSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            cbSearch formStudents = new cbSearch();
            formStudents.ShowDialog();
        }

        private void btQLK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDepartment formDepartment = new FormDepartment();
            formDepartment.ShowDialog();
        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCourses formCourses = new FormCourses();
            formCourses.ShowDialog();
        }

        private void btQLDS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEnrollmetns formEnrollmetns = new FormEnrollmetns();
            formEnrollmetns.ShowDialog();
        }
    }
}
