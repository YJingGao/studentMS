using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dazuoye2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public Byte[] mybyte = new byte[0];

        public static string EncryptWithMD5(string source)  //MD5加密
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

        private void buttonphoto_Click(object sender, EventArgs e)
        {
            //打开浏览图片对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string picturePath = openFileDialog.FileName;//获取图片路径
            //文件的名称，每次必须更换图片的名称，这里很为不便
            //创建FileStream对象
            FileStream fs = new FileStream(picturePath, FileMode.Open, FileAccess.Read);
            //声明Byte数组
            mybyte = new byte[fs.Length];
            //读取数据
            fs.Read(mybyte, 0, mybyte.Length);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";//数据库连接字符串
                SqlConnection connection = new SqlConnection(connString);//创建connection对象
                string sql = "insert into SysUser (UserID,   UserPassWord ,   UserSchoolID, UserMobile, UserBirthday , UserIdentity , UserPhoto ) " +
                                                        "values (@userid, @userpassword,@userschoolid,@usermobile,@userbirthday,@useridentity,@userphoto)";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlParameter sqlParameter = new SqlParameter("@userid", textBoxusername.Text);
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@userpassword", EncryptWithMD5(textBoxpassword.Text));
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@userschoolid", textBoxid.Text);
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@usermobile", textBoxmobile.Text);
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@userbirthday", dateTimePickerbirth.Value);
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@useridentity", comboBoxidentity.Text);
                command.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@userphoto", SqlDbType.VarBinary, mybyte.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mybyte);
                command.Parameters.Add(sqlParameter);

                //打开数据库连接
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("注册成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void buttonquit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ff = new Form1();
            ff.Show();
        }

        private void textBoxusername_Leave(object sender, EventArgs e)
        {
            if (textBoxusername.Text.Trim() != "")
            {
                //使用regex（正则表达式）进行格式设置 至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符。
                Regex regex = new Regex(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{3,20}");

                if (regex.IsMatch(textBoxusername.Text))//判断格式是否符合要求
                {
                    //MessageBox.Show("输入用户名格式正确!");
                }
                else
                {
                    MessageBox.Show("至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符！");
                    textBoxusername.Focus();
                }
            }
            else
            {
                MessageBox.Show("用户名不能为空！");
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxpassword_Leave_1(object sender, EventArgs e)
        {
            if (textBoxpassword.Text.Trim() != "")
            {
                //使用regex（正则表达式）进行格式设置 至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符。
                Regex regex = new Regex(@"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{3,20}");

                if (regex.IsMatch(textBoxpassword.Text))//判断格式是否符合要求
                {
                    //MessageBox.Show("输入密码格式正确!");
                }
                else
                {
                    MessageBox.Show("至少有数字、大写字母、小写字母各一个。最少3个字符、最长20个字符！");
                    textBoxpassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("密码不能为空！");
            }
        }
    }
}
