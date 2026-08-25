using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text;
using System.Transactions;

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
            if (ngaySinh > homNay)
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
            DateTime sinhNhatKeTiep = new DateTime(homNay.Year, ngaySinh.Month, ngaySinh.Day);
            if (sinhNhatKeTiep < homNay)
            {
                sinhNhatKeTiep = sinhNhatKeTiep.AddYears(1);
            }
            int soNgayConLai = (int)(sinhNhatKeTiep - homNay).TotalDays;
            Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {soNgaySong} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayConLai} ngày");

            Console.ReadKey();
        }
            static void Bai5()
            {
            float diemThangMuoi,diemToan,diemAnh,diemLapTrinh,diemThang4;
            int tinchimontoan, tinchimonanh, tinchimonlaptrinh;
            Console.WriteLine("Bài 5: Quản lý điểm học phần và quy đổi thang điểm GPA (4.0)");
            Console.Write("Nhập điểm môn Toán của bạn: ");
            diemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhập số tín chỉ: ");
            tinchimontoan = int.Parse(Console.ReadLine());


            Console.Write("Nhập điểm môn Tiếng Anh của bạn: ");
            diemAnh = float.Parse(Console.ReadLine());
            Console.Write("Nhập số tín chỉ: ");
            tinchimonanh = int.Parse(Console.ReadLine());


            Console.Write("Nhập điểm môn Cơ sở lập trình của bạn: ");
            diemLapTrinh = float.Parse(Console.ReadLine());
            Console.Write("Nhập số tín chỉ: ");
            tinchimonlaptrinh = int.Parse(Console.ReadLine());
            if (diemToan>= 10 && diemToan <= 0)
            {
                Console.WriteLine("Lỗi: Điểm thang 10 phải nằm trong khoảng từ 0 đến 10!");
                return;
            }
            if (diemAnh >= 10 && diemAnh <= 0)
            {
                Console.WriteLine("Lỗi: Điểm thang 10 phải nằm trong khoảng từ 0 đến 10!");
                return;
            }
            if (diemLapTrinh >= 10 && diemLapTrinh <= 0)
            {
                Console.WriteLine("Lỗi: Điểm thang 10 phải nằm trong khoảng từ 0 đến 10!");
                return;
            }
            diemThangMuoi = (diemToan * tinchimontoan + diemAnh * tinchimonanh + diemLapTrinh * tinchimonlaptrinh)/(tinchimontoan+ tinchimonanh +tinchimonlaptrinh);
            Console.WriteLine($"Điểm trung bình thang 10: {diemThangMuoi}");
            string diemChu, hocLuc;
            
                if (diemThangMuoi >= 8.5)
                {
                    diemChu = "A";
                    diemThang4 = 4.0f;
                }
                else if (diemThangMuoi >= 7)
                {
                    diemChu = "B";
                diemThang4 = 3.0f;
            }
                else if (diemThangMuoi >= 5.5)
                {
                    diemChu = "C";
                diemThang4 = 2.0f;
            }
                else if (diemThangMuoi >= 4)
                {
                    diemChu = "D";
                diemThang4 = 1.0f;
            }
                else
                {
                    diemChu = "F";
                diemThang4 = 0.0f;
            }
                if (diemChu == "A")
                {
                    hocLuc = "Xuất sắc/Giỏi";
                }
                else if (diemChu == "B")
                {
                    hocLuc = "Khá";
                }
                else if (diemChu == "C")
                {
                    hocLuc = "Trung bình";
                }
                else if (diemChu == "D")
                { 
                    hocLuc = "Yếu";
                }
                else 
                    hocLuc = "Kém (Trượt)";
                Console.WriteLine($"Điểm chữ quy đổi: {diemChu}");
                Console.WriteLine($"Điểm GPA thang 4: {diemThang4}");
                Console.WriteLine($"Xếp loại học lực: {hocLuc}");
                Console.ReadKey();
            }
        static void Bai6()
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string hovaten; 
            Console.WriteLine("Câu 6:Chuẩn hóa họ tên người dùng và tự động tạo email/username");
            Console.Write("Nhập họ và tên của bạn: ");
            hovaten = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(hovaten))
            {
                Console.WriteLine("Họ và tên không được để trống!");
                return;
            }
            string[] words = hovaten.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0;i < words.Length;i++)
            {
                string word = words[i].ToLower();
                words[i] = char.ToUpper(word[0])+ word.Substring(1);    
            }
            string fullname = string.Join(" ",words);
            string ho="";
            string tendem="";
            string ten="";
            if (words.Length == 1)
            {
                ten = words[0];
            }
            else if (words.Length == 2)
            { 
                ho = words[0];
                ten = words[1];
            }
            else
            {
                ho = words[0];
                ten = words[words.Length - 1];
                string[] middleWords = new string[words.Length - 2];
                Array.Copy(words, 1, middleWords, 0, words.Length - 2);
                tendem = string.Join(" ", middleWords);
            }
            string hokhongdau = bodautiengviet(ho).ToLower();
            string tenDemKhongDau = bodautiengviet(tendem).Replace(" ", "").ToLower();
            string tenKhongDau = bodautiengviet(ten).ToLower();
            string username = $"{tenKhongDau}.{hokhongdau}{tenDemKhongDau}";
            string email = $"{username}@company.edu.vn";

            Console.WriteLine($"Họ tên chuẩn hóa: {fullname}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tendem} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");

            Console.ReadKey();
        }
      
        static string bodautiengviet(string text)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;

            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().Normalize(NormalizationForm.FormC).Replace("đ", "d").Replace("Đ", "D");
        }
        static void Bai7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài 7: Lập kế hoạch chi phí nhiên liệu và chia sẻ chuyến đi");
            Console.Write("Nhập quãng đường chuyến đi (km): ");
            double quangduong = double.Parse(Console.ReadLine());
            Console.Write("Nhập mức tiêu hao nhiên liệu (lít/100km): ");
            double muctieuthu = double.Parse(Console.ReadLine());
            Console.Write("Nhập giá xăng (VND/lit): ");
            decimal giaxang = decimal .Parse(Console.ReadLine());
            Console.Write("Nhập số người đi: ");
            int songuoi = int.Parse(Console.ReadLine());
            double tongsolitxang = (quangduong / 100f) * muctieuthu;
            decimal tongchiphitienxang = (decimal)tongsolitxang * giaxang;
            decimal tienmoinguoi = tongchiphitienxang / songuoi;
            Console.WriteLine($"Tổng nhiên liệu phải trả: {tongsolitxang:F2}");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongchiphitienxang:#,##0} VND ");
            Console.WriteLine($"Tổng chi phí mỗi người: {Math.Ceiling(tienmoinguoi):#,##0} VND");
        }
        static void Bai8()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài 8: Kiểm tra mã xác thực OTP và quản lý thời gian hiệu lực");
            string systemOTP = "839201";
            DateTime creationTime = DateTime.Now;
            Console.WriteLine("Nhập mã OTP xác thực: ");
            string userOTP = Console.ReadLine()?.Trim() ?? "";
            Console.Write("Nhập số phút đã trôi qua: ");
            int.TryParse(Console.ReadLine(), out int sophuttroiqua);
            Console.Write("Nhập số giây đã trôi qua: ");
            int.TryParse(Console.ReadLine(), out int sogiaytroiqua);
            DateTime thoidiemxacthuc = creationTime.AddMinutes(sophuttroiqua).AddSeconds(sophuttroiqua);
            TimeSpan thoigiantroiqua = thoidiemxacthuc - creationTime ;
            bool dinhdanghople = userOTP.Length == 6 && int.TryParse(userOTP, out _);
            if (!dinhdanghople)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI - Lỗi định dạng không hợp lệ (Mã OTP phải gồm đúng 6 chữ số).");
            }
            bool makhop = userOTP == systemOTP;
            if (!makhop)
            {
                Console.WriteLine("Trạng thái xác thực: THẤT BẠI - Mã không chính xác!");
            }
            bool hanthoigian = thoigiantroiqua.TotalSeconds > 300;
            if(!hanthoigian)
            {
                Console.WriteLine($"Trạng thái xác thực: THẤT BẠI - Mã OTP hết hạn (Thời gian trôi qua: {thoigiantroiqua.Minutes} phút, {thoigiantroiqua.Seconds} giây");
            }
            Console.WriteLine("Trạng thái xác thực: THÀNH CÔNG - Giao dịch đã được phê duyệt");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //Bai1();
            //Bai2();
            //Bai3();
            //Bai4();
            //Bai5();
            //Bai6();
            //Bai7();
            Bai8();

        }
    }   
}