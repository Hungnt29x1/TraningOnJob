using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_SOLID
{
    /*
        - I : Interface segregation principle (ISP)
        - Thay vì dùng chung vào 1 interface, ta nên tách thành nhiều interface nhỏ, với các mục đích khác nhau.
     */

    //---------------------------- VÍ DỤ ------------------------------------------
    public interface IGuiBaoCao
    {
        void BaoCaoExcel();

        void BaoCaoPDF();
    }// Có vấn đề ở đây là có những nhân viên chỉ cần chức năng báo cáo excel, có nhân viên cần cả 2 chức năng. Lúc này nếu gom chung lại thì ta phải implement lại tất cả phương thức.

    //---------------------GIẢI PHÁP--------------------------------
    // Tách nhỏ mỗi loại báo cáo ra thành các interface nhỏ.

    public interface IBaoCaoPDF
    {
        void BaoCaoPDF();
    }

    public interface IBaoCaoExcel
    {
        void BaoCaoExcel();
    }


    internal class I
    {
    }
}
