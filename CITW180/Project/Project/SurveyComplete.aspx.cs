using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class SurveyComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["contact"] == null)
            {
                Session["contact"] = "";
            }
            if (Session["contact"].ToString().Length > 0)
            {
                surveyLbl.Text = "We will contact you by " + Session["contact"].ToString() + " within 24 hours.";
            }
            else
            {
                surveyLbl.Text = "Your feedback ensures that we give the best possible customer service.";
            }
        }

        protected void return_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerSurvey");
        }
    }
}