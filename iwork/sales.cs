using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBUtility;
using DataGridViewAutoFilter;
using digits;

namespace iwork
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }
        private int k = 0;//psn[k]
        private int i = 0;
        private bool changed = false;
        private bool flag = false;//true为已点击保存，退出不需提示保存
        private string sql = string.Empty;

        private string str1 = string.Empty;
        private string IDSelected = string.Empty;
        DataSet dsData = new DataSet();
        private struct rec_editpsn
        {
            public int x;
            public int y;
        }//变化表

        rec_editpsn[] psn = new rec_editpsn[100];
        string str2 = string.Empty;
        int tag = 0;
        private void sales_Load(object sender, EventArgs e)
        {
            Search("top(50)*");


        }

        public void Search(string ss)
        {
            string strSql = string.Empty;

            strSql = "SELECT " + ss + " FROM   sales  order by 加入序号 desc";

            dsData = DbHelperSQL.Query(strSql);

            dgv1.AutoGenerateColumns = false;
            this.dgv1.ColumnHeadersHeight = 30;//标题行高
            if (dgv1.DataSource != null)
                dgv1.DataSource = null;
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            this.dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中



        }


        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tag == 0)
            {
                str2 = "*";//全选
                tag = 1;
                浏览ToolStripMenuItem.Text = "最近50订单";
            }
            else
            {
                str2 = "top(50)*";//选前50个记录
                tag = 0;
                浏览ToolStripMenuItem.Text = "全部订单";
            }
            Search(str2);
        }

        private void dgv1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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


            string strtemp = dgv1.Columns[e.ColumnIndex].Name;
            if (strtemp == "签订数量" || strtemp == "赠品数量" || strtemp == "出货数量")
            {

                if (dgv1.CurrentRow.Cells[strtemp].Value != null)
                {
                    if (numcheck.IsPositiveInteger(dgv1.CurrentRow.Cells[strtemp].Value.ToString()) == false)
                    {
                        MessageBox.Show("数量只能是正整数");
                        dgv1.CurrentCell.Value = null;
                        return;
                    }
                }
            }

            //计算总额
            if (dgv1.Columns[e.ColumnIndex].Name == "销售单价")
            {
                if (dgv1.CurrentRow.Cells["销售单价"].Value != null)
                {
                    if (numcheck.IsFloat(dgv1.CurrentRow.Cells["销售单价"].Value.ToString()) == true)
                    {
                        if (dgv1.CurrentRow.Cells["签订数量"].Value != null)
                        {

                            float x = float.Parse(dgv1.CurrentRow.Cells["销售单价"].Value.ToString());
                            float y = float.Parse(dgv1.CurrentRow.Cells["签订数量"].Value.ToString());
                            dgv1.CurrentRow.Cells["销售金额"].Value = (x * y).ToString();
                            sql = "update sales set 销售金额='" + dgv1.CurrentRow.Cells["销售金额"].Value.ToString() + "' where 加入序号='" + dgv1.CurrentRow.Cells["加入序号"].Value.ToString() + "'";
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
                    sql = "update sales set 销售金额='0' where 加入序号='" + dgv1.CurrentRow.Cells["加入序号"].Value.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);
                }
            }
            if (dgv1.Columns[e.ColumnIndex].Name == "签订数量")
            {
                if (dgv1.CurrentRow.Cells["签订数量"].Value != null)
                {
                    if (numcheck.IsPositiveInteger(dgv1.CurrentRow.Cells["签订数量"].Value.ToString()) == true)
                    {
                        if (dgv1.CurrentRow.Cells["销售单价"].Value.ToString() != string.Empty)
                        {
                            //不为空肯定是通过了检查的
                            float x = float.Parse(dgv1.CurrentRow.Cells["销售单价"].Value.ToString());

                            int y = int.Parse(dgv1.CurrentRow.Cells["签订数量"].Value.ToString());
                            dgv1.CurrentRow.Cells["销售金额"].Value = (x * y).ToString();
                            sql = "update sales set 销售金额='" + dgv1.CurrentRow.Cells["销售金额"].Value.ToString() + "' where 加入序号='" + dgv1.CurrentRow.Cells["加入序号"].Value.ToString() + "'";
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
                    sql = "update sales set 销售金额='0' where 加入序号='" + dgv1.CurrentRow.Cells["加入序号"].Value.ToString() + "'";
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

        private void sales_FormClosing(object sender, FormClosingEventArgs e)
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
                            rowname = dgv1.Rows[psn[i].x].Cells["加入序号"].Value.ToString();//行名-订单编号
                            sql = "update sales set " + colname + "='";
                            sql += dgv1.Rows[psn[i].x].Cells[psn[i].y].Value.ToString() + "'";
                            sql += " where 加入序号='" + rowname + "'";
                            DbHelperSQL.ExecuteSql(sql);
                        }

                        if (i == k)
                            MessageBox.Show("修改已保存");
                    }
                    else
                    {
                        MessageBox.Show("修改未保存");
                        return;
                    }
                }
            }
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
                    rowname = dgv1.Rows[psn[i].x].Cells["加入序号"].Value.ToString();//行名-订单编号
                    sql = "update sales set " + colname + "='";

                    sql += dgv1.Rows[psn[i].x].Cells[psn[i].y].Value.ToString() + "'";
                    sql += " where 加入序号='" + rowname + "'";
                    DbHelperSQL.ExecuteSql(sql);
                }

                if (i == k)
                {
                    MessageBox.Show("修改已保存");
                    changed = false;
                    k = 0;
                    flag = true;
                }
                else
                {
                    MessageBox.Show("修改部分未保存");
                    flag = false;
                }
            }
            else
                MessageBox.Show("记录无变化");
        }





        private void 添加ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //添加
            sql = "insert into sales([订单日期],[生产状态],[核销]) values('" + DateTime.Now.ToString() + "','等待采购','未完成')";
            DbHelperSQL.ExecuteSql(sql);
            Search("top(50)*");
            订单成品选择 ddcpxz = new 订单成品选择();
            ddcpxz.ShowDialog();

            Search("top(50)*");

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
                sql = "delete from [sales]  ";
                sql += " WHERE [加入序号]='" + IDSelected + "'";
                DBUtility.DbHelperSQL.ExecuteSql(sql);
                dgv1.Rows.RemoveAt(dgv1.CurrentCell.RowIndex);

                //删除连带信息
                //订单成品库存
                sql = "delete from 订单成品库存 where 编码='" + DbHelperSQL.maxnum("编码", "订单成品库存") + "'";
                DbHelperSQL.ExecuteSql(sql);


                Search("top(50)*");
            }
            IDSelected = string.Empty;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {//dgv不空
                IDSelected = dgv1.Rows[dgv1.CurrentRow.Index].Cells["加入序号"].Value.ToString();

                if (e.RowIndex > -1&&e.ColumnIndex>-1)
                {//点标题不触发
                    if (this.dgv1.Columns[e.ColumnIndex].Name == "有无其他零部件")
                    {
                        if (this.dgv1.CurrentCell.Value.ToString() == "有")
                        {

                            sales_other so = new sales_other();
                            if (dgv1.CurrentRow.Cells["订单编号"].Value != null)
                                so.ordernum = dgv1.CurrentRow.Cells["订单编号"].Value.ToString();
                            if (dgv1.CurrentRow.Cells["订单日期"].Value != null)
                                so.dt = dgv1.CurrentRow.Cells["订单日期"].Value.ToString();
                            if (dgv1.CurrentRow.Cells["版本号"].Value != null)
                                so.ver_num = dgv1.CurrentRow.Cells["版本号"].Value.ToString();
                            so.ShowDialog();
                        }
                    }
                    if (this.dgv1.Columns[e.ColumnIndex].Name == "核销")
                    {
                        if (this.dgv1.CurrentCell.Value.ToString() == "未完成")
                        {
                            DialogResult result = MessageBox.Show("确定修改为已完成？", "确定修改？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                dgv1.CurrentCell.Value = "完成";
                                sql = "update sales set [核销] ='完成' where 加入序号='" + dgv1.CurrentRow.Cells["加入序号"].Value.ToString() + "'";
                                DbHelperSQL.ExecuteSql(sql);

                                //未用完的物料入物料库存信息
                                sql = "select 物料NO,sum(库存) as 库存 from 物料采购状态 where 订单加入序号='" + this.dgv1.CurrentRow.Cells["加入序号"].Value.ToString() + "' group by 物料NO";
                                DataSet ds = new DataSet();
                                ds = DbHelperSQL.Query(sql);
                                int flag = 0;
                                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                                {    
                                    if (int.Parse(ds.Tables[0].Rows[j]["库存"].ToString()) > 0)
                                    {
                                        flag = 1;
                                        if (DbHelperSQL.isin(ds.Tables[0].Rows[j]["物料NO"].ToString(), "物料NO", "物料库存信息") == true)
                                        {
                                            //订单库存转入单独库存
                                            sql = "update 物料库存信息 set 单独库存=((select 单独库存 from 物料库存信息 where 物料NO='" + ds.Tables[0].Rows[j]["物料NO"].ToString() + "')+" + ds.Tables[0].Rows[j]["库存"].ToString() + ") where 物料NO='" + ds.Tables[0].Rows[j]["物料NO"].ToString() + "'";
                                            DbHelperSQL.ExecuteSql(sql);
                                            sql = "update 物料采购状态 set 库存='0' where 订单加入序号='" + dgv1.CurrentRow.Cells["加入序号"].Value.ToString() + "' and 物料NO='" + ds.Tables[0].Rows[j]["物料NO"].ToString() + "'";
                                            DbHelperSQL.ExecuteSql(sql);

                                        }
                                        else
                                        {
                                            //插入物料库存信息
                                            sql = "insert into 物料库存信息(物料NO,料号,品名) select material.NO,material.料号,material.品名 from material where NO='" + ds.Tables[0].Rows[j]["物料NO"].ToString() + "'";
                                            DbHelperSQL.ExecuteSql(sql);
                                            sql = "update 物料库存信息 set 单独库存='" + ds.Tables[0].Rows[j]["库存"].ToString() + "' where 物料NO='" + ds.Tables[0].Rows[j]["物料NO"].ToString() + "'";
                                            DbHelperSQL.ExecuteSql(sql);
                                            sql = "update 物料采购状态 set 库存='0' where 订单加入序号='" + dgv1.CurrentRow.Cells["加入序号"].Value.ToString() + "' and 物料NO='" + ds.Tables[0].Rows[j]["物料NO"].ToString() + "'";

                                            DbHelperSQL.ExecuteSql(sql);
                                        }  

                                    }
                                }
                                if(flag==1)
                                    MessageBox.Show("订单剩余物料已经转入物料库存信息");

                                //  Search();
                            }
                        }
                    }
                    if (this.dgv1.Columns[e.ColumnIndex].Name == "生产状态")
                    {
                        if (dgv1.CurrentRow.Cells["核销"].Value.ToString() != "完成")
                        {

                            订单物料库存 cgzt = new 订单物料库存();
                            cgzt.cgstr = dgv1.CurrentRow.Cells["加入序号"].Value.ToString();
                            cgzt.sql_start = "select 采购信息.订单加入序号,采购信息.物料NO,采购信息.料号,采购信息.品名,采购信息.单位,采购信息.型号规格,采购信息.供应商,采购信息.使用位置,采购信息.采购数量,物料采购状态.到齐,物料采购状态.库存 from 采购信息,物料采购状态 where 物料采购状态.订单加入序号='" + cgzt.cgstr + "' and 采购信息.订单加入序号=物料采购状态.订单加入序号 and 采购信息.编码=物料采购状态.采购编码 order by 供应商";
                            cgzt.prstatus = this.dgv1.CurrentRow.Cells["生产状态"].Value.ToString();
                            cgzt.dgv1.ReadOnly = true;
                            cgzt.dgv1.Columns["本次库存变化"].Visible = false;
                            cgzt.dgv1.Columns["出入库后总库存"].Visible = false;
                            cgzt.dgv1.Columns["入库"].Visible = false;
                            cgzt.dgv1.Columns["出库"].Visible = false;
                            cgzt.Width = 1010;
                            cgzt.ShowDialog();
                        }

                    }
                  
                }
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgv1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //上色
            if ("有" == this.dgv1.Rows[e.RowIndex].Cells["有无其他零部件"].Value.ToString())
            {
                this.dgv1.Rows[e.RowIndex].Cells["有无其他零部件"].Style.BackColor = Color.LightGreen;
            }
            else
                if ("无" == this.dgv1.Rows[e.RowIndex].Cells["有无其他零部件"].Value.ToString())
                {
                    this.dgv1.Rows[e.RowIndex].Cells["有无其他零部件"].Style.BackColor = Color.LightGray;
                }

            if ("未完成" == this.dgv1.Rows[e.RowIndex].Cells["核销"].Value.ToString())
            {
                this.dgv1.Rows[e.RowIndex].Cells["核销"].Style.BackColor = Color.LightGreen;
            }
            else
                if ("完成" == this.dgv1.Rows[e.RowIndex].Cells["核销"].Value.ToString())
                {
                    this.dgv1.Rows[e.RowIndex].Cells["核销"].Style.BackColor = Color.LightGray;
                }


            if ("等待采购" == this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Value.ToString())
            {
                this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Style.BackColor = Color.LightPink;
            }
            else
                if ("正在采购" == this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Value.ToString())
                {
                    this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Style.BackColor = Color.LightGreen;
                }
                else
                    if ("准备生产" == this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Value.ToString())
                    {
                        this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Style.BackColor = Color.Yellow;
                    }
                    else
                        if ("正在生产" == this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Value.ToString())
                        {
                            this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Style.BackColor = Color.LightSkyBlue;
                        }
                        else
                            if ("已完成" == this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Value.ToString())
                            {
                                this.dgv1.Rows[e.RowIndex].Cells["生产状态"].Style.BackColor = Color.LightGray;
                            }

        }


        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search("top(50)*");
        }

        private void 小提示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            帮助 help = new 帮助();
            help.ShowDialog();
        }

        private void dgv1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void dgv1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
            {//dgv不空
                if (e.ColumnIndex > -1 && e.RowIndex > -1)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        if (this.dgv1.Columns[e.ColumnIndex].Name == "订单描述")
                        {
                            if (this.dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != string.Empty)
                            {
                                订单描述 ddms = new 订单描述();
                                ddms.rt1.Text = "    "+ this.dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                                ddms.ShowDialog();
                            }

                        }
                    }
                }
            }
        }





    }
}
