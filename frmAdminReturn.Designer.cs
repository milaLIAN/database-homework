namespace BookManagement
{
    partial class frmAdminReturn
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataTime = new System.Windows.Forms.DateTimePicker();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.labUserID = new System.Windows.Forms.Label();
            this.labBookID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comTip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labTip = new System.Windows.Forms.Label();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnProblem = new System.Windows.Forms.Button();
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
            this.groupBox1.Size = new System.Drawing.Size(390, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已处理归还业务";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(407, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "待处理归还业务";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnProblem);
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
            this.groupBox3.Location = new System.Drawing.Point(408, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 240);
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
            this.dataGridView1.Size = new System.Drawing.Size(384, 440);
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
            this.dataGridView2.Size = new System.Drawing.Size(405, 193);
            this.dataGridView2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "时间：";
            // 
            // dataTime
            // 
            this.dataTime.Location = new System.Drawing.Point(115, 111);
            this.dataTime.Name = "dataTime";
            this.dataTime.Size = new System.Drawing.Size(180, 25);
            this.dataTime.TabIndex = 24;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(307, 65);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 25);
            this.txtUserID.TabIndex = 23;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(307, 24);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 25);
            this.txtBookID.TabIndex = 22;
            // 
            // labUserID
            // 
            this.labUserID.AutoSize = true;
            this.labUserID.Location = new System.Drawing.Point(219, 68);
            this.labUserID.Name = "labUserID";
            this.labUserID.Size = new System.Drawing.Size(82, 15);
            this.labUserID.TabIndex = 21;
            this.labUserID.Text = "读者编号：";
            // 
            // labBookID
            // 
            this.labBookID.AutoSize = true;
            this.labBookID.Location = new System.Drawing.Point(219, 27);
            this.labBookID.Name = "labBookID";
            this.labBookID.Size = new System.Drawing.Size(82, 15);
            this.labBookID.TabIndex = 20;
            this.labBookID.Text = "图书编号：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(115, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 25);
            this.txtID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "管理员账号：";
            // 
            // comTip
            // 
            this.comTip.FormattingEnabled = true;
            this.comTip.Items.AddRange(new object[] {
            "通过",
            "损坏",
            "超期"});
            this.comTip.Location = new System.Drawing.Point(115, 24);
            this.comTip.Name = "comTip";
            this.comTip.Size = new System.Drawing.Size(80, 23);
            this.comTip.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "审批意见：";
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.ForeColor = System.Drawing.Color.Firebrick;
            this.labTip.Location = new System.Drawing.Point(145, 161);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(97, 15);
            this.labTip.TabIndex = 15;
            this.labTip.Text = "请谨慎操作！";
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(307, 198);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(74, 27);
            this.btnFalse.TabIndex = 14;
            this.btnFalse.Text = "退出";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(186, 200);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(76, 27);
            this.btnPass.TabIndex = 13;
            this.btnPass.Text = "确认";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnProblem
            // 
            this.btnProblem.Location = new System.Drawing.Point(53, 198);
            this.btnProblem.Name = "btnProblem";
            this.btnProblem.Size = new System.Drawing.Size(90, 27);
            this.btnProblem.TabIndex = 26;
            this.btnProblem.Text = "问题记录";
            this.btnProblem.UseVisualStyleBackColor = true;
            this.btnProblem.Click += new System.EventHandler(this.btnProblem_Click);
            // 
            // frmAdminReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 477);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdminReturn";
            this.Text = "归还业务处理";
            this.Load += new System.EventHandler(this.frmAdminReturn_Load);
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataTime;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label labUserID;
        private System.Windows.Forms.Label labBookID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnProblem;
    }
}