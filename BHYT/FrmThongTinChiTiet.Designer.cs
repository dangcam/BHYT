namespace BHYT
{
    partial class FrmThongTinChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongTinChiTiet));
            this.gridControlXML3 = new DevExpress.XtraGrid.GridControl();
            this.gridViewXML3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlXML2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewXML2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Stt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HamLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LieuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stt3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXML3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXML3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXML2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXML2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlXML3
            // 
            this.gridControlXML3.Location = new System.Drawing.Point(12, 196);
            this.gridControlXML3.MainView = this.gridViewXML3;
            this.gridControlXML3.Name = "gridControlXML3";
            this.gridControlXML3.Size = new System.Drawing.Size(877, 132);
            this.gridControlXML3.TabIndex = 0;
            this.gridControlXML3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewXML3});
            // 
            // gridViewXML3
            // 
            this.gridViewXML3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Stt3,
            this.MaDichVu,
            this.TenDichVu,
            this.DonViTinh3,
            this.SoLuong3,
            this.DonGia3,
            this.ThanhTien3});
            this.gridViewXML3.GridControl = this.gridControlXML3;
            this.gridViewXML3.Name = "gridViewXML3";
            this.gridViewXML3.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlXML2
            // 
            this.gridControlXML2.Location = new System.Drawing.Point(12, 12);
            this.gridControlXML2.MainView = this.gridViewXML2;
            this.gridControlXML2.Name = "gridControlXML2";
            this.gridControlXML2.Size = new System.Drawing.Size(877, 178);
            this.gridControlXML2.TabIndex = 0;
            this.gridControlXML2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewXML2});
            // 
            // gridViewXML2
            // 
            this.gridViewXML2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Stt,
            this.MaThuoc,
            this.TenThuoc,
            this.HamLuong,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien,
            this.LieuDung});
            this.gridViewXML2.GridControl = this.gridControlXML2;
            this.gridViewXML2.Name = "gridViewXML2";
            this.gridViewXML2.OptionsView.ShowGroupPanel = false;
            // 
            // Stt
            // 
            this.Stt.Caption = "STT";
            this.Stt.FieldName = "Stt";
            this.Stt.Name = "Stt";
            this.Stt.OptionsColumn.AllowEdit = false;
            this.Stt.Visible = true;
            this.Stt.VisibleIndex = 0;
            this.Stt.Width = 39;
            // 
            // MaThuoc
            // 
            this.MaThuoc.Caption = "Mã Thuốc";
            this.MaThuoc.FieldName = "MaThuoc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.OptionsColumn.AllowEdit = false;
            this.MaThuoc.Visible = true;
            this.MaThuoc.VisibleIndex = 1;
            this.MaThuoc.Width = 68;
            // 
            // TenThuoc
            // 
            this.TenThuoc.Caption = "Tên Thuốc";
            this.TenThuoc.FieldName = "TenThuoc";
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Visible = true;
            this.TenThuoc.VisibleIndex = 2;
            this.TenThuoc.Width = 154;
            // 
            // HamLuong
            // 
            this.HamLuong.Caption = "Hàm Lượng";
            this.HamLuong.FieldName = "HamLuong";
            this.HamLuong.Name = "HamLuong";
            this.HamLuong.OptionsColumn.AllowEdit = false;
            this.HamLuong.Visible = true;
            this.HamLuong.VisibleIndex = 3;
            this.HamLuong.Width = 140;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn Vị";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.OptionsColumn.AllowEdit = false;
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 4;
            this.DonViTinh.Width = 55;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowEdit = false;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 5;
            this.SoLuong.Width = 60;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 6;
            this.DonGia.Width = 56;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành Tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.AllowEdit = false;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 7;
            this.ThanhTien.Width = 66;
            // 
            // LieuDung
            // 
            this.LieuDung.Caption = "Liều Dùng";
            this.LieuDung.FieldName = "LieuDung";
            this.LieuDung.Name = "LieuDung";
            this.LieuDung.OptionsColumn.AllowEdit = false;
            this.LieuDung.Visible = true;
            this.LieuDung.VisibleIndex = 8;
            this.LieuDung.Width = 221;
            // 
            // Stt3
            // 
            this.Stt3.Caption = "STT";
            this.Stt3.FieldName = "Stt";
            this.Stt3.Name = "Stt3";
            this.Stt3.OptionsColumn.AllowEdit = false;
            this.Stt3.Visible = true;
            this.Stt3.VisibleIndex = 0;
            this.Stt3.Width = 38;
            // 
            // MaDichVu
            // 
            this.MaDichVu.Caption = "Mã DV";
            this.MaDichVu.FieldName = "MaDichVu";
            this.MaDichVu.Name = "MaDichVu";
            this.MaDichVu.OptionsColumn.AllowEdit = false;
            this.MaDichVu.Visible = true;
            this.MaDichVu.VisibleIndex = 1;
            this.MaDichVu.Width = 71;
            // 
            // TenDichVu
            // 
            this.TenDichVu.Caption = "Tên Dịch Vụ";
            this.TenDichVu.FieldName = "TenDichVu";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.OptionsColumn.AllowEdit = false;
            this.TenDichVu.Visible = true;
            this.TenDichVu.VisibleIndex = 2;
            this.TenDichVu.Width = 302;
            // 
            // DonViTinh3
            // 
            this.DonViTinh3.Caption = "Đơn Vị";
            this.DonViTinh3.FieldName = "DonViTinh";
            this.DonViTinh3.Name = "DonViTinh3";
            this.DonViTinh3.OptionsColumn.AllowEdit = false;
            this.DonViTinh3.Visible = true;
            this.DonViTinh3.VisibleIndex = 3;
            this.DonViTinh3.Width = 108;
            // 
            // SoLuong3
            // 
            this.SoLuong3.Caption = "Số Lượng";
            this.SoLuong3.FieldName = "SoLuong";
            this.SoLuong3.Name = "SoLuong3";
            this.SoLuong3.OptionsColumn.AllowEdit = false;
            this.SoLuong3.Visible = true;
            this.SoLuong3.VisibleIndex = 4;
            this.SoLuong3.Width = 108;
            // 
            // DonGia3
            // 
            this.DonGia3.Caption = "Đơn Giá";
            this.DonGia3.FieldName = "DonGia";
            this.DonGia3.Name = "DonGia3";
            this.DonGia3.OptionsColumn.AllowEdit = false;
            this.DonGia3.Visible = true;
            this.DonGia3.VisibleIndex = 5;
            this.DonGia3.Width = 108;
            // 
            // ThanhTien3
            // 
            this.ThanhTien3.Caption = "Thành Tiền";
            this.ThanhTien3.FieldName = "ThanhTien";
            this.ThanhTien3.Name = "ThanhTien3";
            this.ThanhTien3.OptionsColumn.AllowEdit = false;
            this.ThanhTien3.Visible = true;
            this.ThanhTien3.VisibleIndex = 6;
            this.ThanhTien3.Width = 124;
            // 
            // FrmThongTinChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 340);
            this.Controls.Add(this.gridControlXML2);
            this.Controls.Add(this.gridControlXML3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongTinChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.FrmThongTinChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXML3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXML3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXML2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXML2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlXML3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewXML3;
        private DevExpress.XtraGrid.GridControl gridControlXML2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewXML2;
        private DevExpress.XtraGrid.Columns.GridColumn Stt;
        private DevExpress.XtraGrid.Columns.GridColumn MaThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn TenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn HamLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn LieuDung;
        private DevExpress.XtraGrid.Columns.GridColumn Stt3;
        private DevExpress.XtraGrid.Columns.GridColumn MaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn TenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh3;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong3;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia3;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien3;
    }
}