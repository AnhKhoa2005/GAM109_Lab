using System;
using System.Threading;

namespace Lab8
{
    internal static class Bai1
    {
        private static Random random = new Random();
        private static volatile int numberRandom = 0;
        private static volatile bool hasNewNumber = false;

        public static void _Bai1()
        {
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        private static void Thread1()
        {
            for (int i = 0; i < 100; i++)
            {
                numberRandom = random.Next(1, 11);
                hasNewNumber = true;
                Console.WriteLine($"Thread 1: {numberRandom}");
                Thread.Sleep(2000);
            }
        }

        private static void Thread2()
        {
            for (int i = 0; i < 100; i++)
            {
                if (hasNewNumber)
                {
                    int current = numberRandom;
                    double binhPhuong = Math.Pow(current, 2);
                    Console.WriteLine($"Thread 2: {current}^2 = {binhPhuong}");
                    hasNewNumber = false;
                }
                else
                {
                    Console.WriteLine("Thread 2: Chua co so moi.");
                }

                Thread.Sleep(1000);
            }
        }
    }
}
