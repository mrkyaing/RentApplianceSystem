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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminstrator_Click(object sender, EventArgs e)
        {
            ActiveForm.Visible = false;
            LoginAdminstrator al=new LoginAdminstrator();
            al.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActiveForm.Visible = false;
            LoginCustomer al = new LoginCustomer();
            al.Show();
        }
    }
}
