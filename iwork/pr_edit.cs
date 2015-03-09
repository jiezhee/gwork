using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBUtility;
using digits;
namespace iwork
{
    public partial class pr_edit : Form
    {
        public pr_edit()
        {
            InitializeComponent();
        }
        public int which;//区别编辑和相似添加
        public int num = 0;//成品编码
        private int j = 0;
        private int i = 0;
        public int count = 0;
        public string IDSelected = string.Empty;
        public string sql = string.Empty;
        private void pr_addseem_Load(object sender, EventArgs e)
        {
           
            string sql = string.Empty;
            DataSet ds = new DataSet();
            sql = "select material.NO,material.料号,material.品名,material.型号规格,material.单位,material.供应商,pr_ma.用量,pr_ma.使用位置,pr_ma.BOM备注 from material,pr_ma where pr_num=" + num.ToString() + " and pr_ma.ma_num=material.NO order by material.NO";

            ds = DbHelperSQL.Query(sql);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ds.Tables[0];
            dgv.ClearSelection(); //取消选中  

            for (j =this.dgv.Rows.Count-1; j >=0; j--)
            {

                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dgv1);
                dr.Cells[0].Value = dgv.Rows[j].Cells[0].Value;
                dr.Cells[1].Value = dgv.Rows[j].Cells[1].Value;
                dr.Cells[2].Value = dgv.Rows[j].Cells[2].Value;
                dr.Cells[3].Value = dgv.Rows[j].Cells[3].Value;
                dr.Cells[4].Value = dgv.Rows[j].Cells[4].Value;
                dr.Cells[5].Value = dgv.Rows[j].Cells[5].Value;
                dr.Cells[6].Value = dgv.Rows[j].Cells[6].Value;
                dr.Cells[7].Value = dgv.Rows[j].Cells[7].Value;
                dr.Cells[8].Value = dgv.Rows[j].Cells[8].Value;
                //dgv2.Rows.Add(dr);                  
                dgv1.Rows.Insert(0, dr);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                pr_add2 pa22 = new pr_add2();
                pa22.GetForms(this);  
            if (which == 1)
            {//相似添加          
                pa22.which = 2;        
            }
            else
                if(which==2)
                {
                    //编辑
                    pa22.which = 3;
                    pa22.num = num;
                }

             pa22.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //删除
            if (IDSelected == null)
            {
                MessageBox.Show("选择删除行");
                return;
            }
            if (which == 1)
            {//相似添加时删除（不动数据库）
                dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
            }
            else
                if (which == 2)
                {//编辑（数据库同时改变）
                    sql = string.Empty;
                    sql += "delete from [pr_ma]  ";
                    sql += " WHERE [pr_num]='" + num.ToString() + "'";
                    sql += "and [ma_num]='" + dgv1.CurrentRow.Cells[0].Value.ToString() + "'";
                    DbHelperSQL.ExecuteSql(sql);
                    dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
                }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.Rows.Count > 0)
                IDSelected = dgv1.CurrentRow.Cells[0].Value.ToString();
        }

