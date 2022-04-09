using QuanLySach.App;
using QuanLySach.App.models;
using QuanLySach.Common;
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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            var frm = new frmQuanLySach();
            frm.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private List<SanPhamDTO> danhSachSanPham;
        private List<CTHDForm> hoaDon;

        private void frmSach_Load(object sender, EventArgs e)
        {
            tssLabel.Text = $"" +
                $"Xin chào: {AppManager.Instance.User.HoVaTen} - " +
                $"Tên đăng nhập: {AppManager.Instance.User.TenDangNhap} - " +
                $"Chi nhánh: {AppManager.Instance.User.ChiNhanh.Ten} - " +
                $"Nhóm: {AppManager.Instance.User.ChucVuVN}";

            danhSachSanPham = SanPhamDAO.Instance.GetAllProducts();
            hoaDon = new List<CTHDForm>();
            RenderDatagridView(danhSachSanPham);
        }

        private void RenderDatagridView(List<SanPhamDTO> products)
        {
            dgvSach.DataSource = products;

            dgvSach.Columns[0].Visible = false;
            dgvSach.Columns[3].Visible = false;
            dgvSach.Columns[4].Visible = false;

            dgvSach.Columns[1].HeaderText = "Tên SP";
            dgvSach.Columns[2].HeaderText = "Giá";
        }

        private void RenderDatagridViewForBill(List<CTHDForm> billDetails)
        {
            dgvCTBH.DataSource = billDetails;

            dgvCTBH.Columns[1].Visible = false;
            dgvCTBH.Columns[2].Visible = false;
            dgvCTBH.Columns[3].Visible = false;

            dgvCTBH.Columns[0].HeaderText = "Tên";
            dgvCTBH.Columns[4].HeaderText = "Số Lượng";
            dgvCTBH.Columns[5].HeaderText = "Giá";
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.Trim().ToLower();
            var filtered = danhSachSanPham.Where(s => s.TenSP.ToLower().Contains(keyword)).ToList();

            RenderDatagridView(filtered);
        }

        private void btnAddProductToBill_Click(object sender, EventArgs e)
        {
            var sanpham = dgvSach.SelectedRows[0].DataBoundItem as SanPhamDTO;
            bool isExist = false;

            for(int i = 0; i< hoaDon.Count; i++)
            {
                if (sanpham.MaSP == hoaDon[i].MaSP)
                {
                    hoaDon[i].SoLuong += Convert.ToInt32(txtProductQuantity.Value);
                    isExist = true;
                    break;
                }
            }
            var cthd = new CTHDForm(1, 1, 1, 1, 1);
            cthd.TenSanPham = sanpham.TenSP;
            cthd.MaSP = sanpham.MaSP;
            cthd.GiaMua = sanpham.GiaBan;
            cthd.SoLuong = Convert.ToInt32(txtProductQuantity.Value);

            if (!isExist) hoaDon.Add(cthd);
            RenderDatagridViewForBill(hoaDon.GetRange(0, hoaDon.Count));

            decimal tongTien = tinhTong(hoaDon);

            lblTongTien.Text = tongTien.ToString();

            decimal tongTienSauGiamGia = tongTien - (tongTien * (nmGiamGia.Value / 100));
            lblTongTienCuoiCung.Text = tongTienSauGiamGia.ToString();
            lblTongTienGhiBangChu.Text = MoneyHelper.So_chu(Convert.ToDouble(tongTienSauGiamGia));
        }

        private void btnRemoveProductFromBill_Click(object sender, EventArgs e)
        {
            if (dgvCTBH.SelectedRows.Count == 0) return;

            var cthd = dgvCTBH.SelectedRows[0].DataBoundItem as CTHDForm;

            var filterd = hoaDon.Where(s => s.MaSP != cthd.MaSP).ToList();
            hoaDon = filterd;
            RenderDatagridViewForBill(filterd);

            decimal tongTien = tinhTong(hoaDon);

            lblTongTien.Text = tongTien.ToString();

            decimal tongTienSauGiamGia = tongTien - (tongTien * (nmGiamGia.Value / 100));
            lblTongTienCuoiCung.Text = tongTienSauGiamGia.ToString();
            lblTongTienGhiBangChu.Text = MoneyHelper.So_chu(Convert.ToDouble(tongTienSauGiamGia));
        }

        private decimal tinhTong(List<CTHDForm> hoaDon)
        {
            decimal tong = 0;
            
            foreach (var cthd in hoaDon)
            {
                tong += cthd.SoLuong * cthd.GiaMua;
            }

            return tong;
        }

        private void nmGiamGia_ValueChanged(object sender, EventArgs e)
        {
            decimal tongTien = tinhTong(hoaDon);

            decimal tongTienSauGiamGia = tongTien - (tongTien * (nmGiamGia.Value / 100));
            lblTongTienCuoiCung.Text = tongTienSauGiamGia.ToString();
            lblTongTienGhiBangChu.Text = MoneyHelper.So_chu(Convert.ToDouble(tongTienSauGiamGia));
        }
    }
}
