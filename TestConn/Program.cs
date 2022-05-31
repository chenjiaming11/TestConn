using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestConn
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试数据库连接，访问数据
            //1、准备数据库连接的字符串
            string connString = "Data Source=.;Initial Catalog=Myshool;User ID=sa;Password=1234";
            //2、创建数据库连接对象SqlConnection ,并且打开连接
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //3、创建执行对象SqlConnand
            SqlCommand command = new SqlCommand("select StudentNo,StudentName from student", conn);
            //4、执行语句，返回结果/结果集
            SqlDataReader reader = command.ExecuteReader();
            //5、处理结果（打印输出）
            Console.WriteLine("学号\t姓名");
            while (reader.Read())
            {
                string stuNo = reader["StudentNo"].ToString();
                string stuName = reader["StudentName"].ToString();
                Console.WriteLine("stuNo+\t+stuName");
            }
            //6、关闭连接或其他资源
            conn.Close();
        }
    }
}
