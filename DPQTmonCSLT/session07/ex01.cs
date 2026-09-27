using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

namespace DPQTmonCSLT.session07
{
    internal class ex01
    {
        public static double[] chuyenChuoiThanhMang(string input)
        {
            string[] cacSoChuoi = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            double[] arr = new double[cacSoChuoi.Length];
            for (int i = 0; i < cacSoChuoi.Length; i++)
            {
                arr[i] = double.Parse(cacSoChuoi[i]);
            }
            return arr;
        }
        public static double tinhTrungBinh(double[] mang)
        {
            double tong = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                tong += mang[i];
            }
            return tong / mang.Length;
        }
        public static bool KiemTraTonTai(double[] mang, double soCanTim)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == soCanTim)
                {
                    return true;
                }
            }
            return false;
        }
        public static double timIndex(double[] mang, double timIndex)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == timIndex)
                {
                    return i;
                }
            }
            return 0;
        }

        public static double[] xoaSo(double[] arr, double x)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != x) dem++;
            }
            double[] arrMoi = new double[dem];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != x)
                {
                    arrMoi[index] = arr[i];
                    index++;
                }
            }
            return arrMoi;
        }

        public static double timMax(double[] arr)
        {
            double max = arr[0];
            foreach (double d in arr)
            {
                if (d > max)
                {
                    max = d;
                }
            }
            return max;
        }
        public static double timMin(double[] arr)
        {
            double min = arr[0];
            foreach (double d in arr)
            {
                if (d < min)
                {
                    min = d;
                }
            }
            return min;
        }
        public static double[] daoNguocChuoi(double[] arr)
        {
            double[] arrMoi = new double[arr.Length];
            int index = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arrMoi[index] = arr[i];
                index++;
            }
            return arrMoi;
        }
        public static double[] timKiTuTrung(double[] arr)
        {
            List<double> danhSachTrung = new List<double>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (!danhSachTrung.Contains(arr[i]))
                        {
                            danhSachTrung.Add(arr[i]);
                        }
                    }
                }
            }
            return danhSachTrung.ToArray();
        }
        public static double[] loaiTrungLap(double[] arr)
        {
            List<double> danhSachDuyNhat = new List<double>();
            for(int i = 0; i < arr.Length;i++)
            {
                if (!danhSachDuyNhat.Contains(arr[i]))
                {
                    danhSachDuyNhat.Add(arr[i]);
                }
            }

            return danhSachDuyNhat.ToArray();
        }
        public static double [] sapXepNoiBot(double[] arr)
        {
            if (arr == null || arr.Length == 0) return null;
            int n = arr.Length;
            for (int i = 0;i < n-1;i++)
            {
                for(int j =0;j<n-1-i;j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        double temp = arr[j];
                        arr[j]= arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static int timKiemTuyenTinh(string input, string input2)
        {
            if (string.IsNullOrEmpty(input)) return -1;
            string[] chuoiMoi = input.Split(new char[] { ' ', ',' });
            for (int i = 0; i < chuoiMoi.Length; i++)
            {
                if (chuoiMoi[i] == input2)
                {
                    return i + 1;
                }
            }
            return -1;
        }
        public static int[,] taoMaTran(int n,int m )
        {
            Random random = new Random();
            int[,] matrix = new int[n, m];
            for(int i =0; i < n; i++)
            {
                for( int j =0; j < m; j++)
                {
                    matrix [i,j] = random.Next(10, 100);
                }
            }

            return matrix;
        }
        public static void inMaTran(int[,] matrix)
        {
            if (matrix == null)
            {
                Console.WriteLine("Ma trận chưa được khởi tạo!");
                return;
            }
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0;i<n;i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write   ($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }
        public static void inHangHoacCot(int[,] matrix, int i, bool isRow)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            if (isRow)
            {
                if (i < 0 || i >= n)
                {
                    Console.WriteLine("Chỉ số hàng không hợp lệ!");
                    return;
                }
                Console.WriteLine($"Các phần tử ở hàng {i} là: ");
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                if (i < 0 || i >= m)
                {
                    Console.WriteLine("Chỉ số cột không hợp lệ!");
                    return;
                }
                Console.WriteLine($"Các phần tử ở cột {i} là: ");
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(matrix[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    public static int timMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];
                }
            }
            return max;
        }
        public static int timMinHangHoacCot(int[,] matrix, int i, bool isRow)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            if (isRow)
            {
                if (i < 0 || i >= n) throw new ArgumentException("Hàng không hợp lệ!");
                int min = matrix[i, 0];
                for (int j = 1; j < m; j++) if (matrix[i, j] < min) min = matrix[i, j];
                return min;
            }
            else
            {
                if (i < 0 || i >= m) throw new ArgumentException("Cột không hợp lệ!");
                int min = matrix[0, i];
                for (int j = 1; j < n; j++) if (matrix[j, i] < min) min = matrix[j, i];
                return min;
            }
        }
        public static int[,] chuyenViMaTran(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] transposed = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }
            return transposed;
        }
        public static void inDuongCheo(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            if (n != m)
            {
                Console.WriteLine("Đây không phải là ma trận vuông, không thể in đường chéo!");
                return;
            }

            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < n; i++) Console.Write(matrix[i, i] + " ");
            Console.WriteLine();

            Console.Write("Đường chéo phụ: ");
            for (int i = 0; i < n; i++) Console.Write(matrix[i, n - 1 - i] + " ");
            Console.WriteLine();
        }
        
        static void Main(string[] args)
            {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //Console.Write("Bài 1:");
            //Console.WriteLine(" Tính giá trị trung bình của các phần tử trong mảng.");
            //Console.Write("Mời bạn nhập mảng số (VD: 1 2 3 4 5): ");
            //string input = Console.ReadLine();
            //double[] arr = chuyenChuoiThanhMang(input);
            //if (arr.Length == 0)
            //{
            //    Console.WriteLine("Bạn chưa nhập số nào hợp lí, mời bạn nhập lại mảng mới!");
            //    return;
            //}

            //double trungBinh = tinhTrungBinh(arr);
            //Console.WriteLine($"Giá trị trung bình của mảng là: {trungBinh}");



            //Console.Write("Bài 2:");
            //Console.WriteLine(" Kiểm tra xem mảng có chứa một giá trị cụ thể nào đó hay không.");
            //Console.Write("Mời bạn nhập chuỗi: ");
            //string input1 = Console.ReadLine();
            //double[] arr2 = chuyenChuoiThanhMang(input1);
            //Console.Write("Mời bạn nhập số cần tìm trong chuỗi: ");
            //double n = double.Parse(Console.ReadLine());
            //bool ketQua = KiemTraTonTai(arr2, n);
            //if (ketQua==true)
            //{
            //    Console.WriteLine("Số bạn tìm có trong mảng!");
            //}
            //else
            //{
            //    Console.WriteLine("Số bạn tìm không có trong mảng!");
            //}   


            //Console.Write("Bài 3:");
            //Console.WriteLine("Tìm chỉ số index của một phần từ trong mảng: ");
            //Console.Write("Mời bạn nhập chuỗi: ");
            //string input3 = Console.ReadLine();
            //Console.Write("Mời bạn nhập phần tử muốn tìm index: ");
            //double n3 = double.Parse(Console.ReadLine());
            //double[] arr3 = chuyenChuoiThanhMang(input3);
            //double y = timIndex(arr3,n3);
            //if (y==0)
            //{
            //    Console.WriteLine($"Không tìm thấy kí số {n3} đó trong mảng!");
            //}
            //else
            //{
            //    Console.WriteLine($"Index của số {n3} là {y}");
            //}



            //Console.Write("Bài 4: ");
            //Console.WriteLine("Xóa một phần tử cụ thể ra khỏi mảng.");
            //Console.WriteLine("Mời bạn nhập mảng số: ");
            //string input4 = Console.ReadLine();
            //Console.WriteLine("Mời bạn nhập số muốn xóa ra khỏi mảng: ");
            //double n4 = double.Parse(Console.ReadLine());
            //double[] arr4 = chuyenChuoiThanhMang(input4);
            //double[] mangKetQua = xoaSo(arr4, n4);
            //Console.WriteLine("Mảng sau khi xóa số " + n4 + " là: " + string.Join(" ", mangKetQua));



            //Console.WriteLine("Bài 5: ");
            //Console.WriteLine("Tìm giá trị lớn nhất và nhỏ nhất trong mảng.");
            //Console.Write("Mời bạn nhập chuỗi: ");
            //string input5 = Console.ReadLine();
            //double[] arr5 = chuyenChuoiThanhMang(input5);
            //double min = timMin(arr5);
            //double max = timMax(arr5);
            //Console.WriteLine($"Số lớn nhất trong mảng: {max}");
            //Console.WriteLine($"Số nhỏ nhất trong mảng: {min}");



            //Console.Write("Bài 6: ");
            //Console.WriteLine("Đảo ngược chuỗi.");
            //Console.WriteLine("Mời bạn nhập chuỗi: ");
            //string input6 = Console.ReadLine();
            //double[] arr6 = chuyenChuoiThanhMang(input6);
            //double[] mangKetQua = daoNguocChuoi(arr6);
            //Console.WriteLine("Mảng sau khi đảo ngược " + string.Join(",", mangKetQua));


            //Console.WriteLine("Bài 7: ");
            //Console.WriteLine(" Tìm các giá trị trùng lập trong mảng ");
            //Console.WriteLine("Mời bạn nhập mảng: ");
            //string input7 = Console.ReadLine();
            //double[] arr7 = chuyenChuoiThanhMang(input7);
            //double[] chuoiMoi7 = timKiTuTrung(arr7);
            //if (chuoiMoi.Length>0)
            //{

            //    Console.WriteLine("Các giá trị trùng lập là: "+string.Join(",", chuoiMoi));
            //}
            //else
            //{
            //    Console.WriteLine("Không có giá trị nào trùng lập trong mảng");
            //}



            //Console.Write("Bài 8:");
            //Console.WriteLine("Loại bỏ các kí tự trùng lập ra khỏi mảng.");
            //Console.WriteLine("Mời bạn nhâp chuỗi: ");
            //string input8 = Console.ReadLine();
            //double[] chuoiMoi8 = chuyenChuoiThanhMang(input8);
            //double[] chuoiKetQua = loaiTrungLap(chuoiMoi8);
            //Console.WriteLine("Chuỗi sau khi loại bỏ kí tự trùng lập là: " + string.Join(",", chuoiKetQua));


            //Console.WriteLine("Bài toán sắp xếp nổi bọt");
            //Console.WriteLine("Mời bạn nhập dãy số gồm 10 số: ");
            //string input9 = Console.ReadLine();
            //double[] arr9 = chuyenChuoiThanhMang(input9);
            //double[] sauSapXep = sapXepNoiBot(arr9);
            //Console.WriteLine("Kết quả sau khi sắp xếp nổi bọt là: " + string.Join(",", sauSapXep));


            //Console.WriteLine("Tìm kiếm tuyến tính.");
            //Console.WriteLine("Mời bạn nhập chuỗi kí tự: ");
            //string chuoi = Console.ReadLine();
            //Console.WriteLine("Mời bạn nhập kí tự muốn tìm:");
            //string chuTim = Console.ReadLine();
            //int viTri = timKiemTuyenTinh(chuoi, chuTim);
            //if (viTri > 0)
            //{
            //    Console.WriteLine("Vị trí của chữ cần tìm đang nằm ở chữ thứ: " + viTri);
            //}
            //else
            //{
            //    Console.WriteLine("Không tìm thấy vị trí của từ đó!");
            //}


            int[,] matrix = null;
            while (true)
            {
                Console.WriteLine("MENU quản lý chức năng");
                Console.WriteLine("1. Tạo ma trận ngẫu nhiên N x M");
                Console.WriteLine("2. In ma trận");
                Console.WriteLine("3. In hàng/cột thứ i");
                Console.WriteLine("4. Tìm giá trị lớn nhất của ma trận");
                Console.WriteLine("5. Tìm giá trị nhỏ nhất của hàng/cột thứ i");
                Console.WriteLine("6. Chuyển vị ma trận");
                Console.WriteLine("7. In đường chéo chính và phụ (Ma trận vuông)");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Mời chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Vui lòng nhập số hợp lệ!");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập số hàng N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.Write("Nhập số cột M: ");
                        int M = int.Parse(Console.ReadLine());
                        matrix = taoMaTran(N, M);
                        Console.WriteLine("Đã tạo ma trận thành công: ");
                        inMaTran(matrix);
                        break;
                    case 2:
                        N = 2;
                        M = 3;
                        matrix = taoMaTran(N, M);
                        inMaTran(matrix);
                        break;
                    case 3:
                        if (matrix == null)
                        {
                            Console.WriteLine("Vui lòng khởi tạo ma trận trước (chọn 1)!");
                            break;
                        }
                        Console.WriteLine("Vui lòng nhập chỉ số i:");
                        int i3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("In hàng nhập 1 hay in cột nhập 0?");
                        bool isRow3 = int.Parse(Console.ReadLine()) == 1;
                        inHangHoacCot(matrix,i3 ,isRow3);
                        break;
                    case 4:
                        if (matrix == null) { Console.WriteLine("Vui lòng tạo ma trận trước (chọn 1)!"); break; }
                        Console.WriteLine("Giá trị lớn nhất của ma trận là: " + timMax(matrix));
                        break;
                    case 5:
                        if (matrix == null) { Console.WriteLine("Vui lòng tạo ma trận trước (chọn 1)!"); break; }
                        Console.Write("Nhập chỉ số i: ");
                        int i5 = int.Parse(Console.ReadLine());
                        Console.Write("Tìm min của hàng (nhập 1) hay cột (nhập 0)? ");
                        bool isRow5 = int.Parse(Console.ReadLine()) == 1;
                        try
                        {
                            Console.WriteLine("Giá trị nhỏ nhất là: " + timMinHangHoacCot(matrix, i5, isRow5));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 6:
                        if (matrix == null) { Console.WriteLine("Vui lòng tạo ma trận trước (chọn 1)!"); break; }
                        int[,] transposed = chuyenViMaTran(matrix);
                        Console.WriteLine("Ma trận sau khi chuyển vị:");
                        inMaTran(transposed); // In luôn kết quả sau khi chuyển vị
                        break;
                    case 7:
                        if (matrix == null) { Console.WriteLine("Vui lòng tạo ma trận trước (chọn 1)!"); break; }
                        inDuongCheo(matrix);
                        break;
                    case 0:
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}


