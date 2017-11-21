using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class ProductMaintenance : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //float test = float.Parse(GridView1.Rows[0].Cells[2].Text);
                
            
            if (!Page.IsPostBack)
            {
                Update();
            }
            //Bind data to the GridView control.
            
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {

            if (ValidateData())
            {
                SqlDataSource1.InsertCommand = string.Format("INSERT INTO [Products] VALUES ('{0}', '{1}', {2}, {3});", productCode.Text, name.Text, version.Text, date.Text);
                SqlDataSource1.Insert();
                Update();
                version.Text = "";
                name.Text = "";
                productCode.Text = "";
                date.Text = "";
            }
            else
            {
                ErrorLabel.Text = "Please fill out all forms and ensure that the Product Code is not already in use.";
            }
        }

        protected void date_TextChanged(object sender, EventArgs e)
        {
            
        }
        protected void Update()
        {
            DataView view = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            DataTable table = view.ToTable();
            Session["TaskTable"] = table;
            BindData();
        }
        bool ValidateData()
        {
            decimal dec;
            DateTime dt;
            if (productCode.Text!= null)
            {
                for(int i = 0; i < GridView1.Rows.Count; i++)
                {
                    if(GridView1.Rows[i].Cells[01].Text==productCode.Text)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            if (name.Text == null)
                return false;
            if (!DateTime.TryParse(date.Text, out dt))
                return false;
            if (!decimal.TryParse(version.Text, out dec))
                return false;
            return true;
        }
       
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            /*GridView1.EditIndex = e.NewEditIndex;
            GVBind();*/
            
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
            ErrorLabel.Text = "Name: " + GridView1.Rows[0].Cells[1].Text;
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //GridView1.DataBind();
            DataTable dt = (DataTable)Session["TaskTable"];
            GridViewRow row = GridView1.Rows[e.RowIndex];
            // GridView1.DataSource = dt;

            string code = e.Keys[0].ToString();
            string name = e.NewValues[0].ToString();
            string version = e.NewValues[1].ToString();
            string date = e.NewValues[2].ToString();

            SqlDataSource1.UpdateCommand = "Update Products Set Name='" + name + "', Version=CAST('" + version + "' as DECIMAL(18,1)), ReleaseDate='" + date + "' Where ProductCode = '" + code + "';";
            SqlDataSource1.Update();
            GridView1.EditIndex = -1;
            Update();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void BindData()
        {
            GridView1.DataSource = Session["TaskTable"];
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = (DataTable)Session["TaskTable"];
            SqlDataSource1.DeleteCommand = "DELETE from Products where ProductCode = '" + e.Keys[0]+"';";
            SqlDataSource1.Delete();
            DataView view = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            dt = view.ToTable();
            Session["TaskTable"] = dt;
            BindData();
        }
    }
}