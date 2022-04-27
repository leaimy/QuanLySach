using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    internal class NhanVienDAO
    {
        private NhanVienDAO()
        {

        }

        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
        }

        public List<NhanVienDTO> GetAllStaff()
        {
            var products = new List<NhanVienDTO>();

            var query = "EXEC dbo.sp_GetAllStaff";
            var table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                products.Add(new NhanVienDTO(item));
            }
            
            return products;
        }

        public List<NhanVienDTO> GetAllStaffWithBranch()
        {
            var products = new List<NhanVienDTO>();

            var query = "EXEC dbo.sp_GetAllStaff_WithBranch";
            var table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                products.Add(new NhanVienDTO(item));
            }
            
            return products;
        }

        public List<NhanVienDTO> GetAllStaffAllBranch()
        {
            var products = new List<NhanVienDTO>();

            var query = "EXEC dbo.sp_GetAllStaffAllBranch";
            var table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                products.Add(new NhanVienDTO(item));
            }
            
            return products;
        }

        public NhanVienDTO GetNhanVienByID(int id)
        {
            string query = "EXEC sp_GetNhanVien_ByID @ID";
            object[] param = new object[] { id };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new NhanVienDTO(row);
            }

            return null;
        }

        public NhanVienDTO Create(int MaChiNhanh, string Ten, string HoDem, DateTime NgaySinh, string DiaChi, string SDT, decimal Luong)
        {
            string query = "EXEC dbo.sp_CreateNewStaff @Branch , @First_Name , @Last_Name , @DateOfBirth , @Address , @Phone , @Salary";

            object[] param = new object[] { MaChiNhanh, Ten, HoDem, NgaySinh.ToString("yyyy-MM-dd HH:mm:ss"), DiaChi, SDT, Luong };

            DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

            foreach (DataRow row in table.Rows)
            {
                return new NhanVienDTO(row);
            }

            return null;
        }

        public void TrashByID(int id)
        {
            string query = "EXEC dbo.sp_TrashStaffByID @ID";
            object[] param = new object[] { id };

            DataProvider.Instance.ExecuteQuery(query, param);
        }
    }
}
