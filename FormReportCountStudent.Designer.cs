namespace QLSV
{
    partial class FormReportCountStudent
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
            this.crystalReportViewerCountStudent = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerCountStudent
            // 
            this.crystalReportViewerCountStudent.ActiveViewIndex = -1;
            this.crystalReportViewerCountStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerCountStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerCountStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerCountStudent.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerCountStudent.Name = "crystalReportViewerCountStudent";
            this.crystalReportViewerCountStudent.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerCountStudent.TabIndex = 0;
            this.crystalReportViewerCountStudent.Load += new System.EventHandler(this.crystalReportViewerCountStudent_Load);
            // 
            // FormReportCountStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerCountStudent);
            this.Name = "FormReportCountStudent";
            this.Text = "FormReportCountStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerCountStudent;
    }
}