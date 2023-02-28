using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_OOPBASIC
{
    internal class NguoiYeuMoi : Nguoi
    {
        public double canNang { get; set; }
        public string soThich { get; set; }
        public string danhGia { get; set; }
        public NguoiYeuMoi()
        {

        }

        public NguoiYeuMoi(string ten, string sdt, int gioiTinh, double canNang, string soThich) : base(ten, sdt, gioiTinh)
        {
            this.canNang = canNang;
            this.soThich = soThich;
        }

            

        public override void inRaManHinh()
        {
            Console.WriteLine($"{ten} | {sdt} | {(gioiTinh == 1 ? "Nam" : "Nữ")} | {soThich} | {canNang} | [{danhGia}]");
        }
    }
}
