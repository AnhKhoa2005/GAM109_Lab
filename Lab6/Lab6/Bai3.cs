using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal static class Bai3
    {
        static List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
        static List<int> list2 = new List<int>() { 5, 6, 7, 8, 1 };

        public static void _Bai3()
        {
            Console.WriteLine("\n----------Bai 3----------");
            Console.WriteLine("\n----------Cau a----------");
            Cau_a();
            Console.WriteLine("\n----------Cau b----------");
            Cau_b();
            Console.WriteLine("\n----------Cau c----------");
            Cau_c();
            Console.WriteLine("\n----------Cau d----------");
            Cau_d();
        }

        public static void Cau_a()
        {
            Console.Write("Cac gia tri giam dan:");
            list1
                .Union(list2)
                .OrderByDescending(x => x)
                .ToList()
                .ForEach(x => Console.Write(" " + x));
        }
        public static void Cau_b()
        {
            Console.Write("Phan giao cua tap hop:");
            list1
                .Intersect(list2)
                .ToList()
                .ForEach(x => Console.Write(" " + x));
        }
        public static void Cau_c()
        {
            Console.Write("Cac gia tri tang dan:");
            list1
                .Concat(list2)
                .OrderBy(x => x)
                .ToList()
                .ForEach(x => Console.Write(" " + x));
        }
        public static void Cau_d()
        {
            Console.Write("Cac phan tu co trong list1 nhung khong co trong list 2:");
            list1
                .Except(list2)
                .ToList()
                .ForEach(x => Console.Write(" " + x));
        }
    }
}
