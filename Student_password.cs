using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dazuoye2
{
    public partial class Student_password : Form
    {
        public Student_password()
        {
            InitializeComponent();
        }
        public static string EncryptWithMD5(string source)      //MD5加密
        {
            byte[] sor = Encoding.UTF8.GetBytes(source);
            MD5 md5 = MD5.Create();
            byte[] result = md5.ComputeHash(sor);
            StringBuilder strbul = new StringBuilder(40);
            for (int i = 0; i < result.Length; i++)
            {
                strbul.Append(result[i].ToString("x2"));//加密结果"x2"结果为32位,"x3"结果为48位,"x4"结果为64位
            }
            return strbul.ToString();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 m = new Form1();
                string select_name = m.Get();
                string newpassword = textBoxnewpassword.Text.Trim();
                string newpassword1 = textBoxnewpassword1.Text.Trim();
                string connString = "Data Source=.;Initial Catalog=School;Persist Security Info=True;User ID=sa;Password=123";//数据库连接字符串
                SqlConnection connection = new SqlConnection(connString);//创建connection对象              
                connection.Open(); //打开数据库连接

                if (textBoxusername.Text.Trim() == select_name)
                {
                    if (newpassword == newpassword1)//密码与确认密码的内容相同
                    {
                        string sql = "update SysUser set UserPassWord = @upw where UserID = @id";
                        SqlCommand cmd = new SqlCommand(sql, connection);

                        SqlParameter sqlParameter = new SqlParameter("@upw", EncryptWithMD5(textBoxnewpassword.Text.Trim()));
                        cmd.Parameters.Add(sqlParameter);
                        SqlParameter sqlParameter1 = new SqlParameter("@id", textBoxusername.Text.Trim());
                        cmd.Parameters.Add(sqlParameter1);

                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("密码修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("请再次检查输入的密码是否正确！");
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确的用户名！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMain s = new StudentMain();
            s.Show();
        }

        private void textBoxnewpassword_Leave(object sender, EventArgs e)//密码
        {
            if (textBoxnewpassword.Text.Trim() != "")
            {
                //使用regex（正则表达式）进行格式设置 至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符。
                Regex regex = new Regex(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{3,20}");
                if (regex.IsMatch(textBoxnewpassword.Text))//判断格式是否符合要求
                {
                    //MessageBox.Show("输入密码格式正确!");
                }
                else
                {
                    MessageBox.Show("至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符！");
                    textBoxnewpassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("密码不能为空！");
            }
        }

        private void textBoxnewpassword1_Leave(object sender, EventArgs e)//确认新密码
        {
            if (textBoxnewpassword1.Text.Trim() != "")
            {
                //使用regex（正则表达式）进行格式设置 至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符。
                Regex regex = new Regex(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{3,20}");

                if (regex.IsMatch(textBoxnewpassword1.Text))//判断格式是否符合要求
                {
                    //MessageBox.Show("输入密码格式正确!");
                }
                else
                {
                    MessageBox.Show("至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符！");
                    textBoxnewpassword1.Focus();
                }
            }
            else
            {
                MessageBox.Show("确定密码不能为空！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }
    }
}
