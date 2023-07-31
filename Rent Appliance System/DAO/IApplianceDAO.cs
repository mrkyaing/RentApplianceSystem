using Rent_Appliance_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.DAO
{
    public interface IApplianceDAO
    {
      bool Create(ApplianceModel appliance);
      IList<ApplianceModel> Reterive();
      bool Update(ApplianceModel appliance);
    }
}
