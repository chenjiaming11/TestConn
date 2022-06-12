using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My
{
    public partial class FrmMain1 : Form
    {
        public FrmMain1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
          //点击取消按钮，取消登录 关闭窗口
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //添加信息框
            DialogResult result = MessageBox.Show("确实取消登录么", "提示", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) { 
            this.Close();
            }
        }
        //加载窗口时，操作
        private void FrmMain1_Load(object sender, EventArgs e)
        {
            //组合框中默认显示“请选择”
            cboLginType.SelectedIndex = 0;
            

        }
        //点击登录的操作
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1、非空验证 ：
            //IsEmpty();
            if (IsEmpty())//如果验证非空，结果为值，控件输了值
            {
                //登录操作（验证输入的用户名的密码，正确）
                if (Login())
                {
                    //窗体跳转 ：新建一个窗体
                   
                    //判断是管理员还是学生用户，跳转到对应得窗体、
                    if (cboLginType.Text.Equals("系统管理员"))
                    {
                        MessageBox.Show("登录成功！");
                        FrmAdmin guanli = new FrmAdmin();
                        guanli.Show(); 
                    }
                    else
                    {
                        MessageBox.Show("登录失败!");
                    }

                   this.Hide();//隐藏当前登录窗体

                }
                if (stu())
                {
                    
                    //判断是管理员还是学生用户，跳转到对应得窗体、
                    if (cboLginType.Text.Equals("学生登录"))
                    {
                        MessageBox.Show("登录成功！");
                        FrmStudent stu = new FrmStudent();
                        stu.Show();
                    }
                    else
                    {
                        MessageBox.Show("登录失败!");
                    }
                    this.Hide();//隐藏当前登录窗体
                }   

            }

                else
                {
                    MessageBox.Show("登录失败!");
                }
                 }
        //登录实现
        public bool Login()
        {
            //1、获取控件中用户输入的信息（用户名和密码）
            string name = txtUsername.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            //2、访问数据库操作
            //2-1数据库连接字符串
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            //准备sql语句
            string sql = "select * from Admin where UserName = '" + name + "'and password='" + pwd + "'";
            //2-3创建执行对象SqlCommand
            SqlCommand command = new SqlCommand(sql,conn);
            //2-4执行sql语句，返回结果
            int i = 0;
            if (command.ExecuteScalar() != null)
            {
                i = (int)command.ExecuteScalar();
            }
            //2-6关闭连接或其他资源 
            conn.Close();
            //2-5处理结果
            if (i == 1)
            {        
                return true;                
            }
            else
            {
               return false;
            }             
        }
        public bool stu()
        {
            string name = txtUsername.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            //2、访问数据库操作
            //2-1数据库连接字符串
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            //准备sql语句
            string sql = "select * from studentdl where UserName = '" + name + "'and password='" + pwd + "'";
            //2-3创建执行对象SqlCommand
            SqlCommand command = new SqlCommand(sql, conn);
            //2-4执行sql语句，返回结果
            int i = 0;
            if (command.ExecuteScalar() != null)
            {
                i = (int)command.ExecuteScalar();
            }
            //2-6关闭连接或其他资源 
            conn.Close();
            //2-5处理结果
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //非空验证
        public bool IsEmpty()
        {
            //1、非空验证 ：用户名、密码 、登录类型
            //获取控件的值，判断
            if(txtUsername.Text.Trim() ==string.Empty )
            {
                MessageBox.Show("未输入用户名");
                return false;
            }
            if (txtPwd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("未输入密码");
                return false;
            }
            if (cboLginType.Text == "请选择")
            {
                MessageBox.Show("未选择登录类型");
                return false;
            }
            return true;

        }
       
    }
}
