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
        }
        public void SapXepGiam()
        {
            int[] mangtang = new int[10];
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
