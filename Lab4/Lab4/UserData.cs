using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class UserData
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public UserData(string Name, int Level)
        {
            this.Name = Name;
            this.Level = Level;
        }
    }
}
