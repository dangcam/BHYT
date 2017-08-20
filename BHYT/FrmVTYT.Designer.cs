namespace BHYT
{
    partial class FrmVTYT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVTYT));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaVTYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenVTYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenBV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyetDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CongBo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bntNhapExcel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaVatTu = new System.Windows.Forms.TextBox();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.txtTenBV = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtQuyetDinh = new System.Windows.Forms.TextBox();
            this.txtCongBo = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Location = new System.Drawing.Point(0, 129);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(934, 392);
            this.gridControl.TabIndex = 11;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhom,
            this.MaVTYT,
            this.TenVTYT,
            this.TenBV,
            this.DonGia,
            this.DonViTinh,
            this.QuyetDinh,
            this.CongBo});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Tìm dịch vụ kỹ thuật";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.Click += new System.EventHandler(this.gridView_Click);
            // 
            // MaNhom
            // 
            this.MaNhom.Caption = "Mã Nhóm";
            this.MaNhom.FieldName = "MA_NHOM";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.OptionsColumn.AllowEdit = false;
            this.MaNhom.Visible = true;
            this.MaNhom.VisibleIndex = 0;
            this.MaNhom.Width = 60;
            // 
            // MaVTYT
            // 
            this.MaVTYT.Caption = "Mã VTYT";
            this.MaVTYT.FieldName = "MA_VTYT";
            this.MaVTYT.Name = "MaVTYT";
            this.MaVTYT.OptionsColumn.AllowEdit = false;
            this.MaVTYT.Visible = true;
            this.MaVTYT.VisibleIndex = 1;
            this.MaVTYT.Width = 90;
            // 
            // TenVTYT
            // 
            this.TenVTYT.Caption = "Tên VTYT";
            this.TenVTYT.FieldName = "TEN_VTYT";
            this.TenVTYT.Name = "TenVTYT";
            this.TenVTYT.OptionsColumn.AllowEdit = false;
            this.TenVTYT.Visible = true;
            this.TenVTYT.VisibleIndex = 2;
            this.TenVTYT.Width = 220;
            // 
            // TenBV
            // 
            this.TenBV.Caption = "Tên BV";
            this.TenBV.FieldName = "TEN_BV";
            this.TenBV.Name = "TenBV";
            this.TenBV.OptionsColumn.AllowEdit = false;
            this.TenBV.Visible = true;
            this.TenBV.VisibleIndex = 3;
            this.TenBV.Width = 226;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.DisplayFormat.FormatString = "#,###";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGia.FieldName = "DON_GIA";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            this.DonGia.Width = 80;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn Vị";
            this.DonViTinh.FieldName = "DON_VI_TINH";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 5;
            this.DonViTinh.Width = 60;
            // 
            // QuyetDinh
            // 
            this.QuyetDinh.Caption = "Quyết Định";
            this.QuyetDinh.FieldName = "QUYET_DINH";
            this.QuyetDinh.Name = "QuyetDinh";
            this.QuyetDinh.OptionsColumn.AllowEdit = false;
            this.QuyetDinh.Visible = true;
            this.QuyetDinh.VisibleIndex = 6;
            this.QuyetDinh.Width = 80;
            // 
            // CongBo
            // 
            this.CongBo.Caption = "Công Bố";
            this.CongBo.FieldName = "CONG_BO";
            this.CongBo.Name = "CongBo";
            this.CongBo.OptionsColumn.AllowEdit = false;
            this.CongBo.Visible = true;
            this.CongBo.VisibleIndex = 7;
            this.CongBo.Width = 100;
            // 
            // bntNhapExcel
            // 
            this.bntNhapExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhapExcel.Appearance.Options.UseFont = true;
            this.bntNhapExcel.Image = ((System.Drawing.Image)(resources.GetObject("bntNhapExcel.Image")));
            this.bntNhapExcel.Location = new System.Drawing.Point(816, 12);
            this.bntNhapExcel.Name = "bntNhapExcel";
            this.bntNhapExcel.Size = new System.Drawing.Size(106, 33);
            this.bntNhapExcel.TabIndex = 10;
            this.bntNhapExcel.Text = "Nhập Excel";
            this.bntNhapExcel.Click += new System.EventHandler(this.bntNhapExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Vật Tư:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Vật Tư:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên BV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn Giá:";
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVatTu.Location = new System.Drawing.Point(101, 6);
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Size = new System.Drawing.Size(254, 22);
            this.txtMaVatTu.TabIndex = 0;
            // 
            // txtTenVT
            // 
            this.txtTenVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVT.Location = new System.Drawing.Point(101, 35);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(254, 22);
            this.txtTenVT.TabIndex = 1;
            // 
            // txtTenBV
            // 
            this.txtTenBV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBV.Location = new System.Drawing.Point(101, 64);
            this.txtTenBV.Name = "txtTenBV";
            this.txtTenBV.Size = new System.Drawing.Size(254, 22);
            this.txtTenBV.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(101, 93);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(254, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn Vị Tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Công Bố:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quyết Định:";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(473, 6);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(268, 22);
            this.txtDonViTinh.TabIndex = 4;
            // 
            // txtQuyetDinh
            // 
            this.txtQuyetDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyetDinh.Location = new System.Drawing.Point(473, 35);
            this.txtQuyetDinh.Name = "txtQuyetDinh";
            this.txtQuyetDinh.Size = new System.Drawing.Size(268, 22);
            this.txtQuyetDinh.TabIndex = 5;
            // 
            // txtCongBo
            // 
            this.txtCongBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongBo.Location = new System.Drawing.Point(473, 64);
            this.txtCongBo.Name = "txtCongBo";
            this.txtCongBo.Size = new System.Drawing.Size(268, 22);
            this.txtCongBo.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(666, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.Location = new System.Drawing.Point(472, 93);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(75, 30);
            this.btnMoi.TabIndex = 7;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(571, 93);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmVTYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 521);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtCongBo);
            this.Controls.Add(this.txtQuyetDinh);
            this.Controls.Add(this.txtTenBV);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTenVT);
            this.Controls.Add(this.txtMaVatTu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.bntNhapExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVTYT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vật tư y tế";
            this.Load += new System.EventHandler(this.FrmVTYT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn MaVTYT;
        private DevExpress.XtraGrid.Columns.GridColumn TenVTYT;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn QuyetDinh;
        private DevExpress.XtraGrid.Columns.GridColumn CongBo;
        private DevExpress.XtraEditors.SimpleButton bntNhapExcel;
        private DevExpress.XtraGrid.Columns.GridColumn TenBV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaVatTu;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.TextBox txtTenBV;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtQuyetDinh;
        private System.Windows.Forms.TextBox txtCongBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnLuu;
    }
}