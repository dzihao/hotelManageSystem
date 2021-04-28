using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace hotelManageSystem
{
    public partial class salary : Form
    {
        private operation op;
        string connStr = "Data Source=localhost;Initial Catalog=hotelManage;Persist Security Info=True;User ID=sa;Password=123456";
        public salary()
        {
            InitializeComponent();
        }
        public void BindInfo()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            switch (tsbWhat.Text)
            {
                case "":
                    var result = from s in db.Salary
                                 select s;
                    dgvSalary.DataSource = result;
                    break;
                case "员工编号":
                    var result1 = from s in db.Salary
                                 where s.emp_id == txtValue.Text
                                 select s;
                    dgvSalary.DataSource = result1;
                    break;
                case "姓名":
                    var result3 = from s in db.Salary
                                 where s.emp_name == txtValue.Text
                                 select s;
                    dgvSalary.DataSource = result3;
                    break;

            }
        }
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
            if (op == operation.insert)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                Salary sa = new Salary();
                sa.emp_id = txtId.Text;
                sa.emp_name = txtName.Text;
                sa.basesalary = Convert.ToSingle(txtBase.Text);
                sa.overwork = Convert.ToSingle(txtOverWork.Text);
                sa.extra =Convert.ToSingle(txtExtra.Text) ;
                sa.remark = txtRemark.Text;
                sa.allsalary = Convert.ToSingle(txtAllSalary.Text); ;
                db.Salary.InsertOnSubmit(sa);
                db.SubmitChanges();
                MessageBox.Show("数据添加成功", "添加记录",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                BindInfo();
            }
            else if (op == operation.update)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                Salary sa = new Salary();
                var result = from s in db.Salary
                             where s.emp_id == txtId.Text
                             select s;
                foreach (Salary s in result)
                {
                    s.emp_id = txtId.Text;
                    s.emp_name = txtName.Text;
                    s.basesalary = Convert.ToSingle(txtBase.Text);
                    s.overwork = Convert.ToSingle(txtOverWork.Text);
                    s.extra = Convert.ToSingle(txtExtra.Text);
                    s.remark = txtRemark.Text;
                    s.allsalary = Convert.ToSingle(txtAllSalary.Text);
                    db.SubmitChanges();
                    MessageBox.Show("数据修改成功", "修改记录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    BindInfo();
                }
            }
        }
        private void txtID_Click(object sender, EventArgs e)
        {
            if (op == operation.update)
            {
                txtId.Enabled = false;
                MessageBox.Show("该状态下员工编号不可修改！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void dgvSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dgvSalary.Rows[e.RowIndex].Cells[0].Value);
            txtName.Text = Convert.ToString(dgvSalary.Rows[e.RowIndex].Cells[1].Value);
            txtBase.Text = Convert.ToString(dgvSalary.Rows[e.RowIndex].Cells[2].Value);
            txtOverWork.Text = Convert.ToString(dgvSalary.Rows[e.RowIndex].Cells[3].Value);
            txtExtra.Text = Convert.ToString(dgvSalary.Rows[e.RowIndex].Cells[4].Value);
            txtRemark.Text = Convert.ToString(dgvSalary.Rows[e.RowIndex].Cells[5].Value);
            txtAllSalary.Text= Convert.ToString(dgvSalary.Rows[e.RowIndex].Cells[6].Value);
        }
        private void tsbReserve_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            var result = from p in db.Salary
                         where txtId.Text == p.emp_id
                         select p;
            db.Salary.DeleteAllOnSubmit(result);
            db.SubmitChanges();
            MessageBox.Show("该记录已删除", "删除记录",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            BindInfo();
        }
        private void txtAllSalary_Click(object sender, EventArgs e)
        {
            txtAllSalary.Text = Convert.ToString(Convert.ToSingle(txtBase.Text) +Convert.ToSingle(txtOverWork.Text) +Convert.ToSingle(txtExtra.Text));
        }
    }
}
