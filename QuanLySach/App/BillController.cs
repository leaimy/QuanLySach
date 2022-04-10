using QuanLySach.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class BillController
    {
        private BillController()
        {

        }
        private static BillController instance;
        public static BillController Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillController();
                return instance;
            }
        }

        public bool CreateBill()
        {
            int MaNV = AppManager.Instance.User.MaNhanVien;
            decimal TongTien = AppManager.Instance.Cart.TotalWithoutDiscount;
            decimal GiamGia = AppManager.Instance.Cart.Discount;
            DateTime NgayThanhToan = DateTime.Now;
            string TenKH = AppManager.Instance.Customer.HoTen;
            string SDT = AppManager.Instance.Customer.SDT;

            var hoaDon = HoaDonDAO.Instance.Create(MaNV, TongTien, GiamGia, NgayThanhToan, TenKH, SDT);

            if (hoaDon == null) return false;

            AppManager.Instance.Cart.Clear();
            AppManager.Instance.Customer = null;

            return true;
        }
    }
}
