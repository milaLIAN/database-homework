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
    public partial class frmAdminReturn : Form
    {
        public frmAdminReturn()
        {
            InitializeComponent();
        }

        private void frmAdminReturn_Load(object sender, EventArgs e)
        {
            string str = "SELECT\r\n ARB.ARID AS '申请归还编号',   UI.UID AS '读者ID',\r\n    UI.UName AS '读者姓名',\r\n    UI.UName AS '联系电话',\r\n    BA.BookName AS '图书名称',\r\n BA.BAID AS '图书ID',    BA.BookAuthor AS '作者',\r\n    BA.BookPrice AS '价格',\r\n    BA.BookContent AS '简介'\r\nFROM\r\n    Ask_Returned_Books ARB\r\nJOIN\r\n    User_Info UI ON ARB.UID = UI.UID\r\nJOIN\r\n    BookAll BA ON ARB.BAID = BA.BAID;";

            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView2.DataSource = dt;
        }

        protected void Yes_Load_date()
        {
            string str = "SELECT\r\n ARB.ARID AS '申请归还编号',   UI.UID AS '读者ID',\r\n    UI.UName AS '读者姓名',\r\n    UI.UName AS '联系电话',\r\n    BA.BookName AS '图书名称',\r\n BA.BAID AS '图书ID',    BA.BookAuthor AS '作者',\r\n    BA.BookPrice AS '价格',\r\n    BA.BookContent AS '简介'\r\nFROM\r\n    Ask_Returned_Books ARB\r\nJOIN\r\n    User_Info UI ON ARB.UID = UI.UID\r\nJOIN\r\n    BookAll BA ON ARB.BAID = BA.BAID;";

            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView2.DataSource = dt;
        }

        //加载处理好的信息
        protected void Yes_Load_Return()
        {
            string str = "select * from Returned_Books;";
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView1.DataSource = dt;
        }

        //删除处理好的申请信息
        protected void Yes_Del_Return()
        {
            DataGridViewRow selectedRow = dataGridView2.CurrentRow;

            int abbid = (int)selectedRow.Cells["申请归还编号"].Value;

            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string str = String.Format("delete from Ask_Returned_Books where {0}", abbid);

            MySqlCommand cmd = new MySqlCommand(str, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnProblem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminDeny frmAdminDeny = new frmAdminDeny();
            frmAdminDeny.Show();
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAdmin frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
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

            string str = String.Format("insert into Returned_Books values (null,{0},{1},{2},'{3}','{4}')", baid, uid, aid, datetime, text);
            MySqlCommand cmd = new MySqlCommand(str, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                Yes_Del_Return();
                labTip.Text = "归还业务处理成功！";
                Yes_Load_Return();
                Yes_Load_date();
                

            }
        }
    }
}
