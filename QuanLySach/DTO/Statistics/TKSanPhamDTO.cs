using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO.Statistics
{
    internal class TKSanPhamDTO
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        public int SoLuongBan { get; set; }
        public decimal GiaBan { get; set; }
        public decimal UocLuongSoTien { get; set; }

        public TKSanPhamDTO()
        {

        }

        public TKSanPhamDTO(DataRow row)
        {
            MaSP = Convert.ToInt32(row["MaSP"]);
            TenSP = row["TenSP"].ToString();
            MaLoaiSP = Convert.ToInt32(row["MaLoaiSP"]);
            TenLoaiSP = row["TenLoaiSP"].ToString();
            SoLuongBan = Convert.ToInt32(row["So luong ban"]);
            GiaBan = Convert.ToDecimal(row["GiaBan"]);
            UocLuongSoTien = Convert.ToDecimal(row["Uoc luong so tien"]);
        }
    }
}
