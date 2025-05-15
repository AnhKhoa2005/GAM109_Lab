using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_1
{
    internal class Maps
    {
        public string id;
        public string name;
        public static string inGame = "Lien Minh Huyen Minh";

        public Maps(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Maps()
        {
        }

        public string ShowData()
        {
            return "ID: " + id + " |Name: " + name + " |InGame: " + inGame;
        }
    }
}
