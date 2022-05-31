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
    public partial class FrmEditStudent : Form
    {
        public FrmEditStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //加载窗体时的人时件
        private void FrmEditStudent_Load(object sender, EventArgs e)
        {
            //显示性别女 被选中
            radoNv.Checked = true;

        }
        //点击清空按钮的操作，所有的控件清空或者恢复到初始值
        private void btnClear_Click(object sender, EventArgs e)
        {
            //清空两个分组框中所有的文本框的值：方法1把每个控件重新赋值 方法2循环遍历
            foreach (Control con in grpoupBox1.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
                   
            }
            //清空第二个分组框中所有的值
            foreach (Control con in groupBox2.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
            }
            //其他控件的清空或恢复
            radoNv.Checked = true;//性别恢复默认女选择
            dtpBornDate.Value = DateTime.Now;//日期控件恢复默认值当前时间
        }
            //点击保存按钮，实现添加学生记录
        private void button1_Click(object sender, EventArgs e)
        {
            //思路：获取所有控件值：学号、密码、姓名、性别、年级（学生表中需要年级id而不是年级名称）、电话、地址、出生日期、邮箱
            string stuNo = txtStuNo.Text.Trim();
            string pwd = txtpwd.Text.Trim();
            MessageBox.Show(pwd);
            string pwd2 = txtpwdCofirm.Text.Trim();
            MessageBox.Show(pwd2);
            if (pwd !=pwd2)
            {
                MessageBox.Show("两次密码输入不一致！");
                return;
            }
            string name = txtName.Text.Trim();
            MessageBox.Show(name);
            string sex = null;
            if (radoNv.Checked)
            {
                sex = "女";
            }
            else
            {
                sex = "男";
            }
            MessageBox.Show(sex);
            //获取年级信息id：
            string phone = txtPhone.Text.Trim();
            MessageBox.Show(phone);
            string address = txtAddress.Text.Trim();
            MessageBox.Show(address);
            DateTime date = dtpBornDate.Value;
            string date2 = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);
            MessageBox.Show(date2);
            string email = txtEmail.Text.Trim();
            MessageBox.Show(email);
            //执行添加的操作
        }
    }
}
