using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dazuoye2
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //static类型+函数用于实现窗体间传递学生账号
        static String name;
        public string Get()
        {
            return name;
        }
        public void ShowCode()   //验证码取值
        {
            labelcode.Text = "";
            //随机实例化 
            Random ran = new Random();
            int number;
            char code1;
            //取五个数 
            for (int i = 0; i < 5; i++)
            {
                number = ran.Next();
                if (number % 2 == 0)
                    code1 = (char)('1' + (char)(number % 9));
                //由于O与0经常混淆，所以数字从1-9，大写英文字母A-Z
                else
                    code1 = (char)('A' + (char)(number % 26)); //转化为字符 

                this.code += code1.ToString();
            }

            labelcode.Text = code;

        }

        public string code;


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowCode();
        }

        private void linkLabelregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            
        }

        private void linkLabelchange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.code = "";
            ShowCode();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string identity;
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text.Trim();  //取出账号
            string password = EncryptWithMD5(textBoxpassword.Text.Trim());  //取出密码并加密        
            name = username;
           
            if (radioButtonadmin.Checked)
            {
                identity = radioButtonadmin.Text;
            }
            else if (radioButtonstudent.Checked)
            {
                identity = radioButtonstudent.Text;
            }
            string myConnString = "Data Source =.; Initial Catalog = School;  Persist Security Info = True;User ID = sa; Password = 123";

            SqlConnection sqlConnection = new SqlConnection(myConnString);  //实例化连接对象
            sqlConnection.Open();

           
            string sql = "select UserID,UserPassword,UserIdentity  from SysUser where UserID = '" + username + "' and UserPassword = '" + password + "' and UserIdentity='"+identity+"'";                                            //编写SQL命令
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows && textBoxcode.Text == code && radioButtonstudent.Checked)//学生成功登录
            {            
                    MessageBox.Show("欢迎使用！");             //登录成功
                    this.Hide();
                    StudentMain studentmain = new StudentMain();
                    studentmain.ShowDialog();
                                                                  
            }
            if (sqlDataReader.HasRows && textBoxcode.Text == code && radioButtonadmin.Checked)//管理员成功登录
            {
                MessageBox.Show("欢迎使用！");  
                this.Hide();           //登录成功
                AdminMain adminmain = new AdminMain();
                adminmain.ShowDialog();
                
            }                  
            if (textBoxcode.Text != code)       //验证码输入错误，登录失败
            {
                MessageBox.Show("验证码错误！");
                return;
            }
            if (!sqlDataReader.HasRows)         //用户名或密码错误，登录失败
            {
                MessageBox.Show("密码错误或该用户不存在！");
                return;
            }
            if (!radioButtonstudent.Checked && !radioButtonadmin.Checked)        //未选择身份
            {
                MessageBox.Show("请选择登录身份！");
                return;
            }

            sqlDataReader.Close();
            sql = "insert into SysLog values ( '" + username + "' , '" + DateTime.Now + "' , '" + "Login" + "')";                                            //编写SQL命令
            sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();


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

        private void labelcode_Click(object sender, EventArgs e)
        {

        }
    }
}
