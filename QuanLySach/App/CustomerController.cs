using QuanLySach.DAO;
using QuanLySach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App
{
    class CustomerController
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        private bool sapXepTheoSoLuongHoaDon = true;
        private bool sapXepTheoTongTien = true;
        private bool sapXepTheoDuocGiamGia = true;
        private bool sapXepTheoTienPhaiTra = true;

        private List<ThongKeKhachHangDTO> customers;
        private CustomerController()
        {
            customers = new List<ThongKeKhachHangDTO>();
        }

        private static CustomerController instance;

        public static CustomerController Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new CustomerController();
                return instance;
            }
        }


        public List<ThongKeKhachHangDTO> FetchCustomer(DateTime from, DateTime to)
        {
            FromDate = new DateTime(
                from.Year,
                from.Month,
                from.Day,
                0,
                0,
                0,
                from.Kind
                );

            ToDate = new DateTime(
                to.Year,
                to.Month,
                to.Day,
                23,
                59,
                59,
                to.Kind
                );
            customers = HoaDonDAO.Instance.ThongKeKhachHang(FromDate, ToDate);
            return Clone();
        }

        public List<ThongKeKhachHangDTO> Clone()
        {
            return customers.GetRange(0, customers.Count);
        }


        public void TheoSoLuongHoaDon(bool Desc = true)
        {
            if (!Desc)
                customers = customers.OrderBy(s => s.SoLuongHoaDon).ToList();
            else
                customers = customers.OrderByDescending(s => s.SoLuongHoaDon).ToList();
        }

        public void TheoTongTien(bool Desc = true)
        {
            if (!Desc)
                customers = customers.OrderBy(s => s.TongTien).ToList();
            else
                customers = customers.OrderByDescending(s => s.TongTien).ToList();
        }

        public void TheoDuocGiamGia(bool Desc = true)
        {
            if (!Desc)
                customers = customers.OrderBy(s => s.DuocGiamGia).ToList();
            else
                customers = customers.OrderByDescending(s => s.DuocGiamGia).ToList();
        }

        public void TheoTienPhaiTra(bool Desc = true)
        {
            if (!Desc)
                customers = customers.OrderBy(s => s.TienPhaiTra).ToList();
            else
                customers = customers.OrderByDescending(s => s.TienPhaiTra).ToList();
        }


        public void SapXepTheoSoLuongHoaDon()
        {
            TheoSoLuongHoaDon(sapXepTheoSoLuongHoaDon);
            sapXepTheoSoLuongHoaDon = !sapXepTheoSoLuongHoaDon;
        }

        public void SapXepTheoTongTien()
        {
            TheoTongTien(sapXepTheoTongTien);
            sapXepTheoTongTien = !sapXepTheoTongTien;
        }

        public void SapXepTheoDuocGiamGia()
        {
            TheoDuocGiamGia(sapXepTheoDuocGiamGia);
            sapXepTheoDuocGiamGia = !sapXepTheoDuocGiamGia;
        }

        public void SapXepTheoTienPhaiTra()
        {
            TheoTienPhaiTra(sapXepTheoTienPhaiTra);
            sapXepTheoTienPhaiTra = !sapXepTheoTienPhaiTra;
        }

        public int Count => customers.Count;

        public List<ThongKeKhachHangDTO> FetchAllCustomer()
        {
            customers = HoaDonDAO.Instance.ThongKeTatCaKhachHang(FromDate, ToDate);
            return Clone();
        }

        public List<ThongKeKhachHangDTO> Refetch()
        {
            FetchCustomer(FromDate, ToDate);
            return Clone();
        }
    }
}
