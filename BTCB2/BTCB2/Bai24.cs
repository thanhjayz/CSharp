using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai24
    {
        

        static void Main(string[] args)
        {
            int x, x1, d=0, s, e, tg=0, nd=0;
            Console.WriteLine("Nhap 1 so tu nhien: ");
            x = Int32.Parse(Console.ReadLine());
            x1 = x;
            e = x % 10;
            while (x != 0)
            {
                tg += x % 10;
                nd += x % 10;
                nd *= 10;
                x /= 10;
                d++;
            }
            nd /= 10;
            s = nd % 10;
            Console.WriteLine("{0} co {1} chu so", x1, d);
            Console.WriteLine("chu so cuoi cung la: "+e);
            Console.WriteLine("chu so dau tien la: " + s);
            Console.WriteLine("tong cac chu so la: " + tg);
            Console.WriteLine("so dao nguoc la: " + nd);
            Console.ReadKey();





        }
    } 

}
