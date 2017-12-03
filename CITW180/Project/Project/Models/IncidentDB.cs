using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;

namespace Project
{
    [DataObject(true)]
    public class IncidentDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static IEnumerable GetOpenTechIncidents(int techID)
        {
            int ID = techID;
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT DateOpened, Products.Name as Product, Customers.Name as Customer " +
                "From Incidents " +
                "INNER JOIN Products on Incidents.ProductCode = Products.ProductCode " +
                "INNER JOIN Customers on Incidents.CustomerID = Customers.CustomerID " +
                "WHERE TechID = CAST('" + ID + "' AS int) " +
                "AND DateClosed IS NULL " +
                "ORDER BY DateOpened;";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
    }
}