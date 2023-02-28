using System;

namespace B1_ValueType_ReferenceTyle
{
    /*
      - Kiểu tham trị sẽ lưu trực tiếp dữ liệu trong bộ nhớ Stack
       - Kiểu tham chiếu chỉ lưu địa chỉ của ô nhớ trong Stack còn giá trị biến nằm ở trong Heap

    + Stack là cấp phát tĩnh, kích cỡ nhỏ (Kích thước phải biết lúc biên dịch) 
    + Heap là cấp phát Động , kích cỡ lớn (KHông biết kích thước biến lúc biên dịch

    - Kiểu tham trị lưu nội dung , khi tạo 1 biến kiểu tham trị thì 1 vùng nhớ sẽ được cấp phát để lưu giá trị của biến 1 cách trực tiếp và nếu gán nó cho 1 biến khác thì giá trị sẽ được copy trực tiếp và cả 2 biến sẽ làm việc kiểu 1 cách độc lập
    - Các kiểu tham trị : + Các kiểu số nguyên
                          + Kiểu số thực
                          + Kiểu logic bool
                          + Kiểu ký tự char
                          + Kiểu Struct 
                          + Kiểu Enum
    - Các kiểu tham chiếu : + Class
                            + Object
                            + Array
                            + Indexer
                            + Interface

    - Kiểu tham chiếu
     */
    internal class Program
    {
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        static void ChangeReferenceType(Student student1)
        {
            student1.StudentName = "Tien Hung";
        }

        static void ChangeRef(ref int tuoi)
        {
            ++ tuoi;
            Console.WriteLine("Tuổi của bạn là: "+tuoi);
        }

        static void ChangeOut(out int tuoi)
        {
            tuoi = 200;
            ++tuoi;
            Console.WriteLine("Tuổi của bạn là: " + tuoi);
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("----------------------------THAM TRỊ----------------------------");
            int i = 100;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);


            Console.WriteLine("----------------------------THAM CHIẾU----------------------------");
            Student student2 = new Student();
            student2.StudentName = "Quang Huy";
            ChangeReferenceType(student2);
            Console.WriteLine(student2.StudentName);// THay đổi giá trị -- Nó không phải copy giá trị mà nó update cái student có sẵn


            Console.WriteLine("----------------------------Ref----------------------------");
            int tuoi2 = 100;
            ChangeRef(ref tuoi2);// ref phải gán giá trị trước 
            Console.WriteLine("Tuổi của ref :"+tuoi2);


            Console.WriteLine("----------------------------OUT----------------------------");
            ChangeOut(out int tuoi3);// out không cần gán giá trị trước
            Console.WriteLine("Tuổi của out :" + tuoi3);
        }
    }

    class Student
    {
        public string StudentName { get; set; }
    }
}
