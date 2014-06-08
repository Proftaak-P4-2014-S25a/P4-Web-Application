//Entry-control code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebApplication_SME
{
    public partial class Entry : System.Web.UI.Page
    {
        private DatabaseMngr mngr = new DatabaseMngr();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                Succes.Visible = false;
                Unsuccess.Visible = false;
                LoginMenu.Text = "Logout";
            }
        }

        protected void entry_Click(object sender, EventArgs e)
        {
         
            if (mngr.HasPaid(mngr.GetReservationNumber((info.Text))) == "true")
            {
                Unsuccess.Visible = false;
                    if (mngr.GetPersoon(info.Text) != null)
                    {
                        Succes.Visible = true;
                        TextBox_persons.Text = (mngr.GetPersoon(info.Text).ToString());
                    }
                    else
                    {
                        string error = "Persoon bestaat niet";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + error + "');", true);
                    }
                    
            }
            else
            {
                TextBox_persons.Text = (mngr.GetPersoon(info.Text).ToString());
                Succes.Visible = false;
                Unsuccess.Visible = true;
            }
        }
    }
}