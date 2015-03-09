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
    public partial class 今日生产总结 : Form
    {
        public 今日生产总结()
        {
            InitializeComponent();
        }
        private string sql = string.Empty;
        private  DataSet dsData = new DataSet();


        private int k = 0;//psn[k]
        private bool changed = false;
        private bool flag = false;//true为已点击保存，退出不需提示保存

        private string str1 = string.Empty;
        private string IDSelected = string.Empty;

        private void 添加待生产产品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            添加待生产订单 tjdsc = new 添加待生产订单();
            tjdsc.ShowDialog();
            if (tjdsc.DialogResult == DialogResult.OK)
            {
                //有待添加的
                for (int i = 0; i < tjdsc.dgv1.RowCount; i++)
                {
                    object value = tjdsc.dgv1.Rows[i].Cells["加入"].EditedFormattedValue;

                    if (true == (Boolean)value)
                    {
                        //写入当前生产表
                            sql = "insert into 当前生产订单(订单编号,商品名称,签订数量,累积) values('" + tjdsc.dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "',";
                            sql += "'" + tjdsc.dgv1.Rows[i].Cells["商品名称"].Value.ToString() + "',";
                            sql += "'" + tjdsc.dgv1.Rows[i].Cells["签订数量"].Value.ToString() + "',";
                            sql += "'0')";
                            DbHelperSQL.ExecuteSql(sql);

                        //更新销售管理订单状态
                            sql = "update sales set 生产状态='正在生产' where 订单编号='" + tjdsc.dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);
  
                    }//if
                }//for
                tjdsc.Close();
                Search();
            }
        }

        private void 今日生产总结_Load(object sender, EventArgs e)
        {
            
            Search();
        }

        public void Search()
        {
            sql = "select * from 当前生产订单";
            dsData = DbHelperSQL.Query(sql);
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = dsData.Tables[0];
            dgv1.ClearSelection(); //取消选中
          
            for (int i = 0; i < dgv1.RowCount; i++)
            {
              
                if (int.Parse(dgv1.Rows[i].Cells["累积"].Value.ToString()) >= int.Parse(dgv1.Rows[i].Cells["签订数量"].Value.ToString()))
                {
                    MessageBox.Show("订单'" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "'已完成!");
                    sql = "update sales set 生产状态='已完成' where 订单编号='" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);
                    sql = "delete from 当前生产订单 where 订单编号='" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);
                    dgv1.Rows.RemoveAt(i);
                }
            }


            for (int i = 0; i < dgv1.RowCount; i++)
                dgv1.Rows[i].Cells["flag1"].Value = "0";
            changed = false;
            flag = false;
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tag=0;
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (dgv1.Rows[i].Cells["日产量"].Value!=null)
                    tag = 1;
            }
            if(tag==1)
            {
                if (changed == true)
                {
                    for (int i = 0; i < dgv1.RowCount; i++)
                    {
                        if (dgv1.Rows[i].Cells["flag1"].Value.ToString() == "1")
                        {


                            //有输入日产量                    
                            dgv1.Rows[i].Cells["flag1"].Value = "0";

                            //更新当前生产订单
                            sql = "select 累积 from 当前生产订单 where 订单编号='" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "'";
                            if (DbHelperSQL.execscalar(sql) != null)
                            {
                                int temp6 = int.Parse(DbHelperSQL.execscalar(sql));
                                temp6 += int.Parse(dgv1.Rows[i].Cells["日产量"].Value.ToString());
                                sql = "update 当前生产订单 set 累积='" + temp6.ToString() + "' where 订单编号='" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "'";
                         
                                DbHelperSQL.ExecuteSql(sql);
                            }


                            //保存到生产日志
                            sql = "insert into 生产日志 values('" + DateTime.Now.ToString("yyyy-MM-dd") + "',";

                            {
                                if (dgv1.Rows[i].Cells["订单编号"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "',";
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["商品名称"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["商品名称"].Value.ToString() + "',";
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["生产线"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["生产线"].Value.ToString() + "',";
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["签订数量"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["签订数量"].Value.ToString() + "',";
                                else
                                    sql += "null" + ",";
                            }

                            sql += "'" + dgv1.Rows[i].Cells["日产量"].Value.ToString() + "',";//日产量


                            if (dgv1.Rows[i].Cells["累积"].Value != null)
                            {
                                sql += "'" + dgv1.Rows[i].Cells["累积"].Value.ToString() + "',";
                            }
                            else
                                sql += "null" + ",";


                            //剩余数量
                           
                                if (int.Parse(dgv1.Rows[i].Cells["签订数量"].Value.ToString()) >= int.Parse(dgv1.Rows[i].Cells["累积"].Value.ToString()))
                                {
                                    int yu = int.Parse(dgv1.Rows[i].Cells["签订数量"].Value.ToString()) - int.Parse(dgv1.Rows[i].Cells["累积"].Value.ToString());
                                    sql += "'" + yu.ToString() + "',";
                                }
                                else
                                {
                                    int yu = int.Parse(dgv1.Rows[i].Cells["累积"].Value.ToString()) - int.Parse(dgv1.Rows[i].Cells["签订数量"].Value.ToString());
                                    sql += "'已超出" + yu.ToString() + "',";
                                }
                    

                            {

                                if (dgv1.Rows[i].Cells["作业工时"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["作业工时"].Value.ToString() + "',";
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["作业人数"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["作业人数"].Value.ToString() + "')";
                                else
                                    sql += "null" + ")";
                            }
                   
                            DbHelperSQL.ExecuteSql(sql);

                        }//if(**=="1")
                    }//for


                    MessageBox.Show("已保存");
                    changed = false;
                    flag = true;
                }
                Search();
            }
            else
                MessageBox.Show("记录无变化或日产量为空");
            
        }

        private void dgv1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            if (dgv1.CurrentCell.Value != null)
                str1 = dgv1.CurrentCell.Value.ToString();
        }

        private void dgv1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.CurrentCell.Value != null)
            {
                if (str1 != dgv1.CurrentCell.Value.ToString())
                {
                    dgv1.CurrentRow.Cells["flag1"].Value = "1";//需要保存
                }
            }
            if (dgv1.Columns[e.ColumnIndex].Name == "日产量")
            {
               
                if (dgv1.CurrentRow.Cells["日产量"].Value == null)
                {
                    //编辑后为空
                    dgv1.CurrentRow.Cells["flag1"].Value = "0";
                    //恢复累积
                    sql = "select 累积 from 当前生产订单 where 订单编号='" + dgv1.CurrentRow.Cells["订单编号"].Value.ToString() + "'";
                    if (DbHelperSQL.execscalar(sql) != null)
                    {

                        dgv1.CurrentRow.Cells["累积"].Value = DbHelperSQL.execscalar(sql);
                    }

                    return;
                }
                else
                {
                    //编辑后不为空
                    if (numcheck.IsPositiveInteger(dgv1.CurrentCell.Value.ToString()) == true)
                    {
                        sql = "select 累积 from 当前生产订单 where 订单编号='" + dgv1.CurrentRow.Cells["订单编号"].Value.ToString() + "'";
                        if (DbHelperSQL.execscalar(sql) != null)
                        {
                            int temp5 = int.Parse(DbHelperSQL.execscalar(sql));
                            dgv1.CurrentRow.Cells["累积"].Value = temp5 + int.Parse(dgv1.CurrentRow.Cells["日产量"].Value.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("日产量只能为正整数");
                        dgv1.CurrentCell.Value = null;
                        return;
                    }
                }
            }

            if (flag == true)
                flag = false;
            if (changed == false)
            {
                changed = true;
            }
        }

        private void 今日生产总结_FormClosing(object sender, FormClosingEventArgs e)
        {
              int tag=0;
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (dgv1.Rows[i].Cells["日产量"].Value!=null)
                    tag = 1;
            }
            if (tag == 1)
            {
                if (flag == false)
                {
                    if (changed == true)
                    {
                        //有未保存的
                        DialogResult result = MessageBox.Show("记录发生变化，是否保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            for (int i = 0; i < dgv1.RowCount; i++)
                            {
                                if (dgv1.Rows[i].Cells["flag1"].Value.ToString() == "1")
                                {

                                    //有输入日产量   
                                    dgv1.Rows[i].Cells["flag1"].Value = "0";


                                    //更新当前生产订单
                                    sql = "select 累积 from 当前生产订单 where 订单编号='" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "'";
                                    if (DbHelperSQL.execscalar(sql) != null)
                                    {
                                        int temp6 = int.Parse(DbHelperSQL.execscalar(sql));
                                        temp6 += int.Parse(dgv1.Rows[i].Cells["日产量"].Value.ToString());
                                        sql = "update 当前生产订单 set 累积='" + temp6.ToString() + "' where 订单编号='" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "'";
                                        DbHelperSQL.ExecuteSql(sql);
                                    }


                                    //保存到生产日志
                                    sql = "insert into 生产日志 values('" + DateTime.Now.ToString("yyyy-MM-dd") + "',";

                                    {
                                        if (dgv1.Rows[i].Cells["订单编号"].Value != null)
                                            sql += "'" + dgv1.Rows[i].Cells["订单编号"].Value.ToString() + "',";
                                        else
                                            sql += "null" + ",";
                                    }
                                    {
                                        if (dgv1.Rows[i].Cells["商品名称"].Value != null)
                                            sql += "'" + dgv1.Rows[i].Cells["商品名称"].Value.ToString() + "',";
                                        else
                                            sql += "null" + ",";
                                    }
                                    {
                                        if (dgv1.Rows[i].Cells["生产线"].Value != null)
                                            sql += "'" + dgv1.Rows[i].Cells["生产线"].Value.ToString() + "',";
                                        else
                                            sql += "null" + ",";
                                    }
                                    {
                                        if (dgv1.Rows[i].Cells["签订数量"].Value != null)
                                            sql += "'" + dgv1.Rows[i].Cells["签订数量"].Value.ToString() + "',";
                                        else
                                            sql += "null" + ",";
                                    }

                                    sql += "'" + dgv1.Rows[i].Cells["日产量"].Value.ToString() + "',";//日产量

                                    {
                                        if (dgv1.Rows[i].Cells["累积"].Value != null)
                                            sql += "'" + dgv1.Rows[i].Cells["累积"].Value.ToString() + "',";
                                        else
                                            sql += "null" + ",";
                                    }

                                    //剩余数量
                                 
                                        if (int.Parse(dgv1.Rows[i].Cells["签订数量"].Value.ToString()) >= int.Parse(dgv1.Rows[i].Cells["累积"].Value.ToString()))
                                        {
                                            int yu = int.Parse(dgv1.Rows[i].Cells["签订数量"].Value.ToString()) - int.Parse(dgv1.Rows[i].Cells["累积"].Value.ToString());
                                            sql += "'" + yu.ToString() + "',";
                                        }
                                        else
                                        {
                                            int yu = int.Parse(dgv1.Rows[i].Cells["累积"].Value.ToString()) - int.Parse(dgv1.Rows[i].Cells["签订数量"].Value.ToString());
                                            sql += "'已超出" + yu.ToString() + "',";
                                        }


                                    {

                                        if (dgv1.Rows[i].Cells["作业工时"].Value != null)
                                            sql += "'" + dgv1.Rows[i].Cells["作业工时"].Value.ToString() + "',";
                                        else
                                            sql += "null" + ",";
                                    }
                                    {
                                        if (dgv1.Rows[i].Cells["作业人数"].Value != null)
                                            sql += "'" + dgv1.Rows[i].Cells["作业人数"].Value.ToString() + "')";
                                        else
                                            sql += "null" + ")";
                                    }
                                    DbHelperSQL.ExecuteSql(sql);

                                }//if(**=="1")
                            }//for

                            MessageBox.Show("已保存");
                        }
                        else
                        {
                            MessageBox.Show("未保存");
                            return;
                        }
                    }
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
