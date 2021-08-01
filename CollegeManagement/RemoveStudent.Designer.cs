namespace CollegeManagement
{
    partial class RemoveStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStudent));
            this.dataGridViewDel = new System.Windows.Forms.DataGridView();
            this.btnDeleteStd = new System.Windows.Forms.Button();
            this.DelFieldStd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDel
            // 
            this.dataGridViewDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDel.Location = new System.Drawing.Point(12, 200);
            this.dataGridViewDel.Name = "dataGridViewDel";
            this.dataGridViewDel.ReadOnly = true;
            this.dataGridViewDel.Size = new System.Drawing.Size(990, 275);
            this.dataGridViewDel.TabIndex = 17;
            // 
            // btnDeleteStd
            // 
            this.btnDeleteStd.BackColor = System.Drawing.Color.Navy;
            this.btnDeleteStd.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStd.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStd.Location = new System.Drawing.Point(397, 122);
            this.btnDeleteStd.Name = "btnDeleteStd";
            this.btnDeleteStd.Size = new System.Drawing.Size(173, 27);
            this.btnDeleteStd.TabIndex = 16;
            this.btnDeleteStd.Text = "Delete Student";
            this.btnDeleteStd.UseVisualStyleBackColor = false;
            this.btnDeleteStd.Click += new System.EventHandler(this.btnDeleteStd_Click);
            // 
            // DelFieldStd
            // 
            this.DelFieldStd.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelFieldStd.Location = new System.Drawing.Point(397, 75);
            this.DelFieldStd.MaxLength = 9999;
            this.DelFieldStd.Name = "DelFieldStd";
            this.DelFieldStd.Size = new System.Drawing.Size(173, 26);
            this.DelFieldStd.TabIndex = 15;
            this.DelFieldStd.TextChanged += new System.EventHandler(this.DelFieldStd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(209, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registration ID:";
            // 
            // TeacherSearch
            // 
            this.TeacherSearch.AutoSize = true;
            this.TeacherSearch.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherSearch.ForeColor = System.Drawing.Color.Navy;
            this.TeacherSearch.Location = new System.Drawing.Point(392, 4);
            this.TeacherSearch.Name = "TeacherSearch";
            this.TeacherSearch.Size = new System.Drawing.Size(188, 25);
            this.TeacherSearch.TabIndex = 13;
            this.TeacherSearch.Text = "Remove Student";
            this.TeacherSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 482);
            this.Controls.Add(this.dataGridViewDel);
            this.Controls.Add(this.btnDeleteStd);
            this.Controls.Add(this.DelFieldStd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherSearch);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RemoveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveStudent";
            this.Load += new System.EventHandler(this.RemoveStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDel;
        private System.Windows.Forms.Button btnDeleteStd;
        private System.Windows.Forms.TextBox DelFieldStd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TeacherSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}