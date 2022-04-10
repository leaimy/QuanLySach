using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class BillController
    {
        private List<HoaDonDTO> bills;
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        private BillController()
        {
            From = DateTime.Now;
            To = DateTime.Now;

            bills = new List<HoaDonDTO>();
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

        public List<HoaDonDTO> Clone()
        {
            return bills.GetRange(0, bills.Count);
        }

        public List<HoaDonDTO> GetBillsInRange(DateTime from, DateTime to)
        {
            From = from;
            To = to;

            bills = HoaDonDAO.Instance.GetBillsInRange(from, to);
            return Clone();
        }

        public List<HoaDonDTO> GetBillsToday()
        {
            From = DateTime.Now;
            To = DateTime.Now;

            bills = HoaDonDAO.Instance.GetBillsInRange(From, To);
            return Clone();
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
