using QuanLySach.App.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    internal class RoleController
    {
        private RoleController()
        {

        }

        private static RoleController instance;
        public static RoleController Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoleController();
                return instance;
            }
        }

        public List<Role> GetRolesForCombobox()
        {
            List<Role> roles = new List<Role>()
            {
                new Role() { Title = "Giám đốc", Code = RoleEnum.GIAMDOC },
                new Role() { Title = "Quản lý CN", Code = RoleEnum.QLCHINHANH },
                new Role() { Title = "Nhân viên CN", Code = RoleEnum.NHANVIEN },
            };

            return roles;
        }
    }
}
