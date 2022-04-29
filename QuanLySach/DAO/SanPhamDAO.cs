using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class SanPhamDAO
    {
        private SanPhamDAO()
        {

        }

        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAO();
                return instance;
            }
        }

        public List<SanPhamDTO> GetAllProducts()
        {
            var products = new List<SanPhamDTO>();

            var query = "EXEC dbo.sp_GetProducts";
            var table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                products.Add(new SanPhamDTO(item));
            }
            
            return products;
        }

        public List<SanPhamDTO> GetAllProductsWithCategory()
        {
            var products = new List<SanPhamDTO>();

            var query = "EXEC dbo.sp_GetProducts_WithCategory";
            var table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                products.Add(new SanPhamDTO(item));
            }
            
            return products;
        }

        public SanPhamDTO Create(string TenSP, decimal GiaBan, int TheLoai, string MoTa)
        {
            string query = "EXEC dbo.sp_CreateNewProduct @Name , @Price , @Category , @Desc";

            object[] param = new object[] { TenSP, GiaBan, TheLoai, MoTa };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new SanPhamDTO(row);
            }

            return null;
        }
    }
}
