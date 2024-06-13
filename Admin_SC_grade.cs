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
    public partial class Admin_SC_grade : Form
    {
        public Admin_SC_grade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_SC sc = new Admin_SC();
            sc.Show();
        }

        string conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";

        private void buttonselect_Click(object sender, EventArgs e)
        {
            string SCsno = textBoxsno.Text.Trim();
            string SCcno = textBoxcno.Text.Trim();
            string SCgrade = textBoxgrade.Text.Trim();
          
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象

            try
            {
                sqlconnection.Open();

                if (SCcno != "" && SCsno != "")//按照Sno和Cno查询
                {
                    String select_by_snocno = "select * from SC where Sno='" + SCsno + "' AND Cno='" + SCcno + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_snocno, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                    //将读出来的值赋给数据源，再将数据源给dataGridView
                }
                if (SCsno != "" && SCcno == "" && SCgrade == "")//按照学号查询
                {
                    String select_by_sno = "select * from SC where Sno='" + SCsno + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_sno, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (SCcno != "" && SCsno == "" && SCgrade == "")//按照Cno查找
                {
                    String select_by_cno = "select * from SC where Cno='" + SCcno + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_cno, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (SCgrade != "" && SCsno == "" && SCcno == "")//按照Grade查询
                {
                    String select_by_grade = "select * from SC where Grade='" + SCgrade + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_grade, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
               
                if (SCcno != "" && SCgrade != "" && SCsno == "")//按照Cno和Grade查询
                {
                    String select_by_cnograde = "select * from SC where Cno='" + SCcno + "' and Grade='" + SCgrade + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_cnograde, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (SCsno != "" && SCgrade != "" && SCcno == "")//按照Sno和Grade查询
                {
                    String select_by_snograde = "select * from SC where Sno='" + SCsno + "' and Grade='" + SCgrade + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_snograde, sqlconnection);
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

        private void buttonavggrade_Click(object sender, EventArgs e)//平均成绩
        {
            string SCsno = textBoxsno.Text.Trim();
            string SCcno = textBoxcno.Text.Trim();
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象
            try
            {
                sqlconnection.Open();
                if (SCsno != "" && SCcno == "")//查询某个学生的平均成绩
                {
                    string select_avggrade = "select AVG(Grade) from SC where Sno='" + SCsno + "'";

                    SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (SCcno != "" && SCsno == "")//查询某个课程的平均成绩
                {
                    string select_avggrade = "select AVG(Grade) from SC where Cno='" + SCcno + "'";

                    SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
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


            /*  try
              {
                  sqlconnection.Open();

                  if (SCsno != "" && SCcno == "")//查询某个学生的平均成绩
                  {
                      string select_avggrade = "select AVG(Grade) from SC where Sno='" + SCsno + "'";

                      SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
                      SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                      BindingSource bindingsource = new BindingSource();
                      bindingsource.DataSource = sqldatareader;
                      dataGridView1.DataSource = bindingsource;
                  }
                  if (SCcno != "" && SCsno == "")//查询某个课程的平均成绩
                  {
                      string select_avggrade = "select AVG(Grade) from SC where Cno='" + SCcno + "'";
                      SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
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
              }*/
            /* string SCsno = textBoxsno.Text.Trim();
             string SCcno = textBoxcno.Text.Trim();         
             SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象

             try
             {
                 sqlconnection.Open();
                 if (SCsno != "" && SCcno == "")//查询某个学生的平均成绩
                 {
                     string select_avggrade = "select AVG(Grade) from SC where  Sno='" + SCsno + "'";
                     SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
                     SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                     BindingSource bindingsource = new BindingSource();
                     bindingsource.DataSource = sqldatareader;
                     dataGridView1.DataSource = bindingsource;
                 }
                 if (SCcno != "" && SCsno == "")//查询某个课程的平均成绩
                 {
                     string select_avggrade = "select AVG(Grade) from SC where  Cno='" + SCcno + "'";
                     SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
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
             }*/
        }

        private void buttonnograde_Click(object sender, EventArgs e)//不及格成绩
        {
            string SCsno = textBoxsno.Text.Trim();
            string SCcno = textBoxcno.Text.Trim();          
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象

            try
            {
                sqlconnection.Open();

                if (SCsno != "" && SCcno == "")//查询某个学生的不及格成绩
                {
                    string select_nograde = "select * from SC where Grade<60 and Sno='" + SCsno + "'";
                       
                    SqlCommand sqlcommand = new SqlCommand(select_nograde, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (SCcno != "" && SCsno == "")//查询某个课程的不及格成绩
                {
                    string select_nograde = "select * from SC where Grade<60 and Cno='" + SCcno + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_nograde, sqlconnection);
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

        private void buttonclear_Click(object sender, EventArgs e)//清除文本框的内容
        {
            textBoxsno.Text = "";
            textBoxcno.Text = "";
            textBoxgrade.Text = "";
            textBoxmin.Text = "";
            textBoxmax.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)//分数段查询
        {
            string SCcno = textBoxcno.Text.Trim();
            string SCmin = textBoxmin.Text.Trim();
            string SCmax = textBoxmax.Text.Trim();

           // string SCsno = textBoxsno.Text.Trim();
           // string SCcno= textBoxcno.Text.Trim();

            String conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象
            
            try
            {
                sqlconnection.Open();
                if (SCmin != "" && SCmax != "" && SCcno != "")//查询在特定分数段的学生
                {
                    String select_by_minmax = "select * from SC where Cno='" + SCcno + "' and Grade between '" + SCmin + "' and '" + SCmax + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_minmax, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;                   
                } 
                if (SCcno != "" && SCmin != "" && SCmax == "")//查询在特定成绩之上的学生     
                {
                    String select_by_cnograde = "select * from SC where Cno='" + SCcno + "' and Grade>'" + SCmin + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_cnograde, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                 if (SCcno != "" && SCmin == "" && SCmax != "")//查询在特定成绩之下的学生
                {
                    String select_by_cnograde = "select * from SC where Cno='" + SCcno + "' and Grade<'" + SCmax + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_cnograde, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }


              /*  if (SCsno != "" && SCcno == "")//查询某个学生的平均成绩
                {
                    string select_avggrade = "select AVG(Grade) from SC where Sno='" + SCsno + "'";

                    SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (SCcno != "" && SCsno == "")//查询某个课程的平均成绩
                {
                    string select_avggrade = "select AVG(Grade) from SC where Cno='" + SCcno + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }*/

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

        private void Admin_SC_grade_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet7.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter.Fill(this.schoolDataSet7.SC);

        }

        private void textBoxmax_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxgrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelgrade_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsno_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelcno_Click(object sender, EventArgs e)
        {

        }

        private void labelsno_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string SCsno = textBoxsno.Text.Trim();
            string SCcno = textBoxcno.Text.Trim();
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象
            try
            {
                sqlconnection.Open();
                if (SCsno != "" && SCcno == "")//查询某个学生的平均成绩
                {
                    string select_avggrade = "select AVG(Grade) from SC where Sno='" + SCsno + "'";

                    SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (SCcno != "" && SCsno == "")//查询某个课程的平均成绩
                {
                    string select_avggrade = "select AVG(Grade) from SC where Cno='" + SCcno + "'";

                    SqlCommand sqlcommand = new SqlCommand(select_avggrade, sqlconnection);
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
    }
}