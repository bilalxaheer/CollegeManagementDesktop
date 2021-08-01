using System;
using System.Data;
using System.Windows.Forms;
using CollegeManagement;
using DLL;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CollegeManagement
{
    public partial class signIn : Form
    {
        //MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=loginsystem;");
        //MySqlDataAdapter sda;
        dbConnection db = new dbConnection();

        public signIn()
        {
            InitializeComponent();
        }  
      
        private void SignUp_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp S1 = new SignUp();
            S1.Show();
        }

        private void ForgotPassword_link(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            //if (ShowPassword.Checked == true)
            //{
            //    Password.UseSystemPasswordChar = false;
            //}
            //else if (ShowPassword.Checked == false)
            //{
            //    Password.UseSystemPasswordChar = true;
            //}
    }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the username");
                return;
            }

            if (Password.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the password");
                return;
            }
            else {

                try {

                    string count = db.Login(UserName.Text, Password.Text);

                    if (count == "1")
                    {
                        
                        this.Hide();
                        DashBoard myDash = new DashBoard();
                        myDash.Show();
                        //MessageBox.Show("You have Logged In Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
                catch(Exception ex)
            {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
                
           
                //string select_query = "SELECT count(*) from signup WHERE Email = '" + UserName.Text + "' and Password = '" + Password.Text + "'";
                //sda = new MySqlDataAdapter(select_query, con);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //    if (dt.Rows[0][0].ToString() == "1")
                //    { 
                //        MessageBox.Show("You are Login Successfull");

            //        this.Hide();
            //        DashBoard myDash = new DashBoard();
            //        myDash.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Incorrect Username or Password ");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Server Down!");
            //}

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
