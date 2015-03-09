using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
namespace iwork
{
    public partial class setconfig : Form
    {
        public setconfig()
        {
            InitializeComponent();
        }


        public static void SetKeyValue(string AppKey, string AppValue)
        {
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load(System.Windows.Forms.Application.ExecutablePath + ".config");

            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;

            xNode = xDoc.SelectSingleNode("//appSettings");

            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");

            if (xElem1 != null)
            {
                xElem1.SetAttribute("value", AppValue);
            
            }
            else
            {
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", AppKey);
                xElem2.SetAttribute("value", AppValue);
                xNode.AppendChild(xElem2);
            }
            xDoc.Save(System.Windows.Forms.Application.ExecutablePath + ".config");
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SetKeyValue("ConnectionString", "server="+t1.Text+";user=sa;pwd=111111;database=greenlight;");
            MessageBox.Show("修改成功");
            this.Close();
        }
    }
}
