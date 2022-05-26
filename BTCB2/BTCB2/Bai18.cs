using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai18
    {
        //Viết chương trình nhập vào số giờ, xuất ra số tương đương tính theo tuần, theo ngày và theo giờ.
        static void Main(string[] args)
        {
            int s, t=0, n=0, h=0;
            Console.WriteLine("Nhap vao so gio: ");
            s = Int32.Parse(Console.ReadLine());
            if (s > 24 * 7)
            {
                t = s / (24 * 7);
                s %= (24 * 7);
            }
            if (s > 24)
            {
                n = s / 24;
                s %= 24;
            }
            h = s;
            Console.WriteLine("{0} tuan, {1} ngay, {2} gio", t, n, h);
            Console.ReadKey();
        }
    }
}
