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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void toolStripckcj_Click(object sender, EventArgs e)
        {
            Frmchaxun cx = new Frmchaxun();
            cx.Show();
        }

        private void tsmtc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
