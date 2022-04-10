using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App.models
{
    internal class CartItem
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaMua { get; set; }

        public decimal ThanhTien
        {
            get
            {
                return GiaMua * SoLuong;
            }
        }
    }
}
