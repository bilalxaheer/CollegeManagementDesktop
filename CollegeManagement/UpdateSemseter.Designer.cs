namespace CollegeManagement
{
    partial class UpdateSemseter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSemseter));
            this.btnUpSemster = new System.Windows.Forms.Button();
            this.UpSemster2 = new System.Windows.Forms.ComboBox();
            this.UpSemster1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpSemster
            // 
            this.btnUpSemster.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpSemster.Location = new System.Drawing.Point(151, 436);
            this.btnUpSemster.Name = "btnUpSemster";
            this.btnUpSemster.Size = new System.Drawing.Size(206, 23);
            this.btnUpSemster.TabIndex = 32;
            this.btnUpSemster.Text = "Upgrade";
            this.btnUpSemster.UseVisualStyleBackColor = true;
            this.btnUpSemster.Click += new System.EventHandler(this.btnUpSemster_Click);
            // 
            // UpSemster2
            // 
            this.UpSemster2.FormattingEnabled = true;
            this.UpSemster2.Items.AddRange(new object[] {
            "1st Semster",
            "2nd Semster",
            "3rd Semster",
            "4th Semster",
            "5th Semster",
            "6th Semster",
            "7th Semster",
            "8th Semster"});
            this.UpSemster2.Location = new System.Drawing.Point(151, 375);
            this.UpSemster2.Name = "UpSemster2";
            this.UpSemster2.Size = new System.Drawing.Size(206, 21);
            this.UpSemster2.TabIndex = 31;
            // 
            // UpSemster1
            // 
            this.UpSemster1.FormattingEnabled = true;
            this.UpSemster1.Items.AddRange(new object[] {
            "1st Semster",
            "2nd Semster",
            "3rd Semster",
            "4th Semster",
            "5th Semster",
            "6th Semster",
            "7th Semster",
            "8th Semster"});
            this.UpSemster1.Location = new System.Drawing.Point(151, 282);
            this.UpSemster1.Name = "UpSemster1";
            this.UpSemster1.Size = new System.Drawing.Size(206, 21);
            this.UpSemster1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Upgrade student To Semester:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Upgrade student from Semester:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateSemseter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 495);
            this.Controls.Add(this.btnUpSemster);
            this.Controls.Add(this.UpSemster2);
            this.Controls.Add(this.UpSemster1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdateSemseter";
            this.Text = "UpdateSemseter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpSemster;
        private System.Windows.Forms.ComboBox UpSemster2;
        private System.Windows.Forms.ComboBox UpSemster1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}