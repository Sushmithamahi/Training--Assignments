using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class Cricket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //establish coonection to the database
            using (SqlConnection con = new SqlConnection("data source=.; database=aspDB;integrated security=SSPI"))
            {
                SqlDataAdapter sd = new SqlDataAdapter("select * from IndianCricket ", con);


                DataSet ds = new DataSet();

                sd.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
        }
    }
}