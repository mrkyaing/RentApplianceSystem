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
    public partial class LoginCustomer : Form
    { 

        dsRentApplianceSystemTableAdapters.CustomerTableAdapter cds = new dsRentApplianceSystemTableAdapters.CustomerTableAdapter();
        int failedCount = 1;
        public LoginCustomer()
        {
            InitializeComponent();
        }

        private void LoginCustomer_Load(object sender, EventArgs e)
        {
            btnHide.Visible = true;
            txtPassword.PasswordChar = '*';
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void lnkCustomerRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActiveForm.Visible = false;
            CustomerRegisterForm c = new CustomerRegisterForm();
            c.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (failedCount > 3) {
                MessageBox.Show("Failed For Over Three Times");
                this.Close();
                MainPage cmp = new MainPage();
                cmp.Show();
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username");
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                txtPassword.Focus();
            }
            else
            {
                DataTable dt = new DataTable();;
                string Username, Password;
                Username = txtUsername.Text;
                Password = txtPassword.Text;
                //cds.CheckCustomer(Username,Password);

                dt = cds.CheckCustomer(Username, Password);

                if (dt.Rows.Count > 0)
                {
                    this.Close();
                    CustomerMainPage cmp = new CustomerMainPage();
                    cmp.Show();
                }
                else
                {
                    MessageBox.Show(failedCount + "Invalid Login");
                    failedCount++;
                }

            }

        }

      
    }
}
