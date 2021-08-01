using System;
using System.Windows.Forms;

namespace CollegeManagement
{
    public partial class DashBoard : Form
    {
        public string username;
        public string password;
        public DashBoard()
        {
            InitializeComponent();
            
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void CollegeManagement_Load(object sender, EventArgs e)
        {
            menuStrip.Visible = true;
        }

        //private void BtnLogin_Click(object sender, EventArgs e)
        //{
        //    //username = TxtUserName.Text;
        //    //password = TxtPassword.Text;

        //    //if (username== "admin" && password== "admin")
        //    //{
        //    //    menuStrip.Visible = true;
        //    //    LoginPanel.Visible = false;
        //    //}

        //    //else
        //    //{
        //    //    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //}
        //}

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAdmission na = new NewAdmission();
            na.Show();
        }

        private void upgradeSemsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSemseter US = new UpdateSemseter();
            US.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You want to Exit? It will delete your UNSAVED Data!", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            } 
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs AU = new AboutUs();
            AU.Show();
        }

        private void feeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees Fee = new Fees();
            Fee.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSearch std = new StudentSearch();
            std.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndvidualDetails SID = new StudentIndvidualDetails();
            SID.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher AT = new AddTeacher();
            AT.Show();
        }

        private void seachTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher ST = new SearchTeacher();
            ST.Show();
        }

        //private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //{
        //    //    username = TxtUserName.Text;
        //    //    password = TxtPassword.Text;

        //    //    if (e.KeyValue == (char)Keys.Enter)
        //    //    {
        //    //        if (username == "admin" && password == "admin")
        //    //        {
        //    //            menuStrip.Visible = true;
        //    //            LoginPanel.Visible = false;
        //    //        }

        //    //        else
        //    //        {
        //    //            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //        }

        //    //    }
        //    //}
        //}

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent RS = new RemoveStudent();
            RS.Show();
        }
    }
}
