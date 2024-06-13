namespace dazuoye2
{
    partial class StudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            this.buttoninfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttongrade = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttoncourse = new System.Windows.Forms.Button();
            this.buttonpassword = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoninfo
            // 
            this.buttoninfo.Location = new System.Drawing.Point(64, 143);
            this.buttoninfo.Name = "buttoninfo";
            this.buttoninfo.Size = new System.Drawing.Size(81, 68);
            this.buttoninfo.TabIndex = 0;
            this.buttoninfo.Text = "个人信息";
            this.buttoninfo.UseVisualStyleBackColor = true;
            this.buttoninfo.Click += new System.EventHandler(this.buttoninfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择您要进行的操作：";
            // 
            // buttongrade
            // 
            this.buttongrade.Location = new System.Drawing.Point(296, 143);
            this.buttongrade.Name = "buttongrade";
            this.buttongrade.Size = new System.Drawing.Size(81, 68);
            this.buttongrade.TabIndex = 2;
            this.buttongrade.Text = "成绩信息";
            this.buttongrade.UseVisualStyleBackColor = true;
            this.buttongrade.Click += new System.EventHandler(this.buttongrade_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttoncourse
            // 
            this.buttoncourse.Location = new System.Drawing.Point(64, 251);
            this.buttoncourse.Name = "buttoncourse";
            this.buttoncourse.Size = new System.Drawing.Size(81, 68);
            this.buttoncourse.TabIndex = 5;
            this.buttoncourse.Text = "选课信息";
            this.buttoncourse.UseVisualStyleBackColor = true;
            this.buttoncourse.Click += new System.EventHandler(this.buttoncourse_Click);
            // 
            // buttonpassword
            // 
            this.buttonpassword.Location = new System.Drawing.Point(296, 251);
            this.buttonpassword.Name = "buttonpassword";
            this.buttonpassword.Size = new System.Drawing.Size(81, 68);
            this.buttonpassword.TabIndex = 6;
            this.buttonpassword.Text = "修改密码";
            this.buttonpassword.UseVisualStyleBackColor = true;
            this.buttonpassword.Click += new System.EventHandler(this.buttonpassword_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(165, 377);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(70, 61);
            this.buttonclose.TabIndex = 7;
            this.buttonclose.Text = "返回";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonpassword);
            this.Controls.Add(this.buttoncourse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttongrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoninfo);
            this.Name = "StudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttongrade;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttoncourse;
        private System.Windows.Forms.Button buttonpassword;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button button1;
    }
}