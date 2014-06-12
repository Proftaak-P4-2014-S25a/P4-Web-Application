using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace WebApplication_SME
{
    public partial class validate : System.Web.UI.Page
    {
        private string user;
        private DatabaseMngr dbmngr = new DatabaseMngr();
        private List<Campingspot> spots = new List<Campingspot>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Login.Text = "Logout";
            }
            string rfid = Request.QueryString["user"];
            user = dbmngr.GetEmail((rfid));
            if (user != null)
            {
                EmailSent.Text = "An email with login details will be sent to: " + user;
            }
            GoodCampsite.Visible = false;
            spots = dbmngr.GetFreeCampingSpots();
            lbox_Spots.Items.Clear();
            foreach (Campingspot spot in spots)
            {
                lbox_Spots.Items.Add(spot.ToString());
            }

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int aantal = Convert.ToInt32(tb_Members.Text);

            if(aantal < 0)
            {
                string error = "Het aantal extra bezoekers kan niet kleiner dan 0 zijn";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + error + "');", true);
            }

            GoodCampsite.Visible = true;
            List<int> campsites = dbmngr.GetFreeCampsites();
            foreach (int i in campsites)
            {
                if (i == Convert.ToInt32(tb_CampSite.Text))
                {
                    GoodCampsite.Text = "&#x2713;";
                    GoodCampsite.CssClass = "form-control alert alert-success";
                    string rfid = Request.QueryString["user"];
                    dbmngr.SetKampeerplaats(Convert.ToString(dbmngr.GetReservationNumber(rfid)), tb_CampSite.Text);
                    for (int x = 1; x <= aantal x++)
                    {
                        dbmngr.AddKlant(Convert.ToString(dbmngr.GetReservationNumber(rfid)), "TEST1");
                    }
                    break;

                }
                else
                {
                    GoodCampsite.Text = "&#x2717;";
                    GoodCampsite.CssClass = "form-control alert alert-danger";
                    break;
                }
            }
            //Send email to new user

            SmtpClient smtpClient = new SmtpClient("192.168.19.163", 25);
            smtpClient.Credentials = new System.Net.NetworkCredential("administration@sme.com", "Password1");
            smtpClient.UseDefaultCredentials = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = false;

            //Creating the mail message
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("administration@sme.com");
            mail.To.Add(new MailAddress(user));
            mail.Subject = "Thank your for registering!";
            mail.Body = "Thank you for registering with Social Media Events!" + System.Environment.NewLine +
                "Your usernames are: ";
            string list = string.Empty;
            foreach(int i in dbmngr.GetKlanten(dbmngr.GetReservationNumber(Request.QueryString["user"])))
            {
                list += i.ToString() + ", ";
            }
            mail.Body += list + System.Environment.NewLine + "With the password: 'TEST1'";

            smtpClient.Send(mail);
        }
    }
}