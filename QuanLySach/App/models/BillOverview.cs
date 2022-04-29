using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.App.models
{
    public class BillOverview
    {
        public int CustomerCount { get; set; }
        public int StaffCount { get; set; }
        public decimal Total { get => Subtotal - DiscountTotal; }
        public decimal Subtotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public int TotalBill { get; set; }
    }
}
