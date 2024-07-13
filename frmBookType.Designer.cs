namespace BookManagement
{
    partial class frmBookType
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.labNum = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labBContent = new System.Windows.Forms.Label();
            this.labBPrice = new System.Windows.Forms.Label();
            this.labBAuthor = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.labTip = new System.Windows.Forms.Label();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(445, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书馆藏信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.labNum);
            this.groupBox2.Controls.Add(this.txtContent);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtAuthor);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.labBContent);
            this.groupBox2.Controls.Add(this.labBPrice);
            this.groupBox2.Controls.Add(this.labBAuthor);
            this.groupBox2.Controls.Add(this.lab);
            this.groupBox2.Controls.Add(this.labTip);
            this.groupBox2.Controls.Add(this.btnFalse);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书馆藏管理";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(103, 212);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(191, 25);
            this.txtNum.TabIndex = 28;
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Location = new System.Drawing.Point(15, 215);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(82, 15);
            this.labNum.TabIndex = 27;
            this.labNum.Text = "存储数量：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(103, 175);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(191, 25);
            this.txtContent.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(103, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 25);
            this.txtPrice.TabIndex = 25;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(103, 85);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(191, 25);
            this.txtAuthor.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 25);
            this.txtName.TabIndex = 22;
            // 
            // labBContent
            // 
            this.labBContent.AutoSize = true;
            this.labBContent.Location = new System.Drawing.Point(15, 178);
            this.labBContent.Name = "labBContent";
            this.labBContent.Size = new System.Drawing.Size(52, 15);
            this.labBContent.TabIndex = 21;
            this.labBContent.Text = "简介：";
            // 
            // labBPrice
            // 
            this.labBPrice.AutoSize = true;
            this.labBPrice.Location = new System.Drawing.Point(15, 135);
            this.labBPrice.Name = "labBPrice";
            this.labBPrice.Size = new System.Drawing.Size(52, 15);
            this.labBPrice.TabIndex = 20;
            this.labBPrice.Text = "价格：";
            // 
            // labBAuthor
            // 
            this.labBAuthor.AutoSize = true;
            this.labBAuthor.Location = new System.Drawing.Point(15, 88);
            this.labBAuthor.Name = "labBAuthor";
            this.labBAuthor.Size = new System.Drawing.Size(52, 15);
            this.labBAuthor.TabIndex = 19;
            this.labBAuthor.Text = "作者：";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(15, 40);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(52, 15);
            this.lab.TabIndex = 17;
            this.lab.Text = "书名：";
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.ForeColor = System.Drawing.Color.Red;
            this.labTip.Location = new System.Drawing.Point(119, 397);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(97, 15);
            this.labTip.TabIndex = 15;
            this.labTip.Text = "请谨慎操作！";
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(174, 348);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(75, 33);
            this.btnFalse.TabIndex = 14;
            this.btnFalse.Text = "退出";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(174, 310);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 32);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(63, 310);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 32);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "修改";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBookType";
            this.Text = "图书馆藏管理";
            this.Load += new System.EventHandler(this.frmBookType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labBContent;
        private System.Windows.Forms.Label labBPrice;
        private System.Windows.Forms.Label labBAuthor;
        private System.Windows.Forms.Label lab;
    }
}