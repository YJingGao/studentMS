using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dazuoye2
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“schoolDataSet2.SysLog”中。您可以根据需要移动或删除它。
            this.sysLogTableAdapter.Fill(this.schoolDataSet2.SysLog);

        }

        private void buttonclose_Click(object sender, EventArgs e)//关闭按钮
        {
            this.Close();
            AdminMain a = new AdminMain();
            a.Show();
        }

        private void Admin_login_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }

        private void buttonchange_Click(object sender, EventArgs e)//刷新
        {
            this.sysLogTableAdapter.Fill(this.schoolDataSet2.SysLog);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
