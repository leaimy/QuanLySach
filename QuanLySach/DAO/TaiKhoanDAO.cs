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
    }
}
