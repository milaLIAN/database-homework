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
            string username = txtName.Text.Trim();
            string password = txtPwd.Text.Trim();
            string userType = cboUserType.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }

            int userTypeCode = userType.Equals("管理员") ? 1 : 2;

            string connectionString = "server=localhost;database=BookManage;uid=root;pwd=1111;";
            string query = $"SELECT * FROM User_Info WHERE UID='{username}' AND UPwd='{password}' AND UState={userTypeCode}";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (userTypeCode == 1)
                        {
                            MessageBox.Show("登录成功，欢迎进入管理员页面！");
                            Hide();
                            frmLoginAdmin frmAdmin = new frmLoginAdmin();
                            frmAdmin.Show();
                        }
                        else if (userTypeCode == 2)
                        {
                            MessageBox.Show("登录成功，欢迎进入用户页面！");
                            Hide();
                            frmLoginUser frmUser = new frmLoginUser();
                            frmUser.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据库连接或查询出错：{ex.Message}");
            }
        }

        private void btnCancelClick_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
