namespace BookManagement
{
    partial class frmAdminBorrow
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.labTip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comTip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labBookID = new System.Windows.Forms.Label();
            this.labUserID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.dataTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已处理业务";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待处理业务";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataTime);
            this.groupBox3.Controls.Add(this.txtUserID);
            this.groupBox3.Controls.Add(this.txtBookID);
            this.groupBox3.Controls.Add(this.labUserID);
            this.groupBox3.Controls.Add(this.labBookID);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comTip);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labTip);
            this.groupBox3.Controls.Add(this.btnFalse);
            this.groupBox3.Controls.Add(this.btnPass);
            this.groupBox3.Location = new System.Drawing.Point(367, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 181);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作面板";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(342, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(416, 233);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(228, 148);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(76, 27);
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "确认";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(326, 148);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(74, 27);
            this.btnFalse.TabIndex = 1;
            this.btnFalse.Text = "退出";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.ForeColor = System.Drawing.Color.Firebrick;
            this.labTip.Location = new System.Drawing.Point(260, 116);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(97, 15);
            this.labTip.TabIndex = 2;
            this.labTip.Text = "请谨慎操作！";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "审批意见：";
            // 
            // comTip
            // 
            this.comTip.FormattingEnabled = true;
            this.comTip.Items.AddRange(new object[] {
            "通过",
            "否决"});
            this.comTip.Location = new System.Drawing.Point(118, 34);
            this.comTip.Name = "comTip";
            this.comTip.Size = new System.Drawing.Size(80, 23);
            this.comTip.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "管理员账号：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 25);
            this.txtID.TabIndex = 6;
            // 
            // labBookID
            // 
            this.labBookID.AutoSize = true;
            this.labBookID.Location = new System.Drawing.Point(222, 37);
            this.labBookID.Name = "labBookID";
            this.labBookID.Size = new System.Drawing.Size(82, 15);
            this.labBookID.TabIndex = 7;
            this.labBookID.Text = "图书编号：";
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.Location = new System.Drawing.Point(222, 78);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(82, 15);
            this.labUserID.TabIndex = 8;
            this.labUserID.Text = "读者编号：";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(310, 34);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 25);
            this.txtBookID.TabIndex = 9;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(310, 75);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 25);
            this.txtUserID.TabIndex = 10;
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(18, 135);
            this.dataTime.Name = "dataTime";
            this.dataTime.Size = new System.Drawing.Size(180, 25);
            this.dataTime.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "时间：";
            // 
            // frmAdminBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdminBorrow";
            this.Text = "借阅业务处理";
            this.Load += new System.EventHandler(this.frmAdminBorrow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.Label labBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataTime;
    }
}