using System.Data;

namespace QuanLySach.DTO
{
    internal class SanPhamDTO
    {
        private int _MaSP;
        private string _TenSP;
        private decimal _GiaBan;
        private int _LoaiSanPham;
        private string _Mota;

        public int MaSP { get { return _MaSP; } set { _MaSP = value; } }
        public string TenSP { set { _TenSP = value; } get { return _TenSP; } }
        public decimal GiaBan { get { return _GiaBan; } set { GiaBan = value; } }
        public int LoaiSanPham { get { return _LoaiSanPham; } set { LoaiSanPham = value; } }
        public string Mota { get { return _Mota; } set { _Mota = value; } }

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
            this.GiaBan = (decimal)row["GiaBan"];
            this.LoaiSanPham = (int)row["LoaiSanPham"];
            this.Mota = row["Mota"].ToString();
        }
    }
}
