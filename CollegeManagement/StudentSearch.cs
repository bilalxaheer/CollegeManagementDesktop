using System;
using System.Data;
using System.Windows.Forms;
using DLL;
using DevExpress.XtraReports.UI;
using MySql.Data.MySqlClient;

namespace CollegeManagement
{
    public partial class StudentSearch : Form
    {
        dbConnection db = new dbConnection();
        DataTable DS;
        public StudentSearch()
        {
            InitializeComponent();
        }

        private void StudentSearch_Load(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
            //MySqlCommand cmd = new MySqlCommand();
            //con.Open();
            //cmd = new MySqlCommand("searchStudent", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.ExecuteNonQuery();
            //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
            //SA.Fill(DS);
            //con.Close();

            //dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.DataSource = db.fetchData().Tables[0];
        }

        //private void btnSearchStd_Click(object sender, EventArgs e)
        //{
        //    if (searchFieldStd.Text != "")
        //    {
        //        //MySqlConnection con = new MySqlConnection();
        //        //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
        //        //MySqlCommand cmd = new MySqlCommand();
        //        //con.Open();
        //        //cmd = new MySqlCommand("searchStdBtn", con);
        //        //cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.Parameters.AddWithValue("searchFieldStd", searchFieldStd.Text);
        //        //cmd.ExecuteNonQuery();
        //        //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
        //        //DataSet DS = new DataSet();
        //        //SA.Fill(DS);
        //        //con.Close();

        //        //dataGridView1.DataSource = DS.Tables[0];
        //        dataGridView1.DataSource = db.fetchDataSearchStd(searchFieldStd.Text).Tables[0];

        //    }
        //    else
        //    {
        //        //MySqlConnection con = new MySqlConnection();
        //        //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
        //        //MySqlCommand cmd = new MySqlCommand();
        //        //con.Open();
        //        //cmd = new MySqlCommand("searchStudent", con);
        //        //cmd.CommandType = CommandType.StoredProcedure;
        //        //cmd.ExecuteNonQuery();
        //        //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
        //        //DataSet DS = new DataSet();
        //        //SA.Fill(DS);
        //        //con.Close();

        //        //dataGridView1.DataSource = DS.Tables[0];
        //        dataGridView1.DataSource = db.fetchData().Tables[0];
        //    }
        //}

        private void searchFieldStd_TextChanged(object sender, EventArgs e)
        {
            if (searchFieldStd.Text != "")
            {
                //MySqlConnection con = new MySqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //MySqlCommand cmd = new MySqlCommand();
                //con.Open();
                //cmd = new MySqlCommand("searchStdBtn", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("searchFieldStd", searchFieldStd.Text);
                //cmd.ExecuteNonQuery();
                //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //SA.Fill(DS);
                //con.Close();

                //dataGridView1.DataSource = DS.Tables[0];

                dataGridView1.DataSource = db.fetchDataSearchStd(searchFieldStd.Text).Tables[0];
            }

            else
            {
                //MySqlConnection con = new MySqlConnection();
                //con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=collegemanagement";
                //MySqlCommand cmd = new MySqlCommand();
                //con.Open();
                //cmd = new MySqlCommand("searchStudent", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.ExecuteNonQuery();
                //MySqlDataAdapter SA = new MySqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //SA.Fill(DS);
                //con.Close();

                //dataGridView1.DataSource = DS.Tables[0];

               dataGridView1.DataSource = db.fetchData().Tables[0];
            }
        }

    

        private void genReport_Click(object sender, EventArgs e)
        {
            DS = db.fetchData().Tables[0];
            XtraReport1 Xreport = new XtraReport1();
            Xreport.DataSource = DS;
            Xreport.DataMember = "collegemanagement_searchStudent";
            ReportPrintTool PrintTool = new ReportPrintTool(Xreport);
            PrintTool.ShowPreview();
        }
    }
}
