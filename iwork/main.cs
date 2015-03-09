using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBUtility;
using appconfig_seting;
namespace iwork
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }



        public string username = "cc";

        public class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        public class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.YellowGreen; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.YellowGreen; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.YellowGreen; }
            }

            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.YellowGreen; }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.YellowGreen; }
            }
        }


    

        private void 物料清单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHelperSQL.execscalar("select 基础物料 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                material m = new material();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
        }

        private void 基础资料录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DbHelperSQL.execscalar("select 成品 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                production b = new production();
                b.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
          
        }

        private void 销售订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DbHelperSQL.execscalar("select 销售管理_所有权限 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                sales s = new sales();
                s.ShowDialog();
            }
            else
            {
                if (DbHelperSQL.execscalar("select 销售管理_部分权限 from 用户管理 where 用户名='" + username + "'") == "1")
                {
                    sales s = new sales();
                    s.dgv1.Columns["销售单价"].Visible = false;
                    s.dgv1.Columns["币别"].Visible = false;
                    s.dgv1.Columns["销售金额"].Visible = false;
                    s.dgv1.Columns["收款金额"].Visible = false;
                    s.dgv1.Columns["收款时间"].Visible = false;
                    s.dgv1.Columns["备注"].Visible = false;
                    s.dgv1.Columns["核销"].Visible = false;
                    s.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("没有访问权限");
                }
            }
         
           
        }

        private void 生成采购单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DbHelperSQL.execscalar("select 采购管理 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                purchaselist_create plc = new purchaselist_create();
                plc.dgv1.Columns["生产状态"].Visible = false;
                plc.Width = 560;
                plc.sql_start = "SELECT 订单编号,商品型号,商品名称,商品描述,成品num,加入序号 FROM sales where 生产状态='等待采购' order by 加入序号 desc";
                plc.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
           
          
        }

        private void 采购单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (DbHelperSQL.execscalar("select 采购管理 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                采购日志 cggl = new 采购日志();
                cggl.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
            
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
           
        }

        private void 库存日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {

          
           
        }

        private void 今日总结ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHelperSQL.execscalar("select 生产管理 from 用户管理 where 用户名='" + username + "'") == "1" || DbHelperSQL.execscalar("select 仓库管理_成品 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                今日生产总结 rj = new 今日生产总结();
                rj.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
            
        }

        private void 生产日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHelperSQL.execscalar("select 生产管理 from 用户管理 where 用户名='" + username + "'") == "1" || DbHelperSQL.execscalar("select 仓库管理_成品 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                生产日志 scrz = new 生产日志();
                scrz.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
           
        }

        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
           
        }

       

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出吗？", "是否退出？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
            else
                return;

          
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
                用户管理 yh = new 用户管理();
                yh.ShowDialog();
    
           
        }

        private void 更改服务器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setconfig sc = new setconfig();
            sc.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            关于本软件 gy = new 关于本软件();
            gy.ShowDialog();
        }

        private void 更换封面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
       /*     OpenFileDialog f = new OpenFileDialog();
          //  f.InitialDirectory = "D:\\";
            f.Filter = "所有文件|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                string fname = f.FileName; 
                string path = System.IO.Path.GetDirectoryName(fname);
                
                pictureBox1.Image = Image.FromFile(fname);
                
            }
         */
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

     

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码 xgmm = new 修改密码();
            xgmm.user = username;
            xgmm.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (DbHelperSQL.execscalar("select 用户管理权限 from 用户管理 where 用户名='" + username + "'") != "1")
            {
                this.权限管理ToolStripMenuItem.Visible = false;
            }
            this.Text += "——当前用户：" + username;
            //string picpath = System.Configuration.ConfigurationManager.AppSettings["path"].ToString();
            // pictureBox1.ImageLocation = picpath;
            更换封面ToolStripMenuItem.Visible = false;
        }

        private void 供应商信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHelperSQL.execscalar("select 采购管理 from 用户管理 where 用户名='" + username + "'") == "1")
            {

                供应商信息 gys = new 供应商信息();
                gys.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
        }

        private void 采购状态审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 物料库存日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHelperSQL.execscalar("select 仓库管理_物料 from 用户管理 where 用户名='" + username + "'") == "1" || DbHelperSQL.execscalar("select 仓库管理_成品 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                物料库存日志 ccrz = new 物料库存日志();
                ccrz.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
        }

        private void 物料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHelperSQL.execscalar("select 仓库管理_物料 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                仓库管理_物料 cw = new 仓库管理_物料();
                cw.ShowDialog();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
        }

        private void 成品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DbHelperSQL.execscalar("select 仓库管理_成品 from 用户管理 where 用户名='" + username + "'") == "1")
            {
                仓库管理_成品 ck_cp = new 仓库管理_成品();
                ck_cp.Show();
            }
            else
            {
                MessageBox.Show("没有访问权限");
            }
        }

        private void 物料ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            订单物料状态 cgsh = new 订单物料状态();
            cgsh.ShowDialog();
        }

        private void 成品ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            订单成品库存 ddcpck = new 订单成品库存();
            ddcpck.ShowDialog();
        }

        private void 成品库存日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            成品库存日志 cpcurz = new 成品库存日志();
            cpcurz.ShowDialog();
        }

       
    }
}
