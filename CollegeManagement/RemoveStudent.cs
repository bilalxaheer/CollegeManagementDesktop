using System;
using System.Data;
using System.Windows.Forms;
using DLL;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    public partial class RemoveStudent : Form
    {
        dbConnection db = new dbConnection();
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
            //MySqlCommand cmd = new MySqlCommand();
            //con.Open();
            //cmd = new MySqlCommand("delStudent", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.ExecuteNonQuery();
            //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            //SA.Fill(DS);
            //con.Close();

            //dataGridViewDel.DataSource = DS.Tables[0];
            dataGridViewDel.DataSource = db.removeStdLoad().Tables[0];
        }

        private void btnDeleteStd_Click(object sender, EventArgs e)
        {
            if (DelFieldStd.Text == "")
            {
                MessageBox.Show("Please enter a registration id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                MessageBox.Show("This will Delete Your Data", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                //MySqlConnection con = new MySqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //MySqlCommand cmd = new MySqlCommand();
                //MySqlCommand cmd1;

                //cmd = new MySqlCommand("DelRemoveStd", con);
                //cmd1 = new MySqlCommand("delStudent", con);
                //cmd1.CommandType = CommandType.StoredProcedure;
                //con.Open();
                //cmd.ExecuteNonQuery();
                ////cmd1.ExecuteNonQuery();

                //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
                //MessageBox.Show("student is deleted successfully","success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MySqlDataAdapter SA1 = new MySqlDataAdapter(cmd1);
                //DataSet DS = new DataSet();
                //SA1.Fill(DS);
                //con.Close();

                //dataGridViewDel.DataSource = DS.Tables[0];
                this.DelFieldStd.Clear();
                dataGridViewDel.DataSource = db.btnDelStd(DelFieldStd.Text).Tables[0];

            }
        }


        private void DelFieldStd_TextChanged(object sender, EventArgs e)
        {

            if (DelFieldStd.Text != "")
            {
                //MySqlConnection con = new MySqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //MySqlCommand cmd = new MySqlCommand();

                //con.Open();
                //cmd = new MySqlCommand("DelFieldStd", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@DelFieldStd", DelFieldStd.Text);
                //cmd.ExecuteNonQuery();
                //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //SA.Fill(DS);
                //con.Close();

                //dataGridViewDel.DataSource = DS.Tables[0];

                dataGridViewDel.DataSource = db.fetchdataDelStdField(DelFieldStd.Text).Tables[0];
            }
            else
            {
                //MySqlConnection con = new MySqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //MySqlCommand cmd = new MySqlCommand();
                //con.Open();
                //cmd = new MySqlCommand("delStudent", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.ExecuteNonQuery();
                //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //SA.Fill(DS);
                //con.Close();

                //dataGridViewDel.DataSource = DS.Tables[0];

                dataGridViewDel.DataSource = db.removeStdLoad().Tables[0];
            }
        }
    }
}
