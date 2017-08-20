namespace BHYT
{
    partial class FrmDanhSachKCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachKCB));
            this.cbLoaiKCB = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dateTu = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.dateDen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayVao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.lblTong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiNgay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiKCB
            // 
            this.cbLoaiKCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiKCB.FormattingEnabled = true;
            this.cbLoaiKCB.Items.AddRange(new object[] {
            "1. Khám bệnh",
            "2. Điều trị ngoại trú",
            "3. Điều trị nội trú"});
            this.cbLoaiKCB.Location = new System.Drawing.Point(87, 12);
            this.cbLoaiKCB.Name = "cbLoaiKCB";
            this.cbLoaiKCB.Size = new System.Drawing.Size(163, 24);
            this.cbLoaiKCB.TabIndex = 58;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(21, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 16);
            this.label31.TabIndex = 59;
            this.label31.Text = "Loại KCB:";
            // 
            // dateTu
            // 
            this.dateTu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTu.CustomFormat = "dd/MM/yyyy";
            this.dateTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTu.Location = new System.Drawing.Point(658, 14);
            this.dateTu.Name = "dateTu";
            this.dateTu.Size = new System.Drawing.Size(129, 22);
            this.dateTu.TabIndex = 60;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(629, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 16);
            this.label25.TabIndex = 61;
            this.label25.Text = " từ:";
            // 
            // dateDen
            // 
            this.dateDen.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDen.CustomFormat = "dd/MM/yyyy";
            this.dateDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDen.Location = new System.Drawing.Point(825, 14);
            this.dateDen.Name = "dateDen";
            this.dateDen.Size = new System.Drawing.Size(129, 22);
            this.dateDen.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(790, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "đến";
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOK.Location = new System.Drawing.Point(973, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(51, 33);
            this.btnOK.TabIndex = 63;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Location = new System.Drawing.Point(0, 56);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheck});
            this.gridControl.Size = new System.Drawing.Size(1120, 515);
            this.gridControl.TabIndex = 64;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLK,
            this.MaBN,
            this.MaThe,
            this.HoTen,
            this.NgaySinh,
            this.NgayVao,
            this.NgayRa,
            this.TenBenh,
            this.TongTien,
            this.Phong,
            this.CheckOut});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindDelay = 500;
            this.gridView.OptionsFind.FindNullPrompt = "Nhập thông tin tìm kiếm";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_RowUpdated);
            this.gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView_CustomColumnDisplayText);
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // MaLK
            // 
            this.MaLK.Caption = "MALK";
            this.MaLK.FieldName = "MA_LK";
            this.MaLK.Name = "MaLK";
            // 
            // MaBN
            // 
            this.MaBN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaBN.AppearanceCell.Options.UseFont = true;
            this.MaBN.Caption = "Số Phiếu";
            this.MaBN.FieldName = "MA_BN";
            this.MaBN.Name = "MaBN";
            this.MaBN.OptionsColumn.AllowEdit = false;
            this.MaBN.Visible = true;
            this.MaBN.VisibleIndex = 0;
            this.MaBN.Width = 104;
            // 
            // MaThe
            // 
            this.MaThe.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaThe.AppearanceCell.Options.UseFont = true;
            this.MaThe.Caption = "Thẻ BHYT";
            this.MaThe.FieldName = "MA_THE";
            this.MaThe.Name = "MaThe";
            this.MaThe.OptionsColumn.AllowEdit = false;
            this.MaThe.Visible = true;
            this.MaThe.VisibleIndex = 1;
            this.MaThe.Width = 132;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceCell.Options.UseFont = true;
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.FieldName = "HO_TEN";
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.AllowEdit = false;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            this.HoTen.Width = 199;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.AppearanceCell.Options.UseFont = true;
            this.NgaySinh.Caption = "Ngày Sinh";
            this.NgaySinh.DisplayFormat.FormatString = "d";
            this.NgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySinh.FieldName = "NGAY_SINH";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.OptionsColumn.AllowEdit = false;
            this.NgaySinh.Visible = true;
            this.NgaySinh.VisibleIndex = 3;
            this.NgaySinh.Width = 79;
            // 
            // NgayVao
            // 
            this.NgayVao.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayVao.AppearanceCell.Options.UseFont = true;
            this.NgayVao.Caption = "Ngày Vào";
            this.NgayVao.DisplayFormat.FormatString = "d";
            this.NgayVao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayVao.FieldName = "NGAY_VAO";
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.OptionsColumn.AllowEdit = false;
            this.NgayVao.Visible = true;
            this.NgayVao.VisibleIndex = 4;
            this.NgayVao.Width = 79;
            // 
            // NgayRa
            // 
            this.NgayRa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayRa.AppearanceCell.Options.UseFont = true;
            this.NgayRa.Caption = "Ngày Ra";
            this.NgayRa.DisplayFormat.FormatString = "d";
            this.NgayRa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgayRa.FieldName = "NGAY_RA";
            this.NgayRa.Name = "NgayRa";
            this.NgayRa.OptionsColumn.AllowEdit = false;
            this.NgayRa.Visible = true;
            this.NgayRa.VisibleIndex = 5;
            this.NgayRa.Width = 79;
            // 
            // TenBenh
            // 
            this.TenBenh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenBenh.AppearanceCell.Options.UseFont = true;
            this.TenBenh.Caption = "Tên Bệnh";
            this.TenBenh.FieldName = "TEN_BENH";
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.OptionsColumn.AllowEdit = false;
            this.TenBenh.OptionsFilter.AllowAutoFilter = false;
            this.TenBenh.OptionsFilter.AllowFilter = false;
            this.TenBenh.Visible = true;
            this.TenBenh.VisibleIndex = 6;
            this.TenBenh.Width = 199;
            // 
            // TongTien
            // 
            this.TongTien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongTien.AppearanceCell.Options.UseFont = true;
            this.TongTien.Caption = "Tổng Tiền";
            this.TongTien.DisplayFormat.FormatString = "#,###";
            this.TongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TongTien.FieldName = "T_TONGCHI";
            this.TongTien.Name = "TongTien";
            this.TongTien.OptionsColumn.AllowEdit = false;
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 7;
            this.TongTien.Width = 111;
            // 
            // Phong
            // 
            this.Phong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phong.AppearanceCell.Options.UseFont = true;
            this.Phong.Caption = "Phòng khám";
            this.Phong.FieldName = "PHONG";
            this.Phong.Name = "Phong";
            this.Phong.OptionsColumn.AllowEdit = false;
            this.Phong.OptionsColumn.FixedWidth = true;
            this.Phong.Visible = true;
            this.Phong.VisibleIndex = 8;
            // 
            // CheckOut
            // 
            this.CheckOut.Caption = "#";
            this.CheckOut.ColumnEdit = this.repositoryItemCheck;
            this.CheckOut.FieldName = "CHECK_OUT";
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.OptionsColumn.FixedWidth = true;
            this.CheckOut.Visible = true;
            this.CheckOut.VisibleIndex = 9;
            this.CheckOut.Width = 30;
            // 
            // repositoryItemCheck
            // 
            this.repositoryItemCheck.AutoHeight = false;
            this.repositoryItemCheck.Name = "repositoryItemCheck";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(1032, 16);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(53, 16);
            this.lblTong.TabIndex = 65;
            this.lblTong.Text = "Tổng: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Phòng khám:";
            // 
            // cbPhong
            // 
            this.cbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Items.AddRange(new object[] {
            "Tất cả",
            "1",
            "2",
            "3",
            "4"});
            this.cbPhong.Location = new System.Drawing.Point(348, 12);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(71, 24);
            this.cbPhong.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tìm theo:";
            // 
            // cbLoaiNgay
            // 
            this.cbLoaiNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiNgay.FormattingEnabled = true;
            this.cbLoaiNgay.Items.AddRange(new object[] {
            "Ngày vào",
            "Ngày thanh toán"});
            this.cbLoaiNgay.Location = new System.Drawing.Point(499, 12);
            this.cbLoaiNgay.Name = "cbLoaiNgay";
            this.cbLoaiNgay.Size = new System.Drawing.Size(124, 24);
            this.cbLoaiNgay.TabIndex = 67;
            // 
            // FrmDanhSachKCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLoaiNgay);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDen);
            this.Controls.Add(this.dateTu);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cbLoaiKCB);
            this.Controls.Add(this.label31);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDanhSachKCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Khám Chữa Bệnh";
            this.Load += new System.EventHandler(this.FrmDanhSachKCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiKCB;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker dateTu;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dateDen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaLK;
        private DevExpress.XtraGrid.Columns.GridColumn MaBN;
        private DevExpress.XtraGrid.Columns.GridColumn MaThe;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn NgayVao;
        private DevExpress.XtraGrid.Columns.GridColumn NgayRa;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraGrid.Columns.GridColumn TenBenh;
        private System.Windows.Forms.Label lblTong;
        private DevExpress.XtraGrid.Columns.GridColumn CheckOut;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheck;
        private DevExpress.XtraGrid.Columns.GridColumn Phong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiNgay;
    }
}