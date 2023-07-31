using Rent_Appliance_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.DAO
{
  public  class ApplicanceService:IApplianceDAO
    {
        public bool Create(ApplianceModel appliance)
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "insert into Appliance values(@Code,@Name,@PowerUsage,@TypicalUsage,@EstimatedMonthlyCost,@Description,@Model,@Dimension,@Colour,@EngeryConsuption,@MonthlyFee,@BrandId,@ApplianceTypeId,@IsRent);";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Code", appliance.Code);
            command.Parameters.AddWithValue("@Name", appliance.Name);
            command.Parameters.AddWithValue("@PowerUsage", appliance.PowerUsage);
            command.Parameters.AddWithValue("@TypicalUsage", appliance.TypicalUsage);
            command.Parameters.AddWithValue("@EstimatedMonthlyCost", appliance.EstimatedMonthlyCost);
            command.Parameters.AddWithValue("@Description", appliance.Description);
            command.Parameters.AddWithValue("@Model", appliance.Model);
            command.Parameters.AddWithValue("@Dimension", appliance.Dimension);
            command.Parameters.AddWithValue("@Colour", appliance.Colour);
            command.Parameters.AddWithValue("@EngeryConsuption", appliance.EngeryConsuption);
            command.Parameters.AddWithValue("@MonthlyFee", appliance.MonthlyFee);
            command.Parameters.AddWithValue("@BrandId", appliance.BrandId);
            command.Parameters.AddWithValue("@ApplianceTypeId", appliance.ApplianceTypeId);
            command.Parameters.AddWithValue("@IsRent", 0);
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return true;
            return false;
        }

        public IList<ApplianceModel> Reterive()
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "select * from Appliance";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<ApplianceModel> appliances = new List<ApplianceModel>();
            while (reader.Read())
            {
                ApplianceModel appliance = new ApplianceModel();
                appliance.Code = reader["Code"].ToString();
                appliance.Name = reader["Name"].ToString();
                appliance.PowerUsage = reader["PowerUsage"].ToString();
                appliance.TypicalUsage = reader["TypicalUsage"].ToString();
                appliance.EstimatedMonthlyCost =Convert.ToInt32( reader["EstimatedMonthlyCost"]);
                appliance.Description = reader["Description"].ToString();
                appliance.Model = reader["Model"].ToString();
                appliance.Dimension = reader["Dinmension"].ToString();
                appliance.Colour = reader["Colour"].ToString();
                appliance.EngeryConsuption = Convert.ToInt32(reader["EngeryConsuption"]);
                appliance.MonthlyFee = Convert.ToInt32(reader["MonthlyFee"]);
                appliance.BrandId = reader["BrandId"].ToString();
                appliance.IsRent =Convert.ToBoolean( reader["IsRent"].ToString());
                appliance.ApplianceTypeId = reader["ApplianceTypeId"].ToString();
                appliances.Add(appliance);
            }
            return appliances;
        }


        public bool Update(ApplianceModel appliance)
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "Update Appliance set IsRent=1 where Code=@Code";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Code", appliance.Code);           
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return true;
            return false;
        }
    }
}
