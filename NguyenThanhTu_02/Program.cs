using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhTu_02
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int chon=0;
            do
            { 
            Console.WriteLine(" 1. Nhap danh sach nhan vien ");
            Console.WriteLine(" 2. Xuat danh sach nhan vien ");
            Console.WriteLine(" 3. Tinh tong luong nhan vien ");
            Console.WriteLine(" 4. Tinh trung binh luong nhan vien ");
            Console.WriteLine(" 5. Thoát ");

                Console.Write(" Moi ban nhap chuc nang : ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        ql.Nhap();
                        break;
                    case 2:
                        ql.Xuat();
                        break;
                    case 3:
                        Console.WriteLine($" Tong luong nhan vien {ql.TongLuong()}");
                        break;
                    case 4:
                        Console.WriteLine($" Trung binh luong nhan vien {ql.TinhTrungBinh()}");
                        break;
                    case 5:
                        Console.ReadLine();
                        break;
                }
            } while (chon != 5);
        }
    }
}
