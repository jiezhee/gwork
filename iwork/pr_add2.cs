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
    public partial class pr_add2 : Form
    {
        private string sql = string.Empty;
        private int j = 0;
        private int i = 0;
        public int num = 0;//编辑时成品编号
        public pr_add1 p1 = null;
        public pr_edit pedit = null;
        public int which;
        public string IDSelected = string.Empty;
        public pr_add2()
        {
            InitializeComponent();
        }

        public void GetForm(pr_add1 theform)
        {
            p1 = theform;
        }


        public void GetForms(pr_edit theforms)
        {
            pedit = theforms;
        }

        private void pr_add2_Load(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            string strSql = string.Empty;
            strSql = "SELECT * FROM   material";
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(strSql);
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgv1.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {//只有点到按钮才触发
                    if (dgv1.CurrentRow.Cells["flag"].Value == null)
                    {
                        dgv1.CurrentRow.Cells["flag"].Value = true;
                        DataGridViewRow dr = new DataGridViewRow();
                        dr.CreateCells(dgv2);
                        dr.Cells[0].Value = dgv1.CurrentRow.Cells[1].Value;
                        dr.Cells[1].Value = dgv1.CurrentRow.Cells[2].Value;
                        dr.Cells[2].Value = dgv1.CurrentRow.Cells[3].Value;
                        dr.Cells[3].Value = dgv1.CurrentRow.Cells[4].Value;
                        dr.Cells[4].Value = dgv1.CurrentRow.Cells[5].Value;
                        dr.Cells[5].Value = dgv1.CurrentRow.Cells[6].Value;
                        //dgv2.Rows.Add(dr);                  
                        dgv2.Rows.Insert(0, dr);
                    }
                    else
                        MessageBox.Show("不能重复添加");
                }
            }
          
        }




        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void 确认添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (which == 1)
            {//全新添加
                for (j = 0; j < this.dgv2.Rows.Count; j++)
                {

                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(p1.dgv);
                    dr.Cells[0].Value = dgv2.Rows[j].Cells[0].Value;
                    dr.Cells[1].Value = dgv2.Rows[j].Cells[1].Value;
                    dr.Cells[2].Value = dgv2.Rows[j].Cells[2].Value;
                    dr.Cells[3].Value = dgv2.Rows[j].Cells[3].Value;
                    dr.Cells[4].Value = dgv2.Rows[j].Cells[4].Value;
                    dr.Cells[5].Value = dgv2.Rows[j].Cells[5].Value;
                    //dgv2.Rows.Add(dr);                  
                    p1.dgv.Rows.Insert(0, dr);
                }

                if (j != this.dgv2.Rows.Count)
                    MessageBox.Show("添加失败");
            }
            else
                if (which == 2)
                {//相似添加
                    for (j = 0; j < this.dgv2.Rows.Count; j++)
                    {

                        DataGridViewRow dr = new DataGridViewRow();
                        dr.CreateCells(pedit.dgv1);
                        dr.Cells[0].Value = dgv2.Rows[j].Cells[0].Value;
                        dr.Cells[1].Value = dgv2.Rows[j].Cells[1].Value;
                        dr.Cells[2].Value = dgv2.Rows[j].Cells[2].Value;
                        dr.Cells[3].Value = dgv2.Rows[j].Cells[3].Value;
                        dr.Cells[4].Value = dgv2.Rows[j].Cells[4].Value;
                        dr.Cells[5].Value = dgv2.Rows[j].Cells[5].Value;
                        pedit.dgv1.Rows.Insert(0, dr);
                    }
                }
                else
                    if (which == 3)
                    {
                        //编辑
                        sql = string.Empty;

                        //直接添加到pr_ma关系表
                        for (i = 0; i < dgv2.Rows.Count; i++)
                        {
                            sql = "insert into pr_ma([pr_num],[ma_num]) values('" + num.ToString() + "','";
                            sql += dgv2.Rows[i].Cells[0].Value.ToString() + "')";
                            if (1 != DbHelperSQL.ExecuteSql(sql))
                            {
                                MessageBox.Show("编辑失败");
                                return;
                            }
                            DataGridViewRow dr = new DataGridViewRow();
                            dr.CreateCells(pedit.dgv1);
                            dr.Cells[0].Value = dgv2.Rows[i].Cells[0].Value;
                            dr.Cells[1].Value = dgv2.Rows[i].Cells[1].Value;
                            dr.Cells[2].Value = dgv2.Rows[i].Cells[2].Value;
                            dr.Cells[3].Value = dgv2.Rows[i].Cells[3].Value;
                            dr.Cells[4].Value = dgv2.Rows[i].Cells[4].Value;
                            dr.Cells[5].Value = dgv2.Rows[i].Cells[5].Value;
                            pedit.dgv1.Rows.Insert(0, dr);

                        }
                        if (i != dgv2.Rows.Count)
                        {
                            MessageBox.Show("编辑失败");
                            this.Close();
                        }
                    }



            this.Close();
         }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IDSelected == string.Empty)
            {
                MessageBox.Show("选择删除行");
                return;
            }
            dgv2.Rows.RemoveAt(dgv2.CurrentRow.Index);
            for (int k = 0; k < dgv1.Rows.Count; k++)
            {
                if (dgv1.Rows[k].Cells["NO"].Value.ToString() == IDSelected)
                {
                    dgv1.Rows[k].Cells["flag"].Value = null;
                    this.dgv1.Rows[k].DefaultCellStyle.BackColor = Color.White;
                    break;
                }
            }
            IDSelected = string.Empty;
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv2.Rows.Count > 0)
                IDSelected = dgv2.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (this.dgv1.Rows[e.RowIndex].Cells["flag"].Value != null)
            {
                this.dgv1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            else
                this.dgv1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

  


        }
    }

