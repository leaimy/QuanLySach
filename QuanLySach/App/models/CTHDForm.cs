using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App.models
{
    internal class CTHDForm : ChiTietHoaDonDTO
    {
        public string TenSanPham { get; set; }
        public CTHDForm(int MaCTHD, int MaHD, int MaSP, int SoLuong, decimal GiaMua) : base(MaCTHD, MaHD, MaSP, SoLuong, GiaMua)
        {
        }
    }
}
