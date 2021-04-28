namespace hotelManageSystem
{
    partial class Land
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Land));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updatePwd = new System.Windows.Forms.LinkLabel();
            this.btnLand = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工编号：";
            // 
            // txtEmp
            // 
            this.txtEmp.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmp.Location = new System.Drawing.Point(165, 35);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(154, 30);
            this.txtEmp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(165, 135);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(154, 30);
            this.txtPassWord.TabIndex = 5;
            this.txtPassWord.Click += new System.EventHandler(this.txtPassWord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(123, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "注：默认密码为员工编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(161, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "初次登录请先修改密码";
            // 
            // updatePwd
            // 
            this.updatePwd.AutoSize = true;
            this.updatePwd.Location = new System.Drawing.Point(170, 242);
            this.updatePwd.Name = "updatePwd";
            this.updatePwd.Size = new System.Drawing.Size(129, 20);
            this.updatePwd.TabIndex = 10;
            this.updatePwd.TabStop = true;
            this.updatePwd.Text = "点此修改密码";
            this.updatePwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updatePwd_LinkClicked);
            // 
            // btnLand
            // 
            this.btnLand.BackColor = System.Drawing.Color.White;
            this.btnLand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLand.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLand.Location = new System.Drawing.Point(71, 279);
            this.btnLand.Name = "btnLand";
            this.btnLand.Size = new System.Drawing.Size(98, 45);
            this.btnLand.TabIndex = 11;
            this.btnLand.Text = "登录";
            this.btnLand.UseVisualStyleBackColor = false;
            this.btnLand.Click += new System.EventHandler(this.btnLand_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Location = new System.Drawing.Point(279, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 45);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Land
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(454, 355);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLand);
            this.Controls.Add(this.updatePwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Land";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hotelManageSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel updatePwd;
        private System.Windows.Forms.Button btnLand;
        private System.Windows.Forms.Button btnExit;
    }
}

