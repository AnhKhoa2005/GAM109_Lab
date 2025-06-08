using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal static class Bai2
    {
        public static void _Bai2()
        {
            Console.WriteLine("\n------------Bai 2------------");
            Console.WriteLine("------------Cau a-------------");
            Cau_a();
            Console.WriteLine("------------Cau b-------------");
            Cau_b(); 
            Console.WriteLine("------------Cau c-------------");
            Cau_c();
        }

        public static void Cau_a()
        {
            Bai1.list
                .OrderBy(x => x.winRate)
                .SkipWhile(x => x.winRate <= 50)
                .ToList()
                .ForEach(x => Console.WriteLine($"Name: {x.name} \t Rank: {x.rank} \t WinRate: {x.winRate} \t Type: {x.type} \t Skin: {x.skin}"));
        }

        public static void Cau_b()
        {
            var maxWinRate = Bai1.list.Max(x => x.winRate);
            var userMaxWinRate = Bai1.list.FirstOrDefault(x => x.winRate == maxWinRate);
            Console.WriteLine($"Name: {userMaxWinRate.name} \t Rank: {userMaxWinRate.rank} \t WinRate: {userMaxWinRate.winRate} \t Type: {userMaxWinRate.type} \t Skin: {userMaxWinRate.skin}");
        }

        public static void Cau_c()
        {
            Console.WriteLine($"So luong tai khoan: {Bai1.list.Count}");
        }
    }
}
