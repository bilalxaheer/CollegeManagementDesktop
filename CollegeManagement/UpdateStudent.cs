using System;
using System.Windows.Forms;
using System.Data;
using DLL;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace CollegeManagement
{
    public partial class UpdateStudent : Form
    {
        dbConnection db = new dbConnection();
        int updateStdId;

        public string RegularExpression()
        {
            string flag = "";
            if (!Regex.IsMatch(UpdateFullName.Text, "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$"))
            {
                MessageBox.Show("Enter a Valid Full Name of Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }
            else if (!Regex.IsMatch(UpdateGname.Text, "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$"))
            {
                MessageBox.Show("Enter a Valid Guardian Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }
            else if (!Regex.IsMatch(UpdateMobile.Text, "^[0-9]{11}$"))
            {
                MessageBox.Show("Enter a Valid Mobile Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }

            else if (!Regex.IsMatch(UpdateEmail.Text, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
            {
                MessageBox.Show("Enter a Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }
            return flag;
        }
        public UpdateStudent()
        {
            InitializeComponent();
        }

        public UpdateStudent(string registration, string fullname, string Gname, string Gender, string Dob, string Mobile, string Email, string Standard, string Medium, string Sname, string Year, string Address)
        {
            InitializeComponent();
            labelRegisterationInfo.Text = registration;
            updateStdId = Int32.Parse(registration);
            UpdateFullName.Text = fullname;
            UpdateGname.Text = Gname;
            UpdateGender.Text = Gender;
            UpdateDob.Text = Dob;
            UpdateMobile.Text = Mobile; 
            UpdateEmail.Text = Email;
            UpdateSemster.Text = Standard;
            UpdateProg.Text = Medium;
            UpdateSname.Text = Sname;
            UpdateDuration.Text = Year;
            UpdateAddress.Text = Address;

        }

        private void SaveInfoBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update semester?", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //MySqlConnection con = new MySqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //MySqlCommand cmd = new MySqlCommand();
                //con.Open();
                //cmd = new MySqlCommand("updateStudent", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@labelRegisterationInfo", labelRegisterationInfo.Text);
                //cmd.Parameters.AddWithValue("@UpdateFullName", UpdateFullName.Text);
                //cmd.Parameters.AddWithValue("@UpdateGname", UpdateGname.Text);
                //cmd.Parameters.AddWithValue("@UpdateGender", UpdateGender.Text);
                //cmd.Parameters.AddWithValue("@UpdateDob", UpdateDob.Text);
                //cmd.Parameters.AddWithValue("@UpdateMobile", UpdateMobile.Text);
                //cmd.Parameters.AddWithValue("@UpdateEmail", UpdateEmail.Text);
                //cmd.Parameters.AddWithValue("@UpdateSemster", UpdateSemster.Text);
                //cmd.Parameters.AddWithValue("@UpdateProg", UpdateProg.Text);
                //cmd.Parameters.AddWithValue("@UpdateSname", UpdateSname.Text);
                //cmd.Parameters.AddWithValue("@UpdateDuration", UpdateDuration.Text);
                //cmd.Parameters.AddWithValue("@UpdateAddress", UpdateAddress.Text);

                //cmd.ExecuteNonQuery();
                //con.Close();
                if (UpdateFullName.Text.Trim() == "" || UpdateGname.Text.Trim() == "" || UpdateMobile.Text.Trim() == "" || UpdateEmail.Text.Trim() == "" || UpdateSemster.Text.Trim() == "" || UpdateProg.Text.Trim() == "" || UpdateSname.Text.Trim() == "" || UpdateAddress.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter the input in each field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();

                }
                else
                {

                    string flag = RegularExpression();


                    if (flag == "false")
                    {

                        this.Show();
                    }
                    else if (UpdateFullName.Text.Length < 3 || UpdateGname.Text.Length < 3 || UpdateMobile.Text.Length < 11 || UpdateEmail.Text.Length < 11)
                    {
                        MessageBox.Show("Minimum Lenght of each field is not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                    }

                    else
                    {
                        db.updateStd(updateStdId, UpdateFullName.Text, UpdateGname.Text, UpdateGender.Text, UpdateDob.Text, UpdateMobile.Text, UpdateEmail.Text, UpdateSemster.Text, UpdateProg.Text, UpdateSname.Text, UpdateDuration.Text, UpdateAddress.Text);

                        MessageBox.Show("Upgrade Student Info is successfull", "Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Hide();
                        StudentIndvidualDetails SID = new StudentIndvidualDetails();
                        SID.Show();

                        //TxtFname.Clear();
                        //TxtGname.Clear();
                        //radioButtonFemale.Checked = false;
                        //radioButtonMale.Checked = false;
                        //TxtMobile.Clear();
                        //TxtEmail.Clear();
                        //TxtSemster.ResetText();
                        //TxtProg.ResetText();
                        //TxtSname.Clear();
                        //TxtDuration.ResetText();
                        //TxtAddress.Clear();
                    }
                }
            }

            else
            {
                MessageBox.Show("Upgrade Student info is Unsuccessfull", "Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}


