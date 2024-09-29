using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Yêu cầu người dùng nhập số lượng sản phẩm
                Console.Write("Nhập số lượng sản phẩm: ");
                int soLuong = int.Parse(Console.ReadLine());

                // Yêu cầu người dùng nhập giá của một sản phẩm
                Console.Write("Nhập giá của một sản phẩm: ");
                double giaSanPham = double.Parse(Console.ReadLine());

                // Tính tổng giá trị đơn hàng
                double tongGiaTri = soLuong * giaSanPham;

                // In ra tổng giá trị đơn hàng
                Console.WriteLine("Tổng giá trị đơn hàng là: " + tongGiaTri);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập số.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
  
