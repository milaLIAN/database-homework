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
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void 查看读者信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReader reader = new frmReader();
            reader.Show();
        }

        private void 图书信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBook book = new frmBook();
            book.Show();
        }

        private void 图书馆藏信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookType bookType = new frmBookType();
            bookType.Show();
        }

        private void 出版社信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookstore bookstore = new frmBookstore();
            bookstore.Show();
        }

        private void 办理借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminBorrow borrow = new frmAdminBorrow();
            borrow.Show();
        }

        private void 办理归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminReturn frmAdminReturn = new frmAdminReturn();
            frmAdminReturn.Show();
        }
    }
}
