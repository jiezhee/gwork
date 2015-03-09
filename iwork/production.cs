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
    public partial class production : Form
    {
        public production()
        {
            InitializeComponent();
        }
        private bool flag = false;//标记有没点相似添加
        private string IDSelected=string.Empty;
        internal static void show()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {

            string sql = string.Empty;
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



        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search();
            if (flag == true)
                flag = false;
        }

        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pr_sort ps = new pr_sort();  
            ps.ShowDialog();
            if (ps.DialogResult == DialogResult.OK)
            {
                DataSet ds_this = ps.dsData.Copy();      
                ps.Close();
                dgv1.DataSource = null;
               dgv1.AutoGenerateColumns = false;
               dgv1.DataSource =ds_this.Tables[0];
               dgv1.ClearSelection(); //取消选中
            
            }
        
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgv1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {//只有点到按钮才触发(物料明细）
                    pmdetail pm = new pmdetail();
                    DataSet ds1 = new DataSet();
                    string sql = string.Empty;
            //        sql += "SELECT * FROM  material where NO in(";
            //        sql += "select ma_num from pr_ma where pr_num=" + dgv1.CurrentRow.Cells["编码"].Value.ToString() + ") order by NO";

                    sql = "select material.*,pr_ma.用量,pr_ma.使用位置,pr_ma.BOM备注 from material,pr_ma where pr_num=" + dgv1.CurrentRow.Cells["编码"].Value.ToString() + " and pr_ma.ma_num=material.NO order by material.类别 asc,material.NO asc";
                    ds1 = DbHelperSQL.Query(sql);             
                    pm.dgv1.AutoGenerateColumns = false;
                    BindingSource s = new BindingSource();
                    s.DataSource = ds1.Tables[0];
                    pm.dgv1.DataSource = s;
                    pm.dgv1.ClearSelection(); //取消选中  
           

        /*            
                    DataSet ds2 = new DataSet();              
                    sql = "select ma_num,用量,使用位置,备注 from pr_ma where pr_num=" + dgv1.CurrentRow.Cells["编码"].Value.ToString()+" order by ma_num";   
                    ds2 = DbHelperSQL.Query(sql);
                    for (int j = 0; j < ds2.Tables[0].Rows.Count; j++)
                    {
                        MessageBox.Show(ds2.Tables[0].Rows[j]["用量"].ToString());
                        pm.dgv1.Rows[j].Cells["用量"].Value = ds2.Tables[0].Rows[j]["用量"];
                        pm.dgv1.Rows[j].Cells["使用位置"].Value = ds2.Tables[0].Rows[j]["使用位置"];
                        pm.dgv1.Rows[j].Cells["备注"].Value = ds2.Tables[0].Rows[j]["备注"];
                    }
                    //bindingsource绑定了，无法修改dgv
          */    
                    pm.Text = dgv1.CurrentRow.Cells["型号"].Value.ToString() + "-物料明细";
                    pm.ShowDialog();
                    if (flag == true)
                        flag = false;
                }
            }

        }

        private void production_Load(object sender, EventArgs e)
        {
             Search();
        }

        private void 全新添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pr_add1 pa1 = new pr_add1();
            pa1.ShowDialog();
            Search();
            if (flag == true)
                flag = false;
        }

        private void 相似添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("双击选择相似成品");
            flag = true;//有双击
        }

    

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
            {
                if (e.RowIndex >= 0)
                {
                    pr_edit pseem = new pr_edit();
                    pseem.Text = "成品资料相似添加";
                    pseem.textBox1.Text = dgv1.CurrentRow.Cells["型号"].Value.ToString();
                    pseem.textBox2.Text = dgv1.CurrentRow.Cells["品名"].Value.ToString();
                    pseem.textBox3.Text = dgv1.CurrentRow.Cells["描述"].Value.ToString();
                    pseem.which = 1;
                    pseem.num = int.Parse(dgv1.CurrentRow.Cells["编码"].Value.ToString());
                    pseem.ShowDialog();
                    Search();
                    flag = false;
                }
            }
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IDSelected == string.Empty)
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }
            pr_edit pe = new pr_edit();
            pe.Text = "成品资料编辑";
            if(dgv1.CurrentRow.Cells["型号"].Value!=null)
                pe.textBox1.Text = dgv1.CurrentRow.Cells["型号"].Value.ToString();
            if (dgv1.CurrentRow.Cells["品名"].Value != null)
                pe.textBox2.Text = dgv1.CurrentRow.Cells["品名"].Value.ToString();
            if (dgv1.CurrentRow.Cells["描述"].Value != null)
                pe.textBox3.Text = dgv1.CurrentRow.Cells["描述"].Value.ToString();

            pe.num = Int32.Parse(dgv1.CurrentRow.Cells["编码"].Value.ToString());
            pe.which = 2;
            pe.ShowDialog();
            if (pe.DialogResult == DialogResult.OK)
            {
                this.dgv1.CurrentRow.Cells["型号"].Value = pe.textBox1.Text;
                this.dgv1.CurrentRow.Cells["品名"].Value = pe.textBox2.Text;
                this.dgv1.CurrentRow.Cells["描述"].Value = pe.textBox3.Text;
                pe.Close();
            }

            if (flag == true)
                flag = false;
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
                IDSelected = dgv1.Rows[dgv1.CurrentRow.Index].Cells["编码"].Value.ToString();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shanchuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = string.Empty;
            if (IDSelected == string.Empty)
            {
                MessageBox.Show("选择删除行");
                return;
            }
            DialogResult result = MessageBox.Show("确定删除吗？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                sql = "delete from [production]  ";
                sql += " WHERE [num]='" +dgv1.CurrentRow.Cells["编码"].Value.ToString()+ "'";
                DBUtility.DbHelperSQL.ExecuteSql(sql);
                dgv1.Rows.RemoveAt(dgv1.CurrentCell.RowIndex);
                Search();
            }
            IDSelected = string.Empty;
            if (flag == true)
                flag = false;
        }

        private void dgv1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dgv1.RowCount; i++)
                dgv1.Rows[i].Cells["BOM"].Value = "查看";
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

    }
}
