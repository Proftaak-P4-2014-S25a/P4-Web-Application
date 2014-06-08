using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_SME
{
    public partial class validate : System.Web.UI.Page
    {
        private string user;
        private DatabaseMngr dbmngr = new DatabaseMngr();
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
                EmailSent.Text = "An email with login details has been sent to: " + user;
            }
            GoodCampsite.Visible = false;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            GoodCampsite.Visible = true;
            List<int> campsites = dbmngr.GetFreeCampsites();
            foreach (int i in campsites)
            {
                if (i == Convert.ToInt32(tb_CampSite.Text))
                {
                    GoodCampsite.Text = "&#x2713;";
                    GoodCampsite.CssClass = "form-control alert alert-success";
                    return;
                }
                else
                {
                    GoodCampsite.Text = "&#x2717;";
                    GoodCampsite.CssClass = "form-control alert alert-danger";
                    continue;
                }
            }
        }
    }
}