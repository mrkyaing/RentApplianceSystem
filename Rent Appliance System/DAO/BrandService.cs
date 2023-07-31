using Rent_Appliance_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.DAO
{
   public class BrandService:IBrandDAO
    {
        public bool Create(BrandModel brand)
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "insert into brand values(@Id,@Name,@Model,@ManifacturedCompany);";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", brand.Id);
                command.Parameters.AddWithValue("@Name", brand.Name);
                command.Parameters.AddWithValue("@Model", brand.Model);
                command.Parameters.AddWithValue("@ManifacturedCompany", brand.ManifacturedCompany);
                int result=command.ExecuteNonQuery();
                if (result > 0) 
                    return true;
            return false;
        }
        public IList<BrandModel> Reterive()
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "select * from Brand";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<BrandModel> brands = new List<BrandModel>();
            while (reader.Read())
            {
                BrandModel brand = new BrandModel();
                brand.Id = reader["Id"].ToString();
                brand.Name = reader["Name"].ToString();
                brand.Model = reader["Model"].ToString();
                brand.ManifacturedCompany = reader["ManifacturedCompany"].ToString();
                brands.Add(brand);
            }
            return brands;
        }
    }
}
