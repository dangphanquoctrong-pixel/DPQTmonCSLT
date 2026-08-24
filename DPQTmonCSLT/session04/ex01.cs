using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace DPQTmonCSLT.session04
{
    internal class ex01
    {
        static void Bai1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            int so;
            Console.WriteLine("Câu 1:");
            Console.Write("Nhập một số để kiểm tra số đó là số chẵn hay số lẻ: ");
            so = int.Parse(Console.ReadLine());
            if ((so%2) == 0)
            {
                Console.WriteLine($"Số {so} là số chẵn");
            }
            else
            {
                Console.WriteLine($"Số {so} là số lẻ");
            }
            Console.ReadKey();
        }
        static void Bai2()
        {
            Console.WriteLine("Câu 2:");
            Console.WriteLine("Nhập 3 số và tìm số lớn nhất trong 3 số: ");
            Console.Write("Nhập số thứ nhất: ");
            float so1 = float .Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            float so2 = float.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba: ");
            float so3 = float.Parse(Console.ReadLine());
             float soLonnhat = Math.Max(Math.Max(so1,so2), so3);
            Console.WriteLine($"Số lớn nhất trong 3 số {so1},{so2},{so3} là: {soLonnhat}");
            Console.ReadKey();

        }
        static void Bai3()
        {
            double diemx, diemy;
            Console.WriteLine("Câu 3: Viết chương trình C# nhập vào tọa độ của một điểm trong " +
                               "hệ tọa đọ XY và xác định điểm đó nằm ở góc phần tư nào ");
            Console.Write("Mời nhập vào tọa độ điểm x: ");
            diemx = double.Parse(Console.ReadLine());
            Console.Write("Mời nhập vào tọa độ điểm y: ");
            diemy = double.Parse(Console.ReadLine());
            if (diemx == 0 || diemy == 0)
            {
                Console.WriteLine(" Điểm đó không nằm trong bốn góc phần từ nào mà chỉ nằm trên trục tọa độ!");
            }
            else if (diemx > 0 && diemy > 0)
            {
                Console.WriteLine($"Điểm ({diemx},{diemy}) nằm ở góc trên bên phải!");
            }
            else if (diemx < 0 && diemy < 0)
            {
                Console.WriteLine($"Điểm ({diemx},{diemy}) nằm ở góc dưới bên trái!");
            }
            else if (diemx < 0 && diemy > 0)
            {
                Console.WriteLine($"Điếm ({diemx},{diemy}) nằm ở góc trên bên trái!");
            }
            else if (diemx > 0 && diemy < 0)
            {
                Console.WriteLine($"Điểm ({diemx},{diemy}) nằm ở góc dưới bên phải!");
            }
            Console.ReadKey();
        }
        static void Bai4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            float canh1, canh2, canh3;
            Console.WriteLine("Câu 4: Viết  chương trình kiểm tra xem một tam giác là tam giac đều" +
                ",tam giác cân hay tam giác thường");
            Console.Write("Nhập độ dài cạnh thứ nhất của tam giác: ");
            canh1 = float.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh thứ hai của tam giác: ");
            canh2 = float.Parse(Console.ReadLine());
            Console.Write("Nhập độ dài cạnh thứ ba của tam giác: ");
            canh3 = float.Parse(Console.ReadLine());
            if (canh1 <= 0 || canh2 <= 0 || canh3 <= 0)
            {
                Console.WriteLine("Đây không phải là hình tam giác!");
                return;
            }
            else if (canh1 + canh2 <= canh3 || canh1 + canh3 <= canh2 || canh2 + canh3 <= canh1) 
            {
                Console.WriteLine("Đây không phải là hình tam giác!");
                return;
            }
            if (canh1 == canh2 && canh2==canh3)
            {
                Console.WriteLine($"Đây là tam giác đều!");
                return;
            }
            if (canh1 == canh2 || canh1 == canh3 || canh2 == canh3)
            {
                Console.WriteLine("Đây là tam giác cân!");
            }
            else
            {
                Console.WriteLine("Đây là tam giác bình thường!");
            }
                Console.ReadKey();
        }

        static void Main(string[] args)
            {
                Bai1();
                Bai2();
                Bai3();
                Bai4();
            }
        
    }
}