        private void 确认录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sql = string.Empty;
            if (which == 1)
            {
                //成品相似添加

                for (i = 0; i < dgv1.Rows.Count; i++)
                {
                    if (dgv1.Rows[i].Cells["用量"].Value != null)
                    {
                        if (numcheck.isnum(dgv1.Rows[i].Cells["用量"].Value.ToString()) == false)
                        {
                            MessageBox.Show("用量只能为整数！");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("用量为空无意义！");
                        return;
                    }
                }

                sql = "insert into production([code],[name],[描述])values('";
                sql += textBox1.Text + "','";
                sql += textBox2.Text + "','";
                sql += textBox3.Text + "')";
                //添加到成品表
                if (1 != DbHelperSQL.ExecuteSql(sql))
                {
                    MessageBox.Show("录入失败");
                    return;
                }

                count = DbHelperSQL.maxnum("num", "production");     //获取记录总数
                //添加到pr_ma关系表
                for (i = 0; i < dgv1.Rows.Count; i++)
                {
                    sql = "insert into pr_ma([pr_num],[ma_num]) values('" + count.ToString() + "','";
                    sql += dgv1.Rows[i].Cells[0].Value.ToString() + "')";
                    DbHelperSQL.ExecuteSql(sql);


                }
                //存储料号，品名，型号规格，单位，供应商，使用位置，用量,备注
                for (i = 0; i < dgv1.Rows.Count; i++)
                {
                    sql = "update pr_ma set ";
                    sql += "[用量]='" + dgv1.Rows[i].Cells["用量"].Value.ToString() + "'";

                    if (dgv1.Rows[i].Cells["使用位置"].Value != null)
                    {
                        sql += ",[使用位置]='" + dgv1.Rows[i].Cells["使用位置"].Value.ToString() + "'";

                    }
                    if (dgv1.Rows[i].Cells["物料料号"].Value != null)
                    {
                        sql += ",[料号]='" + dgv1.Rows[i].Cells["物料料号"].Value.ToString() + "'";

                    }
                    if (dgv1.Rows[i].Cells["品名"].Value != null)
                    {
                        sql += ",[品名]='" + dgv1.Rows[i].Cells["品名"].Value.ToString() + "'";

                    }
                    if (dgv1.Rows[i].Cells["型号规格"].Value != null)
                    {
                        sql += ",[型号规格]='" + dgv1.Rows[i].Cells["型号规格"].Value.ToString() + "'";

                    }
                    if (dgv1.Rows[i].Cells["单位"].Value != null)
                    {
                        sql += ",[单位]='" + dgv1.Rows[i].Cells["单位"].Value.ToString() + "'";

                    }
                    if (dgv1.Rows[i].Cells["供应商"].Value != null)
                    {
                        sql += ",[供应商]='" + dgv1.Rows[i].Cells["供应商"].Value.ToString() + "'";

                    }
                    if (dgv1.Rows[i].Cells["备注"].Value != null)
                    {

                        sql += ",[BOM备注]='" + dgv1.Rows[i].Cells["备注"].Value.ToString() + "'";

                    }

                    sql += "where pr_num='" + count.ToString() + "' and ma_num='" + dgv1.Rows[i].Cells[0].Value.ToString() + "'";

                    DbHelperSQL.ExecuteSql(sql);
     


                }
                MessageBox.Show("录入成功");
                this.Close();

              
            }
            else
                if (which == 2)
                {
                    //成品资料编辑
                    for (i = 0; i < dgv1.Rows.Count; i++)
                    {
                        if (dgv1.Rows[i].Cells["用量"].Value != null)
                        {
                            if (numcheck.isnum(dgv1.Rows[i].Cells["用量"].Value.ToString()) == false)
                            {
                                MessageBox.Show("用量只能为整数！");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("用量为空无意义！");
                            return;
                        }
                    }


                    sql += "UPDATE [production] SET ";
                    sql += "[code]='" + this.textBox1.Text + "',";
                    sql += "[name]='" + this.textBox2.Text + "',";
                    sql += "[描述]='" + this.textBox3.Text + "'";
                    sql += " WHERE [num]='" + num.ToString() + "'";
                    
                    //编辑成品表
                     DBUtility.DbHelperSQL.ExecuteSql(sql);
  
                    //存入pr_ma
                      for (i = 0; i < dgv1.Rows.Count; i++)
                      {    
                          sql = "update pr_ma set ";
                          sql += "[用量]='" + dgv1.Rows[i].Cells["用量"].Value.ToString() + "'";

                          if (dgv1.Rows[i].Cells["使用位置"].Value != null)
                          {
                              sql += ",[使用位置]='" + dgv1.Rows[i].Cells["使用位置"].Value.ToString() + "'";

                          }

                          if (dgv1.Rows[i].Cells["物料料号"].Value != null)
                          {
                              sql += ",[料号]='" + dgv1.Rows[i].Cells["物料料号"].Value.ToString() + "'";

                          }
                          if (dgv1.Rows[i].Cells["品名"].Value != null)
                          {
                              sql += ",[品名]='" + dgv1.Rows[i].Cells["品名"].Value.ToString() + "'";

                          }
                          if (dgv1.Rows[i].Cells["型号规格"].Value != null)
                          {
                              sql += ",[型号规格]='" + dgv1.Rows[i].Cells["型号规格"].Value.ToString() + "'";

                          }
                          if (dgv1.Rows[i].Cells["单位"].Value != null)
                          {
                              sql += ",[单位]='" + dgv1.Rows[i].Cells["单位"].Value.ToString() + "'";

                          }
                          if (dgv1.Rows[i].Cells["供应商"].Value != null)
                          {
                              sql += ",[供应商]='" + dgv1.Rows[i].Cells["供应商"].Value.ToString() + "'";

                          }

                          if (dgv1.Rows[i].Cells["备注"].Value != null)
                          {

                              sql += ",[BOM备注]='" + dgv1.Rows[i].Cells["备注"].Value.ToString() + "'";

                          }

                          sql += "where pr_num='" + num.ToString() + "' and ma_num='" + dgv1.Rows[i].Cells[0].Value.ToString() + "'";

                          DbHelperSQL.ExecuteSql(sql);
                       
                      }


                        MessageBox.Show("编辑成功");
                        this.DialogResult = DialogResult.OK;

                }


        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
