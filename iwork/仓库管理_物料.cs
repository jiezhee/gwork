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
    public partial class 仓库管理_物料 : Form
    {
        public 仓库管理_物料()
        {
            InitializeComponent();
        }
        string sql = string.Empty;

        private  string cancel_num =string.Empty;
        private  string  cancel_quantity=string.Empty;
        private bool cancel_nochange = true;
        private bool cancel_storage = true;//标记出入库


        public void update()
        {
            //更新库存，存入物料库存信息
            sql = "select 物料NO,sum(库存) as 库存 from 物料采购状态 group by 物料NO";
            DataSet s = new DataSet();
            s = DbHelperSQL.Query(sql);
            for (int i = 0; i < s.Tables[0].Rows.Count; i++)
            {
                if (DbHelperSQL.isin(s.Tables[0].Rows[i]["物料NO"].ToString(), "物料NO", "物料库存信息") == true)
                {
                    //存在库存记录
                    sql = "update 物料库存信息 set 库存='" + s.Tables[0].Rows[i]["库存"].ToString() + "' where 物料NO='" + s.Tables[0].Rows[i]["物料NO"].ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);

                    //更新总库存
                    int dandukucun = int.Parse(DbHelperSQL.execscalar("select 单独库存 from 物料库存信息 where 物料NO='" + s.Tables[0].Rows[i]["物料NO"].ToString() + "'"));
                    int sum = dandukucun + int.Parse(s.Tables[0].Rows[i]["库存"].ToString());
                    sql = "update 物料库存信息 set 总库存='" + sum.ToString() + "' where 物料NO='" + s.Tables[0].Rows[i]["物料NO"].ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);
                }
                else
                {
                    //插入物料库存信息
                    sql = "insert into 物料库存信息(物料NO,料号,品名) select material.NO,material.料号,material.品名 from material where NO='" + s.Tables[0].Rows[i]["物料NO"].ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);
                    sql = "update 物料库存信息 set 库存='" + s.Tables[0].Rows[i]["库存"].ToString() + "' where 物料NO='" + s.Tables[0].Rows[i]["物料NO"].ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);
                    //总库存
                    sql = "update 物料库存信息 set 总库存='" + s.Tables[0].Rows[i]["库存"].ToString() + "' where 物料NO='" + s.Tables[0].Rows[i]["物料NO"].ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);
                }
            }
        }
        public void Search(string order)
        {
            sql = "delete from 物料库存信息 where 总库存<='0'";
            DbHelperSQL.ExecuteSql(sql);

            sql = "SELECT * FROM  物料库存信息 order by 物料NO " + order;
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql);
            if (dgv1.DataSource != null)
            {
                dgv1.DataSource = null;
            }
            dgv1.AutoGenerateColumns = false;
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中

           
        }
        private void 基础录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Search("asc");
            if (cancel_nochange == false)
            {
                cancel_nochange = true;
            }
         
        }

        private void 仓库管理_物料_Load(object sender, EventArgs e)
        {
            update();
            Search("asc");
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

                            //写入物料库存信息
                            sql = "update 物料库存信息 set 单独库存=((select 单独库存 from 物料库存信息 where 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "')+" + rc.t1.Text + ") where 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);
                            sql = "update 物料库存信息 set 总库存=((select 总库存 from 物料库存信息 where 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "')+" + rc.t1.Text + ") where 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                            DbHelperSQL.ExecuteSql(sql);

                            //写入物料库存日志
                           sql= "insert into 物料库存日志(物料NO,料号,品名) select material.NO,material.料号,material.品名 from material where NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                           DbHelperSQL.ExecuteSql(sql);
                           sql = "update 物料库存日志 set 日期='" + DateTime.Now.ToString() + "'";
                           sql += ",出入库类别='入库'";
                           sql += ",数量='" + rc.t1.Text + "'";
                           sql += ",出入库方式='单独入库'";
                           int code = DbHelperSQL.maxnum("编码", "物料库存日志");
                           sql += " where 编码='" + code.ToString() + "'";
                        
                           DbHelperSQL.ExecuteSql(sql);

                           
                            //存撤销信息
                            cancel_nochange = false;
                            cancel_num=dgv1.CurrentRow.Cells["物料NO"].Value.ToString();
                            cancel_quantity =rc.t1.Text;
                            cancel_storage = true;

                            //修改dgv1
                            int temp;
                            temp = int.Parse(this.dgv1.CurrentRow.Cells["总库存"].Value.ToString());
                            temp+= int.Parse(rc.t1.Text.ToString());
                            dgv1.CurrentRow.Cells["本次库存变化"].Value ="入"+ rc.t1.Text;
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
                                temp1 = int.Parse(dgv1.CurrentRow.Cells["单独库存"].Value.ToString()) - int.Parse(cc.t1.Text);
                                if (temp1 < 0)
                                    MessageBox.Show("出库数不能大于当前单独库存");
                                else
                                {
                                    //存入物料库存信息
                                    sql = "update 物料库存信息 set 单独库存=((select 单独库存 from 物料库存信息 where 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "')-" + cc.t1.Text + ") where 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);
                                    sql = "update 物料库存信息 set 总库存=((select 总库存 from 物料库存信息 where 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "')-" + cc.t1.Text + ") where 物料NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);

                                    //存入物料库存日志
                                    sql = "insert into 物料库存日志(物料NO,料号,品名) select material.NO,material.料号,material.品名 from material where NO='" + dgv1.CurrentRow.Cells["物料NO"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);
                                    sql = "update 物料库存日志 set 日期='" + DateTime.Now.ToString() + "'";
                                    sql += ",出入库类别='出库'";
                                    sql += ",数量='" + cc.t1.Text + "'";
                                    sql += ",出入库方式='单独出库'";
                                    int code = DbHelperSQL.maxnum("编码", "物料库存日志");
                                    sql += " where 编码='" + code.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);

                                    //撤销信息
                                    cancel_nochange = false;
                                    cancel_num = dgv1.CurrentRow.Cells["物料NO"].Value.ToString();
                                    cancel_quantity = cc.t1.Text;
                                    cancel_storage = false;

                                    //更新dgv1
                                    int temp;
                                    temp = int.Parse(this.dgv1.CurrentRow.Cells["总库存"].Value.ToString());
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
                    //撤销入库（物料库存信息表）                              
                        sql = "update 物料库存信息 set 单独库存=((select 单独库存 from 物料库存信息 where 物料NO='" + cancel_num + "')-" + cancel_quantity + ") where 物料NO='" + cancel_num + "'";
                        DbHelperSQL.ExecuteSql(sql);
                        sql = "update 物料库存信息 set 总库存=((select 总库存 from 物料库存信息 where 物料NO='" + cancel_num + "')-" + cancel_quantity + ") where 物料NO='" + cancel_num + "'";
                        DbHelperSQL.ExecuteSql(sql);
                        dgv1.CurrentRow.Cells["总库存"].Value = int.Parse(dgv1.CurrentRow.Cells["出入库后总库存"].Value.ToString()) - int.Parse(cancel_quantity);
                        dgv1.CurrentRow.Cells["本次库存变化"].Value = null;
                        dgv1.CurrentRow.Cells["出入库后总库存"].Value = null;
                 //撤销库存日志
                        int temp4=DbHelperSQL.maxnum("编码","物料库存日志");
                        sql = "delete from 物料库存日志 where 编码='" + temp4.ToString() + "'";
                        DbHelperSQL.ExecuteSql(sql);
               
                   
                }
                else
                {
                    //撤销出库(物料库存信息表)               
                  
                        sql = "update 物料库存信息 set 单独库存=((select 单独库存 from 物料库存信息 where 物料NO='" + cancel_num + "')+" + cancel_quantity + ") where 物料NO='" + cancel_num + "'";
                        DbHelperSQL.ExecuteSql(sql);
                        sql = "update 物料库存信息 set 总库存=((select 总库存 from 物料库存信息 where 物料NO='" + cancel_num + "')+" + cancel_quantity + ") where 物料NO='" + cancel_num + "'";
                        DbHelperSQL.ExecuteSql(sql);
                        dgv1.CurrentRow.Cells["总库存"].Value = int.Parse(dgv1.CurrentRow.Cells["出入库后总库存"].Value.ToString()) + int.Parse(cancel_quantity);
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

        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            库存信息搜索 ccss = new 库存信息搜索();
            ccss.ShowDialog();
            if (ccss.DialogResult == DialogResult.OK)
            {
                DataSet ds_this = ccss.ds.Copy();
                ccss.Close();

                dgv1.DataSource = null;
                dgv1.AutoGenerateColumns = false;
                BindingSource ss = new BindingSource();
                ss.DataSource = ds_this.Tables[0];
                dgv1.DataSource = ss;
                dgv1.ClearSelection(); //取消选中
                    
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            库存信息添加 cctj = new 库存信息添加();
            cctj.ShowDialog();
           
            if (cctj.DialogResult == DialogResult.OK)
            {
                //单独显示刚才添加的行
                int flag = 0;
                string str1 = string.Empty;
                DataSet ds2 = new DataSet();
                //清空dgv1
                dgv1.DataSource = null;
                dgv1.Refresh();

                sql = "select * from [物料库存信息] where";               //有非空的
                if (cctj.t1.Text != string.Empty)
                {
                        sql += "[物料NO]='" + cctj.t1.Text + "'";
                        flag = 1;//之前的属性有非空的
                  

                }
                if (cctj.t2.Text != string.Empty)
                {         
                        if (flag == 1)
                            str1 = " and ";
                        else
                        {
                            str1 = "";
                            flag = 1;
                        }
                        sql += str1 + "[料号]='" + cctj.t2.Text + "'";

                }

            
                ds2 = DbHelperSQL.Query(sql);
                dgv1.AutoGenerateColumns = false;   
                BindingSource sss = new BindingSource();
                sss.DataSource = ds2.Tables[0];
                dgv1.DataSource = sss;
                dgv1.ClearSelection(); //取消选中
            }
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
