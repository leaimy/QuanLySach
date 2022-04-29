using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    public class LoaiSanPhamDAO
    {
        private LoaiSanPhamDAO()
        {

        }

        private static LoaiSanPhamDAO instance;
        public static LoaiSanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiSanPhamDAO();
                return instance;
            }
        }

        public List<LoaiSanPhamDTO> GetAllCategories()
        {
            var products = new List<LoaiSanPhamDTO>();

            var query = "EXEC dbo.sp_GetCategories";
            var table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                products.Add(new LoaiSanPhamDTO(item));
            }
            
            return products;
        }
        
        public List<LoaiSanPhamDTO> GetAllCategoriesWithParent()
        {
            var products = new List<LoaiSanPhamDTO>();

            var query = "EXEC dbo.sp_GetCategories_WithParent";
            var table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                products.Add(new LoaiSanPhamDTO(item));
            }
            
            return products;
        }

        public List<LoaiSanPhamDTO> GetAllParentCategories()
        {
            var products = new List<LoaiSanPhamDTO>();

            var query = "EXEC dbo.sp_GetAllParentCategories";
            var table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                products.Add(new LoaiSanPhamDTO(item));
            }
            
            return products;
        }

        public LoaiSanPhamDTO Create(string TenLoaiSP, string MoTa, int ParentID)
        {
            string query = "EXEC dbo.sp_CreateNewCategory @Name , @Desc , @ParentID";

            object[] param = new object[] { TenLoaiSP, MoTa, ParentID };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new LoaiSanPhamDTO(row);
            }

            return null;
        }
    }
}
