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
    public partial class ApplianceRegister : Form
    {
        private IApplianceDAO iApplicanceDAO;
        private IBrandDAO ibrandDAO;
        private IApplianceTypeDAO IApplianceTypeDAO;
        public ApplianceRegister()
        {
            InitializeComponent();
            iApplicanceDAO = new ApplicanceService();
            ibrandDAO = new BrandService();
            IApplianceTypeDAO = new ApplianceTypeService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplianceModel appliance = new ApplianceModel();
            appliance.Code = txtApplianceCode.Text;
            appliance.Name = txtApplianceName.Text;   
            appliance.PowerUsage = txtPowerUsage.Text;

            appliance.TypicalUsage = txtTypicalUage.Text;
            appliance.EstimatedMonthlyCost =Convert.ToInt32( txtEstimatedAnnualCost.Text);
            appliance.Description = txtDescription.Text;
            appliance.Model = txtModel.Text;
            appliance.Dimension = txtDimension.Text;
           

            appliance.Colour = txtColour.Text;
            appliance.EngeryConsuption = Convert.ToInt32(txtEnergyConsumption.Text);
            appliance.MonthlyFee = Convert.ToInt32(txtMonthlyFee.Text);
            appliance.BrandId = cboBrand.SelectedValue.ToString();
            appliance.ApplianceTypeId = cboApplianceTypeName.SelectedValue.ToString();
            if (iApplicanceDAO.Create(appliance))
            {
                MessageBox.Show("1 record is created successfully.");
            }
            else
            {
                MessageBox.Show("error occur when 1 record is created.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplianceRegister_Load(object sender, EventArgs e)
        {
            cboBrand.ValueMember = "Id";
            cboBrand.DisplayMember = "Name";
            cboBrand.DataSource = ibrandDAO.Reterive();

            cboApplianceTypeName.ValueMember = "Id";
            cboApplianceTypeName.DisplayMember = "Name";
            cboApplianceTypeName.DataSource = IApplianceTypeDAO.Reterive();
        }
    }
}
