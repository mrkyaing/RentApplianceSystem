using Rent_Appliance_System.DAO;
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
    public partial class AdminstratorMainPage : Form
    {
        private IUserDAO userDao;
        private IBrandDAO brandDao;
        private IApplianceTypeDAO applianceTypeDao;
        private IApplianceDAO applianceDao;
        public string WhichBtnClick { get; set; }
        public AdminstratorMainPage()
        {
            InitializeComponent();
            userDao = new UserService();
            brandDao = new BrandService();
            applianceTypeDao = new ApplianceTypeService();
            applianceDao = new ApplicanceService();
        }

        private void btnAdminstrator_Click(object sender, EventArgs e)
        {
            dataGridViewCommon.DataSource = userDao.Reterive();
            gbox.Text = "Admininstrator Information";
            WhichBtnClick = "a";
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            dataGridViewCommon.DataSource = brandDao.Reterive();
            gbox.Text = "Brnad Information";
            WhichBtnClick = "b";
        }

        private void btnApplianceType_Click(object sender, EventArgs e)
        {
            dataGridViewCommon.DataSource = applianceTypeDao.Reterive();
            gbox.Text = "Applyace Type Information";
            WhichBtnClick = "at";
        }

        private void btnAppliance_Click(object sender, EventArgs e)
        {
            dataGridViewCommon.DataSource = applianceDao.Reterive().Where(x => x.IsRent == false).ToList();
            gbox.Text = "Appliance  Information";
            WhichBtnClick = "ae";
        }

        private void btnListofRent_Click(object sender, EventArgs e)
        {
            gbox.Text = "Rent List Information";
            WhichBtnClick = "l";
            dataGridViewCommon.DataSource = applianceDao.Reterive().Where(x=>x.IsRent==true).ToList();
        }

        
        private void AdminstratorMainPage_Load(object sender, EventArgs e)
        {
            dataGridViewCommon.DataSource = userDao.Reterive();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (WhichBtnClick.Equals("a"))
            {
                
            }
            else if (WhichBtnClick.Equals("b"))
            {
                new Brand().Show();
            }
            else if (WhichBtnClick.Equals("at"))
            {
                new ApplianceTypeForm().Show();
            }
            else if (WhichBtnClick.Equals("ae"))
            {
                new ApplianceRegister().Show();
            }
        }

        private void btnAdminupdate_Click(object sender, EventArgs e)
        {
            new UpdateAdminstrator().Show();
        }
                   
        
    }
}
