namespace hotelManageSystem
{
    partial class noReserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(noReserve));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbWhat = new System.Windows.Forms.ToolStripComboBox();
            this.txtValue = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewcus = new System.Windows.Forms.ToolStripButton();
            this.tsbAddDay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExitRoom = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReverse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddDay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.lbDays = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRoomID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbroomType = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbWhat,
            this.txtValue,
            this.tsbSelect,
            this.toolStripSeparator1,
            this.tsbUpdate,
            this.toolStripSeparator4,
            this.tsbNewcus,
            this.tsbAddDay,
            this.toolStripSeparator6,
            this.tsbExitRoom,
            this.tsbSave,
            this.toolStripSeparator8,
            this.tsbReverse,
            this.toolStripSeparator10,
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1244, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 36);
            this.toolStripLabel1.Text = "查询类别：";
            // 
            // tsbWhat
            // 
            this.tsbWhat.Items.AddRange(new object[] {
            "姓名",
            "身份证号",
            "房间号"});
            this.tsbWhat.Name = "tsbWhat";
            this.tsbWhat.Size = new System.Drawing.Size(136, 39);
            this.tsbWhat.Click += new System.EventHandler(this.tsbWhat_Click);
            // 
            // txtValue
            // 
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(112, 39);
            // 
            // tsbSelect
            // 
            this.tsbSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelect.Image")));
            this.tsbSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelect.Name = "tsbSelect";
            this.tsbSelect.Size = new System.Drawing.Size(63, 36);
            this.tsbSelect.Text = "查询";
            this.tsbSelect.Click += new System.EventHandler(this.tsbSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = global::hotelManageSystem.Properties.Resources.编辑;
            this.tsbUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(75, 36);
            this.tsbUpdate.Text = "编辑";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbNewcus
            // 
            this.tsbNewcus.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewcus.Image")));
            this.tsbNewcus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewcus.Name = "tsbNewcus";
            this.tsbNewcus.Size = new System.Drawing.Size(63, 36);
            this.tsbNewcus.Text = "新建";
            this.tsbNewcus.Click += new System.EventHandler(this.tsbNewcus_Click);
            // 
            // tsbAddDay
            // 
            this.tsbAddDay.Image = global::hotelManageSystem.Properties.Resources.续费;
            this.tsbAddDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddDay.Name = "tsbAddDay";
            this.tsbAddDay.Size = new System.Drawing.Size(63, 36);
            this.tsbAddDay.Text = "续费";
            this.tsbAddDay.Click += new System.EventHandler(this.tsbAddDay_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbExitRoom
            // 
            this.tsbExitRoom.Image = global::hotelManageSystem.Properties.Resources.删除;
            this.tsbExitRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExitRoom.Name = "tsbExitRoom";
            this.tsbExitRoom.Size = new System.Drawing.Size(63, 36);
            this.tsbExitRoom.Text = "退房";
            this.tsbExitRoom.Click += new System.EventHandler(this.tsbExitRoom_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(63, 36);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbReverse
            // 
            this.tsbReverse.Image = ((System.Drawing.Image)(resources.GetObject("tsbReverse.Image")));
            this.tsbReverse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReverse.Name = "tsbReverse";
            this.tsbReverse.Size = new System.Drawing.Size(63, 36);
            this.tsbReverse.Text = "返回";
            this.tsbReverse.Click += new System.EventHandler(this.tsbReverse_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 36);
            this.toolStripButton1.Text = "退出";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtAddDay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbTime);
            this.groupBox1.Controls.Add(this.txtExtra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPay);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDays);
            this.groupBox1.Controls.Add(this.dtTime);
            this.groupBox1.Controls.Add(this.lbDays);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbRoomID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbroomType);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1235, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户信息";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(984, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "元";
            // 
            // txtAddDay
            // 
            this.txtAddDay.Location = new System.Drawing.Point(1118, 111);
            this.txtAddDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddDay.Name = "txtAddDay";
            this.txtAddDay.Size = new System.Drawing.Size(105, 28);
            this.txtAddDay.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1027, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "续费天数：";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(984, 54);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(29, 19);
            this.lbTime.TabIndex = 21;
            this.lbTime.Text = "天";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(1118, 49);
            this.txtExtra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(105, 28);
            this.txtExtra.TabIndex = 18;
            this.txtExtra.Click += new System.EventHandler(this.txtExtra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1031, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "押金：";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(922, 110);
            this.txtPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(56, 28);
            this.txtPay.TabIndex = 16;
            this.txtPay.Click += new System.EventHandler(this.txtPay_Click);
            this.txtPay.TextChanged += new System.EventHandler(this.txtPay_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(847, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "收费：";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(922, 50);
            this.txtDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDays.Name = "txtDays";
            this.txtDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDays.Size = new System.Drawing.Size(56, 28);
            this.txtDays.TabIndex = 14;
            // 
            // dtTime
            // 
            this.dtTime.Location = new System.Drawing.Point(677, 110);
            this.dtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(149, 28);
            this.dtTime.TabIndex = 13;
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(834, 54);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(109, 19);
            this.lbDays.TabIndex = 12;
            this.lbDays.Text = "入住天数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "入住时间：";
            // 
            // cbRoomID
            // 
            this.cbRoomID.FormattingEnabled = true;
            this.cbRoomID.Location = new System.Drawing.Point(675, 50);
            this.cbRoomID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRoomID.Name = "cbRoomID";
            this.cbRoomID.Size = new System.Drawing.Size(128, 26);
            this.cbRoomID.TabIndex = 9;
            this.cbRoomID.Click += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            this.cbRoomID.Leave += new System.EventHandler(this.cbRoomID_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "房间号：";
            // 
            // cbroomType
            // 
            this.cbroomType.FormattingEnabled = true;
            this.cbroomType.Items.AddRange(new object[] {
            "大床房：180一天",
            "双人间：180一天",
            "三人间：220一天",
            "钟点房：60三小时"});
            this.cbroomType.Location = new System.Drawing.Point(400, 110);
            this.cbroomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbroomType.Name = "cbroomType";
            this.cbroomType.Size = new System.Drawing.Size(128, 26);
            this.cbroomType.TabIndex = 7;
            this.cbroomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(400, 49);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(128, 28);
            this.txtId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "房间类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "身份证号：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(78, 108);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(128, 28);
            this.txtPhone.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 28);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "电话：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvCustomer.Location = new System.Drawing.Point(11, 218);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 27;
            this.dgvCustomer.Size = new System.Drawing.Size(1233, 343);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cus_name";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cus_phone";
            this.Column2.HeaderText = "电话";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cus_id";
            this.Column3.HeaderText = "身份证号";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cus_type";
            this.Column4.HeaderText = "房间类型";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cus_roomid";
            this.Column5.HeaderText = "房间号";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "cus_time";
            this.Column6.HeaderText = "入住时间";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "cus_days";
            this.Column7.HeaderText = "入住天数";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "cus_pay";
            this.Column8.HeaderText = "收费";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "cus_extra";
            this.Column9.HeaderText = "押金";
            this.Column9.Name = "Column9";
            // 
            // noReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 578);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "noReserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入住登记";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tsbWhat;
        private System.Windows.Forms.ToolStripTextBox txtValue;
        private System.Windows.Forms.ToolStripButton tsbSelect;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbNewcus;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbReverse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbroomType;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRoomID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbExitRoom;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAddDay;
        private System.Windows.Forms.TextBox txtAddDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}