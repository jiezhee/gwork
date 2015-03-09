using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iwork
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new  main());
           // Application.Run(new test());
           // Application.Run(new purchaselist_create());
            //cmain c1 = new cmain();
          // Application.Run(c1);
            
        }
    }
}
