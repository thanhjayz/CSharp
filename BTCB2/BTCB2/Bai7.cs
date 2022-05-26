using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai7
    {
        //giai phuong trinh bac 1
        static void Main(string[] args)
        {
            int a, b;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            if (a == 0 && b == 0 || a != 0 && b == 0)
                Console.WriteLine("phuong trinh vo so nghiem");
            else if (a == 0 && b != 0)
                Console.WriteLine("phuong trinh vo nghiem");
            else
                Console.WriteLine("phuong trinh co nghiem = " + -b * 1.0 / a);
        }
    }
}
