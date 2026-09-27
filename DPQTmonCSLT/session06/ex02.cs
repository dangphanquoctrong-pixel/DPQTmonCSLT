using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace DPQTmonCSLT.session06
{
    internal class ex02
    {
        public static int tinhTongHaiSo(int a, int b)
        {
            return a + b;
        }

        public static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        public static int timMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public static long tinhGiaiThua(int n)
        {
            long tich = 1;
            for (int i = 1; i <= n; i++)
            {
                tich *= i;
            }
            return tich;
        }
        public static string daoNguocChuoi(string input)
        {
            char[] CharArray = input.ToCharArray();
            Array.Reverse(CharArray);
            return new string(CharArray);
        }
        public static bool kiemTraNguyenTo(int n)
        {
            if (n<=1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if ( n % i == 0)
                {
                    return false;
                }         
            }
            return true;
        }
        public static void InFibonacci(int n)
        {
            if (n<=0)
            {
                Console.WriteLine("Mời nhập số lớn hơn 0!");
                return;
            }
            long a = 0;
            long b = 1;
            for (int i = 1; i<=n; i++)
            {
                Console.Write(" " + a);
                long c = a + b;
                a = b;
                b = c;
            }
        }

        public static int DemNguyenAm(string s)
        {
         if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
         int n = 0;
            string lowerstr = s.ToLower();
            foreach (char c in lowerstr)
            {
                if (c=='a'||c=='u'||c=='i'||c=='e'||c=='o')
                {
                    n++;
                }
            }
            return n;
        }
        public static double tinhLuyThua(double x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            
                double a = 1;
                for (int i = 1; i <= y; i++)
                {
                    a = a * x;
                }
            return a;
        }
        public static double tinhTrungBinh(int[] arr)
        {
            if (arr == null||arr.Length == 0)
            {
                return 0;
            }
            double tong = 0;
            foreach (int i in arr)
            {
                tong += i;
            }
            double trungBinh = tong/arr.Length;
            return trungBinh;
        }

        public static bool kiemTraDoiXung(string s)
        {
            char[] CharArray = s.ToCharArray();
            Array.Reverse(CharArray);
             string newReverse =new string (CharArray);
            if (newReverse == s)
            {
                return true;
            }
            return false;
        }

        public static double CelsiusToFahrenheit(double c)
        {
            double doF = c * 1.8 + 32;
            return doF;
        }


        public static int TimMin(int[] arrr)
        {
            int minNumber = arrr.Min();
            return minNumber;
        }

        public static int TongCacChuSo(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        public static void SapXepMang(int[] arr)


        {
            Array.Sort(arr);
            
            for (int i = 0; i < arr.Length;i++)
            {
               Console.Write(" "+arr[i]);
            }
            Console.WriteLine();
        }
        public static string XoaTrungLap(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            string ketQua = "";
            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                    
                    {
                    ketQua += c;
                    } 
            }
            return ketQua;
                
        }

        public static int UCLN(int a, int b)
        {
            int c = Math.Max(a, b);
            int d = Math.Min(a, b);
            int r;
            do
            {
                r = c % d;
                c = d;
                d = r;

            }
            while (r != 0);
            return c;
        }
        public static string  DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            string ketQua = "";
            while (n>0)
            {
                int r = n % 2;
                ketQua = r + ketQua;
                n = n / 2;

            }
            return ketQua;

        }
        public static bool KiemTraNamNhuan(int year)
        {
            if (year%4==0) return true ;
            else return false;
            
        }
        public static int DemSoTu(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)) return 0;
            int khoangTrang = 0;
            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    khoangTrang++;
                }
            }
            return khoangTrang + 1;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //Console.WriteLine("Bài 1:");
            //Console.WriteLine("Nhập hai số muốn tỉnh tổng");
            //Console.Write("Số đầu: ");
            //int so1Bai1 = int.Parse(Console.ReadLine());
            //Console.Write("Số thứ hai: ");
            //int so2Bai1 = int.Parse(Console.ReadLine());
            //int Tong = tinhTongHaiSo(so1Bai1, so2Bai1);
            //Console.WriteLine($"Tổng hai số {so1Bai1} + {so2Bai1} = {Tong}");


            //Console.WriteLine("Bài 2:");
            //Console.Write("Nhập một số muốn biết chẵn hay lẽ: ");
            //int so1Bai2 = int.Parse(Console.ReadLine());
            //bool ketQua = KiemTraChan(so1Bai2);
            //if (ketQua == false)
            //{
            //    Console.WriteLine($"Số {so1Bai2} là số lẻ");
            //}
            //if (ketQua == true)
            //{
            //    Console.WriteLine($"Số {so1Bai2} là số chẵn");
            //}


            //Console.WriteLine("Bài 3:");
            //Console.WriteLine("Tìm số lớn nhất trong ba số:");
            //Console.Write("Nhập số đầu: ");
            //int so1Bai3 = int.Parse(Console.ReadLine());
            //Console.Write("Nhập thứ hai: ");
            //int so2Bai3 = int.Parse(Console.ReadLine());
            //Console.Write("Nhập thứ ba: ");
            //int so3Bai3 = int.Parse(Console.ReadLine());
            //int soMax = timMax(so1Bai3, so2Bai3, so3Bai3);
            //Console.WriteLine($"Số lớn nhất trong ba số là: {soMax} ");


            //Console.WriteLine("Bài 4: ");
            //Console.WriteLine("Tìm giai thừa của một số: ");
            //Console.Write("Nhập số muốn tính giai thừa: ");
            //int so1Bai4 = int.Parse(Console.ReadLine());
            //long tich = tinhGiaiThua(so1Bai4);
            //Console.WriteLine($"Kết quả của {so1Bai4}! = {tich}");


            //Console.WriteLine("Bài 5:");
            //Console.WriteLine("Đảo ngược chuỗi kí tự: ");
            //Console.Write("Nhập một chuỗi bạn muốn đảo ngược: ");
            //string chuoiGoc = Console.ReadLine();
            //string chuoiMoi = daoNguocChuoi(chuoiGoc);
            //Console.WriteLine("Sau khi đảo ngược chuỗi: " + chuoiMoi);


            //Console.WriteLine("Bài 6:");
            //Console.WriteLine("Kiểm tra số nguyên tố:");
            //Console.Write("Nhập một số muốn kiểm tra có phải là số nguyên tố không: ");
            //int so1Bai6 = int.Parse(Console.ReadLine());
            //bool kiemTra = kiemTraNguyenTo(so1Bai6);
            //if (kiemTra == false)
            //{
            //    Console.WriteLine($"Số {so1Bai6} không là số nguyên tố!");
            //}
            //else
            //{
            //    Console.WriteLine($"Số {so1Bai6} là số nguyên tố!");
            //}


            //Console.WriteLine("Bài 7:");
            //Console.WriteLine("In dãy Fibonacci: ");
            //Console.Write("Nhập số lượng số đầu tiên của dãy Fibonacci: ");
            //int so1Bai7 = int.Parse(Console.ReadLine());
            //Console.Write($"Dãy số Fibonacci là: ");
            //InFibonacci(so1Bai7);


            //Console.WriteLine("Bài 8:");
            //Console.WriteLine("Đếm số lượng nguyên âm trong chuỗi:");
            //Console.Write("Mời nhập chuỗi: ");
            //string chuoi = Console.ReadLine();
            //int soLuongNguyenAm = DemNguyenAm(chuoi);
            //Console.Write("Số kí tự nguyên âm là: " + soLuongNguyenAm);


            //Console.WriteLine("Bài 9:");
            //Console.WriteLine("Tính lũy thừa (x^y): ");
            //Console.Write("Mời nhập x: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Mời nhập y: ");
            //int y = int.Parse(Console.ReadLine());
            //double luyThua = tinhLuyThua(x, y);
            //Console.WriteLine($"Kết quả của phép tính {x}^{y}={luyThua}");

            //Console.WriteLine("Bài 10:");
            //Console.WriteLine("Tính điểm trung bình của mảng:");
            //Console.Write("Mời nhập mảng số, cách nhau bằng dấu phẩy, (VD: 4, 5, 6, 7): ");
            //string input = Console.ReadLine();
            //string[] stringArray = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int[] arr = Array.ConvertAll(stringArray, int.Parse);
            //double ketqua = tinhTrungBinh(arr);
            //Console.WriteLine($"Kết quả trung bình của mảng: {ketqua}");


            //Console.WriteLine("Bài 11:");
            //Console.WriteLine("Kiểm tra chuỗi đối xứng (Palindrome):");
            //Console.Write("Mời nhập chuỗi: ");
            //string chuoi1Bai11 = Console.ReadLine();
            //bool kiemTraChuoi = kiemTraDoiXung(chuoi1Bai11);
            //if (kiemTraChuoi == true)
            //{
            //    Console.WriteLine($"Chuỗi {chuoi1Bai11} là chuỗi đối xứng");
            //}
            //if (kiemTraChuoi == false)
            //{
            //    Console.WriteLine($"Chuỗi {chuoi1Bai11} không là chuỗi đối xứng");
            //}



            //Console.WriteLine("Bài 12:");
            //Console.WriteLine("Chuyển đổi nhiệt độ:");
            //Console.Write("Mời nhập nhiệt độ C muốn chuyển sang độ F: ");
            //double nhietDo = double.Parse(Console.ReadLine());
            //double sauKhiDoi = CelsiusToFahrenheit(nhietDo);
            //Console.Write($"{nhietDo} độ C bằng {sauKhiDoi} độ F!");



            //Console.WriteLine("Bài 13:");
            //Console.WriteLine("Tìm giá trị nhỏ nhất trong mảng: ");
            //Console.Write("Mời nhập mảng giá trị (VD: 4,5,6,7): ");
            //string mangBanDau = Console.ReadLine();
            //string[] mangMoi = mangBanDau.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int[] arrr = Array.ConvertAll(mangMoi, int.Parse);
            //int dapAn = TimMin(arrr);
            //Console.WriteLine($"Số nhỏ nhất trong {mangBanDau} là: {dapAn}");



            //Console.WriteLine("Bài 14:");
            //Console.WriteLine("Tính tổng các chữ số của một số nguyên:");
            //Console.Write("Mời nhập số: ");
            //int so1Bai14 = int.Parse(Console.ReadLine());
            //int result = TongCacChuSo(so1Bai14);
            //Console.WriteLine($"kết quả của dãy số {so1Bai14} sau khi tách ra và cộng các phần tử lại = {result}");


            //Console.WriteLine("Bài 15:");
            //Console.WriteLine("Sắp xếp mảng tăng dần:");
            //Console.Write("Mời nhập mảng số (VD: 3,1,2,4): ");
            //string MangBanDau = Console.ReadLine();
            //string[] MangMoi = MangBanDau.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int[] mang = Array.ConvertAll(MangMoi, int.Parse);
            //Console.Write($"chuỗi ban đầu là {MangBanDau} và sau khi sắp xếp là: ");
            //SapXepMang(mang);


            //Console.WriteLine("Bài 16: ");
            //Console.WriteLine("Xóa ký tự trùng lặp: ");
            //Console.WriteLine("Mời nhập chuỗi muốn xóa kí tự trùng lập: ");
            //string chuoiBai16 = Console.ReadLine();
            //string xoaTrungLap = XoaTrungLap(chuoiBai16);
            //Console.WriteLine($"Chuỗi ban đầu {chuoiBai16} sau khi xóa trùng lập: {xoaTrungLap}");


            //Console.WriteLine("Bài 17: ");
            //Console.WriteLine("Tìm ước chung lớn nhất (UCLN): ");
            //Console.Write("Mời nhâp số a: ");
            //int soA = int.Parse(Console.ReadLine());
            //Console.Write("Mời nhâp số b: ");
            //int soB = int.Parse(Console.ReadLine());
            //int timUoc = UCLN(soA,soB);
            //Console.WriteLine($"Ước chung lớn nhất của {soA} và {soB} là {timUoc}");




            //Console.WriteLine("Bài 19: ");
            //Console.WriteLine("Kiểm tra năm nhuận");
            //Console.Write("Mời nhập năm: ");
            //int nam = int.Parse(Console.ReadLine());
            //bool namNhuan = KiemTraNamNhuan(nam);
            //if (namNhuan == false)
            //{
            //    Console.WriteLine($"Năm {nam} không phải là năm nhuận!");
            //}
            //if (namNhuan == true)
            //{
            //    Console.WriteLine($"Năm {nam} là năm nhuận!");


            Console.WriteLine("Bài 20: ");
            Console.WriteLine("Đếm số từ trong câu: ");
            Console.Write("Mời bạn nhập câu: ");
            string cau = Console.ReadLine();
            int khoangTrang = DemSoTu(cau);
            Console.WriteLine($"Số khoảng trắng có trong câu: {cau} là {khoangTrang}");
            }
        }    
    }

