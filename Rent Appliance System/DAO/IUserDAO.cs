using Rent_Appliance_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.DAO
{
    public interface IUserDAO
    {
      bool Create(CustomerModel customer);
       IList<CustomerModel> Reterive();
       string GetMaximunCustomerId();
       bool Update(CustomerModel customer);
    }
}
