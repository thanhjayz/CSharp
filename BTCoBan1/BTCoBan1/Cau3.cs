using System;
using System.Collections.Generic;
using System.Text;

namespace BTCoBan1
{
    class Cau3
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap 3 canh cua tam giac:");
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());
            if (a + b == c || a + c == b || b + c == a)
            {
                Console.WriteLine("Day khong la 3 canh cua tam giac");
            }
            else
            {
                Console.WriteLine("Day la 3 canh cua tam giac");
            }

        }
    }
}
