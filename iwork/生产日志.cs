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
    public partial class 生产日志 : Form
    {
        public 生产日志()
        {
            InitializeComponent();
        }
        private string sql = string.Empty;
        string str2 = string.Empty;
        int tag = 0;

        private DataSet dsData = new DataSet();

        public void search(string ss)
        {
            sql = "select "+ss+" from 生产日志 order by 编号 desc";
            dsData = DbHelperSQL.Query(sql);

            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中
        }

        private void 生产日志_Load(object sender, EventArgs e)
        {
            search("top(100)*");

        }

        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tag == 0)
            {
                str2 = "*";//全选
                tag = 1;
                浏览ToolStripMenuItem.Text = "最近100记录";
            }
            else
            {
                str2 = "top(100)*";//选前50个记录
                tag = 0;
                浏览ToolStripMenuItem.Text = "全部记录";
            }
            search(str2);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
