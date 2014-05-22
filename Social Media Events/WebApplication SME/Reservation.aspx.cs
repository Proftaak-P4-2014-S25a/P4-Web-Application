using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_SME
{
    public partial class Reservation1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Login.Text = "Logout";

            }
        }

        protected void Change_Click(object sender, EventArgs e)
        {
            DatabaseMngr dbmngr = new DatabaseMngr();
        }
    }
}