using QuanLySach.App.models;
using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class AccountController
    {
        private AccountController()
        {
            staffs = new List<NhanVienDTO>();
        }

        private static AccountController instance;
        public static AccountController Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountController();
                return instance;
            }
        }

        private List<NhanVienDTO> staffs;

        public List<NhanVienDTO> FetchStaffs()
        {
            staffs = TaiKhoanDAO.Instance.GetAccounts();
            return Clone();
        }

        public List<NhanVienDTO> Clone() => staffs.GetRange(0, staffs.Count);

        public void CreateNewAccount(string loginName, string password, RoleEnum role, int staffID)
        {
            TaiKhoanDAO.Instance.CreateAccount(loginName, password, role, staffID);
            FetchStaffs();
        }

        public List<NhanVienDTO> FilterByRole(RoleEnum role)
        {
            string roleStr = "NHANVIEN";

            if (role == RoleEnum.QLCHINHANH) roleStr = "QLCHINHANH";
            else if (role == RoleEnum.GIAMDOC) roleStr = "GIAMDOC";

            return staffs.Where(s => s.ChucVu == roleStr).ToList();
        }
    }
}
