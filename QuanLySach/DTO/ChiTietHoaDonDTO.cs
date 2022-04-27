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
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int MaChiTietHoaDon { get; set; }
        public int MaHoaDon { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaMua { get; set; }
        public decimal ThanhTien { get => SoLuong * GiaMua; }

        public ChiTietHoaDonDTO()
        {

        }

        public ChiTietHoaDonDTO(DataRow row)
        {
            MaSP = Convert.ToInt32(row["MaSP"]);
            TenSP = row["TenSP"].ToString();
            MaChiTietHoaDon = Convert.ToInt32(row["MaChiTietHoaDon"]);
            MaHoaDon = Convert.ToInt32(row["MaHoaDon"]);
            SoLuong = Convert.ToInt32(row["SoLuong"]);
            GiaMua = Convert.ToDecimal(row["GiaMua"]);
        }
    }
}
