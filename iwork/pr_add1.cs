using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBUtility;
using digits;

namespace iwork
{
    public partial class pr_add1 : Form
    {
        public pr_add1()
        {
            InitializeComponent();
        }
        public int count = 0;//成品编码（物料添加时需要用到）
        private string sql = string.Empty;
        private int i = 0;
        private void 确认录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells["用量"].Value != null)
                {
                    if (numcheck.isnum(dgv.Rows[i].Cells["用量"].Value.ToString()) == false)
                    {
                        MessageBox.Show("用量只能为整数！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("用量为空无意义！");
                    return;
                }
            }
            sql = "insert into production([code],[name],[描述])values('";
            sql += textBox1.Text + "','";
            sql += textBox2.Text + "','";
            sql += textBox3.Text + "')";
            //添加到成品表
            if (1 != DbHelperSQL.ExecuteSql(sql))
            {
                MessageBox.Show("录入失败");
                return;
            }

            count = DbHelperSQL.maxnum("num", "production"); //刚才加入的成品的num
     
            //添加到pr_ma关系表
            for (i = 0; i < dgv.Rows.Count; i++)
            {
                sql = "insert into pr_ma([pr_num],[ma_num]) values('" + count.ToString() + "','";
                sql += dgv.Rows[i].Cells[0].Value.ToString() + "')";
                if (1 != DbHelperSQL.ExecuteSql(sql))
                {
                    MessageBox.Show("录入失败");
                    return;
                }

            }

            //存储料号，品名，型号规格，单位，供应商，使用位置，用量,备注
            for (i = 0; i < dgv.Rows.Count; i++)
            {
                    sql = "update pr_ma set ";
                    sql += "[用量]='" + dgv.Rows[i].Cells["用量"].Value.ToString() + "'";

                    if (dgv.Rows[i].Cells["使用位置"].Value != null)
                    {
                        sql += ",[使用位置]='" + dgv.Rows[i].Cells["使用位置"].Value.ToString() + "'";

                    }
                    if (dgv.Rows[i].Cells["料号"].Value != null)
                    {
                        sql += ",[料号]='" + dgv.Rows[i].Cells["料号"].Value.ToString() + "'";

                    }
                    if (dgv.Rows[i].Cells["品名"].Value != null)
                    {
                        sql += ",[品名]='" + dgv.Rows[i].Cells["品名"].Value.ToString() + "'";

                    }
                    if (dgv.Rows[i].Cells["型号规格"].Value != null)
                    {
                        sql += ",[型号规格]='" + dgv.Rows[i].Cells["型号规格"].Value.ToString() + "'";

                    }
                    if (dgv.Rows[i].Cells["单位"].Value != null)
                    {
                        sql += ",[单位]='" + dgv.Rows[i].Cells["单位"].Value.ToString() + "'";

                    }
                    if (dgv.Rows[i].Cells["供应商"].Value != null)
                    {
                        sql += ",[供应商]='" + dgv.Rows[i].Cells["供应商"].Value.ToString() + "'";

                    }

                    if (dgv.Rows[i].Cells["备注"].Value != null)
                    {

                        sql += ",[BOM备注]='" + dgv.Rows[i].Cells["备注"].Value.ToString() + "' ";

                    }

                    sql += "where pr_num='" + count.ToString() + "' and ma_num='" + dgv.Rows[i].Cells[0].Value.ToString() + "'";
  
                    if (1 != DbHelperSQL.ExecuteSql(sql))
                    {
                        MessageBox.Show("录入失败");
                        return;
                    }

 
            }

            MessageBox.Show("录入成功");
            this.Close();

        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pr_add1_Load(object sender, EventArgs e)
        {
           

        }

        private void 物料添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            pr_add2 pa2 = new pr_add2();
            pa2.GetForm(this);
            pa2.which = 1;
            pa2.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

   

      
    }
}
