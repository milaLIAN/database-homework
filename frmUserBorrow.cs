using MySql.Data.MySqlClient;
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
    public partial class frmUserBorrow : Form
    {
        public frmUserBorrow()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginUser frmLoginUser = new frmLoginUser();
            frmLoginUser.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string bookname = txtSearch.Text;

            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string str = String.Format("select * from BookAll where BookName like '%{0}%'", bookname);

            MySqlDataAdapter da = new MySqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView2.DataSource = dt;

            labTip.Text = "搜索成功！";

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(txtUserID.Text);
            int BAID = Convert.ToInt32(txtBookID.Text);

            DataGridViewRow selectedRow = dataGridView2.CurrentRow;

            int booknum = (int)selectedRow.Cells["BANum"].Value;

            if(booknum>0)
            {
                string str = String.Format("insert into Ask_Borrowed_Books values (null,{0},{1},null)",uid,BAID);

                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                con.Open();

                MySqlCommand cmd = new MySqlCommand(str, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if(i>0)
                {
                    string st = "select * from Ask_Borrowed_Books;";
                    MySqlDataAdapter da = new MySqlDataAdapter(st, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    con.Close();

                    // 将 DataTable 绑定到 DataGridView
                    dataGridView1.DataSource = dt;

                    labTip.Text = "申请借阅成功！";
                }
                else
                {
                    labTip.Text = "申请借阅失败！";
                }
            }
            else
            {
                labTip.Text = "当前无馆藏！";
            }
        }
    }
}
