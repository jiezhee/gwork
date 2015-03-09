using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Configuration;

namespace appconfig_seting
{
    class appconfig_set
    {
        public static void SetKeyValue(string AppKey, string AppValue,string Node)
        {
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load(System.Windows.Forms.Application.ExecutablePath + ".config");

            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;

            xNode = xDoc.SelectSingleNode(Node);

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
    }
}
