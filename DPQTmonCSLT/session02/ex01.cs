using System;
using System.Collections.Generic;
using System.Text;

namespace DPQTmonCSLT.session02
{
    internal class ex01
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            float a, b;
            //1.to Add / Sum Two Numbers.
            Console.WriteLine("Câu 1: Bài tập tính tổng 2 số");
            Console.WriteLine("Mời bạn nhập số a:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số b:");
            b = float.Parse(Console.ReadLine());
            float Tong = a + b;
            Console.WriteLine("Tổng hai số a và b là: {0} ", Tong);

            //2.to Swap Values of Two Variables.
            Console.WriteLine("Câu 2: Bài tập hoán đổi ví trí hai số");
            Console.WriteLine($"Trước khi bị hoán đổi: a = {a}, b = {b}");
            (a, b) = (b, a);
            Console.WriteLine($"Sau khi bị hoán đổi: a = {a}, b = {b} ");

            //3.to Multiply two Floating Point Numbers
            Console.WriteLine("Câu 3: Bài tập nhân hai số (có thập phân)");
            float Tich = a * b;
            Console.WriteLine($"Tích của hai số a và b = {Tich}");

            //4.to convert feet to meter 
            float Meet;
            float Feet;
            Console.WriteLine("Nhập chiều dài mét mà bạn muốn đổi sang feet: ");
            Meet = float.Parse(Console.ReadLine());
            Feet = (float)(Meet * 3.28);
            Console.WriteLine($"Kết quả sau khi đổi:{Feet}");

            //5.to convert Celsius to Fahrenheit and vice versa
            float doC;
            float doF;
            Console.WriteLine("Câu 5: Chuyển đổi độ C sang độ F");
            Console.WriteLine("Nhập nhiệt độ là độ C mà bạn muốn chuyển sang độ F:");
            doC = float.Parse(Console.ReadLine());
            doF = (float)(doC * 1.8) + 32;
            Console.WriteLine($"Kết quả sau khi chuyển đổi từ độ C sang độ F: {doF}");

            //6.to find the Size of data types
            Console.WriteLine("Kích thước của các kiểu dữ liệu trong C#:");

            Console.WriteLine($"Kích thước của bool:    {sizeof(bool)} byte");
            Console.WriteLine($"Kích thước của byte:    {sizeof(byte)} byte");
            Console.WriteLine($"Kích thước của char:    {sizeof(char)} byte");
            Console.WriteLine($"Kích thước của short:   {sizeof(short)} byte");
            Console.WriteLine($"Kích thước của int:     {sizeof(int)} byte");
            Console.WriteLine($"Kích thước của long:    {sizeof(long)} byte");
            Console.WriteLine($"Kích thước của float:   {sizeof(float)} byte");
            Console.WriteLine($"Kích thước của double:  {sizeof(double)} byte");
            Console.WriteLine($"Kích thước của decimal: {sizeof(decimal)} byte");

            //7.to Print ASCII Value(tip: read character, print number of this char)
            Console.Write("Nhập một ký tự: ");
            char kyTu = char.Parse(Console.ReadLine());
            int asciiValue = (int)kyTu;
            Console.WriteLine("Kết qủa là: " + asciiValue);
            //8.to Calculate Area of Circle
            float r, sTron;
            const float PI = 3.14f;
            Console.WriteLine("Nhập bán kính hình tròn: ");
            r = float.Parse(Console.ReadLine());
            sTron = (float)(r * r) * PI;
            Console.WriteLine("Diện tích hình tròn là: s = PI * r^2 = " + sTron);
            //9.to Calculate Area of Square
            float cVuong, sVuong;
            Console.WriteLine("Nhập chiều dài cạnh hình vuông:");
            cVuong = float.Parse(Console.ReadLine());
            sVuong = (float)cVuong * cVuong;
            Console.WriteLine("Diện tích hình vuông là: s = cạnh * cạnh = " + sVuong);
            //10.to convert days to years, weeks and days
            short day;
            int year, month, day1;
            Console.WriteLine("Nhập số ngày bạn muốn quy đổi: ");
            day = short.Parse(Console.ReadLine());
            year = (int)day / 365;
            month = (int)(day - (year * 365)) / 30;
            day1 = (int)(day - (year * 365) - (month * 30));
            Console.WriteLine($"Giả sử bạn có {day} ngày thì bạn có {year} năm, {month} tháng, {day1} ngày");
            Console.ReadKey();
        }
    }
}