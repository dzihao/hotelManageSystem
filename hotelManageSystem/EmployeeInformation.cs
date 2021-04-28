using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace hotelManageSystem
{
    public partial class EmployeeInformation : Form
    {
        //用来判别用户操作
        private operation op;
        //连接数据库
        string connStr = "Data Source=localhost;Initial Catalog=hotelManage;Persist Security Info=True;User ID=sa;Password=123456";
        public EmployeeInformation()
        {
            InitializeComponent();
        }
        public void BindInfo()
        {
            //依据查询类别从数据库查找相应内容
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            switch (tsbWhat.Text)
            {
                case "":
                    var result = from e in db.Employeeinformation
                                 select e;
                    dgvEmployee.DataSource = result;
                    break;
                case "员工编号":
                    var result1 = from e in db.Employeeinformation
                                 where e.emp_id == txtValue.Text
                                 select e;
                    dgvEmployee.DataSource = result1;
                    break;
                case "姓名":
                    var result2 = from e in db.Employeeinformation
                                 where e.emp_name == txtValue.Text
                                 select e;
                    dgvEmployee.DataSource = result2;
                    break;
            }
        }
        //点击查询按钮
        private void tsbSelect_Click(object sender, EventArgs e)
        {
            BindInfo();
        }
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            op = operation.update;
        }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            op = operation.insert;
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            //用户点击新建按钮
            if (op == operation.insert)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                Employeeinformation em = new Employeeinformation();
                em.emp_id = txtId.Text;
                em.emp_name = txtName.Text;
                em.emp_sex = txtSex.Text;
                em.emp_phone = txtPhone.Text;
                em.emp_age =Convert.ToInt32(txtAge.Text);
                em.emp_position = txtPosition.Text;
                em.emp_address = txtAddress.Text;
                db.Employeeinformation.InsertOnSubmit(em);
                db.SubmitChanges();
                MessageBox.Show("员工数据添加成功", "添加记录",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                BindInfo();
            }
            //用户点击编辑按钮
            else if (op == operation.update)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                Employeeinformation em = new Employeeinformation();
                var result = from emp in db.Employeeinformation
                             where emp.emp_id == txtId.Text
                             select emp;
                foreach (Employeeinformation emp in result)
                {
                    emp.emp_id = txtId.Text;
                    emp.emp_name = txtName.Text;
                    emp.emp_sex = txtSex.Text;
                    emp.emp_phone = txtPhone.Text;
                    emp.emp_age = Convert.ToInt32(txtAge.Text);
                    emp.emp_position = txtPosition.Text;
                    emp.emp_address = txtAddress.Text;
                    db.SubmitChanges();
                    MessageBox.Show("数据修改成功", "修改记录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    BindInfo();
                }
            }
        }
        private void txtId_Click(object sender, EventArgs e)
        {
            if (op == operation.update)
            {
                txtId.Enabled = false;
                MessageBox.Show("该状态下员工编号不可修改！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //将查询得到的内容与窗体数据区域对应起来
            txtId.Text= Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[0].Value);
            txtName.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[1].Value);
            txtSex.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[2].Value);
            txtPhone.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[3].Value);
            txtAge.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[4].Value);
            txtPosition.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[5].Value);
            txtAddress.Text=Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[6].Value);
        }
        //点击删除按钮
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            var result = from p in db.Employeeinformation
                         where txtId.Text == p.emp_id
                         select p;
            db.Employeeinformation.DeleteAllOnSubmit(result);
            db.SubmitChanges();
            MessageBox.Show("该记录已删除", "删除记录",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            BindInfo();
        }

        private void tsbReserve_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
