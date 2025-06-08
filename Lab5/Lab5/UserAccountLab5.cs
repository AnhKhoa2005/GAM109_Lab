using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class UserAccountLab5
    {
        public string name;
        public int rank;
        public float winRate;
        public string type;
        public int skin;

        public UserAccountLab5(string name, int rank, float winRate, string type, int skin)
        {
            this.name = name;
            this.rank = rank;
            this.winRate = winRate;
            this.type = type;
            this.skin = skin;
        }
    }
}
