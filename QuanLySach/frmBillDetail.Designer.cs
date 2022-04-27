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
            this.billDetailContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // billDetailContainer
            // 
            this.billDetailContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billDetailContainer.Controls.Add(this.dtgvBillDetails);
            this.billDetailContainer.Location = new System.Drawing.Point(12, 53);
            this.billDetailContainer.Name = "billDetailContainer";
            this.billDetailContainer.Size = new System.Drawing.Size(776, 385);
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
            this.dtgvBillDetails.Size = new System.Drawing.Size(770, 366);
            this.dtgvBillDetails.TabIndex = 0;
            // 
            // frmBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billDetailContainer);
            this.Name = "frmBillDetail";
            this.Text = "frmBillDetail";
            this.billDetailContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox billDetailContainer;
        private System.Windows.Forms.DataGridView dtgvBillDetails;
    }
}