using QuanLySach.App;
using QuanLySach.DAO;
using QuanLySach.DTO;
using QuanLySach.DTO.Statistics;
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

            cbTenNV.DataSource = StaffController.Instance.GetStaffsForCombobox();
            cbTenNV.ValueMember = "MaNhanVien";
            cbTenNV.DisplayMember = "HoVaTen";

            RenderHoaDonDatagridview(BillController.Instance.GetBillsToday());
            #endregion

            #region Thong Ke San Pham
            tp_ST_Product_cbCategory.DataSource = CategoryController.Instance.GetChildCategoriesForCombobox();
            tp_ST_Product_cbCategory.ValueMember = "MaLoaiSP";
            tp_ST_Product_cbCategory.DisplayMember = "TenLoaiSP";

            tp_ST_Product_cbBranches.DataSource = BranchController.Instance.GetBranchesForCombobox();
            tp_ST_Product_cbBranches.ValueMember = "Code";
            tp_ST_Product_cbBranches.DisplayMember = "Title";

            tp_ST_Product_txtVisibleNumber.Value = 10;
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

        private void btnFilterMonthLastDate_Click(object sender, EventArgs e)
        {
            var yesterday = DateTime.Today.AddDays(-1);

            BillController.Instance.GetBillsInRange(yesterday, yesterday);
            RenderHoaDonDatagridview(BillController.Instance.Clone());
        }

        private void btnFilterBillToday_Click(object sender, EventArgs e)
        {
            BillController.Instance.GetBillsToday();
            RenderHoaDonDatagridview(BillController.Instance.Clone());
        }

        private void btnFilterBillCurrentMonth_Click(object sender, EventArgs e)
        {
            BillController.Instance.GetBillsThisMonth();
            RenderHoaDonDatagridview(BillController.Instance.Clone());
        }

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenNV.SelectedIndex == -1) return;

            var selected = cbTenNV.SelectedItem as NhanVienDTO;
            RenderHoaDonDatagridview(BillController.Instance.FilterByStaff(selected.MaNhanVien));
        }

        private void txtFilterBillByCPhone_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtFilterBillByCPhone.Text.Trim();
            RenderHoaDonDatagridview(BillController.Instance.FilterByCustomerPhoneNumber(keyword));
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

        #region Thong Ke San Pham

        private void tp_ST_Product_btnST_Click(object sender, EventArgs e)
        {
            DateTime from = tp_ST_Product_dtpFrom.Value;
            DateTime to = tp_ST_Product_dtpTo.Value;

            RenderProductStatisticDataGridView(ProductStatisticController.Instance.FetchStatistics(from, to));
        }

        private void tp_ST_Product_cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tp_ST_Product_cbCategory.SelectedIndex == -1)
                return;

            LoaiSanPhamDTO item = tp_ST_Product_cbCategory.SelectedItem as LoaiSanPhamDTO;
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.FilterByCategory(item.MaLoaiSP));
        }

        private void tp_ST_Product_txtBookname_TextChanged(object sender, EventArgs e)
        {
            string keyword = tp_ST_Product_txtBookname.Text;
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.FilterByName(keyword));
        }

        private void tp_ST_Product_txtVisibleNumber_ValueChanged(object sender, EventArgs e)
        {
            int visibleCount = Convert.ToInt32(tp_ST_Product_txtVisibleNumber.Value);
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.Take(visibleCount));
        }

        private void RenderProductStatisticDataGridView(List<TKSanPhamDTO> statistics)
        {
            tp_ST_Product_dgvProduct.DataSource = statistics;

            tp_ST_Product_dgvProduct.Columns[0].Visible = false;
            tp_ST_Product_dgvProduct.Columns[2].Visible = false;
            
            tp_ST_Product_dgvProduct.Columns[1].HeaderText = "Tên SP";
            tp_ST_Product_dgvProduct.Columns[3].HeaderText = "Thể loại";
            tp_ST_Product_dgvProduct.Columns[4].HeaderText = "SL Bán";
            tp_ST_Product_dgvProduct.Columns[5].HeaderText = "Giá";
            tp_ST_Product_dgvProduct.Columns[6].HeaderText = "Ước Tính";

            string starting = $"Có {ProductStatisticController.Instance.Count} thống kê ";
            if (ProductStatisticController.Instance.Count == 0)
            {
                starting = "Không có thống kê ";
            }

            if (ProductStatisticController.Instance.FromDate != null)
            {
                tp_ST_Product_dgvContainer.Text = starting + $"từ ngày {ProductStatisticController.Instance.FromDate.ToString("dd-MM-yyyy HH:mm:ss")} đến ngày {ProductStatisticController.Instance.ToDate.ToString("dd-MM-yyyy HH:mm:ss")}";
            }
        }
        #endregion

    }
}
