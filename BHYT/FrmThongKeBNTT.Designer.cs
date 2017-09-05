namespace BHYT
{
    partial class FrmThongKeBNTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeBNTT));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbLoaiKCB = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTuNgay.Location = new System.Drawing.Point(315, 12);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(110, 22);
            this.dateTuNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "đến ngày:";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDenNgay.Location = new System.Drawing.Point(506, 12);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(110, 22);
            this.dateDenNgay.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(275, 53);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 25);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbLoaiKCB
            // 
            this.cbLoaiKCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiKCB.FormattingEnabled = true;
            this.cbLoaiKCB.Items.AddRange(new object[] {
            "0. Tất Cả",
            "1. Khám bệnh",
            "2. Điều trị ngoại trú",
            "3. Điều trị nội trú"});
            this.cbLoaiKCB.Location = new System.Drawing.Point(80, 11);
            this.cbLoaiKCB.Name = "cbLoaiKCB";
            this.cbLoaiKCB.Size = new System.Drawing.Size(163, 24);
            this.cbLoaiKCB.TabIndex = 60;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 16);
            this.label31.TabIndex = 61;
            this.label31.Text = "Loại KCB:";
            // 
            // FrmThongKeBNTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 92);
            this.Controls.Add(this.cbLoaiKCB);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKeBNTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Số Tiền BNTT";
            this.Load += new System.EventHandler(this.FrmThongKeBNTT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbLoaiKCB;
        private System.Windows.Forms.Label label31;
    }
}