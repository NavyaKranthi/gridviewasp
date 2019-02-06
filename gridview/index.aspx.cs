using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System;

namespace gridview
{
    public partial class index : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();


        protected void Page_Load(object sender, EventArgs e)
        {
            GridView11.DataSource = dal.getData();
            GridView11.DataBind();
        }
    }
}