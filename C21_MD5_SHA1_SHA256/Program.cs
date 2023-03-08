using System;
using System.Security.Cryptography;

namespace C21_MD5_SHA1_SHA256
{
    #region Hashing algorithm - Thuật toán băm
    /*
     - MD5 là được sử dụng để chuyển đổi một chuỗi dữ liệu bất kỳ thành một giá trị băm cố định độ dài 128 bit
     - SHA-1 tạo ra giá trị băm có độ dài 160 bit
     - SHA-256 tạo ra giá trị băm có độ dài 256 bit

    - 3 thằng trên đều là hệ mã hóa một chiều , nghĩa là chúng chỉ có thể mã hóa giá trị đầu vào thành một giá trị băm duy nhất, và không thể giải mã giá trị băm để lấy lại giá trị đầu vào ban đầu
     */
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            // Chuỗi cần băm
            string input = "Hung2001!@";

            #region MD5
                // Tạo đối tượng MD5
                MD5 md5 = MD5.Create();

                // Chuyển đổi chuỗi thành mảng byte
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

                // Tính toán giá trị băm
                byte[] hash = md5.ComputeHash(inputBytes);

                // Chuyển đổi giá trị băm từ dạng byte sang dạng chuỗi hexa
                string hashString = BitConverter.ToString(hash).Replace("-", "");

                Console.WriteLine(hashString); //Kết quả: 823C890F41971D0B81CB0DF71C1B45C7
            #endregion

            #region SHA-1
                // Tạo đối tượng SHA1
                SHA1 sha1 = SHA1.Create();

                // Chuyển đổi chuỗi thành mảng byte
                byte[] inputBytes1 = System.Text.Encoding.ASCII.GetBytes(input);

                // Tính toán giá trị băm
                byte[] hash1 = sha1.ComputeHash(inputBytes1);

                // Chuyển đổi giá trị băm từ dạng byte sang dạng chuỗi hexa
                string hashString1 = BitConverter.ToString(hash1).Replace("-", "").ToLower();

                Console.WriteLine(hashString1); // kết quả: 533282378510d840ab62ee8e83d1c3046435ff24
            #endregion

            #region SHA-256
                // Tạo đối tượng SHA256
                SHA256 sha256 = SHA256.Create();

                // Chuyển đổi chuỗi thành mảng byte
                byte[] inputBytes2 = System.Text.Encoding.ASCII.GetBytes(input);

                // Tính toán giá trị băm
                byte[] hash2 = sha256.ComputeHash(inputBytes2);

                // Chuyển đổi giá trị băm từ dạng byte sang dạng chuỗi hexa
                string hashString2 = BitConverter.ToString(hash2).Replace("-", "").ToLower();

                Console.WriteLine(hashString2); // kết quả: 4e26388d399d3717391852df64d8666380b03f7a002f36d429110444b6f9396a
            #endregion

        }
    }
}
