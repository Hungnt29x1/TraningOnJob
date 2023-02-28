using System;

namespace B2_Constant_ReadOnly_Static
{
    /*
     * Const là 1 hằng số từ khi biên dịch  . Bắt buộc phải gán giá trị khi mà mình bắt đầu biên dịch và không thể thay đổi giá trị
    
     * static được sử  dụng để tạo một biến hoặc một thành phần tĩnh, nghĩa là giá trị của nó sẽ được chia sẻ cho toàn bộ các đối tượng và không gắn vào một đối tượng cụ thể nào
     
     * So với Const thì Readonly ko cần phải gán giá trị luôn cho nó . Và khi khởi tạo nó trong contrucstor thì không đc thay đổi giá trị
     
     */
    internal class Program
    {
        const int a = 0;
        const string a1 = "test";
        const double a2 = 3.14159;
        //const double a3;// Bắt buộc phải gán giá trị

        static int x = 10;
        int y = 20;

        class TestReadOnly
        {
            readonly int b = 10; // Khởi tạo lúc khai báo
            readonly int c;

            public TestReadOnly(int _c)
            {
                c = _c; // khởi tạo lúc chạy
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("---------------- Const -----------------");
            //a = 0;// Const ko thể thay đổi giá trị
            Console.WriteLine("Đây là const : {0}",a2);

            Console.WriteLine("---------------- Static ----------------");
            Console.WriteLine("Đây là số : {0}",x);
            //Console.WriteLine(y); //lỗi bởi vì static method chỉ truy cập được biến static

        }


    }
}
