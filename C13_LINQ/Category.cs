using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_LINQ
{
    public class Category
    {
        public int Id { get; set; }
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public bool TrangThai { get; set; }



        public void InRaManHinh()
        {
            Console.WriteLine($"{Id} | {MaTheLoai} | {TenTheLoai} | {TrangThai}");
        }
    }
}
