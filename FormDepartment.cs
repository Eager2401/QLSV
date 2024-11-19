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
    public partial class FormDepartment : Form
    {
        BLL_Departments bLL_Departments = new BLL_Departments();
        DataTable table_Department = new DataTable();

        public FormDepartment()
        {
            InitializeComponent();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartment();
            chkSearchDepartment_CheckedChanged(sender, e);
        }

        public void LoadDepartmentOnCmb(ComboBox cmb)
        {
            table_Department = bLL_Departments.GetDepartment();
            cmb.DataSource = table_Department;
            cmb.DisplayMember = "DepartmentName";
            cmb.ValueMember = "DepartmentID";
        }

        public void LoadDepartment()
        {
            table_Department = bLL_Departments.GetDepartment();
            dataGridViewDepartment.DataSource = table_Department;


            CreateButtonInView();

        }

        public void CreateButtonInView()
        {
            foreach (DataGridViewRow row in dataGridViewDepartment.Rows)
            {
                row.Cells["Update"].Value = "Update";
                row.Cells["Delete"].Value = "Delete";
                row.ReadOnly = true;
            }

            dataGridViewDepartment.Columns["Update"].DisplayIndex = dataGridViewDepartment.ColumnCount - 1;
            dataGridViewDepartment.Columns["Delete"].DisplayIndex = dataGridViewDepartment.ColumnCount - 1;

        }

        private void dataGridViewDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string ColumnClick = dataGridViewDepartment.Columns[e.ColumnIndex].Name;
                string btnClick;
                switch (ColumnClick)
                {
                    case "Update":
                        btnClick = dataGridViewDepartment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        switch (btnClick)
                        {
                            case "Update":
                                dataGridViewDepartment.Rows[e.RowIndex].Cells["Update"].Value = "Save";
                                dataGridViewDepartment.Rows[e.RowIndex].Cells["Delete"].Value = "Cancel";
                                dataGridViewDepartment.Rows[e.RowIndex].ReadOnly = false;
                                break;
                            case "Save":
                                Departments departments = new Departments();
                                departments.DepartmentID = (int)dataGridViewDepartment.Rows[e.RowIndex].Cells["DepartmentID"].Value;
                                departments.DepartmentName = dataGridViewDepartment.Rows[e.RowIndex].Cells["DepartmentName"].Value.ToString();
                                bLL_Departments.Update(departments);
                                LoadDepartment();
                                MessageBox.Show("Cập nhật thông tin cho khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridViewDepartment.Rows[e.RowIndex].Cells["Update"].Value = "Update";
                                dataGridViewDepartment.Rows[e.RowIndex].Cells["Delete"].Value = "Delete";
                                break;
                        }
                        break;
                    case "Delete":
                        btnClick = dataGridViewDepartment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        switch (btnClick)
                        {
                            case "Delete":
                                if ((MessageBox.Show("Bạn muốn xóa khoa này?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                    == DialogResult.Yes)
                                {
                                    string ID = dataGridViewDepartment.Rows[e.RowIndex].Cells["DepartmentID"].Value.ToString();
                                    bLL_Departments.Delete(ID);
                                    MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDepartment();
                                }
                                break;
                            case "Cancel":
                                LoadDepartment();
                                break;
                        }
                        break;
                }

            }
        }

        private void ClearAll1()
        {
            txtDepartmentID.Clear();
            tbAddDepartment.Clear();

            txtDepartmentID.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll1();
        }

        private void chkSearchDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchDepartment.Checked == true)
            {
                lbSearchByDName.Visible = true;
                cmbSearhDName.Visible = true;
                LoadDepartmentOnCmb(cmbSearhDName);
            }
            else
            {
                lbSearchByDName.Visible = false;
                cmbSearhDName.Visible = false;
            }

        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (chkSearchDepartment.Checked == true)
            {
                chkSearchDepartment.Checked = false;
                cmbSearhDName.SelectedIndex = -1;
                chkSearchDepartment_CheckedChanged(sender, e);
            }
            else
            {
                ClearAll1();
            }
            LoadDepartment();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Departments newDepartments = new Departments
            {
                DepartmentID = Convert.ToInt32(txtDepartmentID.Text),
                DepartmentName = tbAddDepartment.Text
            };

            if (bLL_Departments.Add(newDepartments))
            {
                MessageBox.Show("Thêm khoa mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDepartment();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSearhDName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departments = cmbSearhDName.Text;
            table_Department = bLL_Departments.SearchByDepartment(departments);
            dataGridViewDepartment.DataSource = table_Department;
            CreateButtonInView();
        }

        private void FormDepartment_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCourseCount_Click(object sender, EventArgs e)
        {
            FormCourCountByDepartment formCourCountByDepartment = new FormCourCountByDepartment();
            formCourCountByDepartment.Show();
        }
    }
}
