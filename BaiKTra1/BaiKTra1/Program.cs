using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKTra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1) Viết phương thức in ra tổng, hiệu, tích, thương của 2 số đc nhập vào bàn phím cho trước");
            Console.WriteLine("2) Viết phương thức In ra lá cờ Việt Nam bằng các dấu = và *");
            Console.WriteLine("3) Viết phương thức đổi số thập phân thành số nhị phân từ một số thập phân nhập vào từ bàn phím.");
            Console.WriteLine("4) Viết phương thức in ra các thông tin của bản thân(họ tên, lớp, mã sv)");
            Console.WriteLine("Viết chương trình gọi hết các phương thức trên.");
            int x57, kt57=0;
            while (kt57==0)
            {
                Console.WriteLine("nhap lua chon: ");
                x57 = Int32.Parse(Console.ReadLine());
                switch (x57)
                {
                    case 1:
                        {
                            Console.WriteLine("nhap a, b: ");
                            int a57, b57;
                            a57 = Int32.Parse(Console.ReadLine());
                            b57 = Int32.Parse(Console.ReadLine());
                            bai1(a57, b57);
                            break;
                        }
                    case 2:
                        bai2();
                        break;
                    case 3:
                        int so57;
                        Console.WriteLine("nhap so can chuyen: ");
                        so57 = Int32.Parse(Console.ReadLine());
                        bai3(so57);
                        break;
                    case 4:
                        string ten57, lop57, masv57;
                        Console.WriteLine("Nhap ten: ");
                        ten57 = Console.ReadLine();
                        Console.WriteLine("Nhap lop: ");
                        lop57 = Console.ReadLine();
                        Console.WriteLine("Nhap ten: ");
                        masv57  = Console.ReadLine();
                        bai4(ten57, lop57, masv57);
                        break;
                    default:
                        Console.WriteLine("Nhap sai, nhap lai");
                        break;
                }
            }
            Console.ReadKey();
        }
        static void bai1(int a57, int b57)
        {
            Console.WriteLine("tong = " + (a57 + b57));
            Console.WriteLine("hieu = " + (a57 - b57));
            Console.WriteLine("tich = " + a57 * b57);
            Console.WriteLine("thuong = " + a57 / b57);
        }
        static void bai2()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("          *           *");
            Console.WriteLine("        *****         *");
            Console.WriteLine(" *******************  *");
            Console.WriteLine("     ***********      *");
            Console.WriteLine("      *********       *");
            Console.WriteLine("     ***** *****      *");
            Console.WriteLine("    ***       ***     *");
            Console.WriteLine("    *           *     *");
            Console.WriteLine("=======================");
        }
        static void bai3(int so57)
        {
            int[] Array57 = new int[50];
            for (int i = 0; so57 > 0; i++)
            {
                //chia lấy dư và lấy nguyên sau đó lưu vào mảng
                Array57[i] = so57 % 2;
                so57 = so57 / 2;
            }
            for (int i = 1; i <= Array57.Length; i++)
            {
                Console.Write(Array57[i-1].ToString());
            }
            Console.Write("\n");
        }
        static void bai4(string ten57, string lop57, string masv57)
        {
            Console.WriteLine("ho ten: "+ten57);
            Console.WriteLine("lop: " + lop57);
            Console.WriteLine("masv: " + masv57);
        }
    } 

}
