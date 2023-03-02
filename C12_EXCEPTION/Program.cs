using System;

namespace C12_EXCEPTION
{
    internal class Program
    {
        #region EXCEPTION - Xử lý ngoại lệ: try + tab
        /*
           Một số Exception class thường gặp:
               - Exception [Lớp cơ bản của mọi ngoại lệ.]          
               - SystemException [Lớp cơ bản của mọi ngoại lệ phát ra tại thời điểm chạy của chương trình.]           
               - IndexOutOfRangeException [Được ném ra tại thời điểm chạy khi truy cập vào một phần tử của mảng với chỉ số không đúng.]           
               - NullReferenceException [Ném ra tại thời điểm chạy khi một đối tượng null được tham chiếu.]
               - AccessViolationException [Ném ra tại thời điểm chạy khi tham chiếu vào vùng bộ nhớ không hợp lệ.]
               - InvalidOperationException [Ném ra bởi phương thức khi ở trạng thái không hợp lệ.]           
               - ArgumentException [Lớp cơ bản cho các ngoại lệ liên quan tới đối số (Argument).]
               - ArgumentNullException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức mà không cho phép thông số null truyền vào.]
               - ArgumentOutOfRangeException [Lớp này là con của ArgumentException, nó được ném ra bởi phương thức khi một đối số không thuộc phạm vi cho phép truyền vào nó.]
               - ExternalException [Lớp cơ bản cho các ngoại lệ xẩy ra hoặc đến từ môi trường bên ngoài.]
               - COMException [Lớp này mở rộng từ ExternalException, ngoại lệ đóng gói thông tin COM.]
               - SEHException [Lớp này mở rộng từ ExternalException, nó tóm lược các ngoại lệ từ Win32.]
        */
        //Ví dụ 1: Đối với số nguyên chia cho 0 sẽ phát sinh lỗi
        public static void Vidu1()
        {
            int a = 5, b = 0, c;
            c = a / b;
            Console.WriteLine(c);// System.DivideByZeroException: Attempted to divide by zero.
            Console.WriteLine("Kế thúc chương trình");
        }
        public static void Vidu2()
        {
            int a = 5, b = 0, c;
            try
            {
                c = a / b;
                Console.WriteLine(c);// System.DivideByZeroException: Attempted to divide by zero.
            }
            catch (DivideByZeroException e)
            {
                /*
                * 1. Trong chương trình khi phát sinh 1 lỗi xảy ra thì sẽ phát sinh đối tượng Exception hoặc lớp kế thừa từ lớp này. Lớp này giúp hiển thị các thông tin về lỗi giúp xử lý các bước tiếp theo.
                   - e.Message : Thông tin về lỗi
                   - e.StackTrace: Truy vết của lỗi nằm ở đâu
                   - e.GetType().Name: Thông tin lỗi của lớp nào
                   ..... Hãy khám phá thêm trong quá trình học
                */
                Console.WriteLine("Các lỗi xảy ra ");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().Name);
            }
            Console.WriteLine("Kế thúc chương trình");
        }
        //Ví dụ 3: Sử dụng Finally
        public static void Vidu3()
        {
            int a = 5, b = 0, c;
            try
            {
                c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                //Thực hiện 1 hành đố nếu lỗi
            }
            catch (AccessViolationException e)
            {
                //Thực hiện 1 hành đố nếu lỗi
            }
            catch (Exception e)
            {
                //Thực hiện 1 hành đố nếu lỗi
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Kế thúc chương trình");
        }


        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Vidu1();
            //Vidu2();
            Vidu3();
        }
    }
}
