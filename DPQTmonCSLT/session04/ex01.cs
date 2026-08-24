using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DPQTmonCSLT.session04
{
    internal class ex01
    {
        static void Bai1()
        {
            int so;
            Console.WriteLine("Nhập một số để kiểm tra số đó là số chẵn hay số lẻ: ");
            so = int.Parse(Console.ReadLine());
            if ((so / 2) == 0)
            {
                Console.WriteLine($"Số {so} là số chẵn");
            }
            else
            {
                Console.WriteLine($"Số {so} là số lẻ");
            }
            Console.ReadKey();
        }
             static void Main(string[] args)
            {
                Bai1();
            }
        
    }
}
