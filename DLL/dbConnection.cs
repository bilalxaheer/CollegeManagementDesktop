using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DLL.ServiceReference1;

namespace DLL
{
    public class dbConnection
    {
        //SqlConnection con = new SqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement");
        SqlConnection con = new SqlConnection("Data Source=BILL\\SQLEXPRESS;Initial Catalog=collegemanagement;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd1;

        public string Login(string UserName, string Password)
        {

            con.Open();
            cmd = new SqlCommand("loginCheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@PersonPassword", Password);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            string count = dt.Rows[0][0].ToString();
            con.Close();
            return count;

        }

        public void newAdmission(string TxtFname, string TxtGname, string Gender, string TxtDob, string TxtMobile, string TxtEmail, string TxtSemster, string TxtProg, string TxtSname, string TxtDuration, string TxtAddress)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("collegemanagement.NewAdmInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fname", TxtFname);
                cmd.Parameters.AddWithValue("@gname", TxtGname);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@dob", TxtDob);
                cmd.Parameters.AddWithValue("@mobile", TxtMobile);
                cmd.Parameters.AddWithValue("@email", TxtEmail);
                cmd.Parameters.AddWithValue("@semster", TxtSemster);
                cmd.Parameters.AddWithValue("@prog", TxtProg);
                cmd.Parameters.AddWithValue("@school", TxtSname);
                cmd.Parameters.AddWithValue("@duration", TxtDuration);
                cmd.Parameters.AddWithValue("@address", TxtAddress);
                SqlDataAdapter Ds = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Data Saved. Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string registrationCounter()
        {
            con.Open();
            cmd = new SqlCommand("collegemanagement.MaxId", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            con.Close();

            Int64 id = Convert.ToInt64(dt.Tables[0].Rows[0][0]);
            string label13 = (id + 1).ToString();
            return label13;
        }



        public void updatesemester(string Upsemster1, string Upsemster2)
        {
            if (Upsemster1 != "" && Upsemster2 != "")
            {

                con.Open();
                cmd = new SqlCommand("collegemanagement.UpdateSemster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UpSemster1", Upsemster1);
                cmd.Parameters.AddWithValue("@UpSemster2", Upsemster2);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Are you sure you want to Update semester?", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                MessageBox.Show("Upgrade semester is successfull", "Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Upgrade semester is Unsuccessfull", "Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public string[] fees(string txtRegisterFee)
        {

            con.Open();
            cmd = new SqlCommand("collegemanagement.AddFeeRegistration", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@txtRegisterFee", txtRegisterFee);

            cmd.ExecuteNonQuery();


            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();
            string count = DS.Tables[0].Rows.Count.ToString();

            if (count != "0")
            {
                string[] array;
                string fnameFee = DS.Tables[0].Rows[0][0].ToString();
                string gnameFee = DS.Tables[0].Rows[0][1].ToString();
                string durationFee = DS.Tables[0].Rows[0][2].ToString();

                array = new string[4] { count, fnameFee, gnameFee, durationFee };

                return array;
            }
            else
            {
                string[] array;
                array = new string[1] { count };

                return array;
            }
        }

        public string submitFee(string txtRegisterFee)
        {
            con.Open();
            cmd = new SqlCommand("collegemanagement.selectFee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@txtRegisterFee", txtRegisterFee);
            cmd.ExecuteNonQuery();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();
            string count = DS.Tables[0].Rows.Count.ToString();
            return count;
        }

        public void insertFee(string txtRegisterFee, string txtFees)

        {
            con.Open();
            cmd1 = new SqlCommand("collegemanagement.insertFee", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@txtRegisterFee", txtRegisterFee);
            cmd1.Parameters.AddWithValue("@txtFees", txtFees);

            cmd.ExecuteNonQuery();
            SqlDataAdapter SA1 = new SqlDataAdapter(cmd1);
            DataSet DS1 = new DataSet();
            SA1.Fill(DS1);
            con.Close();
        }

        public DataSet fetchData()
        {

            Service1Client client = new Service1Client();
            client.fetchData();
            DataSet DS = new DataSet();
            DS = client.fetchData();
            return DS;

            //con.Open();
            //cmd = new SqlCommand("collegemanagement.searchStudent", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter SA = new SqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            //SA.Fill(DS);
            //con.Close();
            //return DS;
        }

        public DataSet fetchDataSearchStd(string searchFieldStd)
        {
            con.Open();
            cmd = new SqlCommand("collegemanagement.searchStdBtn", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@searchFieldStd", searchFieldStd);
            cmd.ExecuteNonQuery();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();

            return DS;
        }

        public DataSet grabDataSearchTch()
        {

            con.Open();
            cmd = new SqlCommand("collegemanagement.searchTeacher", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();
            return DS;

        }

        public DataSet grabDataSearchFieldTch(string searchFieldTch)
        {
            con.Open();
            cmd = new SqlCommand("collegemanagement.searchFieldTch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@searchFieldTch", searchFieldTch);
            cmd.ExecuteNonQuery();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();
            return DS;

        }

        public void addTeacher(string TxtFnameTch, string Gender, string TxtDobTch, string TxtMobileTch, string TxtEmailTch, string TxtSemsterTch, string TxtProgTch, string TxtDurationTch, string TxtAddressTch)
        {
            try
            {
                //SqlConnection con = new SqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=CollegeManagement";
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand("addTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@TchFullName", TxtFnameTch);
                cmd.Parameters.AddWithValue("@TchGender", Gender);
                cmd.Parameters.AddWithValue("@TchDob", TxtDobTch);
                cmd.Parameters.AddWithValue("@TchMobile", TxtMobileTch);
                cmd.Parameters.AddWithValue("@TchEmail", TxtEmailTch);
                cmd.Parameters.AddWithValue("@TchSemester", TxtSemsterTch);
                cmd.Parameters.AddWithValue("@TchProg", TxtProgTch);
                cmd.Parameters.AddWithValue("@TchDuration", TxtDurationTch);
                cmd.Parameters.AddWithValue("@TchAddress", TxtAddressTch);
                SqlDataAdapter Ds = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Data Saved. Teacher Added Successfully", "Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public DataSet removeStdLoad()
        {
            con.Open();
            cmd = new SqlCommand("collegemanagement.delStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();
            return DS;
        }

        public DataSet btnDelStd(string DelFieldStd)
        {
            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd1;

            cmd = new SqlCommand("collegemanagement.DelRemoveStd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DelFieldStd", DelFieldStd);
            cmd1 = new SqlCommand("collegemanagement.delStudent", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.ExecuteNonQuery();
            //cmd1.ExecuteNonQuery();

            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            MessageBox.Show("student is deleted successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlDataAdapter SA1 = new SqlDataAdapter(cmd1);
            DataSet DS = new DataSet();
            SA1.Fill(DS);
            con.Close();
            return DS;


        }

        public DataSet fetchdataDelStdField(string DelFieldStd)
        {

            con.Open();
            cmd = new SqlCommand("collegemanagement.DelFieldStd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DelFieldStd", DelFieldStd);
            cmd.ExecuteNonQuery();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();
            return DS;

        }

        public string[] StdIndividualDetails(string txtRegisterIndvidual)
        {

            con.Open();
            cmd = new SqlCommand("collegemanagement.stdIndvidualDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@txtRegisterIndvidual", txtRegisterIndvidual);
            cmd.ExecuteNonQuery();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();

            string count = DS.Tables[0].Rows.Count.ToString();

            if (count != "0")
            {
                string[] array;
                string labelFullName = DS.Tables[0].Rows[0][1].ToString();
                string labelGname = DS.Tables[0].Rows[0][2].ToString();
                string labelGender = DS.Tables[0].Rows[0][3].ToString();
                string labelDob = DS.Tables[0].Rows[0][4].ToString();
                string labelMobile = DS.Tables[0].Rows[0][5].ToString();
                string labelEmail = DS.Tables[0].Rows[0][6].ToString();
                string labelStandard = DS.Tables[0].Rows[0][7].ToString();
                string labelMedium = DS.Tables[0].Rows[0][8].ToString();
                string labelSchoolName = DS.Tables[0].Rows[0][9].ToString();
                string labelYear = DS.Tables[0].Rows[0][10].ToString();
                string labelAddress = DS.Tables[0].Rows[0][11].ToString();


                array = new string[12] { count, labelFullName, labelGname, labelGender, labelDob, labelMobile, labelEmail, labelStandard, labelMedium, labelSchoolName, labelYear, labelAddress };

                return array;
            }
            else
            {
                string[] array;
                array = new string[1] { count };

                return array;
            }
        }

        public void updateStd(int labelRegisterationInfo, string UpdateFullName, string UpdateGname, string UpdateGender, string UpdateDob, string UpdateMobile, string UpdateEmail, string UpdateSemster, string UpdateProg, string UpdateSname, string UpdateDuration, string UpdateAddress)
        {
            con.Open();
            cmd = new SqlCommand("collegemanagement.updateStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@labelRegisterationInfo", labelRegisterationInfo);
            cmd.Parameters.AddWithValue("@UpdateFullName", UpdateFullName);
            cmd.Parameters.AddWithValue("@UpdateGname", UpdateGname);
            cmd.Parameters.AddWithValue("@UpdateGender", UpdateGender);
            cmd.Parameters.AddWithValue("@UpdateDob", UpdateDob);
            cmd.Parameters.AddWithValue("@UpdateMobile", UpdateMobile);
            cmd.Parameters.AddWithValue("@UpdateEmail", UpdateEmail);
            cmd.Parameters.AddWithValue("@UpdateSemster", UpdateSemster);
            cmd.Parameters.AddWithValue("@UpdateProg", UpdateProg);
            cmd.Parameters.AddWithValue("@UpdateSname", UpdateSname);
            cmd.Parameters.AddWithValue("@UpdateDuration", UpdateDuration);
            cmd.Parameters.AddWithValue("@UpdateAddress", UpdateAddress);

            cmd.ExecuteNonQuery();
            con.Close();

        }

        public string signUpEmailCheck(string PersonEmail)
        {
            con.Open();
            //string check_userID = "SELECT * from signup WHERE UserEmail ='" + PersonEmail.Text + "' ";
            cmd = new SqlCommand("EmailCheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonEmail", PersonEmail);
            SqlDataAdapter Ds = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Ds.Fill(dt);
            cmd.ExecuteNonQuery();
            string count = dt.Rows[0][0].ToString();
            con.Close();
            return count;
        }

        public void signUpBtnClick(string PersonName, string PersonEmail, string ConfirmPersonPassword)
        {
            
                con.Open();
                cmd = new SqlCommand("SignUp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonName", PersonName);
                cmd.Parameters.AddWithValue("@PersonEmail", PersonEmail);
                cmd.Parameters.AddWithValue("@ConfirmPersonPassword", ConfirmPersonPassword);
                //SqlDataAdapter DA = new SqlDataAdapter(cmd);
                //DataTable df = new DataTable();
                //DA.Fill(df);
                cmd.ExecuteNonQuery();
                con.Close();
          
        }

    }
}
