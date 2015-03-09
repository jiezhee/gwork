using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBUtility;
namespace iwork
{
    public partial class 用户注册 : Form
    {
        public 用户注册()
        {
            InitializeComponent();
        }
        public string sql = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            if (t2.Text == t3.Text)
            {
                sql = "insert into 用户管理(用户名,密码) values(";
                sql += "'" + t1.Text + "',";
                sql += "'" + t2.Text + "')";
                DbHelperSQL.ExecuteSql(sql);
                MessageBox.Show("注册成功!");
                this.Close();
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
            }
        }
    }
}
