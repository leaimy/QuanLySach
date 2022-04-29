using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DTO
{
    public class ChiNhanhDTO
    {
        private int _MaChiNhanh;
        private string _Ten;
        private string _DiaChi;
        private string _MoTa;

        public int MaChiNhanh { get { return _MaChiNhanh; } set { _MaChiNhanh = value; } }
        public string Ten { get { return _Ten; } set { _Ten = value; } }
        public string DiaChi { get { return _DiaChi; } set { _DiaChi = value;} }
        public string MoTa { get { return _MoTa; } set { _MoTa = value; } }

        public ChiNhanhDTO()
        {

        }

        public ChiNhanhDTO(int MaChiNhanh, string Ten, string DiaChi, string MoTa)
        {
            this.MaChiNhanh = MaChiNhanh;
            this.Ten = Ten;
            this.DiaChi = DiaChi;
            this.MoTa = MoTa;
        }

        public ChiNhanhDTO(DataRow row)
        {
            this.MaChiNhanh = (int)row["MaChiNhanh"];
            this.Ten = row["Ten"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.MoTa = row["MoTa"].ToString();
        }
    }
}
