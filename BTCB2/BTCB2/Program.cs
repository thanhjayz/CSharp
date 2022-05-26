using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Program
    {
        static void Main(string[] args)
        {
            const Double pi = 3.14;
            Double r, s, v;
            //Nhập vào diện tích S của một mặt cầu. Tính thể tích V của hình cầu này
            Console.WriteLine("nhap dien tich mat cau: ");
            s = Double.Parse(Console.ReadLine());
            r = Math.Sqrt(s / (4 * pi));
            v = s * r / 3;
            Console.WriteLine("the tich mat cau = "+v);
            Console.ReadKey();
        }
    }
}
