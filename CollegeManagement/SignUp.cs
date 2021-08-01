using System;
using System.Data;
using System.Windows.Forms;
using DLL;
using System.Data.SqlClient;

namespace CollegeManagement
{
    public partial class SignUp : Form
    {
        dbConnection db = new dbConnection();
        //SqlConnection con = new SqlConnection("Data Source=BILL\\SQLEXPRESS;Initial Catalog=collegemanagement;Integrated Security=True");
        //SqlCommand cmd;
        //SqlCommand cmd1;
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (PersonName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the Name!");
                return;
            }

            if (PersonEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the Email name");
                return;
            }

            if (PersonPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the Password correctly");
                return;
            }

            //con.Open();
            ////string check_userID = "SELECT * from signup WHERE UserEmail ='" + PersonEmail.Text + "' ";
            //cmd = new SqlCommand("EmailCheck", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@PersonEmail",PersonEmail.Text);
            //SqlDataAdapter Ds = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //Ds.Fill(dt);
            //cmd.ExecuteNonQuery();
            //con.Close();
           
                string count = db.signUpEmailCheck(PersonEmail.Text);

            if(count == "1")
            {
                MessageBox.Show("Email already exist. Please enter a unique Email", "Error");
                return;
            }
            else
            {



                if (!(PersonPassword.Text == ConfirmPersonPassword.Text))
                {
                    MessageBox.Show("password and confirm password must be same");
                }
                else
                {
                    try
                    {
                        //    con.Open();
                        //    cmd = new SqlCommand("SignUp", con);
                        //    cmd.CommandType = CommandType.StoredProcedure;
                        //    cmd.Parameters.AddWithValue("@PersonName", PersonName.Text);
                        //    cmd.Parameters.AddWithValue("@PersonEmail", PersonEmail.Text);
                        //    cmd.Parameters.AddWithValue("@ConfirmPersonPassword", ConfirmPersonPassword.Text);
                        //    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        //    DataTable df = new DataTable();
                        //    DA.Fill(df);
                        //    cmd.ExecuteNonQuery();
                        //    con.Close();

                        db.signUpBtnClick(PersonName.Text, PersonEmail.Text, ConfirmPersonPassword.Text);
                        MessageBox.Show("You have been Signed Up Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        signIn myLogin = new signIn();
                        myLogin.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PersonPassword.UseSystemPasswordChar = false;
            ConfirmPersonPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PersonPassword.UseSystemPasswordChar = true;
            ConfirmPersonPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signIn mySign = new signIn();
            mySign.Show();
        }
    }
}
