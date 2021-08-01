using System;
using System.Data;
using System.Windows.Forms;
using DLL;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    public partial class StudentIndvidualDetails : Form
    {
        dbConnection db = new dbConnection();
        public StudentIndvidualDetails()
        {
            InitializeComponent();
        }


        private void showDetailsBtn_Click(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
            //MySqlCommand cmd = new MySqlCommand();
            //con.Open();
            //cmd = new MySqlCommand("stdIndvidualDetails", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@txtRegisterIndvidual", txtRegisterIndvidual.Text);
            //cmd.ExecuteNonQuery();
            //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            //SA.Fill(DS);
            //con.Close();

            //if (DS.Tables[0].Rows.Count != 0)
            //{

            //    labelFullName.Text = DS.Tables[0].Rows[0][1].ToString();
            //    labelGname.Text = DS.Tables[0].Rows[0][2].ToString();
            //    labelGender.Text = DS.Tables[0].Rows[0][3].ToString();
            //    labelDob.Text = DS.Tables[0].Rows[0][4].ToString();
            //    labelMobile.Text = DS.Tables[0].Rows[0][5].ToString();
            //    labelEmail.Text = DS.Tables[0].Rows[0][6].ToString();
            //    labelStandard.Text = DS.Tables[0].Rows[0][7].ToString();
            //    labelMedium.Text = DS.Tables[0].Rows[0][8].ToString();
            //    labelSchoolName.Text = DS.Tables[0].Rows[0][9].ToString();
            //    labelYear.Text = DS.Tables[0].Rows[0][10].ToString();
            //    labelAddress.Text = DS.Tables[0].Rows[0][11].ToString();

            //}
            //else
            //{
            //    MessageBox.Show("No record found!", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    labelFullName.Text = "_______________";
            //    labelGname.Text = "_______________";
            //    labelGender.Text = "_______________";
            //    labelDob.Text = "_______________";
            //    labelMobile.Text = "_______________";
            //    labelEmail.Text = "_______________";
            //    labelStandard.Text = "_______________";
            //    labelMedium.Text = "_______________";
            //    labelSchoolName.Text = "_______________";
            //    labelYear.Text = "_______________";
            //    labelAddress.Text = "_______________";
            //}

           
            if (txtRegisterIndvidual.Text == "")
            {
                MessageBox.Show("Enter Registration ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            else if (txtRegisterIndvidual.Text != "")
            {
                string[] array1 = db.StdIndividualDetails(txtRegisterIndvidual.Text);
                string count = array1[0];
                if (count != "0")
                {

                    labelFullName.Text = array1[1];
                    labelGname.Text = array1[2];
                    labelGender.Text = array1[3];
                    labelDob.Text = array1[4];
                    labelMobile.Text = array1[5];
                    labelEmail.Text = array1[6];
                    labelStandard.Text = array1[7];
                    labelMedium.Text = array1[8];
                    labelSchoolName.Text = array1[9];
                    labelYear.Text = array1[10];
                    labelAddress.Text = array1[11];
                }
                else if (count == "0")
                {
                    MessageBox.Show("No Student Found. Enter a valid Registration id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegisterIndvidual.Text = "";
                    labelFullName.Text = "_______________";
                    labelGname.Text = "_______________";
                    labelGender.Text = "_______________";
                    labelDob.Text = "_______________";
                    labelMobile.Text = "_______________";
                    labelEmail.Text = "_______________";
                    labelStandard.Text = "_______________";
                    labelMedium.Text = "_______________";
                    labelSchoolName.Text = "_______________";
                    labelYear.Text = "_______________";
                    labelAddress.Text = "_______________";
                }
            }
            else
            {
                txtRegisterIndvidual.Text = "";
                labelFullName.Text = "_______________";
                labelGname.Text = "_______________";
                labelGender.Text = "_______________";
                labelDob.Text = "_______________";
                labelMobile.Text = "_______________";
                labelEmail.Text = "_______________";
                labelStandard.Text = "_______________";
                labelMedium.Text = "_______________";
                labelSchoolName.Text = "_______________";
                labelYear.Text = "_______________";
                labelAddress.Text = "_______________";
            }




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "_______________";
            labelGname.Text = "_______________";
            labelGender.Text = "_______________";
            labelDob.Text = "_______________";
            labelMobile.Text = "_______________";
            labelEmail.Text = "_______________";
            labelStandard.Text = "_______________";
            labelMedium.Text = "_______________";
            labelSchoolName.Text = "_______________";
            labelYear.Text = "_______________";
            labelAddress.Text = "_______________";
        }

        private void BtnUpdateStd_Click(object sender, EventArgs e)
        {
            if (txtRegisterIndvidual.Text != "")
            {

                string registration = txtRegisterIndvidual.Text;
                string fullname = labelFullName.Text;
                string Gname = labelGname.Text;
                string Gender = labelGender.Text;
                string Dob = labelDob.Text;
                string Mobile = labelMobile.Text;
                string Email = labelEmail.Text;
                string Standard = labelStandard.Text;
                string Medium = labelMedium.Text;
                string Sname = labelSchoolName.Text;
                string Year = labelYear.Text;
                string Address = labelAddress.Text;

                this.Hide();

                UpdateStudent US = new UpdateStudent(registration, fullname, Gname, Gender, Dob, Mobile, Email, Standard, Medium, Sname, Year, Address);
                US.Show();
            }
            else
            {
                MessageBox.Show("Enter a Registration id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
