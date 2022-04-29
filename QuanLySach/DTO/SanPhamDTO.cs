using System;
using System.Data;

namespace QuanLySach.DTO
{
    public class SanPhamDTO
    {
        private int _MaSP;
        private string _TenSP;
        private decimal _GiaBan;
        private int _LoaiSanPham;
        private string _Mota;

        public int MaSP { get { return _MaSP; } set { _MaSP = value; } }
        public string TenSP { set { _TenSP = value; } get { return _TenSP; } }
        public decimal GiaBan { get { return _GiaBan; } set { _GiaBan = value; } }
        public int LoaiSanPham { get { return _LoaiSanPham; } set { _LoaiSanPham = value; } }
        public string Mota { get { return _Mota; } set { _Mota = value; } }
        public string TenLoaiSP { get; set; }

        public SanPhamDTO()
        {

        }

        public SanPhamDTO(int MaSP, string TenSP, decimal GiaBan, int LoaiSanPham, string MoTa)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.GiaBan = GiaBan;
            this.LoaiSanPham = LoaiSanPham;
            this.Mota = Mota;
        }

        public SanPhamDTO(DataRow row)
        {
            this.MaSP = (int)row["MaSP"];
            this.TenSP = row["TenSP"].ToString();
            this.GiaBan = Convert.ToDecimal(row["GiaBan"]);
            this.LoaiSanPham = Convert.ToInt32(row["LoaiSanPham"]);
            this.Mota = row["Mota"].ToString();

            try
            {
                TenLoaiSP = row["TenLoaiSP"].ToString();
            }
            catch { }
        }
    }
}
