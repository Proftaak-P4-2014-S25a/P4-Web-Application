//Login code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_SME
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_sumbit.Click += new EventHandler(this.sumbit_Click);
        }

        protected void sumbit_Click(object sender, EventArgs e)
        {
            Session.Add("rfid", tb_rfid.Text);
            Session.Add("pw", tb_pw.Text);
        }
    }
}