namespace QLSV
{
    partial class FormReportAvgScore
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
            this.crVReportAvgScore = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crVReportAvgScore
            // 
            this.crVReportAvgScore.ActiveViewIndex = -1;
            this.crVReportAvgScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crVReportAvgScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.crVReportAvgScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crVReportAvgScore.Location = new System.Drawing.Point(0, 0);
            this.crVReportAvgScore.Name = "crVReportAvgScore";
            this.crVReportAvgScore.Size = new System.Drawing.Size(675, 308);
            this.crVReportAvgScore.TabIndex = 0;
            // 
            // FormReportAvgScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 308);
            this.Controls.Add(this.crVReportAvgScore);
            this.Name = "FormReportAvgScore";
            this.Text = "FormReportAvgScore";
            this.Load += new System.EventHandler(this.FormReportAvgScore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crVReportAvgScore;
    }
}