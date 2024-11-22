namespace QLSV
{
    partial class cbSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddStudents = new System.Windows.Forms.Button();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.cbxDepartmentName = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSearchStudents = new System.Windows.Forms.CheckBox();
            this.cbSearchID = new System.Windows.Forms.CheckBox();
            this.cbSearchDepartment = new System.Windows.Forms.CheckBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxSearchDepartment = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btOK = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btShowList = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btReportStudentByD = new System.Windows.Forms.Button();
            this.btGetStudentCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.dataGridViewStudents.Location = new System.Drawing.Point(312, 51);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(674, 312);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewStudents_CellBeginEdit);
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giao diện Quản lý sinh viên";
            // 
            // btAddStudents
            // 
            this.btAddStudents.Location = new System.Drawing.Point(40, 23);
            this.btAddStudents.Name = "btAddStudents";
            this.btAddStudents.Size = new System.Drawing.Size(105, 32);
            this.btAddStudents.TabIndex = 2;
            this.btAddStudents.Text = "Thêm sinh viên";
            this.btAddStudents.UseVisualStyleBackColor = true;
            this.btAddStudents.Click += new System.EventHandler(this.btAddStudents_Click);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(126, 178);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerDOB.TabIndex = 40;
            // 
            // cbxDepartmentName
            // 
            this.cbxDepartmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartmentName.FormattingEnabled = true;
            this.cbxDepartmentName.Location = new System.Drawing.Point(127, 248);
            this.cbxDepartmentName.Name = "cbxDepartmentName";
            this.cbxDepartmentName.Size = new System.Drawing.Size(148, 21);
            this.cbxDepartmentName.TabIndex = 39;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(180, 23);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(57, 32);
            this.btCancel.TabIndex = 38;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Location = new System.Drawing.Point(180, 213);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(39, 17);
            this.rBtnFemale.TabIndex = 36;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Nữ";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Location = new System.Drawing.Point(127, 213);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(47, 17);
            this.rBtnMale.TabIndex = 35;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Nam";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(125, 110);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(150, 20);
            this.txtLName.TabIndex = 34;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(125, 141);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(150, 20);
            this.txtFname.TabIndex = 33;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 74);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 20);
            this.txtID.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên (FirstName)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Họ (LastName)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID";
            // 
            // cbSearchStudents
            // 
            this.cbSearchStudents.AutoSize = true;
            this.cbSearchStudents.Location = new System.Drawing.Point(6, 10);
            this.cbSearchStudents.Name = "cbSearchStudents";
            this.cbSearchStudents.Size = new System.Drawing.Size(102, 17);
            this.cbSearchStudents.TabIndex = 41;
            this.cbSearchStudents.Text = "Tìm kiếm dữ liệu";
            this.cbSearchStudents.UseVisualStyleBackColor = true;
            this.cbSearchStudents.CheckedChanged += new System.EventHandler(this.cbSearchStudents_CheckedChanged);
            // 
            // cbSearchID
            // 
            this.cbSearchID.AutoSize = true;
            this.cbSearchID.Location = new System.Drawing.Point(6, 11);
            this.cbSearchID.Name = "cbSearchID";
            this.cbSearchID.Size = new System.Drawing.Size(106, 17);
            this.cbSearchID.TabIndex = 42;
            this.cbSearchID.Text = "Tìm theo Tên SV";
            this.cbSearchID.UseVisualStyleBackColor = true;
            this.cbSearchID.CheckedChanged += new System.EventHandler(this.cbSearchID_CheckedChanged);
            // 
            // cbSearchDepartment
            // 
            this.cbSearchDepartment.AutoSize = true;
            this.cbSearchDepartment.Location = new System.Drawing.Point(6, 12);
            this.cbSearchDepartment.Name = "cbSearchDepartment";
            this.cbSearchDepartment.Size = new System.Drawing.Size(95, 17);
            this.cbSearchDepartment.TabIndex = 43;
            this.cbSearchDepartment.Text = "Tìm theo Khoa";
            this.cbSearchDepartment.UseVisualStyleBackColor = true;
            this.cbSearchDepartment.CheckedChanged += new System.EventHandler(this.cbSearchDepartment_CheckedChanged);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.groupBox2);
            this.grbSearch.Controls.Add(this.groupBox1);
            this.grbSearch.Controls.Add(this.cbSearchStudents);
            this.grbSearch.Location = new System.Drawing.Point(12, 294);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(294, 119);
            this.grbSearch.TabIndex = 44;
            this.grbSearch.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSearchDepartment);
            this.groupBox2.Controls.Add(this.cbxSearchDepartment);
            this.groupBox2.Location = new System.Drawing.Point(0, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 44);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // cbxSearchDepartment
            // 
            this.cbxSearchDepartment.FormattingEnabled = true;
            this.cbxSearchDepartment.Location = new System.Drawing.Point(107, 10);
            this.cbxSearchDepartment.Name = "cbxSearchDepartment";
            this.cbxSearchDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchDepartment.TabIndex = 44;
            this.cbxSearchDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxSearchDepartment_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btOK);
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Controls.Add(this.cbSearchID);
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 35);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(234, 9);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(47, 21);
            this.btOK.TabIndex = 46;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(107, 9);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchName.TabIndex = 45;
            // 
            // btShowList
            // 
            this.btShowList.Location = new System.Drawing.Point(312, 375);
            this.btShowList.Name = "btShowList";
            this.btShowList.Size = new System.Drawing.Size(95, 31);
            this.btShowList.TabIndex = 45;
            this.btShowList.Text = "Xem danh sách";
            this.btShowList.UseVisualStyleBackColor = true;
            this.btShowList.Click += new System.EventHandler(this.btShowList_Click);
            // 
            // btReportStudentByD
            // 
            this.btReportStudentByD.Location = new System.Drawing.Point(413, 375);
            this.btReportStudentByD.Name = "btReportStudentByD";
            this.btReportStudentByD.Size = new System.Drawing.Size(230, 31);
            this.btReportStudentByD.TabIndex = 46;
            this.btReportStudentByD.Text = "Xem danh sách sinh viên ứng với mỗi khoa";
            this.btReportStudentByD.UseVisualStyleBackColor = true;
            this.btReportStudentByD.Click += new System.EventHandler(this.btReportStudentByD_Click);
            // 
            // btGetStudentCount
            // 
            this.btGetStudentCount.Location = new System.Drawing.Point(649, 375);
            this.btGetStudentCount.Name = "btGetStudentCount";
            this.btGetStudentCount.Size = new System.Drawing.Size(208, 31);
            this.btGetStudentCount.TabIndex = 47;
            this.btGetStudentCount.Text = "Lấy số lượng sinh viên với mỗi khoa";
            this.btGetStudentCount.UseVisualStyleBackColor = true;
            this.btGetStudentCount.Click += new System.EventHandler(this.btGetStudentCount_Click);
            // 
            // cbSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 425);
            this.Controls.Add(this.btGetStudentCount);
            this.Controls.Add(this.btReportStudentByD);
            this.Controls.Add(this.btShowList);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.btAddStudents);
            this.Controls.Add(this.cbxDepartmentName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.rBtnFemale);
            this.Controls.Add(this.rBtnMale);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "cbSearch";
            this.Text = "FormStudents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cbSearch_FormClosing);
            this.Load += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddStudents;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox cbxDepartmentName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbSearchStudents;
        private System.Windows.Forms.CheckBox cbSearchID;
        private System.Windows.Forms.CheckBox cbSearchDepartment;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.ComboBox cbxSearchDepartment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private new System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btShowList;
        private System.Windows.Forms.Button btOK;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btReportStudentByD;
        private System.Windows.Forms.Button btGetStudentCount;
    }
}