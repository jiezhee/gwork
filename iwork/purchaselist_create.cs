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
    public partial class purchaselist_create : Form
    {
        public purchaselist_create()
        {
            InitializeComponent();
        }

        public string sql_start = string.Empty;
        public string sql = string.Empty;
        public int which = 0;//默认为0,第一次采购；若为补料,则which=1;
        public void search()
        {
           
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql_start);

            dgv1.AutoGenerateColumns = false;
            BindingSource s = new BindingSource();
            s.DataSource= dsData.Tables[0];
            dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中
        
        }
        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           search();

        }

        private void purchaselist_create_Load(object sender, EventArgs e)
        {
            search();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgv1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {//只有点到按钮才触发(物料明细）
                    purlist_madetail pmd = new purlist_madetail();
                    DataSet ds1 = new DataSet();

                    sql = "select material.NO,material.料号,material.品名,material.单位,material.型号规格,material.供应商,pr_ma.使用位置,pr_ma.用量 from material,pr_ma where pr_num=" + dgv1.CurrentRow.Cells["成品num"].Value.ToString() + " and pr_ma.ma_num=material.NO order by material.供应商 asc,material.NO asc";
                    ds1 = DbHelperSQL.Query(sql);
          
                    pmd.dgv1.AutoGenerateColumns = false;
                    pmd.dgv1.DataSource = ds1.Tables[0];
                    pmd.dgv1.ClearSelection(); //取消选中  

                   
                    pmd.prcode = dgv1.CurrentRow.Cells["商品型号"].Value.ToString();
                    pmd.Text = pmd.prcode + "-物料明细";
                    if (which == 0)
                        pmd.which = 0;
                    else
                        if (which == 1)
                            pmd.which = 1;

                    pmd.dingdan_addnum = dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString();
                    pmd.ShowDialog();
                    if (pmd.DialogResult == DialogResult.OK)
                        this.Close();
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 订单补料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaselist_create ddbl = new purchaselist_create();
            ddbl.Text = "选择以下未完成订单以添加采购";
            ddbl.sql_start = "SELECT 订单编号,商品型号,商品名称,商品描述,成品num,加入序号,生产状态 FROM sales where 生产状态<>'已完成' and 生产状态<>'等待采购' order by 加入序号 desc";
            ddbl.订单补料ToolStripMenuItem.Visible = false;
            ddbl.which = 1;
            ddbl.ShowDialog();
        }



    
    }
}
