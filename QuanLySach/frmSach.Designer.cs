﻿
namespace QuanLySach
{
    partial class frmSach
    {
         /// <summary>
	    /// Required designer variable.
	    /// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThemSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXoaBoLoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTaiLaiDS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHuyDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnTaiLaiDS = new System.Windows.Forms.Button();
            this.btnXoaBoLoc = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCTBH = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTongTienGhiBangChu = new System.Windows.Forms.Label();
            this.lblTongTienCuoiCung = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBH)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.tsmChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1064, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAdmin.ForeColor = System.Drawing.Color.LightCoral;
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(86, 27);
            this.tsmAdmin.Text = "Admin";
            // 
            // tsmChucNang
            // 
            this.tsmChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThemSach,
            this.tsmXoaBoLoc,
            this.tsmTaiLaiDS,
            this.tsmThanhToan,
            this.tsmHuyDon,
            this.tsmDangXuat});
            this.tsmChucNang.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmChucNang.ForeColor = System.Drawing.Color.LightCoral;
            this.tsmChucNang.Name = "tsmChucNang";
            this.tsmChucNang.Size = new System.Drawing.Size(127, 27);
            this.tsmChucNang.Text = "Chức năng";
            // 
            // tsmThemSach
            // 
            this.tsmThemSach.Name = "tsmThemSach";
            this.tsmThemSach.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmThemSach.Size = new System.Drawing.Size(348, 28);
            this.tsmThemSach.Text = "Thêm sách";
            // 
            // tsmXoaBoLoc
            // 
            this.tsmXoaBoLoc.Name = "tsmXoaBoLoc";
            this.tsmXoaBoLoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmXoaBoLoc.Size = new System.Drawing.Size(348, 28);
            this.tsmXoaBoLoc.Text = "Xóa bộ lọc hiện thời";
            // 
            // tsmTaiLaiDS
            // 
            this.tsmTaiLaiDS.Name = "tsmTaiLaiDS";
            this.tsmTaiLaiDS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmTaiLaiDS.Size = new System.Drawing.Size(348, 28);
            this.tsmTaiLaiDS.Text = "Tải lại toàn bộ sách";
            // 
            // tsmThanhToan
            // 
            this.tsmThanhToan.Name = "tsmThanhToan";
            this.tsmThanhToan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmThanhToan.Size = new System.Drawing.Size(348, 28);
            this.tsmThanhToan.Text = "Thanh toán";
            // 
            // tsmHuyDon
            // 
            this.tsmHuyDon.Name = "tsmHuyDon";
            this.tsmHuyDon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.tsmHuyDon.Size = new System.Drawing.Size(348, 28);
            this.tsmHuyDon.Text = "Hủy đơn";
            // 
            // tsmDangXuat
            // 
            this.tsmDangXuat.Name = "tsmDangXuat";
            this.tsmDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmDangXuat.Size = new System.Drawing.Size(348, 28);
            this.tsmDangXuat.Text = "Đăng xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.nmSoLuong);
            this.groupBox1.Controls.Add(this.btnTaiLaiDS);
            this.groupBox1.Controls.Add(this.btnXoaBoLoc);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(3, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhanh sách theo mã hoặc tên";
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Location = new System.Drawing.Point(390, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 27);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(312, 24);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(72, 29);
            this.nmSoLuong.TabIndex = 3;
            this.nmSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTaiLaiDS
            // 
            this.btnTaiLaiDS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTaiLaiDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLaiDS.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLaiDS.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTaiLaiDS.Location = new System.Drawing.Point(137, 53);
            this.btnTaiLaiDS.Name = "btnTaiLaiDS";
            this.btnTaiLaiDS.Size = new System.Drawing.Size(154, 25);
            this.btnTaiLaiDS.TabIndex = 2;
            this.btnTaiLaiDS.Text = "Tải lại danh sách";
            this.btnTaiLaiDS.UseVisualStyleBackColor = true;
            // 
            // btnXoaBoLoc
            // 
            this.btnXoaBoLoc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnXoaBoLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBoLoc.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBoLoc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnXoaBoLoc.Location = new System.Drawing.Point(9, 53);
            this.btnXoaBoLoc.Name = "btnXoaBoLoc";
            this.btnXoaBoLoc.Size = new System.Drawing.Size(111, 25);
            this.btnXoaBoLoc.TabIndex = 1;
            this.btnXoaBoLoc.Text = "Xóa bộ lọc";
            this.btnXoaBoLoc.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(9, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(282, 29);
            this.txtTimKiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSach);
            this.groupBox2.Location = new System.Drawing.Point(0, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 418);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sách hiện có";
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(3, 25);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(525, 390);
            this.dgvSach.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtHoTen);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(537, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 87);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(347, 24);
            this.txtSDT.Mask = "0000000000";
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(156, 29);
            this.txtSDT.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(96, 56);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(407, 29);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "SĐT *:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(96, 24);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(173, 29);
            this.txtHoTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên *:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvCTBH);
            this.groupBox4.Location = new System.Drawing.Point(537, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 418);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin đơn hàng";
            // 
            // dgvCTBH
            // 
            this.dgvCTBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTBH.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTBH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTBH.Location = new System.Drawing.Point(3, 25);
            this.dgvCTBH.MultiSelect = false;
            this.dgvCTBH.Name = "dgvCTBH";
            this.dgvCTBH.ReadOnly = true;
            this.dgvCTBH.RowHeadersWidth = 51;
            this.dgvCTBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTBH.Size = new System.Drawing.Size(509, 390);
            this.dgvCTBH.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox5.Controls.Add(this.lblTongTienGhiBangChu);
            this.groupBox5.Controls.Add(this.lblTongTienCuoiCung);
            this.groupBox5.Controls.Add(this.lblTongTien);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.nmGiamGia);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnHuyDon);
            this.groupBox5.Controls.Add(this.btnThanhToan);
            this.groupBox5.Location = new System.Drawing.Point(0, 542);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1049, 127);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin thanh toán";
            // 
            // lblTongTienGhiBangChu
            // 
            this.lblTongTienGhiBangChu.AutoSize = true;
            this.lblTongTienGhiBangChu.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienGhiBangChu.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTongTienGhiBangChu.Location = new System.Drawing.Point(194, 84);
            this.lblTongTienGhiBangChu.Name = "lblTongTienGhiBangChu";
            this.lblTongTienGhiBangChu.Size = new System.Drawing.Size(348, 23);
            this.lblTongTienGhiBangChu.TabIndex = 20;
            this.lblTongTienGhiBangChu.Text = "Hai trăm tám mươi nghìn đồng chẵn";
            // 
            // lblTongTienCuoiCung
            // 
            this.lblTongTienCuoiCung.AutoSize = true;
            this.lblTongTienCuoiCung.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienCuoiCung.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTongTienCuoiCung.Location = new System.Drawing.Point(637, 35);
            this.lblTongTienCuoiCung.Name = "lblTongTienCuoiCung";
            this.lblTongTienCuoiCung.Size = new System.Drawing.Size(97, 22);
            this.lblTongTienCuoiCung.TabIndex = 19;
            this.lblTongTienCuoiCung.Text = "2.500.015";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTongTien.Location = new System.Drawing.Point(103, 35);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(81, 22);
            this.lblTongTien.TabIndex = 18;
            this.lblTongTien.Text = "300.000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng tiền ghi bằng chữ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tổng tiền sau giảm giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng tiền:";
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Location = new System.Drawing.Point(393, 32);
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(59, 29);
            this.nmGiamGia.TabIndex = 12;
            this.nmGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giảm giá(%):";
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnHuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDon.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnHuyDon.Location = new System.Drawing.Point(956, 32);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(84, 69);
            this.btnHuyDon.TabIndex = 6;
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhToan.Location = new System.Drawing.Point(845, 35);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(84, 69);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng Sách";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBH)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
		private System.Windows.Forms.ToolStripMenuItem tsmChucNang;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnXoaBoLoc;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTaiLaiDS;
		private System.Windows.Forms.DataGridView dgvSach;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.NumericUpDown nmSoLuong;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Button btnHuyDon;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.NumericUpDown nmGiamGia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStripMenuItem tsmThemSach;
		private System.Windows.Forms.ToolStripMenuItem tsmXoaBoLoc;
		private System.Windows.Forms.ToolStripMenuItem tsmTaiLaiDS;
		private System.Windows.Forms.ToolStripMenuItem tsmThanhToan;
		private System.Windows.Forms.ToolStripMenuItem tsmHuyDon;
		private System.Windows.Forms.ToolStripMenuItem tsmDangXuat;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTongTienGhiBangChu;
		private System.Windows.Forms.Label lblTongTienCuoiCung;
		private System.Windows.Forms.Label lblTongTien;
		private System.Windows.Forms.DataGridView dgvCTBH;
		private System.Windows.Forms.MaskedTextBox txtSDT;
	}
}