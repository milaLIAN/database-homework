﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string booktype = this.txtType.Text.ToString();
            string bookname = this.txtName.Text.ToString();
            string bookauthor = this.txtAuthor.Text.ToString();
            double bookprice = Convert.ToDouble(this.txtPrice.Text);
            string bookcontent = this.txtContent.Text.ToString();

            //MySqlConnection conn = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d");
            MySqlConnection conn = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");

            conn.Open();

            string str = String.Format("insert into Book_Info values(null,'{0}','{1}','{2}',{3},'{4}');", bookname, booktype, bookauthor, bookprice, bookcontent);

            //MessageBox.Show(str);
            MySqlCommand cmd = new MySqlCommand(str, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i > 0)
            {
                labTip.Text = "添加成功！";
                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                conn.Open();

                string st = "select * from Book_Info";
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

        private void frmBook_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
            con.Open();

            string st = "select * from Book_Info";
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;;charset=utf8");
                con.Open();
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                //int uid = (int)selectedRow.Cells["BookID"].Value;
                long bookID = Convert.ToInt64(selectedRow.Cells["BookID"].Value);
                string str = String.Format("DELETE FROM Book_Info WHERE BookID = {0};", bookID);
                MySqlCommand cmd = new MySqlCommand(str, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    labTip.Text = "删除成功！";
                    MySqlConnection co = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                    con.Open();

                    string st = "select * from Book_Info";
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

        //private void btnCheck_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentRow != null)
        //    {
        //        DataGridViewRow selectedRow = dataGridView1.CurrentRow;

        //        int bookID = (int)selectedRow.Cells["BookID"].Value;
        //        string bookname = selectedRow.Cells["BookName"].Value.ToString();
        //        string booktype = selectedRow.Cells["BookType"].Value.ToString();
        //        string bookauthor = selectedRow.Cells["BookAuthor"].Value.ToString();
        //        //double bookprice = (double)selectedRow.Cells["BookPrice"].Value;
        //        double bookprice = Convert.ToDouble(selectedRow.Cells["BookPrice"].Value);

        //        string bookcontent = selectedRow.Cells["BookContent"].Value.ToString();

        //        MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d; charset = utf8");
        //        con.Open();

        //        string str = String.Format("UPDATE Book_Info SET BookName = '{0}',BookType = '{1}', BookAuthor = '{2}', BookPrice = {3} , BookContent = '{4}'WHERE BookID = {5}", bookname, booktype, bookauthor, bookprice, bookcontent,bookID);

        //        MySqlCommand cmd = new MySqlCommand(str, con);
        //        int i = cmd.ExecuteNonQuery();
        //        con.Close();

        //        if (i > 0)
        //        {
        //            labTip.Text = "修改成功!";
        //            MySqlConnection conm = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
        //            conm.Open();

        //            string st = "select * from Book_Info";
        //            MySqlDataAdapter da = new MySqlDataAdapter(st, conm);
        //            DataTable dt = new DataTable();
        //            da.Fill(dt);

        //            conm.Close();

        //            // 将 DataTable 绑定到 DataGridView
        //            dataGridView1.DataSource = dt;
        //        }
        //        else
        //        {
        //            labTip.Text = "修改失败!";
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("请选择要修改的行!");
        //    }
        //}
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // 使用 Convert.ToInt64 转换为 bigint 类型
                long bookID = Convert.ToInt64(selectedRow.Cells["BookID"].Value);

                string bookname = selectedRow.Cells["BookName"].Value.ToString();
                string booktype = selectedRow.Cells["BookType"].Value.ToString();
                string bookauthor = selectedRow.Cells["BookAuthor"].Value.ToString();

                // 使用 Convert.ToDouble 转换为 double 类型
                double bookprice = Convert.ToDouble(selectedRow.Cells["BookPrice"].Value);

                string bookcontent = selectedRow.Cells["BookContent"].Value.ToString();

                MySqlConnection con = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                con.Open();

                string str = String.Format("UPDATE Book_Info SET BookName = '{0}', BookType = '{1}', BookAuthor = '{2}', BookPrice = {3}, BookContent = '{4}' WHERE BookID = {5}", bookname, booktype, bookauthor, bookprice, bookcontent, bookID);

                MySqlCommand cmd = new MySqlCommand(str, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    labTip.Text = "修改成功!";
                    MySqlConnection conm = new MySqlConnection("data source=localhost;database=BookManage;user id=root;password=ig2neaLk&d;charset=utf8");
                    conm.Open();

                    string st = "select * from Book_Info";
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
