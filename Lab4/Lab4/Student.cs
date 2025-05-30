using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string Id ,string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
    }
}
