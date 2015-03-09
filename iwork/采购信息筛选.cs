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
    public partial class 采购信息筛选 : Form
    {
        public 采购信息筛选()
        {
            InitializeComponent();
        }

        public DataSet ds = new DataSet();
        private string sql = string.Empty;
        private bool flag = false;//标记前面列有没有空
    //    private bool flag1 = true;//标记是否第一次进入筛选
        private string str1 = string.Empty;
            
        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            t1.Text = null;
            t2.Text = null;
            dtp1.Text = null;
            dtp2.Text = null;
      
        }

      private void 确定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             if ( dtp1.Value>dtp2.Value)
            {
                if (dtp1.Value.ToShortDateString()!=dtp2.Value.ToShortDateString())
                {
                    MessageBox.Show("开始时间不能大于结束时间");
                    return;
                }
            }

            sql = "select * from [采购信息] where ";               //有非空的
            if (t1.Text != string.Empty)
            {
                sql += "[物料NO]='" + t1.Text + "'";
                flag = true;//之前的属性有非空的
            }
            if (t2.Text != string.Empty)
            {
                if (flag == true)
                    str1 = " and ";
                else
                {
                    str1 = "";
                    flag = true;
                }
                sql += str1 + "[料号]='" + t2.Text + "'";
            }

            if (flag == false)
            {
                //处理日期
                //前面都为空
                str1 = "";
            }
            else
                str1 = " and ";

            sql += str1+" [日期] between '" + dtp1.Value.ToString("yyyy-MM-dd") + " 00:00:00' and '" + dtp2.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
 

            ds = DbHelperSQL.Query(sql);
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("没有符合条件的记录");
            else
            {
                //找到符合的记录
                this.DialogResult = DialogResult.OK;
            }
            flag = false;
        }
        
    }
}
