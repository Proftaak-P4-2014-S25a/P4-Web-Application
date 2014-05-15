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
        DatabaseMngr mngr = new DatabaseMngr();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] == null)
            {
                Session.Add("LoggedIn", false);
            }
            if ((bool)Session["LoggedIn"] == true)
            {
                btn_login.Text = "Logout";
                Session["LoggedIn"] = false;
                Response.Redirect("index.aspx");
            }
        }

        protected void sumbit_Click(object sender, EventArgs e)
        {
            if ((bool)Session["LoggedIn"] == false)
            {
                FormsAuthentication.SetAuthCookie(tb_rfid.Text, true);
                FormsAuthentication.s
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

                Session["LoggedIn"] = true;
                Response.Redirect("index.aspx");
            }
        }
    }
}