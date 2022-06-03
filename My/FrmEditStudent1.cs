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
    public partial class FrmEditStudent : Form
    {
        public FrmEditStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //加载显示编辑学生信息的窗体
        private void FrmEditStudent_Load(object sender, EventArgs e)
        {
            //显示性别女 被选中
            radoNv.Checked = true;
            //加载年级名称
            ShowGrade();

        }
        //年级控件绑定数据
        public void ShowGrade()
        {
            //2-1数据库连接字符串
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            //准备查询所有年级名称的sql
            string sql = "select * from grade";
            SqlCommand command = new SqlCommand(sql,conn);
             SqlDataReader reader = command.ExecuteReader();
            //将获取的数据库，去年级名称绑定到组合框CombBox控件中
            cboGrade.Items.Add("请选择");
            cboGrade.SelectedIndex = 0; //设置选中“请选择”
            while (reader.Read())
            {
                string grade = reader["GradeName"].ToString();
                //年级名称放到控件中
                cboGrade.Items.Add(grade);
            }
            reader.Close();
            conn.Close();

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
            //年级恢复“请选择”
            cboGrade.SelectedIndex = 0;
        }
       
        
            //点击保存按钮，实现添加学生记录
        private void button1_Click(object sender, EventArgs e)
        {
            //思路：获取所有控件值：学号、密码、姓名、性别、年级（学生表中需要年级id而不是年级名称）、电话、地址、出生日期、邮箱
            string stuNo = txtStuNo.Text.Trim();
            //判断学号不能和现有的学生的学号冲突，（学号不能重复，自己实现，判断学号是否已经存在）
            

            string pwd = txtpwd.Text.Trim();
            if (pwd.Length < 6)
            {
                MessageBox.Show("密码长度必须大于等于六！");
                return;
            }
            
            string pwd2 = txtpwdCofirm.Text.Trim();
            
            if (pwd !=pwd2)
            {
                MessageBox.Show("两次密码输入不一致！");
                return;
            }
            string name = txtName.Text.Trim();
            
            string sex = null;
            if (radoNv.Checked)
            {
                sex = "女";
            }
            else
            {
                sex = "男";
            }
           
            //获取年级信息id：通过年级的名称查询相对应的年级编号
            string gradeName = cboGrade.Text;
            //2-1数据库连接字符串
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            string sql = "select gradeId from grade where gradeName='" + gradeName + "'";
            SqlCommand command = new SqlCommand(sql,conn);
            SqlDataReader reader = command.ExecuteReader();
            int gradeId = 0;
            while (reader.Read())
            {
                gradeId = Convert.ToInt32(reader["gradeId"]);
            }
            reader.Close();
            //MessageBox.Show(gradeId.ToString());


            string phone = txtPhone.Text.Trim();
            
            string address = txtAddress.Text.Trim();
            
            DateTime date = dtpBornDate.Value;
            string date2 = string.Format("{0}-{1}-{2}", date.Year, date.Month, date.Day);
            
            string email = txtEmail.Text.Trim();
            if (!email.Contains("@"))//邮箱必须包含@
            {
                MessageBox.Show("输入的邮箱中必须包含@！");
                return;
            }
            //非空的判断
            if (stuNo == string.Empty || name == string.Empty || cboGrade.SelectedIndex ==0 || phone == string.Empty || address == string.Empty || email == string.Empty)
            {
                MessageBox.Show("输入内容有空，请检查后重新输入！");
                return;
            }
            //执行添加的操作
            /*StringBuilder sb = new StringBuilder("insert into student(StudenNo,LoginPwd,StudentName,Sex,GradeId,Phone,Address,BornDate,Email) values('");
            sb.Append(stuNo);*/

            string sqlAddStu = "insert into student(StudentNo,LoginPwd,StudentName,Sex,Gradeld,Phone,Address,BornDate,Email) values('" + stuNo+"','"+pwd+"','"+name+"','"+sex+"',"+gradeId+",'"+phone+"','"+address+"','"+date2+"','"+email+"')";
            command = new SqlCommand(sqlAddStu, conn);
            //int i = 0;
            //if (command.ExecuteNonQuery() != null)
            //{
            //   i =(int)command.ExecuteScalar();
            //}           
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("学生信息注册成功！");
            }
            else
            {
                MessageBox.Show("学生信息注册失败！");
            }
            conn.Close();
        }
    }
}
