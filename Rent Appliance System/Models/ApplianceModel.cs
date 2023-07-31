using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_Appliance_System.Models
{
    public class ApplianceModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string PowerUsage { get; set; }

        public string TypicalUsage { get; set; }
        public int EstimatedMonthlyCost { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }

        public string Dimension { get; set; }
        public string Colour { get; set; }
        public int EngeryConsuption { get; set; }
        public decimal MonthlyFee { get; set; }

        public string BrandId { get; set; }
        public string ApplianceTypeId { get; set; }
        public bool IsRent { get; set; }

    }
}
