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
    public partial class ma_sort : Form
    {
        public ma_sort()
        {
            InitializeComponent();
        }
        public material fform=null;
        public string sql = string.Empty;
        private int flag = 0;
        private string str1 = string.Empty;
      
        public void GetForm(material theform)
        {
            fform = theform;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            TT t = new TT();
            bool isint = false;
            bool flag1 = false;
            if (t1.Text == string.Empty && t2.Text == string.Empty && t4.Text == string.Empty &&
               c1.Text == string.Empty && c2.Text == string.Empty && c3.Text == string.Empty && c4.Text == string.Empty)
            {//all empty
                MessageBox.Show("输入筛选条件");
                return;
            }
            else
            {//有不为空的
                if (t4.Text != string.Empty)
                    isint = t.isnum(t4.Text.ToString());
                else
                    flag1 = true;//NO为空，其他有不空的
            }

            if (isint || flag1)
            {
                sql = "select * from [material] where";
                if (t4.Text != string.Empty)
                {
                    sql += "[NO]='" + t4.Text + "'";
                    flag = 1;//之前的属性有非空的
                }
                if (t1.Text != string.Empty)
                {
                    if (flag == 1)
                        str1 = " and ";
                    else
                    {
                        str1 = "";
                        flag = 1;
                    }
                    sql += str1 + "[料号]='" + t1.Text + "'";

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
                        sql += str1 + "[品名]='" + t2.Text + "'";

                    }

                    if (c1.Text != string.Empty)
                    {
                        if (flag == 1)
                            str1 = " and ";
                        else
                        {
                            str1 = "";
                            flag = 1;
                        }
                        sql += str1 + "[型号规格]='" + c1.Text + "'";

                    }

              

                    if (c2.Text != string.Empty)
                    {
                        if (flag == 1)
                            str1 = " and ";
                        else
                        {
                            str1 = "";
                            flag = 1;
                        }
                        sql += str1 + "[单位]='" + c2.Text + "'";

                    }

                    if (c4.Text != string.Empty)
                    {
                        if (flag == 1)
                            str1 = " and ";
                        else
                        {
                            str1 = "";
                            flag = 1;
                        }
                        sql += str1 + "[类别]='" + c4.Text + "'";

                    }

                    if (c3.Text != string.Empty)
                    {
                        if (flag == 1)
                            str1 = " and ";
                        else
                        {
                            str1 = "";
                            flag = 1;
                        }
                        sql += str1 + "[供应商]='" + c3.Text + "'";

                    }


                DataSet dsData = new DataSet();
                dsData = DbHelperSQL.Query(sql);
                if (dsData.Tables[0].Rows.Count == 0)
                    MessageBox.Show("没有符合条件的记录");
                else
                {

                    fform.dgv1.AutoGenerateColumns = false;
                    BindingSource s = new BindingSource();
                    s.DataSource = dsData.Tables[0];
                    fform.dgv1.DataSource = s;
                    fform.dgv1.ClearSelection(); //取消选中
                    this.Close();
                }
                flag = 0;
            }
            else
                MessageBox.Show("代码只能为数字");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Text = null;
            t2.Text = null;
            t4.Text = null;
            c1.Text = null;
            c2.Text = null;
            c3.Text = null;
            c4.Text = null;
            
        }

        private class TT
        {
            public bool isnum(string s)
            {
                string pattern = "^[0-9]*$";
                Regex rx = new Regex(pattern);
                return rx.IsMatch(s);
            }

        }

        private void ma_sort_Load(object sender, EventArgs e)
        {

        }

    }
}
