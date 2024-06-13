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
    public partial class Student_info : Form
    {
        public Student_info()
        {
            InitializeComponent();
        }

        private void buttonselect_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMain s = new StudentMain();
            s.Show();
        }

        private void Student_info_Load(object sender, EventArgs e)
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
                string select_a = "select Sno,Sname,Ssex,UserMobile,UserBirthday,Sage,Sdept from Student,SysUser where Student.Sno=SysUser.UserSchoolID and UserID='" + select_name + "'";
                SqlCommand cmd = new SqlCommand(select_a, connection); 
                SqlDataReader dr = cmd.ExecuteReader();//读取数据
                dr.Read();
                if (dr.HasRows)
                {
                    labelsno.Text=dr[0].ToString();
                    labelsname.Text = dr[1].ToString();
                    labelssex.Text = dr[2].ToString();
                    labelsphone.Text = dr[3].ToString();
                  //  labelsbirth.Text = dr[4].ToString();
                    labelsbirth.Text = Convert.ToString(dr.GetDateTime(4).ToShortDateString());
                    labelsage.Text = dr[5].ToString();
                    labelsdept.Text = dr[6].ToString();                   
                }
                else { MessageBox.Show("您的信息还未录入！"); }
                dr.Close();

                //显示图片,如果图片显示不全，将pictureBox的SizeMode改为Zoom,图片的长宽比例不变
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






               



                connection.Close();
            }

            catch
            {
                MessageBox.Show("显示信息失败！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
