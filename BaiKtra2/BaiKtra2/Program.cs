using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKtra2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           
            Console.WriteLine("1) Nhập n gồm 3 chữ số và in ra cách đọc của n)");
            Console.WriteLine("2) Nhập 1 mảng n chữ số, in ra số chẵn, số lẻ");
            int x, kt = 0;
            while (kt == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("nhap lua chon: ");
                x = Int32.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            int so;
                            Console.WriteLine("nhập so: ");
                            so = Int32.Parse(Console.ReadLine());
                            bai1(so);
                            break;
                        }
                    case 2:
                        {
                            int n;
                            Console.WriteLine("nhập so phan tu cua mang: ");
                            n = Int32.Parse(Console.ReadLine());
                            int[] arr = new int[n+1];
                            for (int i =1; i<=n; i++)
                            {
                                Console.WriteLine("nhập phần tử thứ {0} : ", i);
                                arr[i] = Int32.Parse(Console.ReadLine());
                            }
                            bai2(n, arr);
                            break;
                        }
                    default:
                        Console.WriteLine("Nhap sai, nhap lai");
                        break;
                }
            }
            Console.ReadKey();
        }
        static void bai1(int so)
        {
            int x = 0;
            string a;
            while (so != 0)
            {
                x += (so % 10);
                x *= 10;
                so /= 10;
            }
            x /= 10;
            int y;
            while (x != 0)
            {
                y = x % 10;
                Console.Write(" " + docSo(y));
                if(x/10 >= 10)
                    Console.Write(" trăm");
                else if(x/10>0)
                    if(x%10 == 0)
                        Console.Write(" lẻ");
                else
                Console.Write(" mươi");
                x /= 10;
            }
        }
        static string docSo( int x)
        {
            string a;
            switch (x)
            {
                case 1:
                    {
                        return ("một");
                    }
                case 2:
                    {
                        return ("hai");
                    }
                case 3:
                    {
                        return ("ba");
                    }
                case 4:
                    {
                        return ("bốn");
                    }
                case 5:
                    {
                        return ("năm");
                    }
                case 6:
                    {
                        return ("sáu");
                    }
                case 7:
                    {
                        return ("bảy");
                    }
                case 8:
                    {
                        return ("tám");
                    }
                case 9:
                    {
                        return ("chín");
                    }
            }
            return ("");
        }
        static void bai2(int n, int[] arr)
        {
            Console.WriteLine("số chẵn của mảng: ");
            for(int i=1; i<=n; i++)
            {
                if(arr[i] % 2 ==0)
                    Console.Write(" | "+ arr[i]+" | ");
            }
            Console.WriteLine("");
            Console.WriteLine("số lẻ của mảng: ");
            for (int i = 1; i <= n; i++)
            {
                if (arr[i] % 2 != 0)
                    Console.Write(" | " + arr[i] + " | ");
            }
        }
    }
}
