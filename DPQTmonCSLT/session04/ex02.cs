using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DPQTmonCSLT.session04
{
    internal class ex02
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            double a, b, c, delta;
            
            Console.WriteLine("Bài tập giải phương trình bậc 2");
            Console.WriteLine("Phương trình bậc 2 có dạng ax^2+bx+c=0 ");
            Console.Write("Mời bạn nhập số a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập số b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập số c: ");
            c = double.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            if (a==0  && b==0 && c==0)
            {
                Console.WriteLine("Phương trình có vô số nghiệm!");
                return;
            }
            if (a==0)
            {
                double x1 = - c / b;
                Console.WriteLine($"Phương trình có nghiệm duy nhất x = {x1}");
                return;
            }
            if (a==0&&b==0&&c!=0)
            {
                Console.WriteLine("Phương trình vô nghiệm!");
                return;
            }
            if (a==0&&b!=0&&c==0)
            {
                Console.WriteLine("Phương trình có nghiệm duy nhất x = 0");
                return;
            }
            if (delta <0)
            {
                Console.WriteLine("Phương trình vô nghiệm!");
                return;
            }
            if (delta>0)
            {
                double x1 = (-b + Math.Cbrt(delta))/2*a;
                double x2 = (-b - Math.Cbrt(delta))/2*a;
                Console.WriteLine($"Phương trình có hai nghiêm phân biệt: x1 = {x1} và x2 = {x2} ");
                return;
            }
            if (delta==0)
            {
                double x = -b/2*a;
                Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = {x} ");
            }
            Console.ReadKey();

        }
    }
}
