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
    public partial class purlist_madetail : Form
    {
        public purlist_madetail()
        {
            InitializeComponent();
        }
        public string prcode = string.Empty;
        private string sql = string.Empty;
        private string IDSelected = string.Empty;
        public string dingdan_addnum = string.Empty;
        public int which = 0;//默认为0,第一次采购；若为补料,则which=1;

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void 删除物料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IDSelected == string.Empty)
            {
                MessageBox.Show("选择删除行");
                return;
            }
 
           dgv1.Rows.RemoveAt(dgv1.CurrentCell.RowIndex);
        
            IDSelected = string.Empty;
        }

        private void 生成采购单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                if (this.dgv1.Rows[i].Cells["采购数量"].Value == null)
                {
                    MessageBox.Show("采购数量不能为空！");
                    return;
                }
            }

            采购信息预览 cg = new 采购信息预览();

            for (int k = 0; k < dgv1.RowCount; k++)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(cg.dgv1);
               for(int s=0;s<cg.dgv1.Columns.Count;s++)
                   dr.Cells[s].Value=null;
                cg.dgv1.Rows.Insert(0, dr);
            }

            //复制采购信息
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                cg.dgv1.Rows[i].Cells[0].Value = (i + 1).ToString();
                cg.dgv1.Rows[i].Cells["NO"].Value = dgv1.Rows[i].Cells["物料NO"].Value;
                cg.dgv1.Rows[i].Cells["料号"].Value = dgv1.Rows[i].Cells["料号"].Value;
                cg.dgv1.Rows[i].Cells["品名"].Value = dgv1.Rows[i].Cells["品名"].Value;
                cg.dgv1.Rows[i].Cells["型号规格"].Value = dgv1.Rows[i].Cells["型号规格"].Value;
                cg.dgv1.Rows[i].Cells["单位"].Value = dgv1.Rows[i].Cells["单位"].Value;
                cg.dgv1.Rows[i].Cells["使用位置"].Value = dgv1.Rows[i].Cells["使用位置"].Value; 
                cg.dgv1.Rows[i].Cells["用量"].Value = dgv1.Rows[i].Cells["用量"].Value;
                cg.dgv1.Rows[i].Cells["供应商"].Value = dgv1.Rows[i].Cells["供应商"].Value; 
                cg.dgv1.Rows[i].Cells["采购数量"].Value = dgv1.Rows[i].Cells["采购数量"].Value;
                cg.dgv1.Rows[i].Cells["单价"].Value = dgv1.Rows[i].Cells["单价"].Value;
                cg.dgv1.Rows[i].Cells["金额"].Value = dgv1.Rows[i].Cells["金额"].Value;

            }
            cg.ShowDialog();

            //已经生产采购单，采购信息写入数据库
            if (cg.DialogResult == DialogResult.OK)
            {
                if (which == 0)
                {
                    //写入订单采购状态(一个单只需要一条记录）
                    sql = "insert into 订单采购状态(订单加入序号,采购状态) values('" + dingdan_addnum + "','未完成')";
                    DbHelperSQL.ExecuteSql(sql);

                    //写入采购信息
                    this.DialogResult = DialogResult.OK;
                    int lastday = DbHelperSQL.lastday("日期", "采购信息");
                    int today = DateTime.Now.Day;
                    int macount = 1;
                    int number = 0;
                    if (lastday != 0)
                    {
                        if (lastday == today)
                        {
                            //同一天的采购信息
                            number = DbHelperSQL.lastday_purnum();//最近订单采购单序号
                        }
                    }

                    //后边某天，number=0（时间不错乱）
                    for (int i = 0; i < dgv1.RowCount; i++)
                    {
                        sql = "insert into 采购信息(采购单序号,物料序号,物料NO,料号,品名,型号规格,单位,使用位置,用量,供应商,采购数量,单价,金额,日期,订单加入序号)";
                        sql += "values('";

                        sql += (number + 1).ToString() + "','";//采购单序号

                        sql += macount.ToString() + "',";//物料序号
                        macount++;

                        {
                            if (dgv1.Rows[i].Cells["物料NO"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "',";//物料NO
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["料号"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["料号"].Value.ToString() + "',";//料号
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["品名"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["品名"].Value.ToString() + "',";//品名
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["型号规格"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["型号规格"].Value.ToString() + "',";//型号规格
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["单位"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["单位"].Value.ToString() + "',";//单位
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["使用位置"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["使用位置"].Value.ToString() + "',";//使用位置
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["用量"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["用量"].Value.ToString() + "',";//用量
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["供应商"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["供应商"].Value.ToString() + "',";//供应商
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["采购数量"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["采购数量"].Value.ToString() + "',";//采购数量
                            else
                                sql += "null" + ",";
                        }
                        {
                            if (dgv1.Rows[i].Cells["单价"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["单价"].Value.ToString() + "',";//单价
                            else
                                sql += "null" + ",";
                        }

                        {
                            if (dgv1.Rows[i].Cells["金额"].Value != null)
                                sql += "'" + dgv1.Rows[i].Cells["金额"].Value.ToString() + "',";//金额
                            else
                                sql += "null" + ",";
                        }
                        sql += "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',";
                        sql += "'" + dingdan_addnum + "')";
                        DbHelperSQL.ExecuteSql(sql);


                        //写入物料采购状态
                        int cgmaxnum = DbHelperSQL.maxnum("编码", "采购信息");//获取刚才存的一条采购信息的编码

                        sql = "insert into 物料采购状态 values('";
                        sql += cgmaxnum.ToString() + "','";
                        sql += dingdan_addnum + "'";
                        sql += ",'" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "'";
                        sql += ",'" + dgv1.Rows[i].Cells["采购数量"].Value.ToString() + "'";
                        sql += ",'" + "0" + "'";
                        sql += ",'" + "0" + "')";
                        DbHelperSQL.ExecuteSql(sql);
                    }
                    MessageBox.Show("采购信息已存入数据库");

                    sql = "update sales set 生产状态='正在采购' where 加入序号='" + dingdan_addnum + "'";
                    DbHelperSQL.ExecuteSql(sql);
                    cg.Close();
                    this.Close();
                }
                else
                    if (which == 1)
                    {
                        //补料
                        sql="update 订单采购状态 set 采购状态='未完成' where 订单加入序号='"+dingdan_addnum+"'";
                        DbHelperSQL.ExecuteSql(sql);

                        //写入采购信息
                        this.DialogResult = DialogResult.OK;
                        int lastday = DbHelperSQL.lastday("日期", "采购信息");
                        int today = DateTime.Now.Day;
                        int macount = 1;
                        int number = 0;
                        if (lastday != 0)
                        {
                            if (lastday == today)
                            {
                                //同一天的采购信息
                                number = DbHelperSQL.lastday_purnum();//最近订单采购单序号
                            }
                        }

                        //后边某天，number=0（时间不错乱）
                        for (int i = 0; i < dgv1.RowCount; i++)
                        {
                            sql = "insert into 采购信息(采购单序号,物料序号,物料NO,料号,品名,型号规格,单位,使用位置,用量,供应商,采购数量,单价,金额,日期,订单加入序号)";
                            sql += "values('";

                            sql += (number + 1).ToString() + "','";//采购单序号

                            sql += macount.ToString() + "',";//物料序号
                            macount++;

                            {
                                if (dgv1.Rows[i].Cells["物料NO"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "',";//物料NO
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["料号"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["料号"].Value.ToString() + "',";//料号
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["品名"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["品名"].Value.ToString() + "',";//品名
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["型号规格"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["型号规格"].Value.ToString() + "',";//型号规格
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["单位"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["单位"].Value.ToString() + "',";//单位
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["使用位置"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["使用位置"].Value.ToString() + "',";//使用位置
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["用量"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["用量"].Value.ToString() + "',";//用量
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["供应商"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["供应商"].Value.ToString() + "',";//供应商
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["采购数量"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["采购数量"].Value.ToString() + "',";//采购数量
                                else
                                    sql += "null" + ",";
                            }
                            {
                                if (dgv1.Rows[i].Cells["单价"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["单价"].Value.ToString() + "',";//单价
                                else
                                    sql += "null" + ",";
                            }

                            {
                                if (dgv1.Rows[i].Cells["金额"].Value != null)
                                    sql += "'" + dgv1.Rows[i].Cells["金额"].Value.ToString() + "',";//金额
                                else
                                    sql += "null" + ",";
                            }
                            sql += "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',";
                            sql += "'" + dingdan_addnum + "')";

                            DbHelperSQL.ExecuteSql(sql);

                            //写入物料采购状态

                            sql="select 采购数量 from 物料采购状态 where 订单加入序号='"+dingdan_addnum+"' and 物料NO='"+dgv1.Rows[i].Cells["物料NO"].Value.ToString()+"'";
                            if (DbHelperSQL.execscalar(sql) != null)
                            {
                                //之前该订单采购过该物料
                                string temp = DbHelperSQL.execscalar(sql);
                                temp = (int.Parse(temp) + int.Parse(dgv1.Rows[i].Cells["采购数量"].Value.ToString())).ToString();
                                sql = "update 物料采购状态 set 采购数量='" + temp + "' where 订单加入序号='" + dingdan_addnum + "' and 物料NO='" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "'";
                                DbHelperSQL.ExecuteSql(sql);

                                sql = "update 物料采购状态 set 到齐='0' where 订单加入序号='" + dingdan_addnum + "' and 物料NO='" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "'";
                                DbHelperSQL.ExecuteSql(sql);
                            }
                            else
                            {
                                int cgmaxnum = DbHelperSQL.maxnum("编码", "采购信息");//获取刚才存的一条采购信息的编码
                                sql = "insert into 物料采购状态 values('";
                                sql += cgmaxnum.ToString() + "','";
                                sql += dingdan_addnum + "'";
                                sql += ",'" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "'";
                                sql += ",'" + dgv1.Rows[i].Cells["采购数量"].Value.ToString() + "'";
                                sql += ",'" + "0" + "'";
                                sql += ",'" + "0" + "')";
                                DbHelperSQL.ExecuteSql(sql);
                            }

                        }
                        MessageBox.Show("补料信息已存入数据库");

                        cg.Close();
                        this.Close();
                    }


            }
             
        }

        private void purlist_madetail_Load(object sender, EventArgs e)
        {
            //载入库存信息
            if (which == 0)
            {
                //从总库存中导入
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    if (DbHelperSQL.isin(dgv1.Rows[i].Cells["物料NO"].Value.ToString(), "物料NO", "物料库存信息") == true)
                    {
                        sql = "select 单独库存 from 物料库存信息 where 物料NO='" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "'";
                        dgv1.Rows[i].Cells["可用库存"].Value = DbHelperSQL.execscalar(sql);
                    }
                    else
                    {

                        dgv1.Rows[i].Cells["可用库存"].Value = "0";
                    }
                }
            }
            else
                if (which == 1)
                {
                    //补料,从订单物料库存中导入(总库存+订单库存)
                   for (int i = 0; i < dgv1.RowCount; i++)
                     {
                       sql="select 库存 from 物料采购状态 where 物料NO='" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "' and 订单加入序号='" + dingdan_addnum + "'";
                         if (DbHelperSQL.execscalar(sql)!= null)
                         {
                             //之前采购了这种物料
                             dgv1.Rows[i].Cells["可用库存"].Value = DbHelperSQL.execscalar(sql);
                             if (DbHelperSQL.isin(dgv1.Rows[i].Cells["物料NO"].Value.ToString(), "物料NO", "物料库存信息") == true)
                             {
                                 sql = "select 单独库存 from 物料库存信息 where 物料NO='" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "'";
                                 dgv1.Rows[i].Cells["可用库存"].Value =(int.Parse(dgv1.Rows[i].Cells["可用库存"].Value.ToString())+int.Parse(DbHelperSQL.execscalar(sql))).ToString();
                             }

                           
                         }
                         else
                         {
                             if (DbHelperSQL.isin(dgv1.Rows[i].Cells["物料NO"].Value.ToString(), "物料NO", "物料库存信息") == true)
                             {
                                 sql = "select 单独库存 from 物料库存信息 where 物料NO='" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "'";
                                 dgv1.Rows[i].Cells["可用库存"].Value = DbHelperSQL.execscalar(sql);
                             }
                             else
                             {
                                 dgv1.Rows[i].Cells["可用库存"].Value = "0";
                             }
                         }
                     }
                   

                }
        }

        private void dgv1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Columns[e.ColumnIndex].Name == "单价")
            {
                if (dgv1.CurrentRow.Cells["单价"].Value != null)
                {
                    if (numcheck.IsFloat(dgv1.CurrentRow.Cells["单价"].Value.ToString()) == true)
                    {
                        if (dgv1.CurrentRow.Cells["采购数量"].Value != null)
                        {

                            float x = float.Parse(dgv1.CurrentRow.Cells["单价"].Value.ToString());
                            float y = float.Parse(dgv1.CurrentRow.Cells["采购数量"].Value.ToString());
                            dgv1.CurrentRow.Cells["金额"].Value = (x * y).ToString();

                        }
                    }
                    else
                    {
                        MessageBox.Show("单价为小数格式");
                        dgv1.CurrentCell.Value = null;
                        return;
                    }
                }
            }
            if (dgv1.Columns[e.ColumnIndex].Name == "采购数量")
            {
                if (dgv1.CurrentRow.Cells["采购数量"].Value != null)
                {
                    if (numcheck.IsPositiveInteger(dgv1.CurrentRow.Cells["采购数量"].Value.ToString()) == true)
                    {
                        if (dgv1.CurrentRow.Cells["单价"].Value != null)
                        {
                                float x = float.Parse(dgv1.CurrentRow.Cells["单价"].Value.ToString());
                               
                                float y = float.Parse(dgv1.CurrentRow.Cells["采购数量"].Value.ToString());
                                dgv1.CurrentRow.Cells["金额"].Value = (x * y).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("采购数量只能是正整数");
                        dgv1.CurrentCell.Value=null;
                        return;
                    }
                }
            }
        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {//dgv不空
                IDSelected = dgv1.Rows[dgv1.CurrentRow.Index].Cells["物料NO"].Value.ToString();
            }
        }

        private void dgv1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                if (DbHelperSQL.isin(dgv1.Rows[i].Cells["物料NO"].Value.ToString(), "物料NO", "物料库存信息") == true)
                {
                    sql = "select 单独库存 from 物料库存信息 where 物料NO='" + dgv1.Rows[i].Cells["物料NO"].Value.ToString() + "'";
                    dgv1.Rows[i].Cells["可用库存"].Value = DbHelperSQL.execscalar(sql);
                }
                else
                {

                    dgv1.Rows[i].Cells["可用库存"].Value = "0";
                }
            }
        }

      
       
       

    }
}
