using BussinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class cbSearch : Form
    {
        BLLStudents bll_Students = new BLLStudents();
        DataTable table_Students = new DataTable();
        DataTable table_Department = new DataTable();


        public cbSearch()
        {
            InitializeComponent();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadDepartments(cbxDepartmentName);
            cbSearchStudents_CheckedChanged(sender, e);
        }
        //Tải dữ liệu vào comboBox
        public void LoadDepartments(ComboBox cmb)
        {
            table_Department = bll_Students.GetDepartment();
            cmb.DataSource = table_Department;
            cmb.DisplayMember = "DepartmentName";
            cmb.ValueMember = "DepartmentID";
        }
        //Hàm tạo các button ở trong view
        public void CreateButtonInView()
        {
            DataGridViewComboBoxColumn cbb_Department = new DataGridViewComboBoxColumn();
            cbb_Department.Name = "DepartmentName";
            cbb_Department.HeaderText = "DepartmentName";
            cbb_Department.DataSource = bll_Students.GetDepartment();
            cbb_Department.DisplayMember = "DepartmentName";
            cbb_Department.ValueMember = "DepartmentID";
            cbb_Department.DataPropertyName = "DepartmentID";

            //Thêm ComboBox vào DataGridView
            if (dataGridViewStudents.Columns.Count - table_Students.Columns.Count == 2)
            {
                dataGridViewStudents.Columns.Add(cbb_Department);
            }

            //Thiết lập các giá trị hiển thị của các button
            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                row.Cells["Update"].Value = "Update";
                row.Cells["Delete"].Value = "Delete";
                row.ReadOnly = true;//Không cho phép chỉnh sửa trước khi user nhấn vào button
            }
            //Thiết lập vị trí của các cột được thêm vào
            dataGridViewStudents.Columns["Update"].DisplayIndex = dataGridViewStudents.ColumnCount - 1;
            dataGridViewStudents.Columns["Delete"].DisplayIndex = dataGridViewStudents.ColumnCount - 1;
        }

        public void LoadStudents()
        {
            table_Students = bll_Students.GetAllStudents();
            dataGridViewStudents.DataSource = table_Students;
            //Đặt định dạng ngày
            dataGridViewStudents.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //Không hiển thị cột
            dataGridViewStudents.Columns["DepartmentID"].Visible = false;

            CreateButtonInView();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string ColumnClick = dataGridViewStudents.Columns[e.ColumnIndex].Name;
                string btnClick;
                switch (ColumnClick)
                {
                    case "Update":
                        btnClick = dataGridViewStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        switch (btnClick)
                        {
                            case "Update":
                                dataGridViewStudents.Rows[e.RowIndex].Cells["Update"].Value = "Save";
                                dataGridViewStudents.Rows[e.RowIndex].Cells["Delete"].Value = "Cancel";
                                dataGridViewStudents.Rows[e.RowIndex].ReadOnly = false;
                                break;
                            case "Save":
                                Students students = new Students();
                                students.StudentID = (int)dataGridViewStudents.Rows[e.RowIndex].Cells["StudentID"].Value;
                                students.FirstName = dataGridViewStudents.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                                students.LastName = dataGridViewStudents.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                                students.DateOfBirth = (DateTime)dataGridViewStudents.Rows[e.RowIndex].Cells["DateOfBirth"].Value;
                                students.Gender = dataGridViewStudents.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                                students.DepartmentID = (int)dataGridViewStudents.Rows[e.RowIndex].Cells["DepartmentID"].Value;
                                bll_Students.UpdateStudent(students);
                                LoadStudents();
                                MessageBox.Show("Cập nhật thông tin cho sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridViewStudents.Rows[e.RowIndex].Cells["Update"].Value = "Update";
                                dataGridViewStudents.Rows[e.RowIndex].Cells["Delete"].Value = "Delete";
                                break;
                        }
                        break;
                    case "Delete":
                        btnClick = dataGridViewStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        switch (btnClick)
                        {
                            case "Delete":
                                if ((MessageBox.Show("Bạn muốn xóa sinh viên này?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    == DialogResult.Yes)
                                {
                                    string ID = dataGridViewStudents.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                                    bll_Students.DeleteStudents(ID);
                                    MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadStudents();
                                }
                                break;
                            case "Cancel":
                                LoadStudents();
                                break;
                        }
                        break;
                }
            }

        }


        private DateTimePicker dP;

        private void dataGridViewStudents_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridViewStudents.Columns[e.ColumnIndex].Name == "DateOfBirth")
            {
                dP = new DateTimePicker();
                dataGridViewStudents.Controls.Add(dP);

                Rectangle re = dataGridViewStudents.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dP.Size = new Size(re.Width, re.Height);
                dP.Location = new Point(re.X, re.Y);

                dP.Format = DateTimePickerFormat.Custom;
                dP.CustomFormat = "dd/MM/yyyy";

                var ngay_sinh = dataGridViewStudents.CurrentCell.Value.ToString();
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
            dataGridViewStudents.CurrentCell.Value = DateTime.Parse(
                dP.Text
                );

            dP.Visible = false;

            dataGridViewStudents.EndEdit();

        }

        private Students GetInfoStudents()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("ID không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return null;
            }

            Students students = new Students();
            students.StudentID = Convert.ToInt32(txtID.Text);
            students.FirstName = txtFname.Text;
            students.LastName = txtLName.Text;
            students.DateOfBirth = dateTimePickerDOB.Value;
            DateTime today = DateTime.Today;
            DateTime minBirthDate = today.AddYears(-18); // Ngày tối thiểu là 18 năm trước
            if (students.DateOfBirth > minBirthDate)
            {
                MessageBox.Show("Sinh viên phải từ 18 tuổi trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerDOB.Focus();
                return null;
            }

            students.Gender = rBtnFemale.Checked ? "F" : "M";
            students.DepartmentID = Convert.ToInt32(cbxDepartmentName.SelectedValue.ToString());

            return students;
        }

        private void btAddStudents_Click(object sender, EventArgs e)
        {
            Students students = GetInfoStudents();

            if (bll_Students.AddStudents(students))
            {
                MessageBox.Show("Thêm sinh viên thành công");
                LoadStudents();
                ClearAll1();
            }
            else
            {
                MessageBox.Show("Nhập lại ID:");
                txtID.Focus();
            }
            
        }
        
        private void ClearAll1()
        {
            txtID.Clear(); 
            txtFname.Clear();
            txtLName.Clear();

            cbxDepartmentName.SelectedIndex = -1;
            rBtnMale.Checked = false;

            txtID.Focus();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ClearAll1();
        }

        private void cbSearchStudents_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearchStudents.Checked)
            {
                cbSearchID.Visible = true;
                txtSearchName.Visible = false;
                cbSearchDepartment.Visible = true;
                cbxSearchDepartment.Visible = false;
                btOK.Visible = false;
            }
            else
            {
                cbSearchID.Visible = false;
                txtSearchName.Visible = false;
                cbSearchDepartment.Visible = false;
                cbxSearchDepartment.Visible = false;
                btOK.Visible = false;
            }

        }

        private void cbSearchID_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSearchID.Checked)
            {
                txtSearchName.Visible = true;
                btOK.Visible = true;
                cbSearchDepartment.Visible = false;
                cbxSearchDepartment.Visible = false ;
            }
            else
            {
                txtSearchName.Visible = true;
                btOK.Visible = true;
                cbxSearchDepartment.Visible = true;
                cbSearchDepartment.Visible = true;
            }
        }

        private void cbSearchDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearchDepartment.Checked == true)
            {
                txtSearchName.Visible = false;
                cbSearchID.Visible = false;
                btOK.Visible = false;
                LoadDepartments(cbxSearchDepartment);

            }
            else
            {
                txtSearchName.Visible = true;
                cbSearchID.Visible = true;
                btOK.Visible = true;
                cbxSearchDepartment.Visible = true;
            }

        }

        private void cbxSearchDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departments = cbxSearchDepartment.Text;
            table_Students = bll_Students.SearchByDepartment(departments);
            dataGridViewStudents.DataSource = table_Students;
            CreateButtonInView();
        }

        private void btShowList_Click(object sender, EventArgs e)
        {
            if(cbSearchDepartment.Checked == true)
            {
                cbSearchDepartment.Checked = false;
                cbxSearchDepartment.SelectedIndex = -1;
            }
            else if(cbSearchID.Checked == true)
            {
                cbSearchID.Checked = false;
                txtSearchName.Clear();
            }
            else
            {
                ClearAll1();
            }
            LoadStudents();

        }

        private void btOK_Click(object sender, EventArgs e)
        {

            string lastname = txtSearchName.Text;

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
                MessageBox.Show("Không tìm thấy sinh viên với họ tên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Gán kết quả vào DataGridView
                dataGridViewStudents.DataSource = table_Students;
                CreateButtonInView();
            }
        }

        private void cbSearch_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btReportStudentByD_Click(object sender, EventArgs e)
        {
            FormReportStudentByDepartment formReportStudentByDepartment = new FormReportStudentByDepartment();
            formReportStudentByDepartment.Show();
        }

        private void btGetStudentCount_Click(object sender, EventArgs e)
        {
            FormReportCountStudent formGetStudentCount  = new FormReportCountStudent();
            formGetStudentCount.Show();
        }
    }
}
