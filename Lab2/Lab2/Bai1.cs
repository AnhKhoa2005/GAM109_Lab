using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Bai1
    {
        dynamic x = 10;
        public void bai1a()
        {

            Console.WriteLine("\nx: " + x);
        }

        public void bai1b()
        {
            Console.WriteLine();
            GetDetail(10);
            GetDetail("Game");
            GetDetail(true);
            GetDetail(9.5);
        }

        public void GetDetail(dynamic value)
        {
            Console.WriteLine("Value: " + value);
        }

        public void bai1c()
        {
            Console.WriteLine();
            UserDataLab2 data = new UserDataLab2("2025", "Anh Khoa", 100);
            data.GetInfo();
        }
    }
}
