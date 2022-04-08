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
        }

        private void RenderDatagridViewForBill(List<CTHDForm> billDetails)
        {
            dgvCTBH.DataSource = billDetails;

            dgvCTBH.Columns[1].Visible = false;
            dgvCTBH.Columns[2].Visible = false;
            dgvCTBH.Columns[3].Visible = false;
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

            var cthd = new CTHDForm(1, 1, 1, 1, 1);
            cthd.TenSanPham = sanpham.TenSP;
            cthd.MaSP = sanpham.MaSP;
            cthd.GiaMua = sanpham.GiaBan;
            cthd.SoLuong = Convert.ToInt32(txtProductQuantity.Value);

            hoaDon.Add(cthd);
            RenderDatagridViewForBill(hoaDon.GetRange(0, hoaDon.Count));
        }

        private void btnRemoveProductFromBill_Click(object sender, EventArgs e)
        {
            if (dgvCTBH.SelectedRows.Count == 0) return;

            var cthd = dgvCTBH.SelectedRows[0].DataBoundItem as CTHDForm;

            var filterd = hoaDon.Where(s => s.MaSP != cthd.MaSP).ToList();
            hoaDon = filterd;
            RenderDatagridViewForBill(filterd);
        }
    }
}
