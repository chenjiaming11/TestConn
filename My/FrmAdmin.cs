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

        private void tsQuueryStuGrade_Click(object sender, EventArgs e)
        {
            FrmShowStuByGrade stuByGrade = null;
            if(Application.OpenForms["FrmShowStuByGrade"] != null)
            {
                stuByGrade = (FrmShowStuByGrade)Application.OpenForms["FrmShowStuByGrade"];
            }
            else
            {
                    stuByGrade = new FrmShowStuByGrade();
                    stuByGrade.MdiParent = this;
                    stuByGrade.Show();
            }

            
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
          
        }

        private void tsShowSore_Click(object sender, EventArgs e)
        {

            FrmShowScore score = new FrmShowScore();
            score.MdiParent = this;
            score.Show();
        }
        //点击学生列表，弹出学生所有的信息的窗体展示
        private void txStudentAll_Click(object sender, EventArgs e)
        {
            FrmShowStudentAll stuAll = null;
            if (Application.OpenForms["FrmShowStudentAll"] != null)
            {
                stuAll = (FrmShowStudentAll)Application.OpenForms["FrmShowStudentAll"];
            }
            else
            {
            stuAll = new FrmShowStudentAll();
            stuAll.MdiParent = this;
            stuAll.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmSearchStudent1 frm = null;
            if (Application.OpenForms["FrmSearchStudent1"] != null)
            {
                frm = (FrmSearchStudent1)Application.OpenForms["FrmSearchStudent1"];
            }
            else
            {
             frm = new FrmSearchStudent1();
             frm.MdiParent = this;
             frm.Show();
            }
        }

        private void 按年级查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmShowStuByGrade stuByGrade = new FrmShowStuByGrade();
            stuByGrade.MdiParent = this;
            stuByGrade.Show();
        }

        private void 学生列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowStudentAll stuAll = new FrmShowStudentAll();
            stuAll.MdiParent = this;
            stuAll.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 按年级查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearchStudent1 frm = new FrmSearchStudent1();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
