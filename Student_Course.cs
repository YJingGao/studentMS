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
    public partial class Student_Course : Form
    {
        public Student_Course()
        {
            InitializeComponent();
        }


        string studentsno;
        private void Student_Course_Load(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            string select_name = m.Get();
            
            String conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象
            try
            {
                sqlconnection.Open();
             //   string StuSno = "Qq1";

                String select_by_sno = "select UserSchoolID from SysUser where UserID='" + select_name + "'";
                SqlCommand cmd = new SqlCommand(select_by_sno, sqlconnection);
                SqlDataReader dr = cmd.ExecuteReader();//读取数据
                dr.Read();
                if (dr.HasRows)
                    studentsno = dr[0].ToString();
                dr.Close();

                String select_sno = "select SC.Sno,Course.Cno,Cname,Ccredit from Course,SC where Course.Cno = SC.Cno and SC.Sno = '" + studentsno + "'";
                SqlCommand sqlcommand = new SqlCommand(select_sno, sqlconnection);
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

            // TODO: 这行代码将数据加载到表“schoolDataSet6.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.schoolDataSet6.Course);

        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMain s = new StudentMain();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
