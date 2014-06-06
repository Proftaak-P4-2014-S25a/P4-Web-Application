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
                string item = Convert.ToString(lbox_Rentables.SelectedItem);
                string type = item.Substring(0, item.IndexOf(","));

                foreach (Material m in Materials)
                {
                    if (m.Type == type)
                    {
                        txt_Chosen1.Text = m.Type;
                        Label1.Text = "€" + m.Price;
                        m.Amount--;
                        Update(m.Type, m.Amount);
                        Refresh();
                    }
                }
            }
            else if (txt_Chosen2.Text == "")
            {
               
                    string item = Convert.ToString(lbox_Rentables.SelectedItem);
                    string type = item.Substring(0, item.IndexOf(","));

                    foreach (Material m in Materials)
                    {
                        if (m.Type == type)
                        {
                            txt_Chosen2.Text = m.Type;
                            Label2.Text = "€" + m.Price;
                            m.Amount--;
                            Update(m.Type, m.Amount);
                            Refresh();
                        }
                    }

                
            }
            else if (txt_Chosen3.Text == "")
            {
                
                    string item = Convert.ToString(lbox_Rentables.SelectedItem);
                    string type = item.Substring(0, item.IndexOf(","));

                    foreach (Material m in Materials)
                    {
                        if (m.Type == type)
                        {
                            txt_Chosen3.Text = m.Type;
                            Label3.Text = "€" + m.Price;
                            m.Amount--;
                            Update(m.Type, m.Amount);
                            Refresh();
                        }
                    }

                
            }
            else if (txt_Chosen4.Text == "")
            {
                
                    string item = Convert.ToString(lbox_Rentables.SelectedItem);
                    string type = item.Substring(0, item.IndexOf(","));

                    foreach (Material m in Materials)
                    {
                        if (m.Type == type)
                        {
                            txt_Chosen4.Text = m.Type;
                            Label4.Text = "€" + m.Price;
                            m.Amount--;
                            Update(m.Type, m.Amount);
                            Refresh();
                        }
                    }

                
            }
            else if (txt_Chosen5.Text == "")
            {
                
                    string item = Convert.ToString(lbox_Rentables.SelectedItem);
                    string type = item.Substring(0, item.IndexOf(","));

                    foreach (Material m in Materials)
                    {
                        if (m.Type == type)
                        {
                            txt_Chosen5.Text = m.Type;
                            Label5.Text = "€" + m.Price;
                            m.Amount--;
                            Update(m.Type, m.Amount);
                            Refresh();
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
                    m.Amount = m.Amount + Convert.ToInt32(DropDownList1.SelectedValue);
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen1.Text = "";
            Label1.Text = "€";
        }

        protected void Remove2_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen2.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount = m.Amount + Convert.ToInt32(DropDownList2.SelectedValue);
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen2.Text = "";
            Label2.Text = "€";
        }

        protected void Remove3_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen3.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount = m.Amount + Convert.ToInt32(DropDownList3.SelectedValue);
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen3.Text = "";
            Label3.Text = "€";
        }

        protected void Remove4_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen4.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount = m.Amount + Convert.ToInt32(DropDownList4.SelectedValue);
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen4.Text = "";
            Label4.Text = "€";
        }

        protected void Remove5_Click(object sender, EventArgs e)
        {
            Materials = mngr.GetMaterials();
            string type = txt_Chosen5.Text;
            foreach (Material m in Materials)
            {
                if (m.Type == type)
                {
                    m.Amount= m.Amount + Convert.ToInt32(DropDownList5.SelectedValue);
                    Update(m.Type, m.Amount);
                    Refresh();
                }
            }
            txt_Chosen5.Text = "";
            Label5.Text = "€";
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