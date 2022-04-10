using QuanLySach.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.App
{
    internal class UIController
    {
        private UIController()
        {

        }
        private static UIController instance;
        public static UIController Instance
        {
            get
            {
                if (instance == null)
                    instance = new UIController();
                return instance;
            }
        }

        public void DisplayStatusBar(ToolStripStatusLabel control)
        {
            control.Text = $"" +
                $"Xin chào: {AppManager.Instance.User.HoVaTen} - " +
                $"Tên đăng nhập: {AppManager.Instance.User.TenDangNhap} - " +
                $"Chi nhánh: {AppManager.Instance.User.ChiNhanh.Ten} - " +
                $"Nhóm: {AppManager.Instance.User.ChucVuVN}";
        }

        public void DisplayListOfProduct(DataGridView control)
        {
            control.DataSource = ProductController.Instance.GetProducts();

            control.Columns[0].Visible = false;
            control.Columns[3].Visible = false;
            control.Columns[4].Visible = false;

            control.Columns[1].HeaderText = "Tên SP";
            control.Columns[2].HeaderText = "Giá";
            control.Columns[5].HeaderText = "Thể loại";
        }

        public void DisplayListOfFilteredProduct(DataGridView control, string keyword)
        {
            control.DataSource = ProductController.Instance.FilterByName(keyword);

            control.Columns[0].Visible = false;
            control.Columns[3].Visible = false;
            control.Columns[4].Visible = false;

            control.Columns[1].HeaderText = "Tên SP";
            control.Columns[2].HeaderText = "Giá";
            control.Columns[5].HeaderText = "Thể loại";
        }

        public void DisplayCart(DataGridView control)
        {
            control.DataSource = AppManager.Instance.Cart.Clone();

            control.Columns[0].Visible = false; 

            control.Columns[1].HeaderText = "Tên SP";
            control.Columns[2].HeaderText = "Số Lượng";
            control.Columns[3].HeaderText = "Giá";
            control.Columns[4].HeaderText = "Thành Tiền";
        }
    }
}
