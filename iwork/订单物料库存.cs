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
    public partial class 订单物料库存 : Form
    {
        public 订单物料库存()
        {
            InitializeComponent();
        }

        public string dingdan_addnum = string.Empty;
        public string sql = string.Empty;
        public string sql_start = string.Empty;
        public string prstatus = string.Empty;//订单生产状态
        private string IDSelected = string.Empty;

        //撤销信息
        private string cancel_num = string.Empty;
        private string cancel_num1 = string.Empty;
        private string cancel_quantity = string.Empty;
        private bool cancel_nochange = true;
        private bool cancel_storage = true;//标记出入库
        public string cgstr = string.Empty;//cgstr=dingdan_addnum or ddcgnum

        public void Search()
        {
            
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql_start);

            dgv1.AutoGenerateColumns = false;
            if (dgv1.DataSource != null)
                dgv1.DataSource = null;
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            this.dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中

        }

        private void 采购状态_Load(object sender, EventArgs e)
        {
            this.Text += "(生产状态：" + prstatus + ")";
            if (prstatus != "正在采购")
            {
                this.准许生产ToolStripMenuItem.Visible = false;
            }
            Search();
           
        }

        private void dgv1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgv1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        
            if (dgv1.CurrentCell.Value != null)
            {
               
                    string strtemp = dgv1.Columns[e.ColumnIndex].Name;
                    if (strtemp == "到齐")
                    {
           
                            if (dgv1.CurrentCell.Value.ToString()=="0")
                            {
            
                                sql = "update 物料采购状态 set 到齐='0' where 订单加入序号='" + dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString() + "' and 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                                DbHelperSQL.ExecuteSql(sql);
                            }
                            else
                                if (dgv1.CurrentCell.Value.ToString() == "1")
                                {
                                    sql = "update 物料采购状态 set 到齐='1' where 订单加入序号='" + dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString() + "' and 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);
                                }
                        
                    }

            }
          
     

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search();
            if (cancel_nochange == false)
            {
                cancel_nochange = true;
            }
        }

        private void 准许生产ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("审核完成，可以进行生产！");
            sql = "update sales set 生产状态='准备生产' where 加入序号='" + dingdan_addnum + "'";
            DbHelperSQL.ExecuteSql(sql);
            sql = "update 订单采购状态 set 采购状态='已完成' where 订单加入序号='" + dingdan_addnum + "'";
            DbHelperSQL.ExecuteSql(sql);
            this.Close();
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

                            //写入物料采购状态
                            sql = "update 物料采购状态 set 库存=((select 库存 from 物料采购状态 where 订单加入序号='" + dingdan_addnum + "' and 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "')+" + rc.t1.Text + ") where 订单加入序号='" +dingdan_addnum+ "' and 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);

                  
                            //写入物料库存日志
                            sql = "insert into 物料库存日志(物料NO,料号,品名) select material.NO,material.料号,material.品名 from material where NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);
                            sql = "update 物料库存日志 set 日期='" + DateTime.Now.ToString() + "'";
                            sql += ",出入库类别='入库'";
                            sql += ",数量='" + rc.t1.Text + "'";
                            sql += ",出入库方式='跟随订单入库'";
                            int code = DbHelperSQL.maxnum("编码", "物料库存日志");
                            sql += " where 编码='" + code.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);


                            //存撤销信息
                            cancel_nochange = false;
                            cancel_num = dgv1.CurrentRow.Cells["物料NO"].Value.ToString();
                            cancel_num1 = dingdan_addnum;
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
                                    //存入物料采购状态
                                    sql = "update 物料采购状态 set 库存=((select 库存 from 物料采购状态 where 订单加入序号='" + dingdan_addnum + "' and 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "')-" + cc.t1.Text + ") where 订单加入序号='" +dingdan_addnum+ "' and 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);

                                    //存入物料库存日志
                                    sql = "insert into 物料库存日志(物料NO,料号,品名) select material.NO,material.料号,material.品名 from material where NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);
                                    sql = "update 物料库存日志 set 日期='" + DateTime.Now.ToString() + "'";
                                    sql += ",出入库类别='出库'";
                                    sql += ",数量='" + cc.t1.Text + "'";
                                    sql += ",出入库方式='跟随订单出库'";
                                    int code = DbHelperSQL.maxnum("编码", "物料库存日志");
                                    sql += " where 编码='" + code.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);

                                    //撤销信息
                                    cancel_nochange = false;
                                    cancel_num = dgv1.CurrentRow.Cells["物料NO"].Value.ToString();
                                    cancel_num1 =dingdan_addnum;
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
                    //撤销入库（物料采购状态）                              
                    sql = "update 物料采购状态 set 库存=((select 库存 from 物料采购状态 where 订单加入序号='" + cancel_num1 + "' and 物料NO='" + cancel_num + "')-" + cancel_quantity + ") where 订单加入序号='" + cancel_num1 + "' and 物料NO='" + cancel_num + "'";
                    MessageBox.Show(sql);
                    DbHelperSQL.ExecuteSql(sql);
                   
                    dgv1.CurrentRow.Cells["库存"].Value = int.Parse(dgv1.CurrentRow.Cells["出入库后总库存"].Value.ToString()) - int.Parse(cancel_quantity);
                    dgv1.CurrentRow.Cells["本次库存变化"].Value = null;
                    dgv1.CurrentRow.Cells["出入库后总库存"].Value = null;
                    //撤销库存日志
                    int temp4 = DbHelperSQL.maxnum("编码", "物料库存日志");
                    sql = "delete from 物料库存日志 where 编码='" + temp4.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);


                }
                else
                {
                    //撤销出库(物料库存信息表)               

                    sql = "update 物料采购状态 set 库存=((select 库存 from 物料采购状态 where 订单加入序号='" + cancel_num1 + "' and 物料NO='" + cancel_num + "')+" + cancel_quantity + ") where 订单加入序号='" + cancel_num1 + "' and 物料NO='" + cancel_num + "'";
                    MessageBox.Show(sql);
                    DbHelperSQL.ExecuteSql(sql);
                   
                    dgv1.CurrentRow.Cells["库存"].Value = int.Parse(dgv1.CurrentRow.Cells["出入库后总库存"].Value.ToString()) + int.Parse(cancel_quantity);
                    dgv1.CurrentRow.Cells["本次库存变化"].Value = null;
                    dgv1.CurrentRow.Cells["出入库后总库存"].Value = null;

                    //撤销库存日志
                    int temp4 = DbHelperSQL.maxnum("编码", "物料库存日志");
                    sql = "delete from 物料库存日志 where 编码='" + temp4.ToString() + "'";
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
