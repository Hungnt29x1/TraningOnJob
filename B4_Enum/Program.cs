using System;
using System.Collections.Generic;

namespace B4_Enum
{
    /*
     * Enum là 1 từ khóa để khai báo 1 kiểu liệt kê
     * Là 1 kiểu dữ liệu tham trị
     * Không được phép kế thừa
     * Đại diện cho các số nguyên bắt đầu từ 0.--- 0 , 1 ,2
     
     */
    enum Status
    {
        Active,
        Inactive,
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public Status Status { get; set; } //
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Hùng",
                    Age = 21,
                    Created = DateTime.Now,
                    Status = Status.Inactive,
                },
                new Student()
                {
                    Id = 2,
                    Name = "Trang",
                    Age = 22,
                    Created = DateTime.Now,
                    Status = 0,
                }
            };
            foreach (var item in students)
            {
                Console.WriteLine($"Mã : {item.Id}, Tên : {item.Name}, Tuổi: {item.Age}, Trạng thái: {item.Status}");
                Console.WriteLine();
            }
        }
    }
}
