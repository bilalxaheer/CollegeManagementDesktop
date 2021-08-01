using System;
using System.Data;
using System.Windows.Forms;
using DLL;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    public partial class SearchTeacher : Form
    {
        dbConnection db = new dbConnection();
        public SearchTeacher()
        {
            InitializeComponent();
        }

        private void SearchTeacher_Load(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
            //MySqlCommand cmd = new MySqlCommand();
            //con.Open();
            //cmd = new MySqlCommand("searchTeacher", con);
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.ExecuteNonQuery();
            //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            //SA.Fill(DS);
            //con.Close();

            //dataGridView2.DataSource = DS.Tables[0];
              dataGridView2.DataSource = db.grabDataSearchTch().Tables[0];
        }

        //private void btnSearchTch_Click(object sender, EventArgs e)
        //{
        //    if (searchFieldTch.Text != "")
        //    {
        //        //MySqlConnection con = new MySqlConnection();
        //        //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
        //        //MySqlCommand cmd = new MySqlCommand();
        //        //con.Open();
        //        //cmd = new MySqlCommand("searchFieldTch", con);
        //        //cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.Parameters.AddWithValue("@searchFieldTch", searchFieldTch.Text);
        //        //cmd.ExecuteNonQuery();
        //        //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
        //        //DataSet DS = new DataSet();
        //        //SA.Fill(DS);
        //        //con.Close();

        //        //dataGridView2.DataSource = DS.Tables[0];
        //        dataGridView2.DataSource = db.grabDataSearchFieldTch(searchFieldTch.Text).Tables[0];
        //    }
        //    else
        //    {
        //        //MySqlConnection con = new MySqlConnection();
        //        //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
        //        //MySqlCommand cmd = new MySqlCommand();
        //        //con.Open();
        //        //cmd = new MySqlCommand("searchTeacher ", con);
        //        //cmd.CommandType = CommandType.StoredProcedure;

        //        //cmd.ExecuteNonQuery();
        //        //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
        //        //DataSet DS = new DataSet();
        //        //SA.Fill(DS);
        //        //con.Close();

        //        //dataGridView2.DataSource = DS.Tables[0];
        //        dataGridView2.DataSource = db.grabDataSearchTch().Tables[0];
        //    }
        //}
        private void searchFieldTch_TextChanged(object sender, EventArgs e)
        {
            if (searchFieldTch.Text != "")
            {
                //MySqlConnection con = new MySqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //MySqlCommand cmd = new MySqlCommand();
                //con.Open();
                //cmd = new MySqlCommand("searchFieldTch", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@searchFieldTch", searchFieldTch.Text);
                //cmd.ExecuteNonQuery();
                //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //SA.Fill(DS);
                //con.Close();

                //dataGridView2.DataSource = DS.Tables[0];

                dataGridView2.DataSource = db.grabDataSearchFieldTch(searchFieldTch.Text).Tables[0];
            }
            else
            {
                //MySqlConnection con = new MySqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //MySqlCommand cmd = new MySqlCommand();
                //con.Open();
                //cmd = new MySqlCommand("searchTeacher", con);
                //cmd.CommandType = CommandType.StoredProcedure;

                //cmd.ExecuteNonQuery();
                //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //SA.Fill(DS);
                //con.Close();

                //dataGridView2.DataSource = DS.Tables[0];
                dataGridView2.DataSource = db.grabDataSearchTch().Tables[0];
            }
        }
    }
}
