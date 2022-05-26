using System;
using System.Collections.Generic;
using System.Text;

namespace BTCoBan1
{
    class Cau4
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap 3 canh cua tam giac:");
            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());
            if (a + b == c || a + c == b || b + c == a)
                Console.WriteLine("Day khong la 3 canh cua tam giac");
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                Console.WriteLine("Day la 3 canh cua tam giac vuong");
            else
                Console.WriteLine("Day la 3 canh cua tam giac thuong");
        }
    }
}
