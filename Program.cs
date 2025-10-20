using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        DateTime ngayDau = LayNgayHopLe();

        Console.WriteLine($"\n📅 Tháng {ngayDau.Month:00}/{ngayDau.Year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int ngayTrongThang = DateTime.DaysInMonth(ngayDau.Year, ngayDau.Month);
        int viTriBatDau = (int)ngayDau.DayOfWeek;

        for (int i = 0; i < viTriBatDau; i++)
            Console.Write("    ");

        for (int ngay = 1; ngay <= ngayTrongThang; ngay++)
        {
            Console.Write($"{ngay,2}  ");
            viTriBatDau++;
            if (viTriBatDau % 7 == 0)
                Console.WriteLine();
        }

        Console.WriteLine("\n");
    }

    static DateTime LayNgayHopLe()
    {
        while (true)
        {
            int thang = NhapSoHopLe("Nhập tháng (1-12): ", 1, 12);
            int nam = NhapSoHopLe("Nhập năm (1-9999): ", 1, 9999);

            try
            {
                return new DateTime(nam, thang, 1);
            }
            catch
            {
                Console.WriteLine(" Lỗi tạo ngày tháng — vui lòng nhập lại!\n");
            }
        }
    }

    static int NhapSoHopLe(string thongBao, int min, int max)
    {
        int so;
        while (true)
        {
            Console.Write(thongBao);
            string input = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(" Không được để trống! Vui lòng nhập lại.");
                continue;
            }

            if (!int.TryParse(input, out so))
            {
                Console.WriteLine(" Bạn phải nhập số nguyên! Vui lòng nhập lại.");
                continue;
            }

            if (so < min || so > max)
            {
                Console.WriteLine($" Giá trị phải nằm trong khoảng {min} đến {max}! Vui lòng nhập lại.");
                continue;
            }

            return so;
        }
    }
}

