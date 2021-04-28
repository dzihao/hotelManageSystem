using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace hotelManageSystem
{
    //用枚举判断用户操作是新建还是编辑
    enum operation
    {
        insert,   
        update,   
    }
    public partial class Land : Form
    {
        private string connStr = "Data Source=localhost;Initial Catalog=hotelManage;User ID=sa;Password=123456";
        //定义变量存储获取到的员工编号和密码文本框的值
        public string empId
        {
            get
            {
                return txtEmp.Text.Trim();
            }
        }
        public string passWord
        {
            get
            {
                return txtPassWord.Text.Trim();
            }
        }
        public Land()
        {
            InitializeComponent();
        }
        //更新密码
        private void updatePwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            //查找员工编号是否存在以及密码是否为默认密码
            var originalResult = from r in db.Password
                         where empId == r.emp_id && passWord == r.emp_originalpassword
                         select new { isHave = true };
            //查找密码是否为新密码
            var updateResult = from r in db.Password
                         where empId == r.emp_id && passWord == r.emp_updatepassword
                         select new { isHave = true };
            if (empId == "")
            {
                MessageBox.Show("员工编号不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passWord == "")
            {
                MessageBox.Show("密码不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                //如果查询到原始密码或更新后密码
                if (originalResult.Count() > 0 || updateResult.Count() > 0)
                {
                    UpdatePassword update = new UpdatePassword();
                    update.Owner = this;
                    update.Show();
                    update.txtId.Text = txtEmp.Text;
                    update.txtOriginalPassword.Text = txtPassWord.Text;
                    update.txtId.Enabled = false;
                    update.txtOriginalPassword.Enabled = false;
                    txtPassWord.Clear();
                }
                else
                {
                    MessageBox.Show("密码错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassWord.Clear();
                }
            }
        }
        //点击登录按钮
        public void btnLand_Click(object sender, EventArgs e)
        {
            if (empId == "")
            {
                MessageBox.Show("员工编号不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (passWord == "")
            {
                MessageBox.Show("密码不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            var originalResult = from r in db.Password
                                 where empId == r.emp_id && passWord == r.emp_originalpassword
                                 select new { isHave = true };
            var updateResult = from r in db.Password
                               where empId == r.emp_id && passWord == r.emp_updatepassword
                               select new { isHave = true };
            DialogResult di;
            if (originalResult.Count() > 0)
            {
                MessageBox.Show("请先修改密码", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else 
            {
                if (updateResult.Count() > 0)
                {
                    di = MessageBox.Show("员工;" + txtEmp.Text + "登陆成功", "登陆成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Index index = new Index();
                    index.Owner = this;
                    index.Show();
                }
                else
                {
                    di = MessageBox.Show("密码错误!","密码错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //以下为当用户点击密码文本框时，判断员工编号是否存在
        private void txtPassWord_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            //从数据库中查找是否存在该员工编号
            var result = from s in db.Password
                         where s.emp_id.Equals(empId)
                         select new { isHave = true };
            if (result.Count()> 0 )
            {
                
            }
            else
            {
                //未查询到该员工编号
                MessageBox.Show("员工编号错误,请重新输入！", "员工编号错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmp.Clear();
            }
        }

    }
}
