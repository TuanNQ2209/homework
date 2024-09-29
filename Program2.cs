using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tuan2
{
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public student() { }
        public void Input()
        {
            Console.Write("Nhập ID: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Nhập Tên: ");
            Name = Console.ReadLine();
            Console.Write("Nhập Tuổi: ");
            Age = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0} Họ tên:{1} Tuổi:{2}", Id, Name, Age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> s = new List<student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("====Menu====");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Hiển thị danh sách sinh viên có tuổi từ 15 đến 18");
                Console.WriteLine("4. Hiển thị danh sách sinh viên có tên bắt đầu bằng chữ A");
                Console.WriteLine("5. Tổng số tuổi của tất cả sinh viên");
                Console.WriteLine("6. Hiển thị danh sách sinh viên có tuổi từ bé đến lớn");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng (0-6): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Add(s);
                        break;
                    case "2":
                        Show(s);
                        break;
                    case "3":
                        Showage15to18(s);
                        break;
                    case "4":
                        ShowwithA(s);
                        break;
                    case "5":
                        Sumage(s);
                        break;
                    case "6":
                        MinagetoMaxage(s);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Kết thúc");
                        break;
                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ, chọn lại (0-6): ");
                        break;
                }
                Console.WriteLine();
            }
        }
        private static void Add(List<student> s)
        {
            Console.WriteLine("====Nhập thông tin====");
            student students = new student();
            students.Input();
            s.Add(students);
            Console.WriteLine("Thành công");
        }
        private static void Show(List<student> s)
        {
            Console.WriteLine("============Danh sách============");
            foreach (student student in s)
            {
                student.Show();
            };
        }
        private static void Showage15to18(List<student> s)
        {
            Console.WriteLine("============Danh sách============");
            var students = s.Where(a => a.Age >= 15 && a.Age <= 18);
            foreach (var student in students)
            {
                student.Show();
            }
        }
        private static void ShowwithA(List<student> s)
        {
            Console.WriteLine("============Danh sách============");
            var students = s.Where(a => a.Name.StartsWith("A"));
            foreach (var student in students)
            {
                student.Show();
            }
        }
        private static void Sumage(List<student> s)
        {
            int sum = s.Sum(a => a.Age);
            Console.WriteLine("Tổng tuổi các sv là " + sum);
        }
        private static void Maxage(List<student> s)
        {
            student Max = s.OrderByDescending(a => a.Age).FirstOrDefault();
            if (Max != null)
                Console.WriteLine("MSSV:{0} Họ tên:{1} Tuổi:{2}", Max.Id, Max.Name, Max.Age);
            else Console.WriteLine("====Danh sách trống======");
        }
        private static void MinagetoMaxage(List<student> s)
        { 
            var MintoMax= s.OrderBy(a => a.Age).ToList();
            foreach (var student in MintoMax)
            {
                student.Show();
            }
        }
    }
}
