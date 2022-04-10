using QuanLySach.App;
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
            UIController.Instance.DisplayStatusBar(tssLoginInfo);

            dtgvSach.DataSource = ProductController.Instance.GetProducts();
            cbFilterLoaiSPCha.DataSource = CategoryController.Instance.GetParentCategoriesForCombobox();
            cbFilterLoaiSPCha.ValueMember = "MaLoaiSP";
            cbFilterLoaiSPCha.DisplayMember = "TenLoaiSP";

            RenderLoaiSachDatagridview(CategoryController.Instance.GetCategories());
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

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tpLoaiSach_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            var frm = new frmThemSach();
            frm.ShowDialog();
        }


        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            var frm = new frmThemNhanVien();
            frm.ShowDialog();
        }

    }
}
