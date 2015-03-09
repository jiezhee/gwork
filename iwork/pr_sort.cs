using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBUtility;
using System.Text.RegularExpressions;

namespace iwork
{
    public partial class pr_sort : Form
    {
     
        public pr_sort()
        {
            InitializeComponent();
        }

        public string sql = string.Empty;
        private int flag = 0;    
        private string str1 = string.Empty;
        public DataSet dsData=new DataSet();
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (t1.Text == string.Empty && t2.Text == string.Empty )
            {
                //all empty
                MessageBox.Show("输入搜索条件");
                return;
            }
        
                    sql = "select code,name,num,描述 from [production] where";               //有非空的
                    if (t1.Text != string.Empty)
                    {
                        sql += "[code]='" + t1.Text + "'";
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
                        sql += str1 + "[name]='" + t2.Text + "'";

                    }
                  
                   
                    dsData = DbHelperSQL.Query(sql);
                    if (dsData.Tables[0].Rows.Count == 0)
                        MessageBox.Show("没有符合条件的记录");
                    else
                    {
                        //找到符合的记录
                        this.DialogResult = DialogResult.OK;
                    }
                    flag = 0;
   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            t1.Text = null;
            t2.Text = null;

        }

        private void pr_sort_Load(object sender, EventArgs e)
        {

        }
    }
}
