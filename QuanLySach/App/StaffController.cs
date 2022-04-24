using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class StaffController
    {
        private List<NhanVienDTO> staffs;
        private StaffController()
        {
            staffs = NhanVienDAO.Instance.GetAllStaffWithBranch();
        }

        private static StaffController instance;
        public static StaffController Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffController();
                return instance;
            }
        }

        public List<NhanVienDTO> GetStaffs()
        {
            staffs = NhanVienDAO.Instance.GetAllStaffWithBranch();
            return Clone();
        }

        public List<NhanVienDTO> GetStaffsAllBranch()
        {
            staffs = NhanVienDAO.Instance.GetAllStaffAllBranch();
            return Clone();
        }

        public List<NhanVienDTO> GetStaffsForCombobox()
        {
            var options = staffs.GetRange(0, staffs.Count);

            options.Insert(0, new NhanVienDTO()
            {
                MaNhanVien = 0,
                HoDem = "Chọn nhân",
                Ten = "viên"
            });

            return options;
        }

        public List<NhanVienDTO> FilterByPhoneNumber(string phone)
        {
            return staffs.Where(s => s.SDT.Contains(phone)).ToList();
        }

        public List<NhanVienDTO> Clone() => staffs.GetRange(0, staffs.Count);
    }
}
