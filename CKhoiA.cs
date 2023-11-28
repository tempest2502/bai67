using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CKhoiA: CThiSinh
    {
        public CKhoiA(string mats, string hoten, double diemToan, double diemLy, double diemHoa) : base(mats, hoten)
        {
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
        }

        public CKhoiA() : this("", "", 0, 0, 0)
        {
        }

        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }

        public override double TongDiem => DiemToan + DiemLy + DiemHoa;

        public override KieuKetQua KetQua => TongDiem >= 18.5 ? KieuKetQua.Dat : KieuKetQua.KhongDat;

        public override KieuKhoi Khoi => KieuKhoi.KhoiA;

        public override string ToString()
        {
            return MaTS + "\t" + HoTen + "\t" + Khoi + "\t" + DiemToan + "\t" + DiemLy + "\t" + DiemHoa + "\t" + TongDiem + "\t" + KetQua;
        }
    }
}
