using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using DBUtility;
using System.Data.SqlClient;


namespace iwork
{
    public partial class 采购信息预览 : Form
    {
        public 采购信息预览()
        {
            InitializeComponent();
        }

        private void dgvToExcel(DataGridView dgv,string gys)
        {
            string TEL=string.Empty;
            string FAX = string.Empty;
            string lxr= string.Empty;
            string fkfs = string.Empty;
            string sfhs = string.Empty;

            if (null != DbHelperSQL.execscalar("select TEL from 供应商信息 where 供应商='" + gys + "'"))
                TEL = DbHelperSQL.execscalar("select TEL from 供应商信息 where 供应商='" + gys + "'");

             if(null!=DbHelperSQL.execscalar("select FAX from 供应商信息 where 供应商='" + gys + "'"))
                FAX=DbHelperSQL.execscalar("select FAX from 供应商信息 where 供应商='" + gys + "'");

          if(null!=DbHelperSQL.execscalar("select 联系人 from 供应商信息 where 供应商='" + gys + "'"))
                lxr = DbHelperSQL.execscalar("select 联系人 from 供应商信息 where 供应商='" + gys + "'");

          if (null != DbHelperSQL.execscalar("select 付款方式 from 供应商信息 where 供应商='" + gys + "'"))
              fkfs = DbHelperSQL.execscalar("select 付款方式 from 供应商信息 where 供应商='" + gys + "'");

          if (null != DbHelperSQL.execscalar("select 是否含税 from 供应商信息 where 供应商='" + gys + "'"))
              sfhs = DbHelperSQL.execscalar("select 是否含税 from 供应商信息 where 供应商='" + gys + "'");

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            int rowcount = dgv.Rows.Count;
            int rowindex = 9 + rowcount + 1; ;//标记附属信息开始行号

            int lastday1 = DbHelperSQL.lastday("日期", "采购信息");
            int today1 = DateTime.Now.Day;

            Excel.Range range;

            //保存信息
            SaveFileDialog dlgSaveFile = new SaveFileDialog();
            dlgSaveFile.Filter = "Excel文件（*.xls)|*.xls";
            if (dlgSaveFile.ShowDialog() != DialogResult.OK) return;



            //设置excel格式         
            //标题i=1,2
            range = (Excel.Range)xlWorkSheet.get_Range("A1:K1");
            range.Merge(0);
            xlWorkSheet.Cells[1, 1] = "东莞格锐莱光电有限公司";
            range.Font.Size = 20;
            range.Font.Name = "微软雅黑";
            range.RowHeight = 30;
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter; 
         //   range.Font.FontStyle = "加粗";
            range = (Excel.Range)xlWorkSheet.get_Range("A2:K2");
            range.Merge(0);
            xlWorkSheet.Cells[2, 1] = "物料采购单";
            range.Font.Size = 15;
            range.Font.Name = "微软雅黑";
            range.RowHeight = 24;
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter; 
         //   range.Font.FontStyle = "加粗";

            //i=3
            range = (Excel.Range)xlWorkSheet.get_Range("A3:K3");//选中单元格
            range.Merge(0);
            xlWorkSheet.Cells[3, 1] = "日期："+DateTime.Now.ToString("yyyy/MM/dd");

    
            //i=4
            range = (Excel.Range)xlWorkSheet.get_Range("A4:C4");
            range.Merge(0);
            xlWorkSheet.Cells[4, 1] = "FM：毛生13266548597";

            range = (Excel.Range)xlWorkSheet.get_Range("I4:K4");//选中单元格
            range.Merge(0);
            xlWorkSheet.Cells[4, 9] = "表单编号：GRL-4-4-40a";
            range.HorizontalAlignment = 4;
 


            //i=5
            range = (Excel.Range)xlWorkSheet.get_Range("A5:C5");//选中单元格
            range.Merge(0);
            xlWorkSheet.Cells[5, 1] = "TO：" + gys;

            range = (Excel.Range)xlWorkSheet.get_Range("I5:K5");//选中单元格
            range.Merge(0);
            if (today1 == lastday1)
            {
                int cglastnum = DbHelperSQL.lastday_purnum();
                xlWorkSheet.Cells[5, 9] = "采购单号:GL" + DateTime.Now.ToString("yyyyMMdd") + "-" + (cglastnum + 1).ToString();
            }
            else
            {//不是同一天
                xlWorkSheet.Cells[5, 9] += "采购单号:GL" + DateTime.Now.ToString("yyyyMMdd") + "-" + "1";
            }
            range.HorizontalAlignment = 4;//靠右

            range = (Excel.Range)xlWorkSheet.get_Range("D4:H5");//选中单元格
            range.Merge(true);//分成多行，每行合并

            //i=6,7
            range = (Excel.Range)xlWorkSheet.get_Range("A6:A7");//选中单元格
            range.Merge(true);
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter; 
            xlWorkSheet.Cells[6, 1] = "供应商";
            xlWorkSheet.Cells[7, 1] = gys;

            range = (Excel.Range)xlWorkSheet.get_Range("B6:B7");//选中单元格
            range.Merge(true);
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet.Cells[6, 2] = "电话";
            xlWorkSheet.Cells[7, 2] = TEL;

            range = (Excel.Range)xlWorkSheet.get_Range("C6:C7");//选中单元格
            range.Merge(true);
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet.Cells[6, 3] = "传真";
            xlWorkSheet.Cells[7, 3] = FAX;

            range = (Excel.Range)xlWorkSheet.get_Range("D6:D7");//选中单元格
            range.Merge(true);
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet.Cells[6,4] = "联系人";
            xlWorkSheet.Cells[7,4] = lxr;

            range = (Excel.Range)xlWorkSheet.get_Range("E6:E7");//选中单元格
            range.Merge(true);
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet.Cells[6, 5] = "付款方式";
            xlWorkSheet.Cells[7, 5] = fkfs;

            range = (Excel.Range)xlWorkSheet.get_Range("F6:F7");//选中单元格
            range.Merge(true);
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet.Cells[6, 6] = "交货期";
            xlWorkSheet.Cells[7, 6] = "";

            range = (Excel.Range)xlWorkSheet.get_Range("G6:G7");//选中单元格
            range.Merge(true);
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet.Cells[6, 7] = "是否含税";
            xlWorkSheet.Cells[7, 7] = sfhs;

            range = (Excel.Range)xlWorkSheet.get_Range("H6:K7");//选中单元格
            range.Merge(true);
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            xlWorkSheet.Cells[6, 8] = "备注";
            xlWorkSheet.Cells[7, 8] = "";

            //i=8
            range = (Excel.Range)xlWorkSheet.get_Range("A8:K8");//选中单元格
            range.Merge(true);

            //边框线
            range = (Excel.Range)xlWorkSheet.get_Range("A6:K7");
            range.Borders.LineStyle = 1;
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;//居中
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range.EntireColumn.AutoFit();//列宽自动  

            range = (Excel.Range)xlWorkSheet.get_Range("A9:K"+(12+rowcount).ToString());
            range.Borders.LineStyle = 1;
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;//居中
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
            range.EntireColumn.AutoFit();//列宽自动  

            //附属信息
            range = (Excel.Range)xlWorkSheet.get_Range("A" + rowindex.ToString() + ":K" + rowindex.ToString());
            range.Merge(0);
            range.HorizontalAlignment = 2;
            xlWorkSheet.Cells[rowindex, 1] = "收货地址:东莞市塘厦镇林村卡妮尔工业园4栋4楼 TEL:0769-87888978";
            rowindex++;

            range = (Excel.Range)xlWorkSheet.get_Range("A" + rowindex.ToString() + ":K" + rowindex.ToString());
            range.Merge();
            range.HorizontalAlignment = 2;
            xlWorkSheet.Cells[rowindex, 1] = "供应商回签：          工程：          核准：          批准：          采购：毛传红";
            rowindex++;

            //最后一行
            range = (Excel.Range)xlWorkSheet.get_Range("A" + rowindex.ToString() + ":K" + rowindex.ToString());
            range.Merge();
            xlWorkSheet.Cells[rowindex, 1] = "日期:" + DateTime.Now.ToString("yyyy/MM/dd");
            range.HorizontalAlignment = 4;//居右
           
            //现在rowindex表示总行数

            //save cells
            for (j = 1; j <= dgv.ColumnCount - 1; j++)
            {
                xlWorkSheet.Cells[9, j] = dgv.Columns[j].HeaderText;
            } 
            for (i = 0; i <= dgv.RowCount - 1; i++)
            {
                for (j = 1; j <= dgv.ColumnCount - 1; j++)
                {

                    DataGridViewCell cell = dgv[j, i];
              /*      if (j == 0)
                    {
                        range = (Excel.Range)xlWorkSheet.get_Range("A" + (i + 9).ToString());
                        range.NumberFormatLocal = "@";
                        xlWorkSheet.Cells[i + 7, j + 1] = cell.Value;
                    }
                    else
               * */
                        xlWorkSheet.Cells[i + 10, j] = cell.Value;


                }

            }

            //设置大小格式
            for (i = 3; i <= rowindex; i++)
            {
                range = (Excel.Range)xlWorkSheet.get_Range("A" + i.ToString() + ":K" + i.ToString());
                range.Font.Size = "14";
                range.EntireColumn.AutoFit();
            }

            string sFileName = dlgSaveFile.FileName;
            //  string currentPath = System.Environment.CurrentDirectory;
            //  string outputFilename = "output.xls";
            //  string fullFilename = Path.Combine(currentPath, outputFilename);
            //xlWorkBook.SaveAs(fullFilename, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.SaveAs(sFileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

           
/*
            DialogResult result = MessageBox.Show("导出成功,是否打开文件？", "是否打开", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(sFileName);
            }
  */
        }

