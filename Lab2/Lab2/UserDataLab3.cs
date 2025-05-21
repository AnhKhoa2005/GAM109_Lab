using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class UserDataLab3
    {
        public string id;
        public string userName;
        List<float> scores;

        public UserDataLab3(string id, string userName, List<float> scores)
        {
            this.id = id;
            this.userName = userName;
            this.scores = scores;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ID: {this.id} | UserName: {this.userName}");
            Console.Write("Score: ");
            foreach (var item in scores)
            {
                Console.Write(item + " ");
            }
        }
    }
}
