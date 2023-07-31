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
    public partial class LoginAdminstrator : Form
    {
        dsRentApplianceSystemTableAdapters.CustomerTableAdapter cds = new dsRentApplianceSystemTableAdapters.CustomerTableAdapter();
        int failedCount = 1;
        public LoginAdminstrator()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (failedCount > 3)
            {
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
                DataTable dt = new DataTable(); ;
                string Username, Password;
                Username = txtUsername.Text;
                Password = txtPassword.Text;
                cds.CheckCustomer(Username,Password);

              dt = cds.CheckAdmin(Username, Password);

                if (dt.Rows.Count > 0)
                {
                    this.Close();
                    AdminstratorMainPage m = new AdminstratorMainPage();
                    m.Show();
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
