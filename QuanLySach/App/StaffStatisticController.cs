using QuanLySach.DAO;
using QuanLySach.DTO.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    public class StaffStatisticController
    {
        List<TKNhanVienDTO> staffs;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        private bool sortStaffIDDesc = true;
        private bool sortByOutputQuantityDesc = true;
        private bool sortByTotalDesc = true;


        private StaffStatisticController()
        {
            staffs = new List<TKNhanVienDTO>();
        }

        private static StaffStatisticController instance;
        public static StaffStatisticController Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffStatisticController();
                return instance;
            }
        }

        public List<TKNhanVienDTO> FetchStatistics(DateTime from, DateTime to)
        {
            FromDate = new DateTime(
                from.Year,
                from.Month,
                from.Day,
                0,
                0,
                0,
                from.Kind
            );

            ToDate = new DateTime(
                to.Year,
                to.Month,
                to.Day,
                23,
                59,
                59,
                to.Kind
            );

            staffs = ThongKeDAO.Instance.GetStaffStatistic(FromDate, ToDate);
            return Clone();
        }

        public List<TKNhanVienDTO> Refetch()
        {
            FetchStatistics(FromDate, ToDate);
            return Clone();
        }
        
        public List<TKNhanVienDTO> FetchStatisticsToDay()
        {
            FetchStatistics(DateTime.Now, DateTime.Now);
            return Clone();
        }

        public List<TKNhanVienDTO> FetchStatisticsThisMonth()
        {
            var now = DateTime.Now;
            var lastDayOfMonth = DateTime.DaysInMonth(now.Year, now.Month);

            DateTime From = new DateTime(
                now.Year,
                now.Month,
                1,
                0,
                0,
                0,
                now.Kind
            );

            DateTime To = new DateTime(
                now.Year,
                now.Month,
                lastDayOfMonth,
                23,
                59,
                59,
                now.Kind
            );

            FetchStatistics(From, To);
            return Clone();
        }

        public List<TKNhanVienDTO> Clone() => staffs.GetRange(0, staffs.Count);

        public List<TKNhanVienDTO> FetchAllBranch()
        {
            staffs = ThongKeDAO.Instance.GetStaffStatisticAllBranch(FromDate, ToDate);
            return Clone();
        }

        public void ToggleSortStaffID()
        {
            SortByStaffID(sortStaffIDDesc);
            sortStaffIDDesc = !sortStaffIDDesc;
        }

        public void ToggleSortSoleQuantity()
        {
            SortBySoleQuantity(sortByOutputQuantityDesc);
            sortByOutputQuantityDesc = !sortByOutputQuantityDesc;
        }

        public void ToggleSortTotalQuantity()
        {
            SortByTotal(sortByTotalDesc);
            sortByTotalDesc = !sortByTotalDesc;
        }

        public void SortByStaffID(bool Desc = true)
        {
            if (!Desc)
                staffs = staffs.OrderBy(s => s.MaNhanVien).ToList();
            else
                staffs = staffs.OrderByDescending(s => s.MaNhanVien).ToList();
        }

        public void SortBySoleQuantity(bool Desc = true)
        {
            if (!Desc)
                staffs = staffs.OrderBy(s => s.SL_BAN).ToList();
            else
                staffs = staffs.OrderByDescending(s => s.SL_BAN).ToList();
        }

        public void SortByTotal(bool Desc = true)
        {
            if (!Desc)
                staffs = staffs.OrderBy(s => s.Tong_Tien).ToList();
            else
                staffs = staffs.OrderByDescending(s => s.Tong_Tien).ToList();
        }
    }
}

