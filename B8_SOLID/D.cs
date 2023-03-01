using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_SOLID
{
    /*
        - D : Dependency inversion principle (DIP)
        - Nó là 1 nguyên lý để thiết kế và viết code . 
        - Không nên viết code gắn chặt với nhau vì nó gây khó khăn trong việc bảo trì
    kiểu như là nếu một class phụ thuộc một class khác, ta cần phải thay đổi class đó nếu một trong những class phụ thuộc phải thay đổi. Tốt nhất là cố gắng viết các class ít phụ thuộc nhất có thể.
     */

    //-------------------VÍ DỤ------------------------------------
    public class Email
    {
        public void GuiMail()
        {
            // code to send mail
        }
    }

    public class ThongTin
    {
        private Email _email;
        public ThongTin()
        {
            _email = new Email();
        }

        public void ThongTinBaoCao()
        {
            _email.GuiMail();
        }
    }//  class ThongTin phụ thuộc hoàn toàn vào class Email, vì nó chỉ gửi 1 loại(là gửi mail). Nếu mà ví dụ bây giờ mà muốn thêm tính năng Gửi Tin nhắn thì chúng ta phải thay đổi cả hệ thống thông báo

    //--------------------------------Giải pháp-------------------------------------------------
    public interface IMessenger
    {
        void GuiMessenger();
    }
    public class Email2 : IMessenger
    {
        public void GuiMessenger()
        {
            // code to send email
        }
    }

    public class TinNhan : IMessenger
    {
        public void GuiMessenger()
        {
            // code to send SMS
        }
    }
    public class ThongTin2
    {
        private IMessenger _iMessenger;// Giảm sự phụ thuộc và dễ bảo trì
        public ThongTin2()
        {
            _iMessenger = new Email2();
        }
        public void ThongTinBaoCao()
        {
            _iMessenger.GuiMessenger();
        }
    }
    internal class D
    {
    }
}
