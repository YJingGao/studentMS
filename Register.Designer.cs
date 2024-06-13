namespace dazuoye2
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.buttonphoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelphoto = new System.Windows.Forms.Label();
            this.buttonquit = new System.Windows.Forms.Button();
            this.buttonok = new System.Windows.Forms.Button();
            this.dateTimePickerbirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxidentity = new System.Windows.Forms.ComboBox();
            this.textBoxmobile = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.labelidentity = new System.Windows.Forms.Label();
            this.labelbirth = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelno = new System.Windows.Forms.Label();
            this.labelword = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonphoto
            // 
            this.buttonphoto.Location = new System.Drawing.Point(378, 369);
            this.buttonphoto.Name = "buttonphoto";
            this.buttonphoto.Size = new System.Drawing.Size(83, 45);
            this.buttonphoto.TabIndex = 90;
            this.buttonphoto.Text = "上传";
            this.buttonphoto.UseVisualStyleBackColor = true;
            this.buttonphoto.Click += new System.EventHandler(this.buttonphoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(378, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 217);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // labelphoto
            // 
            this.labelphoto.AutoSize = true;
            this.labelphoto.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelphoto.Location = new System.Drawing.Point(358, 91);
            this.labelphoto.Name = "labelphoto";
            this.labelphoto.Size = new System.Drawing.Size(49, 20);
            this.labelphoto.TabIndex = 88;
            this.labelphoto.Text = "照片";
            // 
            // buttonquit
            // 
            this.buttonquit.Location = new System.Drawing.Point(209, 477);
            this.buttonquit.Name = "buttonquit";
            this.buttonquit.Size = new System.Drawing.Size(71, 56);
            this.buttonquit.TabIndex = 87;
            this.buttonquit.Text = "取消";
            this.buttonquit.UseVisualStyleBackColor = true;
            this.buttonquit.Click += new System.EventHandler(this.buttonquit_Click);
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(25, 477);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(71, 56);
            this.buttonok.TabIndex = 86;
            this.buttonok.Text = "完成";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // dateTimePickerbirth
            // 
            this.dateTimePickerbirth.CustomFormat = "";
            this.dateTimePickerbirth.Location = new System.Drawing.Point(97, 328);
            this.dateTimePickerbirth.Name = "dateTimePickerbirth";
            this.dateTimePickerbirth.Size = new System.Drawing.Size(200, 25);
            this.dateTimePickerbirth.TabIndex = 85;
            // 
            // comboBoxidentity
            // 
            this.comboBoxidentity.FormattingEnabled = true;
            this.comboBoxidentity.Items.AddRange(new object[] {
            "学生",
            "管理员"});
            this.comboBoxidentity.Location = new System.Drawing.Point(97, 381);
            this.comboBoxidentity.Name = "comboBoxidentity";
            this.comboBoxidentity.Size = new System.Drawing.Size(200, 23);
            this.comboBoxidentity.TabIndex = 84;
            // 
            // textBoxmobile
            // 
            this.textBoxmobile.Location = new System.Drawing.Point(97, 266);
            this.textBoxmobile.Name = "textBoxmobile";
            this.textBoxmobile.Size = new System.Drawing.Size(200, 25);
            this.textBoxmobile.TabIndex = 83;
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(97, 212);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(200, 25);
            this.textBoxid.TabIndex = 82;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(97, 112);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(200, 25);
            this.textBoxusername.TabIndex = 80;
            this.textBoxusername.Leave += new System.EventHandler(this.textBoxusername_Leave);
            // 
            // labelidentity
            // 
            this.labelidentity.AutoSize = true;
            this.labelidentity.Location = new System.Drawing.Point(14, 389);
            this.labelidentity.Name = "labelidentity";
            this.labelidentity.Size = new System.Drawing.Size(52, 15);
            this.labelidentity.TabIndex = 79;
            this.labelidentity.Text = "身份：";
            // 
            // labelbirth
            // 
            this.labelbirth.AutoSize = true;
            this.labelbirth.Location = new System.Drawing.Point(14, 328);
            this.labelbirth.Name = "labelbirth";
            this.labelbirth.Size = new System.Drawing.Size(82, 15);
            this.labelbirth.TabIndex = 78;
            this.labelbirth.Text = "出生日期：";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Location = new System.Drawing.Point(14, 267);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(82, 15);
            this.labelphone.TabIndex = 77;
            this.labelphone.Text = "联系方式：";
            // 
            // labelno
            // 
            this.labelno.AutoSize = true;
            this.labelno.Location = new System.Drawing.Point(14, 215);
            this.labelno.Name = "labelno";
            this.labelno.Size = new System.Drawing.Size(90, 15);
            this.labelno.TabIndex = 76;
            this.labelno.Text = "学号/工号：";
            // 
            // labelword
            // 
            this.labelword.AutoSize = true;
            this.labelword.Location = new System.Drawing.Point(14, 166);
            this.labelword.Name = "labelword";
            this.labelword.Size = new System.Drawing.Size(52, 15);
            this.labelword.TabIndex = 75;
            this.labelword.Text = "密码：";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(14, 115);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(67, 15);
            this.labelname.TabIndex = 74;
            this.labelname.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 73;
            this.label1.Text = "注册信息";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 56);
            this.button1.TabIndex = 91;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(97, 163);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(200, 25);
            this.textBoxpassword.TabIndex = 92;
            this.textBoxpassword.Leave += new System.EventHandler(this.textBoxpassword_Leave_1);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 574);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonphoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelphoto);
            this.Controls.Add(this.buttonquit);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.dateTimePickerbirth);
            this.Controls.Add(this.comboBoxidentity);
            this.Controls.Add(this.textBoxmobile);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.labelidentity);
            this.Controls.Add(this.labelbirth);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelno);
            this.Controls.Add(this.labelword);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonphoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelphoto;
        private System.Windows.Forms.Button buttonquit;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.DateTimePicker dateTimePickerbirth;
        private System.Windows.Forms.ComboBox comboBoxidentity;
        private System.Windows.Forms.TextBox textBoxmobile;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label labelidentity;
        private System.Windows.Forms.Label labelbirth;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelno;
        private System.Windows.Forms.Label labelword;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxpassword;
    }
}