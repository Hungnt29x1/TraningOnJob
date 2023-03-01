using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_SOLID
{
    /*
        - S : Single responsibility principle (SRP) 
        - Một class chỉ nên giữ 1 trách nhiệm duy nhất (Chỉ có thể sửa đổi class với 1 lý do duy nhất)
        - Mục đích là để dễ đọc, dễ quản lý. ( ví dụ kiểu class làm quá nhiều việc cùng lúc thì nhìn sẽ rất bị rối

     */
    // ------------- Ví dụ về 1 class làm nhiều việc và rất rồi ---------------
    public class NhanVien
    {
        public int Id { get; set; }
        public string Ten { get; set; }

        public bool Add(NhanVien nv)
        {
            // code xử lý Thêm ở đây
            return true;
        }

        public void GetAll()
        {
            // Code xử lý get ở đây
        }
        public void Report(NhanVien nv)
        {
            // Code xử lý báo cáo ở đây
            //......
        }
    }
    //-------------------------------------------------------------------------

    //Giải pháp : Viết 1 class khác cho việc làm báo cáo hoặc cả chức năng thêm
    public class Service
    {
        public void Report(NhanVien nv)
        {
            // Code xử lý báo cáo ở đây
        }

        public bool Add(NhanVien nv)
        {
            // code xử lý Thêm ở đây
            return true;
        }
    }

    internal class S
    {
    }
}
