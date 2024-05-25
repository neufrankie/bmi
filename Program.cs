using System;

namespace BMICalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập chiều cao từ người dùng (đơn vị: mét)
            Console.Write("Nhap vao chieu cao cua ban (m): ");
            double chieuCao = Convert.ToDouble(Console.ReadLine());

            // Nhập cân nặng từ người dùng (đơn vị: kilogram)
            Console.Write("Nhap vao can nang cua ban (kg): ");
            double canNang = Convert.ToDouble(Console.ReadLine());

            // Tính chỉ số BMI
            double bmi = canNang / (chieuCao * chieuCao);

            // Đánh giá chỉ số BMI
            string danhGia = "";
            if (bmi < 18.5)
            {
                danhGia = "Thieu can";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                danhGia = "Binh thuong";
            }
            else if (bmi >= 24.9 && bmi < 29.9)
            {
                danhGia = "Thua can";
            }
            else
            {
                danhGia = "Beo phi";
            }

            // Hiển thị kết quả
            Console.WriteLine("Chi so BMI cua ban la: " + bmi);
            Console.WriteLine("Danh gia: " + danhGia);
        }
    }
}
