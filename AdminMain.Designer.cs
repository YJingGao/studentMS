namespace dazuoye2
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttoninfo = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonsc = new System.Windows.Forms.Button();
            this.buttoncourse = new System.Windows.Forms.Button();
            this.buttonstudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonpassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(302, 408);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(67, 50);
            this.buttonclose.TabIndex = 17;
            this.buttonclose.Text = "关闭";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttoninfo
            // 
            this.buttoninfo.Location = new System.Drawing.Point(223, 289);
            this.buttoninfo.Name = "buttoninfo";
            this.buttoninfo.Size = new System.Drawing.Size(84, 73);
            this.buttoninfo.TabIndex = 16;
            this.buttoninfo.Text = "个人信息";
            this.buttoninfo.UseVisualStyleBackColor = true;
            this.buttoninfo.Click += new System.EventHandler(this.buttoninfo_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(76, 289);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(83, 73);
            this.buttonlogin.TabIndex = 15;
            this.buttonlogin.Text = "登录日志";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonsc
            // 
            this.buttonsc.Location = new System.Drawing.Point(384, 178);
            this.buttonsc.Name = "buttonsc";
            this.buttonsc.Size = new System.Drawing.Size(101, 67);
            this.buttonsc.TabIndex = 14;
            this.buttonsc.Text = "学生-课程";
            this.buttonsc.UseVisualStyleBackColor = true;
            this.buttonsc.Click += new System.EventHandler(this.buttonsc_Click);
            // 
            // buttoncourse
            // 
            this.buttoncourse.Location = new System.Drawing.Point(223, 175);
            this.buttoncourse.Name = "buttoncourse";
            this.buttoncourse.Size = new System.Drawing.Size(84, 70);
            this.buttoncourse.TabIndex = 13;
            this.buttoncourse.Text = "课程";
            this.buttoncourse.UseVisualStyleBackColor = true;
            this.buttoncourse.Click += new System.EventHandler(this.buttoncourse_Click);
            // 
            // buttonstudent
            // 
            this.buttonstudent.Location = new System.Drawing.Point(75, 173);
            this.buttonstudent.Name = "buttonstudent";
            this.buttonstudent.Size = new System.Drawing.Size(84, 72);
            this.buttonstudent.TabIndex = 12;
            this.buttonstudent.Text = "学生";
            this.buttonstudent.UseVisualStyleBackColor = true;
            this.buttonstudent.Click += new System.EventHandler(this.buttonstudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "请选择您要进行的操作：";
            // 
            // buttonpassword
            // 
            this.buttonpassword.Location = new System.Drawing.Point(384, 289);
            this.buttonpassword.Name = "buttonpassword";
            this.buttonpassword.Size = new System.Drawing.Size(101, 73);
            this.buttonpassword.TabIndex = 19;
            this.buttonpassword.Text = "修改密码";
            this.buttonpassword.UseVisualStyleBackColor = true;
            this.buttonpassword.Click += new System.EventHandler(this.buttonpassword_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttoninfo);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.buttonsc);
            this.Controls.Add(this.buttoncourse);
            this.Controls.Add(this.buttonstudent);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttoninfo;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonsc;
        private System.Windows.Forms.Button buttoncourse;
        private System.Windows.Forms.Button buttonstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonpassword;
        private System.Windows.Forms.Button button1;
    }
}