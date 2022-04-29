using QuanLySach.App.models;
using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    public class BillController
    {
        private List<HoaDonDTO> bills;

        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int VisibleNumber { get; set; }

        public BillOverview StatOverview { get; set; }

        private BillController()
        {
            var now = DateTime.Now;
            VisibleNumber = 10;

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
            StatOverview = GetOverviewStatistic(bills);
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

        public List<HoaDonDTO> Take(int VisibleNumber)
        {
            this.VisibleNumber = VisibleNumber;
            var filtered = bills.Take(VisibleNumber).ToList();

            return filtered;
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
            StatOverview = GetOverviewStatistic(bills);
            return Take(VisibleNumber);
        }

        public List<HoaDonDTO> GetBillsToday()
        {
            bills = HoaDonDAO.Instance.GetBillsInRange(From, To);
            return Take(VisibleNumber);
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
            return Take(VisibleNumber);
        }

        public List<HoaDonDTO> Refetch()
        {
            return GetBillsInRange(From, To);
        }

        public List<HoaDonDTO> GetBillsAllBranch()
        {
            bills = HoaDonDAO.Instance.GetBillsInRangeAllBranch(From, To);
            StatOverview = GetOverviewStatistic(bills);
            return Take(VisibleNumber);
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

            bills.Add(hoaDon);
            StatOverview = GetOverviewStatistic(bills);

            return true;
        }

        public List<HoaDonDTO> FilterByStaff(int StaffID)
        {
            var filterd = bills.Where(s => s.MaNV == StaffID).ToList();
            StatOverview = GetOverviewStatistic(filterd);
            return filterd;
        }

        public List<HoaDonDTO> FilterByCustomerPhoneNumber(string phone)
        {
            var filtered = bills.Where(s => s.SDT.Contains(phone)).ToList();
            StatOverview = GetOverviewStatistic(filtered);

            return filtered;
        }

        public BillOverview GetOverviewStatistic(List<HoaDonDTO> bills)
        {
            BillOverview overview = new BillOverview();
            Dictionary<string, string> customerCount = new Dictionary<string, string>();
            Dictionary<int, string> staffCount = new Dictionary<int, string>();

            bills.ForEach(b =>
            {
                overview.Subtotal += b.TongTien;
                overview.DiscountTotal += (b.TongTien * (b.GiamGia / 100));

                customerCount[b.SDT] = b.TenKH;
                staffCount[b.MaNV] = b.TenNV;
            });

            overview.TotalBill = bills.Count;
            overview.CustomerCount = customerCount.Count;
            overview.StaffCount = staffCount.Count;
            return overview;
        }

        public List<ChiTietHoaDonDTO> GetBillDetails(int billID)
        {
            return HoaDonDAO.Instance.GetBillDetails(billID);
        }
    }
}