        private void 生成采购单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             string gys1 = string.Empty;
             string gys2 = string.Empty;
            
            gys1=dgv1.Rows[0].Cells["供应商"].Value.ToString();
            for (int k = 0; k < dgv1.Rows.Count; k++)
            {
                gys2 = dgv1.Rows[k].Cells["供应商"].Value.ToString();
                if (gys2 == gys1)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dgv);
                    for (int s = 0; s < dgv1.Columns.Count; s++)
                    {
                        if(dgv1.Rows[k].Cells[s].Value!=null)
                           dr.Cells[s].Value = dgv1.Rows[k].Cells[s].Value.ToString();
                    }
                    dgv.Rows.Add(dr);
                    if (k == dgv1.Rows.Count - 1)
                    {
                        dgvToExcel(dgv, gys1);
                    }

                }
                else
                {
                    //生成采购单
                    dgvToExcel(dgv,gys1);
                    //清空dgv
                    while (dgv.RowCount > 0)
                    {
                        dgv.Rows.Remove(dgv.Rows[0]);
                    }

                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dgv);
                    for (int s = 0; s < dgv1.Columns.Count; s++)
                    {
                        if (dgv1.Rows[k].Cells[s].Value != null)
                        dr.Cells[s].Value = dgv1.Rows[k].Cells[s].Value.ToString();
                    }
                    dgv.Rows.Add(dr);

                    if (k == dgv1.Rows.Count - 1)
                    {
                        dgvToExcel(dgv, gys1);
                    }

                    gys1 = gys2;
                }
            }
            
            MessageBox.Show("导出成功");
            this.DialogResult = DialogResult.OK;
  
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

        private void 采购信息预览_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      



    }
}
