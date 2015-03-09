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
    public partial class 库存_新增成品 : Form
    {
        public 库存_新增成品()
        {
            InitializeComponent();
        }

        private string sql = string.Empty;
        private int flag = 0;
        private string str1 = string.Empty;
        private bool isin = false;
        private DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == string.Empty && t2.Text == string.Empty)
            {
                //all empty
                MessageBox.Show("输入添加信息");
                return;
            }

            if (t1.Text != string.Empty)
            {
                isin = DbHelperSQL.isin(t1.Text, "代码", "成品库存信息");
                if (isin == true)
                {
                    MessageBox.Show("该物料已在库存中");
                    return;

                }
            }

            if (t2.Text != string.Empty)
            {
                isin = DbHelperSQL.isin(t2.Text, "名称", "成品库存信息");
                if (isin == true)
                {
                    MessageBox.Show("该物料已在库存中");
                    return;
                }
            }



            //在库存信息里没有，去物料表里添加
            sql = "select code,name from [production] where";               //有非空的
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
            ds = DbHelperSQL.Query(sql);
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("没有符合条件的成品，请确定添加信息");
            else
            {
                //找到符合的记录
                this.DialogResult = DialogResult.OK;

                sql = "insert into 成品库存信息(代码,名称) " + sql;
                DbHelperSQL.ExecuteSql(sql);

                int temp3 = DbHelperSQL.maxnum("编号", "成品库存信息");
                sql = "update 成品库存信息 set 库存='0' where 编号='" + temp3.ToString() + "'";
                DbHelperSQL.ExecuteSql(sql);

                MessageBox.Show("添加成功");
                this.Close();
            }
        }
    }
}
