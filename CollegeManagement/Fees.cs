using System;
using System.Data;
using System.Windows.Forms;
using DLL;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    public partial class Fees : Form
    {
        dbConnection db = new dbConnection();
        public Fees()
        {
            InitializeComponent();
        }

        private void Fees_Load(object sender, EventArgs e)
        {


        }

        private void txtRegisterFee_TextChanged(object sender, EventArgs e)
        {
            if (txtRegisterFee.Text != "")
            {
                string[] array1 = db.fees(txtRegisterFee.Text);
                string count = array1[0];
                if (count != "0")
                {

                    fnameFee.Text = array1[1];
                    gnameFee.Text = array1[2];
                    durationFee.Text = array1[3];
                }
                else if (count == "0")
                {
                    fnameFee.Text = "______________________";
                    gnameFee.Text = "______________________";
                    durationFee.Text = "______________________";
                }
            }
            else
            {
                txtRegisterFee.Text = "";
                txtFees.Text = "";
                fnameFee.Text = "______________________";
                gnameFee.Text = "______________________";
                durationFee.Text = "______________________";
            }


        }

        private void btnSubmitFee_Click(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
            //MySqlCommand cmd = new MySqlCommand();
            //con.Open();
            //cmd = new MySqlCommand("selectFee", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@txtRegisterFee", txtRegisterFee.Text);
            //cmd.ExecuteNonQuery();
            //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            //SA.Fill(DS);
            //con.Close();

            //if (DS.Tables[0].Rows.Count == 0)
            //{
            //    MySqlConnection con1 = new MySqlConnection();
            //    con1.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
            //    MySqlCommand cmd1 = new MySqlCommand();
            //    con1.Open();
            //    cmd1 = new MySqlCommand("insertFee", con1);
            //    cmd1.CommandType = CommandType.StoredProcedure;
            //    cmd1.Parameters.AddWithValue("@txtRegisterFee", txtRegisterFee.Text);
            //    cmd1.Parameters.AddWithValue("@txtFees", txtFees.Text);

            //    cmd1.ExecuteNonQuery();
            //    MySqlDataAdapter SA1 = new MySqlDataAdapter(cmd1);
            //    DataSet DS1 = new DataSet();
            //    SA1.Fill(DS1);
            //    con1.Close();

            //    if (MessageBox.Show("Fee Submit is Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            //    {
            //        txtRegisterFee.Text = "";
            //        txtFees.Text = "";
            //        fnameFee.Text = "______________________";
            //        gnameFee.Text = "______________________";
            //        durationFee.Text = "______________________";

            //    }
            //}

            //else
            //{
            //    MessageBox.Show("Fee is already Submitted");
            //    txtRegisterFee.Text = "";
            //    txtFees.Text = "";
            //    fnameFee.Text = "______________________";
            //    gnameFee.Text = "______________________";
            //    durationFee.Text = "______________________";
            if (txtRegisterFee.Text != "")

            {

                string count = db.submitFee(txtRegisterFee.Text);
                if (count == "0")
                {
                    if (fnameFee.Text == "______________________")
                    {

                        MessageBox.Show("No student found against this id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtFees.Text =="")
                    {
                         MessageBox.Show("Please Enter The Fee Mentioned on Challan Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        db.insertFee(txtRegisterFee.Text, txtFees.Text);

                        MessageBox.Show("Fee Submit is Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        txtRegisterFee.Text = "";
                        txtFees.Text = "";
                        fnameFee.Text = "______________________";
                        gnameFee.Text = "______________________";
                        durationFee.Text = "______________________";
                    }
                }
                else
                {
                    MessageBox.Show("Fee is already Submitted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRegisterFee.Text = "";
                    txtFees.Text = "";
                    fnameFee.Text = "______________________";
                    gnameFee.Text = "______________________";
                    durationFee.Text = "______________________";
                }

            }
            else
            {
                MessageBox.Show("Please enter registration number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

//{

//    MySqlConnection con = new MySqlConnection();
//    con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
//    MySqlCommand cmd = new MySqlCommand();
//    con.Open();
//    cmd = new MySqlCommand("AddFeeRegistration", con);
//    cmd.CommandType = CommandType.StoredProcedure;
//    cmd.Parameters.AddWithValue("@txtRegisterFee", txtRegisterFee.Text);

//    cmd.ExecuteNonQuery();


//    MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
//    DataSet DS = new DataSet();
//    SA.Fill(DS);
//    con.Close();

//    if (DS.Tables[0].Rows.Count != 0)
//    {
//        fnameFee.Text = DS.Tables[0].Rows[0][0].ToString();
//        gnameFee.Text = DS.Tables[0].Rows[0][1].ToString();
//        durationFee.Text = DS.Tables[0].Rows[0][2].ToString();

//    }

//    else
//    {
//        fnameFee.Text = "______________________";
//        gnameFee.Text = "______________________";
//        durationFee.Text = "______________________";
//    }
//}
//else
//{
//    txtRegisterFee.Text = "";
//    txtFees.Text = "";
//    fnameFee.Text = "______________________";
//    gnameFee.Text = "______________________";
//    durationFee.Text = "______________________";
//}