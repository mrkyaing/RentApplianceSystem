using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rent_Appliance_System.DAO;
using Rent_Appliance_System.Models;

namespace Rent_Appliance_System.UI.Customer
{
    public partial class RentPeroidForm : Form
    {
        public ApplianceModel appliance { get; set; }
        
        private IApplianceDAO applianceDao;
        public RentPeroidForm()
        {
            InitializeComponent();
            applianceDao = new ApplicanceService();
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (btnRent.Text.Equals("Calculate"))
            {
                appliance.MonthlyFee = Convert.ToInt32(txtRentMonthPeroid.Text) * appliance.MonthlyFee;
                txtTotal.Text = appliance.MonthlyFee.ToString();
                btnRent.Text = "Rent";
            }
            else
            {
                if (applianceDao.Update(appliance))
                {
                    MessageBox.Show("This appliance was successfull rent .");
                }
            }
        }
    }
}
