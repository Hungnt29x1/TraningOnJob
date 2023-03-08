using System;

namespace C19_LambdaExpression
{
    internal class Program
    {
        /*
     * Biểu thức lambda còn gọi là biểu thức (Anonymous), một biểu thức khai báo giống phương thức nhưng thiếu tên. Cú pháp để khai báo biểu thức lambda là sử dụng toán dử => như sau:
        Công thức 1:
            (tham_số) => biểu_thức;
        Công thức 2:
        (tham_số) =>
            {
               các câu lệnh
               Sử dụng return nếu có giá trị trả về
            };            
     */
        //Ví dụ 1: Sử dụng Delegate với lambda
        delegate int TinhHaiSo(int a, int b);

        public static int TinhTongHaiSo(int a, int b)
        {
            return a + b;
        }

        public static void ViDu1()
        {
            int x = 9, y = 10;
            TinhHaiSo tt = TinhTongHaiSo;//Lúc mới học sẽ tham chiếu như này

            //Khi áp dụng Lambda
            //Cách 1
            TinhHaiSo tt1 = (int c, int d) =>
            {
                return c + d;
            };
            //Cách 2:
            TinhHaiSo tt2 = (int c, int d) => c + d;

            Console.WriteLine(tt1(x, y));
        }

        //Ví dụ 2: khai báo 1 phương thức kiểu lambda
        static double PhepChia(int x, int y) => x / y;

        //Ví dụ 3: 
        public static void ViDu3()
        {
            int[] arrNumbers = { 11, 12, 13, 14 };
            //Cách 1:
            foreach (var x in arrNumbers)
            {
                Console.WriteLine(x);
            }

            //Cách 2:
            Array.ForEach(arrNumbers, delegate (int x) { Console.WriteLine(x); });
            //Cách 3:
            Array.ForEach(arrNumbers, x => Console.WriteLine(x));
            //Cách 4:
            foreach (var x in arrNumbers) Console.WriteLine(x);

        }
        #region Một số quy tắc khi sử dụng lambda
        delegate void ChaoBan1(string name);
        delegate void ChaoBan2();
        delegate void ChaoBan3(string name1, string name2, string name3);
        delegate int TinhToan(int a, int b);
        delegate bool Check1(int a, int b);

        static void ViDu4()
        {
            //1. Không quan tâm đến kiểu dữ liệu đầu vào
            ChaoBan1 chao1 = (string temp) => { Console.WriteLine("Chào bạn " + temp); };
            ChaoBan1 chao2 = (temp) => { Console.WriteLine("Chào bạn " + temp); };

            //2. Để trống nếu không có tham số ()
            ChaoBan2 chao3 = () => { Console.WriteLine("Chào bạn"); };

            //3. Nếu chỉ có một tham số bỏ luôn dấu ()
            ChaoBan1 chao4 = temp => { Console.WriteLine("Chào bạn " + temp); };

            //4. Nếu có nhiều tham số ngăn cách bằng dấu ,
            ChaoBan3 chao5 = (x, y, z) => { Console.WriteLine("Chào" + x + y + z); };

            //5. Nếu phương thức chỉ có 1 câu lệnh thực thi bỏ dấu {}
            ChaoBan3 chao6 = (x, y, z) => Console.WriteLine("Chào" + x + y + z);

            //6. Đối với phương thức return
            TinhToan tinhToan = (x, y) => { return x + y; };
            Check1 check1 = (x, y) => { return x > 10 && y < 20; };
        }
        //Ngoài ra các bạn mở rộng kiến thức bằng cách search nhiều
        #endregion

        // Khai báo một delegate với tham số là một số nguyên và trả về giá trị là một số nguyên
        delegate int MultiplyDelegate(int x);

        static void Main(string[] args)
        {
            /*
             * Lambda expression được sử dụng chủ yếu để thay thế cho các delegate trong C#, nhằm đơn giản hóa việc xử lý các sự kiện, lọc, sắp xếp hay tìm kiếm dữ liệu trong mảng hoặc collection.
              
             
                 (input-parameters) => expression
            Trong đó : 
            - input-parameters: là các tham số đầu vào của hàm, nếu không có tham số thì để trống hoặc sử dụng dấu ngoặc đơn.
            - =>: là toán tử lambda.
            - expression: là biểu thức mà lambda expression sẽ trả về.
             */

            // Sử dụng lambda expression để khởi tạo delegate trên
            MultiplyDelegate multiply = x => x * x;
            // Sử dụng delegate để tính bình phương của số 5
            int result = multiply(5); // kết quả: 25

            Console.WriteLine(result);


        }
    }
}
