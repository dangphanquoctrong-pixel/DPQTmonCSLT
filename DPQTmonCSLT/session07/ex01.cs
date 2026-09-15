using System;
using System.Collections.Generic;
using System.Text;

namespace DPQTmonCSLT.session07
{
    internal class ex01
    {
        public static int timMaxBaSo(int a, int b, int c)
        {
            int max = a;
            if (b>max) max = b;
            if (c>max) max = c;
            return max;
        }
        static long timGiaiThua(int n)
        {
            if (n == 0)
            {
                Console.WriteLine($"Giai thừa của {n} = 0");
                return 1;
            }
            else if (n < 0)
            {
                Console.WriteLine($"Không xác định được giai thừa của {n}");
                return -1;
            }
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập ba số để tìm số lớn nhất trong ba số đó: ");
            Console.Write("Nhập số đầu tiên: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            int c = int.Parse(Console.ReadLine());
            int ketQuaBai1 = timMaxBaSo(a, b, c);
            Console.WriteLine("Kết quả lớn nhất: " + ketQuaBai1);

            Console.Write("Nhập một số muốn tính giai thừa: ");
            int n = int.Parse(Console.ReadLine());
            long ketQuaBai2 = timGiaiThua(n);
            Console.Write($"Kết quả của phép tính {n}! = ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i < n)
                {
                    Console.Write("*");
                }
            }
            Console.Write("=" + ketQuaBai2);
        }
    }
}

