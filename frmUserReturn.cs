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
    public partial class frmUserReturn : Form
    {
        public frmUserReturn()
        {
            InitializeComponent();
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginUser frmLoginUser = new frmLoginUser();
            frmLoginUser.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string uid = txtUserID.Text;

            string st = String.Format("select * from Borrowed_Books where UID = {0};",uid);
            MySqlDataAdapter da = new MySqlDataAdapter(st, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView1.DataSource = dt;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(txtUserID.Text);
            int uid = Convert.ToInt32(txtUserID.Text);

            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            //string str = String.Format("insert into Ask_Returned_Books values (null,{0),{1});",uid,bookid);
            string str = String.Format("insert into Ask_Returned_Books values (null, {0}, {1});", uid, bookid);

            MySqlCommand mySqlCommand = new MySqlCommand(str, con);
            int i=mySqlCommand.ExecuteNonQuery();

            if(i>0)
            {
                Load_Return_Books();
                labTip.Text = "申请归还成功!";
            }
            else
            {
                labTip.Text = "申请归还失败！";
            }

        }

        protected void Load_Return_Books()
        {
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            int uid = Convert.ToInt32( txtUserID.Text);
            //string st = string.Format("select * form Ask_Returned_Books where UID = {0};",uid);
            string st = string.Format("select * from Ask_Returned_Books where UID = {0};", uid);

            MySqlDataAdapter da = new MySqlDataAdapter(st, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView2.DataSource = dt;
        }
    }
}
