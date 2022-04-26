using QuanLySach.App;
using QuanLySach.App.models;
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
        private bool isFirstLoad = true;

        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            if (AppManager.Instance.IsNewLoggedInSession)
            {
                AppManager.Instance.IsNewLoggedInSession = false;

                StaffController.Instance.GetStaffs();
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
            cbChiNhanhNV.DataSource = BranchController.Instance.GetBranchesForCombobox();
            cbChiNhanhNV.ValueMember = "Code";
            cbChiNhanhNV.DisplayMember = "Title";
            cbChiNhanhNV.SelectedIndex = -1;

            RenderNhanVienDatagridview(StaffController.Instance.GetStaffs());
            #endregion

            #region Hoa Don 
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;

            cbTenNV.DataSource = StaffController.Instance.GetStaffsForCombobox();
            cbTenNV.ValueMember = "MaNhanVien";
            cbTenNV.DisplayMember = "HoVaTen";
            cbTenNV.SelectedIndex = -1;

            cbChiNhanh.DataSource = BranchController.Instance.GetBranchesForCombobox();
            cbChiNhanh.ValueMember = "Code";
            cbChiNhanh.DisplayMember = "Title";
            cbChiNhanh.SelectedIndex = -1;

            nmBillVisibleCounter.Value = 10;

            RenderHoaDonDatagridview(BillController.Instance.GetBillsToday());
            #endregion

            #region Tai Khoan 
            tp_Account_cbRoles.DataSource = RoleController.Instance.GetRolesForCombobox();
            tp_Account_cbRoles.ValueMember = "Code";
            tp_Account_cbRoles.DisplayMember = "Title";
            tp_Account_cbRoles.SelectedIndex = -1;

            tp_Account_cbBranches.DataSource = BranchController.Instance.GetBranchesForCombobox();
            tp_Account_cbBranches.ValueMember = "Code";
            tp_Account_cbBranches.DisplayMember = "Title";
            tp_Account_cbBranches.SelectedIndex = -1;

            RenderAccountDatagridview(AccountController.Instance.FetchStaffs());
            #endregion

            #region Thong Ke San Pham
            tp_ST_Product_cbCategory.DataSource = CategoryController.Instance.GetChildCategoriesForCombobox();
            tp_ST_Product_cbCategory.ValueMember = "MaLoaiSP";
            tp_ST_Product_cbCategory.DisplayMember = "TenLoaiSP";
            tp_ST_Product_cbCategory.SelectedIndex = -1;

            tp_ST_Product_cbBranches.DataSource = BranchController.Instance.GetBranchesForCombobox();
            tp_ST_Product_cbBranches.ValueMember = "Code";
            tp_ST_Product_cbBranches.DisplayMember = "Title";
            tp_ST_Product_cbBranches.SelectedIndex = -1;

            tp_ST_Product_txtVisibleNumber.Value = 10;
            #endregion

            #region Thong Ke Khach Hang
            cbCN.DataSource = BranchController.Instance.GetBranchesForCombobox();
            cbCN.ValueMember = "Code";
            cbCN.DisplayMember = "Title";
            cbCN.SelectedIndex = -1;
            #endregion

            #region Thong Ke Nhan Vien
            tp_ST_Staff_cbBranch.DataSource = BranchController.Instance.GetBranchesForCombobox();
            tp_ST_Staff_cbBranch.ValueMember = "Code";
            tp_ST_Staff_cbBranch.DisplayMember = "Title";
            tp_ST_Staff_cbBranch.SelectedIndex = -1;
            #endregion

            isFirstLoad = false;
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
            if (isFirstLoad) return;

            string keyword = txtTenLoai.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword)) return;

            RenderLoaiSachDatagridview(CategoryController.Instance.FilterByName(keyword));
        }

        private void cbFilterLoaiSPCha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;
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
            if (isFirstLoad) return;
            if (cbLoaiSach.SelectedIndex == -1) return;

            var selected = cbLoaiSach.SelectedItem as LoaiSanPhamDTO;
            RenderSachDatagridview(ProductController.Instance.FilterByCategory(selected.MaLoaiSP));
        }

        private void txtFilterProductByName_TextChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

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
            if (isFirstLoad) return;

            var keyword = txtFilterStaffByPhone.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                RenderNhanVienDatagridview(StaffController.Instance.GetStaffs());
                return;
            }

            RenderNhanVienDatagridview(StaffController.Instance.FilterByPhoneNumber(keyword));
        }

        private void cbChiNhanhNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            var selectItem = cbChiNhanhNV.SelectedItem as Branch;
            DataProvider.Instance.SetRemoteAccount(selectItem.Code);

            AppManager.Instance.User.SetBranchName(selectItem.Code);

            if (selectItem.Code == ChiNhanhEnum.CN_GOC)
            {
                RenderNhanVienDatagridview(StaffController.Instance.GetStaffsAllBranch());
            }
            else
            {
                RenderNhanVienDatagridview(StaffController.Instance.GetStaffs());
            }
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            var frm = new frmThemNhanVien();
            frm.ShowDialog();
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

            RenderBillStatisticOverview();
        }

        void RenderBillStatisticOverview()
        {
            BillOverview overview = BillController.Instance.StatOverview;

            txtBillTotalExpected.Text = overview.Subtotal.ToString();
            txtBillDiscountTotal.Text = overview.DiscountTotal.ToString();
            txtBillTotal.Text = overview.Total.ToString();
            txtBillNumberCounter.Text = overview.TotalBill.ToString();
            txtBillCustomerCounter.Text = overview.CustomerCount.ToString();
            txtBillStaffCounter.Text = overview.StaffCount.ToString();
        }

        private void btnFilterBillInRange_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFromDate.Value;
            var toDate = dtpToDate.Value;

            BillController.Instance.GetBillsInRange(fromDate, toDate);
            RenderHoaDonDatagridview(BillController.Instance.Take(getBillVisibleCount()));
        }

        private void btnFilterMonthLastDate_Click(object sender, EventArgs e)
        {
            var yesterday = DateTime.Today.AddDays(-1);

            BillController.Instance.GetBillsInRange(yesterday, yesterday);
            RenderHoaDonDatagridview(BillController.Instance.Take(getBillVisibleCount()));
        }

        private void btnFilterBillToday_Click(object sender, EventArgs e)
        {
            BillController.Instance.GetBillsToday();
            RenderHoaDonDatagridview(BillController.Instance.Take(getBillVisibleCount()));
        }

        private void btnFilterBillCurrentMonth_Click(object sender, EventArgs e)
        {
            BillController.Instance.GetBillsThisMonth();
            RenderHoaDonDatagridview(BillController.Instance.Take(getBillVisibleCount()));
        }

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            if (cbTenNV.SelectedIndex == -1) return;

            var selected = cbTenNV.SelectedItem as NhanVienDTO;
            RenderHoaDonDatagridview(BillController.Instance.FilterByStaff(selected.MaNhanVien));
        }

        private void txtFilterBillByCPhone_TextChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            var keyword = txtFilterBillByCPhone.Text.Trim();
            RenderHoaDonDatagridview(BillController.Instance.FilterByCustomerPhoneNumber(keyword));
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            var selectItem = cbChiNhanh.SelectedItem as Branch;
            if (selectItem == null) return;

            DataProvider.Instance.SetRemoteAccount(selectItem.Code);

            AppManager.Instance.User.SetBranchName(selectItem.Code);

            if (selectItem.Code == ChiNhanhEnum.CN_GOC)
            {
                BillController.Instance.GetBillsAllBranch();
                RenderHoaDonDatagridview(BillController.Instance.Take(getBillVisibleCount()));
            }
            else
            {
                BillController.Instance.Refetch();
                RenderHoaDonDatagridview(BillController.Instance.Take(getBillVisibleCount()));
            }
        }

        private void btnBillResetFilter_Click(object sender, EventArgs e)
        {
            cbChiNhanh.SelectedIndex = -1;
            cbTenNV.SelectedIndex = -1;
            txtFilterBillByCPhone.ResetText();

            RenderHoaDonDatagridview(BillController.Instance.Take(getBillVisibleCount()));
        }

        private void nmBillVisibleCounter_ValueChanged(object sender, EventArgs e)
        {

            RenderHoaDonDatagridview(BillController.Instance.Take(getBillVisibleCount()));
        }

        int getBillVisibleCount()
        {
            try
            {
                int visibleCount = Convert.ToInt32(nmBillVisibleCounter.Value);
                return visibleCount > 0 ? visibleCount : 0;
            }
            catch
            {
                return 0;
            }
        }
        #endregion

        #region Thong Ke San Pham

        private void tp_ST_Product_btnST_Click(object sender, EventArgs e)
        {
            DateTime from = tp_ST_Product_dtpFrom.Value;
            DateTime to = tp_ST_Product_dtpTo.Value;

            RenderProductStatisticDataGridView(ProductStatisticController.Instance.FetchStatistics(from, to));
        }

        private void tp_ST_Product_cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            if (tp_ST_Product_cbCategory.SelectedIndex == -1)
                return;

            LoaiSanPhamDTO item = tp_ST_Product_cbCategory.SelectedItem as LoaiSanPhamDTO;
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.FilterByCategory(item.MaLoaiSP));
        }

        private void tp_ST_Product_txtBookname_TextChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            string keyword = tp_ST_Product_txtBookname.Text;
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.FilterByName(keyword));
        }

        private void tp_ST_Product_txtVisibleNumber_ValueChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

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
        private void tp_ST_Product_btnToday_Click(object sender, EventArgs e)
        {
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.FetchStatisticsToDay());
        }

        private void tp_ST_Product_btnThisMonth_Click(object sender, EventArgs e)
        {
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.FetchStatisticsThisMonth());
        }

        private void tp_ST_Product_btnReset_Click(object sender, EventArgs e)
        {
            int visibleCount = Convert.ToInt32(tp_ST_Product_txtVisibleNumber.Value);
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.Take(visibleCount));

            tp_ST_Product_txtBookname.ResetText();
            tp_ST_Product_cbCategory.ResetText();
        }

        private void tp_ST_Product_dgvProduct_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 4:
                    ProductStatisticController.Instance.ToggleSortQuantity();
                    break;

                case 5:
                    ProductStatisticController.Instance.ToggleSortPrice();
                    break;

                case 6:
                    ProductStatisticController.Instance.ToggleSortTotal();
                    break;

                default:
                    return;
            }

            int visibleCount = Convert.ToInt32(tp_ST_Product_txtVisibleNumber.Value);
            RenderProductStatisticDataGridView(ProductStatisticController.Instance.Take(visibleCount));
        }

        private void tp_ST_Product_cbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            var selectItem = tp_ST_Product_cbBranches.SelectedItem as Branch;
            DataProvider.Instance.SetRemoteAccount(selectItem.Code);

            AppManager.Instance.User.SetBranchName(selectItem.Code);

            if (selectItem.Code == ChiNhanhEnum.CN_GOC)
            {
                RenderProductStatisticDataGridView(ProductStatisticController.Instance.FetchAllBranch());
            }
            else
            {
                RenderProductStatisticDataGridView(ProductStatisticController.Instance.Refetch());
            }

        }
        #endregion

        #region Thong Ke Khach Hang
        private void btnTK_Click(object sender, EventArgs e)
        {
            var ngayBD = dtpNgayBD.Value;
            var ngayKT = dtpNgayKT.Value;

            dtgvKhachHang.DataSource = CustomerController.Instance.FetchCustomer(ngayBD, ngayKT);
        }

        private void RenderCustomerStaticDataGridView(List<ThongKeKhachHangDTO> customers)
        {
            dtgvKhachHang.DataSource = customers;

            dtgvKhachHang.Columns[0].HeaderText = "SDT";
            dtgvKhachHang.Columns[1].HeaderText = "Tên KH";
            dtgvKhachHang.Columns[2].HeaderText = "Số lượng hoá đơn";
            dtgvKhachHang.Columns[3].HeaderText = "Tổng tiền";
            dtgvKhachHang.Columns[4].HeaderText = "Được giảm giá";
            dtgvKhachHang.Columns[5].HeaderText = "Tiền phải trả";

            string starting = $"Có {CustomerController.Instance.Count} thống kê ";
            if (CustomerController.Instance.Count == 0)
            {
                starting = "Không có thống kê";
            }

            if (CustomerController.Instance.FromDate != null)
            {
                grbKhachHang.Text = starting + $"từ ngày {CustomerController.Instance.FromDate.ToString("dd-MM-yyyy HH:mm:ss")} đến ngày {CustomerController.Instance.ToDate.ToString("dd-MM-yyyy HH:mm:ss")}";
            }
        }
        private void dtgvKhachHang_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    CustomerController.Instance.SapXepTheoSoLuongHoaDon();
                    break;
                case 3:
                    CustomerController.Instance.SapXepTheoTongTien();
                    break;
                case 4:
                    CustomerController.Instance.SapXepTheoDuocGiamGia();
                    break;
                case 5:
                    CustomerController.Instance.SapXepTheoTienPhaiTra();
                    break;

                default:
                    return;

            }

            RenderCustomerStaticDataGridView(CustomerController.Instance.Clone());
        }



        #endregion

        #region Tai Khoan
        private void tp_Account_btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmThemTaiKhoan();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string loginName = frm.LoginName;
                string password = frm.Password;
                RoleEnum role = frm.Role;
                int userID = frm.UserID;

                try
                {
                    AccountController.Instance.CreateNewAccount(loginName, password, role, userID);
                    RenderAccountDatagridview(AccountController.Instance.Clone());

                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tp_Account_btnReload_Click(object sender, EventArgs e)
        {
            RenderAccountDatagridview(AccountController.Instance.Clone());
        }

        private void RenderAccountDatagridview(List<NhanVienDTO> staffs)
        {
            tp_Account_dgvAccount.DataSource = staffs;
            tp_Account_dgvAccount.Columns[1].Visible = false;
            tp_Account_dgvAccount.Columns[3].Visible = false;
            tp_Account_dgvAccount.Columns[4].Visible = false;
            tp_Account_dgvAccount.Columns[5].Visible = false;
            tp_Account_dgvAccount.Columns[6].Visible = false;
            tp_Account_dgvAccount.Columns[7].Visible = false;
            tp_Account_dgvAccount.Columns[8].Visible = false;

            tp_Account_dgvAccount.Columns[0].HeaderText = "Mã NV";
            tp_Account_dgvAccount.Columns[2].HeaderText = "Chức Vụ";
            tp_Account_dgvAccount.Columns[9].HeaderText = "Tên CN";
            tp_Account_dgvAccount.Columns[10].HeaderText = "Họ tên";
        }

        private void tp_Account_cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            var selectedItem = tp_Account_cbRoles.SelectedItem as Role;
            RenderAccountDatagridview(AccountController.Instance.FilterByRole(selectedItem.Code));
        }

        private void tp_Account_cbBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            var selectItem = tp_Account_cbBranches.SelectedItem as Branch;
            DataProvider.Instance.SetRemoteAccount(selectItem.Code);

            AppManager.Instance.User.SetBranchName(selectItem.Code);

            if (selectItem.Code == ChiNhanhEnum.CN_GOC)
            {
                RenderAccountDatagridview(AccountController.Instance.FetchStaffsAllBranch());
            }
            else
            {
                RenderAccountDatagridview(AccountController.Instance.FetchStaffs());
            }
        }
        #endregion

        #region Thong Ke Nhan Vien
        private void tp_ST_Staff_cbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFirstLoad) return;

            var selectItem = tp_ST_Staff_cbBranch.SelectedItem as Branch;
            if (selectItem == null) return;

            DataProvider.Instance.SetRemoteAccount(selectItem.Code);

            AppManager.Instance.User.SetBranchName(selectItem.Code);

            if (selectItem.Code == ChiNhanhEnum.CN_GOC)
            {
                RenderStaffStatisticDataGridView(StaffStatisticController.Instance.FetchAllBranch());
            }
            else
            {
                RenderStaffStatisticDataGridView(StaffStatisticController.Instance.Refetch());
            }
        }

        private void tp_ST_Staff_btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime from = tp_ST_Staff_dtpFrom.Value;
            DateTime to = tp_ST_Staff_dtpTo.Value;

            RenderStaffStatisticDataGridView(StaffStatisticController.Instance.FetchStatistics(from, to));
        }

        private void tp_ST_Staff_btnReload_Click(object sender, EventArgs e)
        {
            tp_ST_Staff_cbBranch.SelectedIndex = -1;

            RenderStaffStatisticDataGridView(StaffStatisticController.Instance.Clone());
        }

        void RenderStaffStatisticDataGridView(List<TKNhanVienDTO> staffs)
        {
            tp_ST_Staff_dgvStaff.DataSource = staffs;

            tp_ST_Staff_dgvStaff.Columns[1].Visible = false;
            tp_ST_Staff_dgvStaff.Columns[2].Visible = false;
            tp_ST_Staff_dgvStaff.Columns[4].Visible = false;

            tp_ST_Staff_dgvStaff.Columns[0].HeaderText = "Mã NV";
            tp_ST_Staff_dgvStaff.Columns[3].HeaderText = "Họ Tên";
            tp_ST_Staff_dgvStaff.Columns[5].HeaderText = "CN";
            tp_ST_Staff_dgvStaff.Columns[6].HeaderText = "SL Bán";
            tp_ST_Staff_dgvStaff.Columns[7].HeaderText = "Tổng Tiên";
        }

        private void tp_ST_Staff_dgvStaff_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    StaffStatisticController.Instance.ToggleSortStaffID();
                    break;

                case 6:
                    StaffStatisticController.Instance.ToggleSortSoleQuantity();
                    break;

                case 7:
                    StaffStatisticController.Instance.ToggleSortTotalQuantity();
                    break;

                default:
                    return;
            }

            RenderStaffStatisticDataGridView(StaffStatisticController.Instance.Clone());
        }
        #endregion

    }
}
