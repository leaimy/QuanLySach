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

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            var frm = new frmThemLoai();
            frm.ShowDialog();
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            var frm = new frmThemNhanVien();
            frm.ShowDialog();
        }
    }
}
