
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCTBH = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.btnAddProductToBill = new System.Windows.Forms.Button();
            this.btnRemoveProductFromBill = new System.Windows.Forms.Button();
            this.txtProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGenCustomer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBH)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductQuantity)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1064, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmAdmin.ForeColor = System.Drawing.Color.LightCoral;
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(67, 21);
            this.tsmAdmin.Text = "Admin";
            this.tsmAdmin.Click += new System.EventHandler(this.tsmAdmin_Click);
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
            this.tsmChucNang.Size = new System.Drawing.Size(98, 21);
            this.tsmChucNang.Text = "Chức năng";
            // 
            // tsmThemSach
            // 
            this.tsmThemSach.Name = "tsmThemSach";
            this.tsmThemSach.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmThemSach.Size = new System.Drawing.Size(268, 22);
            this.tsmThemSach.Text = "Thêm sách";
            // 
            // tsmXoaBoLoc
            // 
            this.tsmXoaBoLoc.Name = "tsmXoaBoLoc";
            this.tsmXoaBoLoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmXoaBoLoc.Size = new System.Drawing.Size(268, 22);
            this.tsmXoaBoLoc.Text = "Xóa bộ lọc hiện thời";
            // 
            // tsmTaiLaiDS
            // 
            this.tsmTaiLaiDS.Name = "tsmTaiLaiDS";
            this.tsmTaiLaiDS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmTaiLaiDS.Size = new System.Drawing.Size(268, 22);
            this.tsmTaiLaiDS.Text = "Tải lại toàn bộ sách";
            // 
            // tsmThanhToan
            // 
            this.tsmThanhToan.Name = "tsmThanhToan";
            this.tsmThanhToan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmThanhToan.Size = new System.Drawing.Size(268, 22);
            this.tsmThanhToan.Text = "Thanh toán";
            // 
            // tsmHuyDon
            // 
            this.tsmHuyDon.Name = "tsmHuyDon";
            this.tsmHuyDon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.tsmHuyDon.Size = new System.Drawing.Size(268, 22);
            this.tsmHuyDon.Text = "Hủy đơn";
            // 
            // tsmDangXuat
            // 
            this.tsmDangXuat.Name = "tsmDangXuat";
            this.tsmDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmDangXuat.Size = new System.Drawing.Size(268, 22);
            this.tsmDangXuat.Text = "Đăng xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(3, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhanh sách theo mã hoặc tên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(9, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(454, 25);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSach);
            this.groupBox2.Location = new System.Drawing.Point(0, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 443);
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
            this.dgvSach.Location = new System.Drawing.Point(3, 21);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(466, 419);
            this.dgvSach.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox3.Controls.Add(this.btnGenCustomer);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtHoTen);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(478, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(374, 24);
            this.txtSDT.Mask = "0000000000";
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(159, 25);
            this.txtSDT.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "SĐT *:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(82, 24);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(208, 25);
            this.txtHoTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên *:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvCTBH);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(537, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(515, 443);
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
            this.dgvCTBH.Location = new System.Drawing.Point(3, 21);
            this.dgvCTBH.MultiSelect = false;
            this.dgvCTBH.Name = "dgvCTBH";
            this.dgvCTBH.ReadOnly = true;
            this.dgvCTBH.RowHeadersWidth = 51;
            this.dgvCTBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTBH.Size = new System.Drawing.Size(509, 419);
            this.dgvCTBH.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-59, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 25);
            this.textBox1.TabIndex = 5;
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
            this.lblTongTienGhiBangChu.Size = new System.Drawing.Size(0, 17);
            this.lblTongTienGhiBangChu.TabIndex = 20;
            // 
            // lblTongTienCuoiCung
            // 
            this.lblTongTienCuoiCung.AutoSize = true;
            this.lblTongTienCuoiCung.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienCuoiCung.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTongTienCuoiCung.Location = new System.Drawing.Point(637, 35);
            this.lblTongTienCuoiCung.Name = "lblTongTienCuoiCung";
            this.lblTongTienCuoiCung.Size = new System.Drawing.Size(16, 18);
            this.lblTongTienCuoiCung.TabIndex = 19;
            this.lblTongTienCuoiCung.Text = "0";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTongTien.Location = new System.Drawing.Point(103, 35);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(16, 18);
            this.lblTongTien.TabIndex = 18;
            this.lblTongTien.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng tiền ghi bằng chữ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tổng tiền sau giảm giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng tiền:";
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmGiamGia.Location = new System.Drawing.Point(393, 32);
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(59, 25);
            this.nmGiamGia.TabIndex = 12;
            this.nmGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmGiamGia.ValueChanged += new System.EventHandler(this.nmGiamGia_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
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
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnAddProductToBill
            // 
            this.btnAddProductToBill.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddProductToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductToBill.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductToBill.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProductToBill.Location = new System.Drawing.Point(478, 249);
            this.btnAddProductToBill.Name = "btnAddProductToBill";
            this.btnAddProductToBill.Size = new System.Drawing.Size(53, 37);
            this.btnAddProductToBill.TabIndex = 5;
            this.btnAddProductToBill.Text = ">>>";
            this.btnAddProductToBill.UseVisualStyleBackColor = true;
            this.btnAddProductToBill.Click += new System.EventHandler(this.btnAddProductToBill_Click);
            // 
            // btnRemoveProductFromBill
            // 
            this.btnRemoveProductFromBill.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRemoveProductFromBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProductFromBill.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProductFromBill.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveProductFromBill.Location = new System.Drawing.Point(478, 350);
            this.btnRemoveProductFromBill.Name = "btnRemoveProductFromBill";
            this.btnRemoveProductFromBill.Size = new System.Drawing.Size(53, 37);
            this.btnRemoveProductFromBill.TabIndex = 5;
            this.btnRemoveProductFromBill.Text = "<<<";
            this.btnRemoveProductFromBill.UseVisualStyleBackColor = true;
            this.btnRemoveProductFromBill.Click += new System.EventHandler(this.btnRemoveProductFromBill_Click);
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(478, 307);
            this.txtProductQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(53, 25);
            this.txtProductQuantity.TabIndex = 6;
            this.txtProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(118, 17);
            this.tssLabel.Text = "toolStripStatusLabel1";
            // 
            // btnGenCustomer
            // 
            this.btnGenCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGenCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenCustomer.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenCustomer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGenCustomer.Location = new System.Drawing.Point(539, 24);
            this.btnGenCustomer.Name = "btnGenCustomer";
            this.btnGenCustomer.Size = new System.Drawing.Size(29, 25);
            this.btnGenCustomer.TabIndex = 8;
            this.btnGenCustomer.Text = "+";
            this.btnGenCustomer.UseVisualStyleBackColor = true;
            this.btnGenCustomer.Click += new System.EventHandler(this.btnGenCustomer_Click);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRemoveProductFromBill);
            this.Controls.Add(this.btnAddProductToBill);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBH)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductQuantity)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.DataGridView dgvSach;
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTongTienGhiBangChu;
		private System.Windows.Forms.Label lblTongTienCuoiCung;
		private System.Windows.Forms.Label lblTongTien;
		private System.Windows.Forms.DataGridView dgvCTBH;
		private System.Windows.Forms.MaskedTextBox txtSDT;
        private System.Windows.Forms.Button btnAddProductToBill;
        private System.Windows.Forms.Button btnRemoveProductFromBill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown txtProductQuantity;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
        private System.Windows.Forms.Button btnGenCustomer;
    }
}