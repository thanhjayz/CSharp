using System;
using System.Collections.Generic;
using System.Text;

namespace BTCoBan1
{
    class Cau2
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap 1 so nguyen: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
                case 10:
                    Console.WriteLine("Muoi");
                    break;
                default:
                    Console.WriteLine("So khong hop le");
                    break;
            }
        }
    }
}
