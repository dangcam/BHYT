namespace BHYT
{
    partial class FrmBaoCao79a80a
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCao79a80a));
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbQuy = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.cbGiaiDoan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiKCB = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.btnTongHop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNam
            // 
            this.cbNam.DropDownHeight = 120;
            this.cbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.IntegralHeight = false;
            this.cbNam.Location = new System.Drawing.Point(386, 12);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(114, 24);
            this.cbNam.TabIndex = 8;
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
            this.cbQuy.Location = new System.Drawing.Point(260, 12);
            this.cbQuy.Name = "cbQuy";
            this.cbQuy.Size = new System.Drawing.Size(114, 24);
            this.cbQuy.TabIndex = 9;
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
            this.cbThang.Location = new System.Drawing.Point(260, 12);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(114, 24);
            this.cbThang.TabIndex = 10;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.Location = new System.Drawing.Point(386, 13);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(114, 22);
            this.dateDenNgay.TabIndex = 6;
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuNgay.Location = new System.Drawing.Point(260, 13);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(114, 22);
            this.dateTuNgay.TabIndex = 7;
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
            this.cbGiaiDoan.Location = new System.Drawing.Point(127, 12);
            this.cbGiaiDoan.Name = "cbGiaiDoan";
            this.cbGiaiDoan.Size = new System.Drawing.Size(121, 24);
            this.cbGiaiDoan.TabIndex = 5;
            this.cbGiaiDoan.SelectedIndexChanged += new System.EventHandler(this.cbGiaiDoan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thời gian QT:";
            // 
            // cbLoaiKCB
            // 
            this.cbLoaiKCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiKCB.FormattingEnabled = true;
            this.cbLoaiKCB.Items.AddRange(new object[] {
            "1. Khám bệnh",
            "2. Điều trị ngoại trú",
            "3. Điều trị nội trú"});
            this.cbLoaiKCB.Location = new System.Drawing.Point(127, 47);
            this.cbLoaiKCB.Name = "cbLoaiKCB";
            this.cbLoaiKCB.Size = new System.Drawing.Size(247, 24);
            this.cbLoaiKCB.TabIndex = 64;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(58, 51);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 16);
            this.label31.TabIndex = 65;
            this.label31.Text = "Loại KCB:";
            // 
            // btnTongHop
            // 
            this.btnTongHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongHop.Location = new System.Drawing.Point(386, 47);
            this.btnTongHop.Name = "btnTongHop";
            this.btnTongHop.Size = new System.Drawing.Size(114, 24);
            this.btnTongHop.TabIndex = 66;
            this.btnTongHop.Text = "Tổng hợp";
            this.btnTongHop.UseVisualStyleBackColor = true;
            this.btnTongHop.Click += new System.EventHandler(this.btnTongHop_Click);
            // 
            // FrmBaoCao79a80a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 80);
            this.Controls.Add(this.btnTongHop);
            this.Controls.Add(this.cbLoaiKCB);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbQuy);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.cbGiaiDoan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBaoCao79a80a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỐ LIỆU MẪU 7980A";
            this.Load += new System.EventHandler(this.FrmBaoCao79a80a_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbQuy;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.ComboBox cbGiaiDoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiKCB;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnTongHop;
    }
}