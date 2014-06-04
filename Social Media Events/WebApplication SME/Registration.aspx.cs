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
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //*************** TODO ************************
            //**** Send data to database ****//
            DatabaseMngr dbmngr = new DatabaseMngr();

            

            //*************** TODO ************************
            //Send email to new user

            SmtpClient smtpClient = new SmtpClient("localhost", 25);
            smtpClient.Credentials = new System.Net.NetworkCredential("administration@sme.com", "Password1");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            //Creating the mail message
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("administration@sme.com");
            mail.To.Add(new MailAddress(Email.Text));
            mail.Subject = "Validate your email address";
            mail.Body = "Thank you for registering with Social Media Events!" + System.Environment.NewLine +
                "Please check the following data you entered, if anything is incorrect please contact: customers@socialmediaevents.com" + System.Environment.NewLine +
                "Name: " + Name.Text + System.Environment.NewLine +
                "Street: " + Street.Text + System.Environment.NewLine +
                "Postal code: " + PostalCode.Text + System.Environment.NewLine +
                "City: " + City.Text + System.Environment.NewLine +
                "Telephone: " + Phone.Text + System.Environment.NewLine +
                "Bank account number: " + AccountNumber.Text + System.Environment.NewLine +
                "Social Security Number: " + SSN.Text + System.Environment.NewLine + System.Environment.NewLine +
                "If this data is correct, please validate your account by visiting this page: " + System.Environment.NewLine +
                "http://localhost:1515/Validation.aspx?user=" + dbmngr.GetMaxRFID().ToString();

            //Won't work yet
            //smtpClient.Send(mail);
            Response.Redirect("index.aspx");
        }
    }
}