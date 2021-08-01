using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection("Data Source=BILL\\SQLEXPRESS;Initial Catalog=collegemanagement;Integrated Security=True");
        SqlCommand cmd;
       public DataSet fetchData()
        {
            con.Open();
            cmd = new SqlCommand("collegemanagement.searchStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SA.Fill(DS);
            con.Close();
            return DS;
        }

    }

}
