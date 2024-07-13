using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace BookManagement
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }


        private void frmReader_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d");
            conn.Open();

            string str = "select * from User_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView1.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            conn.Open();

            string UName = this.txtUName.Text.ToString();
            string UPwd = this.txtPwd.Text.Trim();
            string UPhone = this.txtPhone.Text.Trim();
            int UState = rdoAdmin.Checked ? 1: 2;
            //string str = String.Format("insert into User_Info values(null,'{0}','{1}',{2},{3});",UName,UPwd,UPhone,UState);
            string str = String.Format("insert into User_Info values(null,'{0}','{1}','{2}',{3});", UName, UPwd, UPhone, UState);

            //MessageBox.Show(str);
            MySqlCommand cmd = new MySqlCommand(str, conn); 
            int i = cmd.ExecuteNonQuery(); 
            conn.Close();

            if(i>0)
            {
                labTip.Text = "添加成功！";
                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                conn.Open();

                string st = "select * from User_Info";
                MySqlDataAdapter da = new MySqlDataAdapter(st, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conn.Close();

                // 将 DataTable 绑定到 DataGridView
                dataGridView1.DataSource = dt;
            }
            else
            {
                labTip.Text = "添加失败！";
            }
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAdmin frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                con.Open();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                
                int uid = (int)selectedRow.Cells["UID"].Value;
                string str = String.Format("DELETE FROM User_Info WHERE UID = {0};",uid );
                MySqlCommand cmd = new MySqlCommand(str, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if(i>0)
                {
                    labTip.Text = "删除成功！";
                    MySqlConnection co = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                    con.Open();

                    string st = "select * from User_Info";
                    MySqlDataAdapter da = new MySqlDataAdapter(st, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    con.Close();

                    // 将 DataTable 绑定到 DataGridView
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    labTip.Text = "删除失败！";
                }


            }
            else
            {
                // 没有选中的行
                //MessageBox.Show("请选择要操作的行！");
                labTip.Text = "请选择要操作的行！";
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                int uid = (int)selectedRow.Cells["UID"].Value;
                string UName = selectedRow.Cells["UName"].Value.ToString();
                string UPwd = selectedRow.Cells["UPwd"].Value.ToString();
                string UPhone = selectedRow.Cells["UPhone"].Value.ToString();
                int USate = (int)selectedRow.Cells["UState"].Value;

                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d ;charset=utf8");
                con.Open();

                string str = String.Format("UPDATE User_Info SET UName = '{0}',UPwd = '{1}', UPhone = '{2}', UState = {3} WHERE UID = {4}", UName, UPwd, UPhone, USate, uid);

                MySqlCommand cmd = new MySqlCommand(str, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    labTip.Text = "修改成功!";
                    MySqlConnection conm = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                    conm.Open();

                    string st = "select * from User_Info";
                    MySqlDataAdapter da = new MySqlDataAdapter(st, conm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    conm.Close();

                    // 将 DataTable 绑定到 DataGridView
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    labTip.Text = "修改失败!";
                }
            }
            else
            {
                MessageBox.Show("请选择要修改的行!");
            }
          

        }
    }
}
