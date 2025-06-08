using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal static class Bai1
    {
        public static List<UserAccountLab5> list = new List<UserAccountLab5>();
        public static void _Bai1()
        {
            Console.WriteLine("\n------------Bai 1-------------");
            Cau_a();
            Console.WriteLine("------------Cau b-------------");
            Cau_b();
            Console.WriteLine("------------Cau c-------------");
            Cau_c();
            Console.WriteLine("------------Cau d------------");
            Cau_d();
        }

        public static void Cau_a()
        {
            list.Add(new UserAccountLab5("Son Tung", 10, 55.5f, "Ca nhac", 50));
            list.Add(new UserAccountLab5("Den vau", 5, 70.5f, "Ca nhac", 10));
            list.Add(new UserAccountLab5("Do Mixi", 1, 90f, "ALL", 2));
            list.Add(new UserAccountLab5("LienQuan", 7, 98f, "Game", 255));
            list.Add(new UserAccountLab5("PewPew", 3, 50f, "Live", 30));
            list.Add(new UserAccountLab5("CSGO", 6, 85f, "Game", 500));
            list.Add(new UserAccountLab5("Bang Bang", 2, 40f, "Game", 123));
        }

        public static void Cau_b()
        {
            list
                .OrderByDescending(x => x.rank)
                .ToList()
                .ForEach(x => Console.WriteLine($"Name: {x.name} \t Rank: {x.rank} \t WinRate: {x.winRate} \t Type: {x.type} \t Skin: {x.skin}"));
        }

        public static void Cau_c()
        {
            list
                 .OrderByDescending(x => x.name)
                 .ThenByDescending(x => x.skin)
                 .ToList()
                 .ForEach(x => Console.WriteLine($"Name: {x.name} \t Rank: {x.rank} \t WinRate: {x.winRate} \t Type: {x.type} \t Skin: {x.skin}"));
        }

        public static void Cau_d()
        {
            list
                .Where(x => x.name.StartsWith("B"))
                .ToList()
                .ForEach(x => Console.WriteLine($"Name: {x.name} \t Rank: {x.rank} \t WinRate: {x.winRate} \t Type: {x.type} \t Skin: {x.skin}"));
        }
    }
}
