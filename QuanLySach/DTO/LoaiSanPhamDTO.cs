﻿using System;
using System.Data;

namespace QuanLySach.DTO
{
    internal class LoaiSanPhamDTO
    {
        private int _MaLoaiSP;
        private string _TenLoaiSP;
        private string _MoTa;
        private int? _ParentID;
        private DateTime _CreatedAt;
        private DateTime? _UpdatedAt;
        private DateTime? _DeletedAt;

        public int MaLoaiSP { get {  return _MaLoaiSP; } set { _MaLoaiSP = value; } }
        public string TenLoaiSP { set { _TenLoaiSP = value; } get { return _TenLoaiSP; } }
        public string MoTa { set { _MoTa = value; } get { return _MoTa; } }
        public int? ParentID { get { return _ParentID; } set { _ParentID = value; } }
        public DateTime CreatedAt { get { return _CreatedAt; } set { _CreatedAt = value; } }
        public DateTime? UpdatedAt { get { return _UpdatedAt; } set { _UpdatedAt = value; } }
        public DateTime? DeletedAt { get { return _DeletedAt; } set { _DeletedAt = value; } }

        public LoaiSanPhamDTO()
        {

        }

        public LoaiSanPhamDTO(int MaLoaiSP, string TenLoaiSP, string MoTa, int ParentID)
        {
            this.MaLoaiSP = MaLoaiSP;
            this.TenLoaiSP = TenLoaiSP;
            this.MoTa = MoTa;
            this.ParentID = ParentID;
        }

        public LoaiSanPhamDTO(DataRow row)
        {
            this.MaLoaiSP = (int)row["MaLoaiSP"];
            this.TenLoaiSP = row["TenLoaiSP"].ToString();
            this.MoTa = row["MoTa"].ToString();

            if (int.TryParse(row["ParentID"].ToString(), out int pID))
            {
                this.ParentID = pID;
            }
            else
            {
                this.ParentID = null;
            }

            this.CreatedAt = DateTime.Parse(row["CreatedAt"].ToString());
        }
    }
}
