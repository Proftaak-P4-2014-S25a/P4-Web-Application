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
            label1.Text = Session.Keys.Count.ToString();
            for (int i = 0; i < Session.Keys.Count; i++)
            {
                label1.Text += ", " + Session.Keys.Get(i);
            }
        }
    }
}