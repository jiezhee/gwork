using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DBUtility;

namespace iwork
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public string username = string.Empty;
        public string psd = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            username=t1.Text;
            psd=t2.Text;
       
            if (DbHelperSQL.isin(username, "用户名", "用户管理") == true)
            {
               
                if (psd == DbHelperSQL.execscalar("select 密码 from 用户管理 where 用户名='" + username+"'"))
                {//登陆成功 
                   
                    this.Hide();
                    main m = new main();
                    m.username = username;
                    m.ShowDialog();
                    if (m.DialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("密码错误,请重新输入");
                    t2.Text = string.Empty;
                }
            }
            else
                MessageBox.Show("用户名不存在");

           
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            用户注册 yhzc = new 用户注册();
            yhzc.ShowDialog();
        }
    }
}
