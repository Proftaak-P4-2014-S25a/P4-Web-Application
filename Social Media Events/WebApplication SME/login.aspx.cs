﻿//Login code
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
            if (Request.IsAuthenticated)
            {
                this.btn_login.Text = "Logout";
                FormsAuthentication.SignOut();
                Response.Redirect("index.aspx");
            }
        }

        protected void Sumbit_Click(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
            {
                if(this.tb_rfid.Text == "300" && this.tb_pw.Text == "sparta")
                {
                    FormsAuthentication.RedirectFromLoginPage(this.tb_rfid.Text, this.cb_remember.Checked);
                }
                else
                {
                    this.InvalidLogin.Visible = true;
                }
            }
        }
    }
}