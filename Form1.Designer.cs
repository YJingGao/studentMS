namespace dazuoye2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabelregister = new System.Windows.Forms.LinkLabel();
            this.linkLabelchange = new System.Windows.Forms.LinkLabel();
            this.labelcode = new System.Windows.Forms.Label();
            this.textBoxcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonadmin = new System.Windows.Forms.RadioButton();
            this.radioButtonstudent = new System.Windows.Forms.RadioButton();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelregister
            // 
            this.linkLabelregister.AutoSize = true;
            this.linkLabelregister.Location = new System.Drawing.Point(31, 364);
            this.linkLabelregister.Name = "linkLabelregister";
            this.linkLabelregister.Size = new System.Drawing.Size(82, 15);
            this.linkLabelregister.TabIndex = 77;
            this.linkLabelregister.TabStop = true;
            this.linkLabelregister.Text = "新用户注册";
            this.linkLabelregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelregister_LinkClicked);
            // 
            // linkLabelchange
            // 
            this.linkLabelchange.AutoSize = true;
            this.linkLabelchange.Location = new System.Drawing.Point(396, 237);
            this.linkLabelchange.Name = "linkLabelchange";
            this.linkLabelchange.Size = new System.Drawing.Size(112, 15);
            this.linkLabelchange.TabIndex = 76;
            this.linkLabelchange.TabStop = true;
            this.linkLabelchange.Text = "看不清，换一张";
            this.linkLabelchange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelchange_LinkClicked);
            // 
            // labelcode
            // 
            this.labelcode.AutoSize = true;
            this.labelcode.BackColor = System.Drawing.SystemColors.Info;
            this.labelcode.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelcode.Location = new System.Drawing.Point(311, 235);
            this.labelcode.Name = "labelcode";
            this.labelcode.Size = new System.Drawing.Size(69, 19);
            this.labelcode.TabIndex = 75;
            this.labelcode.Text = "label4";
            this.labelcode.Click += new System.EventHandler(this.labelcode_Click);
            // 
            // textBoxcode
            // 
            this.textBoxcode.Location = new System.Drawing.Point(107, 232);
            this.textBoxcode.Name = "textBoxcode";
            this.textBoxcode.Size = new System.Drawing.Size(179, 25);
            this.textBoxcode.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "若是首次登录请先注册信息！";
            // 
            // radioButtonadmin
            // 
            this.radioButtonadmin.AutoSize = true;
            this.radioButtonadmin.Location = new System.Drawing.Point(213, 286);
            this.radioButtonadmin.Name = "radioButtonadmin";
            this.radioButtonadmin.Size = new System.Drawing.Size(73, 19);
            this.radioButtonadmin.TabIndex = 72;
            this.radioButtonadmin.TabStop = true;
            this.radioButtonadmin.Text = "管理员";
            this.radioButtonadmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonstudent
            // 
            this.radioButtonstudent.AutoSize = true;
            this.radioButtonstudent.Location = new System.Drawing.Point(33, 286);
            this.radioButtonstudent.Name = "radioButtonstudent";
            this.radioButtonstudent.Size = new System.Drawing.Size(58, 19);
            this.radioButtonstudent.TabIndex = 71;
            this.radioButtonstudent.TabStop = true;
            this.radioButtonstudent.Text = "学生";
            this.radioButtonstudent.UseVisualStyleBackColor = true;
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(332, 345);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(73, 40);
            this.buttonclose.TabIndex = 70;
            this.buttonclose.Text = "退出";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(181, 345);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(78, 40);
            this.buttonlogin.TabIndex = 69;
            this.buttonlogin.Text = "登录";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(107, 184);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(179, 25);
            this.textBoxpassword.TabIndex = 68;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(107, 137);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(179, 25);
            this.textBoxusername.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "验证码：";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelpassword.Location = new System.Drawing.Point(21, 187);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(73, 15);
            this.labelpassword.TabIndex = 65;
            this.labelpassword.Text = "密  码：";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelusername.Location = new System.Drawing.Point(21, 140);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(71, 15);
            this.labelusername.TabIndex = 64;
            this.labelusername.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 60);
            this.label1.TabIndex = 63;
            this.label1.Text = "学生管理系统";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.linkLabelregister);
            this.Controls.Add(this.linkLabelchange);
            this.Controls.Add(this.labelcode);
            this.Controls.Add(this.textBoxcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonadmin);
            this.Controls.Add(this.radioButtonstudent);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelregister;
        private System.Windows.Forms.LinkLabel linkLabelchange;
        private System.Windows.Forms.Label labelcode;
        private System.Windows.Forms.TextBox textBoxcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonadmin;
        private System.Windows.Forms.RadioButton radioButtonstudent;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label label1;
    }
}

