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
    public partial class 修改密码 : Form
    {
        public 修改密码()
        {
            InitializeComponent();
        }
        public string sql = string.Empty;
        public string user = string.Empty;
        private string pwd_old = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            if (pwd_old == t1.Text)
            {
                if ((t2.Text == string.Empty) && (t3.Text ==string.Empty))
                {
                    MessageBox.Show("新密码不能为空!");
                }
                else
                {
                    if (t2.Text == t3.Text)
                    {
                        sql = "update 用户管理 set 密码='" + t2.Text + "'" + "where 用户名='" + user + "'";
                        DbHelperSQL.Query(sql);
                        MessageBox.Show("修改成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("两次密码输入不一致，请重新输入！");
                    }
                }
            }
            else
            {
                MessageBox.Show("旧密码输入错误,请重新输入");
                t1.Text = string.Empty;
            }
        }

        private void 修改密码_Load(object sender, EventArgs e)
        {
            sql = "select 密码 from 用户管理 where 用户名='" + user + "'";
            pwd_old = DbHelperSQL.execscalar(sql);
        }
    }
}
