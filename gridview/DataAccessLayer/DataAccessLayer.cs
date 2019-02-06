using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace gridview.DataAccessLayer
{
    public class DataAccessLayer
    {
        SqlConnection SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AspWebApp"].ConnectionString);


        public DataTable getData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from tblEmp";
            cmd.Connection = SqlConnection;
            SqlConnection.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            SqlConnection.Close();
            return dt;
        }
    }
}
