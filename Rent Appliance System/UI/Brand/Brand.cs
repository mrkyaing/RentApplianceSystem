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
    public partial class Brand : Form
    {
        private IBrandDAO ibrandDAO;
        public Brand()
        {
            InitializeComponent();
            ibrandDAO = new BrandService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BrandModel brand = new BrandModel();
            brand.Id = txtBrandID.Text;
            brand.Name = txtBrandName.Text;
            brand.Model = txtBrandModel.Text;
            brand.ManifacturedCompany = txtManifacturedCompany.Text;
            if (ibrandDAO.Create(brand))
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
            txtBrandModel.Clear();
            txtManifacturedCompany.Clear();
        }
    }
}
