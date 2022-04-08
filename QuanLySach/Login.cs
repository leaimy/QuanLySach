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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbChiNhanh.Items.Add("Chi nhánh 01");
            cbChiNhanh.Items.Add("Chi nhánh 02");
        }

        private void btnLocHD_Click(object sender, EventArgs e)
        {
            string userName = txtLoginName.Text;
            string password = txtPassword.Text;
            string branch = cbChiNhanh.SelectedItem.ToString();

            if (branch == "Chi nhánh 01")
            {
                DataProvider.Instance.InitConnectionString(App.ChiNhanhEnum.CN_1, userName, password);
            }
            else
            {
                DataProvider.Instance.InitConnectionString(App.ChiNhanhEnum.CN_2, userName, password);
            }

            var frm = new frmSach();
            frm.ShowDialog();

            Close();
        }
    }
}
