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

        public void TrashStaffByID(int id)
        {
            NhanVienDAO.Instance.TrashByID(id);
        }

        public NhanVienDTO CreateNewStaff(string ten, string hoDem, string diaChi, string sdt, decimal luong, DateTime ngaySinh, ChiNhanhEnum branch)
        {
            if (branch == ChiNhanhEnum.CN_1)
                return NhanVienDAO.Instance.Create(1, ten, hoDem, ngaySinh, diaChi, sdt, luong);

            return NhanVienDAO.Instance.Create(2, ten, hoDem, ngaySinh, diaChi, sdt, luong);
        }

        public void TransferStaff(int id, string ten, string hoDem, string diaChi, string sdt, decimal luong, DateTime ngaySinh, Branch branch, Role role, string username, string password)
        {
            // Delete staff at current branch 
            TrashStaffByID(id);

            // Change connection string to new branch
            DataProvider.Instance.SetRemoteAccount(branch.Code);

            // Create new staff with the given information
            NhanVienDTO newStaff = CreateNewStaff(ten, hoDem, diaChi, sdt, luong, ngaySinh, branch.Code);

            // Create new account for staff to login
            AccountController.Instance.CreateNewAccount(username, password, role.Code, newStaff.MaNhanVien);
        }
    }
}
