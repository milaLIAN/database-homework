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
    public partial class frmAdminDeny : Form
    {
        public frmAdminDeny()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAdmin frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(this.txtUserID.Text);
            int bid = Convert.ToInt32(this.txtBookID.Text);
            int aid = Convert.ToInt32(this.txtAID.Text);
            string ptype = comType.Text.ToString();
            int isDeny = (IsRadio.Checked == true)? 1 : 0;

            MySqlConnection conn = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");

            conn.Open();

            string str = String.Format("insert into Problem_Info values(null,{0},{1},{2},'{3}',{4});", uid,bid,aid,ptype,isDeny);

            MessageBox.Show(str);
            MySqlCommand cmd = new MySqlCommand(str, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string st = "select * from Problem_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(st, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView1.DataSource = dt;
        }

        private void frmAdminDeny_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string st = "select * from Problem_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(st, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView1.DataSource = dt;
        }
    }
}
