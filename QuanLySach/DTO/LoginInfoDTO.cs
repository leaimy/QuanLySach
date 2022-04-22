using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    internal class LoginInfoDTO
    {
        public int NhanVienID { get; set; }
        public string VaiTro { get; set; }

        public LoginInfoDTO()
        {

        }

        public LoginInfoDTO(DataRow row)
        {
            try
            {
                NhanVienID = Convert.ToInt32(row["Id"]);
            }
            catch { }

            try
            {
                VaiTro = row["ROLENAME"].ToString();
            }
            catch { }

            try
            {
                NhanVienID = Convert.ToInt32(row["UserName"]);
            }
            catch { }

            try
            {
                VaiTro = row["RoleName"].ToString();
            }
            catch { }
        }
    }
}
