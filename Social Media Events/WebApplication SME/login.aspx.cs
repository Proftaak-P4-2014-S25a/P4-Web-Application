//Login code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebApplication_SME
{
    public partial class Login : System.Web.UI.Page
    {
        private DatabaseMngr mngr = new DatabaseMngr();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["LoggedIn"] == null)
            {
                this.Session.Add("LoggedIn", false);
            }
            if ((bool)this.Session["LoggedIn"] == true)
            {
                this.btn_login.Text = "Logout";
                this.Session["LoggedIn"] = false;
                Response.Redirect("index.aspx");
            }
        }

        protected void Sumbit_Click(object sender, EventArgs e)
        {
            if ((bool)this.Session["LoggedIn"] == false)
            {
                FormsAuthentication.SetAuthCookie(this.tb_rfid.Text, true);

                /*
                bool rememberMe = cb_remember.Checked;
                int timeout = rememberMe ? 525600 : 30; // Timeout in minutes, 525600 = 365 days
                var ticket = new FormsAuthenticationTicket(tb_rfid.Text, rememberMe, timeout);
                string encrypted = FormsAuthentication.Encrypt(ticket);
                var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                cookie.Expires = System.DateTime.Now.AddMinutes(timeout);
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);
                 */

                this.Session["LoggedIn"] = true;
                Response.Redirect("index.aspx");
            }
        }
    }
}