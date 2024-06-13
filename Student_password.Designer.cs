namespace dazuoye2
{
    partial class Student_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_password));
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxnewpassword1 = new System.Windows.Forms.TextBox();
            this.textBoxnewpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(222, 348);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(66, 60);
            this.buttonclose.TabIndex = 17;
            this.buttonclose.Text = "返回";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(71, 348);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(68, 60);
            this.buttonok.TabIndex = 16;
            this.buttonok.Text = "确定";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(115, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "修改密码";
            // 
            // textBoxnewpassword1
            // 
            this.textBoxnewpassword1.Location = new System.Drawing.Point(180, 286);
            this.textBoxnewpassword1.Name = "textBoxnewpassword1";
            this.textBoxnewpassword1.Size = new System.Drawing.Size(152, 25);
            this.textBoxnewpassword1.TabIndex = 14;
            this.textBoxnewpassword1.Leave += new System.EventHandler(this.textBoxnewpassword1_Leave);
            // 
            // textBoxnewpassword
            // 
            this.textBoxnewpassword.Location = new System.Drawing.Point(180, 218);
            this.textBoxnewpassword.Name = "textBoxnewpassword";
            this.textBoxnewpassword.Size = new System.Drawing.Size(152, 25);
            this.textBoxnewpassword.TabIndex = 13;
            this.textBoxnewpassword.Leave += new System.EventHandler(this.textBoxnewpassword_Leave);
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(180, 142);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(152, 25);
            this.textBoxusername.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "确认新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "新  密  码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "用  户  名：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 60);
            this.button1.TabIndex = 18;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(491, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnewpassword1);
            this.Controls.Add(this.textBoxnewpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxnewpassword1;
        private System.Windows.Forms.TextBox textBoxnewpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}