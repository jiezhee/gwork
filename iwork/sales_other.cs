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
    public partial class sales_other : Form
    {
        public sales_other()
        {
            InitializeComponent();
        }
        public string ordernum;
        public string dt;
        public string ver_num;
        private string sql = string.Empty;

        private int k = 0;//psn[k]
        private int i = 0;
        private bool changed = false;
        private bool flag = false;//true为已点击保存，退出不需提示保存

        private string str1 = string.Empty;
        private string IDSelected = string.Empty;

        private struct rec_editpsn
        {
            public int x;
            public int y;
        }//变化表

        rec_editpsn[] psn = new rec_editpsn[100];

        public void search()
        {

            sql = "SELECT  * FROM  其他零部件 where 订单编号='"+ordernum+"' order by 编号 desc";
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql);

            dgv1.AutoGenerateColumns = false;
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            this.dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中
        }

        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search();
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //添加
            sql = "insert into 其他零部件([订单日期],[订单编号],[版本号],[核销]) values('";
            sql += dt + "','" + ordernum + "','" + ver_num + "','未完成')";
            DbHelperSQL.ExecuteSql(sql);
            search();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed == true)
            {
                string colname = string.Empty;
                string rowname = string.Empty;

                for (i = 0; i < k; i++)
                {
                    colname = dgv1.Columns[psn[i].y].Name;//列名
                    rowname = dgv1.Rows[psn[i].x].Cells["编号"].Value.ToString();//行名-编号
                    sql = "update 其他零部件 set " + colname + "='";

                    sql += dgv1.Rows[psn[i].x].Cells[psn[i].y].Value.ToString() + "'";
                    sql += " where 编号='" + rowname + "'";
                    DbHelperSQL.ExecuteSql(sql);
                }

                    MessageBox.Show("已保存");
                    changed = false;
                    k = 0;
                    flag = true;

            }
            else
                MessageBox.Show("记录无变化"); 
        }

        private void sales_other_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
            {
                if (changed == true)
                {
                    DialogResult result = MessageBox.Show("记录发生变化，是否保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string colname = string.Empty;
                        string rowname = string.Empty;
                        for (i = 0; i < k; i++)
                        {
                            colname = dgv1.Columns[psn[i].y].Name;//列名
                            rowname = dgv1.Rows[psn[i].x].Cells["编号"].Value.ToString();//行名-编号
                            sql = "update 其他零部件 set " + colname + "='";
                            sql += dgv1.Rows[psn[i].x].Cells[psn[i].y].Value.ToString() + "'";
                            sql += " where 编号='" + rowname + "'";
                            DbHelperSQL.ExecuteSql(sql);
                        }
                            MessageBox.Show("已保存");
                    }
                    else
                    {
                        MessageBox.Show("修改未保存");
                        return;
                    }
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (IDSelected == string.Empty)
            {
                MessageBox.Show("选择删除行");
                return;
            }
            DialogResult result = MessageBox.Show("确定删除吗？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "delete from [其他零部件]  ";
                sql += " WHERE [编号]='" + IDSelected + "'";
                DBUtility.DbHelperSQL.ExecuteSql(sql);
                dgv1.Rows.RemoveAt(dgv1.CurrentCell.RowIndex);
                search();
            }
            IDSelected = string.Empty;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {//dgv不空
                IDSelected = dgv1.Rows[dgv1.CurrentRow.Index].Cells["编号"].Value.ToString();

                if (e.ColumnIndex != -1)
                {//点标题不触发
                   
                    if (this.dgv1.Columns[e.ColumnIndex].Name == "核销")
                    {
                        if (this.dgv1.CurrentCell.Value.ToString() == "未完成")
                        {
                            DialogResult result = MessageBox.Show("确定修改为已完成？", "确定修改？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                dgv1.CurrentCell.Value = "完成";
                                sql = "update 其他零部件 set [核销] ='完成' where 编号='" + dgv1.CurrentRow.Cells["编号"].Value.ToString() + "'";
                                DbHelperSQL.ExecuteSql(sql);
                                //  Search();
                            }
                        }
                    }
                }
            }
        }

        private void sales_other_Load(object sender, EventArgs e)
        {
            search();
        }

        private void dgv1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ("未完成" == this.dgv1.Rows[e.RowIndex].Cells["核销"].Value.ToString())
            {
                this.dgv1.Rows[e.RowIndex].Cells["核销"].Style.BackColor = Color.LightGreen;
            }
            else
                if ("完成" == this.dgv1.Rows[e.RowIndex].Cells["核销"].Value.ToString())
                {
                    this.dgv1.Rows[e.RowIndex].Cells["核销"].Style.BackColor = Color.LightGray;
                }

        }

        private void dgv1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv1.CurrentCell.Value != null)
            {
                if (str1 != dgv1.CurrentCell.Value.ToString())
                {//有变化，记录到变化表psn[]
                    if (changed == false)
                    {
                        changed = true;
                    }
                    psn[k].x = dgv1.CurrentCell.RowIndex;
                    psn[k].y = dgv1.CurrentCell.ColumnIndex;
                    k++;


                }
            }


      


            //计算总额
            if (dgv1.Columns[e.ColumnIndex].Name == "销售单价")
            {
                if (dgv1.CurrentRow.Cells["销售单价"].Value.ToString() != string.Empty)
                {
                    if (numcheck.IsFloat(dgv1.CurrentRow.Cells["销售单价"].Value.ToString()) == true)
                    {
                        if (dgv1.CurrentRow.Cells["签订数量"].Value.ToString() != string.Empty)
                        {
                            float x = float.Parse(dgv1.CurrentRow.Cells["销售单价"].Value.ToString());
                            float y = float.Parse(dgv1.CurrentRow.Cells["签订数量"].Value.ToString());
                            dgv1.CurrentRow.Cells["销售金额"].Value = (x * y).ToString();
                            sql = "update 其他零部件 set 销售金额='" + dgv1.CurrentRow.Cells["销售金额"].Value.ToString() + "' where 编号='" + dgv1.CurrentRow.Cells["编号"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);

                        }
                    }
                    else
                    {
                        MessageBox.Show("单价为小数格式");
                        dgv1.CurrentCell.Value = null;
                        return;
                    }
                }
                else
                {
                    sql = "update 其他零部件 set 销售金额='0' where 编号='" + dgv1.CurrentRow.Cells["编号"].Value.ToString() + "'";
                    dgv1.CurrentRow.Cells["销售金额"].Value = "0";
                    DbHelperSQL.ExecuteSql(sql);
                }
            }


            if (dgv1.Columns[e.ColumnIndex].Name == "签订数量")
            {
                if (dgv1.CurrentRow.Cells["签订数量"].Value.ToString() != string.Empty)
                {
                    if (numcheck.IsPositiveInteger(dgv1.CurrentRow.Cells["签订数量"].Value.ToString()) == true)
                    {
                        if (dgv1.CurrentRow.Cells["销售单价"].Value.ToString() != string.Empty)
                        {
                            //不为空肯定是通过了检查的
                            float x = float.Parse(dgv1.CurrentRow.Cells["销售单价"].Value.ToString());

                            float y = float.Parse(dgv1.CurrentRow.Cells["签订数量"].Value.ToString());
                            dgv1.CurrentRow.Cells["销售金额"].Value = (x * y).ToString();
                            sql = "update 其他零部件 set 销售金额='" + dgv1.CurrentRow.Cells["销售金额"].Value.ToString() + "' where 编号='" + dgv1.CurrentRow.Cells["编号"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);
                        }

                    }
                    else
                    {
                        MessageBox.Show("数量只能是正整数");
                        dgv1.CurrentCell.Value = null;
                        return;
                    }
                }
                else
                {
                    sql = "update 其他零部件 set 销售金额='0' where 编号='" + dgv1.CurrentRow.Cells["编号"].Value.ToString() + "'";
                    dgv1.CurrentRow.Cells["销售金额"].Value = "0";
                    DbHelperSQL.ExecuteSql(sql);
                }
            }

            if (flag == true)
                flag = false;
     
        }

        private void dgv1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgv1.CurrentCell.Value != null)
                str1 = dgv1.CurrentCell.Value.ToString();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
