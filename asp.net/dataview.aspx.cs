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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //establish coonection to the database
            using (SqlConnection con = new SqlConnection("data source=.; database=aspDB;integrated security=SSPI"))
            {
                SqlDataAdapter sd = new SqlDataAdapter("select * from Students",con);
                

                DataSet ds = new DataSet();

                sd.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }


            //DataTable table = new DataTable();
            //table.Columns.Add("ID");
            //table.Columns.Add("Name");
            //table.Columns.Add("Email");
            //table.Columns.Add("course");

            //table.Rows.Add(101, "Mahi", "alwala@gmail.com", "asp.net");
            //table.Rows.Add(102, "ramya", "ramya@gmail.com", "java");
            //table.Rows.Add(103, "soumya", "soumya@gmail.com", "ML");
            //table.Rows.Add(104, "chandini", "chand@gmail.com", "AI");
            //table.Rows.Add(105, "suhas", "suhas@gmail.com", "IOT");

            //GridView1.DataSource = table;
            //GridView1.DataBind();
        }

       
    }
}