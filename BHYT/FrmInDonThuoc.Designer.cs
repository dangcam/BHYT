namespace BHYT
{
    partial class FrmInDonThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInDonThuoc));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpDuongDung = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LanNgayDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LanDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LieuDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnInDonThuoc = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDuongDung)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpDuongDung});
            this.gridControl.Size = new System.Drawing.Size(1208, 386);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenThuoc,
            this.SoLuong,
            this.NgayDung,
            this.LanNgayDung,
            this.LanDung,
            this.DonVi,
            this.LieuDung});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // TenThuoc
            // 
            this.TenThuoc.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenThuoc.AppearanceCell.Options.UseFont = true;
            this.TenThuoc.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenThuoc.AppearanceHeader.Options.UseFont = true;
            this.TenThuoc.Caption = "Tên Thuốc";
            this.TenThuoc.FieldName = "TEN_THUOC";
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.OptionsColumn.AllowEdit = false;
            this.TenThuoc.OptionsColumn.FixedWidth = true;
            this.TenThuoc.Visible = true;
            this.TenThuoc.VisibleIndex = 0;
            this.TenThuoc.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.AppearanceCell.Options.UseFont = true;
            this.SoLuong.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuong.AppearanceHeader.Options.UseFont = true;
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SO_LUONG";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowEdit = false;
            this.SoLuong.OptionsColumn.FixedWidth = true;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 1;
            this.SoLuong.Width = 40;
            // 
            // NgayDung
            // 
            this.NgayDung.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayDung.AppearanceCell.Options.UseFont = true;
            this.NgayDung.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayDung.AppearanceHeader.Options.UseFont = true;
            this.NgayDung.Caption = "Ngày Dùng";
            this.NgayDung.ColumnEdit = this.lookUpDuongDung;
            this.NgayDung.FieldName = "DUONG_DUNG";
            this.NgayDung.Name = "NgayDung";
            this.NgayDung.OptionsColumn.FixedWidth = true;
            this.NgayDung.Visible = true;
            this.NgayDung.VisibleIndex = 2;
            this.NgayDung.Width = 60;
            // 
            // lookUpDuongDung
            // 
            this.lookUpDuongDung.AutoHeight = false;
            this.lookUpDuongDung.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpDuongDung.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MA_DUONG_DUNG", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DUONG_DUNG", "Đường Dùng")});
            this.lookUpDuongDung.Name = "lookUpDuongDung";
            this.lookUpDuongDung.NullText = "";
            this.lookUpDuongDung.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // LanNgayDung
            // 
            this.LanNgayDung.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanNgayDung.AppearanceCell.Options.UseFont = true;
            this.LanNgayDung.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanNgayDung.AppearanceHeader.Options.UseFont = true;
            this.LanNgayDung.Caption = "Lần Ngày";
            this.LanNgayDung.FieldName = "LAN_NGAY_DUNG";
            this.LanNgayDung.Name = "LanNgayDung";
            this.LanNgayDung.OptionsColumn.FixedWidth = true;
            this.LanNgayDung.Visible = true;
            this.LanNgayDung.VisibleIndex = 3;
            this.LanNgayDung.Width = 50;
            // 
            // LanDung
            // 
            this.LanDung.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanDung.AppearanceCell.Options.UseFont = true;
            this.LanDung.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanDung.AppearanceHeader.Options.UseFont = true;
            this.LanDung.Caption = "Lần Dùng";
            this.LanDung.FieldName = "LAN_DUNG";
            this.LanDung.Name = "LanDung";
            this.LanDung.OptionsColumn.FixedWidth = true;
            this.LanDung.Visible = true;
            this.LanDung.VisibleIndex = 4;
            this.LanDung.Width = 50;
            // 
            // DonVi
            // 
            this.DonVi.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonVi.AppearanceCell.Options.UseFont = true;
            this.DonVi.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonVi.AppearanceHeader.Options.UseFont = true;
            this.DonVi.Caption = "Đơn Vị";
            this.DonVi.FieldName = "DON_VI_TINH";
            this.DonVi.Name = "DonVi";
            this.DonVi.OptionsColumn.FixedWidth = true;
            this.DonVi.Visible = true;
            this.DonVi.VisibleIndex = 5;
            this.DonVi.Width = 70;
            // 
            // LieuDung
            // 
            this.LieuDung.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LieuDung.AppearanceCell.Options.UseFont = true;
            this.LieuDung.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LieuDung.AppearanceHeader.Options.UseFont = true;
            this.LieuDung.Caption = "Ghi Chú";
            this.LieuDung.FieldName = "LIEU_DUNG";
            this.LieuDung.Name = "LieuDung";
            this.LieuDung.OptionsColumn.FixedWidth = true;
            this.LieuDung.Visible = true;
            this.LieuDung.VisibleIndex = 6;
            this.LieuDung.Width = 170;
            // 
            // btnInDonThuoc
            // 
            this.btnInDonThuoc.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDonThuoc.Appearance.Options.UseFont = true;
            this.btnInDonThuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDonThuoc.ImageOptions.Image")));
            this.btnInDonThuoc.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnInDonThuoc.Location = new System.Drawing.Point(540, 395);
            this.btnInDonThuoc.Name = "btnInDonThuoc";
            this.btnInDonThuoc.Size = new System.Drawing.Size(128, 30);
            this.btnInDonThuoc.TabIndex = 2;
            this.btnInDonThuoc.Text = "In Đơn Thuốc";
            this.btnInDonThuoc.Click += new System.EventHandler(this.btnInDonThuoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nghề Nghiệp:";
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.Location = new System.Drawing.Point(109, 399);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(232, 22);
            this.txtNgheNghiep.TabIndex = 1;
            this.txtNgheNghiep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgheNghiep_KeyPress);
            // 
            // FrmInDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 437);
            this.Controls.Add(this.txtNgheNghiep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInDonThuoc);
            this.Controls.Add(this.gridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInDonThuoc_FormClosing);
            this.Load += new System.EventHandler(this.FrmInDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDuongDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn TenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDung;
        private DevExpress.XtraGrid.Columns.GridColumn LanNgayDung;
        private DevExpress.XtraGrid.Columns.GridColumn LanDung;
        private DevExpress.XtraGrid.Columns.GridColumn DonVi;
        private DevExpress.XtraGrid.Columns.GridColumn LieuDung;
        private DevExpress.XtraEditors.SimpleButton btnInDonThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpDuongDung;
    }
}