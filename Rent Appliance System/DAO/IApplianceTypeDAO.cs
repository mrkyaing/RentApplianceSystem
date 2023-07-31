using Rent_Appliance_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.DAO
{
   public interface IApplianceTypeDAO
    {
       bool Create(ApplianceTypeModel applianceType);
       IList<ApplianceTypeModel> Reterive();
    }
}
