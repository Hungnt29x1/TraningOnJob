using System;

namespace B5_VongLap
{
    /*
         * Vòng lặp cho phép lặp lại một hoặc nhiều câu lệnh cho đến khi thỏa mãn điều kiện được chỉ định định.
         *
         * Các loại vòng lặp: while, do..while, for, foreach
         *
         * Từ khóa sử dụng trong vòng lặp:
         *
         * break - ngắt vòng lặp
         * continue: Sẽ bỏ qua các đoạn code phía sau nó và nó quay trở lại lần lặp tiếp theo.
         *
         * Vòng lặp while: Chỉ chạy khi điều kiện luôn đúng và nếu điều kiện luôn đúng ko điểm dừng thì được gọi là vòng lặp vô hạn.
         * Vòng lặp Do..While: Thực hiện hành động ít nhất là 1 lần. Điều kiện đề vòng lặp chạy giống như While(True).
          * Vòng lặp for:
             for (int i = 0; i < 10; i++) {
                }
            int i = 0: Điểm bắt đầu của vòng lặp có kiểu số nguyên
            i < 10: Điều kiện để ngắt vòng
            i++: Tăng bước nhẩy lên 1
   */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int num = 0;
            Console.Write("Số cửu chưởng muốn in ra :");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("--- Cuu chuong {0} ---", i);
                // Vòng lặp con nằm bên trong => lặp từ 1 -> 10
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, (i * j));
                }
            }

        }
    }
}
