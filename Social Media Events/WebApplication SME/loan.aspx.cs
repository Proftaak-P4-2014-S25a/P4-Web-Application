//Loan items code
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
        private DatabaseMngr mngr = new DatabaseMngr();

        private List<Material> Materials = new List<Material>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                LoginMenu.Text = "Logout";
                RegMenu.Visible = false;
            }
        }

        protected void btn_AddItem_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            if (lbox_Rentables.SelectedItem==null)
            {
                string error = "SELECTEER IETS";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + error + "');", true);
                return;
            }
            
            if (txt_Chosen1.Text == "")
            {
                LoanMaterial(txt_Chosen1.Text, Label10.Text);
            }
            else if (txt_Chosen2.Text == "")
            {
                LoanMaterial(txt_Chosen2.Text, Label8.Text);
            }
            else if (txt_Chosen3.Text == "")
            {
                LoanMaterial(txt_Chosen3.Text, Label7.Text);
            }
            else if (txt_Chosen4.Text == "")
            {
                LoanMaterial(txt_Chosen4.Text, Label10.Text);
            }
            else if (txt_Chosen5.Text == "")
            {
                LoanMaterial(txt_Chosen5.Text, Label6.Text);
            }
        }

        public void LoanMaterial(string chosenbox, string chosenlabel)
        {
            string item = Convert.ToString(lbox_Rentables.SelectedItem);
            string type = item.Substring(0, item.IndexOf(","));
            string chosen = Convert.ToString(chosenbox);

            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    if (m.Amount > 0)
                    {
                        chosenbox = m.Type;
                        chosenlabel = Convert.ToString(m.Price);
                        m.Amount--;
                        Label11.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + Convert.ToInt32(Label7.Text) + Convert.ToInt32(Label8.Text) + Convert.ToInt32(Label9.Text) + Convert.ToInt32(Label10.Text));
                        Update(m.Type, m.Amount);
                        Refresh();
                    }
                    else
                    {
                        string error = "MATERIAAL NIET IN VOORRAAD";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + error + "');", true);
                    }
                }
            }
        }
                 
        protected void Remove1_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen1.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount = m.Amount + 1;
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen1.Text = "";
            Label1.Text = "€";
            Label9.Text = "0";
            Label11.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + Convert.ToInt32(Label7.Text) + Convert.ToInt32(Label8.Text) + Convert.ToInt32(Label9.Text) + Convert.ToInt32(Label10.Text));
        }

        protected void Remove2_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen2.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount = m.Amount + 1;
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen2.Text = "";
            Label2.Text = "€";
            Label8.Text = "0";
            Label11.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + Convert.ToInt32(Label7.Text) + Convert.ToInt32(Label8.Text) + Convert.ToInt32(Label9.Text) + Convert.ToInt32(Label10.Text));
        }

        protected void Remove3_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen3.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount = m.Amount + 1;
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen3.Text = "";
            Label3.Text = "€";
            Label7.Text = "0";
            Label11.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + Convert.ToInt32(Label7.Text) + Convert.ToInt32(Label8.Text) + Convert.ToInt32(Label9.Text) + Convert.ToInt32(Label10.Text));
        }

        protected void Remove4_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen4.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount = m.Amount + 1;
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen4.Text = "";
            Label4.Text = "€";
            Label10.Text = "0";
            Label11.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + Convert.ToInt32(Label7.Text) + Convert.ToInt32(Label8.Text) + Convert.ToInt32(Label9.Text) + Convert.ToInt32(Label10.Text));
        }

        protected void Remove5_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen5.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount = m.Amount + 1;
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen5.Text = "";
            Label5.Text = "€";
            Label6.Text = "0";
            Label11.Text = Convert.ToString(Convert.ToInt32(Label6.Text) + Convert.ToInt32(Label7.Text) + Convert.ToInt32(Label8.Text) + Convert.ToInt32(Label9.Text) + Convert.ToInt32(Label10.Text));
        }

        protected void btn_Finish_Click(object sender, EventArgs e)
        {

        }

        protected void RefreshList_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        public void Refresh()
        {
            Materials = mngr.GetMaterials();
            lbox_Rentables.Items.Clear();
            foreach (Material m in Materials)
            {
                lbox_Rentables.Items.Add(Convert.ToString(m.Type + ", " + "Amount: " + m.Amount));
            }
        }
        public void Update(string materiaalnaam,int amount)
        {
            mngr.UpdateMateriaal(materiaalnaam,amount);
        }
    }
}

