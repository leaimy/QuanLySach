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
            var now = DateTime.Now;

            From = new DateTime(
                now.Year,
                now.Month,
                now.Day,
                0,
                0,
                0,
                now.Kind
            );

            To = new DateTime(
                now.Year,
                now.Month,
                now.Day,
                23,
                59,
                59,
                now.Kind
            );

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
            From = new DateTime(
                from.Year,
                from.Month,
                from.Day,
                0,
                0,
                0,
                from.Kind
            );

            To = new DateTime(
                to.Year,
                to.Month,
                to.Day,
                23,
                59,
                59,
                to.Kind
            );

            bills = HoaDonDAO.Instance.GetBillsInRange(from, to);
            return Clone();
        }

        public List<HoaDonDTO> GetBillsToday()
        {
            var now = DateTime.Now;

            From = new DateTime(
                now.Year,
                now.Month,
                now.Day,
                0,
                0,
                0,
                now.Kind
            );

            To = new DateTime(
                now.Year,
                now.Month,
                now.Day,
                23,
                59,
                59,
                now.Kind
            );

            bills = HoaDonDAO.Instance.GetBillsInRange(From, To);
            return Clone();
        }

        public List<HoaDonDTO> GetBillsThisMonth()
        {
            var now = DateTime.Now;
            var lastDayOfMonth = DateTime.DaysInMonth(now.Year, now.Month);

            From = new DateTime(
                now.Year,
                now.Month,
                1,
                0,
                0,
                0,
                now.Kind
            );

            To = new DateTime(
                now.Year,
                now.Month,
                lastDayOfMonth,
                23,
                59,
                59,
                now.Kind
            );

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

        public List<HoaDonDTO> FilterByStaff(int StaffID)
        {
            return bills.Where(s => s.MaNV == StaffID).ToList();
        }

        public List<HoaDonDTO> FilterByCustomerPhoneNumber(string phone)
        {
            return bills.Where(s => s.SDT.Contains(phone)).ToList();
        }
    }
}
