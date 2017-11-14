using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class CustomerIncidentDisplay : System.Web.UI.Page
    {
        string baseSelect = "SELECT Products.Name as pName, Technicians.Name as tName, Incidents.DateOpened, Incidents.DateClosed, Incidents.Title FROM Incidents INNER JOIN Technicians ON Incidents.TechID = Technicians.TechID INNER JOIN Products ON Incidents.ProductCode = Products.ProductCode WHERE Incidents.CustomerID = ";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource2.SelectCommand = baseSelect + "0";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource2.SelectCommand = baseSelect + DropDownList1.SelectedValue + ";";
        }
    }
}