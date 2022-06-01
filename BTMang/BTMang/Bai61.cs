using System;

namespace BTMang
{
    class Bai61
    {
        static void Main(string[] args)
        {
            //cau a
            int n, p, tong=0;
            int[] mang;
            Random random = new Random();
            Console.WriteLine("Nhap n phan tu cua mang: ");
            n = Int32.Parse(Console.ReadLine());
            mang = new int[n+1];
            for (int i =1; i<=n; i++)
                mang[i] = random.Next(-101, 101);
            for (int i = 1; i <= n; i++)
                Console.Write(" | {0} | ", mang[i]);
            Console.Write("\n");
            //cau b
            foreach (var x in mang)
                if (x >= 0)
                    tong += x;
            Console.WriteLine("Tong cac so nguyen duong co trong mang = {0}", tong);
            //cau c
            Console.WriteLine("Nhap vi tri phan tu muon xoa: ");
            p = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
                if (i >= p)
                    mang[i] = mang[i + 1];
            for (int i = 1; i <= n-1; i++)
                Console.Write(" | {0} | ", mang[i]);
            Console.ReadKey();
        }
    }
}
