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
    public class TechnicianDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static IEnumerable GetAllTechnicians()
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT TechID, Name " +
                "FROM Technicians ORDER BY Name";
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