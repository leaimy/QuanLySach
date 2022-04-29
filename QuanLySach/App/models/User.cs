using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App.models
{
    public class User
    {
        // Database login info
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        // Personal info
        public string Ten { get; set; }
        public string HoDem { get; set; }
        public string ChucVu { set; get; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public decimal Luong { get; set; }

        public int ChiNhanhID { get; set; }
        public int MaNhanVien { get; set; }

        private ChiNhanhDTO chiNhanh;

        // Utils prop
        public string HoVaTen
        {
            get
            {
                return HoDem + " " + Ten;
            }
        }

        public ChiNhanhDTO ChiNhanh
        {
            get
            {
                if (chiNhanh == null)
                {
                    chiNhanh = ChiNhanhDAO.Instance.GetChiNhanhByID(ChiNhanhID);
                }

                return chiNhanh;
            }
        }

        public string ChucVuVN
        {
            get
            {
                switch (ChucVu)
                {
                    case "GIAMDOC":
                        return "Giám Đốc";

                    case "QLCHINHANH":
                        return "Quản Lý Chi Nhánh";

                    case "NHANVIEN":
                        return "Nhân Viên";

                    default:
                        return "N/A";
                }
            }
        }

        private void SetBranchDalat()
        {
            ChiNhanh.Ten = "Đà Lạt";
        }

        private void SetBranchBaoLoc()
        {
            ChiNhanh.Ten = "Bảo Lộc";
        }

        private void SetBranchAll()
        {
            ChiNhanh.Ten = "Toàn bộ công ty";
        }

        public void SetBranchName(ChiNhanhEnum b)
        {
            switch (b)
            {
                case ChiNhanhEnum.CN_1:
                    SetBranchDalat();
                    break;

                case ChiNhanhEnum.CN_2:
                    SetBranchBaoLoc();
                    break;

                case ChiNhanhEnum.CN_GOC:
                    SetBranchAll();
                    break;
            }
        }
    }
}
