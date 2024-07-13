namespace BookManagement
{
    partial class frmLoginAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.读者信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看读者信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出版社信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书馆藏信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书借阅管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.办理借阅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.办理归还ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者信息管理ToolStripMenuItem,
            this.出版社信息管理ToolStripMenuItem,
            this.图书信息管理ToolStripMenuItem,
            this.图书馆藏信息ToolStripMenuItem,
            this.图书借阅管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 读者信息管理ToolStripMenuItem
            // 
            this.读者信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看读者信息ToolStripMenuItem,
            this.个人信息栏ToolStripMenuItem});
            this.读者信息管理ToolStripMenuItem.Name = "读者信息管理ToolStripMenuItem";
            this.读者信息管理ToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.读者信息管理ToolStripMenuItem.Text = " 用户信息管理";
            // 
            // 查看读者信息ToolStripMenuItem
            // 
            this.查看读者信息ToolStripMenuItem.Name = "查看读者信息ToolStripMenuItem";
            this.查看读者信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查看读者信息ToolStripMenuItem.Text = " 读者信息栏";
            this.查看读者信息ToolStripMenuItem.Click += new System.EventHandler(this.查看读者信息ToolStripMenuItem_Click);
            // 
            // 出版社信息管理ToolStripMenuItem
            // 
            this.出版社信息管理ToolStripMenuItem.Name = "出版社信息管理ToolStripMenuItem";
            this.出版社信息管理ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.出版社信息管理ToolStripMenuItem.Text = "出版社信息管理";
            this.出版社信息管理ToolStripMenuItem.Click += new System.EventHandler(this.出版社信息管理ToolStripMenuItem_Click);
            // 
            // 图书信息管理ToolStripMenuItem
            // 
            this.图书信息管理ToolStripMenuItem.Name = "图书信息管理ToolStripMenuItem";
            this.图书信息管理ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.图书信息管理ToolStripMenuItem.Text = "图书信息管理";
            this.图书信息管理ToolStripMenuItem.Click += new System.EventHandler(this.图书信息管理ToolStripMenuItem_Click);
            // 
            // 图书馆藏信息ToolStripMenuItem
            // 
            this.图书馆藏信息ToolStripMenuItem.Name = "图书馆藏信息ToolStripMenuItem";
            this.图书馆藏信息ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.图书馆藏信息ToolStripMenuItem.Text = "图书馆藏信息";
            this.图书馆藏信息ToolStripMenuItem.Click += new System.EventHandler(this.图书馆藏信息ToolStripMenuItem_Click);
            // 
            // 图书借阅管理ToolStripMenuItem
            // 
            this.图书借阅管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.办理借阅ToolStripMenuItem,
            this.办理归还ToolStripMenuItem});
            this.图书借阅管理ToolStripMenuItem.Name = "图书借阅管理ToolStripMenuItem";
            this.图书借阅管理ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.图书借阅管理ToolStripMenuItem.Text = " 业务管理";
            // 
            // 办理借阅ToolStripMenuItem
            // 
            this.办理借阅ToolStripMenuItem.Name = "办理借阅ToolStripMenuItem";
            this.办理借阅ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.办理借阅ToolStripMenuItem.Text = "办理借阅";
            this.办理借阅ToolStripMenuItem.Click += new System.EventHandler(this.办理借阅ToolStripMenuItem_Click);
            // 
            // 办理归还ToolStripMenuItem
            // 
            this.办理归还ToolStripMenuItem.Name = "办理归还ToolStripMenuItem";
            this.办理归还ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.办理归还ToolStripMenuItem.Text = "办理归还";
            this.办理归还ToolStripMenuItem.Click += new System.EventHandler(this.办理归还ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 个人信息栏ToolStripMenuItem
            // 
            this.个人信息栏ToolStripMenuItem.Name = "个人信息栏ToolStripMenuItem";
            this.个人信息栏ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.个人信息栏ToolStripMenuItem.Text = "个人信息栏";
            // 
            // frmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLoginAdmin";
            this.Text = "管理员界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 读者信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看读者信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出版社信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书馆藏信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书借阅管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 办理借阅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 办理归还ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}