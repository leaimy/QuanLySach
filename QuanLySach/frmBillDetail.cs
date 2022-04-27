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
    public partial class frmBillDetail : Form
    {
        private HoaDonDTO bill;
        
        public frmBillDetail(HoaDonDTO bill)
        {
            InitializeComponent();
            this.bill = bill;
        }

        private void frmBillDetail_Load(object sender, EventArgs e)
        {
            this.Text = "Danh mục sản phẩm của hóa đơn #" + this.bill.MaHoaDon;
            txtCustomerName.Text = bill.TenKH;
            txtDateCheckout.Text = bill.NgayMua.ToString("dd-MM-yyyy HH:mm:ss");
            txtDiscount.Text = bill.GiamGia + "%";
            txtTotal.Text = bill.TongTien.ToString();
            txtStaffName.Text = bill.HoDemNV + " " + bill.TenNV;

            dtgvBillDetails.DataSource = BillController.Instance.GetBillDetails(this.bill.MaHoaDon);
            dtgvBillDetails.Columns[0].Visible = false;
            dtgvBillDetails.Columns[2].Visible = false;
            dtgvBillDetails.Columns[3].Visible = false;

            dtgvBillDetails.Columns[1].HeaderText = "Tên SP";
            dtgvBillDetails.Columns[4].HeaderText = "SL Mua";
            dtgvBillDetails.Columns[5].HeaderText = "Giá Mua";
            dtgvBillDetails.Columns[6].HeaderText = "Thành Tiền";

            billDetailContainer.Text = "Danh mục sản phẩm của hóa đơn #" + this.bill.MaHoaDon;
        }
    }
}
