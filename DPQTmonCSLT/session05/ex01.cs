using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DPQTmonCSLT.session05
{
    internal class ex01
    {
        static void Bai1()
        {
            for (int x = 2; x < 10; x++)

            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{x} * {y}={x * y}");
                }
                Console.WriteLine();
            }

        }

        static void Bai2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            double sum = 0;
            Console.WriteLine("Mời nhập mười số: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Số {i}: ");
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    sum += num;
                }
            }
            double average = sum / 10;
            Console.WriteLine("Tổng của mười số là: " + sum);
            Console.WriteLine("Trung bình cộng của mười số là: " + average);
        }
        static void Bai3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int number, i;
            Console.Write("Mời nhập một số để làm bảng cửu chương: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Bảng cửu chương {number}");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number}*{i}={number * i}");
            }
        }
        static void Bai4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("" + j);
                }
                Console.WriteLine();
            }
        }
        static void Bai5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số lượng số hạng (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            Console.Write("Chuỗi Harmonic: ");
            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write("1/" + i + " + ");
                }
                else
                {
                    Console.Write("1/" + i);
                }
                sum += 1.0 / i;
            }
            Console.WriteLine();
            Console.WriteLine("Tổng của " + n + " số hạng là: " + sum);
        }
        static void Bai6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập dãy số có dạng (a,b):");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            if (a >= b)
            {
                Console.WriteLine("Đây không phải là dãy số!");
            }
            Console.Write("Các số hoàn hảo trong khoảng từ a đến b là: ");
            for (double number = a; number <= b; number++)
            {
                double sum = 0;
                for (double i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == number && number > 0)
                {
                    Console.Write(" " + number);
                }
            }
        }
        static void Bai7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số muốn kiểm tra có phải số nguyên tố không: ");
            int number = int.Parse(Console.ReadLine());
            if (number <= 1)
            {
                Console.WriteLine($"Số {number} không phải là số nguyên tố");
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"Số {number} không phải là số nguyên tố");
                    break;
                }
                Console.WriteLine($"Số {number} là số nguyên tố");
            }
        }

            static void Main(string[] args)
            {
                Bai1();
                Bai2();
                Bai3();
                Bai4();
                Bai5();
                Bai6();
                Bai7();
            }
        }
    }




