using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class CategoryController
    {
        private List<LoaiSanPhamDTO> categories;
        private CategoryController()
        {
            categories = LoaiSanPhamDAO.Instance.GetAllCategoriesWithParent();
        }

        private static CategoryController instance; 
        public static CategoryController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryController();
                return instance;
            }
        }

        public List<LoaiSanPhamDTO> GetCategories()
        {
            return categories.GetRange(0, categories.Count);
        }

        public List<LoaiSanPhamDTO> GetParentCategories()
        {
            return categories.Where(s => s.ParentID == 0).ToList();
        }

        public List<LoaiSanPhamDTO> GetParentCategoriesForCombobox()
        {
            var parents = categories.Where(s => s.ParentID == 0).ToList();

            parents.Insert(0, new DTO.LoaiSanPhamDTO
            {
                MaLoaiSP = 0,
                TenLoaiSP = "Chọn nhóm cha"
            });

            return parents;
        }

        public List<LoaiSanPhamDTO> FilterByName(string name)
        {
            return categories.Where(s => s.TenLoaiSP.ToLower().Contains(name)).ToList();
        }

        public List<LoaiSanPhamDTO> FilterByParentID(int pID)
        {
            return categories.Where(s => s.ParentID == pID).ToList();
        }
        
        public LoaiSanPhamDTO CreateNew(string Ten, string MoTa, int ParentID)
        {
            var result = LoaiSanPhamDAO.Instance.Create(Ten, MoTa, ParentID);

            if (result != null)
            {
                int pID = result.ParentID;

                if (pID != 0)
                {
                    var p = categories.Find(s => s.MaLoaiSP == pID);
                    result.TenLoaiSPCha = p.TenLoaiSP;
                }

                categories.Add(result);
            }
            
            return result;
        }
    }
}
