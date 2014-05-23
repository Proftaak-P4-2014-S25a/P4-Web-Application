using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            user = dbmngr.GetUser(Convert.ToInt32(rfid));
            StringBuilder sb = new StringBuilder(EmailSent.Text);
            sb.Append(user);
            EmailSent.Text = sb.ToString();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {

        }
    }
}