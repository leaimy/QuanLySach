using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO.Statistics
{
    public class TKNhanVienDTO
    {
        public int MaNhanVien { get; set; }
        public string Ten { get; set; }
        public string HoDem { get; set; }
        public string HoVaTen { get => HoDem + " " + Ten; }
        public int MaChiNhanh { get; set; }
        public string Ten_CN { get; set; }
        public int SL_BAN { get; set; }
        public decimal Tong_Tien { get; set; }

        public TKNhanVienDTO()
        {

        }

        public TKNhanVienDTO(DataRow row)
        {
            MaNhanVien = Convert.ToInt32(row["MaNhanVien"]);
            Ten = row["Ten"].ToString();
            HoDem = row["HoDem"].ToString();
            MaChiNhanh = Convert.ToInt32(row["MaChiNhanh"]);
            Ten_CN = row["Ten_CN"].ToString();

            try
            {

                SL_BAN = Convert.ToInt32(row["SL_BAN"]);
            }
            catch
            {
                SL_BAN = 0;
            }

            try
            {
                Tong_Tien = Convert.ToDecimal(row["Tong_Tien"]);
            }
            catch
            {
                Tong_Tien = 0;
            }
        }
    }
}
