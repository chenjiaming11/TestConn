
namespace My
{
    partial class FrmStudent
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
            this.tsmzhgl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripckcj = new System.Windows.Forms.ToolStripButton();
            this.toolStripgrcj = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmzhgl,
            this.tsmtc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmzhgl
            // 
            this.tsmzhgl.Name = "tsmzhgl";
            this.tsmzhgl.Size = new System.Drawing.Size(68, 21);
            this.tsmzhgl.Text = "账户管理";
            // 
            // tsmtc
            // 
            this.tsmtc.Name = "tsmtc";
            this.tsmtc.Size = new System.Drawing.Size(44, 21);
            this.tsmtc.Text = "退出";
            this.tsmtc.Click += new System.EventHandler(this.tsmtc_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripckcj,
            this.toolStripgrcj});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(746, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripckcj
            // 
            this.toolStripckcj.Image = global::My.Properties.Resources.查看_01;
            this.toolStripckcj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripckcj.Name = "toolStripckcj";
            this.toolStripckcj.Size = new System.Drawing.Size(76, 22);
            this.toolStripckcj.Text = "查看成绩";
            this.toolStripckcj.Click += new System.EventHandler(this.toolStripckcj_Click);
            // 
            // toolStripgrcj
            // 
            this.toolStripgrcj.Image = global::My.Properties.Resources.查看;
            this.toolStripgrcj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripgrcj.Name = "toolStripgrcj";
            this.toolStripgrcj.Size = new System.Drawing.Size(100, 22);
            this.toolStripgrcj.Text = "查看个人成绩";
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生窗口";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmzhgl;
        private System.Windows.Forms.ToolStripMenuItem tsmtc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripckcj;
        private System.Windows.Forms.ToolStripButton toolStripgrcj;
    }
}