using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum KieuKetQua { Dat, KhongDat }
    public enum KieuKhoi { KhoiA, KhoiNangKhieu }
    class CThiSinh
    {
        public CThiSinh(string maTS, string hoTen)
        {
            MaTS = maTS;
            HoTen = hoTen;
        }

        public CThiSinh(): this("","")
        {
        }

        public string MaTS { get; set; }
        public string HoTen { get; set; }
        public virtual double TongDiem => 0;
        public virtual KieuKetQua KetQua => KieuKetQua.KhongDat;
        public virtual KieuKhoi Khoi => KieuKhoi.KhoiA;

    
    }

}
