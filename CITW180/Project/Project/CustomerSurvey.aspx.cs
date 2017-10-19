using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class CustomerSurvey : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetFocus(idText);
            incidentsBox.Items.Add("None");
        }

        protected void idButton_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(idText.Text.ToString(), out a))
            {
                errorMessage.Text = "";
                incidentsBox.Items.Clear();
                incidentsBox.Items.Add("None");
                ArrayList incidentList = (ArrayList)Session["incidents"];
                SqlDataSource1.DataSourceMode = SqlDataSourceMode.DataSet;
                Customer c = new Customer();
                DataView incidentsTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                incidentsTable.RowFilter = string.Format("CustomerID = '{0}'", idText.Text);
                if (incidentsTable.Count > 0)
                {
                    incidentsBox.Enabled = true;
                    surveyTable.Enabled = true;
                    contactMe.Enabled = true;
                    SubmitSurvey.Enabled = true;
                    for (int i = 0; i < incidentsTable.Count; i++)
                    {
                        String item = "";
                        item += incidentsTable[i].Row["Title"] + "-" + incidentsTable[i].Row["DateClosed"].ToString() + "-" + incidentsTable[i].Row["Description"].ToString();
                        incidentsBox.Items.Add(item);
                    }
                }
            }
            else
            {
                errorMessage.Text = "Please enter a numeric customer ID.";
            }
        }

        protected void SubmitSurvey_Click(object sender, EventArgs e)
        {
            Session["contact"] = "";
            if (contactMe.Checked == true)
            {
                if(emailContact.Checked == true)
                {
                    Session["contact"] = "email";
                }
                else if(phoneContact.Checked == true)
                {
                    Session["contact"] = "phone";
                }
            }
            Response.Redirect("SurveyComplete.aspx");
        }

        protected void contactMe_CheckedChanged(object sender, EventArgs e)
        {
            emailContact.Enabled = true;
            emailContact.Checked = true;
            phoneContact.Enabled = true;
            errorMessage.Text = "checked changed";
        }
    }
}