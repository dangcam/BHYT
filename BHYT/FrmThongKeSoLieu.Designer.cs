namespace BHYT
{
    partial class FrmThongKeSoLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeSoLieu));
            this.label1 = new System.Windows.Forms.Label();
            this.cbGiaiDoan = new System.Windows.Forms.ComboBox();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbQuy = new System.Windows.Forms.ComboBox();
            this.btnTongHop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian:";
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
            this.cbGiaiDoan.Location = new System.Drawing.Point(85, 20);
            this.cbGiaiDoan.Name = "cbGiaiDoan";
            this.cbGiaiDoan.Size = new System.Drawing.Size(121, 24);
            this.cbGiaiDoan.TabIndex = 1;
            this.cbGiaiDoan.SelectedIndexChanged += new System.EventHandler(this.cbGiaiDoan_SelectedIndexChanged);
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuNgay.Location = new System.Drawing.Point(218, 21);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(114, 22);
            this.dateTuNgay.TabIndex = 2;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.Location = new System.Drawing.Point(344, 21);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(114, 22);
            this.dateDenNgay.TabIndex = 2;
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
            this.cbThang.Location = new System.Drawing.Point(218, 20);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(114, 24);
            this.cbThang.TabIndex = 3;
            // 
            // cbNam
            // 
            this.cbNam.DropDownHeight = 120;
            this.cbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.IntegralHeight = false;
            this.cbNam.Location = new System.Drawing.Point(344, 20);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(114, 24);
            this.cbNam.TabIndex = 3;
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
            this.cbQuy.Location = new System.Drawing.Point(218, 20);
            this.cbQuy.Name = "cbQuy";
            this.cbQuy.Size = new System.Drawing.Size(114, 24);
            this.cbQuy.TabIndex = 3;
            // 
            // btnTongHop
            // 
            this.btnTongHop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongHop.Location = new System.Drawing.Point(194, 63);
            this.btnTongHop.Name = "btnTongHop";
            this.btnTongHop.Size = new System.Drawing.Size(84, 34);
            this.btnTongHop.TabIndex = 4;
            this.btnTongHop.Text = "Tổng Hợp";
            this.btnTongHop.UseVisualStyleBackColor = true;
            this.btnTongHop.Click += new System.EventHandler(this.btnTongHop_Click);
            // 
            // FrmThongKeSoLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 113);
            this.Controls.Add(this.btnTongHop);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbQuy);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.cbGiaiDoan);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKeSoLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Số Liệu";
            this.Load += new System.EventHandler(this.FrmThongKeSoLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGiaiDoan;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbQuy;
        private System.Windows.Forms.Button btnTongHop;
    }
}