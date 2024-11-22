namespace QLSV
{
    partial class FormEnrollments
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEnrollments = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btShowList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelEnollments = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.cmbCoursesName = new System.Windows.Forms.ComboBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.btnAddEnrollments = new System.Windows.Forms.Button();
            this.dTPEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnrollmentID = new System.Windows.Forms.TextBox();
            this.btReportAVGScore = new System.Windows.Forms.Button();
            this.chkBSearchScore = new System.Windows.Forms.CheckBox();
            this.chkSearchStudentName = new System.Windows.Forms.CheckBox();
            this.chkSearchCourseName = new System.Windows.Forms.CheckBox();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.btSearchStudent = new System.Windows.Forms.Button();
            this.cbxSearchCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnrollments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao diện Quản lý Đăng ký khóa học";
            // 
            // dataGridViewEnrollments
            // 
            this.dataGridViewEnrollments.AllowUserToAddRows = false;
            this.dataGridViewEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnrollments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.dataGridViewEnrollments.Location = new System.Drawing.Point(321, 60);
            this.dataGridViewEnrollments.Name = "dataGridViewEnrollments";
            this.dataGridViewEnrollments.Size = new System.Drawing.Size(696, 183);
            this.dataGridViewEnrollments.TabIndex = 1;
            this.dataGridViewEnrollments.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewEnrollments_CellBeginEdit);
            this.dataGridViewEnrollments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnrollments_CellClick);
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
            // btShowList
            // 
            this.btShowList.Location = new System.Drawing.Point(668, 249);
            this.btShowList.Name = "btShowList";
            this.btShowList.Size = new System.Drawing.Size(169, 39);
            this.btShowList.TabIndex = 16;
            this.btShowList.Text = "Xem danh sách đăng ký";
            this.btShowList.UseVisualStyleBackColor = true;
            this.btShowList.Click += new System.EventHandler(this.btShowList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã sinh viên";
            // 
            // btnCancelEnollments
            // 
            this.btnCancelEnollments.Location = new System.Drawing.Point(116, 191);
            this.btnCancelEnollments.Name = "btnCancelEnollments";
            this.btnCancelEnollments.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEnollments.TabIndex = 15;
            this.btnCancelEnollments.Text = "Cancel";
            this.btnCancelEnollments.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Khóa học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày đăng ký";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điểm số";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(98, 58);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(187, 20);
            this.txtStudentID.TabIndex = 9;
            // 
            // cmbCoursesName
            // 
            this.cmbCoursesName.FormattingEnabled = true;
            this.cmbCoursesName.Location = new System.Drawing.Point(98, 86);
            this.cmbCoursesName.Name = "cmbCoursesName";
            this.cmbCoursesName.Size = new System.Drawing.Size(187, 21);
            this.cmbCoursesName.TabIndex = 11;
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(97, 148);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(187, 20);
            this.tbGrade.TabIndex = 12;
            // 
            // btnAddEnrollments
            // 
            this.btnAddEnrollments.Location = new System.Drawing.Point(35, 191);
            this.btnAddEnrollments.Name = "btnAddEnrollments";
            this.btnAddEnrollments.Size = new System.Drawing.Size(75, 23);
            this.btnAddEnrollments.TabIndex = 14;
            this.btnAddEnrollments.Text = "Add";
            this.btnAddEnrollments.UseVisualStyleBackColor = true;
            this.btnAddEnrollments.Click += new System.EventHandler(this.btnAddEnrollments_Click);
            // 
            // dTPEnrollmentDate
            // 
            this.dTPEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPEnrollmentDate.Location = new System.Drawing.Point(97, 118);
            this.dTPEnrollmentDate.Name = "dTPEnrollmentDate";
            this.dTPEnrollmentDate.Size = new System.Drawing.Size(187, 20);
            this.dTPEnrollmentDate.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã lớp học";
            // 
            // txtEnrollmentID
            // 
            this.txtEnrollmentID.Location = new System.Drawing.Point(97, 30);
            this.txtEnrollmentID.Name = "txtEnrollmentID";
            this.txtEnrollmentID.Size = new System.Drawing.Size(188, 20);
            this.txtEnrollmentID.TabIndex = 19;
            // 
            // btReportAVGScore
            // 
            this.btReportAVGScore.Location = new System.Drawing.Point(843, 249);
            this.btReportAVGScore.Name = "btReportAVGScore";
            this.btReportAVGScore.Size = new System.Drawing.Size(174, 39);
            this.btReportAVGScore.TabIndex = 20;
            this.btReportAVGScore.Text = "Lấy điểm trung bình của sinh viên với  mỗi khóa học";
            this.btReportAVGScore.UseVisualStyleBackColor = true;
            this.btReportAVGScore.Click += new System.EventHandler(this.btReportAVGScore_Click);
            // 
            // chkBSearchScore
            // 
            this.chkBSearchScore.AutoSize = true;
            this.chkBSearchScore.Location = new System.Drawing.Point(16, 249);
            this.chkBSearchScore.Name = "chkBSearchScore";
            this.chkBSearchScore.Size = new System.Drawing.Size(68, 17);
            this.chkBSearchScore.TabIndex = 21;
            this.chkBSearchScore.Text = "Tìm kiếm";
            this.chkBSearchScore.UseVisualStyleBackColor = true;
            this.chkBSearchScore.CheckedChanged += new System.EventHandler(this.chkBSearchScore_CheckedChanged);
            // 
            // chkSearchStudentName
            // 
            this.chkSearchStudentName.AutoSize = true;
            this.chkSearchStudentName.Location = new System.Drawing.Point(12, 280);
            this.chkSearchStudentName.Name = "chkSearchStudentName";
            this.chkSearchStudentName.Size = new System.Drawing.Size(134, 17);
            this.chkSearchStudentName.TabIndex = 24;
            this.chkSearchStudentName.Text = "Tìm theo Tên sinh viên";
            this.chkSearchStudentName.UseVisualStyleBackColor = true;
            this.chkSearchStudentName.CheckedChanged += new System.EventHandler(this.chkSearchStudentName_CheckedChanged);
            // 
            // chkSearchCourseName
            // 
            this.chkSearchCourseName.AutoSize = true;
            this.chkSearchCourseName.Location = new System.Drawing.Point(12, 309);
            this.chkSearchCourseName.Name = "chkSearchCourseName";
            this.chkSearchCourseName.Size = new System.Drawing.Size(137, 17);
            this.chkSearchCourseName.TabIndex = 25;
            this.chkSearchCourseName.Text = "Tìm theo Tên khóa học";
            this.chkSearchCourseName.UseVisualStyleBackColor = true;
            this.chkSearchCourseName.CheckedChanged += new System.EventHandler(this.chkSearchCourseName_CheckedChanged);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(152, 276);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(143, 20);
            this.txtSearchStudent.TabIndex = 26;
            // 
            // btSearchStudent
            // 
            this.btSearchStudent.Location = new System.Drawing.Point(301, 274);
            this.btSearchStudent.Name = "btSearchStudent";
            this.btSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btSearchStudent.TabIndex = 28;
            this.btSearchStudent.Text = "Tìm";
            this.btSearchStudent.UseVisualStyleBackColor = true;
            this.btSearchStudent.Click += new System.EventHandler(this.btSearchStudent_Click);
            // 
            // cbxSearchCourse
            // 
            this.cbxSearchCourse.FormattingEnabled = true;
            this.cbxSearchCourse.Location = new System.Drawing.Point(152, 309);
            this.cbxSearchCourse.Name = "cbxSearchCourse";
            this.cbxSearchCourse.Size = new System.Drawing.Size(143, 21);
            this.cbxSearchCourse.TabIndex = 29;
            this.cbxSearchCourse.SelectedIndexChanged += new System.EventHandler(this.cbxSearchCourse_SelectedIndexChanged);
            // 
            // FormEnrollmetns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 340);
            this.Controls.Add(this.cbxSearchCourse);
            this.Controls.Add(this.btSearchStudent);
            this.Controls.Add(this.txtSearchStudent);
            this.Controls.Add(this.chkSearchCourseName);
            this.Controls.Add(this.chkSearchStudentName);
            this.Controls.Add(this.chkBSearchScore);
            this.Controls.Add(this.btReportAVGScore);
            this.Controls.Add(this.txtEnrollmentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTPEnrollmentDate);
            this.Controls.Add(this.btShowList);
            this.Controls.Add(this.btnCancelEnollments);
            this.Controls.Add(this.btnAddEnrollments);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.cmbCoursesName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewEnrollments);
            this.Controls.Add(this.label1);
            this.Name = "FormEnrollmetns";
            this.Text = "FormEnrollmetns";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEnrollmetns_FormClosing);
            this.Load += new System.EventHandler(this.FormEnrollmetns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnrollments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEnrollments;
        private System.Windows.Forms.Button btShowList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelEnollments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.ComboBox cmbCoursesName;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Button btnAddEnrollments;
        private new System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DateTimePicker dTPEnrollmentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnrollmentID;
        private System.Windows.Forms.Button btReportAVGScore;
        private System.Windows.Forms.CheckBox chkBSearchScore;
        private System.Windows.Forms.CheckBox chkSearchStudentName;
        private System.Windows.Forms.CheckBox chkSearchCourseName;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btSearchStudent;
        private System.Windows.Forms.ComboBox cbxSearchCourse;
    }
}