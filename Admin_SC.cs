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
    public partial class Admin_SC : Form
    {
        public Admin_SC()
        {
            InitializeComponent();
        }

        private void Admin_SC_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet3.SC”中。您可以根据需要移动或删除它。
            this.sCTableAdapter.Fill(this.schoolDataSet3.SC);

        }

        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123"); //连接数据库


        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMain a = new AdminMain();
            a.Show();
        }

        private void buttonempty_Click(object sender, EventArgs e)
        {
            textBoxcno.Text = "";
            textBoxsno.Text = "";
            textBoxgrade.Text = "";
        }

        private void buttonselect_Click(object sender, EventArgs e)//查找
        {
            this.Hide();
            Admin_SC_grade adsc = new Admin_SC_grade();
            adsc.ShowDialog();
            
           /* string SCsno = textBoxsno.Text.Trim();
            string SCcno = textBoxcno.Text.Trim();
            string SCgrade = textBoxgrade.Text.Trim();

            string conn = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";
            SqlConnection sqlconnection = new SqlConnection(conn);//实例化连接对象

            try
            {
                sqlconnection.Open();

                if(SCcno!=""&&SCsno!="")//按照Sno和Cno查询
                {
                    String select_by_snocno = "select * from SC where Sno='" + SCsno + "' AND Cno='"+SCcno+"'";
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
                if (SCgrade != "" && SCcno == "" && SCcno == "")//按照Grade查询
                {
                    String select_by_grade= "select * from SC where Grade='" + SCgrade + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_grade, sqlconnection);
                    SqlDataReader sqldatareader = sqlcommand.ExecuteReader();
                    BindingSource bindingsource = new BindingSource();
                    bindingsource.DataSource = sqldatareader;
                    dataGridView1.DataSource = bindingsource;
                }
                if (SCsno != "" && SCgrade != "" )//按照Sno和Grade查询
                {
                    String select_by_snograde = "select * from SC where Sno='" + SCsno + "' and Grade='" + SCgrade + "'";
                    SqlCommand sqlcommand = new SqlCommand(select_by_snograde, sqlconnection);
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

        private void buttonchange_Click(object sender, EventArgs e)//修改
        {
            string SCsno = textBoxsno.Text.Trim();
            string SCcno = textBoxcno.Text.Trim();
            string SCgrade = textBoxgrade.Text.Trim();

            try
            {
                con.Open();     //打开数据库

                if (SCsno == "" || SCcno == "")
                {
                    MessageBox.Show("Sno和Cno不能为空！");
                }
                if (SCgrade != "")//根据Sno和Cno修改Grade
                {
                    string update_grade = "UPDATE SC SET Grade='" + SCgrade + "' WHERE Sno='"+SCsno+"' AND Cno='"+SCcno+"'";
                    SqlCommand cmd = new SqlCommand(update_grade,con);
                    cmd.ExecuteNonQuery();
                }
               
            }
            catch
            {
                MessageBox.Show("输入数据违反要求！");
            }
            finally
            {
                   //关闭数据库
                con.Close();
            }
            this.sCTableAdapter.Fill(this.schoolDataSet3.SC);
        }

        private void buttondelete_Click(object sender, EventArgs e)//删除
        {
            try
            {         
               con.Open(); //打开数据库
                string select_Sno = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选择的当前行第一列的值，也就是Sno
                string select_Cno = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//选择当前行第2列的值，也就是Cno
                string delete_by_SnoCno = "delete from SC where Sno='" + select_Sno + "' and Cno='" + select_Cno + "'";//sql删除语句
                SqlCommand cmd = new SqlCommand(delete_by_SnoCno, con);
                cmd.ExecuteNonQuery();             
            }
            catch
            {
                MessageBox.Show("请选择正确行！");
            }
            finally
            {                 
                con.Close(); //关闭数据库
            }
            this.sCTableAdapter.Fill(this.schoolDataSet3.SC);
        }

        public string EMPTY_grade(string obj)//输入的数据Cpno为空时的情况
        {
            if (obj == null)
                return DBNull.Value.ToString();
            return obj;
        }

        private void buttonadd_Click(object sender, EventArgs e)//增加
        {
            string SCsno = textBoxsno.Text.Trim();
            string SCcno = textBoxcno.Text.Trim();
            string SCgrade = EMPTY_grade(textBoxgrade.Text);
            try
            {
                con.Open();     //打开数据库
                string insertsc = "INSERT INTO SC(Sno,Cno,Grade)" + "VALUES('" + SCsno + "','" + SCcno + "'," +SCgrade +")";
                SqlCommand cmd = new SqlCommand(insertsc, con);
                cmd.ExecuteNonQuery();      //将增加后的信息直接出来
            }
            catch
            {
                MessageBox.Show("输入数据违反要求！");
            }
            finally
            {
                con.Close();      //关闭数据库                                
            }
            this.sCTableAdapter.Fill(this.schoolDataSet3.SC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
