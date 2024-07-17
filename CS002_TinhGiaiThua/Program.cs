using System;
namespace CS002_TinhGiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.OutputEncoding =  System.Text.Encoding.UTF8;    
            Console.WriteLine("Chương trình tính giai thừa của một số");
            int a;
            Console.WriteLine("Nhập số: ");a = Convert.ToInt32(Console.ReadLine());
            TinhGT(a);
        }
        static void TinhGT(int a)
        {
            int ketqua = 1;
            for (int i = 1; i <= a; i++)
            {
                ketqua *= i;
            }
            Console.WriteLine(ketqua);
        }
    }
}
