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
    public partial class 物料库存日志 : Form
    {
        public 物料库存日志()
        {
            InitializeComponent();
        }
        private string sql = string.Empty;
        string str2 = string.Empty;
        int tag = 0;


        public void search(string ss)
        {
            sql = "SELECT "+ss+" FROM  物料库存日志 order by 编码 desc";
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(sql);  
     
            dgv1.AutoGenerateColumns = false;
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中
        }

        private void 库存日志_Load(object sender, EventArgs e)
        {
            search("top(100)*");
        }

        private void dgv1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //上色
            if ("入库" == this.dgv1.Rows[e.RowIndex].Cells["出入库类别"].Value.ToString())
            {
                this.dgv1.Rows[e.RowIndex].Cells["出入库类别"].Style.BackColor = Color.Gold;
            }
            if ("出库" == this.dgv1.Rows[e.RowIndex].Cells["出入库类别"].Value.ToString())
            {
                this.dgv1.Rows[e.RowIndex].Cells["出入库类别"].Style.BackColor = Color.LightGreen;
            }
        }
       
        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tag == 0)
            {
                str2 = "*";//全选
                tag = 1;
                浏览ToolStripMenuItem.Text = "最近100记录";
            }
            else
            {
                str2 = "top(100)*";//选前50个记录
                tag = 0;
                浏览ToolStripMenuItem.Text = "全部记录";
            }
            search(str2);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
