using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    internal class ChiTietHoaDonDTO
    {
        private int _MaChiTietHoaDon;
        private int _MaHoaDon;
        private int _MaSP;
        private int _SoLuong;
        private decimal _GiaMua;

        public int MaChiTietHoaDon { get { return _MaChiTietHoaDon; } set { _MaChiTietHoaDon = value; } } 
        public int MaHoaDon { get { return _MaHoaDon; } set { _MaHoaDon = value; } } 
        public int MaSP { get { return _MaSP; } set { _MaSP = value; } } 
        public int SoLuong { get { return _SoLuong; } set { _SoLuong = value; } } 
        public decimal GiaMua { get { return _GiaMua; } set { if (value < 0) value = 0; } }

        public ChiTietHoaDonDTO(int MaCTHD, int MaHD, int MaSP, int SoLuong, decimal GiaMua)
        {
            this.MaChiTietHoaDon = MaCTHD;
            this.MaHoaDon = MaHD;
            this.MaSP = MaSP;
            this.SoLuong = SoLuong;
            this.GiaMua = GiaMua;
        }

        public ChiTietHoaDonDTO(DataRow row)
        {
            this.MaChiTietHoaDon = (int)row["MaChiTietHoaDon"];
            this.MaHoaDon = (int)row["MaHoaDon"];
            this.MaSP = (int)row["MaSP"];
            this.SoLuong = (int)row["SoLuong"];
            this.GiaMua = (decimal)row["GiaMua"];
        }
    }
}
