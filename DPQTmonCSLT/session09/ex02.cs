using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DPQTmonCSLT.session09
{
    internal class ex02
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n================ MENU BÀI TẬP FILE C# ================");
                Console.WriteLine("1.  Tạo một file trống trên đĩa");
                Console.WriteLine("2.  Xóa một file khỏi đĩa");
                Console.WriteLine("3.  Tạo file và thêm văn bản");
                Console.WriteLine("4.  Tạo file văn bản và đọc nội dung");
                Console.WriteLine("5.  Tạo file và ghi một mảng chuỗi vào file");
                Console.WriteLine("6.  Nối thêm văn bản (append) vào file đã có");
                Console.WriteLine("7.  Tạo, sao chép file sang tên khác và hiển thị nội dung");
                Console.WriteLine("8.  Tạo file và di chuyển (đổi tên) trong cùng thư mục");
                Console.WriteLine("9.  Đọc dòng đầu tiên của file");
                Console.WriteLine("10. Tạo và đọc dòng cuối cùng của file");
                Console.WriteLine("11. Tạo và đọc n dòng cuối cùng của file");
                Console.WriteLine("12. Đọc một dòng cụ thể từ file");
                Console.WriteLine("13. Đếm số dòng trong một file");
                Console.WriteLine("14. In cấu trúc của một thư mục cụ thể (bao gồm cả file)");
                Console.WriteLine("15. Thống kê ký tự/chữ số và vị trí (Mảng chữ nhật & Jagged Array)");
                Console.WriteLine("0.  Thoát chương trình");
                Console.Write("Chọn bài tập (0-15): ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ!");
                    continue;
                }

                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập tên file muốn tạo (VD: test.txt): ");
                        string file1 = Console.ReadLine();
                        Ex01_CreateBlankFile(file1);
                        break;

                    case 2:
                        Console.Write("Nhập tên file muốn xóa (VD: test.txt): ");
                        string file2 = Console.ReadLine();
                        Ex02_RemoveFile(file2);
                        break;

                    case 3:
                        Console.Write("Nhập tên file muốn tạo (VD: test.txt): ");
                        string file3 = Console.ReadLine();
                        Console.Write("Nhập nội dung văn bản muốn ghi: ");
                        string text3 = Console.ReadLine();
                        Ex03_CreateAndAddText(file3, text3);
                        break;

                    case 4:
                        Console.Write("Nhập tên file (VD: test.txt): ");
                        string file4 = Console.ReadLine();
                        Console.Write("Nhập nội dung để tạo file và đọc lại: ");
                        string text4 = Console.ReadLine();
                        Ex04_CreateAndReadFile(file4, text4);
                        break;

                    case 5:
                        Console.Write("Nhập tên file (VD: array.txt): ");
                        string file5 = Console.ReadLine();
                        Console.Write("Nhập số lượng chuỗi trong mảng: ");
                        int n5 = int.Parse(Console.ReadLine());
                        string[] arr5 = new string[n5];
                        for (int i = 0; i < n5; i++)
                        {
                            Console.Write($"Nhập chuỗi thứ {i + 1}: ");
                            arr5[i] = Console.ReadLine();
                        }
                        Ex05_WriteArrayOfStrings(file5, arr5);
                        break;

                    case 6:
                        Console.Write("Nhập tên file muốn nối thêm văn bản (VD: test.txt): ");
                        string file6 = Console.ReadLine();
                        Console.Write("Nhập văn bản muốn nối thêm vào cuối file: ");
                        string appendText = Console.ReadLine();
                        Ex06_AppendTextToFile(file6, appendText);
                        break;

                    case 7:
                        Console.Write("Nhập tên file nguồn (VD: source.txt): ");
                        string src7 = Console.ReadLine();
                        Console.Write("Nhập nội dung cho file nguồn: ");
                        string content7 = Console.ReadLine();
                        Console.Write("Nhập tên file đích sau khi sao chép (VD: copy.txt): ");
                        string dest7 = Console.ReadLine();
                        Ex07_CopyFileAndDisplay(src7, content7, dest7);
                        break;

                    case 8:
                        Console.Write("Nhập tên file ban đầu (VD: old.txt): ");
                        string oldFile8 = Console.ReadLine();
                        Console.Write("Nhập nội dung cho file ban đầu: ");
                        string content8 = Console.ReadLine();
                        Console.Write("Nhập tên file mới sau khi di chuyển (VD: new.txt): ");
                        string newFile8 = Console.ReadLine();
                        Ex08_MoveFileSameDirectory(oldFile8, content8, newFile8);
                        break;

                    case 9:
                        Console.Write("Nhập tên file cần đọc dòng đầu tiên: ");
                        string file9 = Console.ReadLine();
                        Ex09_ReadFirstLine(file9);
                        break;

                    case 10:
                        Console.Write("Nhập tên file (VD: lastline.txt): ");
                        string file10 = Console.ReadLine();
                        Console.Write("Nhập số dòng muốn tạo: ");
                        int n10 = int.Parse(Console.ReadLine());
                        string[] lines10 = new string[n10];
                        for (int i = 0; i < n10; i++)
                        {
                            Console.Write($"Nhập dòng {i + 1}: ");
                            lines10[i] = Console.ReadLine();
                        }
                        Ex10_CreateAndReadLastLine(file10, lines10);
                        break;

                    case 11:
                        Console.Write("Nhập tên file (VD: nlines.txt): ");
                        string file11 = Console.ReadLine();
                        Console.Write("Nhập tổng số dòng muốn tạo cho file: ");
                        int total11 = int.Parse(Console.ReadLine());
                        string[] lines11 = new string[total11];
                        for (int i = 0; i < total11; i++)
                        {
                            Console.Write($"Nhập dòng {i + 1}: ");
                            lines11[i] = Console.ReadLine();
                        }
                        Console.Write("Nhập số dòng cuối cùng muốn đọc (n): ");
                        int lastN = int.Parse(Console.ReadLine());
                        Ex11_CreateAndReadLastNLines(file11, lines11, lastN);
                        break;

                    case 12:
                        Console.Write("Nhập tên file cần đọc: ");
                        string file12 = Console.ReadLine();
                        Console.Write("Nhập số thứ tự dòng muốn đọc (bắt đầu từ 1): ");
                        int lineNum12 = int.Parse(Console.ReadLine());
                        Ex12_ReadSpecificLine(file12, lineNum12);
                        break;

                    case 13:
                        Console.Write("Nhập tên file cần đếm số dòng: ");
                        string file13 = Console.ReadLine();
                        Ex13_CountLinesInFile(file13);
                        break;

                    case 14:
                        Console.Write("Nhập đường dẫn thư mục (Nhấn Enter để lấy thư mục hiện tại): ");
                        string path14 = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(path14))
                        {
                            path14 = Directory.GetCurrentDirectory();
                        }
                        Ex14_PrintFolderStructure(path14);
                        break;

                    case 15:
                        Console.Write("Nhập tên file cần thống kê (VD: stats.txt): ");
                        string file15 = Console.ReadLine();
                        if (!File.Exists(file15))
                        {
                            Console.Write("File chưa tồn tại. Nhập số dòng muốn tạo mới cho file: ");
                            int n15 = int.Parse(Console.ReadLine());
                            string[] lines15 = new string[n15];
                            for (int i = 0; i < n15; i++)
                            {
                                Console.Write($"Nhập dòng {i + 1}: ");
                                lines15[i] = Console.ReadLine();
                            }
                            File.WriteAllLines(file15, lines15);
                        }
                        Ex15_CharacterStatistics(file15);
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }

       
        static void Ex01_CreateBlankFile(string fileName)
        {
            using (FileStream fs = File.Create(fileName)) { }
            Console.WriteLine($"Đã tạo file trống '{fileName}' tại: {Path.GetFullPath(fileName)}");
        }

       
        static void Ex02_RemoveFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine($"Đã xóa file '{fileName}' thành công.");
            }
            else
            {
                Console.WriteLine($"File '{fileName}' không tồn tại.");
            }
        }

        
        static void Ex03_CreateAndAddText(string fileName, string content)
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(content);
            }
            Console.WriteLine($"Đã tạo file '{fileName}' và ghi nội dung thành công.");
        }

        
        static void Ex04_CreateAndReadFile(string fileName, string content)
        {
            File.WriteAllText(fileName, content);
            Console.WriteLine($"--- Nội dung đọc từ file '{fileName}' ---");
            using (StreamReader sr = File.OpenText(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

       
        static void Ex05_WriteArrayOfStrings(string fileName, string[] lines)
        {
            File.WriteAllLines(fileName, lines);
            Console.WriteLine($"--- Nội dung mảng chuỗi trong file '{fileName}' ---");
            foreach (string line in File.ReadAllLines(fileName))
            {
                Console.WriteLine(line);
            }
        }

       
        static void Ex06_AppendTextToFile(string fileName, string appendText)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(appendText);
            }
            Console.WriteLine($"--- Nội dung file '{fileName}' sau khi nối thêm ---");
            Console.WriteLine(File.ReadAllText(fileName));
        }

       
        static void Ex07_CopyFileAndDisplay(string sourceFile, string content, string destFile)
        {
            File.WriteAllText(sourceFile, content);
            File.Copy(sourceFile, destFile, true);
            Console.WriteLine($"Đã sao chép '{sourceFile}' sang '{destFile}'. Nội dung file mới:");
            Console.WriteLine(File.ReadAllText(destFile));
        }

        
        static void Ex08_MoveFileSameDirectory(string originalFile, string content, string movedFile)
        {
            File.WriteAllText(originalFile, content);
            if (File.Exists(movedFile))
            {
                File.Delete(movedFile);
            }
            File.Move(originalFile, movedFile);
            Console.WriteLine($"Đã di chuyển '{originalFile}' thành '{movedFile}'. Nội dung:");
            Console.WriteLine(File.ReadAllText(movedFile));
        }

        
        static void Ex09_ReadFirstLine(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File '{fileName}' không tồn tại!");
                return;
            }
            using (StreamReader sr = new StreamReader(fileName))
            {
                Console.WriteLine($"Dòng đầu tiên của '{fileName}': {sr.ReadLine()}");
            }
        }

       
        static void Ex10_CreateAndReadLastLine(string fileName, string[] lines)
        {
            File.WriteAllLines(fileName, lines);
            string[] allLines = File.ReadAllLines(fileName);
            if (allLines.Length > 0)
            {
                Console.WriteLine($"Dòng cuối cùng của '{fileName}': {allLines[allLines.Length - 1]}");
            }
        }

        
        static void Ex11_CreateAndReadLastNLines(string fileName, string[] lines, int n)
        {
            File.WriteAllLines(fileName, lines);
            string[] allLines = File.ReadAllLines(fileName);
            int startIndex = Math.Max(0, allLines.Length - n);

            Console.WriteLine($"--- {n} dòng cuối cùng của file '{fileName}' ---");
            for (int i = startIndex; i < allLines.Length; i++)
            {
                Console.WriteLine(allLines[i]);
            }
        }

       
        static void Ex12_ReadSpecificLine(string fileName, int lineNumber)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File '{fileName}' không tồn tại!");
                return;
            }
            string[] allLines = File.ReadAllLines(fileName);
            if (lineNumber >= 1 && lineNumber <= allLines.Length)
            {
                Console.WriteLine($"Dòng thứ {lineNumber}: {allLines[lineNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Số thứ tự dòng nằm ngoài phạm vi của file!");
            }
        }

        
        static void Ex13_CountLinesInFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File '{fileName}' không tồn tại!");
                return;
            }
            int count = File.ReadAllLines(fileName).Length;
            Console.WriteLine($"Số dòng trong file '{fileName}' là: {count}");
        }

      
        static void Ex14_PrintFolderStructure(string dirPath, string indent = "")
        {
            if (!Directory.Exists(dirPath))
            {
                Console.WriteLine("Thư mục không tồn tại!");
                return;
            }

            try
            {
                foreach (string file in Directory.GetFiles(dirPath))
                {
                    Console.WriteLine($"{indent}├── [File] {Path.GetFileName(file)}");
                }

                foreach (string subDir in Directory.GetDirectories(dirPath))
                {
                    Console.WriteLine($"{indent}└── [Dir]  {Path.GetFileName(subDir)}");
                    Ex14_PrintFolderStructure(subDir, indent + "    ");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"{indent}└── [Không có quyền truy cập]");
            }
        }

       
        static void Ex15_CharacterStatistics(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            
            char[] uniqueChars = new char[0];
            for (int r = 0; r < lines.Length; r++)
            {
                for (int c = 0; c < lines[r].Length; c++)
                {
                    char ch = lines[r][c];
                    if (char.IsLetterOrDigit(ch))
                    {
                        bool exists = false;
                        for (int i = 0; i < uniqueChars.Length; i++)
                        {
                            if (uniqueChars[i] == ch)
                            {
                                exists = true;
                                break;
                            }
                        }
                        if (!exists)
                        {
                            Array.Resize(ref uniqueChars, uniqueChars.Length + 1);
                            uniqueChars[uniqueChars.Length - 1] = ch;
                        }
                    }
                }
            }

            int totalUnique = uniqueChars.Length;

            
            int[,] rectStats = new int[totalUnique, 2];
            for (int i = 0; i < totalUnique; i++)
            {
                char target = uniqueChars[i];
                rectStats[i, 0] = (int)target;
                int count = 0;

                for (int r = 0; r < lines.Length; r++)
                {
                    for (int c = 0; c < lines[r].Length; c++)
                    {
                        if (lines[r][c] == target) count++;
                    }
                }
                rectStats[i, 1] = count;
            }

            
            string[][] jaggedPositions = new string[totalUnique][];
            for (int i = 0; i < totalUnique; i++)
            {
                jaggedPositions[i] = new string[rectStats[i, 1]];
                int posIndex = 0;
                char target = (char)rectStats[i, 0];

                for (int r = 0; r < lines.Length; r++)
                {
                    for (int c = 0; c < lines[r].Length; c++)
                    {
                        if (lines[r][c] == target)
                        {
                            jaggedPositions[i][posIndex] = $"({r + 1},{c + 1})";
                            posIndex++;
                        }
                    }
                }
            }

            
            Console.WriteLine($"\n--- THỐNG KÊ KÝ TỰ & CHỮ SỐ TRONG FILE '{fileName}' ---");
            Console.WriteLine($"{"Ký tự",-8} | {"Số lần",-8} | {"Vị trí (Dòng, Cột)"}");
            Console.WriteLine(new string('-', 55));

            for (int i = 0; i < totalUnique; i++)
            {
                char ch = (char)rectStats[i, 0];
                int count = rectStats[i, 1];
                string positions = string.Join(", ", jaggedPositions[i]);
                Console.WriteLine($"'{ch}'{"",-5} | {count,-8} | {positions}");
            }
        }
    }
}

