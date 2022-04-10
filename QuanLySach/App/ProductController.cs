using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class ProductController
    {
        private ProductController()
        {
            products = new List<SanPhamDTO>();
        }

        private static ProductController instance;
        public static ProductController Instance
        {
            get { return instance ?? (instance = new ProductController()); }
        }

        private List<SanPhamDTO> products;

        public void FetchNew()
        {
            products = SanPhamDAO.Instance.GetAllProducts();
        }

        public List<SanPhamDTO> FilterByName(string keyword)
        {
            keyword = keyword.ToLower().Trim();
            return products.Where(s => s.TenSP.ToLower().Contains(keyword)).ToList();
        }

        public List<SanPhamDTO> GetProducts() => Clone();

        public List<SanPhamDTO> Clone()
        {
            return products.GetRange(0, products.Count);
        }
    }
}
