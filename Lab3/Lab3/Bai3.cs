using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal static class Bai3
    {
        static string path1 = @"..\..\..\data";
        static string path2 = @"..\..\..\data2";
        static string path3 = @"..\..\..\data\folder";
        static string id = "PD12001";
        static string name = "Trần Duy Anh Khoa";


        public static void _Bai3()
        {
            CreateFolder(path1);
            CreateFolder(path3);
            WriteFile(path1, id, name);

            CreateFolder(path2);
            CopyFile(path1, path2);
        }

        public static void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }

        public static void WriteFile(string path, string id, string name)
        {
            string newPath = Path.Combine(path, "data.txt");

            using (FileStream fs = new FileStream(newPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write(id + " ");
                    sw.Write(name + "\n");
                }
            }
        }

        public static void CopyFile(string path1, string path2)
        {
            DirectoryInfo sourceDir = new DirectoryInfo(path1);
            DirectoryInfo targetDir = new DirectoryInfo(path2);

            // Nếu thư mục đích chưa tồn tại thì tạo nó
            if (!targetDir.Exists)
                targetDir.Create();

            foreach (FileInfo files in sourceDir.GetFiles())
            {
                files.CopyTo(Path.Combine(targetDir.FullName, files.Name), true);
            }

            foreach (DirectoryInfo subDir in sourceDir.GetDirectories())
            {
                //Lấy nguồn copy mới từ thư mục con của path1 trở đi, và nối thư mục path2 hiện tại trở đi với thư mục con bên trong
                CopyFile(subDir.FullName, Path.Combine(targetDir.FullName, subDir.Name));
            }
        }
    }
}
