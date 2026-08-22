using System;
using System.Collections.Generic;
using System.Text;

namespace DPQTmonCSLT.session03
{
    internal class ex01
    {
        static void Cau1()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            float doC, doF, doK;
            Console.Write("Nhập độ C mà bạn muốn đổi sang độ F và độ K: ");
            doC = float.Parse(Console.ReadLine());

            doK = (doC + 273f);
            doF = (doC * 1.8f) + 32f;

            Console.WriteLine($"Chuyển từ độ C sang độ F: {doF:F0}");
            Console.WriteLine($"Chuyển từ độ C sang độ K: {doK:F0}");
            Console.ReadKey();
        }
        static void Cau2()
        {
            Console.WriteLine("Câu 2: Tính diện tính mặt cầu và thể tích hình cầu:");
            double r, sCau, vCau;
            Console.Write("Nhập bán kính: ");
            r = double.Parse(Console.ReadLine());
            sCau = 4 * Math.PI * r * r;
            vCau = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"Diện tích mặt cầu là:{sCau:F2}");
            Console.WriteLine($"Thể tích hình cầu là:{vCau:F2} ");
            Console.ReadKey();
        }
        static void Cau3()
        {
            Console.WriteLine("Câu 3: Thực  hiện các phép tính");
            int a, b, tong, hieu, tich, thuong, mod;
            Console.Write("Nhập số a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b:");
            b = int.Parse(Console.ReadLine());
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = a / b;
            mod = a % b;
            Console.WriteLine("Kết quả của các phép tính: ");
            Console.WriteLine("a+b= " + tong);
            Console.WriteLine("a-b= " + hieu);
            Console.WriteLine("a*b= " + tich);
            Console.WriteLine("a/b= " + thuong);
            Console.WriteLine("a%b= " + mod);
            Console.ReadKey();
        }
            static void Main(string[] args)
            {
            Cau1();
            Cau2();
            Cau3();
            }
    }
}