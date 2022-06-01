using System;
using System.Collections.Generic;
using System.Text;

namespace BTDiemDanh26_4
{
    class PTBac2
    {
        private int a, b, c;

        public PTBac2()
        {
        }
        public PTBac2(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public int delta()
        {
            return b * b - 4 * a * c;
        }
        public void nghiem()
        {
            int d = delta();
            Console.WriteLine("delta = {0}", d);
            if(d<0)
                Console.WriteLine("pt vo nghiem");
            else if(d==0)
                Console.WriteLine($"pt co 1 nghiem duy nhat x = {(-b*1.0/(2*a))}");
            else
                Console.WriteLine($"pt co 2 nghiem phan biet x1 = {((-b + Math.Sqrt(d*1.0)) / (2 * a))}, x2 = {((-b - Math.Sqrt(d * 1.0)) / (2 * a))}");
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        static void Main(string[] args)
        {
            PTBac2 pt257 = new PTBac2(2, -7, 3);
            pt257.nghiem();
            Console.ReadKey();
        }
    }
}
