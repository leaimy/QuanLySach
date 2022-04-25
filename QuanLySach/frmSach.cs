using QuanLySach.App;
using QuanLySach.App.models;
using QuanLySach.Common;
using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            UIController.Instance.DisplayStatusBar(tssLabel);
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            ProductController.Instance.FetchNew();
            UIController.Instance.DisplayListOfProduct(dgvSach);
            UIController.Instance.DisplayStatusBar(tssLabel);
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            UIController.Instance.DisplayListOfFilteredProduct(dgvSach, txtTimKiem.Text);
        }

        private void btnAddProductToBill_Click(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count == 0) return;

            var sanpham = dgvSach.SelectedRows[0].DataBoundItem as SanPhamDTO;
            var CartItem = new CartItem()
            {
                GiaMua = sanpham.GiaBan,
                MaSP = sanpham.MaSP,
                SoLuong = Convert.ToInt32(txtProductQuantity.Value),
                TenSP = sanpham.TenSP
            };

            AppManager.Instance.Cart.AddToCart(CartItem);
            UIController.Instance.DisplayCart(dgvCTBH);

            lblTongTien.Text = AppManager.Instance.Cart.TotalWithoutDiscount.ToString();
            lblTongTienCuoiCung.Text = AppManager.Instance.Cart.TotalWithDiscount.ToString();
            lblTongTienGhiBangChu.Text = MoneyHelper.So_chu(Convert.ToDouble(AppManager.Instance.Cart.TotalWithDiscount));

            txtProductQuantity.Value = 1;
        }

        private void btnRemoveProductFromBill_Click(object sender, EventArgs e)
        {
            if (dgvCTBH.SelectedRows.Count == 0) return;

            var cthd = dgvCTBH.SelectedRows[0].DataBoundItem as CartItem;
            AppManager.Instance.Cart.RemoveFromCart(cthd.MaSP, Convert.ToInt32(txtProductQuantity.Value));

            UIController.Instance.DisplayCart(dgvCTBH);

            lblTongTien.Text = AppManager.Instance.Cart.TotalWithoutDiscount.ToString();
            lblTongTienCuoiCung.Text = AppManager.Instance.Cart.TotalWithDiscount.ToString();
            lblTongTienGhiBangChu.Text = MoneyHelper.So_chu(Convert.ToDouble(AppManager.Instance.Cart.TotalWithDiscount));

            txtProductQuantity.Value = 1;
        }

        private void nmGiamGia_ValueChanged(object sender, EventArgs e)
        {
            AppManager.Instance.Cart.Discount = nmGiamGia.Value;

            lblTongTien.Text = AppManager.Instance.Cart.TotalWithoutDiscount.ToString();
            lblTongTienCuoiCung.Text = AppManager.Instance.Cart.TotalWithDiscount.ToString();
            lblTongTienGhiBangChu.Text = MoneyHelper.So_chu(Convert.ToDouble(AppManager.Instance.Cart.TotalWithDiscount));
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string sdt = txtSDT.Text;

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt)) return;

            AppManager.Instance.Customer = new Customer()
            {
                HoTen = hoTen,
                SDT = sdt,
            };

            var frm = new frmBill();
            var result = frm.ShowDialog();

            if (result != DialogResult.OK) return;

            if (BillController.Instance.CreateBill())
            {
                MessageBox.Show("Tạo hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình tạo hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenCustomer_Click(object sender, EventArgs e)
        {
            var instance = new CustomerFakeData();
            var result = instance.GetRandomPair();

            txtHoTen.Text = result["name"];
            txtSDT.Text = result["phone"];
        }

        private void Reset()
        {
            lblTongTien.ResetText();
            lblTongTienCuoiCung.ResetText();
            lblTongTienGhiBangChu.ResetText();

            txtHoTen.ResetText();
            txtSDT.ResetText();

            nmGiamGia.Value = 0;
            AppManager.Instance.Cart.Clear();

            UIController.Instance.DisplayCart(dgvCTBH);
        }
    }
}
