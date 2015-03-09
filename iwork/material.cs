using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBUtility;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using DataGridViewAutoFilter;

namespace iwork
{
    public partial class material : Form
    {
        public material()
        {
            InitializeComponent();

        }

        public string sql = string.Empty;
        public string temp = string.Empty;
        private string IDSelected = string.Empty;

        public void Search()
        {
            string strnum = string.Empty;
            string strname = string.Empty;
            string strfullname = string.Empty;
            //strOid = txtOid.Text.Trim();
            string strSql = string.Empty;

            //删除数据库中重复的记录
            sql = "delete from material where NO not in(select min(NO) from material group by 料号)";
            DbHelperSQL.ExecuteSql(sql);             

            strSql = @"SELECT   *
                         FROM   material ";
            DataSet dsData = new DataSet();
            dsData = DbHelperSQL.Query(strSql);
            dgv1.AutoGenerateColumns = false;
            if (dgv1.DataSource != null)
                dgv1.DataSource = null;
            BindingSource s = new BindingSource();
            s.DataSource = dsData.Tables[0];
            this.dgv1.DataSource = s;
            dgv1.ClearSelection(); //取消选中
        }



        private void dgv1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
                IDSelected = dgv1.Rows[dgv1.CurrentRow.Index].Cells["NO"].Value.ToString();

        }





        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Search();

        }

        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ma_sort ms = new ma_sort();
            ms.GetForm(this);
            ms.ShowDialog();
        }

        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IDSelected == string.Empty)
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }
            ma_edit me = new ma_edit();
            me.editcode = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[0].Value.ToString();
            me.t4.Text = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[0].Value.ToString();

            if (this.dgv1.Rows[dgv1.CurrentRow.Index].Cells["备注"].Value != null)
                me.t3.Text = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells["备注"].Value.ToString();
            if (this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[1].Value != null)
                me.t1.Text = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[1].Value.ToString();

            if (this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[2].Value != null)
                me.t2.Text = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[2].Value.ToString();

            if (this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[3].Value != null)
                me.c1.Text = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[3].Value.ToString();

            if (this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[4].Value != null)
                me.c2.Text = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[4].Value.ToString();

            if (this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[5].Value != null)
                me.gys = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[5].Value.ToString();

            if (this.dgv1.Rows[dgv1.CurrentRow.Index].Cells["类别"].Value != null)
                me.c4.Text = this.dgv1.Rows[dgv1.CurrentRow.Index].Cells["类别"].Value.ToString();

            me.ShowDialog();
            if (me.DialogResult == DialogResult.OK)
            {
                this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[1].Value = me.t1.Text;
                this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[2].Value = me.t2.Text;
                this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[3].Value = me.c1.Text;
                this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[4].Value = me.c2.Text;
                this.dgv1.Rows[dgv1.CurrentRow.Index].Cells["备注"].Value = me.t3.Text;
                this.dgv1.Rows[dgv1.CurrentRow.Index].Cells[5].Value = me.c3.Text;
                this.dgv1.Rows[dgv1.CurrentRow.Index].Cells["类别"].Value = me.c4.Text;
                me.Close();

            }
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
                sql = "delete from [material]  ";
                sql += " WHERE [NO]='" + IDSelected + "'";
                DBUtility.DbHelperSQL.ExecuteSql(sql);
                dgv1.Rows.RemoveAt(dgv1.CurrentCell.RowIndex);
            }
            else { return; }


        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ma_add ad = new ma_add();
            string current_no = (DbHelperSQL.maxnum("NO", "material") + 1).ToString();
            ad.t4.Text = current_no;
            ad.ShowDialog();
           Search();
        }

 

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void material_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void 导出为ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

                        Excel.Application xlApp = new Excel.Application();
                        Excel.Workbook xlWorkBook;
                        Excel.Worksheet xlWorkSheet;

                        object misValue = System.Reflection.Missing.Value;
                        xlApp = new Excel.ApplicationClass();
                        xlWorkBook = xlApp.Workbooks.Add(misValue);

                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                        int i = 0;
                        int j = 0;

                        //save header
                        for (i = 0; i <= dgv1.ColumnCount - 1; i++)
                        {
                            xlWorkSheet.Cells[0 + 1, i + 1] = dgv1.Columns[i].HeaderText;
                        }

                        //save cells
                        for (i = 0; i <= dgv1.RowCount - 1; i++)
                        {
                            for (j = 0; j <= dgv1.ColumnCount - 1; j++)
                            {
                                DataGridViewCell cell = dgv1[j, i];
                                xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                            }
                        }

                        SaveFileDialog dlgSaveFile = new SaveFileDialog();
                        dlgSaveFile.Filter = "Excel文件（*.xls)|*.xls";
                        if (dlgSaveFile.ShowDialog() != DialogResult.OK) return;
                        string sFileName = dlgSaveFile.FileName;
                        xlWorkBook.SaveAs(sFileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                        xlWorkBook.Close(true, misValue, misValue);
                        xlApp.Quit();

                        releaseObject(xlWorkSheet);
                        releaseObject(xlWorkBook);
                        releaseObject(xlApp);
                
        }
    }
}
