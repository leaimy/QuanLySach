using QuanLySach.DAO;
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
    public partial class frmThemLoai : Form
    {
        public string Ten;
        public string MoTa;
        public int ParentID;

        public frmThemLoai()
        {
            InitializeComponent();
        }

        private void frmThemLoai_Load(object sender, EventArgs e)
        {
            var parents = LoaiSanPhamDAO.Instance.GetAllParentCategories();

            parents.Insert(0, new DTO.LoaiSanPhamDTO
            {
                MaLoaiSP = 0,
                TenLoaiSP = "Chọn nhóm cha"
            });

            cbParentID.DataSource = parents;
            cbParentID.ValueMember = "MaLoaiSP";
            cbParentID.DisplayMember = "TenLoaiSP";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Ten = txtName.Text;
            MoTa = txtMota.Text;
            ParentID = (int)cbParentID.SelectedValue;

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
