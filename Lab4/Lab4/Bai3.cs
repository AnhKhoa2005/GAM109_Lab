using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4
{
    internal static class Bai3
    {
        public static void bai3()
        {
            List<Student> students = new List<Student>
            {
                new Student("1","Hoa", 9),
                new Student("2","Vu", 13),
                new Student("3","Khoa", 15),
                new Student("4","Lan", 29),
                new Student("5", "Huy", 17),
                new Student("6", "Khanh", 20),
                new Student("7", "Huyen", 16),
            };
            Console.WriteLine("Cac sinh vien co tuoi > 12 va < 20:");

            Console.WriteLine("\nLINQ Query Syntax:");
            var Result = from s in students
                         where s.Age > 12 && s.Age < 20
                         select new { s.Name, s.Age };

            foreach (var s in Result)
            {
                Console.WriteLine($"Name: {s.Name}, Age: {s.Age}");
            }

            Console.WriteLine("\nLINQ Method Syntax:");
            students
                .Where(s => s.Age > 12 && s.Age < 20)
                .Select(s => new { s.Name, s.Age })
                .ToList()
                .ForEach(s => Console.WriteLine($"Name: {s.Name}, Age: {s.Age}"));
        }
    }
}
