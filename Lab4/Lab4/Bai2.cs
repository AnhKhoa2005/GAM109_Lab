using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal static class Bai2
    {
        public static void bai2()
        {
            List<UserData> userList = new List<UserData>
            {
                new UserData("Tokyo", 25),
                new UserData("Berlin", 30),
                new UserData("Rio", 20),
                new UserData("Moscow", 35),
                new UserData("Denver", 28)
            };

            Console.WriteLine("\nA. Thong tin Name va Level:");
            userList
                .Select(u => new { u.Name, u.Level })
                .ToList()
                .ForEach(u => Console.WriteLine($"Name: {u.Name}, Level: {u.Level}"));

            Console.WriteLine("\nB. Danh sach giam dan theo level: ");
            userList
                .OrderByDescending(u => u.Level)
                .ToList()
                .ForEach(u => Console.WriteLine($"Name: {u.Name}, Level: {u.Level}"));
        }
    }
}
