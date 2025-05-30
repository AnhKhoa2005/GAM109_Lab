using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal static class Bai1
    {
        static string path = @"..\..\..\data.txt";
        static string userName = "AnhKhoa2k5";
        static string passWord = "12345";
        public static void _Bai1()
        {
            WriteFile(path, userName, passWord);
            ReadFile(path, userName, passWord);
        }

        public static void WriteFile(string path, string userName, string passWord)
        {

            if (UserExists(userName, path)) //Nếu có tên rồi thì không cần ghi nữa
                return;

            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                fs.Close();
            }


            using (StreamWriter sw = new StreamWriter(path, append: true, Encoding.UTF8))
            {
                sw.Write(userName + " ");
                sw.Write(passWord + "\n");
            }

        }
        public static void ReadFile(string path, string userName, string passWord)
        {
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                int index = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split(' ');
                    info.ToList().ForEach(x =>
                    {
                        if (index == 0)
                            Console.Write("User: ");
                        else if (index == 1)
                            Console.Write("Pass: ");
                        Console.Write(x + " ");
                        index++;
                    });
                    Console.WriteLine();
                    index = 0;
                }
            }
        }

        public static bool UserExists(string userName, string path)
        {
            if (!File.Exists(path)) return false ; // Nếu tệp chưa có thì false

            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] _string = line.Split(' ');
                    if (_string[0] == userName)
                    {
                        return true; //Nếu tên đã tồn tại thì true
                    }
                };
                return false; //Nếu chưa có tên thì false
            }
        }
    }
}

