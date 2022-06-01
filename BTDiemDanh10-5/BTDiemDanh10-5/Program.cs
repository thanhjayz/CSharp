using System;

namespace BTDiemDanh10_5
{
    class Program
    {
        public int[] mang = new int[11];
        public void nhap()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("nhap phan tu thu " + i);
                mang[i] = int.Parse(Console.ReadLine());
            }
            xuat(mang);
        }
        public void max()
        {
            int max;
            max = mang[1];
            for (int i = 1; i <= 10; i++)
            {
                if (mang[i] > max)
                    max = mang[i];
            }
            Console.Write("\n max = " + max);
        }
        public void min()
        {
            int min;
            min = mang[1];
            for (int i = 1; i <= 10; i++)
            {
                if (mang[i] < min)
                    min = mang[i];
            }
            Console.Write("\n min = " + min);
        }
        public void XuatHienNhieu()
        {
            int count1 = 0, count2 = 0, vitri=1;
            for (int i = 1; i <= 10; i++)
            {
                if (count1 > count2)
                {
                    count2 = count1;
                    vitri = i;
                }
                count1 = 0;
                for (int j = 1; j <= 10; j++)
                    if (mang[i] == mang[j])
                        count1++;
                count1--;
            }
            Console.Write("\n Gia tri xuat hien nhieu nhat  = {0}", mang[vitri]);
        }
            public void SapXepGiam()
        {
            int[] manggiam = new int[11];
            manggiam = mang;
            for (int i = 1; i< 10; i++)
            {
                for (int j = i + 1; j <= 10; j++)
                    if (manggiam[i] < manggiam[j])
                    {
                         int tg = manggiam[i];
                        manggiam[i] = manggiam[j];
                        manggiam[j] = tg;
                    } 
            }
            Console.Write("\n Mang giam dan: ");
            xuat(manggiam);
        }
        public void SapXepTang()
        {
            int[] mangtang = new int[10];
            mangtang = mang;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j <= 10; j++)
                    if (mangtang[i] > mangtang[j])
                    {
                        int tg = mangtang[i];
                        mangtang[i] = mangtang[j];
                        mangtang[j] = tg;
                    }
            }
            Console.Write("\n Mang tang dan: ");
            xuat(mangtang);
        }
        public void xuat(int[] mang)
        {
            for (int i = 1; i <= 10; i++)
                Console.Write(" | {0} | ", mang[i]);
        }

        static void Main(string[] args)
        {
            Program bt = new Program();
            bt.nhap();
            bt.min();
            bt.max();
            bt.XuatHienNhieu();
            bt.SapXepGiam();
            bt.SapXepTang();
            Console.ReadKey();
        }
    }
}
