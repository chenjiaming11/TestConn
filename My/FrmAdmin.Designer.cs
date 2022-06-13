
namespace My
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.账户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddstu = new System.Windows.Forms.ToolStripMenuItem();
            this.按年级查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按年级查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.学生列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdmin = new System.Windows.Forms.ToolStrip();
            this.tsAddStu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsQuueryStuGrade = new System.Windows.Forms.ToolStripButton();
            this.tsShowSore = new System.Windows.Forms.ToolStripButton();
            this.txStudentAll = new System.Windows.Forms.ToolStripDropDownButton();
            this.msAdmin.SuspendLayout();
            this.tsAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.BackColor = System.Drawing.Color.Aqua;
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户管理ToolStripMenuItem,
            this.学生用户管理ToolStripMenuItem,
            this.科目管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(1123, 25);
            this.msAdmin.TabIndex = 0;
            this.msAdmin.Text = "ms";
            // 
            // 账户管理ToolStripMenuItem
            // 
            this.账户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.账户管理ToolStripMenuItem.Name = "账户管理ToolStripMenuItem";
            this.账户管理ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.账户管理ToolStripMenuItem.Text = "账户管理(&U)";
            this.账户管理ToolStripMenuItem.Click += new System.EventHandler(this.账户管理ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 学生用户管理ToolStripMenuItem
            // 
            this.学生用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddstu,
            this.按年级查询ToolStripMenuItem,
            this.按年级查询ToolStripMenuItem1,
            this.学生列表ToolStripMenuItem});
            this.学生用户管理ToolStripMenuItem.Name = "学生用户管理ToolStripMenuItem";
            this.学生用户管理ToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.学生用户管理ToolStripMenuItem.Text = "学生用户管理(&S)";
            // 
            // tsmiAddstu
            // 
            this.tsmiAddstu.Name = "tsmiAddstu";
            this.tsmiAddstu.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddstu.Text = "新增学生用户";
            this.tsmiAddstu.Click += new System.EventHandler(this.tsmiAddstu_Click);
            // 
            // 按年级查询ToolStripMenuItem
            // 
            this.按年级查询ToolStripMenuItem.Name = "按年级查询ToolStripMenuItem";
            this.按年级查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.按年级查询ToolStripMenuItem.Text = "按姓名查询";
            this.按年级查询ToolStripMenuItem.Click += new System.EventHandler(this.按年级查询ToolStripMenuItem_Click);
            // 
            // 按年级查询ToolStripMenuItem1
            // 
            this.按年级查询ToolStripMenuItem1.Name = "按年级查询ToolStripMenuItem1";
            this.按年级查询ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.按年级查询ToolStripMenuItem1.Text = "按年级查询";
            this.按年级查询ToolStripMenuItem1.Click += new System.EventHandler(this.按年级查询ToolStripMenuItem1_Click);
            // 
            // 学生列表ToolStripMenuItem
            // 
            this.学生列表ToolStripMenuItem.Name = "学生列表ToolStripMenuItem";
            this.学生列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.学生列表ToolStripMenuItem.Text = "学生列表";
            this.学生列表ToolStripMenuItem.Click += new System.EventHandler(this.学生列表ToolStripMenuItem_Click);
            // 
            // 科目管理ToolStripMenuItem
            // 
            this.科目管理ToolStripMenuItem.Name = "科目管理ToolStripMenuItem";
            this.科目管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.科目管理ToolStripMenuItem.Text = "科目管理(&C)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&W)";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(61, 21);
            this.退出ToolStripMenuItem1.Text = "退出(&H)";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // tsAdmin
            // 
            this.tsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddStu,
            this.toolStripButton2,
            this.tsQuueryStuGrade,
            this.tsShowSore,
            this.txStudentAll});
            this.tsAdmin.Location = new System.Drawing.Point(0, 25);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(1123, 25);
            this.tsAdmin.TabIndex = 1;
            this.tsAdmin.Text = "toolStrip1";
            // 
            // tsAddStu
            // 
            this.tsAddStu.Image = ((System.Drawing.Image)(resources.GetObject("tsAddStu.Image")));
            this.tsAddStu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddStu.Name = "tsAddStu";
            this.tsAddStu.Size = new System.Drawing.Size(100, 22);
            this.tsAddStu.Text = "新建学生用户";
            this.tsAddStu.Click += new System.EventHandler(this.tsmiAddstu_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton2.Text = "按姓名查询学生";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsQuueryStuGrade
            // 
            this.tsQuueryStuGrade.Image = ((System.Drawing.Image)(resources.GetObject("tsQuueryStuGrade.Image")));
            this.tsQuueryStuGrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuueryStuGrade.Name = "tsQuueryStuGrade";
            this.tsQuueryStuGrade.Size = new System.Drawing.Size(112, 22);
            this.tsQuueryStuGrade.Text = "按年级查询学生";
            this.tsQuueryStuGrade.Click += new System.EventHandler(this.tsQuueryStuGrade_Click);
            // 
            // tsShowSore
            // 
            this.tsShowSore.Image = ((System.Drawing.Image)(resources.GetObject("tsShowSore.Image")));
            this.tsShowSore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsShowSore.Name = "tsShowSore";
            this.tsShowSore.Size = new System.Drawing.Size(76, 22);
            this.tsShowSore.Text = "查询成绩";
            this.tsShowSore.Click += new System.EventHandler(this.tsShowSore_Click);
            // 
            // txStudentAll
            // 
            this.txStudentAll.Image = ((System.Drawing.Image)(resources.GetObject("txStudentAll.Image")));
            this.txStudentAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txStudentAll.Name = "txStudentAll";
            this.txStudentAll.Size = new System.Drawing.Size(85, 22);
            this.txStudentAll.Text = "学生列表";
            this.txStudentAll.Click += new System.EventHandler(this.txStudentAll_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1123, 688);
            this.Controls.Add(this.tsAdmin);
            this.Controls.Add(this.msAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msAdmin;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员主窗体";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.tsAdmin.ResumeLayout(false);
            this.tsAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem 账户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddstu;
        private System.Windows.Forms.ToolStripMenuItem 按年级查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按年级查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 学生列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip tsAdmin;
        private System.Windows.Forms.ToolStripButton tsAddStu;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsQuueryStuGrade;
        private System.Windows.Forms.ToolStripButton tsShowSore;
        private System.Windows.Forms.ToolStripDropDownButton txStudentAll;
    }
}