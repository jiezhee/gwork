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
    public partial class 库存信息添加 : Form
    {
        public 库存信息添加()
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
                isin = DbHelperSQL.isin(t1.Text, "物料NO", "物料库存信息");
                if (isin ==true)
                {
                    MessageBox.Show("该物料已在库存中");
                    return;
                 
                }
            }

            if (t2.Text != string.Empty)
            {
                isin = DbHelperSQL.isin(t2.Text, "料号", "物料库存信息");
                if (isin == true)
                {
                    MessageBox.Show("该物料已在库存中");
                    return;
                }
            }



            //在库存信息里没有，去物料表里添加
            sql = "select NO,料号,品名 from [material] where";               //有非空的
            if (t1.Text != string.Empty)
            {
                sql += "[NO]='" + t1.Text + "'";
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
                sql += str1 + "[料号]='" + t2.Text + "'";
            }
            ds = DbHelperSQL.Query(sql);
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("没有符合条件的物料，请确定添加信息");
            else
            {
                //找到符合的记录
                this.DialogResult = DialogResult.OK;
         
                sql = "insert into 物料库存信息(物料NO,料号,品名) " + sql;
                DbHelperSQL.ExecuteSql(sql);
                MessageBox.Show("添加成功");
                this.Close();
            }
        }
    }
}
