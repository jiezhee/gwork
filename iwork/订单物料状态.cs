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
    public partial class 订单物料状态 : Form
    {
        public 订单物料状态()
        {
            InitializeComponent();
        }
        string sql = string.Empty;
        public void search()
        {
            //选出采购状态为正在采购的订单
            sql += "SELECT sales.订单编号,sales.商品型号,sales.商品名称,sales.商品描述,sales.加入序号,sales.生产状态 FROM sales,订单采购状态 where sales.加入序号=订单采购状态.订单加入序号 and sales.核销='未完成'";
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql);
            dgv1.AutoGenerateColumns = false;
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中

        }
        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search();
        }

        private void 采购审核_Load(object sender, EventArgs e)
        {
             search();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgv1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {//只有点到按钮才触发
                    订单物料库存 cgzt = new 订单物料库存();
                    cgzt.dingdan_addnum = this.dgv1.CurrentRow.Cells["订单加入序号"].Value.ToString();
                    cgzt.sql_start = "select 采购信息.订单加入序号,采购信息.物料NO,采购信息.料号,采购信息.品名,采购信息.单位,采购信息.型号规格,采购信息.供应商,采购信息.使用位置,物料采购状态.采购数量,物料采购状态.到齐,物料采购状态.库存 from 采购信息,物料采购状态 where 物料采购状态.订单加入序号='" + cgzt.dingdan_addnum + "' and 采购信息.订单加入序号=物料采购状态.订单加入序号 and 采购信息.编码=物料采购状态.采购编码 order by 供应商 ";
                    cgzt.prstatus = this.dgv1.CurrentRow.Cells["生产状态"].Value.ToString();
                    cgzt.ShowDialog();
                 
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
