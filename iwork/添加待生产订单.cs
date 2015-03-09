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
    public partial class 添加待生产订单 : Form
    {
        public 添加待生产订单()
        {
            InitializeComponent();
        }

        private string sql = string.Empty;
        private DataSet ds = new DataSet();
        private void 添加待生产订单_Load(object sender, EventArgs e)
        {

            sql = "select 订单编号,商品名称,签订数量 from sales where 生产状态='准备生产'";
             ds=DbHelperSQL.Query(sql);
             dgv1.AutoGenerateColumns = false;
            this.dgv1.DataSource = ds.Tables[0];
            dgv1.ClearSelection(); //取消选中
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                dgv1.Rows[i].Cells["加入"].Value = false;
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv1.RowCount; i++)
            {
                object value = dgv1.Rows[i].Cells["加入"].EditedFormattedValue;
                if (true == (Boolean)value)
                {
                    //需要添加
                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewColumn column = dgv1.Columns[e.ColumnIndex];
                if (column is DataGridViewCheckBoxColumn)
                {
                    if ((Boolean)dgv1.CurrentRow.Cells["加入"].Value == false)
                        dgv1.CurrentRow.Cells["加入"].Value = true;
                    else
                        dgv1.CurrentRow.Cells["加入"].Value = false;
                }
            }
        }
    }
}
