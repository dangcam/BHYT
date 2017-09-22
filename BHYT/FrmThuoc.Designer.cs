namespace BHYT
{
    partial class FrmThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThuoc));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bntNhapExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoatChat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HamLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DuongDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.QuyCach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TieuChuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyetDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NuocSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HanDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhomThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnItemXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItemXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNhapExcel
            // 
            this.bntNhapExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhapExcel.Appearance.Options.UseFont = true;
            this.bntNhapExcel.Image = ((System.Drawing.Image)(resources.GetObject("bntNhapExcel.Image")));
            this.bntNhapExcel.Location = new System.Drawing.Point(1236, 12);
            this.bntNhapExcel.Name = "bntNhapExcel";
            this.bntNhapExcel.Size = new System.Drawing.Size(106, 33);
            this.bntNhapExcel.TabIndex = 2;
            this.bntNhapExcel.Text = "Nhập Excel";
            this.bntNhapExcel.Click += new System.EventHandler(this.bntNhapExcel_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Location = new System.Drawing.Point(0, 51);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnItemXoa,
            this.lookUpDonViTinh});
            this.gridControl.Size = new System.Drawing.Size(1354, 560);
            this.gridControl.TabIndex = 3;
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
            this.MaThuoc,
            this.TenThuoc,
            this.HoatChat,
            this.HamLuong,
            this.DuongDung,
            this.QuyCach,
            this.TieuChuan,
            this.DonViTinh,
            this.DonGia,
            this.SoDK,
            this.QuyetDinh,
            this.NhaSX,
            this.NuocSX,
            this.HanDung,
            this.NhomThuoc,
            this.Nhom,
            this.TinhTrang,
            this.btnXoaThuoc});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_RowUpdated);
            // 
            // MaThuoc
            // 
            this.MaThuoc.Caption = "Mã Thuốc";
            this.MaThuoc.FieldName = "MA_THUOC";
            this.MaThuoc.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.OptionsColumn.AllowEdit = false;
            this.MaThuoc.Visible = true;
            this.MaThuoc.VisibleIndex = 0;
            this.MaThuoc.Width = 70;
            // 
            // TenThuoc
            // 
            this.TenThuoc.Caption = "Tên Thuốc";
            this.TenThuoc.FieldName = "TEN_THUOC";
            this.TenThuoc.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.OptionsColumn.AllowEdit = false;
            this.TenThuoc.Visible = true;
            this.TenThuoc.VisibleIndex = 1;
            this.TenThuoc.Width = 120;
            // 
            // HoatChat
            // 
            this.HoatChat.Caption = "Hoạt Chất";
            this.HoatChat.FieldName = "HOAT_CHAT";
            this.HoatChat.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.HoatChat.Name = "HoatChat";
            this.HoatChat.OptionsColumn.AllowEdit = false;
            this.HoatChat.Visible = true;
            this.HoatChat.VisibleIndex = 2;
            this.HoatChat.Width = 170;
            // 
            // HamLuong
            // 
            this.HamLuong.Caption = "Hàm Lượng";
            this.HamLuong.FieldName = "HAM_LUONG";
            this.HamLuong.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.HamLuong.Name = "HamLuong";
            this.HamLuong.OptionsColumn.AllowEdit = false;
            this.HamLuong.Visible = true;
            this.HamLuong.VisibleIndex = 3;
            this.HamLuong.Width = 120;
            // 
            // DuongDung
            // 
            this.DuongDung.Caption = "Đường Dùng";
            this.DuongDung.ColumnEdit = this.lookUpDonViTinh;
            this.DuongDung.FieldName = "DUONG_DUNG";
            this.DuongDung.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.DuongDung.Name = "DuongDung";
            this.DuongDung.OptionsColumn.AllowEdit = false;
            this.DuongDung.Visible = true;
            this.DuongDung.VisibleIndex = 4;
            this.DuongDung.Width = 50;
            // 
            // lookUpDonViTinh
            // 
            this.lookUpDonViTinh.AutoHeight = false;
            this.lookUpDonViTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpDonViTinh.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mã", "MA_DUONG_DUNG"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Đường Dùng", "DUONG_DUNG")});
            this.lookUpDonViTinh.Name = "lookUpDonViTinh";
            this.lookUpDonViTinh.NullText = "";
            // 
            // QuyCach
            // 
            this.QuyCach.Caption = "Quy Cách";
            this.QuyCach.FieldName = "QUY_CACH";
            this.QuyCach.Name = "QuyCach";
            this.QuyCach.OptionsColumn.AllowEdit = false;
            this.QuyCach.Visible = true;
            this.QuyCach.VisibleIndex = 5;
            this.QuyCach.Width = 80;
            // 
            // TieuChuan
            // 
            this.TieuChuan.Caption = "Tiêu Chuẩn";
            this.TieuChuan.FieldName = "TIEU_CHUAN";
            this.TieuChuan.Name = "TieuChuan";
            this.TieuChuan.OptionsColumn.AllowEdit = false;
            this.TieuChuan.Visible = true;
            this.TieuChuan.VisibleIndex = 6;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn Vị Tính";
            this.DonViTinh.FieldName = "DON_VI_TINH";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 7;
            this.DonViTinh.Width = 50;
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
            this.DonGia.VisibleIndex = 8;
            this.DonGia.Width = 80;
            // 
            // SoDK
            // 
            this.SoDK.Caption = "Số ĐK";
            this.SoDK.FieldName = "SO_DK";
            this.SoDK.Name = "SoDK";
            this.SoDK.OptionsColumn.AllowEdit = false;
            this.SoDK.Visible = true;
            this.SoDK.VisibleIndex = 9;
            // 
            // QuyetDinh
            // 
            this.QuyetDinh.Caption = "Quyết Định";
            this.QuyetDinh.FieldName = "QUYET_DINH";
            this.QuyetDinh.Name = "QuyetDinh";
            this.QuyetDinh.OptionsColumn.AllowEdit = false;
            this.QuyetDinh.Visible = true;
            this.QuyetDinh.VisibleIndex = 10;
            // 
            // NhaSX
            // 
            this.NhaSX.Caption = "Nhà SX";
            this.NhaSX.FieldName = "NHA_SX";
            this.NhaSX.Name = "NhaSX";
            this.NhaSX.OptionsColumn.AllowEdit = false;
            this.NhaSX.Visible = true;
            this.NhaSX.VisibleIndex = 11;
            // 
            // NuocSX
            // 
            this.NuocSX.Caption = "Nước SX";
            this.NuocSX.FieldName = "NUOC_SX";
            this.NuocSX.Name = "NuocSX";
            this.NuocSX.OptionsColumn.AllowEdit = false;
            this.NuocSX.Visible = true;
            this.NuocSX.VisibleIndex = 12;
            // 
            // HanDung
            // 
            this.HanDung.Caption = "Hạn Dùng";
            this.HanDung.FieldName = "HAN_DUNG";
            this.HanDung.Name = "HanDung";
            this.HanDung.OptionsColumn.AllowEdit = false;
            this.HanDung.Visible = true;
            this.HanDung.VisibleIndex = 13;
            // 
            // NhomThuoc
            // 
            this.NhomThuoc.Caption = "Nhóm Thuốc";
            this.NhomThuoc.FieldName = "NHOM_THUOC";
            this.NhomThuoc.Name = "NhomThuoc";
            this.NhomThuoc.OptionsColumn.AllowEdit = false;
            this.NhomThuoc.Visible = true;
            this.NhomThuoc.VisibleIndex = 14;
            this.NhomThuoc.Width = 40;
            // 
            // Nhom
            // 
            this.Nhom.Caption = "Nhóm";
            this.Nhom.FieldName = "NHOM";
            this.Nhom.Name = "Nhom";
            this.Nhom.OptionsColumn.AllowEdit = false;
            this.Nhom.Visible = true;
            this.Nhom.VisibleIndex = 15;
            this.Nhom.Width = 40;
            // 
            // TinhTrang
            // 
            this.TinhTrang.Caption = "Ẩn/Hiện";
            this.TinhTrang.FieldName = "TINH_TRANG";
            this.TinhTrang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 16;
            this.TinhTrang.Width = 40;
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.Caption = "#";
            this.btnXoaThuoc.ColumnEdit = this.btnItemXoa;
            this.btnXoaThuoc.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Visible = true;
            this.btnXoaThuoc.VisibleIndex = 17;
            this.btnXoaThuoc.Width = 30;
            // 
            // btnItemXoa
            // 
            this.btnItemXoa.AutoHeight = false;
            this.btnItemXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnItemXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnItemXoa.Name = "btnItemXoa";
            this.btnItemXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnItemXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnItemXoa_ButtonClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1141, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 611);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.bntNhapExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục thuốc";
            this.Load += new System.EventHandler(this.FrmThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItemXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bntNhapExcel;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn MaThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn HoatChat;
        private DevExpress.XtraGrid.Columns.GridColumn HamLuong;
        private DevExpress.XtraGrid.Columns.GridColumn QuyCach;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoDK;
        private DevExpress.XtraGrid.Columns.GridColumn QuyetDinh;
        private DevExpress.XtraGrid.Columns.GridColumn NhaSX;
        private DevExpress.XtraGrid.Columns.GridColumn NuocSX;
        private DevExpress.XtraGrid.Columns.GridColumn NhomThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn Nhom;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn btnXoaThuoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnItemXoa;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn TieuChuan;
        private DevExpress.XtraGrid.Columns.GridColumn HanDung;
        private DevExpress.XtraGrid.Columns.GridColumn DuongDung;
    }
}