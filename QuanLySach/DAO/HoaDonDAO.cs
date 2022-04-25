using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    internal class HoaDonDAO
    {

        private HoaDonDAO()
        {

        }

        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
        }

        public List<HoaDonDTO> GetBillsInRange(DateTime From, DateTime To)
        {
            var bills = new List<HoaDonDTO>();

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

            var query = "EXEC dbo.sp_GetBills_InRange @From_Date , @To_Date";
            object[] param = new object[] { start.ToString("yyyy-MM-dd HH:mm:ss"), end.ToString("yyyy-MM-dd HH:mm:ss") };

            var table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow item in table.Rows)
            {
                bills.Add(new HoaDonDTO(item));
            }

            return bills;
        }

        public List<HoaDonDTO> GetBillsInRangeAllBranch(DateTime From, DateTime To)
        {
            var bills = new List<HoaDonDTO>();

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

            var query = "EXEC dbo.sp_GetBills_InRange_AllBranch @From_Date , @To_Date";
            object[] param = new object[] { start.ToString("yyyy-MM-dd HH:mm:ss"), end.ToString("yyyy-MM-dd HH:mm:ss") };

            var table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow item in table.Rows)
            {
                bills.Add(new HoaDonDTO(item));
            }

            return bills;
        }

        public HoaDonDTO Create(int MaNV, decimal TongTien, decimal GiamGia, DateTime NgayThanhToan, string TenKH, string SDT)
        {
            string query = "EXEC dbo.sp_CreateBill @Staff_ID , @Total , @Discount , @Checkout_Date , @Customer_Name , @Customer_Phone";

            string ngayThanhToan = NgayThanhToan.ToString("yyyy-MM-dd HH:mm:ss");
            object[] param = new object[] { MaNV, TongTien, GiamGia, ngayThanhToan, TenKH, SDT };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new HoaDonDTO(row);
            }

            return null;
        }

        public List<ThongKeKhachHangDTO> ThongKeKhachHang(DateTime From, DateTime To)
        {
            var customers = new List<ThongKeKhachHangDTO>();

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

            var query = "EXECUTE dbo.sp_DSKhachHangCungSoTien_TheoThoiGian @ngayBD , @ngayKT ";

            object[] param = new object[] { start.ToString("yyyy-MM-dd HH:mm:ss"), end.ToString("yyyy-MM-dd HH:mm:ss") };

            var table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow item in table.Rows)
            {
                customers.Add(new ThongKeKhachHangDTO(item));
            }

            return customers;
        }
    }
}
