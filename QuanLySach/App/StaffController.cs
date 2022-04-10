﻿using QuanLySach.DAO;
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
            return staffs.GetRange(0, staffs.Count);
        }

        public List<NhanVienDTO> FilterByPhoneNumber(string phone)
        {
            return staffs.Where(s => s.SDT.Contains(phone)).ToList();
        }

        public void FetchNew()
        {
            staffs = NhanVienDAO.Instance.GetAllStaffWithBranch();
        }
    }
}