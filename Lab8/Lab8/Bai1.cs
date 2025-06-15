using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal static class Bai1
    {
        //private static List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static Random random = new Random();
        private static int numberRandom;
        public static void _Bai1()
        {
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);

            thread1.Start();
            thread2.Start();
            thread1.Join();
        }

        private static void Thread1()
        {
            for (int i = 0; i < 100; i++)
            {
                numberRandom = random.Next(1, 11);
                Console.WriteLine($"Thread 1: {numberRandom}");
                Thread.Sleep(2000);
            }
        }

        private static void Thread2()
        {
            for (int i = 0; i < 100; i++)
            {
                double binhPhuong = Math.Pow(numberRandom, 2);
                Console.WriteLine($"Thread 2: {binhPhuong}");
                Thread.Sleep(1000);
            }
        }
    }
}
