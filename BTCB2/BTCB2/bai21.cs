using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class bai21
    {
        static void Main(string[] args)
        {
            float a, b, c, dt, dc, tg;
            string kv;
            Console.WriteLine("nhap diem chuan: ");
            dc = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem 3 mon: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem khu vuc: ");
            kv = Console.ReadLine();
            Console.WriteLine("nhap diem doi tuong: ");
            dt = float.Parse(Console.ReadLine());
            tg = a + b + c;
            if (kv == "A")
                tg += 2f;
            if (kv == "B")
                tg += 1f;
            if (kv == "C")
                tg += 0.5f;
            if (dt == 1)
                tg += 2.5f;
            if (dt == 2)
                tg += 1.5f;
            if (dt == 3)
                tg += 1f;
            if(tg>=dc && a!=0 && b!=0 && c != 0)
            
                Console.WriteLine("Dau [{0}]", tg);

            else
                Console.WriteLine("Rot [{0}]", tg);
            Console.ReadKey();

        }
    }
}
