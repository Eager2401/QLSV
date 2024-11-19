namespace QLSV
{
    partial class FormCourses
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
            this.btShowList = new System.Windows.Forms.Button();
            this.cbSearchDepartment = new System.Windows.Forms.CheckBox();
            this.cbxSearchDepartment = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.txtSearchCourses = new System.Windows.Forms.TextBox();
            this.cbSearchCoursesName = new System.Windows.Forms.CheckBox();
            this.cbSearchCourses = new System.Windows.Forms.CheckBox();
            this.btAddCourses = new System.Windows.Forms.Button();
            this.cbxDepartmentName = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtIDCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btShowList
            // 
            this.btShowList.Location = new System.Drawing.Point(191, 61);
            this.btShowList.Name = "btShowList";
            this.btShowList.Size = new System.Drawing.Size(95, 31);
            this.btShowList.TabIndex = 64;
            this.btShowList.Text = "Xem danh sách";
            this.btShowList.UseVisualStyleBackColor = true;
            this.btShowList.Click += new System.EventHandler(this.btShowList_Click);
            // 
            // cbSearchDepartment
            // 
            this.cbSearchDepartment.AutoSize = true;
            this.cbSearchDepartment.Location = new System.Drawing.Point(12, 314);
            this.cbSearchDepartment.Name = "cbSearchDepartment";
            this.cbSearchDepartment.Size = new System.Drawing.Size(95, 17);
            this.cbSearchDepartment.TabIndex = 43;
            this.cbSearchDepartment.Text = "Tìm theo Khoa";
            this.cbSearchDepartment.UseVisualStyleBackColor = true;
            this.cbSearchDepartment.CheckedChanged += new System.EventHandler(this.cbSearchDepartment_CheckedChanged);
            // 
            // cbxSearchDepartment
            // 
            this.cbxSearchDepartment.FormattingEnabled = true;
            this.cbxSearchDepartment.Location = new System.Drawing.Point(117, 314);
            this.cbxSearchDepartment.Name = "cbxSearchDepartment";
            this.cbxSearchDepartment.Size = new System.Drawing.Size(155, 21);
            this.cbxSearchDepartment.TabIndex = 44;
            this.cbxSearchDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxSearchDepartment_SelectedIndexChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(225, 273);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(47, 21);
            this.btOK.TabIndex = 46;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txtSearchCourses
            // 
            this.txtSearchCourses.Location = new System.Drawing.Point(39, 273);
            this.txtSearchCourses.Name = "txtSearchCourses";
            this.txtSearchCourses.Size = new System.Drawing.Size(180, 20);
            this.txtSearchCourses.TabIndex = 45;
            // 
            // cbSearchCoursesName
            // 
            this.cbSearchCoursesName.AutoSize = true;
            this.cbSearchCoursesName.Location = new System.Drawing.Point(13, 250);
            this.cbSearchCoursesName.Name = "cbSearchCoursesName";
            this.cbSearchCoursesName.Size = new System.Drawing.Size(138, 17);
            this.cbSearchCoursesName.TabIndex = 42;
            this.cbSearchCoursesName.Text = "Tìm theo Tên Khóa học";
            this.cbSearchCoursesName.UseVisualStyleBackColor = true;
            this.cbSearchCoursesName.CheckedChanged += new System.EventHandler(this.cbSearchCoursesName_CheckedChanged);
            // 
            // cbSearchCourses
            // 
            this.cbSearchCourses.AutoSize = true;
            this.cbSearchCourses.Location = new System.Drawing.Point(14, 227);
            this.cbSearchCourses.Name = "cbSearchCourses";
            this.cbSearchCourses.Size = new System.Drawing.Size(102, 17);
            this.cbSearchCourses.TabIndex = 41;
            this.cbSearchCourses.Text = "Tìm kiếm dữ liệu";
            this.cbSearchCourses.UseVisualStyleBackColor = true;
            this.cbSearchCourses.CheckedChanged += new System.EventHandler(this.cbSearchCourses_CheckedChanged);
            // 
            // btAddCourses
            // 
            this.btAddCourses.Location = new System.Drawing.Point(12, 61);
            this.btAddCourses.Name = "btAddCourses";
            this.btAddCourses.Size = new System.Drawing.Size(105, 32);
            this.btAddCourses.TabIndex = 47;
            this.btAddCourses.Text = "Thêm khóa học";
            this.btAddCourses.UseVisualStyleBackColor = true;
            this.btAddCourses.Click += new System.EventHandler(this.btAddCourses_Click);
            // 
            // cbxDepartmentName
            // 
            this.cbxDepartmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepartmentName.FormattingEnabled = true;
            this.cbxDepartmentName.Location = new System.Drawing.Point(98, 182);
            this.cbxDepartmentName.Name = "cbxDepartmentName";
            this.cbxDepartmentName.Size = new System.Drawing.Size(148, 21);
            this.cbxDepartmentName.TabIndex = 61;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(123, 61);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(57, 32);
            this.btCancel.TabIndex = 60;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(98, 144);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(150, 20);
            this.txtCourseName.TabIndex = 56;
            // 
            // txtIDCourse
            // 
            this.txtIDCourse.Location = new System.Drawing.Point(98, 112);
            this.txtIDCourse.Name = "txtIDCourse";
            this.txtIDCourse.Size = new System.Drawing.Size(151, 20);
            this.txtIDCourse.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-62, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-62, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-62, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tên Khóa học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-62, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Giao diện Quản lý khóa học";
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToAddRows = false;
            this.dataGridViewCourses.AllowUserToOrderColumns = true;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.dataGridViewCourses.Location = new System.Drawing.Point(314, 61);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.Size = new System.Drawing.Size(554, 312);
            this.dataGridViewCourses.TabIndex = 46;
            this.dataGridViewCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellClick);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "ID Khóa học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Tên khoa";
            // 
            // FormCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 392);
            this.Controls.Add(this.cbSearchCoursesName);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbSearchCourses);
            this.Controls.Add(this.cbxSearchDepartment);
            this.Controls.Add(this.txtSearchCourses);
            this.Controls.Add(this.cbSearchDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btShowList);
            this.Controls.Add(this.btAddCourses);
            this.Controls.Add(this.cbxDepartmentName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtIDCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCourses);
            this.Name = "FormCourses";
            this.Text = "FormCourses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCourses_FormClosing);
            this.Load += new System.EventHandler(this.FormCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btShowList;
        private System.Windows.Forms.CheckBox cbSearchDepartment;
        private System.Windows.Forms.ComboBox cbxSearchDepartment;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox txtSearchCourses;
        private System.Windows.Forms.CheckBox cbSearchCoursesName;
        private System.Windows.Forms.CheckBox cbSearchCourses;
        private System.Windows.Forms.Button btAddCourses;
        private System.Windows.Forms.ComboBox cbxDepartmentName;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtIDCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private new System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
    }
}