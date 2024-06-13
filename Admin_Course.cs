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
    public partial class Admin_Course : Form
    {
        public Admin_Course()
        {
            InitializeComponent();
        }

        private void Admin_Course_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet1.Course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.schoolDataSet1.Course);

        }

        public void clear()
        {
            textBoxcno.Text = "";
            textBoxcname.Text = "";
            textBoxcpno.Text = "";
            textBoxcredit.Text = "";
        }
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123"); //连接数据库

       
        private void buttonadd_Click(object sender, EventArgs e)//增加
        {
            string CouCno = textBoxcno.Text.Trim();
            string CouCname = textBoxcname.Text.Trim();
            string CouCpno =textBoxcpno.Text.Trim();
            string CouCcredit = textBoxcredit.Text.Trim();
            try
            {

                con.Open();     //打开数据库
                string insertCou = "INSERT INTO Course(Cno,Cname,Cpno,Ccredit)" + "VALUES('" + CouCno + "','" + CouCname + "','" + CouCpno + "'," + CouCcredit+ ")";
                SqlCommand cmd = new SqlCommand(insertCou, con);
                cmd.ExecuteNonQuery();      //将增加后的信息直接出来
            }
            catch
            {
                MessageBox.Show("输入数据违反要求！");
            }
            finally 
            {
                con.Close();
            }
            this.courseTableAdapter.Fill(this.schoolDataSet1.Course);
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMain a = new AdminMain();
            a.Show();
        }

        private void buttondelete_Click(object sender, EventArgs e)//删除
        {
            try
            {
                con.Open();     //打开数据库
                string select_Cno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是Cno
                string delete_by_Cno = "DELETE FROM Course WHERE Cno='" + select_Cno + "'";//sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_Cno, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("已有学生选课或作为先行课，无法删除！");
            }
            finally
            {
                // con.Dispose();      //关闭数据库
                con.Close();
            }
            this.courseTableAdapter.Fill(this.schoolDataSet1.Course);
        }

        private void buttonchange_Click(object sender, EventArgs e)//修改
        {
            string CouCno = textBoxcno.Text.Trim();
            string CouCname = textBoxcname.Text.Trim();
            string CouCpno = textBoxcpno.Text.Trim();
            string CouCcredit = textBoxcredit.Text.Trim();
            try
            {
                con.Open();     //打开数据库
                
                if (CouCname != "") //修改课程名称,只能根据课程号修改
                {
                    
                    string update_cname = "UPDATE Course SET Cname='" + CouCname + "'WHERE Cno='" + CouCno + "'";
                    SqlCommand cmd = new SqlCommand(update_cname, con);
                    cmd.ExecuteNonQuery();
                }
                 if ( CouCpno != "" &&CouCno != "" || CouCname != ""&& CouCpno != "")  //修改Cpno，通过课程号修改一门课的或者通过课程名修改多门课的
                 {
                     string update_cpno = "UPDATE Course SET Cpno='" + CouCpno + "' WHERE Cno='" + CouCno + "' OR Cname='"+CouCname+"'";
                     SqlCommand cmd2 = new SqlCommand(update_cpno, con);
                     cmd2.ExecuteNonQuery();
                 }

                 if (CouCcredit != "" && CouCno != "" || CouCname != "" && CouCcredit != "")//修改Credit,通过课程号修改一门课的或者通过课程名修改多门课的
                 {
                     string update_credit = "UPDATE Course SET Ccredit='" + CouCcredit + " 'WHERE Cno='" + CouCno + "' OR Cname='"+CouCname+"'";
                     SqlCommand cmd3 = new SqlCommand(update_credit, con);
                     cmd3.ExecuteNonQuery();
                 }
              
            }
            catch
            {
                MessageBox.Show("输入数据违反要求！");
            }
            finally
            {
                //con.Dispose();      //关闭数据库
                con.Close();
            }
            this.courseTableAdapter.Fill(this.schoolDataSet1.Course);
        }

        private void buttonselect_Click(object sender, EventArgs e)//查找
        {
            string CouCno = textBoxcno.Text.Trim();
            string CouCname = textBoxcname.Text.Trim();
            string CouCpno = textBoxcpno.Text.Trim();
            string CouCcredit = textBoxcredit.Text.Trim();
            String conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象

            try
            {
                sqlconnection.Open();

                if (CouCno != "")//按照课序号查找，只有一个
                {
                    String select_by_cno = "select * from Course where Cno='" + CouCno + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_cno, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                    //将读出来的值赋给数据源，再将数据源给dataGridView
                }
                if (CouCname != "" && CouCpno == "" && CouCcredit == "")//按照课程名查找
                {
                    String select_by_cname = "select * from Course where Cname='" + CouCname + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_cname, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (CouCpno != "" && CouCname == "" && CouCcredit == "")//按照Cpno查找
                {
                    String select_by_cpno = "select * from Course where Cpno='" + CouCpno + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_cpno, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (CouCcredit != "" && CouCname == "" && CouCpno == "")//按照Credit查找
                {
                    String select_by_credit = "select * from Course where Ccredit='" + CouCcredit + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_credit, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (CouCname != "" && CouCpno != "" && CouCcredit == "")//按照Cname和Cpno查找
                {
                    String select_by_namepno = "select * from Course where Cname='" + CouCname + "' AND Cpno='"+CouCpno+"'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_namepno, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (CouCname != "" && CouCcredit != "" && CouCpno == "")//按照Cname和Ccredit查找
                {
                    String select_by_namecredit = "select * from Course where Cname='" + CouCname + "' AND Ccredit='" + CouCcredit + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_namecredit, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (CouCpno != "" && CouCcredit != "" && CouCname == "")//按照Cpno和Ccredit查找
                {
                    String select_by_pnocredit = "select * from Course where Cpno='" + CouCpno + "' AND Ccredit='" + CouCcredit + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_pnocredit, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (CouCname != "" && CouCpno != "" && CouCcredit != "")//按照Cname和Cpno和Ccredit查找
                {
                    String select_by_pnocreditname = "select * from Course where Cpno='" + CouCpno + "' AND Ccredit='" + CouCcredit + "' AND Cname='"+CouCname+"'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_pnocreditname, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
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

        private void buttonempty_Click(object sender, EventArgs e)//清空
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
