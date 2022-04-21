using QuanLySach.DTO.Statistics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    internal class ThongKeDAO
    {
        private ThongKeDAO()
        {

        }

        private static ThongKeDAO instance;
        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongKeDAO();
                return instance;
            }
        }

        public List<TKSanPhamDTO> GetProductStatistics(DateTime From, DateTime To)
        {
            DateTime start = new DateTime(
                From.Year,
                From.Month,
                From.Day,
                0,
                0,
                0,
                From.Kind
            );

            DateTime end = new DateTime(
                To.Year,
                To.Month,
                To.Day,
                23,
                59,
                59,
                To.Kind
            );

            var statistics = new List<TKSanPhamDTO>();

            var query = "EXEC dbo.sp_GetProductStatistics @From_Date , @To_Date";
            object[] param = new object[] { start.ToString("yyyy-MM-dd HH:mm:ss"), end.ToString("yyyy-MM-dd HH:mm:ss") };

            var table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow item in table.Rows)
            {
                statistics.Add(new TKSanPhamDTO(item));
            }

            return statistics;
        }
    }
}
