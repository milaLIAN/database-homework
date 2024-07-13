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
    public partial class frmAdminBorrow : Form
    {
        public frmAdminBorrow()
        {
            InitializeComponent();
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAdmin frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
        }

        private void frmAdminBorrow_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            //string str = "select * from Ask_Borrowed_Books;";
            string str = "SELECT\r\n\tABB.ABBID as '申请借阅编号',UI.UID as 'ID',\r\n    UI.UName AS '读者名称',\r\n    BA.BookName as '图书名称',\r\n  BA.BAID as '图书ID',  BA.BookAuthor as '作者',\r\n    BA.BookPrice as '价格',\r\n    BA.BookContent as '简介'\r\nFROM\r\n    Ask_Borrowed_Books ABB\r\nJOIN\r\n    User_Info UI ON ABB.UID = UI.UID\r\nJOIN\r\n    BookAll BA ON ABB.BAID = BA.BAID;\r\n";

            MySqlDataAdapter da = new MySqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView2.DataSource = dt;
        }

        protected void Yes_Load_Date2()
        {
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            //string str = "select * from Ask_Borrowed_Books;";
            string str = "SELECT\r\n\tABB.ABBID as '申请借阅编号',UI.UID as 'ID',\r\n    UI.UName AS '读者名称',\r\n    BA.BookName as '图书名称',\r\n    BA.BookAuthor as '作者',\r\n    BA.BookPrice as '价格',\r\n    BA.BookContent as '简介'\r\nFROM\r\n    Ask_Borrowed_Books ABB\r\nJOIN\r\n    User_Info UI ON ABB.UID = UI.UID\r\nJOIN\r\n    BookAll BA ON ABB.BAID = BA.BAID;\r\n";

            MySqlDataAdapter da = new MySqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView2.DataSource = dt;
        }

        protected void Yes_Load_Data1()
        {
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string str = "select * from Borrowed_Books";

            MySqlDataAdapter da = new MySqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView1.DataSource = dt;
        }

        protected void Yes_Del()
        {
            DataGridViewRow selectedRow = dataGridView2.CurrentRow;

            int abbid = (int)selectedRow.Cells["申请借阅编号"].Value;

            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string str = String.Format("delete from Ask_Borrowed_Books where {0}",abbid);

            MySqlCommand cmd = new MySqlCommand(str, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

        }
        private void btnPass_Click(object sender, EventArgs e)
        {
            int baid = Convert.ToInt32(txtBookID.Text);
            int uid = Convert.ToInt32(txtUserID.Text);
            int aid = Convert.ToInt32(txtID.Text);
            string datetime = dataTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string text = comTip.Text;

            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string str = String.Format("insert into Borrowed_Books values (null,{0},{1},{2},'{3}','{4}')",baid,uid,aid,datetime,text);
            MySqlCommand cmd = new MySqlCommand(str,con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if(i>0)
            {
                Yes_Del();
                labTip.Text = "借阅业务处理成功！";
                Yes_Load_Data1();
                Yes_Load_Date2();

            }




        }
    }
}
