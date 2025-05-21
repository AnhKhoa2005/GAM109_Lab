using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Bai3
    {
        public void bai3()
        {
            UserDataLab3 userData = new UserDataLab3("2025", "Anh Khoa", new List<float>() { 10, 9, 8, 2, 7.3f, 4.5f, 1.2f });
            userData.GetInfo();
        }
    }
}
