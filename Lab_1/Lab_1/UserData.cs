using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal static class UserData
    {
        public static string ID;
        public static string UserName;
        public static float Health;
        public static int Point;

        static UserData()
        {
            ID = "2025";
            UserName = "Anh Khoa";
            Health = 100;
            Point = 10;
        }
    }
}
