namespace BookManagement
{
    partial class frmBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab = new System.Windows.Forms.Label();
            this.labBType = new System.Windows.Forms.Label();
            this.labBAuthor = new System.Windows.Forms.Label();
            this.labBPrice = new System.Windows.Forms.Label();
            this.labBContent = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.labTip = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labTip);
            this.groupBox2.Controls.Add(this.btnFalse);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.txtContent);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtAuthor);
            this.groupBox2.Controls.Add(this.txtType);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.labBContent);
            this.groupBox2.Controls.Add(this.labBPrice);
            this.groupBox2.Controls.Add(this.labBAuthor);
            this.groupBox2.Controls.Add(this.labBType);
            this.groupBox2.Controls.Add(this.lab);
            this.groupBox2.Location = new System.Drawing.Point(461, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书管理";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(422, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(35, 49);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(52, 15);
            this.lab.TabIndex = 0;
            this.lab.Text = "书名：";
            // 
            // labBType
            // 
            this.labBType.AutoSize = true;
            this.labBType.Location = new System.Drawing.Point(35, 90);
            this.labBType.Name = "labBType";
            this.labBType.Size = new System.Drawing.Size(82, 15);
            this.labBType.TabIndex = 1;
            this.labBType.Text = "图书类型：";
            // 
            // labBAuthor
            // 
            this.labBAuthor.AutoSize = true;
            this.labBAuthor.Location = new System.Drawing.Point(35, 137);
            this.labBAuthor.Name = "labBAuthor";
            this.labBAuthor.Size = new System.Drawing.Size(52, 15);
            this.labBAuthor.TabIndex = 2;
            this.labBAuthor.Text = "作者：";
            // 
            // labBPrice
            // 
            this.labBPrice.AutoSize = true;
            this.labBPrice.Location = new System.Drawing.Point(35, 184);
            this.labBPrice.Name = "labBPrice";
            this.labBPrice.Size = new System.Drawing.Size(52, 15);
            this.labBPrice.TabIndex = 3;
            this.labBPrice.Text = "价格：";
            // 
            // labBContent
            // 
            this.labBContent.AutoSize = true;
            this.labBContent.Location = new System.Drawing.Point(35, 227);
            this.labBContent.Name = "labBContent";
            this.labBContent.Size = new System.Drawing.Size(52, 15);
            this.labBContent.TabIndex = 4;
            this.labBContent.Text = "简介：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 25);
            this.txtName.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(116, 90);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(191, 25);
            this.txtType.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(116, 134);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(191, 25);
            this.txtAuthor.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(116, 181);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(191, 25);
            this.txtPrice.TabIndex = 8;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(116, 224);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(191, 25);
            this.txtContent.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(72, 288);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(81, 33);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "修改";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(191, 288);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(84, 33);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 34);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(191, 341);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(84, 34);
            this.btnFalse.TabIndex = 13;
            this.btnFalse.Text = "退出";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.ForeColor = System.Drawing.Color.Red;
            this.labTip.Location = new System.Drawing.Point(128, 390);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(97, 15);
            this.labTip.TabIndex = 14;
            this.labTip.Text = "请谨慎操作！";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBook";
            this.Text = "图书管理";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labBContent;
        private System.Windows.Forms.Label labBPrice;
        private System.Windows.Forms.Label labBAuthor;
        private System.Windows.Forms.Label labBType;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label labTip;
    }
}