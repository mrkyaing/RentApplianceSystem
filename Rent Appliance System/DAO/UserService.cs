using Rent_Appliance_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.DAO
{
    public class UserService : IUserDAO
    {           

        public bool Create(CustomerModel customer)
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "insert into Customer values(@CustomerId,@CustomerName,@UserName,@Password,@PhoneNumber,@CustomerNRC,@CustomerEmail,@CustomerAddress,@CustomerProfile,@isAdmin);";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
            command.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
            command.Parameters.AddWithValue("@UserName", customer.UserName);
            command.Parameters.AddWithValue("@Password", customer.Password);        
            command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
            command.Parameters.AddWithValue("@CustomerNRC", customer.CustomerNRC);
            command.Parameters.AddWithValue("@CustomerEmail", customer.CustomerEmail);
            command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
            command.Parameters.AddWithValue("@CustomerProfile", "NOTHING");
            command.Parameters.AddWithValue("@isAdmin", 0);
            int result = command.ExecuteNonQuery();
            if (result > 0)
                return true;
            return false;
        }

     public   IList<CustomerModel> Reterive()
        {
            SqlConnection connection = DatabaseConnectionHelper.GetConnection();
            string sql = "select * from Customer where IsAdmin=1";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CustomerModel> users = new List<CustomerModel>();
            while (reader.Read())
            {
                CustomerModel user = new CustomerModel();
                user.CustomerId = reader["CustomerId"].ToString();
                user.UserName = reader["UserName"].ToString();
                user.CustomerName = reader["CustomerName"].ToString();
                user.Password = reader["Password"].ToString();
                user.PhoneNumber = reader["PhoneNumber"].ToString();
                user.CustomerNRC = reader["CustomerNRC"].ToString();
                user.CustomerEmail = reader["CustomerEmail"].ToString();
                user.CustomerAddress = reader["CustomerAddress"].ToString();
                user.CustomerProfile = reader["CustomerProfile"].ToString();
                users.Add(user);
            }
            return users;
        }


     public string GetMaximunCustomerId()
     {
         SqlConnection connection = DatabaseConnectionHelper.GetConnection();
         string sql = "select max(customerId) as customerId from Customer where isAdmin=0;";
         SqlCommand cmd = new SqlCommand(sql, connection);
         SqlDataReader reader = cmd.ExecuteReader();
         string customerId = null;
         while (reader.Read())
         {
             customerId = reader["CustomerId"].ToString();
         }
         return customerId;
     }


     public bool Update(CustomerModel customer)
     {
         SqlConnection connection = DatabaseConnectionHelper.GetConnection();
         string sql = "Update Customer SET CustomerName=@CustomerName,UserName=@UserName,Password=@Password,PhoneNumber=@PhoneNumber,CustomerAddress=@CustomerAddress where customerId=@CustomerId;";
         SqlCommand command = new SqlCommand(sql, connection);
         command.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
         command.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
         command.Parameters.AddWithValue("@UserName", customer.UserName);
         command.Parameters.AddWithValue("@Password", customer.Password);
         command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);       
         command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
         int result = command.ExecuteNonQuery();
         if (result > 0)
             return true;
         return false;
     }
    }
}
