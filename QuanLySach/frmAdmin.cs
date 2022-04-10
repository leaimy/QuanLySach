﻿using QuanLySach.App;
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
    public partial class frmQuanLySach : Form
    {
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            if (AppManager.Instance.IsNewLoggedInSession)
            {
                AppManager.Instance.IsNewLoggedInSession = false;

                StaffController.Instance.FetchNew();
            }

            UIController.Instance.DisplayStatusBar(tssLoginInfo);

            #region Loai San Pham
            dtgvSach.DataSource = ProductController.Instance.GetProducts();
            cbFilterLoaiSPCha.DataSource = CategoryController.Instance.GetParentCategoriesForCombobox();
            cbFilterLoaiSPCha.ValueMember = "MaLoaiSP";
            cbFilterLoaiSPCha.DisplayMember = "TenLoaiSP";

            RenderLoaiSachDatagridview(CategoryController.Instance.GetCategories());
            #endregion

            #region San Pham 
            cbLoaiSach.DataSource = CategoryController.Instance.GetChildCategoriesForCombobox();
            cbLoaiSach.ValueMember = "MaLoaiSP";
            cbLoaiSach.DisplayMember = "TenLoaiSP";

            RenderSachDatagridview(ProductController.Instance.GetProducts());
            #endregion

            #region Nhan Vien 
            RenderNhanVienDatagridview(StaffController.Instance.GetStaffs());
            #endregion

            #region Hoa Don 
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;

            RenderHoaDonDatagridview(BillController.Instance.GetBillsToday());
            #endregion
        }

        #region Loai San Pham
        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            var frm = new frmThemLoai();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string TenLoai = frm.Ten;
                string MoTa = frm.MoTa;
                int ParentID = frm.ParentID;

                var result = CategoryController.Instance.CreateNew(TenLoai, MoTa, ParentID);

                if (result == null)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình tạo loại sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tạo loại sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                RenderLoaiSachDatagridview(CategoryController.Instance.GetCategories());
            }
        }
        private void btnResetLoaiSach_Click(object sender, EventArgs e)
        {
            RenderLoaiSachDatagridview(CategoryController.Instance.GetCategories());

            txtTenLoai.ResetText();
            cbFilterLoaiSPCha.ResetText();
        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTenLoai.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword)) return;

            RenderLoaiSachDatagridview(CategoryController.Instance.FilterByName(keyword));
        }

        private void cbFilterLoaiSPCha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterLoaiSPCha.SelectedIndex == -1) return;

            LoaiSanPhamDTO selected = cbFilterLoaiSPCha.SelectedItem as LoaiSanPhamDTO;

            RenderLoaiSachDatagridview(CategoryController.Instance.FilterByParentID(selected.MaLoaiSP));
        }

        void RenderLoaiSachDatagridview(List<LoaiSanPhamDTO> categories)
        {
            dtgvLoaiSach.DataSource = categories;

            dtgvLoaiSach.Columns[3].Visible = false;

            dtgvLoaiSach.Columns[0].HeaderText = "Mã";
            dtgvLoaiSach.Columns[1].HeaderText = "Tên";
            dtgvLoaiSach.Columns[2].HeaderText = "Mô tả";
            dtgvLoaiSach.Columns[4].HeaderText = "Nhóm cha";
        }
        #endregion

        #region San Pham 
        void RenderSachDatagridview(List<SanPhamDTO> products)
        {
            dtgvSach.DataSource = products;

            dtgvSach.Columns[3].Visible = false;

            dtgvSach.Columns[0].HeaderText = "Mã";
            dtgvSach.Columns[1].HeaderText = "Tên";
            dtgvSach.Columns[2].HeaderText = "Giá";
            dtgvSach.Columns[4].HeaderText = "Mô tả";
            dtgvSach.Columns[5].HeaderText = "Thể loại";
        }

        private void cbLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiSach.SelectedIndex == -1) return;

            var selected = cbLoaiSach.SelectedItem as LoaiSanPhamDTO;
            RenderSachDatagridview(ProductController.Instance.FilterByCategory(selected.MaLoaiSP));
        }

        private void txtFilterProductByName_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtFilterProductByName.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                RenderSachDatagridview(ProductController.Instance.GetProducts());
                return;
            }

            RenderSachDatagridview(ProductController.Instance.FilterByName(keyword));
        }

        private void btnResetSach_Click(object sender, EventArgs e)
        {
            RenderSachDatagridview(ProductController.Instance.GetProducts());

            cbLoaiSach.ResetText();
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            var frm = new frmThemSach();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string TenSach = frm.TenSach;
                int LoaiSach = frm.LoaiSach;
                decimal GiaBan = frm.GiaBan;
                string MoTa = frm.MoTa;

                if (ProductController.Instance.CreateNew(TenSach, GiaBan, LoaiSach, MoTa) != null)
                {
                    MessageBox.Show("Tạo sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RenderSachDatagridview(ProductController.Instance.GetProducts());
            }
        }

        #endregion

        #region Nhan Vien 
        void RenderNhanVienDatagridview(List<NhanVienDTO> staffs)
        {
            dtgvNV.DataSource = staffs;

            dtgvNV.Columns[1].Visible = false;
            dtgvNV.Columns[2].Visible = false;

            dtgvNV.Columns[0].HeaderText = "Mã";
            dtgvNV.Columns[3].HeaderText = "Tên";
            dtgvNV.Columns[4].HeaderText = "Họ";
            dtgvNV.Columns[5].HeaderText = "Ngày sinh";
            dtgvNV.Columns[6].HeaderText = "Địa chỉ";
            dtgvNV.Columns[7].HeaderText = "SDT";
            dtgvNV.Columns[8].HeaderText = "Lương";
            dtgvNV.Columns[9].HeaderText = "Chi nhánh";
        }

        private void txtFilterStaffByPhone_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtFilterStaffByPhone.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                RenderNhanVienDatagridview(StaffController.Instance.GetStaffs());
                return; 
            }

            RenderNhanVienDatagridview(StaffController.Instance.FilterByPhoneNumber(keyword));
        }
        #endregion

        #region Hoa Don 
        void RenderHoaDonDatagridview(List<HoaDonDTO> bills)
        {
            dtgvBill.DataSource = bills;

            dtgvBill.Columns[1].Visible = false;
            dtgvBill.Columns[5].Visible = false;
            dtgvBill.Columns[8].Visible = false;
            dtgvBill.Columns[9].Visible = false;
            dtgvBill.Columns[10].Visible = false;

            dtgvBill.Columns[0].HeaderText = "Mã";
            dtgvBill.Columns[2].HeaderText = "Ngày mua";
            dtgvBill.Columns[3].HeaderText = "Tổng";
            dtgvBill.Columns[4].HeaderText = "Giảm giá";
            dtgvBill.Columns[6].HeaderText = "KH";
            dtgvBill.Columns[7].HeaderText = "SDT";
            dtgvBill.Columns[11].HeaderText = "NV";

            grBillContainer.Text = "Danh sách hóa đơn từ ngày: " + BillController.Instance.From.ToString("dd-MM-yyyy HH:mm:ss") + " đến ngày " + BillController.Instance.To.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void btnFilterBillInRange_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFromDate.Value;
            var toDate = dtpToDate.Value;

            BillController.Instance.GetBillsInRange(fromDate, toDate);
            RenderHoaDonDatagridview(BillController.Instance.Clone());
        }

        private void btnFilterBillToday_Click(object sender, EventArgs e)
        {
            BillController.Instance.GetBillsToday();
            RenderHoaDonDatagridview(BillController.Instance.Clone());
        }
        #endregion

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tpLoaiSach_Click(object sender, EventArgs e)
        {

        }


        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            var frm = new frmThemNhanVien();
            frm.ShowDialog();
        }

    }
}
