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
    public partial class FrmShowStudentAll : Form
    {
        public FrmShowStudentAll()
        {
            InitializeComponent();
        }
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        //加载窗体时，显示所有学生信息
        private void FrmShowStudentAll_Load(object sender, EventArgs e)
        {
            ShowStudentAll();
        }

        private void ShowStudentAll()
        {
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            string sql = "select * from student";
            ds = new DataSet();
            adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"];
            //判断 数据源没有数据
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //点击修改按钮，编辑修改单元格（修改数据集中的数据）
        private void xiugaibaocun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认要修改吗？","提示信息",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                //执行修改
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//需要参数：适配器（具有数据源的）
                adapter.Update(ds,"Student");
            }
        }
        //选中某行单元格（点击事件）
        private void dgv_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected)
            {//将dgv中行数据，显示到修改编辑区域
                //1获取agv行中数据
               
                int i = dataGridView1.CurrentRow.Index;

                textBox1.Text = dataGridView1.Rows[i].Cells["StudentNo"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells["LoginPwd"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells["StudentName"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[i].Cells["SEX"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[i].Cells["Gradeld"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[i].Cells["Phone"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[i].Cells["Address"].Value.ToString();
                textBox8.Text = dataGridView1.Rows[i].Cells["bornDate"].Value.ToString();
                textBox9.Text = dataGridView1.Rows[i].Cells["Email"].Value.ToString();
                //2通过文本框属性Text接收数据
                
            }
        }
        //点击保存，直接更新数据库
        private void btnUpdaSQL_Click(object sender, EventArgs e)
        {
            string connSting = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2-2创建连接对象SqlConnention
            SqlConnection conn = new SqlConnection(connSting);
            conn.Open();
            string sql = "  update Student set LoginPwd='"+textBox2.Text+ "',StudentName='" + textBox3.Text + "',Sex='" + textBox4.Text + "',Gradeld='" + textBox5.Text + "',Phone='" + textBox6.Text + "',Address='" + textBox7.Text + "',BornDate='" + textBox8.Text + "',Email='" + textBox9.Text + "'where StudentNo = '" + textBox1.Text + "'"; 
            SqlCommand command = new SqlCommand(sql,conn);
            int i = command.ExecuteNonQuery();
            if(i > 0)
            {
                MessageBox.Show("修改成功");
                ShowStudentAll();

            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
