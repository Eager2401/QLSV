namespace QLSV
{
    partial class FormDepartment
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
            this.btAdd = new System.Windows.Forms.Button();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.btnShowList = new System.Windows.Forms.Button();
            this.chkSearchDepartment = new System.Windows.Forms.CheckBox();
            this.cmbSearhDName = new System.Windows.Forms.ComboBox();
            this.lbSearchByDName = new System.Windows.Forms.Label();
            this.tbAddDepartment = new System.Windows.Forms.TextBox();
            this.btnCourseCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao diện quản lý khoa";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(48, 296);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Thêm Khoa";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.AllowUserToAddRows = false;
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.dataGridViewDepartment.Location = new System.Drawing.Point(32, 48);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.Size = new System.Drawing.Size(545, 150);
            this.dataGridViewDepartment.TabIndex = 2;
            this.dataGridViewDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartment_CellClick);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Khoa";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Location = new System.Drawing.Point(105, 221);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(136, 20);
            this.txtDepartmentID.TabIndex = 1;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(244, 296);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(75, 23);
            this.btnShowList.TabIndex = 5;
            this.btnShowList.Text = "Xem danh sách khoa";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // chkSearchDepartment
            // 
            this.chkSearchDepartment.AutoSize = true;
            this.chkSearchDepartment.Location = new System.Drawing.Point(343, 218);
            this.chkSearchDepartment.Name = "chkSearchDepartment";
            this.chkSearchDepartment.Size = new System.Drawing.Size(68, 17);
            this.chkSearchDepartment.TabIndex = 9;
            this.chkSearchDepartment.Text = "Tìm kiếm";
            this.chkSearchDepartment.UseVisualStyleBackColor = true;
            this.chkSearchDepartment.CheckedChanged += new System.EventHandler(this.chkSearchDepartment_CheckedChanged);
            // 
            // cmbSearhDName
            // 
            this.cmbSearhDName.FormattingEnabled = true;
            this.cmbSearhDName.Location = new System.Drawing.Point(389, 254);
            this.cmbSearhDName.Name = "cmbSearhDName";
            this.cmbSearhDName.Size = new System.Drawing.Size(188, 21);
            this.cmbSearhDName.TabIndex = 11;
            this.cmbSearhDName.SelectedIndexChanged += new System.EventHandler(this.cmbSearhDName_SelectedIndexChanged);
            // 
            // lbSearchByDName
            // 
            this.lbSearchByDName.AutoSize = true;
            this.lbSearchByDName.Location = new System.Drawing.Point(397, 238);
            this.lbSearchByDName.Name = "lbSearchByDName";
            this.lbSearchByDName.Size = new System.Drawing.Size(118, 13);
            this.lbSearchByDName.TabIndex = 12;
            this.lbSearchByDName.Text = "Tìm kiếm theo tên khoa";
            // 
            // tbAddDepartment
            // 
            this.tbAddDepartment.Location = new System.Drawing.Point(105, 254);
            this.tbAddDepartment.Name = "tbAddDepartment";
            this.tbAddDepartment.Size = new System.Drawing.Size(136, 20);
            this.tbAddDepartment.TabIndex = 2;
            // 
            // btnCourseCount
            // 
            this.btnCourseCount.Location = new System.Drawing.Point(336, 296);
            this.btnCourseCount.Name = "btnCourseCount";
            this.btnCourseCount.Size = new System.Drawing.Size(241, 23);
            this.btnCourseCount.TabIndex = 13;
            this.btnCourseCount.Text = "Xem báo cáo Số lượng khóa học theo khoa";
            this.btnCourseCount.UseVisualStyleBackColor = true;
            this.btnCourseCount.Click += new System.EventHandler(this.btnCourseCount_Click);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 341);
            this.Controls.Add(this.btnCourseCount);
            this.Controls.Add(this.cmbSearhDName);
            this.Controls.Add(this.lbSearchByDName);
            this.Controls.Add(this.tbAddDepartment);
            this.Controls.Add(this.chkSearchDepartment);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Name = "FormDepartment";
            this.Text = "FormDepartment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDepartment_FormClosing);
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.CheckBox chkSearchDepartment;
        private System.Windows.Forms.ComboBox cmbSearhDName;
        private new System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lbSearchByDName;
        private System.Windows.Forms.TextBox tbAddDepartment;
        private System.Windows.Forms.Button btnCourseCount;
    }
}