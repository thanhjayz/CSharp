using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai19
    //Nhập vào thời điểm1 và thời điểm2. Tìm thời gian trải qua giữa hai thời điểmnày tính bằng giờ, phút, giây.
    {
        static void Main(string[] args)
        {
            int h1, p1, s1, h2, p2, s2, h3, p3, s3, s;
            Console.WriteLine("Nhap thoi diem 1: gio - phut - giay");
            h1 = Int32.Parse(Console.ReadLine());
            p1 = Int32.Parse(Console.ReadLine());
            s1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi diem 2: gio - phut - giay");
            h2 = Int32.Parse(Console.ReadLine());
            p2 = Int32.Parse(Console.ReadLine());
            s2 = Int32.Parse(Console.ReadLine());

            s =  (h2 * 3600 + p2 * 60 + s2) - (h1 * 3600 + p1 * 60 + s1);
            if (h2 < h1)
                s = 12 * 60 * 60 - s;
            h3 = s / 3600;
            s %= 3600;
            p3 = s / 60;
            s %= 60;
            s3 = s;
            Console.WriteLine("Hieu thoi gian = {0} gio,{1} phut,{2} giay", h3, p3, s3);
            Console.ReadKey();

        }
    }
}
