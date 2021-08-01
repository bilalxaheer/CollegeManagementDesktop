using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DLL;


namespace CollegeManagement
{
    public partial class UpdateSemseter : Form
    {
        dbConnection db = new dbConnection();
        public UpdateSemseter()
        {
            InitializeComponent();
        }

        private void btnUpSemster_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to Update semester?","Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            //{
            //    MySqlConnection con = new MySqlConnection();
            //    con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
            //    MySqlCommand cmd = new MySqlCommand();

            //    con.Open();
            //    cmd = new MySqlCommand("UpdateSemster", con);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@UpSemster1",UpSemster1.Text);
            //    cmd.Parameters.AddWithValue("@UpSemster2",UpSemster2.Text);
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Upgrade semester is successfull", "Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            //    MessageBox.Show("Upgrade semester is Unsuccessfull", "Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}
            db.updatesemester(UpSemster1.Text, UpSemster2.Text);
        }
    }
}
