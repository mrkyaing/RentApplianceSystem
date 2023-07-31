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
    public partial class CustomerRegisterForm : Form
    {
        private IUserDAO userDAO;
        dsRentApplianceSystemTableAdapters.CustomerTableAdapter cds = new dsRentApplianceSystemTableAdapters.CustomerTableAdapter();
        public CustomerRegisterForm()
        {
            InitializeComponent();
            userDAO = new UserService();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
            CustomerModel customer = new CustomerModel();
            customer.CustomerId = txtCustomerID.Text;
            customer.UserName = txtUserName.Text;
            customer.Password = txtPassword.Text;
            customer.CustomerName = txtCustomerName.Text;
            customer.PhoneNumber = txtPhoneNumber.Text;
            customer.CustomerNRC = txtNRC.Text;
            customer.CustomerEmail = txtCustomerEmail.Text;
            customer.CustomerAddress = txtCustomerAddress.Text;
            customer.CustomerProfile = ofdCustomerProfile.FileName;
            if(string.IsNullOrEmpty(txtUserName.Text)){
            MessageBox.Show("Please fill up customer name!");
            return;
            }

            var result = userDAO.Create(customer);
           
            if (result)
            {
                this.Close();
                MessageBox.Show("1 customer record is created successfully.Login now!!");
                LoginCustomer m = new LoginCustomer();
                m.Show();
            }
            else
            {
                MessageBox.Show("error when creating new customer");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdCustomerProfile.ShowDialog();
        }

        private void CBTermsAndCondition_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTermsAndCondition.Checked == true)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void AutoID()
        {
            int maxvalue = Convert.ToInt32(userDAO.GetMaximunCustomerId().Substring(1));
            maxvalue++;
            txtCustomerID.Text = "C"+maxvalue;
        }

        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            AutoID();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }                     
                
    }
}
