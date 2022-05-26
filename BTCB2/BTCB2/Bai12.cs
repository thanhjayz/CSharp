using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai12
    {
        //Giai he phuong trinh 2 an
        static void Main(string[] args)
        {
            int a1, b1, c1, a2, b2, c2, d, dx, dy;
            Console.WriteLine("Nhap a1, b1, c1: ");
            a1 = Int32.Parse(Console.ReadLine());
            b1 = Int32.Parse(Console.ReadLine());
            c1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap a2, b2, c2: ");
            a2 = Int32.Parse(Console.ReadLine());
            b2 = Int32.Parse(Console.ReadLine());
            c2 = Int32.Parse(Console.ReadLine());
            d = a1 * b2 - a2 * b1;
            dx = b1 * c2 - b2 * c1;
            dy = a1 * c2 - a2 * c1;
            if (d == 0)
            {
                if(dx == dy && dx == d && d==0)
                    Console.WriteLine("pt co vo so nghiem");
                else
                    Console.WriteLine("pt vo nghiem");
            }
            else
            {
                Console.WriteLine("pt co nghiem duy nhat x = {0} ,y = {1}", dx*1.0/d, dy*1.0/d); 
            }
            Console.ReadKey();

        }
    }
}
