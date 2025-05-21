using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class UserDataLab2
    {
        public string id;
        public string userName;
        public int level;

        public UserDataLab2(string id, string userName, int level)
        {
            this.id = id;
            this.userName = userName;
            this.level = level;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ID: {this.id} | UserName: {this.userName} | Level: {this.level}");
        }
    }
}
