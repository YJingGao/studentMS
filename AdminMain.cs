using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dazuoye2
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void buttonstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Student ads = new Admin_Student();
            ads.ShowDialog();
            
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void buttoncourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Course adc = new Admin_Course();
            adc.ShowDialog();
            
        }

        private void buttoninfo_Click(object sender, EventArgs e)//个人信息
        { 
            this.Hide();
            Admin_info adin = new Admin_info();
            adin.ShowDialog();
           
        }

        private void buttonlogin_Click(object sender, EventArgs e)//登录日志
        { 
            this.Hide();
            Admin_login adlogin = new Admin_login();
            adlogin.ShowDialog();
           
        }

        private void buttonsc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_SC adsc = new Admin_SC();
            adsc.ShowDialog();
            
        }

        private void buttonpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_password adpw = new Admin_password();
            adpw.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
