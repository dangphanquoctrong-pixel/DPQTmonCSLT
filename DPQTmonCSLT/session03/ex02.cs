using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text;

namespace DPQTmonCSLT.session03
{
    internal class ex02
    {
        static void Bai1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            decimal dienCu, dienMoi, dienTieuthu;
            Console.WriteLine("Bài 1: Tính tiền điện sinh hoạt gia đình theo bậc thang (EVN) ");
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            dienCu = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số điện mới (kWh): ");
            dienMoi = decimal.Parse(Console.ReadLine());
            if (dienMoi < dienCu)
            {
                Console.WriteLine("Lỗi: Chỉ số điện mới phải lớn hơn hoặc bằng chỉ số điện cũ!");
                return;
            }
            dienTieuthu = dienMoi - dienCu;
            const decimal giaBac1 = 1806m;
            const decimal giaBac2 = 1866m;
            const decimal giaBac3 = 2167m;
            const decimal giaBac4 = 2729m;
            const decimal giaBac5 = 3050m;
            const decimal thueVAT = 0.08m;
            decimal tienChuathue = 0m;
            if (dienTieuthu <= 50)
            {
                tienChuathue = dienTieuthu * giaBac1;
            }
            else if (dienTieuthu <= 100)
            {
                tienChuathue = (50 * giaBac1) + (giaBac2 * (dienTieuthu - 50));
            }
            else if (dienTieuthu <= 200)
            {
                tienChuathue = (50 * giaBac1) + (giaBac2 * 50) + ((dienTieuthu - 100) * giaBac3);
            }
            else if (dienTieuthu <= 300)
            {
                tienChuathue = (50 * giaBac1) + (giaBac2 * 50) + (giaBac3 * 100) + ((dienTieuthu - 200) * giaBac4);
            }
            else
            {
                tienChuathue = (50 * giaBac1) + (giaBac2 * 50) + (giaBac3 * 100) +  (100 * giaBac4) +((dienTieuthu -300)*giaBac5);
            }
            decimal tienThue = tienChuathue * thueVAT;
            decimal tongThanhtoan = tienThue + tienChuathue;
            tienChuathue = Math.Round(tienChuathue, MidpointRounding.AwayFromZero);
            tienThue = Math.Round(tienThue, MidpointRounding.AwayFromZero);
            tongThanhtoan = Math.Round(tongThanhtoan, MidpointRounding.AwayFromZero);
            Console.WriteLine("Số điện tiêu thụ: kWh"+dienTieuthu);
            Console.WriteLine($"Tiền điện chưa thuế:{tienChuathue:#,##0} VND ");
            Console.WriteLine($"Thuế VAT:{tienThue:#,##0} VND ");
            Console.WriteLine($"Tổng thanh toán:{tongThanhtoan:#,##0} VND ");
            Console.ReadKey();
        } 
        static void Bai2()
        {
            double chieuCao, canNang, bmi;
            string loaiSuckhoe ="";
            Console.WriteLine("Bài 2: Hệ thống theo dõi chỉ số BMI và đánh giá tình trạng sức khỏe");
            Console.Write("Mời nhập chiều cao của bạn (tính bằng mét, ví dụ 1.72):  ");
            chieuCao = float.Parse( Console.ReadLine() );
            Console.Write("Mời nhập cân nặng của bạn (tính bằng kg, ví dụ 68.5): ");
            canNang = float.Parse(Console.ReadLine());
            bmi = canNang / (chieuCao * chieuCao);
            if (bmi < 18.5)
            {
                loaiSuckhoe = "Thiếu cân";
            }
            else if (bmi < 23)
            {
                loaiSuckhoe = "Lý tưởng";
            }
            else if (bmi < 25)
            {
                loaiSuckhoe = " Tiền béo phì";
            }
            else 
            {
                loaiSuckhoe = "Béo phì";
            }
            double canNangtoithieu = 18.5f * chieuCao * chieuCao;
            double canNangtoida = 22.9f * chieuCao * chieuCao;
            Console.WriteLine($"Chỉ sổ BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {loaiSuckhoe}");
            Console.WriteLine($"Cân nặng lý tưởng của bạn từ {canNangtoithieu:F2} kg đến {canNangtoida:F2} kg.");
            Console.ReadKey();
        }
            enum loaiTiente
        {
            USA=1,
            EUR=2,
            JPY=3,
            GBP=4
        }
        static void Bai3()
        {

            const decimal tyGiaMy = 25400m;
            const decimal tyGiaChauAu = 27200m;
            const decimal tyGiaBangAnh = 32100m;
            const decimal tyGiaNhat = 165m;
            Console.WriteLine("Bài 3: Ứng dụng quy đổi tiền tệ ngoại tệ đa tỷ giá ngân hàng");
            Console.WriteLine("1. USA (Đồng đô la Mỹ)");
            Console.WriteLine("2. EUR (Euro)");
            Console.WriteLine("3. JPY (Yên Nhật)");
            Console.WriteLine("4. GBP (Bảng Anh)");
            Console.Write( "Chọn từ 1 đến 4 theo thứ tự đồng tiền muốn đổi: ");
            int luaChon = int.Parse(Console.ReadLine());
            loaiTiente tienchon = (loaiTiente)luaChon;
            Console.Write("Nhập số tiền VND cần đổi sang ngoại tệ mong muốn: ");
            decimal soTienViet = decimal.Parse(Console.ReadLine());
            decimal tyLePhiQuyDoi = 0.05m;
            decimal phiDichVu = soTienViet * tyLePhiQuyDoi;
            decimal tienVietTinhDoi = soTienViet - phiDichVu;
            decimal tyGiaApDung = 0m;
            decimal ngoaiTeNhanDuoc;
            switch (tienchon)
            {
                case loaiTiente.USA:
                    tyGiaApDung = tyGiaMy;
                    break;
                case loaiTiente.EUR:
                    tyGiaApDung = tyGiaChauAu;
                    break;
                case loaiTiente.JPY:
                    tyGiaApDung = tyGiaNhat;
                    break;
                case loaiTiente.GBP:
                    tyGiaApDung = tyGiaBangAnh;
                    break;
            }
            ngoaiTeNhanDuoc = tienVietTinhDoi / tyGiaApDung; 
            Console.WriteLine($"Phí dịch vụ:{phiDichVu:#,##0} VND");
            Console.WriteLine($"Số tiền Việt Nam tính đổi:{tienVietTinhDoi:#,##0} VND");
            Console.WriteLine($"Số tiền {tienchon} nhận được :{ngoaiTeNhanDuoc:F2} {tienchon}");
            Console.ReadKey();
        }
        static void Bai4()
        {
            
            Console.WriteLine("Bài 4: Tính tuổi chính xác và đếm ngược ngày sinh nhật: ");
            Console.Write("Nhập ngày tháng năm sinh của bạn (dd/MM/yyyy): ");
            string input = Console.ReadLine();
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngaySinh))
            {
                Console.WriteLine("Lỗi: Ngày sinh không hợp lệ hoặc sai định dạng(dd/MM/yyyy)!");
                return;
            }
            DateTime homNay = DateTime.Now.Date;
            if (ngaySinh>homNay)
            {
                Console.WriteLine("Ngày sinh không được lớn hơn ngày hiện tại!");
                return;
            }
             int tuoi = homNay.Year - ngaySinh.Year;
            if (homNay < ngaySinh.AddYears(tuoi))
            {
                tuoi--;
            }
            TimeSpan thoiGianSong = homNay - ngaySinh;
            int soNgaySong = (int)thoiGianSong.TotalDays;
            DateTime sinhNhatKeTiep = new DateTime(homNay.Year,ngaySinh.Month,ngaySinh.Day);
            if (sinhNhatKeTiep < homNay )
            {
                sinhNhatKeTiep = sinhNhatKeTiep.AddYears(1);
            }
            int  soNgayConLai = (int)(sinhNhatKeTiep - homNay).TotalDays;
            Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {soNgaySong} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayConLai} ngày");
            
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