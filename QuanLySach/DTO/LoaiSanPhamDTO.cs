using System;
using System.Data;

namespace QuanLySach.DTO
{
    internal class LoaiSanPhamDTO
    {
        private int _MaLoaiSP;
        private string _TenLoaiSP;
        private string _MoTa;
        private int _ParentID;

        public int MaLoaiSP { get { return _MaLoaiSP; } set { _MaLoaiSP = value; } }
        public string TenLoaiSP { set { _TenLoaiSP = value; } get { return _TenLoaiSP; } }
        public string MoTa { set { _MoTa = value; } get { return _MoTa; } }
        public int ParentID { get { return _ParentID; } set { _ParentID = value; } }

        public string TenLoaiSPCha { get; set; }

        public LoaiSanPhamDTO()
        {

        }

        public LoaiSanPhamDTO(int MaLoaiSP, string TenLoaiSP, string MoTa, int ParentID)
        {
            this.MaLoaiSP = MaLoaiSP;
            this.TenLoaiSP = TenLoaiSP;
            this.MoTa = MoTa;
            this.ParentID = ParentID;
        }

        public LoaiSanPhamDTO(DataRow row)
        {
            this.MaLoaiSP = (int)row["MaLoaiSP"];
            this.TenLoaiSP = row["TenLoaiSP"].ToString();
            this.MoTa = row["MoTa"].ToString();
            this.ParentID = (int)row["ParentID"];

            try
            {
                TenLoaiSPCha = row["ParentName"].ToString();
            }
            catch { }
        }
    }
}
