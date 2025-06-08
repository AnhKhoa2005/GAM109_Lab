using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal static class Bai1
    {
        static List<int> listInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9};
        static List<string> listStr = new List<string>() { null, "T1", "T2", "T3", null };
        static List<string> listNull = new List<string>();
        public static void _Bai1()
        {
            Console.WriteLine("----------Bai 1----------");
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
            var newNumber = listInt
                                 .Where(x => x % 2 == 0)
                                 .FirstOrDefault(x => x > 5);
            Console.WriteLine($"So chan dau tien va lon hon 5 trong listInt: {newNumber}");
        }
        public static void Cau_b()
        {
            var newNumber = listInt
                               .LastOrDefault(x => x > 200);
            Console.WriteLine($"Phan tu cuoi vung trong listInt > 200: {newNumber}");
        }
        public static void Cau_c()
        {
            var newStr = listStr
                            .FirstOrDefault(x => x != null && x.StartsWith("T"));
            Console.WriteLine($"Phan tu dau tien trong listStr co gia tri bat dau bang 'T': {newStr}");
        }
        public static void Cau_d()
        {
            var total = listInt
                                .Where((x, index) => index % 2 != 0 && x % 2 == 0)
                                .Sum();
            Console.WriteLine($"Tong cac gia tri tai vi tri index le va chia het cho 2 trong listInt: {total}");
        }

    }
}
