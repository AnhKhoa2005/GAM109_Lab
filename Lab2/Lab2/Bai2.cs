using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Bai2
    {
        public void bai2a()
        {
            var userInfo = new
            {
                id = "2025",
                name = "Faker",
                isPlaying = false,
                bag = new
                {
                    skins = 127,
                    cups = 20,
                }
            };
            Console.WriteLine();
            Console.WriteLine("ID: " + userInfo.id);
            Console.WriteLine("Name: " + userInfo.name);
            Console.WriteLine("IsPlaying: " + userInfo.isPlaying);
            Console.WriteLine("Bag Skins: " + userInfo.bag.skins);
            Console.WriteLine("Bag Cups: " + userInfo.bag.cups);
        }

        public void bai2b()
        {
            Console.WriteLine();
            int y = 10;
            Action<int> anonymousMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Sub: " + sub);
            };
            anonymousMethod(5);
        }
    }
}
