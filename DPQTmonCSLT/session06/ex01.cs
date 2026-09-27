using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Text;

namespace DPQTmonCSLT.session06
{
    internal class ex01
    {
        public static int timMaxBaSo(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static long timGiaiThua(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"Không xác định được giai thừa của {n}");
                return -1;
            }
            if (n == 0)
            {
                Console.WriteLine($"Giai thừa của {n} = 1");
                return 1;
            }
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }
        public static void timSoNguyenTo(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Đây không phải là số nguyên tố!");
                return;
            }
            bool laNguyenTo = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    laNguyenTo = false;
                    break;
                }
            }
            if (laNguyenTo)
            {
                Console.WriteLine($"Số {n} là số nguyên tố!");
            }
            else
            {
                Console.WriteLine($"Số {n} không là số nguyên tố!");
            }
        }
        public static void inDaySo(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Không có dãy số nguyên tố!");
            }
        }
        public static bool Isprime (int n1)
        {
            //if (n1 < 2) return false;
            for (int i = 2; i<= n1 / 2; i++)
            {
                if (n1 % i == 0) return false;
            }
            return true;
        }
        public static void timNguyenTonhoHon1So(int n2)
        {
            for (int i = 2;i <n2;i++)
            {
                if (Isprime(i))
                {
                    Console.Write(i + ",");
                }
            }
            Console.WriteLine();
        }
        public static void timNsoNguyenTo(int n3)
        {
            int count = 0;
            int currentNumber = 2;
            while (count < n3)
            {
                if (Isprime(currentNumber))
                {
                    Console.Write(currentNumber + ",");
                    count++;
                }
                currentNumber++;
            }
            Console.WriteLine();

        }
        public static bool  kiemTraSoHoanHao(int n)
        {
            if (n<2)
            {
                return false;
            }
            int tonguoc = 1;
         
            for (int i=2; i<=n/2 ; i++)
            {
                
                if (n%i==0)
                {
                    tonguoc += i;
                }
            }
           return tonguoc==n;
           
        
        }
        public static string soHoanHaoNhoHon1000(int n)
        {
            string ketQua = "";

            for (int i=1; i<n;i++)
            {
                if (kiemTraSoHoanHao(i))
                {
                    ketQua += i+ " ";
                }
            }
            return ketQua.Trim();
        }
        public static bool KiemTraPangram(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length <26) return false;
            str = str.ToLower();
            return "abcdefghijklmnopqrstuvwxyz".All(c => str.Contains(c));
        }
        static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
            //Console.WriteLine("Bài 1; ");
            //Console.WriteLine("Nhập ba số để tìm số lớn nhất trong ba số đó: ");
            //Console.Write("Nhập số đầu tiên: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Nhập số thứ hai: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Nhập số thứ ba: ");
            //int c = int.Parse(Console.ReadLine());
            //int ketQuaBai1 = timMaxBaSo(a, b, c);
            //Console.WriteLine("Kết quả lớn nhất: " + ketQuaBai1);


            //Console.WriteLine("Bài 2:");
            //Console.Write("Nhập một số muốn tính giai thừa: ");
            //int n = int.Parse(Console.ReadLine());
            //long ketQuaBai2 = timGiaiThua(n);
            //if (n > 0)
            //{
            //    Console.Write($"Kết quả của phép tính {n}! = ");
            //    for (int i = 1; i <= n; i++)
            //    {
            //        Console.Write(i);
            //        if (i < n)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine("=" + ketQuaBai2);
            //}



            //Console.WriteLine("Bài 3: ");
            //Console.Write("Nhập số muốn kiểm tra có phải là số nguyên tố hay không: ");
            //int number = int.Parse(Console.ReadLine());
            //timSoNguyenTo(number);
            //Console.Write("Nhập 1 số để in ra một dãy số nguyên tố nhỏ hơn số đó và in ra N số nguyên tố từ số đó:  ");
            //int so  = int.Parse(Console.ReadLine());
            //inDaySo(so
            //


            //Console.WriteLine("Bài 4.1:");
            //Console.WriteLine("Tìm tất các các số nguyên tố nhỏ hơn 1 số nhập từ bàn phím:");
            //Console.Write("Mời bạn nhập số: ");
            //int so1bai4 = int.Parse(Console.ReadLine());
            //Console.Write($"Những số nguyên tố nhỏ hơn {so1bai4} là: ");
            //timNguyenTonhoHon1So(so1bai4);



            //Console.WriteLine("Bài 4.2: ");
            //Console.WriteLine("Tìm n số nguyên tố đầu tiên: ");
            //Console.Write("Mời bạn nhập số n: ");
            //int so2Bai4 = int.Parse(Console.ReadLine());
            //Console.Write($"{so2Bai4} số nguyên tố đầu tiên là: ");
            //timNsoNguyenTo(so2Bai4);


            //Console.WriteLine("Bài 5: ");
            //Console.WriteLine("Kiểm tra một số có phải là số hoàn hảo hay không và in ra tất cả các số hoàn hảo nhỏ hơn 1000: ");
            //Console.Write("Mời bạn nhập một số: ");
            //int so1bai5 = int.Parse(Console.ReadLine());
            //bool kiemtra = kiemTraSoHoanHao(so1bai5);

            //if (kiemtra == true)
            //{
            //    Console.WriteLine($"Số {so1bai5} là số hoàn hảo!");
            //}
            //if (kiemtra == false)
            //{
            //    Console.WriteLine($"Số {so1bai5} không là số hoàn hảo!");
            //}
            //string danhSachSoHoanHao = soHoanHaoNhoHon1000(1000);
            //Console.WriteLine($"Các số hoàn hảo nhỏ hơn 1000 là: {danhSachSoHoanHao} ");


            Console.WriteLine("Bài 6: ");
            Console.WriteLine("6. Viết hàm C# để kiểm tra xem một chuỗi có phải là pangram hay không: ");
            Console.Write("Mời bạn nhập câu: ");
            string cau = Console.ReadLine();
            if (KiemTraPangram(cau))
            {
                Console.WriteLine("Câu bạn vừa mới nhập là câu hoàn hảo!");
            }
            else
            {
                Console.WriteLine("Câu bạn vừa mới nhập không là câu hoàn hảo!");
            }
        }
       
    }
}

