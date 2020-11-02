using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace FlightProject
{
    public partial class FlightTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            var insertQuery = "insert into Passengers(PassengerName,FlightID,FlightName,Source,Destination)values(@P,@F,@FN,@S,@D)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@P", TextBox5.Text);
            cmd.Parameters.AddWithValue("@F", TextBox1.Text);
            cmd.Parameters.AddWithValue("@FN", TextBox2.Text);
            cmd.Parameters.AddWithValue("@S", TextBox3.Text);
            cmd.Parameters.AddWithValue("@D", TextBox4.Text);
            


            int affected_rows=cmd.ExecuteNonQuery();
            if(affected_rows>0)
            {
                Label2.Text += "Hello" + "  " + TextBox5.Text + "Your  flight  details are as follows" + "<br>" +
                            "your Flight Id is " + " " + TextBox1.Text +
                            "<br>" + "your Flight  Name is" + "  " + TextBox2.Text +
                             "<br>" + "from" + "  " + TextBox3.Text + "<br>" +
                             "to" + "  " + TextBox4.Text +
                             "<br>" + "Have a safe and happy Journey";

            }
            con.Close();
            Response.Redirect("Boardingpass.aspx");

        }
    }
}