using QuanLySach.App;
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
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            lbBill_TenKH.Text = AppManager.Instance.Customer.HoTen;
            lbBill_SDTKH.Text = AppManager.Instance.Customer.SDT;

            lbBill_TongTien.Text = AppManager.Instance.Cart.TotalWithoutDiscount.ToString();
            lbBill_Discount.Text = AppManager.Instance.Cart.Discount.ToString() + "%";
            lbBill_ThanhToan.Text = AppManager.Instance.Cart.TotalWithDiscount.ToString();
        }

        private void btnBill_ThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBill_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
