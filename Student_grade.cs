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
    public partial class Student_grade : Form
    {
        public Student_grade()
        {
            InitializeComponent();
        }

        String conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
        static Form1 m = new Form1();
        static string select_name = m.Get();
        private void Student_grade_Load(object sender, EventArgs e)
        {
           // Form1 m = new Form1();
           // string select_name = m.Get();
           // String conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象

            try
            {
                sqlconnection.Open();
                string select_by_sno = "select SC.Sno,Sname,SC.Cno,Cname,Grade from Student,SC,Course,SysUser where Student.Sno=SC.Sno and Course.Cno=SC.Cno and SC.Sno=SysUser.UserSchoolID and UserID='" + select_name + "'";
                SqlCommand sqlcommand = new SqlCommand(select_by_sno, sqlconnection);
                SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                BindingSource bindingsource = new BindingSource();
                bindingsource.DataSource = sqldatareader;
                dataGridView1.DataSource = bindingsource;
            }
            catch
            {
                MessageBox.Show("查询语句有误，请认真检查SQL语句");
            }
            finally
            {
                sqlconnection.Close();
            }
            // TODO: 这行代码将数据加载到表“schoolDataSet5.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter.Fill(this.schoolDataSet5.SC);
        }
     

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMain s = new StudentMain();
            s.Show();
        }
       
        
        private void buttonavegrade_Click(object sender, EventArgs e)//查询平均成绩
        {
          //  Form1 m = new Form1();
          //  string select_name = m.Get();
          //  String conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象

            try
            {
                sqlconnection.Open();
                string select_avggrade = "select AVG(Grade) from SC,SysUser where  SC.Sno=SysUser.UserSchoolID and UserID='" + select_name + "'";
               
                SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
                SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                BindingSource bindingsource = new BindingSource();
                bindingsource.DataSource = sqldatareader;
                dataGridView1.DataSource = bindingsource;
            }
            catch
            {
                MessageBox.Show("查询语句有误，请认真检查SQL语句");
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        private void buttonnograde_Click(object sender, EventArgs e)//查询不及格成绩信息
        {
          //  Form1 m = new Form1();
          //  string select_name = m.Get();
           // String conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象

            try
            {
                sqlconnection.Open();
                string select_nograde =" select Sno,SC.Cno,Cname,Grade from SC,Course,SysUser where SC.Cno=Course.Cno and SC.Sno = SysUser.UserSchoolID and Grade<60 and UserID = '" + select_name + "'";

                SqlCommand sqlcommand = new SqlCommand(select_nograde, sqlconnection);
                SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                BindingSource bindingsource = new BindingSource();
                bindingsource.DataSource = sqldatareader;
                dataGridView1.DataSource = bindingsource;
                if (dataGridView1.DataSource is null)
                {
                    string nullgrade = "wiekof";
                    SqlCommand sqlcommand1 = new SqlCommand(nullgrade, sqlconnection);
                    SqlDataReader sqldatareader1 = sqlcommand.ExecuteReader();
                    BindingSource bindingsource1= new BindingSource();
                    bindingsource.DataSource = sqldatareader1;
                    dataGridView1.DataSource = bindingsource1;
                }
            }
            catch
            {
               // MessageBox.Show("weikof");
                MessageBox.Show("查询语句有误，请认真检查SQL语句");
            }
            finally
            {
                sqlconnection.Close();
            }
            this.sCTableAdapter.Fill(this.schoolDataSet5.SC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
