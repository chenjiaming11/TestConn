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
    public partial class FrmShowStuByGrade : Form
    {
        public FrmShowStuByGrade()
        {
            InitializeComponent();
        }
        //加载当前窗体时，操作
        private void FrmShowStuByGrade_Load(object sender, EventArgs e)
        {
            //加载年级名称：到组合框控件
            ShowGrade();
            MessageBox.Show(cboGreade.SelectedValue.ToString());
            //显示所有学生信息
            
            ShoStudent();
            
           
        }
        //加载年级名称的方法
        public void ShowGrade()
        {
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            string sql = "select * from grade";
            //数据集对象
            DataSet ds = new DataSet();
            //适配器对象
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds, "Grade");
            //添加一行:编号| 名称-“全部”
            DataRow row = ds.Tables["Grade"].NewRow();
            row["GradeID"] = -1;
            row["GradeName"] = "全部";
            ds.Tables["Grade"].Rows.InsertAt(row,0);

            //将数据集中年级表信息绑定到组合框中
            cboGreade.DataSource = ds.Tables["Grade"];
            cboGreade.ValueMember = "GradeId";
            cboGreade.DisplayMember ="GradeName";
        }

        //加载学生信息的放方法
        public void ShoStudent()
        {
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            string sql ="select studentNO,studentName,sex,bornDate from student as s,Grade as g WHERE g.GradeId = S.Gradeld";
            //追加条件：点击查询时，更新qsl语句
            if (Convert.ToInt32(cboGreade.SelectedValue) !=-1)
            { //选择年级
                sql += " and g.gradeId=" + Convert.ToInt32(cboGreade.SelectedValue);
            }
            //查询数据后，将数据库源绑定到dateGridView控件：使用数据集DataSet和适配器DataAdapter
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            adapter.Fill(ds,"Student");
            dgvStudent.DataSource = ds.Tables["Student"];
            //判断 数据源没有数据
           if (ds.Tables["Student"].Rows.Count==0)
            {
                MessageBox.Show("此年级暂无数据");
            }
            conn.Close();
        }
        //点击查询按钮，更新DataGridView学生信息
        private void button1_Click(object sender, EventArgs e)
        {
            ShoStudent();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
