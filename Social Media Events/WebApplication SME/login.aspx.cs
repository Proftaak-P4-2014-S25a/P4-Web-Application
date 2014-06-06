//Login code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.Configuration;
using System.Configuration;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace WebApplication_SME
{
    public partial class Login : System.Web.UI.Page
    {
        private DatabaseMngr mngr = new DatabaseMngr();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                LoginMenu.Text = "Logout";
                FormsAuthentication.SignOut();
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
            {
                if (mngr.AuthenticateLogin(tb_rfid.Text, tb_pw.Text))
                {
                    Session.Add("UserRFID", tb_rfid.Text);
                    FormsAuthentication.RedirectFromLoginPage(this.tb_rfid.Text, this.cb_remember.Checked);
                }
                else
                {
                    this.InvalidLogin.Visible = true;
                }
            }
        }

        private bool Authenticate(string userName, string password, string domain)
        {
            bool authentic = false;
            try
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + domain,
                    userName, password);
                object nativeObject = entry.NativeObject;
                authentic = true;
            }
            catch (DirectoryServicesCOMException) { }
            return authentic;
        }
    }
}