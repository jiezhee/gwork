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


namespace iwork
{
    public partial class 采购日志 : Form
    {
        public 采购日志()
        {
            InitializeComponent();
        }
        string sql = string.Empty;
        private  DataSet dsData = new DataSet();
        string str2 = string.Empty;
        int tag = 0;
        public void Search(string ss)
        {

           
           
            sql = "SELECT "+ss+" FROM   采购信息  order by 编码 desc";

            dsData = DbHelperSQL.Query(sql); 
     
            this.dgv1.ColumnHeadersHeight = 30;//标题行高
            if (dgv1.DataSource != null)
            {
                dgv1.DataSource = null;
            }
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];

            dgv1.AutoGenerateColumns = false;
            this.dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中

            //裁剪日期格式
            int spaceindex = 0;
            string strdate = string.Empty;
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    strdate = dgv1.Rows[i].Cells["日期"].Value.ToString();
                    spaceindex = strdate.IndexOf(" ");
                    dgv1.Rows[i].Cells["日期"].Value = strdate.Substring(0, spaceindex);
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
                浏览ToolStripMenuItem.Text = "全部采购记录";
            }
            Search(str2);

        }

        private void 采购单管理_Load(object sender, EventArgs e)
        {
            Search("top(100)*");
        }

        private void 筛选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            采购信息筛选 cgsx = new 采购信息筛选();
            cgsx.ShowDialog();

            if (cgsx.DialogResult == DialogResult.OK)
            {
                DataSet ds_this = cgsx.ds.Copy();
                cgsx.Close();

                BindingSource ss = new BindingSource();
                ss.DataSource =ds_this.Tables[0];

                dgv1.DataSource = null; 
                dgv1.AutoGenerateColumns = false;
                dgv1.DataSource = ss;
                dgv1.ClearSelection(); //取消选中

                int spaceindex = 0;
                string strdate = string.Empty;
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    strdate = dgv1.Rows[i].Cells["日期"].Value.ToString();
                    spaceindex = strdate.IndexOf(" ");
                    dgv1.Rows[i].Cells["日期"].Value = strdate.Substring(0, spaceindex);
                    dgv1.Rows[i].Cells["序号"].Value = dgv1.Rows[i].Cells["采购单序号"].Value.ToString() + "-" + dgv1.Rows[i].Cells["物料序号"].Value.ToString();
                }
            }
        }



        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                if (e.ColumnIndex != -1)
                {           
                    if (this.dgv1.Columns[e.ColumnIndex].Name == "是否取消")
                    {//点到"是否取消"触发

                        if (dgv1.CurrentCell.Value.ToString() == "否")
                        {

                            DialogResult result = MessageBox.Show("是否取消该采购信息？", "取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                dgv1.CurrentCell.Value = "是";
                                sql = "update 采购信息 set [是否取消]='是' where 编码='" + dgv1.CurrentRow.Cells["编码"].Value.ToString() + "'";
                                DbHelperSQL.ExecuteSql(sql);
                                MessageBox.Show("已取消");
                            }
                            else { return; }
                        }
                        else
                            if (dgv1.CurrentCell.Value.ToString() == "是")
                            {

                                DialogResult result = MessageBox.Show("是否恢复该采购信息？", "撤销取消", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    dgv1.CurrentCell.Value = "否";
                                    sql = "update 采购信息 set [是否取消]='否' where 编码='" + dgv1.CurrentRow.Cells["编码"].Value.ToString() + "'";
                                    DbHelperSQL.ExecuteSql(sql);
                                    MessageBox.Show("已恢复");
                                }
                                else { return; }
                            }
                    }
                }
            }
        }

        private void dgv1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //上色

          //      this.dgv1.Rows[e.RowIndex].Cells["是否取消"].Style.BackColor = Color.Gold;
          
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }//

    }
}
