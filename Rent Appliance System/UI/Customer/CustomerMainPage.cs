using Rent_Appliance_System.DAO;
using Rent_Appliance_System.Models;
using Rent_Appliance_System.UI.Customer;
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
    public partial class CustomerMainPage : Form
    {
        private IApplianceDAO applianceDao;
        public CustomerMainPage()
        {
            InitializeComponent();
            applianceDao = new ApplicanceService();
        }

           

        private void CustomerMainPage_Load(object sender, EventArgs e)
        {
            dataGridViewAppliance.DataSource = applianceDao.Reterive().ToList();
        }

        private void txtYourRentItem_Click(object sender, EventArgs e)
        {

        }

        private void cbSortin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IList<ApplianceModel> data = applianceDao.Reterive().Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower())
               || x.Code.ToLower().Contains(txtSearch.Text.ToLower())
               || x.Colour.ToLower().Contains(txtSearch.Text.ToLower())
               || x.PowerUsage.ToLower().Contains(txtSearch.Text.ToLower())
               || x.TypicalUsage.ToLower().Contains(txtSearch.Text.ToLower())
               || x.Model.ToLower().Contains(txtSearch.Text.ToLower())
               || x.Description.ToLower().Contains(txtSearch.Text.ToLower())
               ).ToList();
            if (data.Count > 0)
                dataGridViewAppliance.DataSource = data;
            else { MessageBox.Show("There is no record your search value");
            applianceDao.Reterive().ToList();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text="Type Search Values";
            dataGridViewAppliance.DataSource = applianceDao.Reterive().ToList();
        }

        private void dataGridViewAppliance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ApplianceModel applianceModel = (ApplianceModel)dataGridViewAppliance.CurrentRow.DataBoundItem;
                RentPeroidForm rentPeroidUi = new RentPeroidForm();
                rentPeroidUi.appliance = applianceModel;
                rentPeroidUi.Show();
            }
        }

    }
}
