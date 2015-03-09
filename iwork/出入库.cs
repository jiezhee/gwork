using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using digits;
namespace iwork
{
    public partial class 出入库 : Form
    {
        public 出入库()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text != string.Empty)
            {
                if (numcheck.IsPositiveInteger(t1.Text) == true)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("只能输入正整数");
                    return;
                }
            }
            else
                MessageBox.Show("请输入数量");
        }
    }
}
