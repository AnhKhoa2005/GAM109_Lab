using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 1
            Console.WriteLine("Bài 1-----");
            Bai1 bai1 = new Bai1();

            bai1.bai1a(); // 1a
            bai1.bai1b(); // 1b
            bai1.bai1c(); // 1c

            //Bài 2
            Console.WriteLine("\nBài 2-----");
            Bai2 bai2 = new Bai2();

            bai2.bai2a(); // 2a
            bai2.bai2b(); // 2b

            //Bài 3
            Console.WriteLine("\nBài 3-----");
            Bai3 bai3 = new Bai3();

            bai3.bai3();
        }
    }
}
