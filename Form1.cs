using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BookManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text != string.Empty && this.txtPwd.Text != string.Empty)
            {
                string state = this.cboUserType.Text; ;
                int num;
                if (state.Equals("管理员"))
                    num = 1;
                else
                    num = 2;

                string sql = string.Format("select * from User_Info where UID='{0}' and UPwd = '{1}' and UState = {2}", this.txtName.Text.Trim(), this.txtPwd.Text.Trim(), num);

                MySqlConnection conn = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d");
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(sql,conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                conn.Close();

                if (num==1&&dt.Rows.Count>0)
                {
                    MessageBox.Show("登录成功，欢迎进入管理员页面！");
                    this.Hide();
                    frmLoginAdmin frmLoginAdmin = new frmLoginAdmin(); 
                    frmLoginAdmin.Show();

                }
                else if(num== 2&&dt.Rows.Count > 0)
                {
                    MessageBox.Show("登录成功，欢迎进入用户页面！");
                    this.Hide();
                    frmLoginUser frmLoginUser = new frmLoginUser();
                    frmLoginUser.Show();
                }
                else
                { 
                    MessageBox.Show("用户名或密码错误！");
                }
            }
            else
            {
                MessageBox.Show("用户名或密码为空！");
            }
        }

        private void btnCancelClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
