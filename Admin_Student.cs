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
    public partial class Admin_Student : Form
    {
        public Admin_Student()
        {
            InitializeComponent();
        }

        private void Admin_Student_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet.Student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);

        }
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123"); //连接数据库

        private void buttonadd_Click(object sender, EventArgs e)    //增加
        {
            string StuSno = textBoxsno.Text.Trim();
            string StuSname = textBoxsname.Text.Trim();
            string StuSsex = textBoxssex.Text.Trim();
            string StuSage = textBoxsage.Text.Trim();
            string StuSdept = textBoxsdept.Text.Trim();
           
             try
             {
                if (StuSsex != "男" && StuSsex != "女")
                {
                    MessageBox.Show("性别必须输入为“男”或“女”");
                }
                
                con.Open();     //打开数据库
                 string insertStr = "INSERT INTO Student(Sno,Sname,Ssex,Sage,Sdept)" + "VALUES('" + StuSno + "','" + StuSname + "','" + StuSsex + "'," + StuSage + ",'" + StuSdept + "')";
                 SqlCommand cmd = new SqlCommand(insertStr, con);
                 cmd.ExecuteNonQuery();      //将增加后的信息直接出来
             }
             catch
             {
                MessageBox.Show("输入数据违反要求,请按照要求填写信息！");
            }
             finally
             {
                con.Close();      //关闭数据库
               //  con.Close();
             }
             this.studentTableAdapter.Fill(this.schoolDataSet.Student);
            

        }

        public void clear()//将文本框的内容全部清除
        {
            textBoxsno.Text = "";
            textBoxsname.Text = "";
            textBoxssex.Text = "";
            textBoxsage.Text = "";
            textBoxsdept.Text = "";
        }
        private void buttonclose_Click(object sender, EventArgs e)      //关闭窗口
        {
            this.Close();
            AdminMain a = new AdminMain();
            a.Show();
        }

        private void buttondelete_Click(object sender, EventArgs e)     //删除
        {
            try
            {
                con.Open();     //打开数据库
                string select_Sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是Sno
                string delete_by_Sno = "DELETE FROM Student WHERE Sno='" + select_Sno + "'";//sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_Sno, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("该学生已选课，无法删除！");
            }
            finally
            {
                // con.Dispose();      //关闭数据库
                con.Close();
            }
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);


        }

        private void buttonchange_Click(object sender, EventArgs e)     //修改，根据学号修改姓名、性别、年龄、专业
        {
            string StuSno = textBoxsno.Text.Trim();
            string StuSname = textBoxsname.Text.Trim();
            string StuSsex = textBoxssex.Text.Trim();
            string StuSage = textBoxsage.Text.Trim();
            string StuSdept = textBoxsdept.Text.Trim();
            try
            {
                con.Open();     //打开数据库
                if (StuSno == "")//输入的学号为空
                {
                    MessageBox.Show("学号不能为空！");
                }
                if (StuSname != "") //在Sname的文本框输入内容，修改Sname
                {
                    string update_sname = "UPDATE Student SET Sname='" + StuSname + "'WHERE Sno='" + StuSno + "'";
                    SqlCommand cmd1 = new SqlCommand(update_sname, con);
                    cmd1.ExecuteNonQuery();
                }
                if (StuSsex != "")  //修改Ssex
                {
                    string update_sex = "UPDATE Student SET Ssex='" + StuSsex + "' WHERE Sno='" + StuSno + "'";
                    SqlCommand cmd2 = new SqlCommand(update_sex, con);
                    cmd2.ExecuteNonQuery();
                }
                if (StuSage != "")//修改Sage
                {                
                     string update_age = "UPDATE Student SET Sage='" + StuSage + " 'WHERE Sno='" + StuSno + "'";
                     SqlCommand cmd3 = new SqlCommand(update_age, con);
                    cmd3.ExecuteNonQuery();
                }
                if (StuSdept != "")//修改Sdept
                {
                    string update_sdept = "UPDATE Student SET Sdept='" + StuSdept + "' WHERE Sno='" + StuSno + "'";
                    SqlCommand cmd4 = new SqlCommand(update_sdept, con);
                    cmd4.ExecuteNonQuery();
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
            this.studentTableAdapter.Fill(this.schoolDataSet.Student);
        }

        private void buttonselect_Click(object sender, EventArgs e) //查找
        {
            string StuSno = textBoxsno.Text.Trim();
            string StuSname = textBoxsname.Text.Trim();
            string StuSsex = textBoxssex.Text.Trim();
            string StuSage = textBoxsage.Text.Trim();
            string StuSdept = textBoxsdept.Text.Trim();
            String conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象
            
            try
            {
                sqlconnection.Open();
                
                if (StuSno != "")//按照学号查找，只有一个
                {
                    String select_by_sno = "select * from Student where Sno='" + StuSno + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_sno, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                    //将读出来的值赋给数据源，再将数据源给dataGridView
                }
                if (StuSname != ""&&StuSsex==""&&StuSage==""&&StuSdept=="")//只按照姓名查找
                {
                    String select_by_sname = "select * from Student where Sname='" + StuSname + "'";
                   SqlCommand  sqlcommand = new SqlCommand(select_by_sname, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                    //将读出来的值赋给数据源，再将数据源给dataGridView
                }
                if (StuSsex!=""&&StuSname==""&& StuSdept==""&&StuSage=="") //只按照性别查找
                {
                    String select_by_sex = "select * from Student where Ssex='" + StuSsex + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_sex, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                    //将读出来的值赋给数据源，再将数据源给dataGridView
                }
                if (StuSage != "" && StuSname == "" && StuSsex == "" && StuSdept == "")//只按照年龄查找
                {
                    String select_by_age = "select * from Student where Sage='" + StuSage + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_age, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                    //将读出来的值赋给数据源，再将数据源给dataGridView
                }
                if (StuSdept != "" && StuSname == "" && StuSsex == "" && StuSage == "")//只按照系别查找
                {
                    String select_by_sdept = "select * from Student where Sdept='" + StuSdept + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_sdept, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                    //将读出来的值赋给数据源，再将数据源给dataGridView
                }
                 if(StuSsex!=""&&StuSage!=""&&StuSdept=="")//按照性别和年龄查找
                {
                    String select_by_sexage = "select * from Student where Ssex='" + StuSsex + "' and Sage='"+StuSage+"'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_sexage, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (StuSsex != "" && StuSdept != "" && StuSage == "")//按照性别和系别查找
                {
                    String select_by_sexdept = "select * from Student where Ssex='" + StuSsex + "' and Sdept='" + StuSdept + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_sexdept, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (StuSage != "" && StuSdept != "" && StuSsex == "")//按照年龄和系别查找
                {
                    String select_by_agedept = "select * from Student where Sage='" + StuSage + "' and Sdept='" + StuSdept + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_agedept, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (StuSage != "" && StuSdept != "" && StuSsex != "")//按照年龄、系别、性别查找
                {
                    String select_by_agedeptsex = "select * from Student where Sage='" + StuSage + "' and Sdept='" + StuSdept + "' and Ssex='"+StuSsex+"'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_agedeptsex, sqlconnection);
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

        private void buttonempty_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
