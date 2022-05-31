using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void 账户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //点击新增学生，跳转到编辑学生信息窗体
        private void tsmiAddstu_Click(object sender, EventArgs e)
        {
            FrmEditStudent editStu = null;
            //打开子窗体前，判断是否已经存在,避免重复打开同一个窗体
            if (Application.OpenForms["FrmEditStudent"] !=null)
            {
                editStu = (FrmEditStudent)Application.OpenForms["FrmEditStudent"];
            }
            else
            {
                editStu = new FrmEditStudent();
            //设置打开窗体为子窗体，即把当前主窗体为父窗体
            
                editStu.MdiParent = this;
            
                editStu.Show();

            }
            
        }
    }
}
