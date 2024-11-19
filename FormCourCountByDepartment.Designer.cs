namespace QLSV
{
    partial class FormCourCountByDepartment
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
            this.crVCourseCount = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crVCourseCount
            // 
            this.crVCourseCount.ActiveViewIndex = -1;
            this.crVCourseCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crVCourseCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.crVCourseCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crVCourseCount.Location = new System.Drawing.Point(0, 0);
            this.crVCourseCount.Name = "crVCourseCount";
            this.crVCourseCount.Size = new System.Drawing.Size(800, 450);
            this.crVCourseCount.TabIndex = 0;
            this.crVCourseCount.Load += new System.EventHandler(this.crVCourseCount_Load);
            // 
            // FormCourCountByDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crVCourseCount);
            this.Name = "FormCourCountByDepartment";
            this.Text = "FormCourCountByDepartment";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crVCourseCount;
    }
}