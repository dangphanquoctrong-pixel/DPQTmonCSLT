using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
            if (str != null)
            {
                foreach (char c in str) length++;
            }
            return length;
        }
        public static string tachKiTu(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str[i] + " ";
            }
            return result;
        }
        public static string inChuoiNguocLai(string str)
        {
            string result = "";
            int len = str.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
        public static int demSoTu(string str)
        {
            int wordCount = 0;
            bool inWord = false;
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                char c = str[i];
                if (c != ' ' && c != '\n' && c != '\t')
                {
                    if (!inWord)
                    {
                        wordCount++; inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }
            return wordCount;
        }
        public static bool soSanhHaiChuoi(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            if (len1 != len2)
            {
                return false;
            }
            for (int i = 0; i < len1; i++)
            {
                if (str1[i] == str2[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static void dem(string str, out int alphabets, out int digits, out int specials)
        {
            alphabets = 0; digits = 0; specials = 0;
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                char c = str[i];
                bool isUpper = (c >= 'A' && c <= 'Z');
                bool isLower = (c >= 'A' && c <= 'Z');
                bool isDigits = (c >= '0' && c <= '9');
                if (isUpper || isLower) alphabets++;
                else if (isDigits) digits++;
                else if (c != ' ' && c != '\t' && c != '\n') specials++;
            }
        }
        public static void demNguyenPhuAm(string str, out int soNguyenAm, out int soPhuAm)
        {
            soNguyenAm = 0; soPhuAm = 0;
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                char c = str[i];
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    if (c == 'a' || c == 'u' || c == 'o' || c == 'i' || c == 'e' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        soNguyenAm++;
                    }
                    else
                    {
                        soPhuAm++;
                    }
                }
            }
        }
        public static bool kiemTraChuoiCon(string str,string str1)
        {
            return timChuoiCon(str, str1) != -1;
        }
        public static int timChuoiCon(string str,string str1)
        {
            int lenME = str.Length;
            int lenCON = str1.Length;
            if (lenCON==0 || lenME<lenCON) return -1;
            for (int i = 0; i <= lenME - lenCON; i++)
            {
                bool match = true;
                for (int j = 0; j < lenCON; j++)
                {
                    if (str[i + j] != str1[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return i;
            }
            return -1;    
        }
        public static int kiemTraKieuChu(char c)
        {
            if (c >= 'A' && c <= 'Z') return 1;
            if (c >= 'a' && c <= 'z') return 2;
            return 0;
        }
        public static int soChuoiCon(string str, string sub)
        {
            int lenStr = str.Length;
            int lenSub = sub.Length;

            if (lenSub == 0) return 0;

            int count = 0;
            for (int i = 0; i <= lenStr - lenSub;)
            {
                bool match = true;
                for (int j = 0; j < lenSub; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    count++;
                    i += lenSub; // Cắt qua chuỗi vừa tìm được
                }
                else
                {
                    i++;
                }
            }
            return count;
        }
        public static string themChuoi(string str, string sub, string insertStr)
        {
            int pos = timChuoiCon(str, sub);
            if (pos == -1) return null;

            int lenStr = str.Length;
            int lenInsert = insertStr.Length;
            string result = "";

         
            for (int i = 0; i < pos; i++)
            {
                result += str[i];
            }
            for (int i = 0; i < lenInsert; i++)
            {
                result += insertStr[i];
            }
            for (int i = pos; i < lenStr; i++)
            {
                result += str[i];
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
                    case "4":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str4 = Console.ReadLine();
                        string result = inChuoiNguocLai(str4);
                        Console.WriteLine("Chuỗi sau khi đảo ngược là: "+result);
                            break;
                    case "5":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str5 = Console.ReadLine();
                        int tongSoTu = demSoTu(str5);
                        Console.WriteLine("Tổng số từ có trong câu là: " + tongSoTu);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Tạm biệt!");
                        break;
                    case "6":
                        Console.Write("Mời bạn nhập chuỗi 1: ");
                        string str61 = Console.ReadLine();
                        Console.Write("Mời bạn nhập chuỗi 2:");
                        string str62 = Console.ReadLine();
                        bool result6 = soSanhHaiChuoi(str61, str62);
                        if(result6)
                        {
                            Console.WriteLine("Hai chuỗi này giống nhau!");
                        }
                        else
                        {
                            Console.WriteLine("Hai chuỗi này khác nhau!");
                        }
                        break;
                    case "7":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str7 = Console.ReadLine();
                        dem(str7, out int alphabets, out int digits, out int specials);
                        Console.WriteLine($"Chuỗi gồm {alphabets} từ, {digits} số, {specials} kí tự đặc biệt ");
                        break;
                    case "8":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str8 = Console.ReadLine();
                        demNguyenPhuAm(str8, out int soNguyenAm, out int soPhuAm);
                        Console.WriteLine($"Số nguyên âm là {soNguyenAm} và số phụ âm là {soPhuAm} ");
                        break;
                    case "9":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str91 = Console.ReadLine();
                        Console.Write("Mời bạn nhập để kiểm tra có phải chuỗi con của chuỗi phía trên hay không: ");
                        string str92 = Console.ReadLine();
                        bool result9 = kiemTraChuoiCon(str91, str92);
                        if (result9)
                        {
                            Console.WriteLine($"Chuỗi {str92} là chuỗi con của chuỗi {str91}");
                        }
                        else
                        {
                            Console.WriteLine($"Chuỗi {str92} không là chuỗi con của chuỗi {str91}");
                        }
                        break;
                    case "10":
                        Console.Write("Mời bạn nhập chuỗi: ");
                        string str101 = Console.ReadLine();
                        Console.Write("Mời bạn nhập chuỗi con để kiểm tra vị trí của nó trong chuỗi mẹ: ");
                        string str102 = Console.ReadLine();
                        int result10 = timChuoiCon(str101, str102);
                        if (result10 == -1)
                        {
                            Console.WriteLine("Không tìm thấy chuỗi con!");
                        }
                        else
                        {
                            Console.WriteLine("Vị trí của chuỗi con trong chuỗi mẹ là: "+result10);
                        }
                        break;
                    case "11":
                        Console.Write("Mời nhập một kí tự bất kì: ");
                        char str11  = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        int kieuChu = kiemTraKieuChu(str11);
                        if (kieuChu == 1) Console.WriteLine("Kiểu của chữ là chữ Hoa");
                        else if (kieuChu == 2) Console.WriteLine("Kiểu của chữ là chữ thường");
                        else { Console.WriteLine("Kiểu chữ không xác định"); }
                        break;
                    case "12":
                        Console.Write("Mời nhập chuỗi: ");
                        string str121 = Console.ReadLine();
                        Console.WriteLine("Mời nhập chuỗi con: ");
                        string str122 = Console.ReadLine();
                        int sochuoiCon = soChuoiCon(str121, str122);
                        break;
                    case "13":
                        Console.Write("Nhập chuỗi gốc: ");
                        string str13 = Console.ReadLine();
                        Console.Write("Nhập chuỗi con làm mốc: ");
                        string sub13 = Console.ReadLine();
                        Console.Write("Nhập chuỗi muốn chèn vào trước mốc: ");
                        string insertStr = Console.ReadLine();

                        string result13 = themChuoi(str13, sub13, insertStr);
                        if (result13 != null) Console.WriteLine($"Chuỗi mới: {result13}");
                        else Console.WriteLine("Không tìm thấy chuỗi mốc trong chuỗi gốc để chèn.");
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
