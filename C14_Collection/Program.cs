using System;
using System.Collections;

namespace C14_Collection
{
    internal class Program
    {
        #region COLLECTION LÀ GÌ?
        /*
         * - Collection là lớp hỗ trợ lưu trữ, quản lý và thao tác với các đối tượng linh hoạt.
           - Có thể lưu trữ một tập hợp đối tượng thuộc nhiều kiểu khác nhau.
           - Hỗ trợ rất nhiều phương thức để thao tác với tập hợp như: tìm kiếm, sắp xếp, đảo ngược, . . .
           - Là một mảng có kích thước động:
               + Không cần khai báo kích thước khi khởi tạo.
               + Có thể tăng giảm số lượng phần tử trong mảng một cách linh hoạt
         */
        #endregion

        #region HashTable  
        /*
         * - Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
         * - Vì Key và Value đều là kiểu object nên ta có thể lưu trữ được mọi kiểu dữ liệu từ những kiểu cơ sở đến kiểu phức tạp (class).

           Một số thuộc tính và phương thức hỗ trợ sẵn trong Hashtable: 
                - Count  Trả về 1 số nguyên là số phần tử hiện có trong Hashtable.           
                - Keys  Trả về 1 danh sách chứa các Key trong Hashtable.           
                - Values  Trả về 1 danh sách chứa các Value trong Hashtable.
                - Add(object Key, object Value)  Thêm 1 cặp Key - Value vào Hashtable.

                - Clear()  Xoá tất cả các phần tử trong Hashtable.           
                - Clone()  Tạo 1 bản sao từ Hashtable hiện tại.           
                - ContainsKey(object Key) Kiểm tra đối tượng Key có tồn tại trong Hashtable hay không.           
                - ContainsValue(object Value)  Kiểm tra đối tượng Value có tồn tại trong Hashtable hay không.           
                - CopyTo(Array array, int Index)  Thực hiện sao chép tất cả phần tử trong Hashtable sang mảng một chiều array từ vị trí Index của array. Lưu ý: array phải là mảng các object hoặc mảng các DictionaryEntry.           
                - Remove(object Key)  Xoá đối tượng có Key xuất hiện đầu tiên trong Hashtable.
         */
        static void MethodHashTable()
        {

            // khởi tạo 1 Hashtable
            Hashtable Hash1 = new Hashtable();

            // khởi tạo 1 Hashtable và chỉ định Capacity ban đầu là 10
            Hashtable Hash2 = new Hashtable(10);

            //Ngoài ra bạn cũng có thể khởi tạo 1 Hashtable chứa các phần tử được sao chép từ một Hashtable khác:
            Hashtable Hash3 = new Hashtable(Hash1);

            //Thêm giá trị vào Hashtable
            Hash1.Add("dog", "chó");
            Hash1.Add("cat", "mèo");
            Hash1.Add("fpoly", "FPT POLYTECHNIC");

            Hash2.Add(1, "Dũng");
            Hash2.Add(2, "Thụ");
            Hash2.Add(3, "Trang");

            //Cách lấy 1 phần tử ra
            Console.WriteLine("=============");
            Console.WriteLine(Hash1["fpoly"]);

            /* 
            * In các phần tử trong Hashtable.
            * Vì mỗi phần tử là 1 DictionaryEntry nên ta chỉ định kiểu dữ liệu cho item là DictionaryEntry luôn.
            * Thử in ra màn hình cặp Key - Value của mỗi phần tử được duyệt.
            */
            Console.WriteLine("=============");
            Console.WriteLine("\nHash1 Count: " + Hash1.Count);
            foreach (DictionaryEntry x in Hash1)
            {
                Console.WriteLine(x.Key + "\t" + x.Value);
            }

            Console.WriteLine("=============");
            Console.WriteLine("\nHash2 Count: " + Hash1.Count);
            foreach (DictionaryEntry x in Hash2)
            {
                Console.WriteLine(x.Key + "\t" + x.Value);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}
