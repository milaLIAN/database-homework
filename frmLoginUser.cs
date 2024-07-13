using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class frmLoginUser : Form
    {
        public frmLoginUser()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void 图书借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserBorrow frmUserBorrow = new frmUserBorrow();
            frmUserBorrow.Show();
        }

        private void 图书归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserReturn frmUserReturn = new frmUserReturn();
            frmUserReturn.Show();
        }

        private void 系统信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmError frmError = new frmError();
            frmError.Show();
        }
    }
}
