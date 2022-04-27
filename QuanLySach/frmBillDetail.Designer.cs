namespace QuanLySach
{
    partial class frmBillDetail
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
            this.billDetailContainer = new System.Windows.Forms.GroupBox();
            this.dtgvBillDetails = new System.Windows.Forms.DataGridView();
            this.pnBillTongTienUocTinh1 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblBillTongTienUocTinh1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDateCheckout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.billDetailContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetails)).BeginInit();
            this.pnBillTongTienUocTinh1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // billDetailContainer
            // 
            this.billDetailContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billDetailContainer.Controls.Add(this.dtgvBillDetails);
            this.billDetailContainer.Location = new System.Drawing.Point(12, 141);
            this.billDetailContainer.Name = "billDetailContainer";
            this.billDetailContainer.Size = new System.Drawing.Size(776, 297);
            this.billDetailContainer.TabIndex = 7;
            this.billDetailContainer.TabStop = false;
            this.billDetailContainer.Text = "Danh sách hóa đơn hiện có";
            // 
            // dtgvBillDetails
            // 
            this.dtgvBillDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBillDetails.BackgroundColor = System.Drawing.Color.White;
            this.dtgvBillDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvBillDetails.Location = new System.Drawing.Point(3, 16);
            this.dtgvBillDetails.MultiSelect = false;
            this.dtgvBillDetails.Name = "dtgvBillDetails";
            this.dtgvBillDetails.ReadOnly = true;
            this.dtgvBillDetails.RowHeadersWidth = 51;
            this.dtgvBillDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBillDetails.Size = new System.Drawing.Size(770, 278);
            this.dtgvBillDetails.TabIndex = 0;
            // 
            // pnBillTongTienUocTinh1
            // 
            this.pnBillTongTienUocTinh1.Controls.Add(this.txtCustomerName);
            this.pnBillTongTienUocTinh1.Controls.Add(this.lblBillTongTienUocTinh1);
            this.pnBillTongTienUocTinh1.Location = new System.Drawing.Point(15, 12);
            this.pnBillTongTienUocTinh1.Name = "pnBillTongTienUocTinh1";
            this.pnBillTongTienUocTinh1.Size = new System.Drawing.Size(326, 34);
            this.pnBillTongTienUocTinh1.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(136, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(187, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblBillTongTienUocTinh1
            // 
            this.lblBillTongTienUocTinh1.AutoSize = true;
            this.lblBillTongTienUocTinh1.Location = new System.Drawing.Point(3, 8);
            this.lblBillTongTienUocTinh1.Name = "lblBillTongTienUocTinh1";
            this.lblBillTongTienUocTinh1.Size = new System.Drawing.Size(65, 13);
            this.lblBillTongTienUocTinh1.TabIndex = 0;
            this.lblBillTongTienUocTinh1.Text = "Khách hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDateCheckout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(462, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 34);
            this.panel1.TabIndex = 9;
            // 
            // txtDateCheckout
            // 
            this.txtDateCheckout.Location = new System.Drawing.Point(136, 5);
            this.txtDateCheckout.Name = "txtDateCheckout";
            this.txtDateCheckout.Size = new System.Drawing.Size(187, 20);
            this.txtDateCheckout.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày mua";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 34);
            this.panel2.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(136, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(187, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng tiền";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDiscount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(462, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 34);
            this.panel3.TabIndex = 10;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(136, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(187, 20);
            this.txtDiscount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giảm giá";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtStaffName);
            this.panel4.Controls.Add(this.lblStaffName);
            this.panel4.Location = new System.Drawing.Point(15, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 34);
            this.panel4.TabIndex = 10;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(136, 5);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(187, 20);
            this.txtStaffName.TabIndex = 1;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(3, 8);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(56, 13);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Nhân viên";
            // 
            // frmBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBillTongTienUocTinh1);
            this.Controls.Add(this.billDetailContainer);
            this.Name = "frmBillDetail";
            this.Text = "frmBillDetail";
            this.Load += new System.EventHandler(this.frmBillDetail_Load);
            this.billDetailContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetails)).EndInit();
            this.pnBillTongTienUocTinh1.ResumeLayout(false);
            this.pnBillTongTienUocTinh1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox billDetailContainer;
        private System.Windows.Forms.DataGridView dtgvBillDetails;
        private System.Windows.Forms.Panel pnBillTongTienUocTinh1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblBillTongTienUocTinh1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDateCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffName;
    }
}