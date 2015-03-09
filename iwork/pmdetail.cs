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
    public partial class pmdetail : Form
    {
        public pmdetail()
        {
            InitializeComponent();
        }

        private void pmdetail_Load(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            int i = 0;
            int j = 0;
            int currentrow = 0;
            string lb1 = string.Empty;
            string lb2 = string.Empty;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
           

            range = (Excel.Range)xlWorkSheet.get_Range("A1:J1");
            range.Merge(0);
            xlWorkSheet.Cells[1, 1] = "东莞格锐莱光电有限公司";
            range.Font.Size = 15;
            range.Font.Name = "微软雅黑";
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;

            range = (Excel.Range)xlWorkSheet.get_Range("A2:J2");
            range.Merge(0);
            xlWorkSheet.Cells[2, 1] = "BOM表";
            range.Font.Size = 13;
            range.Font.Name = "微软雅黑";
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;

            range = (Excel.Range)xlWorkSheet.get_Range("A3:J3");
            range.Merge(0);

            //save header
            for (i = 0; i <= dgv1.ColumnCount - 1; i++)
            {
                xlWorkSheet.Cells[4, i + 1] = dgv1.Columns[i].HeaderText;
            }

            //save cells
            //初始化第一种材料
            lb1 = dgv1.Rows[0].Cells["类别"].Value.ToString();
            range = (Excel.Range)xlWorkSheet.get_Range("A5:J5");
            range.Merge(0);
            xlWorkSheet.Cells[5, 1] = lb1;
            range.Font.Size = 13;
            range.Font.Name = "微软雅黑";
            currentrow = 6;

            for (i = 0; i <= dgv1.RowCount - 1; i++)
            {
                lb2 = dgv1.Rows[i].Cells["类别"].Value.ToString();
               
                if (lb2 == lb1)
                {
                    for (j = 0; j <= dgv1.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgv1[j, i];
                        xlWorkSheet.Cells[currentrow, j + 1] = cell.Value;      
                    } 
                    currentrow++;
                }
                else
                {
                    //新类别
                    range = (Excel.Range)xlWorkSheet.get_Range("A"+currentrow.ToString()+":J"+currentrow.ToString());
                    range.Merge(0);
                    xlWorkSheet.Cells[currentrow, 1] = lb2;
                    range.Font.Size = 13;
                    range.Font.Name = "微软雅黑";
                    lb1 = lb2;
                    currentrow++;
                    i--;
                }
            }

            //边框线和格式
            range = (Excel.Range)xlWorkSheet.get_Range("A4:J"+(currentrow-1).ToString());
            range.Borders.LineStyle = 1;
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;//居中
            range.HorizontalAlignment = Excel.XlVAlign.xlVAlignJustify;
            range.EntireColumn.AutoFit();//列宽自动  



            SaveFileDialog dlgSaveFile = new SaveFileDialog();
            dlgSaveFile.Filter = "Excel文件（*.xls)|*.xls";
            if (dlgSaveFile.ShowDialog() != DialogResult.OK) return;
            string sFileName = dlgSaveFile.FileName;
            xlWorkBook.SaveAs(sFileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            DialogResult result = MessageBox.Show("导出成功,是否打开文件？", "是否打开", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(sFileName);
            }
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
    }
}
