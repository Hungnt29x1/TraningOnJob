using System;
using System.Text;

namespace B9_FileIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Service service = new Service();
            string _input;
            do
            {
                Console.WriteLine("1. Mở thư mục");
                Console.WriteLine("2. Tạo File");
                Console.WriteLine("3. Sửa file");
                Console.WriteLine("4. Xóa file");
                Console.WriteLine("5. Copy thư mục");
                Console.WriteLine("6. Thoát");
                Console.WriteLine("Mời chọn: ");
                _input = Console.ReadLine();
                switch (_input)
                {
                    case "1":
                        Console.WriteLine("Xin mới truyền đường dẫn để mở thư mục");
                        _input = Console.ReadLine();
                        service.OpenFolder(_input);
                        break;
                    case "2":
                        Console.WriteLine("Xin mời tạo file");
                        _input = Console.ReadLine();
                        service.CreateFile(_input);
                        break;
                    case "3":
                        Console.WriteLine("Mời bạn nhập file cần sửa");
                        string a = Console.ReadLine();
                        Console.WriteLine("Bạn muốn sửa thành tên gì nào ?");
                        string b = Console.ReadLine();
                        service.EditFile(a, b);
                        break;
                    case "4":
                        Console.WriteLine("Mời nhập file muốn xóa !!!");
                        _input = Console.ReadLine();
                        service.DeteleFile(_input);
                        break;

                    case "5":
                        Console.WriteLine("Mời bạn truyền file muốn copy !!");
                        string path = Console.ReadLine();
                        Console.WriteLine("Đặt tên cho file luôn đi !!");
                        string pathPaste = Console.ReadLine();
                        service.CopyFile(path, pathPaste);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Mời chọn lại !");
                        break;
                }
            } while (true);
        }
    }
}
