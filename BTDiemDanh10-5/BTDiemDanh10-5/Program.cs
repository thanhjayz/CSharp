using System;

namespace BTDiemDanh10_5
{
    class Program
    {
        public int []mang = new int[10];
        public void nhap()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("nhap phan tu thu " + i);
                mang[i] = int.Parse(Console.ReadLine());
                
            }
        }
        public void max()
        {
            int max;
            max = mang[0];
            for (int i = 1; i < 10; i++)
            {
                if (mang[i] > max)
                    max = mang[i];
            }
            Console.WriteLine("max = " + max);
        }
        public void min()
        {
            int min;
            min = mang[0];
            for (int i = 1; i < 10; i++)
            {
                if (mang[i] < min)
                    min = mang[i];
            }
            Console.WriteLine("min = " + min);
        }
        public void SapXepTang()
        {
            int[] mangtang = new int[10];
            mangtang = mang;
            for (int i = 0; i<10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                    if (mangtang[i] < mangtang[j])
                    {
                         int tg = mangtang[i];
                         mangtang[i] = mangtang[j];
                        mangtang[j] = tg;
                    } 
            }
        }
        public void SapXepGiam()
        {
            int[] manggiam = new int[10];
            manggiam = mang;
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                    if (manggiam[i] > manggiam[j])
                    {
                        int tg = manggiam[i];
                        manggiam[i] = manggiam[j];
                        manggiam[j] = tg;
                    }
            }
        }


        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
