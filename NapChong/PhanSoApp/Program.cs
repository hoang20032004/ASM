using System;

namespace PhanSoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BÀI TẬP 1: TẠO VÀ RÚT GỌN PHÂN SỐ ===");
            try
            {
                PhanSo psA = new PhanSo(2, 4);
                Console.WriteLine($"2/4 -> {psA}");

                PhanSo psB = new PhanSo(1, -3);
                Console.WriteLine($"1/-3 -> {psB}");

                Console.WriteLine("Thử tạo phân số với mẫu số bằng 0:");
                PhanSo psC = new PhanSo(1, 0); // Sẽ ném ngoại lệ
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ngoại lệ bắt được: {ex.Message}");
            }
            Console.WriteLine();

            Console.WriteLine("=== BÀI TẬP 2: CÁC PHÉP TOÁN SỐ HỌC ===");
            PhanSo ps1 = new PhanSo(1, 2);  // 1/2
            PhanSo ps2 = new PhanSo(1, 3);  // 1/3

            Console.WriteLine($"ps1 = {ps1}");
            Console.WriteLine($"ps2 = {ps2}");
            Console.WriteLine($"ps1 + ps2 = {ps1 + ps2}");  // Kết quả: 5/6
            Console.WriteLine($"ps1 - ps2 = {ps1 - ps2}");  // Kết quả: 1/6
            Console.WriteLine($"ps1 * ps2 = {ps1 * ps2}");  // Kết quả: 1/6
            Console.WriteLine($"ps1 / ps2 = {ps1 / ps2}");  // Kết quả: 3/2

            Console.WriteLine();
            Console.WriteLine("--- Yêu cầu nâng cao ---");
            Console.WriteLine($"ps1 + 2 = {ps1 + 2}");      // Kết quả: 5/2
            Console.WriteLine($"3 + ps2 = {3 + ps2}");      // Kết quả: 10/3
            Console.WriteLine();

            Console.WriteLine("=== BÀI TẬP 3: CÁC PHÉP SO SÁNH ===");
            PhanSo p1 = new PhanSo(1, 2);   // 1/2
            PhanSo p2 = new PhanSo(2, 4);   // 2/4 (rút gọn thành 1/2)
            PhanSo p3 = new PhanSo(1, 3);   // 1/3

            Console.WriteLine($"p1 = {p1}");
            Console.WriteLine($"p2 = 2/4 (sau rút gọn: {p2})");
            Console.WriteLine($"p3 = {p3}");
            Console.WriteLine($"p1 == p2 : {p1 == p2}");    // True
            Console.WriteLine($"p1 != p3 : {p1 != p3}");    // True
            Console.WriteLine($"p3 < p1  : {p3 < p1}");     // True
            Console.WriteLine($"p1 > p3  : {p1 > p3}");     // True

            Console.WriteLine("\nNhấn Enter để thoát...");
            Console.ReadLine();
        }
    }
}