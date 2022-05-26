using System;

namespace BTCoBan1
{
    class Cau1
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap 1 so nguyen: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                Console.WriteLine("Day la so nguyen duong");
            }
            else
            {
                Console.WriteLine("Day la so nguyen am");
            }

        }
    }
}
