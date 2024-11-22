using BussinessLogic;
using DTO;
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
    public partial class FormCourses : Form
    {
        BLL_Courses bLL_Courses = new BLL_Courses();
        DataTable table_Courses = new DataTable();
        DataTable table_Department = new DataTable();

        public FormCourses()
        {
            InitializeComponent();
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadDepartments(cbxDepartmentName);
            cbSearchCourses_CheckedChanged(sender, e);
        }

        public void LoadDepartments(ComboBox cmb)
        {
            table_Department = bLL_Courses.GetDepartment();
            cmb.DataSource = table_Department;
            cmb.DisplayMember = "DepartmentName";
            cmb.ValueMember = "DepartmentID";
        }

        public void CreateButtonInView()
        {
            DataGridViewComboBoxColumn cbb_Department = new DataGridViewComboBoxColumn();
            cbb_Department.Name = "DepartmentName";
            cbb_Department.HeaderText = "DepartmentName";
            cbb_Department.DataSource = bLL_Courses.GetDepartment();
            cbb_Department.DisplayMember = "DepartmentName";
            cbb_Department.ValueMember = "DepartmentID";
            cbb_Department.DataPropertyName = "DepartmentID";

            if (dataGridViewCourses.Columns.Count - table_Courses.Columns.Count == 2)
            {
                dataGridViewCourses.Columns.Add(cbb_Department);
            }
            foreach (DataGridViewRow row in dataGridViewCourses.Rows)
            {
                row.Cells["Update"].Value = "Update";
                row.Cells["Delete"].Value = "Delete";
                row.ReadOnly = true;
            }

            dataGridViewCourses.Columns["Update"].DisplayIndex = dataGridViewCourses.ColumnCount - 1;
            dataGridViewCourses.Columns["Delete"].DisplayIndex = dataGridViewCourses.ColumnCount - 1;
        }

        public void LoadCourses()
        {
            table_Courses = bLL_Courses.GetCourses();
            dataGridViewCourses.DataSource = table_Courses;

            dataGridViewCourses.Columns["DepartmentID"].Visible = false;

            CreateButtonInView();
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string ColumnClick = dataGridViewCourses.Columns[e.ColumnIndex].Name;
                string btnClick;
                switch (ColumnClick)
                {
                    case "Update":
                        btnClick = dataGridViewCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        switch (btnClick)
                        {
                            case "Update":
                                dataGridViewCourses.Rows[e.RowIndex].Cells["Update"].Value = "Save";
                                dataGridViewCourses.Rows[e.RowIndex].Cells["Delete"].Value = "Cancel";
                                dataGridViewCourses.Rows[e.RowIndex].ReadOnly = false;
                                break;
                            case "Save":
                                Courses courses = new Courses();
                                courses.CoursesID = (int)dataGridViewCourses.Rows[e.RowIndex].Cells["CourseID"].Value;
                                courses.CoursesName = dataGridViewCourses.Rows[e.RowIndex].Cells["CourseName"].Value.ToString();
                                courses.DepartmentID = (int)dataGridViewCourses.Rows[e.RowIndex].Cells["DepartmentID"].Value;
                                bLL_Courses.UpdateCourses(courses);
                                LoadCourses();
                                MessageBox.Show("Cập nhật thông tin cho khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridViewCourses.Rows[e.RowIndex].Cells["Update"].Value = "Update";
                                dataGridViewCourses.Rows[e.RowIndex].Cells["Delete"].Value = "Delete";
                                break;
                        }
                        break;
                    case "Delete":
                        btnClick = dataGridViewCourses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        switch (btnClick)
                        {
                            case "Delete":
                                if ((MessageBox.Show("Bạn muốn xóa khóa học này?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    == DialogResult.Yes)
                                {
                                    string ID = dataGridViewCourses.Rows[e.RowIndex].Cells["CourseID"].Value.ToString();
                                    bLL_Courses.DeleteCourses(ID);
                                    MessageBox.Show("Xóa khóa học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadCourses();
                                }
                                break;
                            case "Cancel":
                                LoadCourses();
                                break;
                        }
                        break;

                }
            }
        }


        private void btAddCourses_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses
            {
                CoursesID = Convert.ToInt32(txtIDCourse.Text),
                CoursesName = txtCourseName.Text,
                DepartmentID = Convert.ToInt32(cbxDepartmentName.SelectedValue),
            };

            if (bLL_Courses.AddCourses(courses))
            {
                MessageBox.Show("Thêm khóa học mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearAll1()
        {
            txtIDCourse.Clear();
            txtCourseName.Clear();

            cbxDepartmentName.SelectedIndex = -1;

            txtIDCourse.Focus();
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            ClearAll1();
        }

        private void btShowList_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void cbSearchCourses_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearchCourses.Checked)
            {
                txtSearchCourses.Visible = false;
                cbSearchCoursesName.Visible = true;
                cbxSearchDepartment.Visible = false;
                cbSearchDepartment.Visible = true;
                btOK.Visible = false;
            }
            else
            {
                txtSearchCourses.Visible = false;
                cbSearchCoursesName.Visible = false;
                cbxSearchDepartment.Visible = false;
                cbSearchDepartment.Visible = false;
                btOK.Visible = false;
            }

        }

        private void cbxSearchDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departments = cbxSearchDepartment.Text;
            table_Courses = bLL_Courses.SearchByDepartment(departments);
            dataGridViewCourses.DataSource = table_Courses;
            CreateButtonInView();

        }

        private void cbSearchCoursesName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearchCoursesName.Checked)
            {
                txtSearchCourses.Visible = true;
                btOK.Visible = true;
                cbSearchDepartment.Visible = false;
                cbxSearchDepartment.Visible = false;
            }
            else
            {
                txtSearchCourses.Visible = true;
                btOK.Visible = true;
                cbxSearchDepartment.Visible = true;
                cbSearchDepartment.Visible = true;
            }
        }

        private void cbSearchDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearchDepartment.Checked == true)
            {
                txtSearchCourses.Visible = false;
                cbSearchCourses.Visible = false;
                btOK.Visible = false;
                LoadDepartments(cbxSearchDepartment);

            }
            else
            {
                txtSearchCourses.Visible = true;
                cbSearchCourses.Visible = true;
                btOK.Visible = true;
                cbxSearchDepartment.Visible = true;
            }

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string nameCourse = txtSearchCourses.Text;

            // Kiểm tra nếu textbox rỗng
            if (string.IsNullOrWhiteSpace(nameCourse))
            {
                MessageBox.Show("Vui lòng nhập tên của khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm kiếm sinh viên theo họ
            table_Courses = bLL_Courses.SearchByCourseName(nameCourse);

            // Kiểm tra kết quả tìm kiếm
            if (table_Courses.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khóa học nào trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Gán kết quả vào DataGridView
                dataGridViewCourses.DataSource = table_Courses;
                CreateButtonInView();
            }

        }

        private void FormCourses_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                // Hide the current form
                this.Hide();

                // Show the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
        }
    }
}
