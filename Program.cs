using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CThiSinh> ds = fakeData();
            Console.WriteLine("Danh sach thi sinh");
            xuat(ds);
            Console.WriteLine("\nSo thi sinh khoi nang khieu: " + GetSoThiSinhKhoiNangKhieu(ds));
            Console.WriteLine("\nDanh sach thi sinh khoi A");
            xuat(getDSThiSinhKhoiA(ds));
            Console.WriteLine("\nDiem thi lon nhat khoi A: " + GetDiemLonNhatKhoiA(ds));
            Console.WriteLine("\nDanh sach thi sinh Dat");
            xuat(getDSThiSinhDat(ds));
            Console.WriteLine("\nDanh sach thi sinh khoi nang khieu Khong Dat");
             

        }
        static void xuat(List<CThiSinh> ds)
        {
            foreach (CThiSinh ts in ds)
                Console.WriteLine(ts);
        }
        static List<CThiSinh> fakeData()
        {
            List<CThiSinh> ds = new List<CThiSinh>();
            ds.Add(new CKhoiA("ts01", "Cong", 8, 8, 8));
            ds.Add(new CKhoiA("ts02", "Hau", 7, 8, 9));
            ds.Add(new CKhoiA("ts03", "Ban", 6, 7, 8));
            ds.Add(new CKhoiA("ts04", "Khang", 7, 7, 7));
            ds.Add(new CKhoiNangKhieu("nk01", "Hai", 8, 9));
            ds.Add(new CKhoiNangKhieu("nk02", "Thu", 7, 8));
            ds.Add(new CKhoiNangKhieu("nk03", "Yen", 6, 7));
            ds.Add(new CKhoiNangKhieu("nk04", "Binh", 5, 8));
            ds.Add(new CKhoiNangKhieu("nk05", "Khoa", 6, 9));
            return ds;
        }
        
        static int GetSoThiSinhKhoiNangKhieu(List<CThiSinh> ds)
        {
            int count = 0;
            foreach (CThiSinh nk in ds)
                if (nk.Khoi == KieuKhoi.KhoiNangKhieu)
                    count++;
            return count;
        }
        static List<CThiSinh> getDSThiSinhKhoiA(List<CThiSinh> ds)
        {
            List<CThiSinh> kq = new List<CThiSinh>();
            foreach (CThiSinh ts in ds)
                if (ts.Khoi == KieuKhoi.KhoiA)
                    kq.Add(ts);
            return kq;
        }
        static double GetDiemLonNhatKhoiA(List<CThiSinh> ds)
        {
            double max = 0;
            foreach (CThiSinh a in ds)
                if(a.Khoi==KieuKhoi.KhoiA)
                    if (a.TongDiem > max)
                        max = a.TongDiem;
            return max;
        }
        static List<CThiSinh> getDSThiSinhDat(List<CThiSinh> ds)
        {
            List<CThiSinh> kq = new List<CThiSinh>();
            foreach (CThiSinh ts in ds)
                if (ts.KetQua == KieuKetQua.Dat)
                    kq.Add(ts);
            return kq;
        }
        List<CKhoiNangKhieu> getDSThiSinhNangKhieuKhongDat(List<CThiSinh> ds)
        {
            List<CKhoiNangKhieu> kq = new List<CKhoiNangKhieu>();
            foreach (CKhoiNangKhieu nk in ds)
                if (nk.KetQua == KieuKetQua.KhongDat)
                    kq.Add(nk);
            return kq;
        }
    }
}
