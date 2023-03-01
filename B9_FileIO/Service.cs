using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9_FileIO
{
    public class Service
    {
        public void OpenFolder(string path)
        {
            string[] inFile = Directory.GetFiles(path);
            Console.WriteLine($"Danh sách file trong thư mục {path}");
            foreach (string file in inFile)
            {
                Console.WriteLine(file);
            }
        }

        public void CreateFile(string pathResult)
        {
            File.Create(@"D:\TestTaoFile\" + pathResult);
            Console.WriteLine("Đã tạo");
        }

        public void EditFile(string path1, string path2)
        {
            File.Move(@"D:\TestTaoFile\" + path1, @"D:\TestTaoFile\" + path2);
            Console.WriteLine("Đã sửa");
        }

        public void DeteleFile(string path)
        {
            File.Delete(@"D:\TestTaoFile\" + path);
            Console.WriteLine("Đã xóa");
        }

        public void CopyFile(string copy, string paste)
        {
            File.Copy(@"D:\TestTaoFile\" + copy, @"D:\TestTaoFile\" + paste);
            Console.WriteLine("Đã copy xong");
        }
    }
}
