using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CKhoiNangKhieu: CThiSinh
    {
        public CKhoiNangKhieu(string mats, string hoten, double diemToan, double diemNangKhieu) : base(mats, hoten)
        {
            DiemToan = diemToan;
            DiemNangKhieu = diemNangKhieu;
        }

        public CKhoiNangKhieu() : this("", "", 0, 0)
        {
        }

        public double DiemToan { get; set; }
        public double DiemNangKhieu { get; set; }

        public override double TongDiem => DiemToan + DiemNangKhieu * 2;

        public override KieuKetQua KetQua => TongDiem >= 17 ? KieuKetQua.Dat : KieuKetQua.KhongDat;

        public override KieuKhoi Khoi => KieuKhoi.KhoiNangKhieu;
        public override string ToString()
        {
            return MaTS + "\t" + HoTen + "\t" + Khoi + "\t" + DiemToan + "\t" + DiemNangKhieu + "\t" + TongDiem + "\t" + KetQua;
        }
    }
}
