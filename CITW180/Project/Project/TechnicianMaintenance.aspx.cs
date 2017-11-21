using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class TechnicianMaintenance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FormView1.SelectMethod = "Select * From Technicians Where TechID = '" + DropDownList1.SelectedValue.ToString() + "';";
            //FormView1.DataBind();
            //TestLabel.Text = "Select * From Technicians Where TechID = '" + DropDownList1.SelectedValue.ToString() + "';";
        }
    }
}