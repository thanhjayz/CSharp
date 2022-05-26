using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai8
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d, x1, x2;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = Int32.Parse(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (d == 0)
                Console.WriteLine("phuong trinh co nghiem kep = " + (-b * 1.0 / (2 * a)));
            else {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("phuong trinh co 2 nghiem phan biet x1 = {0}, x2 = {1}", x1, x2);
            }
            Console.ReadKey();
        }
    } 
}
