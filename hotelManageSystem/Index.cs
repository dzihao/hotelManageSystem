using System;
using System.Windows.Forms;

namespace hotelManageSystem
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        private void empSalaryManage(object sender, EventArgs e)
        {
            salary sa = new salary();
            sa.Owner = this;
            sa.Show();
        }
        private void exitSystem(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productManageToolMenu(object sender, EventArgs e)
        {
            ProductManage jinhuo = new ProductManage();
            jinhuo.Owner = this;
            jinhuo.Show();
        }
        private void reserveManageTool(object sender, EventArgs e)
        {
            reserve re = new reserve();
            re.Owner = this;
            re.Show();
        }

        private void empManageTool(object sender, EventArgs e)
        {
            EmployeeInformation em = new EmployeeInformation();
            em.Owner = this;
            em.Show();
        }

        private void noReserveManage(object sender, EventArgs e)
        {
            noReserve cr = new noReserve();
            cr.Owner = this;
            cr.Show();
        }

        private void productManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManage jinhuo = new ProductManage();
            jinhuo.Owner = this;
            jinhuo.Show();
        }
    }
}
