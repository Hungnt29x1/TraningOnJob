using System;

namespace C10_Delegate
{
    /*
        - Delegate nó tương tự như con trỏ tới các hàm
        - Delegate là một biến kiểu tham chiếu chứa tham chiếu tới một phương thức

        - Như ví dụ bên dưới thì Delegate có thể được sử dụng để tham chiếu bất kỳ phương thức nào có cùng tham số và  kiểu trả về .
     */
    public class Program
    {
        static void Main(string[] args)
        {
            PhepTinhDelegate phepTinhDelegate;

            PhepTinh phepTinh = new PhepTinh();

            phepTinhDelegate = phepTinh.Tong;// nó là Single cast Delegates -- Tức là 1 delegate chỉ tham chiếu đến 1 phương thức tại 1 thời điểm // Đây là thời điểm 1
            Console.WriteLine(phepTinhDelegate(6, 7));

            phepTinhDelegate = phepTinh.Hieu;// Đây là thời điểm 2
            Console.WriteLine(phepTinhDelegate(6, 7));
        }

        static void ThucHien(PhepTinhDelegate dlg,int a,int b)
        {

        }
    }
}
