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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var frm = new frmBill();
            frm.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
