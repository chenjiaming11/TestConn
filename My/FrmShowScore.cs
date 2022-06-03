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
    public partial class FrmShowScore : Form
    {
        public FrmShowScore()
        {
            InitializeComponent();
        }
        //加载成绩窗口，显示所有学生成绩
        private void FrmShowScore_Load(object sender, EventArgs e)
        {
            //调用方法
            ShowScore();
        }
        //获取学生所有成绩
        public void ShowScore()
        {
            //2-1数据库连接字符串
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            string sql = "select stu.StudentNo,stu.StudentName,sub.SubjectName,res.StudentResult,res.ExamData from Student as stu,Subject as sub,ResuIt as res where res.StudentNo = stu.StudentNo and res.SujectId = sub.SubjectId ";
            //获取控件的值
            string stuNo = txtStuNo.Text.Trim();
            string stuName = txtStuName.Text.Trim();
            string subName = txtStubName.Text.Trim();
            if (stuNo!= string.Empty)
            {
                sql += " and stu.StudentNo like '%" + stuNo + "%'";
            }
            if (stuName != string.Empty)
            {
                sql += " and stu.StudentName like '%" + stuName + "%'";
            }
            if (subName != string.Empty)
            {
                sql += " and sub.SubjectName like '%" + subName + "%'";
            }

            //创建数据集和适配器
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "Score");
            //绑定数据源到DateGridView控件中
            dgvScore.DataSource = ds.Tables["Score"];
            if (ds.Tables["Score"].Rows.Count ==0)
            {
                MessageBox.Show("没有该学生成绩记录！");
            }
        }
        //点击查询按钮，展示成绩
        private void btnSelect_Click(object sender, EventArgs e)
        {
            ShowScore();
        }
    }
}
