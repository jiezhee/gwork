using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iwork
{
    public partial class ma_add : Form
    {
        public ma_add()
        {
            InitializeComponent();
        }
        public string sql = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {

             
         }

        private void ma_add_Load(object sender, EventArgs e)
        {
            DBUtility.DbHelperSQL.ExecuteReader_combobox("select 供应商 from 供应商信息", c3);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sql = "INSERT INTO [material]([料号],[品名],[型号规格],[单位],[供应商],[类别],[备注]) VALUES(";
            if (this.t1.Text == string.Empty)
            {
                MessageBox.Show("料号不能为空");
                return;
            }
            else
            {

                sql += "'" + this.t1.Text + "',";
            }


            if (this.t2.Text == string.Empty)
            {
                MessageBox.Show("品名不能为空");
                return;
            }
            else
            {

                sql += "'" + this.t2.Text + "',";
            }


            if (this.c1.Text == string.Empty)
            {
                MessageBox.Show("型号规格不能为空");
                return;
            }
            else
            {
                sql += "'" + this.c1.Text + "',";
            }


            if (this.c2.Text == string.Empty)
            {
                MessageBox.Show("单位不能为空");
                return;
            }
            else
            {
                sql += "'" + this.c2.Text + "',";
            }

            if (this.c3.Text == string.Empty)
            {
                MessageBox.Show("供应商不能为空");
                return;
            }
            else
            {
                sql += "'" + this.c3.Text + "',";
            }

            if (this.c4.Text == string.Empty)
            {
                MessageBox.Show("类别不能为空");
                return;
            }
            else
            {
                sql += "'" + this.c4.Text + "',";
            }

            sql += "'" + this.t3.Text + "')";//备注

            if (1 == DBUtility.DbHelperSQL.ExecuteSql(sql))
            {
                MessageBox.Show("添加成功");
                this.Close();
            }
        }
        
        
    }
}
