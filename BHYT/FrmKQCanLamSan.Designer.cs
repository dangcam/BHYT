namespace BHYT
{
    partial class FrmKQCanLamSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKQCanLamSan));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuanDoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYeuCau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCanLanSan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lookUpDVKT = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_NHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DVKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_DVKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DON_GIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DON_VI_TINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lookUpBacSi = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDVKT = new DevExpress.XtraGrid.GridControl();
            this.gridViewDVKT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaDVKT = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.NgayYLenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongDVKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoaMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGiaDVKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Muc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KetQua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.lookUpMaKhoa = new DevExpress.XtraEditors.LookUpEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.MaNhomCLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_DICH_VU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDVKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBacSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDVKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDVKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaDVKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaKhoa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(79, 11);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(186, 22);
            this.txtHoTen.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageUri.Uri = "Save;Size16x16";
            this.btnLuu.Location = new System.Drawing.Point(897, 41);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu KQ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chuẩn đoán:";
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuanDoan.Location = new System.Drawing.Point(107, 41);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.ReadOnly = true;
            this.txtChuanDoan.Size = new System.Drawing.Size(212, 22);
            this.txtChuanDoan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yêu cầu kiểm tra:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtYeuCau
            // 
            this.txtYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYeuCau.Location = new System.Drawing.Point(79, 71);
            this.txtYeuCau.Multiline = true;
            this.txtYeuCau.Name = "txtYeuCau";
            this.txtYeuCau.ReadOnly = true;
            this.txtYeuCau.Size = new System.Drawing.Size(240, 44);
            this.txtYeuCau.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "CLS:";
            // 
            // txtCanLanSan
            // 
            this.txtCanLanSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanLanSan.Location = new System.Drawing.Point(318, 11);
            this.txtCanLanSan.Name = "txtCanLanSan";
            this.txtCanLanSan.ReadOnly = true;
            this.txtCanLanSan.Size = new System.Drawing.Size(195, 22);
            this.txtCanLanSan.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên DVKT:";
            // 
            // lookUpDVKT
            // 
            this.lookUpDVKT.Location = new System.Drawing.Point(414, 41);
            this.lookUpDVKT.Name = "lookUpDVKT";
            this.lookUpDVKT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpDVKT.Properties.Appearance.Options.UseFont = true;
            this.lookUpDVKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpDVKT.Properties.NullText = "";
            this.lookUpDVKT.Properties.PopupFormSize = new System.Drawing.Size(600, 400);
            this.lookUpDVKT.Properties.View = this.searchLookUpEdit1View;
            this.lookUpDVKT.Size = new System.Drawing.Size(298, 22);
            this.lookUpDVKT.TabIndex = 6;
            this.lookUpDVKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lookUpDVKT_KeyPress);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_NHOM,
            this.MA_DVKT,
            this.TEN_DVKT,
            this.DON_GIA,
            this.DON_VI_TINH,
            this.CLS});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsFind.AlwaysVisible = true;
            this.searchLookUpEdit1View.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MA_NHOM
            // 
            this.MA_NHOM.Caption = "MA_NHOM";
            this.MA_NHOM.FieldName = "MA_NHOM";
            this.MA_NHOM.Name = "MA_NHOM";
            // 
            // MA_DVKT
            // 
            this.MA_DVKT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MA_DVKT.AppearanceCell.Options.UseFont = true;
            this.MA_DVKT.Caption = "Mã nhóm";
            this.MA_DVKT.FieldName = "MA_DVKT";
            this.MA_DVKT.Name = "MA_DVKT";
            this.MA_DVKT.OptionsColumn.AllowEdit = false;
            this.MA_DVKT.Visible = true;
            this.MA_DVKT.VisibleIndex = 0;
            this.MA_DVKT.Width = 70;
            // 
            // TEN_DVKT
            // 
            this.TEN_DVKT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEN_DVKT.AppearanceCell.Options.UseFont = true;
            this.TEN_DVKT.Caption = "Tên DVKT";
            this.TEN_DVKT.FieldName = "TEN_DVKT";
            this.TEN_DVKT.Name = "TEN_DVKT";
            this.TEN_DVKT.OptionsColumn.AllowEdit = false;
            this.TEN_DVKT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.TEN_DVKT.Visible = true;
            this.TEN_DVKT.VisibleIndex = 1;
            this.TEN_DVKT.Width = 200;
            // 
            // DON_GIA
            // 
            this.DON_GIA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DON_GIA.AppearanceCell.Options.UseFont = true;
            this.DON_GIA.Caption = "Đơn giá";
            this.DON_GIA.DisplayFormat.FormatString = "#,###";
            this.DON_GIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DON_GIA.FieldName = "DON_GIA";
            this.DON_GIA.Name = "DON_GIA";
            this.DON_GIA.OptionsColumn.AllowEdit = false;
            this.DON_GIA.Visible = true;
            this.DON_GIA.VisibleIndex = 2;
            this.DON_GIA.Width = 59;
            // 
            // DON_VI_TINH
            // 
            this.DON_VI_TINH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DON_VI_TINH.AppearanceCell.Options.UseFont = true;
            this.DON_VI_TINH.Caption = "Đơn Vị";
            this.DON_VI_TINH.FieldName = "DON_VI_TINH";
            this.DON_VI_TINH.Name = "DON_VI_TINH";
            this.DON_VI_TINH.OptionsColumn.AllowEdit = false;
            this.DON_VI_TINH.Visible = true;
            this.DON_VI_TINH.VisibleIndex = 3;
            this.DON_VI_TINH.Width = 55;
            // 
            // CLS
            // 
            this.CLS.Caption = "CLS";
            this.CLS.FieldName = "CLS";
            this.CLS.Name = "CLS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bác sĩ:";
            // 
            // lookUpBacSi
            // 
            this.lookUpBacSi.Location = new System.Drawing.Point(773, 10);
            this.lookUpBacSi.Name = "lookUpBacSi";
            this.lookUpBacSi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpBacSi.Properties.Appearance.Options.UseFont = true;
            this.lookUpBacSi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBacSi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MA_NHANVIEN", "Mã BS"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN_NHANVIEN", "Tên BS")});
            this.lookUpBacSi.Properties.NullText = "";
            this.lookUpBacSi.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lookUpBacSi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpBacSi.Size = new System.Drawing.Size(199, 22);
            this.lookUpBacSi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(719, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(789, 41);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Size = new System.Drawing.Size(84, 22);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // btnChon
            // 
            this.btnChon.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Appearance.Options.UseFont = true;
            this.btnChon.ImageUri.Uri = "Add;Size16x16";
            this.btnChon.Location = new System.Drawing.Point(789, 71);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(84, 23);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // gridControlDVKT
            // 
            this.gridControlDVKT.Location = new System.Drawing.Point(5, 126);
            this.gridControlDVKT.MainView = this.gridViewDVKT;
            this.gridControlDVKT.Name = "gridControlDVKT";
            this.gridControlDVKT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoaDVKT});
            this.gridControlDVKT.Size = new System.Drawing.Size(975, 281);
            this.gridControlDVKT.TabIndex = 65;
            this.gridControlDVKT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDVKT});
            // 
            // gridViewDVKT
            // 
            this.gridViewDVKT.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewDVKT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDVKT.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewDVKT.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDVKT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.btnXoa,
            this.NgayYLenh,
            this.TenDichVu,
            this.SoLuongDVKT,
            this.KhoaMa,
            this.BacSi,
            this.DonGiaDVKT,
            this.Muc,
            this.Tien,
            this.MaNhom,
            this.KetQua,
            this.MaNhomCLS,
            this.MA_DICH_VU});
            this.gridViewDVKT.GridControl = this.gridControlDVKT;
            this.gridViewDVKT.Name = "gridViewDVKT";
            this.gridViewDVKT.OptionsView.ShowGroupPanel = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "#";
            this.btnXoa.ColumnEdit = this.btnXoaDVKT;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OptionsColumn.FixedWidth = true;
            this.btnXoa.Visible = true;
            this.btnXoa.VisibleIndex = 0;
            this.btnXoa.Width = 20;
            // 
            // btnXoaDVKT
            // 
            this.btnXoaDVKT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoaDVKT.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnXoaDVKT.Name = "btnXoaDVKT";
            this.btnXoaDVKT.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoaDVKT.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoaDVKT_ButtonClick);
            // 
            // NgayYLenh
            // 
            this.NgayYLenh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayYLenh.AppearanceCell.Options.UseFont = true;
            this.NgayYLenh.Caption = "Ngày y lệnh";
            this.NgayYLenh.FieldName = "NGAY_YL";
            this.NgayYLenh.Name = "NgayYLenh";
            this.NgayYLenh.OptionsColumn.FixedWidth = true;
            this.NgayYLenh.Width = 50;
            // 
            // TenDichVu
            // 
            this.TenDichVu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDichVu.AppearanceCell.Options.UseFont = true;
            this.TenDichVu.Caption = "Tên Dịch Vụ";
            this.TenDichVu.FieldName = "TEN_DICH_VU";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.OptionsColumn.AllowEdit = false;
            this.TenDichVu.Visible = true;
            this.TenDichVu.VisibleIndex = 1;
            this.TenDichVu.Width = 282;
            // 
            // SoLuongDVKT
            // 
            this.SoLuongDVKT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongDVKT.AppearanceCell.Options.UseFont = true;
            this.SoLuongDVKT.Caption = "Số lượng";
            this.SoLuongDVKT.FieldName = "SO_LUONG";
            this.SoLuongDVKT.Name = "SoLuongDVKT";
            this.SoLuongDVKT.OptionsColumn.AllowEdit = false;
            this.SoLuongDVKT.Visible = true;
            this.SoLuongDVKT.VisibleIndex = 2;
            this.SoLuongDVKT.Width = 56;
            // 
            // KhoaMa
            // 
            this.KhoaMa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoaMa.AppearanceCell.Options.UseFont = true;
            this.KhoaMa.Caption = "Khoa";
            this.KhoaMa.FieldName = "MA_KHOA";
            this.KhoaMa.Name = "KhoaMa";
            this.KhoaMa.OptionsColumn.AllowEdit = false;
            this.KhoaMa.Width = 56;
            // 
            // BacSi
            // 
            this.BacSi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacSi.AppearanceCell.Options.UseFont = true;
            this.BacSi.Caption = "Bác sĩ";
            this.BacSi.FieldName = "MA_BAC_SI";
            this.BacSi.Name = "BacSi";
            this.BacSi.OptionsColumn.AllowEdit = false;
            this.BacSi.Width = 65;
            // 
            // DonGiaDVKT
            // 
            this.DonGiaDVKT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonGiaDVKT.AppearanceCell.Options.UseFont = true;
            this.DonGiaDVKT.Caption = "Đơn giá";
            this.DonGiaDVKT.DisplayFormat.FormatString = "#,###";
            this.DonGiaDVKT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGiaDVKT.FieldName = "DON_GIA";
            this.DonGiaDVKT.Name = "DonGiaDVKT";
            this.DonGiaDVKT.OptionsColumn.AllowEdit = false;
            this.DonGiaDVKT.Visible = true;
            this.DonGiaDVKT.VisibleIndex = 3;
            this.DonGiaDVKT.Width = 64;
            // 
            // Muc
            // 
            this.Muc.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muc.AppearanceCell.Options.UseFont = true;
            this.Muc.Caption = "Mức thanh toán";
            this.Muc.FieldName = "TYLE_TT";
            this.Muc.Name = "Muc";
            this.Muc.OptionsColumn.FixedWidth = true;
            this.Muc.Width = 50;
            // 
            // Tien
            // 
            this.Tien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tien.AppearanceCell.Options.UseFont = true;
            this.Tien.Caption = "Thành tiền";
            this.Tien.DisplayFormat.FormatString = "#,###";
            this.Tien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Tien.FieldName = "THANH_TIEN";
            this.Tien.Name = "Tien";
            this.Tien.OptionsColumn.AllowEdit = false;
            this.Tien.Visible = true;
            this.Tien.VisibleIndex = 4;
            this.Tien.Width = 69;
            // 
            // MaNhom
            // 
            this.MaNhom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhom.AppearanceCell.Options.UseFont = true;
            this.MaNhom.Caption = "Mã Nhóm";
            this.MaNhom.FieldName = "MA_NHOM";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.OptionsColumn.AllowEdit = false;
            this.MaNhom.OptionsColumn.FixedWidth = true;
            this.MaNhom.Width = 30;
            // 
            // KetQua
            // 
            this.KetQua.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.AppearanceCell.Options.UseFont = true;
            this.KetQua.Caption = "Kết quả";
            this.KetQua.FieldName = "KET_QUA";
            this.KetQua.Name = "KetQua";
            this.KetQua.Visible = true;
            this.KetQua.VisibleIndex = 5;
            this.KetQua.Width = 345;
            // 
            // btnIn
            // 
            this.btnIn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Appearance.Options.UseFont = true;
            this.btnIn.ImageUri.Uri = "Print;Size16x16";
            this.btnIn.Location = new System.Drawing.Point(897, 69);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 47);
            this.btnIn.TabIndex = 10;
            this.btnIn.Text = "Lưu & In";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(524, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 72;
            this.label12.Text = "Khoa:";
            // 
            // lookUpMaKhoa
            // 
            this.lookUpMaKhoa.Location = new System.Drawing.Point(568, 10);
            this.lookUpMaKhoa.Name = "lookUpMaKhoa";
            this.lookUpMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.lookUpMaKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMaKhoa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MA_KHOA", "Mã Khoa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN_KHOA", "Tên Khoa")});
            this.lookUpMaKhoa.Properties.NullText = "";
            this.lookUpMaKhoa.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lookUpMaKhoa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpMaKhoa.Size = new System.Drawing.Size(144, 22);
            this.lookUpMaKhoa.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(329, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kết quả:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaNhomCLS
            // 
            this.MaNhomCLS.Caption = "MaNhom";
            this.MaNhomCLS.FieldName = "MaNhom";
            this.MaNhomCLS.Name = "MaNhomCLS";
            // 
            // MA_DICH_VU
            // 
            this.MA_DICH_VU.Caption = "MA_DICH_VU";
            this.MA_DICH_VU.FieldName = "MA_DICH_VU";
            this.MA_DICH_VU.Name = "MA_DICH_VU";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(414, 69);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(358, 46);
            this.txtKetQua.TabIndex = 73;
            this.txtKetQua.Enter += new System.EventHandler(this.txtKetQua_Enter);
            this.txtKetQua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKetQua_KeyPress);
            // 
            // FrmKQCanLamSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lookUpMaKhoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.gridControlDVKT);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lookUpBacSi);
            this.Controls.Add(this.txtYeuCau);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtCanLanSan);
            this.Controls.Add(this.txtChuanDoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookUpDVKT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKQCanLamSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Cận Lâm Sàn";
            this.Load += new System.EventHandler(this.FrmKQCanLamSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDVKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBacSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDVKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDVKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaDVKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMaKhoa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuanDoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeuCau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCanLanSan;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SearchLookUpEdit lookUpDVKT;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit lookUpBacSi;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraGrid.GridControl gridControlDVKT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDVKT;
        private DevExpress.XtraGrid.Columns.GridColumn btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoaDVKT;
        private DevExpress.XtraGrid.Columns.GridColumn NgayYLenh;
        private DevExpress.XtraGrid.Columns.GridColumn TenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongDVKT;
        private DevExpress.XtraGrid.Columns.GridColumn KhoaMa;
        private DevExpress.XtraGrid.Columns.GridColumn BacSi;
        private DevExpress.XtraGrid.Columns.GridColumn DonGiaDVKT;
        private DevExpress.XtraGrid.Columns.GridColumn Muc;
        private DevExpress.XtraGrid.Columns.GridColumn Tien;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn KetQua;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NHOM;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DVKT;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_DVKT;
        private DevExpress.XtraGrid.Columns.GridColumn DON_GIA;
        private DevExpress.XtraGrid.Columns.GridColumn DON_VI_TINH;
        private DevExpress.XtraGrid.Columns.GridColumn CLS;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.LookUpEdit lookUpMaKhoa;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhomCLS;
        private DevExpress.XtraGrid.Columns.GridColumn MA_DICH_VU;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}