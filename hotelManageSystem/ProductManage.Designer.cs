namespace hotelManageSystem
{
    partial class ProductManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManage));
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHandle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUnits = new System.Windows.Forms.ComboBox();
            this.dgvJinhuo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtRealpay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiff = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbWhat = new System.Windows.Forms.ToolStripComboBox();
            this.txtValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSeleect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.txbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReverse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJinhuo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(112, 71);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(112, 28);
            this.txtId.TabIndex = 1;
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品名称：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 125);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 28);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "经手人：";
            // 
            // cbHandle
            // 
            this.cbHandle.FormattingEnabled = true;
            this.cbHandle.Items.AddRange(new object[] {
            "王宽",
            "吴兰"});
            this.cbHandle.Location = new System.Drawing.Point(423, 71);
            this.cbHandle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHandle.Name = "cbHandle";
            this.cbHandle.Size = new System.Drawing.Size(108, 26);
            this.cbHandle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "供货单位：";
            // 
            // cbUnits
            // 
            this.cbUnits.FormattingEnabled = true;
            this.cbUnits.Items.AddRange(new object[] {
            "苏州博雅日用品有新公司",
            "苏州蓝天酒店用品有限公公司",
            "苏州白云一次性用品有限公司"});
            this.cbUnits.Location = new System.Drawing.Point(423, 128);
            this.cbUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.Size = new System.Drawing.Size(108, 26);
            this.cbUnits.TabIndex = 8;
            // 
            // dgvJinhuo
            // 
            this.dgvJinhuo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJinhuo.BackgroundColor = System.Drawing.Color.White;
            this.dgvJinhuo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJinhuo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJinhuo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvJinhuo.Location = new System.Drawing.Point(17, 185);
            this.dgvJinhuo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvJinhuo.Name = "dgvJinhuo";
            this.dgvJinhuo.RowTemplate.Height = 27;
            this.dgvJinhuo.Size = new System.Drawing.Size(1046, 198);
            this.dgvJinhuo.TabIndex = 11;
            this.dgvJinhuo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJinhuo_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pro_id";
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pro_name";
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pro_handle";
            this.Column3.HeaderText = "经手人";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "pro_units";
            this.Column4.HeaderText = "供货单位";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "pro_price";
            this.Column5.HeaderText = "进货单价";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "pro_count";
            this.Column6.HeaderText = "进货数量";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "pro_time";
            this.Column7.HeaderText = "进货日期";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pro_pay";
            this.Column8.HeaderText = "应付金额";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "pro_realpay";
            this.Column9.HeaderText = "实付金额";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "pro_difference";
            this.Column10.HeaderText = "差额";
            this.Column10.Name = "Column10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "进货数量：";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(663, 124);
            this.txtCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(112, 28);
            this.txtCount.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "应付金额：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "实付金额：";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(98, 407);
            this.txtPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(112, 28);
            this.txtPay.TabIndex = 17;
            this.txtPay.Click += new System.EventHandler(this.txtPay_Click);
            // 
            // txtRealpay
            // 
            this.txtRealpay.Location = new System.Drawing.Point(98, 467);
            this.txtRealpay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRealpay.Name = "txtRealpay";
            this.txtRealpay.Size = new System.Drawing.Size(112, 28);
            this.txtRealpay.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "差额：";
            // 
            // txtDiff
            // 
            this.txtDiff.Location = new System.Drawing.Point(316, 434);
            this.txtDiff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(112, 28);
            this.txtDiff.TabIndex = 20;
            this.txtDiff.Click += new System.EventHandler(this.txtDiff_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "进货单";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(663, 69);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 28);
            this.txtPrice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "进货单价：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(794, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "进货日期：";
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(893, 92);
            this.dtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(147, 28);
            this.dtTime.TabIndex = 26;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbWhat,
            this.txtValue,
            this.tsbSeleect,
            this.toolStripSeparator3,
            this.tsbUpdate,
            this.toolStripSeparator4,
            this.txbAdd,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.toolStripSeparator5,
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbReverse,
            this.toolStripSeparator6,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1071, 28);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 25);
            this.toolStripLabel1.Text = "查询类别：";
            // 
            // tsbWhat
            // 
            this.tsbWhat.Items.AddRange(new object[] {
            "商品编号",
            "商品名称",
            "经手人"});
            this.tsbWhat.Name = "tsbWhat";
            this.tsbWhat.Size = new System.Drawing.Size(136, 28);
            // 
            // txtValue
            // 
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(112, 28);
            // 
            // tsbSeleect
            // 
            this.tsbSeleect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSeleect.Image")));
            this.tsbSeleect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSeleect.Name = "tsbSeleect";
            this.tsbSeleect.Size = new System.Drawing.Size(63, 25);
            this.tsbSeleect.Text = "查询";
            this.tsbSeleect.Click += new System.EventHandler(this.tsbSeleect_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(63, 25);
            this.tsbUpdate.Text = "编辑";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // txbAdd
            // 
            this.txbAdd.Image = ((System.Drawing.Image)(resources.GetObject("txbAdd.Image")));
            this.txbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txbAdd.Name = "txbAdd";
            this.txbAdd.Size = new System.Drawing.Size(63, 25);
            this.txbAdd.Text = "添加";
            this.txbAdd.Click += new System.EventHandler(this.txbAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbDelete
            // 
            this.tsbDelete.BackColor = System.Drawing.SystemColors.Control;
            this.tsbDelete.Image = global::hotelManageSystem.Properties.Resources.删除;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.SkyBlue;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(63, 25);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::hotelManageSystem.Properties.Resources.保存;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(63, 25);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbReverse
            // 
            this.tsbReverse.Image = global::hotelManageSystem.Properties.Resources.撤销;
            this.tsbReverse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReverse.Name = "tsbReverse";
            this.tsbReverse.Size = new System.Drawing.Size(63, 25);
            this.tsbReverse.Text = "返回";
            this.tsbReverse.Click += new System.EventHandler(this.tsbReverse_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::hotelManageSystem.Properties.Resources.退出;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(63, 25);
            this.tsbExit.Text = "退出";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 559);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiff);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRealpay);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJinhuo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbUnits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHandle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ProductManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进货管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJinhuo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHandle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUnits;
        private System.Windows.Forms.DataGridView dgvJinhuo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtRealpay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tsbWhat;
        private System.Windows.Forms.ToolStripTextBox txtValue;
        private System.Windows.Forms.ToolStripButton tsbSeleect;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbReverse;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton txbAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}