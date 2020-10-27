using System;
using System.Collections.Generic;
using System.IO;
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
            ShowDate.Text = "you have selected" + Calendar1.SelectedDate.ToString("D");
            
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
            redlbl.Text = "ASP.NET";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bluelbl.Text = "ASP.NET";
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            yellbl.Text = "ASP.NET";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var x = "";
            if (CheckBox1.Checked)
                x = "you selected : " +" " +CheckBox1.Text;

            if (CheckBox2.Checked)
                x ="you selected:"+" "+ CheckBox2.Text;

            if (CheckBox3.Checked)
                x ="you selected:"+" "+ CheckBox3.Text;

            if (CheckBox4.Checked)
                x = "you selected:"+" " +CheckBox4.Text;

            ShowCourse.Text = x;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label2.Text = "WELCOME TO FACEBOOK";
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Label3.Text = "WELCOME TO YOUTUBE";
        }

        protected void uploadedfile_Click(object sender, EventArgs e)
        {
            Response.Write("image one is uploaded");
            if(FileUpload1.HasFiles)
            {
                foreach (HttpPostedFile uploadedfile in FileUpload1.PostedFiles) 
                {
                    uploadedfile.SaveAs(System.IO.Path.Combine(Server.MapPath("~/Images/"), uploadedfile.FileName));
                    ListOfUploadedFiles.Text += string.Format("{0}<br/>", uploadedfile.FileName);
                }
                Response.Write("images are sucessfully uploaded");
            }
        }

        protected void download_Click(object sender, EventArgs e)
        {
            var filepath = "C:\\Users\\amahi2\\OneDrive - DXC Production\\Desktop\\WeekAssignments.txt";
            FileInfo file = new FileInfo(filepath);//constructor ==>storing /intializin gthe local file path from my laptop
            if(file.Exists)
            {
                Response.Clear();

                //add header by specifying file name
                Response.AddHeader("Content Disposition", "Attachment ,filename=" + file.Name);

                //add header for content length
                Response.AddHeader("Content-Length", file.Length.ToString());

                //specify type of the content
                Response.ContentType = "text/plain";

                //clearing flush
                Response.Flush();

                //transmit the file
                Response.TransmitFile(file.FullName);
                Response.End();
            }
            else
            {
                dwnlbl.Text = "requested file is not avaliable to downlaod";
            }
        }
    }
}