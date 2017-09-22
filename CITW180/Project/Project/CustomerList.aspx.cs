using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
        protected void UpdateList()
        {
            //customerListBox.Items.Clear();
            ArrayList customersList = (ArrayList)Session["customersList"];
            if (customersList == null)
                customersList = new ArrayList();
            foreach(Customer c in customersList)
            {
                string s = c.name + " " + c.phone + " " + c.email;
                customerListBox.Items.Add(s);
            }            
        }

        protected void removeBtn_Click(object sender, EventArgs e)
        {
            ArrayList customersList = (ArrayList)Session["customersList"];
            customersList.RemoveAt(customerListBox.SelectedIndex);
            customerListBox.Items.Remove(customerListBox.SelectedItem);
            customerListBox.ClearSelection();
            Session["customersList"] = customersList;
            Response.Redirect("CustomerList.aspx");
        }

        protected void emptyBtn_Click(object sender, EventArgs e)
        {
            ArrayList customersList = new ArrayList();
            Session["customersList"] = customersList;
            customerListBox.ClearSelection();
            customerListBox.Items.Clear();
            Response.Redirect("CustomerList.aspx");
        }

        protected void customerDisplay_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDisplay.aspx");
        }
    }
}