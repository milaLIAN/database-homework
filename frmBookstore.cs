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
    public partial class frmBookstore : Form
    {
        public frmBookstore()
        {
            InitializeComponent();
        }

        private void frmBookstore_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d");
            con.Open();

            string st = "select * from Bookstore_Info";
            MySqlDataAdapter da = new MySqlDataAdapter(st, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Close();

            // 将 DataTable 绑定到 DataGridView
            dataGridView1.DataSource = dt;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginAdmin frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bsname = txtName.Text;
            string bsaddress = txtAddress.Text;
            string bsphone = txtPhone.Text;

            MySqlConnection conn = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            conn.Open();

            string str = String.Format("insert into Bookstore_Info values(null,'{0}','{1}','{2}');", bsname, bsaddress, bsphone);

            //MessageBox.Show(str);
            MySqlCommand cmd = new MySqlCommand(str, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i > 0)
            {
                labTip.Text = "添加成功！";
                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                conn.Open();

                string st = "select * from Bookstore_Info";
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                con.Open();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int uid = (int)selectedRow.Cells["BSID"].Value;
                string str = String.Format("DELETE FROM Bookstore_Info WHERE BSID = {0};", uid);
                MySqlCommand cmd = new MySqlCommand(str, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    labTip.Text = "删除成功！";
                    MySqlConnection co = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                    con.Open();

                    string st = "select * from Bookstore_Info";
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
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                int BSID = (int)selectedRow.Cells["BSID"].Value;
                string bsname = selectedRow.Cells["BSName"].Value.ToString();
                string bsaddress = selectedRow.Cells["BSAddress"].Value.ToString();
                string bsphone = selectedRow.Cells["BSPhone"].Value.ToString();
           

                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                con.Open();

                //string str = String.Format("UPDATE Bookstore_Info SET BSName = '{0}',BSAddress = '{1}', BSPhone = '{2} WHERE BSID = {3}", bsname,bsaddress,bsphone,BSID);
                string str = String.Format("UPDATE Bookstore_Info SET BSName = '{0}', BSAddress = '{1}', BSPhone = '{2}' WHERE BSID = {3}", bsname, bsaddress, bsphone, BSID);

                MySqlCommand cmd = new MySqlCommand(str, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    labTip.Text = "修改成功!";
                    MySqlConnection conm = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                    conm.Open();

                    string st = "select * from Bookstore_Info";
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
