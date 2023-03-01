using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_SOLID
{
    /*
     *  - Open closed principle (OCP)
        - Có thể mở rộng 1 class, nhưng không được sửa đổi bên trong class đó

     */

    // -------------------------------- VÍ DỤ -------------------------------------------
    public class Report
    {
        public string LoaiBaoCao { get; set; }

       
        public void TaoBaoCao(NhanVien nv)
        {
            if (LoaiBaoCao == "Word")
            {
                // Code tạo báo cáo với nhân viên bằng word ở đây
            }
            if (LoaiBaoCao == "PDF")
            {
                // Code tạo báo cáo với nhân viên bằng PDF ở đây
            }
        }
    } // Cái vấn đề ở đây là khi mà muốn thêm nhiều loại báo cáo khác như PP , Doc,... thì lúc này phải sửa class cũ Report và thêm vào bên trong nhiều if của phương thức TaoBaoCao() ---> thì cái việc chỉnh sửa này thì không nên 

    //-------------------------Giải pháp ------------------------------------------------
    // Sử dụng 1 interface để trừu tượng hóa chức năng tạo báo cáo . Khi có thêm loại báo cáo ta chỉ cần tạo class cụ thể và sử dụng interface này.
    public interface IBaoCao
    {
        public void TaoBaoCao(NhanVien em);
    }
    
    public class BaoCaoBangDoc : IBaoCao
    {
        public void TaoBaoCao(NhanVien nv)
        {
            // viết code báo cáo bằng DOC ở đây
        }
    }
   
    public class BaoCaoBangExcel : IBaoCao
    {
        public void TaoBaoCao(NhanVien nv)
        {
            // viết code báo cáo bằng Excel ở đây
        }
    }


    internal class O
    {
    }
}
