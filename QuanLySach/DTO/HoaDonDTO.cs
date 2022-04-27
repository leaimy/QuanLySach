using System;
using System.Data;

namespace QuanLySach.DTO
{
    public class HoaDonDTO
    {
        private int _MaHoaDon;
        private int _MaNV;
        private DateTime _NgayMua;
        private decimal _TongTien;
        private decimal _GiamGia;
        private DateTime? _NgayThanhToan;

        private string _TenKH;
        private string _SDT;

        public int MaHoaDon { get { return _MaHoaDon; } set { _MaHoaDon = value; } }
        public int MaNV { get { return _MaNV; } set { _MaNV = value; } }
        public DateTime NgayMua { get { return _NgayMua; } set { _NgayMua = value; } }
        public decimal TongTien { get { return _TongTien; } set { _TongTien = value; } }
        public decimal GiamGia { get { return _GiamGia; } set { if (value < 0) value = 0; _GiamGia = value; } }
        public DateTime? NgayThanhToan { get { return _NgayThanhToan; } set { _NgayThanhToan = value; } }
        public string TenKH { get { return _TenKH; } set { _TenKH = value; } }
        public string SDT { get { return _SDT; } set { _SDT = value; } }

        public int ChiNhanhID { get; set; }
        public string HoDemNV { get; set; }
        public string TenNV { get; set; }
        public string HoTenNV { get => HoDemNV + " " + TenNV; }

        public HoaDonDTO()
        {

        }

        public HoaDonDTO(int MaHoaDon, int MaNV, DateTime NgayMua, decimal TongTien, decimal GiamGia, DateTime? NgayThanhToan, string TenKH, string SDT)
        {
            this.MaHoaDon = MaHoaDon;
            this.MaNV = MaNV;
            this.NgayMua = NgayMua;
            this.TongTien = TongTien;
            this.GiamGia = GiamGia;
            this.NgayThanhToan = NgayThanhToan;
            this.TenKH = TenKH;
            this.SDT = SDT;
        }

        public HoaDonDTO(DataRow row)
        {
            this.MaHoaDon = (int)row["MaHoaDon"];
            this.NgayMua = DateTime.Parse(row["NgayMua"].ToString());
            this.TongTien = Convert.ToDecimal(row["TongTien"]);
            this.GiamGia = Convert.ToDecimal(row["GiamGia"]);
            this.NgayThanhToan = DateTime.Parse(row["NgayThanhToan"].ToString());
            this.TenKH = row["TenKH"].ToString();
            this.SDT = row["SDT"].ToString();

            try
            {
                this.MaNV = (int)row["MaNV"];
            }
            catch { }

            try
            {
                this.MaNV = (int)row["MaNhanVien"];
            }
            catch { }

            try
            {
                this.ChiNhanhID = (int)row["ChiNhanh"];
            }
            catch { }

            try
            {
                this.HoDemNV = row["HoDem"].ToString();
            }
            catch { }

            try
            {
                this.TenNV = row["Ten"].ToString();
            }
            catch { }
        }
    }
}
