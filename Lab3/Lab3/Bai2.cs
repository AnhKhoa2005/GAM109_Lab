using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal static class Bai2
    {
        static string userName = "TranDuyAnhKhoa2005";
        static string passWord = "AnhKhoa123";
        static string time = "29/5/2025";
        static string content;
        public static void _Bai2()
        {
            SaveAccount();
            ShowAccount();
        }

        public static void SaveAccount()
        {
            using (StringWriter sw = new StringWriter())
            {
                sw.WriteLine("UserName: " + userName);
                sw.WriteLine("PassWord: " + passWord);
                sw.WriteLine("Time Save: " + time);
                content = sw.ToString();
            }
        }

        public static void ShowAccount()
        {
            using (StringReader sr = new StringReader(content))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
