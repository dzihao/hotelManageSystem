namespace hotelManageSystem
{
    partial class Index
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.住宿管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出当前系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.住宿管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.productManageToolStripMenuItem,
            this.退出当前系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 住宿管理ToolStripMenuItem
            // 
            this.住宿管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.reserveTool});
            this.住宿管理ToolStripMenuItem.Name = "住宿管理ToolStripMenuItem";
            this.住宿管理ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.住宿管理ToolStripMenuItem.Text = "住宿管理";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 26);
            this.toolStripMenuItem1.Text = "未预定顾客住房管理";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.noReserveManage);
            // 
            // reserveTool
            // 
            this.reserveTool.Name = "reserveTool";
            this.reserveTool.Size = new System.Drawing.Size(264, 26);
            this.reserveTool.Text = "预定顾客住房管理";
            this.reserveTool.Click += new System.EventHandler(this.reserveManageTool);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.empSalaryToolStripMenuItem});
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.employeeToolStripMenuItem.Text = "员工信息管理";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.empManageTool);
            // 
            // empSalaryToolStripMenuItem
            // 
            this.empSalaryToolStripMenuItem.Name = "empSalaryToolStripMenuItem";
            this.empSalaryToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.empSalaryToolStripMenuItem.Text = "员工工资管理";
            this.empSalaryToolStripMenuItem.Click += new System.EventHandler(this.empSalaryManage);
            // 
            // productManageToolStripMenuItem
            // 
            this.productManageToolStripMenuItem.Name = "productManageToolStripMenuItem";
            this.productManageToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.productManageToolStripMenuItem.Text = "酒店用品进货管理";
            this.productManageToolStripMenuItem.Click += new System.EventHandler(this.productManageToolStripMenuItem_Click);
            // 
            // 退出当前系统ToolStripMenuItem
            // 
            this.退出当前系统ToolStripMenuItem.Name = "退出当前系统ToolStripMenuItem";
            this.退出当前系统ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.退出当前系统ToolStripMenuItem.Text = "退出当前系统";
            this.退出当前系统ToolStripMenuItem.Click += new System.EventHandler(this.exitSystem);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotelManageSystem.Properties.Resources.酒店外观剪裁后;
            this.ClientSize = new System.Drawing.Size(665, 366);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 住宿管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noReserveTool;
        private System.Windows.Forms.ToolStripMenuItem productManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出当前系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveTool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}