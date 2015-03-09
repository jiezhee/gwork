using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace digits
{
    class numcheck
    {
        /// <summary>
        /// 判断一个串是不是 一串数字
        /// </summary>
        public static bool isnum(string s)
            {
                string pattern = "^[0-9]*$";
                Regex rx = new Regex(pattern);
                return rx.IsMatch(s);
            }

         /// <summary>
         /// 判断一个串是不是“正整数的字面值”——正确
         /// </summary>
         public static Boolean IsPositiveInteger(String str)
         {
             //(?<= |^)\+?(?!0\d+\b)\d+\b(?!\.)
             String pattern = @"^(?<= |^)\+?(?!0+\b)\d+\b(?!\.)$";//
             return System.Text.RegularExpressions.Regex.IsMatch(str, pattern);
         }

         /// <summary>
         /// 判断一个串是不是“小数的字面值”——正确
         /// </summary>
         public static bool IsFloat(string str)
         {
             String pattern = @"^[+-]?(?!0\d)\d+\.\d+\b(?![.])$";
             return System.Text.RegularExpressions.Regex.IsMatch(str, pattern);
         }
    }
}
