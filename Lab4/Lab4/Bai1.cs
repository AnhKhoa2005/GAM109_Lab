using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Bai1
    {
        public static void bai1()
        {
            List<int> numbers = new List<int> { 1, 4, 7, 22, 33, 41, 12, 36, 23, 11, 88, 55, 66, 43, 46, 90, 120, 100 };

            Console.Write("Cac so chan:");
            numbers
                .Where(x => x % 2 == 0)
                .ToList()
                .ForEach(x => Console.Write(" " + x));
        }
    }
}
