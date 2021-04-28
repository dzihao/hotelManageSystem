using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace hotelManageSystem
{
    public partial class UpdatePassword : Form
    {
        private operation op;
        string connStr = "Data Source=localhost;Initial Catalog=hotelManage;Persist Security Info=True;User ID=sa;Password=123456";
        public UpdatePassword()
        {
            InitializeComponent();
        }
        //当用户点击确认修改按钮
        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            string user = txtId.Text.Trim();
            if (txtConfirmPassword.Text.Trim() == txtNewPassword.Text.Trim())
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                var result = from c in db.Password
                             where c.emp_id == txtId.Text
                             select c;
                foreach (Password c in result)
                {
                    c.emp_updatepassword = txtConfirmPassword.Text;
                    db.SubmitChanges();
                    MessageBox.Show("密码修改成功", "修改密码",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Close();
                    MessageBox.Show("请输入修改后的密码","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            else if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                MessageBox.Show("密码不一致", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNewPassword_Click(object sender, EventArgs e)
        {
            op = operation.update;
        }
    }
}
