﻿//Loan items code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebApplication_SME
{
    public partial class Loan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                LoginMenu.Text = "Logout";
            }
        }

        protected void btn_AddItem_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Finish_Click(object sender, EventArgs e)
        {

        }
    }
}