using Rent_Appliance_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.DAO
{
    public class ApplianceTypeService : IApplianceTypeDAO
    {          

        public bool Create(ApplianceTypeModel applianceType)
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "insert into ApplianceType values(@Id,@Name);";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", applianceType.Id);
            command.Parameters.AddWithValue("@Name", applianceType.Name);
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return true;
            return false;
        }

        IList<ApplianceTypeModel> IApplianceTypeDAO.Reterive()
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "select * from ApplianceType";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<ApplianceTypeModel> applianceTypes = new List<ApplianceTypeModel>();
            while (reader.Read())
            {
                ApplianceTypeModel applianceType = new ApplianceTypeModel();
                applianceType.Id = reader["Id"].ToString();
                applianceType.Name = reader["Name"].ToString();
                applianceTypes.Add(applianceType);
            }
            return applianceTypes;
        }
    }
}
