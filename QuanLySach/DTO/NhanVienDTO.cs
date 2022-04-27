using System;
using System.Data;

namespace QuanLySach.DTO
{
    public class NhanVienDTO
    {
        private int _MaNhanVien;
        private int _ChiNhanh;
        private string _ChucVu;
        private string _Ten;
        private string _HoDem;
        private DateTime _NgaySinh;
        private string _DiaChi;
        private string _SDT;
        private decimal _Luong;

        public int MaNhanVien { get { return _MaNhanVien; } set { _MaNhanVien = value; } }
        public int ChiNhanh { get { return _ChiNhanh; } set { _ChiNhanh = value; } }
        public string ChucVu { get { return _ChucVu; } set { _ChucVu = value; } }
        public string Ten { get { return _Ten; } set { _Ten = value; } }
        public string HoDem { get { return _HoDem; } set { _HoDem = value; } }
        public DateTime NgaySinh { get { return _NgaySinh; } set { _NgaySinh = value; } }
        public string DiaChi { get { return _DiaChi; } set { _DiaChi = value; } }
        public string SDT { get { return _SDT; } set { _SDT = value; } }
        public decimal Luong { get { return _Luong; } set { _Luong = value; } }

        public string TenChiNhanh { get; set; }
        public string HoVaTen { get => HoDem + " " + Ten; }

        public NhanVienDTO()
        {
            ChucVu = "N/A";
        }

        public NhanVienDTO(int MaNhanVien, int ChiNhanh, string ChucVu, string Ten, string HoDem, DateTime NgaySinh, string DiaChi, string SDT, decimal Luong)
        {
            this.MaNhanVien = MaNhanVien;
            this.ChiNhanh = ChiNhanh;
            this.ChucVu = ChucVu;
            this.Ten = Ten;
            this.HoDem = HoDem;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.Luong = Luong;
        }

        public NhanVienDTO(DataRow row)
        {
            this.MaNhanVien = (int)row["MaNhanVien"];
            this.Ten = row["Ten"].ToString();
            this.HoDem = row["HoDem"].ToString();
            this.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            this.DiaChi = row["DiaChi"].ToString();
            this.SDT = row["SDT"].ToString();
            this.Luong = Convert.ToDecimal(row["Luong"]);

            try
            {
                this.ChucVu = row["ChucVu"].ToString();
            }
            catch { }

            try
            {
                this.ChiNhanh = (int)row["ChiNhanh"];
            }
            catch { }

            try
            {
                this.ChiNhanh = (int)row["MaChiNhanh"];
            }
            catch { }

            try
            {
                TenChiNhanh = row["TenChiNhanh"].ToString();
            }
            catch { }
        }
    }
}
