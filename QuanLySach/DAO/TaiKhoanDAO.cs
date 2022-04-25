using QuanLySach.App.models;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    internal class TaiKhoanDAO
    {
        private TaiKhoanDAO()
        {

        }

        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
        }

        public List<LoginInfoDTO> GetAccountsRaw()
        {
            List<LoginInfoDTO> accounts = new List<LoginInfoDTO>();

            string query = "EXEC dbo.sp_GetAllLogins";

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                accounts.Add(new LoginInfoDTO(row));
            }

            return accounts;
        }

        public List<LoginInfoDTO> GetAccountsRawAllBranch()
        {
            List<LoginInfoDTO> accounts = new List<LoginInfoDTO>();

            string query = "EXEC dbo.sp_GetLoginsAllBranch";

            DataTable table = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in table.Rows)
            {
                accounts.Add(new LoginInfoDTO(row));
            }

            return accounts;
        }

        public List<NhanVienDTO> GetAccounts()
        {
            List<NhanVienDTO> staffs = NhanVienDAO.Instance.GetAllStaffWithBranch();

            Dictionary<int, NhanVienDTO> lookup = new Dictionary<int, NhanVienDTO>();
            staffs.ForEach(s => lookup[s.MaNhanVien] = s);

            List<LoginInfoDTO> accounts = GetAccountsRaw();

            foreach (LoginInfoDTO account in accounts)
            {
                try
                {
                    lookup[account.NhanVienID].ChucVu = account.VaiTro;
                }
                catch
                {
                    continue;
                }
            }


            return staffs;
        }

        public List<NhanVienDTO> GetAccountsAllBranch()
        {
            List<NhanVienDTO> staffs = NhanVienDAO.Instance.GetAllStaffAllBranch();

            Dictionary<int, NhanVienDTO> lookup = new Dictionary<int, NhanVienDTO>();
            staffs.ForEach(s => lookup[s.MaNhanVien] = s);

            List<LoginInfoDTO> accounts = GetAccountsRawAllBranch();

            foreach (LoginInfoDTO account in accounts)
            {
                try
                {
                    lookup[account.NhanVienID].ChucVu = account.VaiTro;
                }
                catch
                {
                    continue;
                }
            }


            return staffs;
        }

        public void CreateAccount(string loginName, string password, RoleEnum role, int staffID)
        {
            string query = "EXEC dbo.sp_TaoTaiKhoan @LGNAME , @PASS , @USERNAME , @ROLE";

            string roleStr = "NHANVIEN";

            if (role == RoleEnum.QLCHINHANH) roleStr = "QLCHINHANH";
            else if (role == RoleEnum.GIAMDOC) roleStr = "GIAMDOC";

            object[] param = new object[] { loginName, password, staffID, roleStr };

            object result = DataProvider.Instance.ExecuteScalar(query, param);

            try
            {
                int code = Convert.ToInt32(result);
                if (code != 0)
                    throw new Exception("Có lỗi trong quá trình tạo tài khoản, thử lại sau");
            }
            catch
            {
                throw;
            }
        }
    }
}
