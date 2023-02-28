using System;

namespace B3_Struct
{
    /*
     * Struct là kiểu dữ liệu có cấu trúc
     * Struct thuộc nhóm kiểu giá trị C# chứ không phải kiểu tham chiếu C#
     * Không thể khai báo hàm khởi tạo(không đối số)
     * Trong struct có thể chứa: Trường dữ liệu, thuộc tính, phương thức khởi tạo, hằng số, các phương thức, toán tử, sự kiện.
     * Không hỗ trợ kế thừa
     
     */

    /*
     Bài tập struct: Viết chương trình lưu trữ thông tin của sinh viên bao gồm: mã số, họ tên, điểm toán, điểm lý, điểm văn. Thực hiện nhập thông tin cho 1 sinh viên và tính điểm trung bình theo công thức (toán + lý + văn)/3.
     */
    internal class Program
    {
        struct SinhVien
        {
            public int MaSo;
            public string HoTen;
            public double DiemToan;
            public double DiemLy;
            public double DiemVan;
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma so: ");
            SV.MaSo = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan = Double.Parse(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" Ma so: " + SV.MaSo);
            Console.WriteLine(" Ho ten: " + SV.HoTen);
            Console.WriteLine(" Diem toan: " + SV.DiemToan);
            Console.WriteLine(" Diem ly: " + SV.DiemLy);
            Console.WriteLine(" Diem van: " + SV.DiemVan);
        }

        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemVan) / 3;
        }

        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            Console.WriteLine(" Nhập thông tin sinh viên: ");
            /*
             * Đây là hàm hỗ trợ nhập thông tin sinh viên.
             * Sử dụng từ khoá out để có thể cập nhật giá trị nhập được ra biến SV1 bên ngoài 
             * khi kết thúc gọi hàm (có thể xem lại bài Hàm trong C#).
             */
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine("*********");
            Console.WriteLine(" Thông tin sinh viên vừa nhập là: ");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine(" Điểm trung bình 3 môn: " + DiemTBSinhVien(SV1));

            Console.ReadLine();
        }

    }


}
