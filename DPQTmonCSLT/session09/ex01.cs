using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DPQTmonCSLT.sessioon09
{
    internal class ex01
    {
        public static int timChieuDai(string str)
        {
            int length = 0;
            if(str !=null)
            {
                foreach (char c in str)  length++; 
            }
            return length;
        }
        public static string tachKiTu(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result +=  str[i] + " ";
            }
            return result;

        }
        static void Main (string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("MENU QUẢN LÝ TÍNH NĂNG");
                Console.WriteLine("1. Nhập và in chuỗi");
                Console.WriteLine("2. Tìm độ dài chuỗi (không dùng hàm)");
                Console.WriteLine("3. Tách từ kí tự từ chuỗi");
                Console.WriteLine("4. In chuỗi theo thứ tự ngược lại");
                Console.WriteLine("5. Đếm tổng số từ trong chuỗi");
                Console.WriteLine("6. So sánh hai chuỗi (không dùng hàm)");
                Console.WriteLine("7. Đếm số chữ cái, chữ số, ký tự đặc biệt");
                Console.WriteLine("8. Đếm số nguyên âm, phụ âm");
                Console.WriteLine("9. Kiểm tra chuỗi con có tồn tại hay không");
                Console.WriteLine("10. Tìm vị trí xuất hiện của chuỗi con");
                Console.WriteLine("11. Kiểm tra một kí tự (chữ cái, hoa/thường)");
                Console.WriteLine("12. Đếm số lần xuất hiện của chuỗi con");
                Console.WriteLine("13. Chèn chuỗi trước chuỗi con");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("Chọn tính năng từ 0 đến 13: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Chuỗi bạn vừa mới nhập là: " + str1);
                        break;
                    case "2":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str2 = Console.ReadLine();
                        int doDai = timChieuDai(str2);
                        Console.WriteLine("Độ dài của chuỗi là (tính cả khoảng trắng): "+doDai);
                        break;
                    case "3":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str3 = Console.ReadLine();
                        string output = tachKiTu(str3);
                        Console.WriteLine("Chuỗi sau khi tách là: " + output);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                } 
                        if (!exit)
                {
                    Console.WriteLine("Nhấp phím bất kì để quay trở lại menu");
                    Console.ReadKey();
                }
            }
        }
    }
}
