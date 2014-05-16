//Loan items code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_SME
{
    public partial class Loan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["LoggedIn"] == null)
            {
                this.Session.Add("LoggedIn", false);
            }
            if ((bool)this.Session["LoggedIn"] == true)
            {
                this.btn_login.Text = "Logout";
            }
        }
    }
}