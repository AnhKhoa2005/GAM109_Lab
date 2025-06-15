using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal static class Bai2
    {
        private static Object lock1 = new Object();
        private static Object lock2 = new Object();
        public static void _Bai2()
        {
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);

            thread1.Start();
            thread2.Start();
            thread1.Join();
        }

        static void Thread1()
        {
            lock (lock1)
            {
                Console.WriteLine("Thread 1 locked lock1");

                Thread.Sleep(100);
                Console.WriteLine("Thread 1 is waiting for lock2");

                if (Monitor.TryEnter(lock2, 2000))
                {
                    try
                    {
                        Console.WriteLine("Thread 1 locked lock2");
                    }
                    finally
                    {
                        Monitor.Exit(lock2);
                    }
                }
                else
                {
                    Console.WriteLine("Thread 1 could not lock lock2 (timeout)");
                }
            }
        }

        static void Thread2()
        {
            lock (lock2)
            {
                Console.WriteLine("Thread 2 locked lock2");

                Thread.Sleep(100);
                Console.WriteLine("Thread 2 is waiting for lock1");

                if (Monitor.TryEnter(lock1, 2000))
                {
                    try
                    {
                        Console.WriteLine("Thread 2 locked lock1");
                    }
                    finally
                    {
                        Monitor.Exit(lock1);
                    }
                }
                else
                {
                    Console.WriteLine("Thread 2 could not lock lock1 (timeout)");
                }
            }
        }

    }
}
