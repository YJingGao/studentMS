using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dazuoye2
{
    public partial class Admin_info : Form
    {
        public Admin_info()
        {
            InitializeComponent();

            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMain a = new AdminMain();
            a.Show();
        }

        private void Admin_info_Load(object sender, EventArgs e)
        {
            try
            {
                Form1 m = new Form1();
                string select_name = m.Get();
                string connString = "Data Source=.;Initial Catalog=School;Persist Security Info=True;User ID=sa;Password=123";//数据库连接字符串
                SqlConnection connection = new SqlConnection(connString);//创建connection对象              
                connection.Open(); //打开数据库连接

                //显示信息
                //在显示出生日期,注意DataTime格式的转换，以及完成查询后的标签内容的转换                
                string select_a = "select Ano,Aname,Asex,UserMobile,UserBirthday,Asalary,Atitle from Admin,SysUser where Admin.Ano=SysUser.UserSchoolID and UserID='" + select_name + "'";
                SqlCommand cmd = new SqlCommand(select_a, connection);
                SqlDataReader dr = cmd.ExecuteReader();//读取数据
                dr.Read();
                if (dr.HasRows)
                {
                    labelno.Text = dr[0].ToString();
                    labelname.Text = dr[1].ToString();
                    labelsex.Text = dr[2].ToString();
                    labelphone.Text = dr[3].ToString();                 
                     labelbirth.Text = Convert.ToString(dr.GetDateTime(4).ToShortDateString());
                    //出生日期只显示年月日
                    labelsalary.Text = dr[5].ToString();
                    labeltitle.Text = dr[6].ToString();
                }
                else { MessageBox.Show("您的信息还未录入！"); }
                dr.Close();

                //显示图片
                string sql = "select UserPhoto from SysUser where UserID = '" + select_name + "'";                
                SqlCommand command = new SqlCommand(sql, connection);//创建SqlCommand对象
                //创建DataAdapter对象
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //创建DataSet对象
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "SysUser");
                int c = dataSet.Tables["SysUser"].Rows.Count;
                if (c > 0)
                {
                    Byte[] mybyte = new byte[0];
                    mybyte = (Byte[])(dataSet.Tables["SysUser"].Rows[c - 1]["UserPhoto"]);
                    MemoryStream ms = new MemoryStream(mybyte);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                else
                    pictureBox1.Image = null;






                /*  //读取显示工号
                  string select_ano = "select UserSchoolID from SysUser where UserID='" + select_name + "'"; //创建sql语句
                  SqlCommand cmd = new SqlCommand(select_ano, connection);
                  SqlDataReader dr = cmd.ExecuteReader();
                  while (dr.Read())
                  {
                      labelno.Text = dr.GetString(0);//在labelno中显示

                  }
                  dr.Close();

                  //读取显示姓别、性别 ，工资，职称        
                  string select_a = "select Aname,Asex,Asalary,Atitle from Admin, SysUser where Admin.Ano = SysUser.UserSchoolID and UserID= '" + select_name + "'";
                  SqlCommand cmd1 = new SqlCommand(select_a, connection);
                  SqlDataReader dr1 = cmd1.ExecuteReader();
                  while (dr1.Read())
                  {
                      labelname.Text = dr1.GetString(0);
                      labelsex.Text = dr1.GetString(1);
                     labelsalary.Text = dr1.GetString(2);
                      labeltitle.Text = dr1.GetString(3);
                  }
                  dr1.Close();
                  //显示联系方式
                  string select_b = "select UserMobile from SysUser where UserID='" + select_name + "'";
                  SqlCommand cmd2 = new SqlCommand(select_b, connection);
                  SqlDataReader dr2 = cmd2.ExecuteReader();
                  while (dr2.Read())                
                  {

                      labelphone.Text = dr2.GetString(0); 
                  }
                 dr2.Close();



                  //   显示出生日期,注意DataTime格式的转换，以及完成查询后的标签内容的转换

                  string select_c = "select UserBirthday from SysUser where UserID='" + select_name + "'";
                  SqlCommand cmd3 = new SqlCommand(select_c, connection);
                  SqlDataReader dr3 = cmd3.ExecuteReader();

                  if (dr3.Read())
                  {
                      labelbirth.Text =Convert.ToString( dr3.GetDateTime(0).ToShortDateString());
                      //出生日期只显示年月日，不显示具体的时间
                  }
                  dr3.Close();
                  */



                connection.Close();
                }
           
            catch
            {
                MessageBox.Show("显示信息失败！");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelAsalary_Click(object sender, EventArgs e)
        {

        }
    }

        

        
    
}
