using System;
using System.Collections.Generic;
using System.Text;

namespace BTMang
{
    class Bai63
    {
        static void Main(string[] args)
        {
            //cau a
            int n, count = 0;
            int[] mang;
            Random random = new Random();
            Console.WriteLine("Nhap n phan tu cua mang: ");
            n = Int32.Parse(Console.ReadLine());
            mang = new int[n + 1];
            for (int i = 1; i <= n; i++)
                mang[i] = random.Next(-101, 101);
            for (int i = 1; i <= n; i++)
                Console.Write(" | {0} | ", mang[i]);
            Console.Write("\n");
            //cau b
            foreach (var x in mang)
                if (x %10==6 && x%4 == 0)
                    count ++;
            Console.WriteLine("Co {0} phan tu chia het cho 4, tan cung 6", count);
            //cau c
            for (int i = 1; i <= n; i += 2)
                mang[i] *= 2;
            Console.WriteLine("Mang sau khi x2 phan tu le: ");
            for (int i = 1; i <= n; i++)
                Console.Write(" | {0} | ", mang[i]);
            Console.ReadKey();
        }
    }
}
