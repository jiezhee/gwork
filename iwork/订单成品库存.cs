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
    public partial class 订单成品库存 : Form
    {
        public 订单成品库存()
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
            sql = "SELECT 订单成品库存.*,sales.订单编号,sales.商品型号,sales.商品名称,sales.商品描述,sales.成品num FROM 订单成品库存,sales where sales.加入序号=订单成品库存.订单加入序号 and sales.核销='未完成'";
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql);

            if (dgv1.DataSource != null)
            {
                dgv1.DataSource = null;
            }
            dgv1.AutoGenerateColumns = false;
            BindingSource s = new BindingSource();
            s.DataSource=dsData.Tables[0];
            dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中

        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search();
            if (cancel_nochange == false)
            {
                cancel_nochange = true;
            }
         
        }

        private void 订单成品库存_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                            //写入订单成品库存
                            sql = "update 订单成品库存 set 库存=((select 库存 from 订单成品库存 where 订单加入序号='" + dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString() + "')+" + rc.t1.Text + ") where 订单加入序号='" + dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);
                           

                            //写入成品库存日志
                            sql = "insert into 成品库存日志(型号,品名,描述) select production.code,production.name,production.描述 from production where num='" + dgv1.CurrentRow.Cells["成品num"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);
                            sql = "update 成品库存日志 set 日期='" + DateTime.Now.ToString() + "'";
                            sql += ",出入库类别='入库'";
                            sql += ",数量='" + rc.t1.Text + "'";
                            sql += ",出入库方式='跟随订单入库'";
                            int code = DbHelperSQL.maxnum("编码", "成品库存日志");
                            sql += " where 编码='" + code.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);


                            //存撤销信息
                            cancel_nochange = false;
                            cancel_num = dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString();
                            cancel_quantity = rc.t1.Text;
                            cancel_storage = true;

                            //修改dgv1
                            int temp;
                            temp = int.Parse(this.dgv1.CurrentRow.Cells["库存"].Value.ToString());
                            temp += int.Parse(rc.t1.Text.ToString());
                            dgv1.CurrentRow.Cells["本次库存变化"].Value = "入" + rc.t1.Text;
                            dgv1.CurrentRow.Cells["出入库后总库存"].Value = temp.ToString();
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
                                temp1 = int.Parse(dgv1.CurrentRow.Cells["库存"].Value.ToString()) - int.Parse(cc.t1.Text);
                                if (temp1 < 0)
                                    MessageBox.Show("出库数不能大于当前库存");
                                else
                                {
                                    //存入订单成品库存
                                    sql = "update 订单成品库存 set 库存=((select 库存 from 订单成品库存 where 订单加入序号='" + dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString() + "')-" + cc.t1.Text + ") where 订单加入序号='" + dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);
                                   
                                    //存入成品库存日志
                                    sql = "insert into 成品库存日志(型号,品名,描述) select code,name,描述 from production where num='" + dgv1.CurrentRow.Cells["成品num"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);
                                    sql = "update 成品库存日志 set 日期='" + DateTime.Now.ToString() + "'";
                                    sql += ",出入库类别='出库'";
                                    sql += ",数量='" + cc.t1.Text + "'";
                                    sql += ",出入库方式='跟随订单出库'";
                                    int code = DbHelperSQL.maxnum("编码", "成品库存日志");
                                    sql += " where 编码='" + code.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);

                                    //撤销信息
                                    cancel_nochange = false;
                                    cancel_num = dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString();
                                    cancel_quantity = cc.t1.Text;
                                    cancel_storage = false;

                                    //更新dgv1
                                    int temp;
                                    temp = int.Parse(this.dgv1.CurrentRow.Cells["库存"].Value.ToString());
                                    temp -= int.Parse(cc.t1.Text.ToString());
                                    dgv1.CurrentRow.Cells["本次库存变化"].Value = "出" + cc.t1.Text;
                                    dgv1.CurrentRow.Cells["出入库后总库存"].Value = temp.ToString();
                                }
                            }

                        }
                }
            }
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cancel_nochange == false)
            {
                //有出入库
                if (cancel_storage == true)
                {
                    //撤销入库（订单成品库存）                              
                    sql = "update 订单成品库存 set 库存=((select 库存 from 订单成品库存 where 订单加入序号='" + cancel_num + "')-" + cancel_quantity + ") where 订单加入序号='" + cancel_num + "'";
                    DbHelperSQL.ExecuteSql(sql);   
                    dgv1.CurrentRow.Cells["库存"].Value = int.Parse(dgv1.CurrentRow.Cells["出入库后总库存"].Value.ToString()) - int.Parse(cancel_quantity);
                    dgv1.CurrentRow.Cells["本次库存变化"].Value = null;
                    dgv1.CurrentRow.Cells["出入库后总库存"].Value = null;
                    //撤销库存日志
                    int temp4 = DbHelperSQL.maxnum("编码", "成品库存日志");
                    sql = "delete from 成品库存日志 where 编码='" + temp4.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);


                }
                else
                {
                    //撤销出库(订单成品库存)               

                    sql = "update 订单成品库存 set 库存=((select 库存 from 订单成品库存 where 订单加入序号='" + cancel_num + "')+" + cancel_quantity + ") where 订单加入序号='" + cancel_num + "'";
                    DbHelperSQL.ExecuteSql(sql);   
                   
                    dgv1.CurrentRow.Cells["库存"].Value = int.Parse(dgv1.CurrentRow.Cells["出入库后总库存"].Value.ToString()) + int.Parse(cancel_quantity);
                    dgv1.CurrentRow.Cells["本次库存变化"].Value = null;
                    dgv1.CurrentRow.Cells["出入库后总库存"].Value = null;

                    //撤销库存日志
                    int temp4 = DbHelperSQL.maxnum("编码", "成品库存日志");
                    sql = "delete from 成品库存日志 where 编码='" + temp4.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);

                }
                MessageBox.Show("已撤销");
                cancel_nochange = true;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
