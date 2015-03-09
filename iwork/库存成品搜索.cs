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
    public partial class 库存成品搜索 : Form
    {
        public 库存成品搜索()
        {
            InitializeComponent();
        }

        private string sql = string.Empty;
        private int flag = 0;
        private string str1 = string.Empty;
        public DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == string.Empty && t2.Text == string.Empty)
            {
                //all empty
                MessageBox.Show("输入搜索条件");
                return;
            }

            sql = "select * from [成品库存信息] where";               //有非空的
            if (t1.Text != string.Empty)
            {
                sql += "[代码]='" + t1.Text + "'";
                flag = 1;//之前的属性有非空的
            }
            if (t2.Text != string.Empty)
            {
                if (flag == 1)
                    str1 = " and ";
                else
                {
                    str1 = "";
                    flag = 1;
                }
                sql += str1 + "[名称]='" + t2.Text + "'";

            }


            ds = DbHelperSQL.Query(sql);
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("没有符合条件的记录");
            else
            {
                //找到符合的记录
                this.DialogResult = DialogResult.OK;
            }
            flag = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = null;
            t2.Text = null;
        }
    }
}
