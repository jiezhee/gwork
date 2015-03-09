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
    public partial class 订单成品选择 : Form
    {
        public 订单成品选择()
        {
            InitializeComponent();
        }
        string sql = string.Empty;
        public string n = string.Empty;//传递成品num
        private void 订单成品选择_Load(object sender, EventArgs e)
        {
           
            sql += "SELECT code,name,描述,num FROM  production order by num desc";
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql);
            if (dgv1.DataSource != null)
            {
                dgv1.DataSource = null;
            }
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = dsData.Tables[0];
            dgv1.ClearSelection(); //取消选中
    
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgv1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {//只有点到按钮才触发(物料明细）
                    int index = DbHelperSQL.maxnum("加入序号", "sales");
                    string sql = "update sales set 商品型号='" + this.dgv1.CurrentRow.Cells["型号"].Value.ToString() + "',";
                    sql+="商品名称='" + this.dgv1.CurrentRow.Cells["品名"].Value.ToString() + "',";
                    sql += "成品num='" + this.dgv1.CurrentRow.Cells["编码"].Value.ToString() + "',";
                    sql+="商品描述='" + this.dgv1.CurrentRow.Cells["描述"].Value.ToString() + "'";
                    sql += "where 加入序号='" + index.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);

                    //插入订单成品库存
                    sql = "insert into 订单成品库存(订单加入序号) values('" + index.ToString() + "')";
                    DbHelperSQL.ExecuteSql(sql);
                    this.Close();
                 
                }
            }
        }
    }
}
