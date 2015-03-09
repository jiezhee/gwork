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
    public partial class ma_edit : Form
    {
        public ma_edit()
        {
            InitializeComponent();
        }
        public string sql = string.Empty;
        public string editcode = string.Empty;
        public string gys= string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {

            sql = "UPDATE [material] SET ";
            sql += "[料号]='" + this.t1.Text + "',";
            sql += "[品名]='" +this.t2.Text + "',";
            sql += "[型号规格]='" + this.c1.Text + "',";
            sql += "[单位]='" + this.c2.Text + "',";
            sql += "[供应商]='" + this.c3.Text + "',";
            sql += "[类别]='" + this.c4.Text + "',";
            sql += "[备注]='" + this.t3.Text + "'";
            sql += " WHERE [NO]='" + editcode + "'";
            if (1 == DBUtility.DbHelperSQL.ExecuteSql(sql))
            {
                MessageBox.Show("编辑成功");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ma_edit_Load(object sender, EventArgs e)
        {
            DBUtility.DbHelperSQL.ExecuteReader_combobox("select 供应商 from 供应商信息", c3);
            this.c3.Text = gys;
        }
    }
}
