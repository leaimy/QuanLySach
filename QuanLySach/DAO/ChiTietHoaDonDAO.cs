using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class ChiTietHoaDonDAO
    {
        private ChiTietHoaDonDAO()
        {

        }

        private static ChiTietHoaDonDAO instance;
        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietHoaDonDAO();
                return instance;
            }
        }
        
        public ChiTietHoaDonDTO Create(int MaHD, int MaSP, int SoLuong, decimal Gia)
        {
            string query = "EXEC dbo.sp_CreateBillDetail @Bill_ID @Product_ID @Quantity @Price";
            object[] param = new object[] { MaHD, MaSP, SoLuong, Gia };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new ChiTietHoaDonDTO(row);
            }

            return null;
        }
    }
}
