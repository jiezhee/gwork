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
    public partial class 用户管理 : Form
    {
        public 用户管理()
        {
            InitializeComponent();
        }
        private string sql=string.Empty;

        private int k = 0;//psn[k]
        private int i = 0;
        private bool changed = false;
        private bool flag = false;//true为已点击保存，退出不需提示保存

        private string str1 = string.Empty;
        private string IDSelected = string.Empty;
        DataSet ds = new DataSet();
        private struct rec_editpsn
        {
            public int x;
            public int y;
        }//变化表

        rec_editpsn[] psn = new rec_editpsn[100];
        private void 用户管理_Load(object sender, EventArgs e)
        {
            search();
        }


       public void search()
       {
          sql="select * from 用户管理 order by 编号 desc";

           ds=DbHelperSQL.Query(sql);
           dgv1.AutoGenerateColumns = false;
           dgv1.DataSource = ds.Tables[0];
           dgv1.ClearSelection(); //取消选中
       }

       private void 保存修改ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (changed == true)
           {
               string colname = string.Empty;
               string rowname = string.Empty;

               for (i = 0; i < k; i++)
               {

                   colname = dgv1.Columns[psn[i].y].Name;//列名
                   rowname = dgv1.Rows[psn[i].x].Cells["编号"].Value.ToString();//行名-编号
                   sql = "update 用户管理 set " + colname + "='";

                   sql += dgv1.Rows[psn[i].x].Cells[psn[i].y].Value.ToString() + "'";
                   sql += " where 编号='" + rowname + "'";
                   DbHelperSQL.ExecuteSql(sql);
               }
               MessageBox.Show("已保存");
               changed = false;
               k = 0;
               flag = true;

           }
           else
               MessageBox.Show("记录无变化"); 
       }

       private void dgv1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
       {
           if (dgv1.CurrentCell.Value != null)
               str1 = dgv1.CurrentCell.Value.ToString();
       }

       private void dgv1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
       {
           if (dgv1.CurrentCell.Value != null)
           {
               if (str1 != dgv1.CurrentCell.Value.ToString())
               {//有变化，记录到变化表psn[]
                   if (changed == false)
                   {
                       changed = true;
                   }
                   psn[k].x = dgv1.CurrentCell.RowIndex;
                   psn[k].y = dgv1.CurrentCell.ColumnIndex;
                   k++;
               }
           }
           if (flag == true)
               flag = false;
       }

       private void 用户管理_FormClosing(object sender, FormClosingEventArgs e)
       {
           if (flag == false)
           {
               if (changed == true)
               {
                   DialogResult result = MessageBox.Show("记录发生变化，是否保存？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if (result == DialogResult.Yes)
                   {
                       string colname = string.Empty;
                       string rowname = string.Empty;
                       for (i = 0; i < k; i++)
                       {
                           colname = dgv1.Columns[psn[i].y].Name;//列名
                           rowname = dgv1.Rows[psn[i].x].Cells["编号"].Value.ToString();//行名-编号
                           sql = "update 用户管理 set " + colname + "='";
                           sql += dgv1.Rows[psn[i].x].Cells[psn[i].y].Value.ToString() + "'";
                           sql += " where 编号='" + rowname + "'";
                           DbHelperSQL.ExecuteSql(sql);
                       }
                       MessageBox.Show("已保存");
                   }
                   else
                   {
                       MessageBox.Show("未保存");
                       return;
                   }
               }
           }
       }

       private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           search();
       }

       private void 增添用户ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           sql = "insert into 用户管理(用户名,密码,基础物料,成品,销售管理_部分权限,销售管理＿所有权限,采购管理,仓库管理_物料,仓库管理_成品,生产管理,用户管理权限) values(null,null,null,null,null,null,null,null,null,null,null)";
           DbHelperSQL.ExecuteSql(sql);
           search();
       }

       private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (IDSelected == string.Empty)
           {
               MessageBox.Show("选择删除行");
               return;
           }
           DialogResult result = MessageBox.Show("确定删除吗？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (result == DialogResult.Yes)
           {
               sql = "delete from [用户管理]  ";
               sql += " WHERE [编号]='" + IDSelected + "'";
               DBUtility.DbHelperSQL.ExecuteSql(sql);
               dgv1.Rows.RemoveAt(dgv1.CurrentCell.RowIndex);
               search();
           }
           IDSelected = string.Empty;
       }

       private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           if (dgv1.Rows.Count > 0)
           {//dgv不空
               IDSelected = dgv1.CurrentRow.Cells["编号"].Value.ToString();
           }
       }

       private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           this.Close();
       }
    }
}
