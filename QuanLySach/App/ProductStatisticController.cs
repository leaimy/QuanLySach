using QuanLySach.DAO;
using QuanLySach.DTO.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class ProductStatisticController
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int VisibleLimit { get; set; }

        private ProductStatisticController()
        {
            statistics = new List<TKSanPhamDTO>();
            VisibleLimit = 10;

            FetchStatisticsToDay();
        }

        private static ProductStatisticController instance;
        public static ProductStatisticController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductStatisticController();
                return instance;
            }
        }

        List<TKSanPhamDTO> statistics;

        public List<TKSanPhamDTO> FetchStatistics(DateTime from, DateTime to)
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

            statistics = ThongKeDAO.Instance.GetProductStatistics(FromDate, ToDate);
            return Take(VisibleLimit);
        }

        public List<TKSanPhamDTO> FetchStatisticsToDay()
        {
            FetchStatistics(DateTime.Now, DateTime.Now);
            return Take(VisibleLimit);
        }

        public List<TKSanPhamDTO> FetchStatisticsThisMonth()
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
            return Take(VisibleLimit);
        }

        public List<TKSanPhamDTO> FilterByCategory(int CategoryID) => statistics.Where(s => s.MaLoaiSP == CategoryID).Take(VisibleLimit).ToList();
        public List<TKSanPhamDTO> FilterByName(string Name)
        {
            Name = Name.ToLower().Trim();
            if (string.IsNullOrEmpty(Name)) return Take(VisibleLimit);

            return statistics.Where(s => s.TenSP.ToLower().Contains(Name)).Take(VisibleLimit).ToList();    
        }

        public List<TKSanPhamDTO> Take(int Number)
        {
            return statistics.Take(Number).ToList();
        }
        
        public List<TKSanPhamDTO> Clone()
        {
            return statistics.GetRange(0, statistics.Count);
        }

        public int Count => statistics.Count;
    }
}
