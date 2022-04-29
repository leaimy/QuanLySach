using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    public class ProductController
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
            products = SanPhamDAO.Instance.GetAllProductsWithCategory();
        }

        public List<SanPhamDTO> FilterByName(string keyword)
        {
            keyword = keyword.ToLower().Trim();
            return products.Where(s => s.TenSP.ToLower().Contains(keyword)).ToList();
        }

        public List<SanPhamDTO> FilterByCategory(int categoryID)
        {
            return products.Where(s => s.LoaiSanPham == categoryID).ToList();
        }

        public List<SanPhamDTO> GetProducts() => Clone();

        public List<SanPhamDTO> Clone()
        {
            return products.GetRange(0, products.Count);
        }

        public SanPhamDTO CreateNew(string TenSP, decimal GiaBan, int TheLoai, string MoTa)
        {
            var sanPham = SanPhamDAO.Instance.Create(TenSP, GiaBan, TheLoai, MoTa);

            if (sanPham != null)
            {
                var cat = CategoryController.Instance.GetByID(sanPham.LoaiSanPham);
                sanPham.TenLoaiSP = cat.TenLoaiSP;
            }

            return sanPham;
        }
    }
}
