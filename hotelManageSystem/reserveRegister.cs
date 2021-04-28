using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace hotelManageSystem
{
    public partial class reserve : Form
    {
        private operation op;
        string connStr = "Data Source=localhost;Initial Catalog=hotelManage;Persist Security Info=True;User ID=sa;Password=123456";
        public reserve()
        {
            InitializeComponent();
        }
        public void BindInfo()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            switch (tsbWhat.Text)
            {
                case "":
                    var result = from c in db.reserveManage
                                 select c;
                    dgvReserve.DataSource = result;
                    break;
                case "姓名":
                    var result1 = from c in db.reserveManage
                                 where c.cus2_name == txtValue.Text
                                 select c;
                    dgvReserve.DataSource = result1;
                    break;
                case "房间号":
                    var result2 = from c in db.reserveManage
                                 where c.cus2_roomid == Convert.ToInt32(txtValue.Text)
                                 select c;
                    dgvReserve.DataSource = result2;
                    break;
                case "身份证号":
                    var result3 = from c in db.reserveManage
                                 where c.cus2_id == txtValue.Text
                                 select c;
                    dgvReserve.DataSource = result3;
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

        private void tsbNewcus_Click(object sender, EventArgs e)
        {
            op = operation.insert;
            txtName.Clear();
            txtPhone.Clear();
            txtId.Clear();
            cbRoomID.Text = "";
            cbroomType.Text = "";
            dtTime.ResetText();
            txtPay.Clear();
            txtExtra.Clear();
            txtDays.Clear();
        }
        private void tsbAddDay_Click(object sender, EventArgs e)
        {
            op = operation.update;
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            var result = from c in db.reserveManage
                         where c.cus2_id == txtId.Text
                         select c;
            foreach (reserveManage c in result)
            {
                c.cus2_days = Convert.ToInt32(txtDays.Text) + Convert.ToInt32(txtAddDay.Text);
                txtDays.Text = Convert.ToString(c.cus2_days);
                c.cus2_pay = Convert.ToSingle(txtPay.Text);
                MessageBox.Show("续费成功", "房间续费", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                switch (cbroomType.Text)
                {
                    case "钟点房：60三小时":
                        if (Convert.ToInt32(txtDays.Text) < 3)
                        {
                            MessageBox.Show("钟点房入住最低时数为三小时!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtDays.Clear();
                        }
                        else
                        {
                            txtPay.Text = Convert.ToString(20 * Convert.ToInt32(txtDays.Text));
                        }
                        break;
                    case "大床房：180一天":
                        txtPay.Text = Convert.ToString(180 * Convert.ToInt32(txtDays.Text));
                        break;
                    case "双人间：180一天":
                        txtPay.Text = Convert.ToString(180 * Convert.ToInt32(txtDays.Text));
                        break;
                    case "三人间：220一天":
                        txtPay.Text = Convert.ToString(220 * Convert.ToInt32(txtDays.Text));
                        break;
                }

                db.SubmitChanges();
                BindInfo();
            }
        }

        private void tsbExitRoom_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            var result = from c in db.reserveManage
                         where txtId.Text == c.cus2_id
                         select c;
            db.reserveManage.DeleteAllOnSubmit(result);
            db.SubmitChanges();
            MessageBox.Show("退房成功", "退房", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            BindInfo();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (op == operation.insert)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                reserveManage re = new reserveManage();
                re.cus2_name = txtName.Text;
                re.cus2_id = txtId.Text;
                re.cus2_phone = txtPhone.Text;
                re.cus2_type = cbroomType.Text;
                re.cus2_roomid = Convert.ToInt32(cbRoomID.Text);
                re.cus2_time = dtTime.Value;
                re.cus2_days = Convert.ToInt32(txtDays.Text);
                re.cus2_pay = Convert.ToSingle(txtPay.Text);
                re.cus2_extra = Convert.ToInt32(txtExtra.Text);
                db.reserveManage.InsertOnSubmit(re);
                db.SubmitChanges();
                MessageBox.Show("数据添加成功", "添加记录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                BindInfo();
            }
            else if (op == operation.update)
            {
                DataClasses1DataContext db = new DataClasses1DataContext(connStr);
                reserveManage cre = new reserveManage();
                var result = from c in db.reserveManage
                             where c.cus2_id == txtId.Text
                             select c;
                foreach (reserveManage c in result)
                {
                    c.cus2_name = txtName.Text;
                    c.cus2_id = txtId.Text;
                    c.cus2_phone = txtPhone.Text;
                    c.cus2_type = cbroomType.Text;
                    c.cus2_roomid = Convert.ToInt32(cbRoomID.Text);
                    c.cus2_time = dtTime.Value;
                    c.cus2_days = Convert.ToInt32(txtDays.Text);
                    c.cus2_pay = Convert.ToSingle(txtPay.Text);
                    c.cus2_extra = Convert.ToInt32(txtExtra.Text);
                    db.SubmitChanges();
                    MessageBox.Show("数据修改成功", "修改记录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    BindInfo();
                }
            }
        }

        private void tsbReverse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvReserve_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[0].Value);
            txtPhone.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[1].Value);
            txtId.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[2].Value);
            cbroomType.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[3].Value);
            cbRoomID.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[4].Value);
            dtTime.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[5].Value);
            txtDays.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[6].Value);
            txtPay.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[7].Value);
            txtExtra.Text = Convert.ToString(dgvReserve.Rows[e.RowIndex].Cells[8].Value);
        }
        private void cbroomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = { "101", "102", "103", "104", "105", "106" };
            string[] str1 = { "201", "202", "203", "204", "205", "206" };
            string[] str2 = { "301", "302", "303", "304", "305", "306" };
            string[] str3 = { "401", "402", "403", "404", "405", "406" };
            //switch语句依据所选房间类型，给出房间号
            switch (cbroomType.Text)
            {
                case "大床房：180一天":
                    cbRoomID.Items.Clear();
                    //遍历数组取得房间号
                    for (int i = 0; i <= 5; i++)
                    {
                        cbRoomID.Items.Add(str[i]);
                    }
                    break;
                case "双人间：180一天":
                    cbRoomID.Items.Clear();
                    for (int i = 0; i <= 5; i++)
                    {
                        cbRoomID.Items.Add(str1[i]);
                    }
                    break;
                case "三人间：220一天":
                    cbRoomID.Items.Clear();
                    for (int i = 0; i <= 5; i++)
                    {
                        cbRoomID.Items.Add(str2[i]);
                    }
                    break;
                case "钟点房：60三小时":
                    lbDays.Text = "入住时数:";
                    lbTime.Text = "小时";
                    cbRoomID.Items.Clear();
                    for (int i = 0; i <= 5; i++)
                    {
                        cbRoomID.Items.Add(str3[i]);
                    }
                    break;
            }
        }
        private void txtExtra_Click(object sender, EventArgs e)
        {
            txtExtra.Text = "200";
        }

        private void txtPay_Click(object sender, EventArgs e)
        {
            switch (cbroomType.Text)
            {
                case "钟点房：60三小时":
                    if (Convert.ToInt32(txtDays.Text) < 3)
                    {
                        MessageBox.Show("钟点房入住最低时数为三小时!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDays.Clear();
                    }
                    else
                    {
                        txtPay.Text = Convert.ToString(20 * Convert.ToInt32(txtDays.Text));
                    }
                    break;
                case "大床房：180一天":
                    txtPay.Text = Convert.ToString(180 * Convert.ToInt32(txtDays.Text));
                    break;
                case "双人间：180一天":
                    txtPay.Text = Convert.ToString(180 * Convert.ToInt32(txtDays.Text));
                    break;
                case "三人间：220一天":
                    txtPay.Text = Convert.ToString(220 * Convert.ToInt32(txtDays.Text));
                    break;
            }
        }

        private void dtTime_DropDown(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            string num = cbRoomID.Text;
            var result = from s in db.reserveManage
                         where s.cus2_roomid.Equals(num)
                         select new { isHave = true };
            var result1 = from s in db.customerManage
                          where s.cus_roomid.Equals(num)
                         select new { isHave = true };
            if (result.Count() > 0 || result1.Count()>0)
            {
                MessageBox.Show("该房间已被订,请重新选择", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbRoomID.Text = "";
            }
        }

        private void cbRoomID_Leave(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(connStr);
            string num = cbRoomID.Text;
            var result = from s in db.reserveManage
                         where s.cus2_roomid.Equals(num)
                         select new { isHave = true };
            var result1 = from s in db.customerManage
                          where s.cus_roomid.Equals(num)
                          select new { isHave = true };
            if (result.Count() > 0 || result1.Count() > 0)
            {
                MessageBox.Show("该房间已被订,请重新选择", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbRoomID.Text = "";
            }
        }
    }
    }

