using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    class ThongKeKhachHangDTO
    {
        private string _SDT;
        private string _TenKH;
        private int _SoLuongHoaDon;
        private decimal _TongTien;
        private decimal _DuocGiamGia;
        private decimal _TienPhaiTra;

       

        public string SDT { get { return _SDT; } set { _SDT = value; } }
        public string TenKH { get { return _TenKH; } set { _TenKH = value; } }
        public int SoLuongHoaDon { get { return _SoLuongHoaDon; } set { _SoLuongHoaDon = value; } }
        public decimal TongTien { get { return _TongTien; } set { _TongTien = value; } }
        public decimal DuocGiamGia { get { return _DuocGiamGia; } set { _DuocGiamGia = value; } }
        public decimal TienPhaiTra { get { return _TienPhaiTra; } set { _TienPhaiTra = value; } }


        public ThongKeKhachHangDTO(string sDT, string tenKH, int soLuongHoaDon, decimal tongTien, decimal duocGiamGia, decimal tienPhaiTra)
        {
            SDT = sDT;
            TenKH = tenKH;
            SoLuongHoaDon = soLuongHoaDon;
            TongTien = tongTien;
            DuocGiamGia = duocGiamGia;
            TienPhaiTra = tienPhaiTra;
        }

        public ThongKeKhachHangDTO(DataRow row)
        {
            SDT = row["SDT"].ToString() ;
            TenKH = row["TenKH"].ToString();
            SoLuongHoaDon = (int)row["So luong hoa don"];
            TongTien = Convert.ToDecimal(row["Tong tien"]);
            DuocGiamGia = Convert.ToDecimal(row["Duoc giam gia"]);
            TienPhaiTra = Convert.ToDecimal(row["Tien phai tra"]);
        }


    }
}
