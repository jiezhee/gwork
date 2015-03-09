using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appconfig_seting;
namespace iwork
{
    public partial class 初始化 : Form
    {
        public 初始化()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appconfig_set.SetKeyValue("ConnectionString", "server=" + t1.Text + ";user=sa;pwd=111111;database=greenlight;","//appSettings");
            MessageBox.Show("初始化成功");  
            this.Close();
        }
    }
}
