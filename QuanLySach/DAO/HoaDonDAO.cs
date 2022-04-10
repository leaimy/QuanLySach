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
    }
}
