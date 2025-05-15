using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 1
            Console.WriteLine($"ID: {UserData.ID}");
            Console.WriteLine($"UserName: {UserData.UserName}");
            Console.WriteLine($"Health: {UserData.Health}");
            Console.WriteLine($"Point: {UserData.Point}");

            //Bài 2
            Maps map_1 = new Maps("1", "Anh A");
            Console.WriteLine(map_1.ShowData());

            Maps map_2 = new Maps()
            {
                id = "2",
                name = "Anh B"
            };
            Console.WriteLine(map_2.ShowData());

            //Bài 3
            Calculator calc = new Calculator();
            Console.WriteLine("Add = " + calc.Add());
            Console.WriteLine("Sub = " + calc.Sub());
            Console.WriteLine("Mul = " + calc.Mul());
            Console.WriteLine($"Div = {calc.Div():F2}");
        }
    }
}
