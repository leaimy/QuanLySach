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
    public partial class frmChangeStaffBranch : Form
    {
        private NhanVienDTO staff;
        public frmChangeStaffBranch(NhanVienDTO staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        public string Ten { get; set; }
        public string HoDem { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public decimal Luong { get; set; }
        public DateTime NgaySinh { get; set; }
        public Branch branch { get; set; }
        public Role role { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }


        private void frmChangeStaffBranch_Load(object sender, EventArgs e)
        {
            txtAddress.Text = staff.DiaChi;
            txtFirstName.Text = staff.Ten;
            txtLastName.Text = staff.HoDem;
            txtPhoneNumber.Text = staff.SDT;
            txtSalary.Text = staff.Luong.ToString();
            dtpNgaySinh.Value = staff.NgaySinh;

            cbBranch.DataSource = BranchController.Instance.GetBranchesForCombobox();
            cbBranch.ValueMember = "Code";
            cbBranch.DisplayMember = "Title";
            cbBranch.SelectedIndex = -1;

            cbRole.DataSource = RoleController.Instance.GetRolesForCombobox();
            cbRole.ValueMember = "Code";
            cbRole.DisplayMember = "Title";
            cbRole.SelectedIndex = -1;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            DiaChi = txtAddress.Text;
            Ten = txtFirstName.Text;
            HoDem = txtLastName.Text;
            SDT = txtPhoneNumber.Text;
            Luong = Convert.ToDecimal(txtSalary.Text);
            NgaySinh = dtpNgaySinh.Value;
            branch = cbBranch.SelectedItem as Branch;
            role = cbRole.SelectedItem as Role;

            UserName = txtUserName.Text;
            Password = txtPassword.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
