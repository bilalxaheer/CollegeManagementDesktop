using System;
using System.Windows.Forms;
using DLL;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace CollegeManagement
{
    public partial class AddTeacher : Form
    {
        dbConnection db = new dbConnection();

        public string RegularExpression()
        {
            string flag = "";
            if (!Regex.IsMatch(TxtFnameTch.Text, "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$"))
            {
                MessageBox.Show("Enter a Valid Full Name of Teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }
           
            else if (!Regex.IsMatch(TxtMobileTch.Text, "^[0-9]{11}$"))
            {
                MessageBox.Show("Enter a Valid Mobile Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }

            else if (!Regex.IsMatch(TxtEmailTch.Text, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
            {
                MessageBox.Show("Enter a Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }
            return flag;
        }
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmitTch_Click(object sender, EventArgs e)
        {
            if (TxtFnameTch.Text.Trim() == "" || TxtMobileTch.Text.Trim() == "" || TxtEmailTch.Text.Trim() == "" || TxtSemsterTch.Text.Trim() == "" || TxtProgTch.Text.Trim() == "" || TxtAddressTch.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the input in each field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();

            }
            else
            {
                String Gender = "";
                bool IsChecked = radioButtonMaleTch.Checked;
                if (IsChecked)
                {
                    Gender = radioButtonMaleTch.Text;
                }
                else
                {
                    Gender = radioButtonFemaleTch.Text;
                }
                string flag = RegularExpression();


                if (flag == "false")
                {

                    this.Show();
                }

                else if (TxtFnameTch.Text.Length < 3 || TxtMobileTch.Text.Length < 11 || TxtEmailTch.Text.Length < 11)
                {
                    MessageBox.Show("Minimum Lenght of each field is not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                }

                else
                {
                    db.addTeacher(TxtFnameTch.Text, Gender, TxtDobTch.Text, TxtMobileTch.Text, TxtEmailTch.Text, TxtSemsterTch.Text, TxtProgTch.Text, TxtDurationTch.Text, TxtAddressTch.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();

                    //    MySqlConnection con = new MySqlConnection();       
                    //    con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=CollegeManagement";
                    //    MySqlCommand cmd = new MySqlCommand();

                    //    cmd = new MySqlCommand("INSERT INTO addteacher( TchFullName, TchGender, TchDob, TchMobile, TchEmail, TchSemester, TchProg, TchDuration, TchAddress) VALUES(@TchFullName,@TchGender,@TchDob,@TchMobile,@TchEmail,@TchSemester,@TchProg,@TchDuration,@TchAddress)", con);
                    //    con.Open();
                    //    cmd.Parameters.AddWithValue("@TchFullName", TxtFnameTch.Text);
                    //    cmd.Parameters.AddWithValue("@TchGender", Gender);
                    //    cmd.Parameters.AddWithValue("@TchDob", TxtDobTch.Text);
                    //    cmd.Parameters.AddWithValue("@TchMobile", TxtMobileTch.Text);
                    //    cmd.Parameters.AddWithValue("@TchEmail", TxtEmailTch.Text);
                    //    cmd.Parameters.AddWithValue("@TchSemester", TxtSemsterTch.Text);
                    //    cmd.Parameters.AddWithValue("@TchProg", TxtProgTch.Text);
                    //    cmd.Parameters.AddWithValue("@TchDuration", TxtDurationTch.Text);
                    //    cmd.Parameters.AddWithValue("@TchAddress", TxtAddressTch.Text);
                    //    cmd.ExecuteNonQuery();
                    //    con.Close();


                    //    MessageBox.Show("Data Saved. Teacher Added Successfully", "Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString());
                    //}
                }
            }
        }
        private void BtnResetTch_Click(object sender, EventArgs e)
        {
            TxtFnameTch.Clear();
            radioButtonFemaleTch.Checked = false;
            radioButtonMaleTch.Checked = false;
            TxtMobileTch.Clear();
            TxtEmailTch.Clear();
            TxtSemsterTch.ResetText();
            TxtProgTch.ResetText();
            TxtDurationTch.ResetText();
            TxtAddressTch.Clear();
        }
    }
}
