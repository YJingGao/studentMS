using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dazuoye2
{
    public partial class StudentMain : Form
    {
        public StudentMain()
        {
            InitializeComponent();
        }

        private void buttonclose_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
            Form1 m = new Form1();
            m.Show();
        }

        private void buttonpassword_Click(object sender, EventArgs e)//修改密码
        {
            this.Hide();
            Student_password spw = new Student_password();
            spw.ShowDialog(); 
        }

        private void buttoninfo_Click(object sender, EventArgs e)//个人信息
        { 
            this.Hide();
            Student_info studentinfo = new Student_info();
            studentinfo.ShowDialog();          
        }

        private void buttongrade_Click(object sender, EventArgs e)//成绩
        {  
            this.Hide();
            Student_grade studentgrade = new Student_grade();
            studentgrade.ShowDialog();         
        }

        private void buttoncourse_Click(object sender, EventArgs e)//课程
        {
            this.Hide();
            Student_Course student_course = new Student_Course();
            student_course.ShowDialog();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
    }
}
