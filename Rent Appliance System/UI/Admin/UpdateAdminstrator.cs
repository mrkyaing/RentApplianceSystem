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
    public partial class UpdateAdminstrator : Form
    {
        public string CustomerId { get; set; }
        private IUserDAO userDAO;
        public UpdateAdminstrator()
        {
            InitializeComponent();
            userDAO = new UserService();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CustomerModel customer = new CustomerModel();
            customer.CustomerId = CustomerId;
            customer.UserName = txtUserName.Text;
            customer.Password = txtPassword.Text;
            customer.CustomerName =txtAdminName.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;
            customer.CustomerAddress = txtAddress.Text;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please fill up customer name!");
                return;
            }

            var result = userDAO.Update(customer);

            if (result)
            {
                MessageBox.Show("record is updated successfully.");
            }
            else
            {
                MessageBox.Show("error when updating admin info");
            }
        }

        private void UpdateAdminstrator_Load(object sender, EventArgs e)
        {
            var customer = userDAO.Reterive().SingleOrDefault();
            CustomerId = customer.CustomerId;
            txtAdminName.Text = customer.CustomerName;
            txtUserName.Text = customer.UserName;
            txtAddress.Text = customer.CustomerAddress;
            txtPassword.Text = customer.Password;
            txtPhoneNumber.Text = customer.PhoneNumber;
        }
    }
}
