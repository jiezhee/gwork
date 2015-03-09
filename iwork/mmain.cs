using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace iwork
{
    public partial class mmain : Form
    {
        public mmain()
        {
            InitializeComponent();
        }

        private void mmain_Load(object sender, EventArgs e)
        {
             string s = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
            
             if (s == "new")
             {
                 //需要初始化
                 MessageBox.Show("进入初始化服务器");
                 初始化 csh = new 初始化();
                 csh.ShowDialog();
                 this.Close();
             }
             this.Hide();
             login l = new login();
             l.ShowDialog();
             if (l.DialogResult == DialogResult.OK)
             {
                 this.Close();
             }
           
            
        }
    }
}
