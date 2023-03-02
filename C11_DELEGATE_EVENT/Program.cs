using System;

namespace C11_DELEGATE_EVENT
{
    /*
       * - Sự kiện (Event) là các hành động, ví dụ như nhấn phím, click, di chuyển chuột...
         - Trong C#, Event là một đối tượng đặc biệt của  Delegate, nó là nơi chứa các phương thức, các phương thức này sẽ được thực thi khi sự kiện xảy ra
         - Đặc điểm của event:
             + Được khai báo trong các lớp hoặc interface
             + Được khai báo là abstract hoặc sealed, virtual
             + Được thực thi thông qua delegate
         - Tạo và sử dụng event
             + Đinh nghĩa delegate cho event
             + Tạo event thông qua delegate
             + Đăng ký để lắng nghe và xử lý event
             + Kích hoạt event
       */
    internal class Program
    {
        public delegate void SuKienNhap2So(int x, int y);

        class NguoiDung
        {
            public event SuKienNhap2So sukienNhapSo;

            public void nhap2So()
            {
                Console.WriteLine("Mời bạn nhập số thứ 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập số thứ 2: ");
                int b = Convert.ToInt32(Console.ReadLine());
                //Phát sự kiện
                sukienNhapSo.Invoke(a, b);
            }
        }

        class TinhToan
        {
            public void thiHanhTinhTong(NguoiDung nguoiDung)
            {
                //Phải sử dụng += hoặc -= để thực hiện phép gán
                nguoiDung.sukienNhapSo += tinhTong;//Khi sự kiện nhập số xảy ra thì sẽ thi hành tính tổng 2 số
            }

            private void tinhTong(int a, int b)
            {
                Console.WriteLine("Tổng: {0} + {1} = {2}", a, b, a + b);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Phát đi sự kiện
            NguoiDung nguoiDung = new NguoiDung();

            //Nhận sự kiện
            TinhToan tinhToan = new TinhToan();
            tinhToan.thiHanhTinhTong(nguoiDung);

            //Thực thi
            nguoiDung.nhap2So();

        }
    }
}
