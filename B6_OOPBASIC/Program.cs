using System;

namespace B6_OOPBASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            NguoiYeuMoiService nym = new NguoiYeuMoiService();
            do
            {
                nym.themNY();
                nym.inDs();
            } while (true);
        }
    }
}
