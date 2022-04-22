using QuanLySach.App;
using QuanLySach.App.models;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class frmThemTaiKhoan : Form
    {

        public string LoginName { get; private set; }
        public string Password { get; private set; }
        public int UserID { get; private set; }

        public RoleEnum Role { get; private set; }

        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            cbRoles.DataSource = RoleController.Instance.GetRolesForCombobox();
            cbRoles.ValueMember = "Code";
            cbRoles.DisplayMember = "Title";

            cbStaff.DataSource = StaffController.Instance.GetStaffsForCombobox();
            cbStaff.ValueMember = "MaNhanVien";
            cbStaff.DisplayMember = "HoVaTen";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoginName = txtName.Text;
            Password = txtPass.Text;

            Role selectedRole = cbRoles.SelectedItem as Role;
            NhanVienDTO selectedStaff = cbStaff.SelectedItem as NhanVienDTO;

            Role = selectedRole.Code;
            UserID = selectedStaff.MaNhanVien;

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
