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
    public partial class FrmSearchStudent1 : Form
    {

        public FrmSearchStudent1()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSearchStudent1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“myshoolDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.myshoolDataSet.Student);

        }
    }
}
