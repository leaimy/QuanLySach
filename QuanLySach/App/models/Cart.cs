using System;
using System.Collections.Generic;

namespace QuanLySach.App.models
{
    internal class Cart
    {
        public Cart()
        {
            items = new List<CartItem>();
        }

        private readonly List<CartItem> items;
        public decimal Discount { get; set; }
        public decimal TotalWithDiscount
        {
            get
            {
                decimal total = 0;
                items.ForEach(s => total += s.ThanhTien);

                total -= (total * (Discount / 100));
                return Convert.ToInt32(total / 1000) * 1000;
            }
        }

        public decimal TotalWithoutDiscount
        {
            get
            {
                decimal total = 0;
                items.ForEach(s => total += s.ThanhTien);

                return Convert.ToInt32(total / 1000) * 1000;
            }
        }

        public void AddToCart(CartItem item)
        {
            CartItem existing = items.Find(s => s.MaSP == item.MaSP);

            if (existing == null)
                items.Add(item);
            else
                existing.SoLuong += item.SoLuong;
        }

        public void RemoveFromCart(int MaSP, int quantity = 1)
        {
            CartItem existing = items.Find(s => s.MaSP == MaSP);

            if (existing != null)
            {
                existing.SoLuong -= quantity;
                if (existing.SoLuong <= 0)
                    items.Remove(existing);
            }
        }

        public void Clear()
        {
            items.Clear();
            Discount = 0;
        }

        public List<CartItem> Clone()
        {
            return items.GetRange(0, items.Count);
        }
    }
}
