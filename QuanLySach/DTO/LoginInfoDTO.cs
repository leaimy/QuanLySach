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
            NhanVienID = Convert.ToInt32(row["Id"]);
            VaiTro = row["ROLENAME"].ToString();
        }
    }
}
