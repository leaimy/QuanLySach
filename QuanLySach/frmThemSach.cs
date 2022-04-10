using QuanLySach.App;
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
    public partial class frmThemSach : Form
    {
        public string TenSach;
        public int LoaiSach;
        public decimal GiaBan;
        public string MoTa;

        public frmThemSach()
        {
            InitializeComponent();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            cbLoaiSach.DataSource = CategoryController.Instance.GetChildCategoriesForCombobox();
            cbLoaiSach.ValueMember = "MaLoaiSP";
            cbLoaiSach.DisplayMember = "TenLoaiSP";
        }

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

                cbLoaiSach.Items.Add(result);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TenSach = txtName.Text;
            GiaBan = txtPrice.Value; 
            MoTa = txtMota.Text;

            var selected = cbLoaiSach.SelectedItem as LoaiSanPhamDTO;
            LoaiSach = selected.MaLoaiSP;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
