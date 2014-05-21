//Reservation code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Net.Mail;
using System.Net;

namespace WebApplication_SME
{
    public partial class Reservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Login.Text = "Logout";
            }
            Submit.Enabled = false;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //**** Send data to database ****//
            DatabaseMngr dbmngr = new DatabaseMngr();

            //*************** TODO ************************

            //Send email to new user

            //*************** TODO ************************

            SmtpClient smtpClient = new SmtpClient("serveradress", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("email@test.com", "password");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            //Creating the mail message
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("email@test.com");
            mail.To.Add(new MailAddress(Email.Text));
            mail.Subject = "Test";
            mail.IsBodyHtml = true;
            mail.Body = "test";

            //Won't work yet
            //smtpClient.Send(mail);
            Response.Redirect("index.aspx");
        }
    }
}