namespace BHYT
{
    partial class FrmThongKeSoLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeSoLuong));
            this.btnTongHop = new System.Windows.Forms.Button();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbQuy = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbGiaiDoan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTieuChi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnTongHop
            // 
            this.btnTongHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongHop.Location = new System.Drawing.Point(231, 134);
            this.btnTongHop.Name = "btnTongHop";
            this.btnTongHop.Size = new System.Drawing.Size(84, 34);
            this.btnTongHop.TabIndex = 12;
            this.btnTongHop.Text = "Tổng Hợp";
            this.btnTongHop.UseVisualStyleBackColor = true;
            this.btnTongHop.Click += new System.EventHandler(this.btnTongHop_Click);
            // 
            // cbNam
            // 
            this.cbNam.DropDownHeight = 120;
            this.cbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.IntegralHeight = false;
            this.cbNam.Location = new System.Drawing.Point(410, 19);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(114, 24);
            this.cbNam.TabIndex = 9;
            // 
            // cbQuy
            // 
            this.cbQuy.DropDownHeight = 100;
            this.cbQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuy.FormattingEnabled = true;
            this.cbQuy.IntegralHeight = false;
            this.cbQuy.ItemHeight = 16;
            this.cbQuy.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cbQuy.Location = new System.Drawing.Point(283, 19);
            this.cbQuy.Name = "cbQuy";
            this.cbQuy.Size = new System.Drawing.Size(114, 24);
            this.cbQuy.TabIndex = 10;
            // 
            // cbThang
            // 
            this.cbThang.DropDownHeight = 100;
            this.cbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.IntegralHeight = false;
            this.cbThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(283, 19);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(114, 24);
            this.cbThang.TabIndex = 11;
            // 
            // cbGiaiDoan
            // 
            this.cbGiaiDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGiaiDoan.FormattingEnabled = true;
            this.cbGiaiDoan.Items.AddRange(new object[] {
            "Giai Đoạn",
            "Tháng",
            "Quý",
            "Năm"});
            this.cbGiaiDoan.Location = new System.Drawing.Point(150, 19);
            this.cbGiaiDoan.Name = "cbGiaiDoan";
            this.cbGiaiDoan.Size = new System.Drawing.Size(121, 24);
            this.cbGiaiDoan.TabIndex = 6;
            this.cbGiaiDoan.SelectedIndexChanged += new System.EventHandler(this.cbGiaiDoan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kỳ Quyết Toán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiêu Chí Thống Kê:";
            // 
            // cbTieuChi
            // 
            this.cbTieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTieuChi.FormattingEnabled = true;
            this.cbTieuChi.Items.AddRange(new object[] {
            "Thuốc có số lượng nhiều nhất",
            "Thuốc có chi phí nhiều nhất",
            "Dịch vụ kỹ thuật có số lượng nhiều nhất",
            "Dịch vụ kỹ thuật có chi phí nhiều nhất",
            "Vật tư y tế có số lượng nhiều nhất",
            "Vật tư y tế có chi phí nhiều nhất"});
            this.cbTieuChi.Location = new System.Drawing.Point(150, 55);
            this.cbTieuChi.Name = "cbTieuChi";
            this.cbTieuChi.Size = new System.Drawing.Size(374, 24);
            this.cbTieuChi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(150, 93);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 14;
            this.txtSoLuong.Text = "10";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.Location = new System.Drawing.Point(410, 20);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(114, 22);
            this.dateDenNgay.TabIndex = 15;
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuNgay.Location = new System.Drawing.Point(283, 20);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(114, 22);
            this.dateTuNgay.TabIndex = 16;
            // 
            // FrmThongKeSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 181);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cbTieuChi);
            this.Controls.Add(this.btnTongHop);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbQuy);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.cbGiaiDoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKeSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Số Lượng";
            this.Load += new System.EventHandler(this.FrmThongKeSoLuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTongHop;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbQuy;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbGiaiDoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTieuChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
    }
}