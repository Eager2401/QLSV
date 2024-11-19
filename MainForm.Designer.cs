namespace QLSV
{
    partial class MainForm
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
            this.btQLDS = new System.Windows.Forms.Button();
            this.btQLKH = new System.Windows.Forms.Button();
            this.btQLK = new System.Windows.Forms.Button();
            this.btQLSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQLDS
            // 
            this.btQLDS.Location = new System.Drawing.Point(38, 201);
            this.btQLDS.Name = "btQLDS";
            this.btQLDS.Size = new System.Drawing.Size(254, 23);
            this.btQLDS.TabIndex = 16;
            this.btQLDS.Text = "Quản lý điểm số";
            this.btQLDS.UseVisualStyleBackColor = true;
            this.btQLDS.Click += new System.EventHandler(this.btQLDS_Click);
            // 
            // btQLKH
            // 
            this.btQLKH.Location = new System.Drawing.Point(38, 161);
            this.btQLKH.Name = "btQLKH";
            this.btQLKH.Size = new System.Drawing.Size(254, 23);
            this.btQLKH.TabIndex = 15;
            this.btQLKH.Text = "Quản lý khóa học";
            this.btQLKH.UseVisualStyleBackColor = true;
            this.btQLKH.Click += new System.EventHandler(this.btQLKH_Click);
            // 
            // btQLK
            // 
            this.btQLK.Location = new System.Drawing.Point(38, 120);
            this.btQLK.Name = "btQLK";
            this.btQLK.Size = new System.Drawing.Size(254, 23);
            this.btQLK.TabIndex = 14;
            this.btQLK.Text = "Quản lý khoa";
            this.btQLK.UseVisualStyleBackColor = true;
            this.btQLK.Click += new System.EventHandler(this.btQLK_Click);
            // 
            // btQLSV
            // 
            this.btQLSV.Location = new System.Drawing.Point(38, 77);
            this.btQLSV.Name = "btQLSV";
            this.btQLSV.Size = new System.Drawing.Size(254, 23);
            this.btQLSV.TabIndex = 13;
            this.btQLSV.Text = "Quản lý sinh viên";
            this.btQLSV.UseVisualStyleBackColor = true;
            this.btQLSV.Click += new System.EventHandler(this.btQLSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chọn giao diện quản lý";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 244);
            this.Controls.Add(this.btQLDS);
            this.Controls.Add(this.btQLKH);
            this.Controls.Add(this.btQLK);
            this.Controls.Add(this.btQLSV);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btQLDS;
        private System.Windows.Forms.Button btQLKH;
        private System.Windows.Forms.Button btQLK;
        private System.Windows.Forms.Button btQLSV;
        private System.Windows.Forms.Label label1;
    }
}