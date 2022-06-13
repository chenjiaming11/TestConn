
namespace My
{
    partial class Frmchaxun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmchaxun));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butchaxun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cobkemu = new System.Windows.Forms.ComboBox();
            this.cobjieguo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.advxinxi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advxinxi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cobjieguo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cobkemu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butchaxun);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // butchaxun
            // 
            this.butchaxun.Location = new System.Drawing.Point(494, 29);
            this.butchaxun.Name = "butchaxun";
            this.butchaxun.Size = new System.Drawing.Size(75, 23);
            this.butchaxun.TabIndex = 0;
            this.butchaxun.Text = "查询";
            this.butchaxun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "科目";
            // 
            // cobkemu
            // 
            this.cobkemu.FormattingEnabled = true;
            this.cobkemu.Location = new System.Drawing.Point(89, 29);
            this.cobkemu.Name = "cobkemu";
            this.cobkemu.Size = new System.Drawing.Size(151, 20);
            this.cobkemu.TabIndex = 2;
            // 
            // cobjieguo
            // 
            this.cobjieguo.FormattingEnabled = true;
            this.cobjieguo.Location = new System.Drawing.Point(320, 29);
            this.cobjieguo.Name = "cobjieguo";
            this.cobjieguo.Size = new System.Drawing.Size(152, 20);
            this.cobjieguo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "结果";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // advxinxi
            // 
            this.advxinxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advxinxi.Location = new System.Drawing.Point(26, 114);
            this.advxinxi.Name = "advxinxi";
            this.advxinxi.RowTemplate.Height = 23;
            this.advxinxi.Size = new System.Drawing.Size(597, 265);
            this.advxinxi.TabIndex = 1;
            // 
            // Frmchaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 405);
            this.Controls.Add(this.advxinxi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmchaxun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询成绩信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advxinxi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cobjieguo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobkemu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butchaxun;
        private System.Windows.Forms.DataGridView advxinxi;
    }
}