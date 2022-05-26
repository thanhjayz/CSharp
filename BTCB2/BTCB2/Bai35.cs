using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCB2
{
    class Bai35
    {
        public static int kiemtra(int n)
        {
            for(int i=2; i<=n; i++)
            {
                if (n % i == 0)
                    //day khong la so nto
                    return 0;
            }
            //day la so nguyen to
            return 1;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = Int32.Parse(Console.ReadLine());
            ;
            if(kiemtra(n)==1)
                Console.WriteLine("{0} la so nguyen to", n);
            else
            {
                Console.WriteLine("{0} khong la so nguyen to", n);
                for (int i=n; i>0; i--) { 
                    if (kiemtra(i) == 1)
                    {
                        Console.WriteLine("{0} la so nguyen to gan n nhat va be hon n", i);
                        break;
                    }
                }
            }
            Console.ReadKey();
        }

    } 
}
