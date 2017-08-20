namespace BHYT
{
    partial class FrmTienGiuongChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTienGiuongChiTiet));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.NgayYL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TyleTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgayYLenh = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.lookUpMaKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpMaBS = new DevExpress.XtraEditors.LookUpEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoNgay = new System.Windows.Forms.NumericUpDown();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpLoaiGiuong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaGuong = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaBS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpLoaiGiuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(0, 83);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa,
            this.repositoryItemSpinEdit});
            this.gridControl.Size = new System.Drawing.Size(1168, 403);
            this.gridControl.TabIndex = 0;
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
            this.Delete,
            this.NgayYL,
            this.LoaiGiuong,
            this.SoNgay,
            this.Khoa,
            this.BS,
            this.DonGia,
            this.TyleTT,
            this.ThanhTien});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_RowUpdated);
            // 
            // Delete
            // 
            this.Delete.Caption = "#";
            this.Delete.ColumnEdit = this.btnXoa;
            this.Delete.Name = "Delete";
            this.Delete.OptionsColumn.FixedWidth = true;
            this.Delete.Visible = true;
            this.Delete.VisibleIndex = 0;
            this.Delete.Width = 20;
            // 
            // btnXoa
            // 
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // NgayYL
            // 
            this.NgayYL.Caption = "Ngày y lệnh";
            this.NgayYL.FieldName = "NGAY_YL";
            this.NgayYL.Name = "NgayYL";
            this.NgayYL.OptionsColumn.FixedWidth = true;
            this.NgayYL.Visible = true;
            this.NgayYL.VisibleIndex = 1;
            this.NgayYL.Width = 50;
            // 
            // LoaiGiuong
            // 
            this.LoaiGiuong.Caption = "Loại giường";
            this.LoaiGiuong.FieldName = "TEN_DICH_VU";
            this.LoaiGiuong.Name = "LoaiGiuong";
            this.LoaiGiuong.OptionsColumn.AllowEdit = false;
            this.LoaiGiuong.OptionsColumn.FixedWidth = true;
            this.LoaiGiuong.Visible = true;
            this.LoaiGiuong.VisibleIndex = 2;
            this.LoaiGiuong.Width = 150;
            // 
            // SoNgay
            // 
            this.SoNgay.Caption = "Số ngày";
            this.SoNgay.ColumnEdit = this.repositoryItemSpinEdit;
            this.SoNgay.FieldName = "SO_LUONG";
            this.SoNgay.Name = "SoNgay";
            this.SoNgay.OptionsColumn.FixedWidth = true;
            this.SoNgay.Visible = true;
            this.SoNgay.VisibleIndex = 3;
            this.SoNgay.Width = 30;
            // 
            // repositoryItemSpinEdit
            // 
            this.repositoryItemSpinEdit.AutoHeight = false;
            this.repositoryItemSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit.MaxLength = 3;
            this.repositoryItemSpinEdit.MaxValue = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.repositoryItemSpinEdit.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit.Name = "repositoryItemSpinEdit";
            // 
            // Khoa
            // 
            this.Khoa.Caption = "Khoa";
            this.Khoa.FieldName = "MA_KHOA";
            this.Khoa.Name = "Khoa";
            this.Khoa.OptionsColumn.FixedWidth = true;
            this.Khoa.Visible = true;
            this.Khoa.VisibleIndex = 4;
            this.Khoa.Width = 30;
            // 
            // BS
            // 
            this.BS.Caption = "Bác sĩ";
            this.BS.FieldName = "MA_BAC_SI";
            this.BS.Name = "BS";
            this.BS.OptionsColumn.FixedWidth = true;
            this.BS.Visible = true;
            this.BS.VisibleIndex = 5;
            this.BS.Width = 60;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.DisplayFormat.FormatString = "#,###";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGia.FieldName = "DON_GIA";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.OptionsColumn.FixedWidth = true;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 6;
            // 
            // TyleTT
            // 
            this.TyleTT.Caption = "Mức thanh toán";
            this.TyleTT.FieldName = "TYLE_TT";
            this.TyleTT.Name = "TyleTT";
            this.TyleTT.OptionsColumn.FixedWidth = true;
            this.TyleTT.Visible = true;
            this.TyleTT.VisibleIndex = 7;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.DisplayFormat.FormatString = "#,###";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ThanhTien.FieldName = "THANH_TIEN";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.FixedWidth = true;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày y lệnh:";
            // 
            // dateNgayYLenh
            // 
            this.dateNgayYLenh.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateNgayYLenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayYLenh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayYLenh.Location = new System.Drawing.Point(126, 8);
            this.dateNgayYLenh.Name = "dateNgayYLenh";
            this.dateNgayYLenh.Size = new System.Drawing.Size(242, 22);
            this.dateNgayYLenh.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(429, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Khoa:";
            // 
            // lookUpMaKhoa
            // 
            this.lookUpMaKhoa.Location = new System.Drawing.Point(486, 8);
            this.lookUpMaKhoa.Name = "lookUpMaKhoa";
            this.lookUpMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.lookUpMaKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMaKhoa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MA_KHOA", "Mã Khoa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN_KHOA", "Tên Khoa")});
            this.lookUpMaKhoa.Properties.NullText = "";
            this.lookUpMaKhoa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpMaKhoa.Size = new System.Drawing.Size(238, 22);
            this.lookUpMaKhoa.TabIndex = 21;
            // 
            // lookUpMaBS
            // 
            this.lookUpMaBS.Location = new System.Drawing.Point(804, 8);
            this.lookUpMaBS.Name = "lookUpMaBS";
            this.lookUpMaBS.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpMaBS.Properties.Appearance.Options.UseFont = true;
            this.lookUpMaBS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMaBS.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MA_NHANVIEN", "Mã Bác Sĩ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN_NHANVIEN", "Tên Bác Sĩ")});
            this.lookUpMaBS.Properties.DropDownRows = 14;
            this.lookUpMaBS.Properties.NullText = "";
            this.lookUpMaBS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpMaBS.Size = new System.Drawing.Size(221, 22);
            this.lookUpMaBS.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(751, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Bác sĩ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Loại giường:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số ngày:";
            // 
            // txtSoNgay
            // 
            this.txtSoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgay.Location = new System.Drawing.Point(640, 44);
            this.txtSoNgay.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtSoNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoNgay.Name = "txtSoNgay";
            this.txtSoNgay.Size = new System.Drawing.Size(84, 22);
            this.txtSoNgay.TabIndex = 31;
            this.txtSoNgay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgay_KeyPress);
            // 
            // btnChon
            // 
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.Location = new System.Drawing.Point(804, 42);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(74, 24);
            this.btnChon.TabIndex = 32;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "#";
            this.gridColumn1.ColumnEdit = this.btnXoa;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 20;
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(1054, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 50);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lookUpLoaiGiuong
            // 
            this.lookUpLoaiGiuong.EditValue = "";
            this.lookUpLoaiGiuong.Location = new System.Drawing.Point(126, 44);
            this.lookUpLoaiGiuong.Name = "lookUpLoaiGiuong";
            this.lookUpLoaiGiuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpLoaiGiuong.Properties.Appearance.Options.UseFont = true;
            this.lookUpLoaiGiuong.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpLoaiGiuong.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpLoaiGiuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpLoaiGiuong.Properties.View = this.searchLookUpEdit2View;
            this.lookUpLoaiGiuong.Size = new System.Drawing.Size(406, 22);
            this.lookUpLoaiGiuong.TabIndex = 35;
            this.lookUpLoaiGiuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lookUpLoaiGiuong_KeyPress);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchLookUpEdit2View.Appearance.FocusedRow.Options.UseBackColor = true;
            this.searchLookUpEdit2View.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchLookUpEdit2View.Appearance.SelectedRow.Options.UseBackColor = true;
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ma,
            this.Ten,
            this.DonGiaGuong});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // Ma
            // 
            this.Ma.Caption = "Mã";
            this.Ma.FieldName = "MA";
            this.Ma.Name = "Ma";
            this.Ma.OptionsColumn.AllowEdit = false;
            this.Ma.OptionsColumn.FixedWidth = true;
            this.Ma.Visible = true;
            this.Ma.VisibleIndex = 0;
            this.Ma.Width = 30;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên";
            this.Ten.FieldName = "TEN";
            this.Ten.Name = "Ten";
            this.Ten.OptionsColumn.AllowEdit = false;
            this.Ten.OptionsColumn.FixedWidth = true;
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 160;
            // 
            // DonGiaGuong
            // 
            this.DonGiaGuong.Caption = "Đơn Giá";
            this.DonGiaGuong.DisplayFormat.FormatString = "#,###";
            this.DonGiaGuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGiaGuong.FieldName = "DON_GIA";
            this.DonGiaGuong.Name = "DonGiaGuong";
            this.DonGiaGuong.OptionsColumn.AllowEdit = false;
            this.DonGiaGuong.OptionsColumn.FixedWidth = true;
            this.DonGiaGuong.Visible = true;
            this.DonGiaGuong.VisibleIndex = 2;
            this.DonGiaGuong.Width = 40;
            // 
            // FrmTienGiuongChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 481);
            this.ControlBox = false;
            this.Controls.Add(this.lookUpLoaiGiuong);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtSoNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpMaBS);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lookUpMaKhoa);
            this.Controls.Add(this.dateNgayYLenh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTienGiuongChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiền Giường";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTienGiuongChiTiet_FormClosing);
            this.Load += new System.EventHandler(this.FrmTienGiuongChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaBS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpLoaiGiuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNgayYLenh;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.LookUpEdit lookUpMaKhoa;
        private DevExpress.XtraEditors.LookUpEdit lookUpMaBS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtSoNgay;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraGrid.Columns.GridColumn NgayYL;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiGiuong;
        private DevExpress.XtraGrid.Columns.GridColumn SoNgay;
        private DevExpress.XtraGrid.Columns.GridColumn Khoa;
        private DevExpress.XtraGrid.Columns.GridColumn BS;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn TyleTT;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SearchLookUpEdit lookUpLoaiGiuong;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn Ma;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaGuong;
    }
}