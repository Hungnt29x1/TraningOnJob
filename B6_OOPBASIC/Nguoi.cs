using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_OOPBASIC
{
    public class Nguoi
    {
        public string ten { get; set; }
        public string sdt { get; set; }
        public int gioiTinh { get; set; }//1 = Nam | 0 Nữ

        public Nguoi()
        {

        }

        public Nguoi(string ten, string sdt, int gioiTinh)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
        }


        public virtual void inRaManHinh() // Vì phương thức inRaManHinh khai báo là loại phương thức virtual, nên ở lớp kế thừa nó, có thể định nghĩa lại - kỹ thuật này gọi là nạp chồng (override)
        {

        }
    }
}
