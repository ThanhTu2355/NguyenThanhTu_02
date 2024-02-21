using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhTu_02
{
    class NhanVienBC : NhanVien
    {
        private string mucxeploai;

        public NhanVienBC() : base()
        { }

        public NhanVienBC(string maso, string hoten, int luongcung, string mucxeploai):base(maso,hoten,luongcung)
        {
            this.mucxeploai = mucxeploai;
        }

        public string MucXepLoai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai : ");
            this.mucxeploai = Console.ReadLine();
        }

        public override int TinhLuong()
        {
            double luong;
            if (mucxeploai == "A")
            {
                luong = 1.5 * LuongCung;
                return (int)luong;
            }
            else if (mucxeploai == "B")
            {
                luong = 1.0 * LuongCung;
                return (int)luong;
            }
            else
            {
                luong = 0.5 * LuongCung;
                return (int)luong;

            }
        }
    }
}
