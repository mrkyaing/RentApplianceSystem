using Rent_Appliance_System.DAO;
using Rent_Appliance_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_Appliance_System
{
    public partial class ApplianceTypeForm : Form
    {
        private IApplianceTypeDAO iapplianceTypeDAO;
        public ApplianceTypeForm()
        {
            InitializeComponent();
            iapplianceTypeDAO = new ApplianceTypeService();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplianceTypeModel brand = new ApplianceTypeModel();
            brand.Id = txtBrandID.Text;
            brand.Name = txtBrandName.Text;
            if (iapplianceTypeDAO.Create(brand))
            {
                MessageBox.Show("1 record is created successfully.");
            }
            else
            {
                MessageBox.Show("error occur when 1 record is created.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBrandID.Clear();
            txtBrandName.Clear();
        }
    }
}
