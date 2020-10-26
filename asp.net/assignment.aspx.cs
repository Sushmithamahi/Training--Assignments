using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asppages
{
    public partial class assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();//keeps the cursor within the textbox
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("button is working fine");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("text entered");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("");
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("aspp");
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write("aaaa");
        }
    }
}