namespace QuanLySach
{
    partial class frmLogin
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
            this.panel21 = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocHD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdHieu = new System.Windows.Forms.RadioButton();
            this.rdHa = new System.Windows.Forms.RadioButton();
            this.panel21.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.cbChiNhanh);
            this.panel21.Controls.Add(this.label18);
            this.panel21.Location = new System.Drawing.Point(28, 62);
            this.panel21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(513, 48);
            this.panel21.TabIndex = 3;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(175, 6);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(333, 24);
            this.cbChiNhanh.TabIndex = 1;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 11);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Chi nhánh:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLoginName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 48);
            this.panel1.TabIndex = 4;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(175, 7);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(333, 22);
            this.txtLoginName.TabIndex = 5;
            this.txtLoginName.Text = "thiha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 48);
            this.panel2.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(175, 7);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(333, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "thiha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // btnLocHD
            // 
            this.btnLocHD.BackColor = System.Drawing.Color.Transparent;
            this.btnLocHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocHD.Location = new System.Drawing.Point(203, 292);
            this.btnLocHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocHD.Name = "btnLocHD";
            this.btnLocHD.Size = new System.Drawing.Size(157, 46);
            this.btnLocHD.TabIndex = 7;
            this.btnLocHD.Text = "Đăng nhập";
            this.btnLocHD.UseVisualStyleBackColor = false;
            this.btnLocHD.Click += new System.EventHandler(this.btnLocHD_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(384, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rdHieu
            // 
            this.rdHieu.AutoSize = true;
            this.rdHieu.Location = new System.Drawing.Point(203, 13);
            this.rdHieu.Name = "rdHieu";
            this.rdHieu.Size = new System.Drawing.Size(58, 21);
            this.rdHieu.TabIndex = 9;
            this.rdHieu.TabStop = true;
            this.rdHieu.Text = "Hieu";
            this.rdHieu.UseVisualStyleBackColor = true;
            // 
            // rdHa
            // 
            this.rdHa.AutoSize = true;
            this.rdHa.Location = new System.Drawing.Point(277, 13);
            this.rdHa.Name = "rdHa";
            this.rdHa.Size = new System.Drawing.Size(47, 21);
            this.rdHa.TabIndex = 10;
            this.rdHa.TabStop = true;
            this.rdHa.Text = "Ha";
            this.rdHa.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 375);
            this.Controls.Add(this.rdHa);
            this.Controls.Add(this.rdHieu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLocHD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel21);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocHD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdHieu;
        private System.Windows.Forms.RadioButton rdHa;
    }
}