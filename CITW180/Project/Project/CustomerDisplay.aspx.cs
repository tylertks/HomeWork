using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace Project
{
    public partial class CustomerDisplay : System.Web.UI.Page
    {
        int changed = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateTable();
        }
        public void PopulateTable()
        {
            SqlDataSource.DataSourceMode = SqlDataSourceMode.DataSet;
            Customer c = new Customer();
            DataView customersTable = (DataView)SqlDataSource.Select(DataSourceSelectArguments.Empty);
            try {
                if(DropDown1.SelectedValue.Length <= 0)
                {
                    DropDown1.SelectedIndex = 0;
                    customersTable.RowFilter = "Name = 'Ania Irvin'";
                }
                else { 
                    customersTable.RowFilter = "Name = '" + DropDown1.SelectedValue + "'";
                }
                DataRowView row = customersTable[0];
                customerName.Text = row["Name"].ToString();
                customerAddress.Text = row["Address"].ToString() + " " + row["City"].ToString() + ", " + row["State"].ToString() + " "+row["zipcode"].ToString();
                customerPhone.Text = row["Phone"].ToString();
                customerEmail.Text = row["Email"].ToString();
            }
            catch(Exception e)
            {

            }
        }

        protected void DropDown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTable();
        }

        protected void addCustomer_Click(object sender, EventArgs e)
        {
            ArrayList customersList = (ArrayList)Session["customersList"];
            if(customersList == null)
            {
                customersList = new ArrayList();
            }

            SqlDataSource.DataSourceMode = SqlDataSourceMode.DataSet;
            DataView customersTable = (DataView)SqlDataSource.Select(DataSourceSelectArguments.Empty);
            DataRowView row = customersTable[0];

            Customer c = new Customer();
            c.name = DropDown1.SelectedValue.ToString();
            c.address = row["address"].ToString();
            c.city = row["city"].ToString();
            c.state = row["state"].ToString();
            if(int.TryParse(row["zipcode"].ToString(), out c.zipcode)) { }
            c.email = row["email"].ToString();
            c.phone = row["phone"].ToString();

            customersList.Add(c);

            Session["customersList"] = customersList;
        }

        protected void showList_Click(object sender, EventArgs e)
        {
            string s = "";
            ArrayList customerList = (ArrayList)Session["customersList"];
            foreach(Customer c in customerList)
            {
                s += c.name + "\n";
            }
            testLabel.Text = s;
            Response.Redirect("CustomerList.aspx");
        }
    }
    
}
