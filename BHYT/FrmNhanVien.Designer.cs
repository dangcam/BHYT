namespace BHYT
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenVietTat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HocHamHocVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaChuyenNganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Loai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaCCHN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCapCCHN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiCapCCHN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TuNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DenNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VanBang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThoiGianDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoaBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bntNhapExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl.Location = new System.Drawing.Point(0, 51);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1354, 430);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            // 
            // gridView
            // 
            this.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKhoa,
            this.MaNhanVien,
            this.TenNhanVien,
            this.TenVietTat,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.DienThoai,
            this.Email,
            this.HocHamHocVi,
            this.MaChuyenNganh,
            this.Loai,
            this.ChucDanh,
            this.MaCCHN,
            this.NgayCapCCHN,
            this.NoiCapCCHN,
            this.TuNgay,
            this.DenNgay,
            this.VanBang,
            this.ThoiGianDK,
            this.KhoaBoPhan});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView.OptionsFind.FindNullPrompt = "Nhập từ khóa tìm kiếm";
            this.gridView.OptionsFind.SearchInPreview = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // MaKhoa
            // 
            this.MaKhoa.Caption = "Mã Khoa";
            this.MaKhoa.FieldName = "MA_KHOA";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.OptionsColumn.AllowEdit = false;
            this.MaKhoa.OptionsColumn.FixedWidth = true;
            this.MaKhoa.Visible = true;
            this.MaKhoa.VisibleIndex = 0;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Caption = "Mã NV";
            this.MaNhanVien.FieldName = "MA_NHANVIEN";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.OptionsColumn.AllowEdit = false;
            this.MaNhanVien.OptionsColumn.FixedWidth = true;
            this.MaNhanVien.Visible = true;
            this.MaNhanVien.VisibleIndex = 1;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Caption = "Tên NV";
            this.TenNhanVien.FieldName = "TEN_NHANVIEN";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.OptionsColumn.AllowEdit = false;
            this.TenNhanVien.OptionsColumn.FixedWidth = true;
            this.TenNhanVien.Visible = true;
            this.TenNhanVien.VisibleIndex = 2;
            this.TenNhanVien.Width = 120;
            // 
            // TenVietTat
            // 
            this.TenVietTat.Caption = "Tên Viết Tắt";
            this.TenVietTat.FieldName = "TEN_VIETTAT";
            this.TenVietTat.Name = "TenVietTat";
            this.TenVietTat.OptionsColumn.AllowEdit = false;
            this.TenVietTat.OptionsColumn.FixedWidth = true;
            this.TenVietTat.Visible = true;
            this.TenVietTat.VisibleIndex = 3;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.FieldName = "GIOI_TINH";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.OptionsColumn.AllowEdit = false;
            this.GioiTinh.OptionsColumn.FixedWidth = true;
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 4;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySinh.FieldName = "NGAY_SINH";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.OptionsColumn.AllowEdit = false;
            this.NgaySinh.OptionsColumn.FixedWidth = true;
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 5;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DIA_CHI";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.OptionsColumn.AllowEdit = false;
            this.DiaChi.OptionsColumn.FixedWidth = true;
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 6;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "Điện Thoại";
            this.DienThoai.FieldName = "DIEN_THOAI";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.OptionsColumn.AllowEdit = false;
            this.DienThoai.OptionsColumn.FixedWidth = true;
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 7;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "EMAIL";
            this.Email.Name = "Email";
            this.Email.OptionsColumn.AllowEdit = false;
            this.Email.OptionsColumn.FixedWidth = true;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 8;
            // 
            // HocHamHocVi
            // 
            this.HocHamHocVi.Caption = "Học Hàm / Học Vị";
            this.HocHamHocVi.FieldName = "HOCHAM_HOCVI";
            this.HocHamHocVi.Name = "HocHamHocVi";
            this.HocHamHocVi.OptionsColumn.AllowEdit = false;
            this.HocHamHocVi.OptionsColumn.FixedWidth = true;
            this.HocHamHocVi.Visible = true;
            this.HocHamHocVi.VisibleIndex = 9;
            // 
            // MaChuyenNganh
            // 
            this.MaChuyenNganh.Caption = "Chuyên Ngành";
            this.MaChuyenNganh.FieldName = "MA_CHUYENNGANH";
            this.MaChuyenNganh.Name = "MaChuyenNganh";
            this.MaChuyenNganh.OptionsColumn.AllowEdit = false;
            this.MaChuyenNganh.OptionsColumn.FixedWidth = true;
            this.MaChuyenNganh.Visible = true;
            this.MaChuyenNganh.VisibleIndex = 10;
            // 
            // Loai
            // 
            this.Loai.Caption = "Loại NV";
            this.Loai.FieldName = "LOAI";
            this.Loai.Name = "Loai";
            this.Loai.OptionsColumn.AllowEdit = false;
            this.Loai.OptionsColumn.FixedWidth = true;
            this.Loai.Visible = true;
            this.Loai.VisibleIndex = 11;
            // 
            // ChucDanh
            // 
            this.ChucDanh.Caption = "Chức Danh";
            this.ChucDanh.FieldName = "CHUC_DANH";
            this.ChucDanh.Name = "ChucDanh";
            this.ChucDanh.OptionsColumn.AllowEdit = false;
            this.ChucDanh.OptionsColumn.FixedWidth = true;
            this.ChucDanh.Visible = true;
            this.ChucDanh.VisibleIndex = 12;
            // 
            // MaCCHN
            // 
            this.MaCCHN.Caption = "Mã CCHN";
            this.MaCCHN.FieldName = "MA_CCHN";
            this.MaCCHN.Name = "MaCCHN";
            this.MaCCHN.OptionsColumn.AllowEdit = false;
            this.MaCCHN.OptionsColumn.FixedWidth = true;
            this.MaCCHN.Visible = true;
            this.MaCCHN.VisibleIndex = 13;
            // 
            // NgayCapCCHN
            // 
            this.NgayCapCCHN.Caption = "Ngày Cấp CCHN";
            this.NgayCapCCHN.FieldName = "NGAYCAP_CCHN";
            this.NgayCapCCHN.Name = "NgayCapCCHN";
            this.NgayCapCCHN.OptionsColumn.AllowEdit = false;
            this.NgayCapCCHN.OptionsColumn.FixedWidth = true;
            this.NgayCapCCHN.Visible = true;
            this.NgayCapCCHN.VisibleIndex = 14;
            // 
            // NoiCapCCHN
            // 
            this.NoiCapCCHN.Caption = "Nơi Cấp CCHN";
            this.NoiCapCCHN.FieldName = "NOICAP_CCHN";
            this.NoiCapCCHN.Name = "NoiCapCCHN";
            this.NoiCapCCHN.OptionsColumn.AllowEdit = false;
            this.NoiCapCCHN.OptionsColumn.FixedWidth = true;
            this.NoiCapCCHN.Visible = true;
            this.NoiCapCCHN.VisibleIndex = 15;
            // 
            // TuNgay
            // 
            this.TuNgay.Caption = "Từ Ngày";
            this.TuNgay.FieldName = "TU_NGAY";
            this.TuNgay.Name = "TuNgay";
            this.TuNgay.OptionsColumn.AllowEdit = false;
            this.TuNgay.OptionsColumn.FixedWidth = true;
            this.TuNgay.Visible = true;
            this.TuNgay.VisibleIndex = 16;
            // 
            // DenNgay
            // 
            this.DenNgay.Caption = "Đến Ngày";
            this.DenNgay.FieldName = "DEN_NGAY";
            this.DenNgay.Name = "DenNgay";
            this.DenNgay.OptionsColumn.AllowEdit = false;
            this.DenNgay.OptionsColumn.FixedWidth = true;
            this.DenNgay.Visible = true;
            this.DenNgay.VisibleIndex = 17;
            // 
            // VanBang
            // 
            this.VanBang.Caption = "Văn Bằng";
            this.VanBang.FieldName = "VANBANGCM";
            this.VanBang.Name = "VanBang";
            this.VanBang.OptionsColumn.AllowEdit = false;
            this.VanBang.OptionsColumn.FixedWidth = true;
            this.VanBang.Visible = true;
            this.VanBang.VisibleIndex = 18;
            // 
            // ThoiGianDK
            // 
            this.ThoiGianDK.Caption = "Thời Gian DK";
            this.ThoiGianDK.FieldName = "THOIGIAN_DK";
            this.ThoiGianDK.Name = "ThoiGianDK";
            this.ThoiGianDK.OptionsColumn.AllowEdit = false;
            this.ThoiGianDK.OptionsColumn.FixedWidth = true;
            this.ThoiGianDK.Visible = true;
            this.ThoiGianDK.VisibleIndex = 19;
            // 
            // KhoaBoPhan
            // 
            this.KhoaBoPhan.Caption = "Khoa/Bộ Phận";
            this.KhoaBoPhan.FieldName = "KHOA_BOPHAN";
            this.KhoaBoPhan.Name = "KhoaBoPhan";
            this.KhoaBoPhan.OptionsColumn.AllowEdit = false;
            this.KhoaBoPhan.OptionsColumn.FixedWidth = true;
            this.KhoaBoPhan.Visible = true;
            this.KhoaBoPhan.VisibleIndex = 20;
            // 
            // bntNhapExcel
            // 
            this.bntNhapExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhapExcel.Appearance.Options.UseFont = true;
            this.bntNhapExcel.Image = ((System.Drawing.Image)(resources.GetObject("bntNhapExcel.Image")));
            this.bntNhapExcel.Location = new System.Drawing.Point(1236, 12);
            this.bntNhapExcel.Name = "bntNhapExcel";
            this.bntNhapExcel.Size = new System.Drawing.Size(106, 33);
            this.bntNhapExcel.TabIndex = 1;
            this.bntNhapExcel.Text = "Nhập Excel";
            this.bntNhapExcel.Click += new System.EventHandler(this.bntNhapExcel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(140, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.Location = new System.Drawing.Point(28, 14);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(75, 30);
            this.btnMoi.TabIndex = 26;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 481);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.bntNhapExcel);
            this.Controls.Add(this.gridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Nhân viên y tế";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn TenVietTat;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn HocHamHocVi;
        private DevExpress.XtraGrid.Columns.GridColumn MaChuyenNganh;
        private DevExpress.XtraGrid.Columns.GridColumn Loai;
        private DevExpress.XtraGrid.Columns.GridColumn ChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn MaCCHN;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCapCCHN;
        private DevExpress.XtraGrid.Columns.GridColumn NoiCapCCHN;
        private DevExpress.XtraGrid.Columns.GridColumn TuNgay;
        private DevExpress.XtraGrid.Columns.GridColumn DenNgay;
        private DevExpress.XtraGrid.Columns.GridColumn VanBang;
        private DevExpress.XtraGrid.Columns.GridColumn ThoiGianDK;
        private DevExpress.XtraGrid.Columns.GridColumn KhoaBoPhan;
        private DevExpress.XtraEditors.SimpleButton bntNhapExcel;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
    }
}