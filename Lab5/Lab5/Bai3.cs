using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal static class Bai3
    {
        public static void _Bai3()
        {
            Console.WriteLine("\n------------Bai 3------------");
            var listAccountToLookup = Bai1.list.ToLookup(x => x.type);

            foreach (var type in listAccountToLookup)
            {
                Console.WriteLine("\n" + type.Key);
                foreach (var info in type)
                {
                    Console.WriteLine($"Name: {info.name} \t Rank: {info.rank} \t WinRate: {info.winRate} \t Skin: {info.skin}");
                }
            }
        }
    }
}
