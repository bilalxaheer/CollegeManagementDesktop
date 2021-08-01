namespace CollegeManagement
{
    partial class StudentSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSearch));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentSeach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchFieldStd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // studentSeach
            // 
            this.studentSeach.AutoSize = true;
            this.studentSeach.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSeach.ForeColor = System.Drawing.Color.Navy;
            this.studentSeach.Location = new System.Drawing.Point(358, 12);
            this.studentSeach.Name = "studentSeach";
            this.studentSeach.Size = new System.Drawing.Size(259, 32);
            this.studentSeach.TabIndex = 1;
            this.studentSeach.Text = "Students Record";
            this.studentSeach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(209, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration No:";
            // 
            // searchFieldStd
            // 
            this.searchFieldStd.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFieldStd.Location = new System.Drawing.Point(387, 83);
            this.searchFieldStd.MaxLength = 9999;
            this.searchFieldStd.Name = "searchFieldStd";
            this.searchFieldStd.Size = new System.Drawing.Size(220, 26);
            this.searchFieldStd.TabIndex = 3;
            this.searchFieldStd.TextChanged += new System.EventHandler(this.searchFieldStd_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(933, 275);
            this.dataGridView1.TabIndex = 5;
            // 
            // genReport
            // 
            this.genReport.BackColor = System.Drawing.Color.Navy;
            this.genReport.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genReport.ForeColor = System.Drawing.Color.White;
            this.genReport.Location = new System.Drawing.Point(707, 76);
            this.genReport.Name = "genReport";
            this.genReport.Size = new System.Drawing.Size(200, 38);
            this.genReport.TabIndex = 29;
            this.genReport.Text = "Generate Report";
            this.genReport.UseVisualStyleBackColor = false;
            this.genReport.Click += new System.EventHandler(this.genReport_Click);
            // 
            // StudentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 495);
            this.Controls.Add(this.genReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchFieldStd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentSeach);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(949, 534);
            this.MinimumSize = new System.Drawing.Size(949, 534);
            this.Name = "StudentSearch";
            this.Text = "Registration No:";
            this.Load += new System.EventHandler(this.StudentSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label studentSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchFieldStd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button genReport;
    }
}