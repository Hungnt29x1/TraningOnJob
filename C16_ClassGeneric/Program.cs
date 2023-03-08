using System;
using System.Text;

namespace C16_ClassGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*
             * Ví dụ 1: Sử dụng Class FPOLY GENERIC
             */
            NTQ<int> classNTQ = new NTQ<int>();
            classNTQ.Temp = 4;
            Console.WriteLine(classNTQ.Temp);
            /*
             * Ví dụ 2: Triển khai 1 đối tượng có 1 thuộc tính là mảng chưa xác kiểu dữ liệu
             * 1. Khai báo 1 mảng
             * 2. Nhập giá trị
             * 3. In tất cả phần tử trong mảng
             */
            Console.WriteLine("Mời bạn nhập số lượng phần tử: ");
            int size = Convert.ToInt32(Console.ReadLine());
            ArrayGeneric<string> ag = new ArrayGeneric<string>(size);
            for (int i = 0; i < ag.Arr.Length; i++)
            {
                Console.Write($"Mời bạn nhập phần tử thứ {i}: ");
                ag.addValueByIndex(i, Console.ReadLine());
            }

            Console.WriteLine("Xuất danh sách");
            for (int i = 0; i < ag.Arr.Length; i++)
            {
                Console.Write(ag.getValueByIndex(i) + " ");
            }
        }
    }
}
