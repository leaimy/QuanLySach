using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    internal class SanPhamDAO
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
    }


}
