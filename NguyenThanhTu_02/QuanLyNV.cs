using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhTu_02
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
         public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }

        public void Nhap()
        {
            string tieptuc = "y";
            int luachon;
            NhanVien nv;
            do
            {
                Console.Write("Nhap thong tin nhan vien [1. Bien che - 2. Hop dong]");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Nhap sai moi ban nhap lai 1 hoac 2 ");
                        break;
                }
                Console.Write("Ban muon tiep tuc khong Y/N");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }
        public void Xuat()
        {
            Console.WriteLine($"{"Ma so",-10} {"Ho ten",20} {"Luong",20:#,##0 VND}");
            foreach(NhanVien nv in dsNV)
            {
                Console.WriteLine($"{nv.MaSo,-10} {nv.HoTen,20} {nv.TinhLuong(),20:#,##0 VND}");
            }
        }
        public int TongLuong()
        {
            int sum=0;
            foreach(NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
            }
            return sum;
        }
        public double TinhTrungBinh()
        {
            int dem = dsNV.Count();
            return  TongLuong() / dem;
        }
    }
}
