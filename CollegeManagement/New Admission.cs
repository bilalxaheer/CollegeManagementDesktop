using System;
using System.Data;
using System.Windows.Forms;
using DLL;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    public partial class NewAdmission : Form
    {
        dbConnection db = new dbConnection();

        public string RegularExpression()
        {
            string flag = "";
            if (!Regex.IsMatch(TxtFname.Text, "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$"))
            {
                MessageBox.Show("Enter a Valid Full Name of Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }
            else if (!Regex.IsMatch(TxtGname.Text, "^[A-Z][a-z]*(\\s[A-Z][a-z]*)+$"))
            {
                MessageBox.Show("Enter a Valid Guardian Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }
            else if (!Regex.IsMatch(TxtMobile.Text, "^[0-9]{11}$"))
            {
                MessageBox.Show("Enter a Valid Mobile Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }

            else if (!Regex.IsMatch(TxtEmail.Text, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
            {
                MessageBox.Show("Enter a Valid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = "false";
            }
            return flag;
        }

        public NewAdmission()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            if (TxtFname.Text.Trim() == "" || TxtGname.Text.Trim() == "" || TxtMobile.Text.Trim() == "" || TxtEmail.Text.Trim() == "" || TxtSemster.Text.Trim() == "" || TxtProg.Text.Trim() == "" || TxtSname.Text.Trim() == "" || TxtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the input in each field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();

            }
            else
            {

                String Gender = "";
                bool IsChecked = radioButtonMale.Checked;
                if (IsChecked)
                {
                    Gender = radioButtonMale.Text;
                }
                else
                {
                    Gender = radioButtonFemale.Text;
                }




                string flag = RegularExpression();


                if (flag == "false")
                {

                    this.Show();
                }
                else if (TxtFname.Text.Length < 3 || TxtGname.Text.Length < 3 || TxtMobile.Text.Length < 11 || TxtEmail.Text.Length < 11)
                {
                    MessageBox.Show("Minimum Lenght of each field is not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                }

                else
                {
                    db.newAdmission(TxtFname.Text, TxtGname.Text, Gender, TxtDob.Text, TxtMobile.Text, TxtEmail.Text, TxtSemster.Text, TxtProg.Text, TxtSname.Text, TxtDuration.Text, TxtAddress.Text);
                    this.Controls.Clear();
                    this.InitializeComponent();
                    label13.Text = db.registrationCounter();
                }
            }
        }

                //try
                //{
                //    MySqlConnection con = new MySqlConnection();
                //    con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //    MySqlCommand cmd;

                //    con.Open();
                //    cmd = new MySqlCommand("NewAdmInsert", con);
                //    cmd.CommandType = CommandType.StoredProcedure;             
                //    cmd.Parameters.AddWithValue("@fname", TxtFname.Text);
                //    cmd.Parameters.AddWithValue("@gname", TxtGname.Text);
                //    cmd.Parameters.AddWithValue("@gender", Gender);
                //    cmd.Parameters.AddWithValue("@dob", TxtDob.Text);
                //    cmd.Parameters.AddWithValue("@mobile", TxtMobile.Text);
                //    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                //    cmd.Parameters.AddWithValue("@semster", TxtSemster.Text);
                //    cmd.Parameters.AddWithValue("@prog", TxtProg.Text);
                //    cmd.Parameters.AddWithValue("@school", TxtSname.Text);
                //    cmd.Parameters.AddWithValue("@duration", TxtDuration.Text);
                //    cmd.Parameters.AddWithValue("@address", TxtAddress.Text);
                //    MySqlDataAdapter Ds = new MySqlDataAdapter(cmd);
                //    cmd.ExecuteNonQuery();
                //    con.Close();


                //    MessageBox.Show("Data Saved. Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //}

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtFname.Clear();
            TxtGname.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            TxtMobile.Clear();
            TxtEmail.Clear();
            TxtSemster.ResetText();
            TxtProg.ResetText();
            TxtSname.Clear();
            TxtDuration.ResetText();
            TxtAddress.Clear();
        }

        private void NewAdmission_Load(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
            //MySqlCommand cmd = new MySqlCommand();
            //con.Open();
            //cmd = new MySqlCommand("MaxId", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.ExecuteNonQuery();


            //MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            //DataSet dt = new DataSet();
            //sda.Fill(dt);
            //con.Close();

            //Int64 id = Convert.ToInt64(dt.Tables[0].Rows[0][0]);
            //label13.Text = (id + 1).ToString();
           label13.Text =  db.registrationCounter();
        }
    }
}
