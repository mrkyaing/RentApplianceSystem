using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.DAO
{
   public class DatabaseConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"server=LAPTOP-N9P94CAP;initial catalog=ApplianceDB;user id=sa;password=sasa";
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception ex)
            {
                throw new Exception("error occur when connect to databae ");
            }
        }
    }
}
