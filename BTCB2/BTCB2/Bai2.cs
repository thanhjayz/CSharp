using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai2
        
    {
        //Nhập vào tọa độ 2 điểm A(xA, yA)và B(xB, yB). Tính khoảng cách AB.
        static void Main(string[] args)
        {

            int xa, ya, xb, yb;
            double d;
            Console.WriteLine("Nhap toa do diem A");
            xa = Int32.Parse(Console.ReadLine());
            ya = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhap toa do diem A");
            xb = Int32.Parse(Console.ReadLine());
            yb = Int32.Parse(Console.ReadLine());

            d = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2));
            d = Math.Abs(d);
            Console.WriteLine("khoang cac AB = "+d);
            Console.ReadKey();
        }
    } 
}
