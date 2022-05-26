using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai20
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhậpsốkW điện đã tiêu thụ. Tính tiền điện phải trả
            int kw, t=0;
            Console.WriteLine("Nhap so kw dien tieu thu: ");
            kw = Int32.Parse(Console.ReadLine());
            t = kw * 500;
            if (kw >= 100)
                t += (kw - 99) * 300;
            if (kw >= 250)
                t += (kw - 249) * 200;
            if (kw >= 350)
                t += (kw - 349) * 500;
            Console.WriteLine("tong tien dien = "+t);
            Console.ReadKey();
        }
    } 
}
