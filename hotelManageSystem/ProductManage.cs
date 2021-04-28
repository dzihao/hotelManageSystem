using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace hotelManageSystem
{
    public partial class ProductManage : Form
    {
        private operation op;
        string connStr = "Data Source=localhost;Initial Catalog=hotelManage;Persist Security Info=True;User ID=sa;Password=123456";
        public ProductManage()
        {
            InitializeComponent();
        }
        public void BindInfo()
        {
            //依据查询类别特定查找
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            switch (tsbWhat.Text)
            {
                case "":
                    var result = from p in db.Product
                                 select p;
                    dgvJinhuo.DataSource = result;
                    break;
                case "商品编号":
                    var result1 = from p in db.Product
                                 where p.pro_id == txtValue.Text
                                 select p;
                    dgvJinhuo.DataSource = result1;
                    break;
                case "商品名称":
                    var result2 = from p in db.Product
                                 where p.pro_name == txtValue.Text
                                 select p;
                    dgvJinhuo.DataSource = result2;
                    break;
                case "经手人":
                    var result3 = from p in db.Product
                                 where p.pro_handle == txtValue.Text
                                 select p;
                    dgvJinhuo.DataSource = result3;
                    break;
            }
        }
        private void tsbSeleect_Click(object sender, EventArgs e)
        {
            BindInfo();
        }
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            op = operation.update;
        }
        private void txbAdd_Click(object sender, EventArgs e)
        {
            op = operation.insert;
        }
        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (op == operation.insert)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                Product pr = new Product();
                pr.pro_id = txtId.Text;
                pr.pro_name = txtName.Text;
                pr.pro_handle = cbHandle.Text;
                pr.pro_units = cbUnits.Text;
                pr.pro_price = Convert.ToSingle( txtPrice.Text);
                pr.pro_count = Convert.ToSingle( txtCount.Text);
                pr.pro_time = dtTime.Value;
                pr.pro_pay = Convert.ToSingle(txtPay.Text);
                pr.pro_realpay = Convert.ToSingle(txtRealpay.Text);
                pr.pro_difference = Convert.ToSingle(Convert.ToSingle(txtPay.Text) - Convert.ToSingle(txtRealpay.Text));
                db.Product.InsertOnSubmit(pr);
                db.SubmitChanges();
                MessageBox.Show("数据添加成功", "添加记录",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                BindInfo();
            }
            else if (op == operation.update)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                Product pr = new Product();
                var result = from p in db.Product
                             where p.pro_id == txtId.Text
                             select p;
                foreach (Product p in result)
                {
                    p.pro_id = txtId.Text;
                    p.pro_name = txtName.Text;
                    p.pro_handle = cbHandle.Text;
                    p.pro_units = cbUnits.Text;
                    p.pro_price = Convert.ToSingle(txtPrice.Text);
                    p.pro_count = Convert.ToSingle(txtCount.Text);
                    p.pro_time = dtTime.Value;
                    p.pro_pay = Convert.ToSingle(txtPay.Text);
                    p.pro_realpay = Convert.ToSingle(txtRealpay.Text);
                    p.pro_difference = Convert.ToSingle(txtDiff.Text);
                    db.SubmitChanges();
                    MessageBox.Show("数据修改成功", "修改记录",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    BindInfo();
                }
            }
        }
        private void txtId_Click(object sender, EventArgs e)
        {

            if (op == operation.update)
            {
                txtId.Enabled = false;
                MessageBox.Show("该状态下商品编号不可修改！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDiff_Click(object sender, EventArgs e)
        {
            //计算差额，并转换数据类型
            txtDiff.Text= Convert.ToString(Convert.ToSingle(txtRealpay.Text)- Convert.ToSingle(txtPay.Text));
        }

        private void txtPay_Click(object sender, EventArgs e)
        {
            txtPay.Text= Convert.ToString(Convert.ToSingle(txtPrice.Text) * Convert.ToSingle(txtCount.Text));
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            var result = from p in db.Product
                         where txtId.Text == p.pro_id
                         select p;
            db.Product.DeleteAllOnSubmit(result);
            db.SubmitChanges();
            MessageBox.Show("该记录已删除", "删除记录",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            BindInfo();
        }
        private void tsbReverse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvJinhuo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[0].Value);
            txtName.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[1].Value);
            cbHandle.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[2].Value);
            cbUnits.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[3].Value);
            txtPrice.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[4].Value);
            txtCount.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[5].Value);
            dtTime.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[6].Value);
            txtPay.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[7].Value);
            txtRealpay.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[8].Value);
            txtDiff.Text = Convert.ToString(dgvJinhuo.Rows[e.RowIndex].Cells[9].Value);
        }
    }
}
