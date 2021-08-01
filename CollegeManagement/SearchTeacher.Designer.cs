namespace CollegeManagement
{
    partial class SearchTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTeacher));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchFieldTch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 356);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(841, 275);
            this.dataGridView2.TabIndex = 11;
            // 
            // searchFieldTch
            // 
            this.searchFieldTch.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFieldTch.Location = new System.Drawing.Point(362, 83);
            this.searchFieldTch.MaxLength = 9999;
            this.searchFieldTch.Name = "searchFieldTch";
            this.searchFieldTch.Size = new System.Drawing.Size(285, 26);
            this.searchFieldTch.TabIndex = 9;
            this.searchFieldTch.TextChanged += new System.EventHandler(this.searchFieldTch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(209, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registration ID:";
            // 
            // TeacherSearch
            // 
            this.TeacherSearch.AutoSize = true;
            this.TeacherSearch.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherSearch.ForeColor = System.Drawing.Color.Navy;
            this.TeacherSearch.Location = new System.Drawing.Point(321, 12);
            this.TeacherSearch.Name = "TeacherSearch";
            this.TeacherSearch.Size = new System.Drawing.Size(337, 44);
            this.TeacherSearch.TabIndex = 7;
            this.TeacherSearch.Text = "Teacher Record";
            this.TeacherSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SearchTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 631);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.searchFieldTch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherSearch);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "SearchTeacher";
            this.Text = "SearchTeacher";
            this.Load += new System.EventHandler(this.SearchTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox searchFieldTch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TeacherSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}