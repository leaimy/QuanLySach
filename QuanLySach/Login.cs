using QuanLySach.App;
using QuanLySach.App.models;
using QuanLySach.DAO;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbChiNhanh.Items.Add("Chi nhánh 01");
            cbChiNhanh.Items.Add("Chi nhánh 02");
        }

        private void btnLocHD_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtLoginName.Text;
                string password = txtPassword.Text;
                string branch = cbChiNhanh.SelectedItem.ToString();

                int who = 1;
                if (rdHa.Checked) who = 2;

                if (branch == "Chi nhánh 01")
                {
                    DataProvider.Instance.InitConnectionString(ChiNhanhEnum.CN_1, userName, password, who);
                }
                else
                {
                    DataProvider.Instance.InitConnectionString(ChiNhanhEnum.CN_2, userName, password, who);
                }

                LoginInfoDTO loginInfo = AuthDAO.Instance.GetLoginInfo(userName);
                NhanVienDTO nhanVien = NhanVienDAO.Instance.GetNhanVienByID(loginInfo.NhanVienID);

                AppManager.Instance.User = new App.models.User()
                {
                    TenDangNhap = userName,
                    MatKhau = password,
                    ChiNhanhID = nhanVien.ChiNhanh,
                    ChucVu = loginInfo.VaiTro,
                    DiaChi = nhanVien.DiaChi,
                    HoDem = nhanVien.HoDem,
                    Luong = nhanVien.Luong,
                    MaNhanVien = nhanVien.MaNhanVien,
                    NgaySinh = nhanVien.NgaySinh,
                    SDT = nhanVien.SDT,
                    Ten = nhanVien.Ten
                };
                AppManager.Instance.IsNewLoggedInSession = true;

                var frm = new frmSach();

                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                this.Show();
            }
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppManager.Instance.IsNewLoggedInSession = true;
        }
    }
}
