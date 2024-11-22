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
    public partial class FormEnrollments : Form
    {
        BLL_Enrollments bLL_Enrollments = new BLL_Enrollments();
        DataTable table_enrollments = new DataTable();
        BLL_Courses bll_courses = new BLL_Courses();
        DataTable table_courses = new DataTable();

        public FormEnrollments()
        {
            InitializeComponent();
        }
        public void CreateButtonInView()
        {
            DataGridViewComboBoxColumn cbb_Courses = new DataGridViewComboBoxColumn();
            cbb_Courses.Name = "CourseName";
            cbb_Courses.HeaderText = "CourseName";
            cbb_Courses.DataSource = bll_courses.GetCourses();
            cbb_Courses.DisplayMember = "CourseName";
            cbb_Courses.ValueMember = "CourseID";
            cbb_Courses.DataPropertyName = "CourseID";

            if (dataGridViewEnrollments.Columns.Count - table_enrollments.Columns.Count == 2)
            {
                dataGridViewEnrollments.Columns.Add(cbb_Courses);
            }

            foreach (DataGridViewRow row in dataGridViewEnrollments.Rows)
            {
                row.Cells["Update"].Value = "Update";
                row.Cells["Delete"].Value = "Delete";
                row.ReadOnly = true;
            }

            dataGridViewEnrollments.Columns["CourseName"].DisplayIndex = dataGridViewEnrollments.ColumnCount - 2;
            dataGridViewEnrollments.Columns["Update"].DisplayIndex = dataGridViewEnrollments.ColumnCount - 1;
            dataGridViewEnrollments.Columns["Delete"].DisplayIndex = dataGridViewEnrollments.ColumnCount - 1;
        }

        public void LoadEnrollments()
        {
            table_enrollments = bLL_Enrollments.GetEnrollments();
            dataGridViewEnrollments.DataSource = table_enrollments;

            dataGridViewEnrollments.Columns["EnrollmentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewEnrollments.Columns["CourseID"].Visible = false;
            CreateButtonInView();
        }

        public void LoadCourses(ComboBox cmb)
        {
            table_courses = bll_courses.GetCourses();
            cmb.DataSource = table_courses;
            cmb.DisplayMember = "CourseName";
            cmb.ValueMember = "CourseID";
        }

        private void FormEnrollmetns_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormEnrollmetns_Load(object sender, EventArgs e)
        {
            LoadEnrollments();
            LoadCourses(cmbCoursesName);
            chkBSearchScore_CheckedChanged(sender, e);
        }

        private void dataGridViewEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string ColumnClick = dataGridViewEnrollments.Columns[e.ColumnIndex].Name;
                string btnClick;
                switch (ColumnClick)
                {
                    case "Update":
                        btnClick = dataGridViewEnrollments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        switch (btnClick)
                        {
                            case "Update":
                                dataGridViewEnrollments.Rows[e.RowIndex].Cells["Update"].Value = "Save";
                                dataGridViewEnrollments.Rows[e.RowIndex].Cells["Delete"].Value = "Cancel";
                                dataGridViewEnrollments.Rows[e.RowIndex].ReadOnly = false;
                                break;
                            case "Save":
                                Enrollments enrollments = new Enrollments();
                                enrollments.StudentID = (int)dataGridViewEnrollments.Rows[e.RowIndex].Cells["StudentID"].Value;
                                enrollments.CourseID = (int)dataGridViewEnrollments.Rows[e.RowIndex].Cells["CourseID"].Value;
                                enrollments.EnrollmentID = (int)dataGridViewEnrollments.Rows[e.RowIndex].Cells["EnrollmentID"].Value;
                                enrollments.EnrollmentDate = (DateTime)dataGridViewEnrollments.Rows[e.RowIndex].Cells["EnrollmentDate"].Value;
                                enrollments.Grade = (int)dataGridViewEnrollments.Rows[e.RowIndex].Cells["Grade"].Value;
                                bLL_Enrollments.UpdateEnrollment(enrollments);
                                LoadEnrollments();
                                MessageBox.Show("Cập nhật thông tin đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridViewEnrollments.Rows[e.RowIndex].Cells["Update"].Value = "Update";
                                dataGridViewEnrollments.Rows[e.RowIndex].Cells["Delete"].Value = "Delete";
                                break;
                        }
                        break;
                    case "Delete":
                        btnClick = dataGridViewEnrollments.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        switch (btnClick)
                        {
                            case "Delete":
                                if ((MessageBox.Show("Bạn muốn xóa trường dữ liệu này?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    == DialogResult.Yes)
                                {
                                    int ID = (int)dataGridViewEnrollments.Rows[e.RowIndex].Cells["CourseID"].Value;
                                    bLL_Enrollments.DeleteEnrollment(ID);
                                    MessageBox.Show("Xóa thông tin đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadEnrollments();
                                }
                                break;
                            case "Cancel":
                                LoadEnrollments();
                                break;
                        }
                        break;
                }
            }

        }

        private void btShowList_Click(object sender, EventArgs e)
        {
            LoadEnrollments();
        }

        private DateTimePicker dP;

        private void dataGridViewEnrollments_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridViewEnrollments.Columns[e.ColumnIndex].Name == "EnrollmentDate")
            {
                dP = new DateTimePicker();
                dataGridViewEnrollments.Controls.Add(dP);

                Rectangle re = dataGridViewEnrollments.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dP.Size = new Size(re.Width, re.Height);
                dP.Location = new Point(re.X, re.Y);

                dP.Format = DateTimePickerFormat.Custom;
                dP.CustomFormat = "dd/MM/yyyy";

                var ngay_sinh = dataGridViewEnrollments.CurrentCell.Value.ToString();
                dP.Value = DateTime.Parse(
                    ngay_sinh,
                    null
                    );

                dP.CloseUp += new EventHandler(dp_Close);

                dP.Visible = true;
            }

        }

        private void dp_Close(object sender, EventArgs e)
        {
            dataGridViewEnrollments.CurrentCell.Value = DateTime.Parse(
                dP.Text
                );

            dP.Visible = false;

            dataGridViewEnrollments.EndEdit();

        }


        private Enrollments GetEnrollmentInfoFromForm()
        {
            Enrollments enrollment = new Enrollments();

            enrollment.EnrollmentID = Convert.ToInt32(txtEnrollmentID.Text);
            enrollment.StudentID = Convert.ToInt32(txtStudentID.Text);
            enrollment.CourseID = Convert.ToInt32(cmbCoursesName.SelectedValue.ToString());

            enrollment.EnrollmentDate = dTPEnrollmentDate.Value;

            // Convert Grade and Score, assuming these are integers
            enrollment.Grade = Convert.ToInt32(tbGrade.Text);


            return enrollment;
        }

        private void btnAddEnrollments_Click(object sender, EventArgs e)
        {
            Enrollments enrollments = GetEnrollmentInfoFromForm();

            if(bLL_Enrollments.AddEnrollment(enrollments))
            {
                MessageBox.Show("Thêm thông tin thành công");
                LoadEnrollments();
                ClearAll1();
            }
            else
            {
                MessageBox.Show("Nhập lại ID Enrollment:");
                txtEnrollmentID.Focus();

            }
        }

        private void ClearAll1()
        {
            txtEnrollmentID.Clear();
            txtStudentID.Clear();
            cmbCoursesName.SelectedIndex = -1;

            tbGrade.Clear();
            txtEnrollmentID.Focus();
        }

        private void btReportAVGScore_Click(object sender, EventArgs e)
        {
            FormReportAvgScore formReportAvgScore = new FormReportAvgScore();
            formReportAvgScore.ShowDialog();
        }

        private void chkBSearchScore_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBSearchScore.Checked)
            {
                chkSearchStudentName.Visible = true;
                chkSearchCourseName.Visible = true;
                txtSearchStudent.Visible = false;
                cbxSearchCourse.Visible = false;
                btSearchStudent.Visible = false;
            }
            else
            {
                chkSearchStudentName.Visible = false;
                chkSearchCourseName.Visible = false;
                txtSearchStudent.Visible = false;
                cbxSearchCourse.Visible = false;
                btSearchStudent.Visible = false;

            }
        }

        private void cbxSearchCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string course = cbxSearchCourse.Text;
            table_courses = bll_courses.SearchCourseInEnrollment(course);
            dataGridViewEnrollments.DataSource = table_courses;
            CreateButtonInView();
        }

        private void chkSearchStudentName_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSearchStudentName.Checked)
            {
                txtSearchStudent.Visible = true;
                btSearchStudent.Visible = true;
                chkSearchCourseName.Visible = false;
                cbxSearchCourse.Visible = false;
            }
            else
            {
                txtSearchStudent.Visible = true;
                btSearchStudent.Visible = true;
                chkSearchCourseName.Visible = true;
                cbxSearchCourse.Visible = true;
            }
        }

        private void chkSearchCourseName_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSearchCourseName.Checked)
            {
                txtSearchStudent.Visible = false;
                btSearchStudent.Visible = false;
                chkSearchStudentName.Visible = false;
                chkSearchCourseName.Visible = true;
                cbxSearchCourse.Visible = true;
                LoadCourses(cbxSearchCourse);

            }
            else
            {
                txtSearchStudent.Visible = true;
                btSearchStudent.Visible = true;
                chkSearchCourseName.Visible = true;
                cbxSearchCourse.Visible = true;
                chkSearchStudentName.Visible = true;
            }
        }

        private void btSearchStudent_Click(object sender, EventArgs e)
        {
            DataTable table_Students = new DataTable();
            BLLStudents bll_Students = new BLLStudents();
            string lastname = txtSearchStudent.Text;

            // Kiểm tra nếu textbox rỗng
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Vui lòng nhập tên của sinh viên cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm kiếm sinh viên theo họ
            table_Students = bll_Students.SearchByLastName(lastname);

            // Kiểm tra kết quả tìm kiếm
            if (table_Students.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên với tên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Gán kết quả vào DataGridView
                dataGridViewEnrollments.DataSource = table_Students;
                CreateButtonInView();
            }

        }
    }
}
