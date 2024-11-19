namespace QLSV
{
    partial class FormReportStudentByDepartment
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
            this.rpVStudentByDepartment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpVStudentByDepartment
            // 
            this.rpVStudentByDepartment.LocalReport.ReportEmbeddedResource = "QLSV.ReportSinhvienTheoKhoa.rdlc";
            this.rpVStudentByDepartment.Location = new System.Drawing.Point(12, 12);
            this.rpVStudentByDepartment.Name = "rpVStudentByDepartment";
            this.rpVStudentByDepartment.ServerReport.BearerToken = null;
            this.rpVStudentByDepartment.Size = new System.Drawing.Size(663, 326);
            this.rpVStudentByDepartment.TabIndex = 0;
            // 
            // FormReportStudentByDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 347);
            this.Controls.Add(this.rpVStudentByDepartment);
            this.Name = "FormReportStudentByDepartment";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpVStudentByDepartment;
    }
}