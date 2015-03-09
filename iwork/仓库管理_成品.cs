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
    public partial class 仓库管理_成品 : Form
    {
        public 仓库管理_成品()
        {
            InitializeComponent();
        }

        private string sql = string.Empty;


        private string cancel_num = string.Empty;
        private string cancel_quantity = string.Empty;
        private bool cancel_nochange = true;
        private bool cancel_storage = true;//标记出入库

        public void Search()
        {
            sql = "delete from 成品库存信息 where 库存<='0'";
            DbHelperSQL.ExecuteSql(sql);

            sql = "SELECT * FROM  成品库存信息";
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql);

            if (dgv1.DataSource != null)
            {
                dgv1.DataSource = null;
            }
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = dsData.Tables[0];
            dgv1.ClearSelection(); //取消选中
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                dgv1.Rows[i].Cells["入库"].Value = "入库";
                dgv1.Rows[i].Cells["出库"].Value = "出库";
            }


        }


        private void 基础录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search();
            if (cancel_nochange == false)
            {
                cancel_nochange = true;
            }
         
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            库存_新增成品 kc_pr_add = new 库存_新增成品();
            kc_pr_add.ShowDialog();

            if (kc_pr_add.DialogResult == DialogResult.OK)
            {
                //单独显示刚才添加的行
                int flag = 0;
                string str1 = string.Empty;
                DataSet ds2 = new DataSet();
                //清空dgv1
                dgv1.DataSource = null;
                dgv1.Refresh();

                sql = "select * from [成品库存信息] where";               //有非空的
                if (kc_pr_add.t1.Text != string.Empty)
                {
                    sql += "[代码]='" + kc_pr_add.t1.Text + "'";
                    flag = 1;//之前的属性有非空的


                }
                if (kc_pr_add.t2.Text != string.Empty)
                {
                    if (flag == 1)
                        str1 = " and ";
                    else
                    {
                        str1 = "";
                        flag = 1;
                    }
                    sql += str1 + "[名称]='" + kc_pr_add.t2.Text + "'";

                }


                ds2 = DbHelperSQL.Query(sql);
                dgv1.AutoGenerateColumns = false;
                dgv1.DataSource = ds2.Tables[0];
                dgv1.ClearSelection(); //取消选中
                dgv1.Rows[0].Cells["入库"].Value = "入库";
                dgv1.Rows[0].Cells["出库"].Value = "出库";
            }
        }

        private void 仓库管理_成品_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            库存成品搜索 kccp = new 库存成品搜索();
            kccp.ShowDialog();

            if (kccp.DialogResult == DialogResult.OK)
            {
                DataSet ds_this = kccp.ds.Copy();
                kccp.Close();

                dgv1.DataSource = null;
                dgv1.AutoGenerateColumns = false;
                dgv1.DataSource = ds_this.Tables[0];
                dgv1.ClearSelection(); //取消选中

                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    dgv1.Rows[i].Cells["入库"].Value = "入库";
                    dgv1.Rows[i].Cells["出库"].Value = "出库";
                }

            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cancel_nochange == false)
            {
                //有出入库
                if (cancel_storage == true)
                {
                    //撤销入库（库存信息表）                              
                    sql = "update 成品库存信息 set 库存=((select 库存 from 成品库存信息 where 代码='" + cancel_num + "')-" + cancel_quantity + ") where 代码='" + cancel_num + "'";
                    DbHelperSQL.ExecuteSql(sql);
                    dgv1.CurrentRow.Cells["之前库存"].Value = int.Parse(dgv1.CurrentRow.Cells["总库存"].Value.ToString()) - int.Parse(cancel_quantity);
                    dgv1.CurrentRow.Cells["本次库存变化"].Value = null;
                    dgv1.CurrentRow.Cells["总库存"].Value = null;
                    //撤销库存日志
                    int temp4 = DbHelperSQL.maxnum("编号", "库存日志");
                    sql = "delete from 库存日志 where 编号='" + temp4.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);


                }
                else
                {
                    //撤销出库(库存信息表)               

                    sql = "update 成品库存信息 set 库存=((select 库存 from 成品库存信息 where 代码='" + cancel_num + "')+" + cancel_quantity + ") where 代码='" + cancel_num + "'";
                    DbHelperSQL.ExecuteSql(sql);
                    dgv1.CurrentRow.Cells["之前库存"].Value = int.Parse(dgv1.CurrentRow.Cells["总库存"].Value.ToString()) + int.Parse(cancel_quantity);
                    dgv1.CurrentRow.Cells["本次库存变化"].Value = null;
                    dgv1.CurrentRow.Cells["总库存"].Value = null;

                    //撤销库存日志
                    int temp4 = DbHelperSQL.maxnum("编号", "库存日志");
                    sql = "delete from 库存日志 where 编号='" + temp4.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);

                }
                MessageBox.Show("已撤销");
                cancel_nochange = true;
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex != -1)
                {
                    if (this.dgv1.Columns[e.ColumnIndex].Name == "入库")
                    {
                        出入库 rc = new 出入库();
                        rc.Text = "入库";
                        rc.ShowDialog();
                        if (rc.DialogResult == DialogResult.OK)
                        {
                            //入库，写入数据库
                            rc.Close();

                            //写入成品库存信息表
                            sql = "update 成品库存信息 set 库存=((select 库存 from 成品库存信息 where 代码='" + dgv1.CurrentRow.Cells["代码"].Value.ToString() + "')+" + rc.t1.Text + ") where 代码='" + dgv1.CurrentRow.Cells["代码"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);

                            //写入库存日志表
                            sql = "insert into 库存日志(日期,商品类别,代码,名称,入出库类别,数量) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','成品',";
                            {
                                if (dgv1.CurrentRow.Cells["代码"].Value != null)
                                    sql += "'" + dgv1.CurrentRow.Cells["代码"].Value.ToString() + "',";//代码
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.CurrentRow.Cells["名称"].Value != null)
                                    sql += "'" + dgv1.CurrentRow.Cells["名称"].Value.ToString() + "',";//名称
                                else
                                    sql += "null" + ",";
                            }

                            sql += "'入库',";

                            sql += "'" + rc.t1.Text + "')";
                            DbHelperSQL.ExecuteSql(sql);

                            //存撤销信息
                            cancel_nochange = false;
                            cancel_num = dgv1.CurrentRow.Cells["代码"].Value.ToString();
                            cancel_quantity = rc.t1.Text;
                            cancel_storage = true;

                            //修改dgv1
                            int temp;
                            temp = int.Parse(this.dgv1.CurrentRow.Cells["之前库存"].Value.ToString());
                            temp += int.Parse(rc.t1.Text.ToString());
                            dgv1.CurrentRow.Cells["本次库存变化"].Value = "入" + rc.t1.Text;
                            dgv1.CurrentRow.Cells["总库存"].Value = temp.ToString();
                        }

                    }
                    else
                        if (this.dgv1.Columns[e.ColumnIndex].Name == "出库")
                        {
                            出入库 cc = new 出入库();
                            cc.Text = "出库";
                            cc.ShowDialog();
                            if (cc.DialogResult == DialogResult.OK)
                            {
                                //出库，写入数据库 
                                cc.Close();
                                int temp1 = 0;
                                temp1 = int.Parse(dgv1.CurrentRow.Cells["之前库存"].Value.ToString()) - int.Parse(cc.t1.Text);
                                if (temp1 < 0)
                                    MessageBox.Show("出库数不能大于当前库存");
                                else
                                {
                                    //存入库存信息表
                                    sql = "update 成品库存信息 set 库存=((select 库存 from 成品库存信息 where 代码='" + dgv1.CurrentRow.Cells["代码"].Value.ToString() + "')-" + cc.t1.Text + ") where 代码='" + dgv1.CurrentRow.Cells["代码"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);

                                    //存入库存日志
                                    sql = "insert into 库存日志(日期,商品类别,代码,名称,入出库类别,数量) values('" + DateTime.Now.ToString("yyyy-MM-dd") + "','成品',";
                                    {
                                        if (dgv1.CurrentRow.Cells["代码"].Value != null)
                                            sql += "'" + dgv1.CurrentRow.Cells["代码"].Value.ToString() + "',";//物料代码
                                        else
                                            sql += "null" + ",";
                                    }
                                    {
                                        if (dgv1.CurrentRow.Cells["名称"].Value != null)
                                            sql += "'" + dgv1.CurrentRow.Cells["名称"].Value.ToString() + "',";//名称
                                        else
                                            sql += "null" + ",";
                                    }

                                    sql += "'出库',";

                                    sql += "'" + cc.t1.Text + "')";
                                    DbHelperSQL.ExecuteSql(sql);

                                    //撤销信息
                                    cancel_nochange = false;
                                    cancel_num = dgv1.CurrentRow.Cells["代码"].Value.ToString();
                                    cancel_quantity = cc.t1.Text;
                                    cancel_storage = false;

                                    //更新dgv1
                                    int temp;
                                    temp = int.Parse(this.dgv1.CurrentRow.Cells["之前库存"].Value.ToString());
                                    temp -= int.Parse(cc.t1.Text.ToString());
                                    dgv1.CurrentRow.Cells["本次库存变化"].Value = "出" + cc.t1.Text;
                                    dgv1.CurrentRow.Cells["总库存"].Value = temp.ToString();
                                }
                            }

                        }
                }
            }
        }

        private void dgv1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                dgv1.Rows[i].Cells["入库"].Value = "入库";
                dgv1.Rows[i].Cells["出库"].Value = "出库";
            }
        }
    }
}
