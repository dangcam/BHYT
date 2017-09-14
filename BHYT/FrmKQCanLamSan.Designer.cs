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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gridControlDVKT = new DevExpress.XtraGrid.GridControl();
            this.gridViewDVKT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NgayYLenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoaMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KetQua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaDVKT = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDVKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDVKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaDVKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(107, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(240, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // gridControlDVKT
            // 
            this.gridControlDVKT.Location = new System.Drawing.Point(12, 45);
            this.gridControlDVKT.MainView = this.gridViewDVKT;
            this.gridControlDVKT.Name = "gridControlDVKT";
            this.gridControlDVKT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoaDVKT,
            this.repositoryItemSpinEdit1});
            this.gridControlDVKT.Size = new System.Drawing.Size(816, 279);
            this.gridControlDVKT.TabIndex = 49;
            this.gridControlDVKT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDVKT});
            // 
            // gridViewDVKT
            // 
            this.gridViewDVKT.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridViewDVKT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewDVKT.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridViewDVKT.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewDVKT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NgayYLenh,
            this.TenDichVu,
            this.KhoaMa,
            this.BacSi,
            this.KetQua,
            this.MaNhom});
            this.gridViewDVKT.GridControl = this.gridControlDVKT;
            this.gridViewDVKT.Name = "gridViewDVKT";
            this.gridViewDVKT.OptionsView.ShowGroupPanel = false;
            // 
            // NgayYLenh
            // 
            this.NgayYLenh.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayYLenh.AppearanceCell.Options.UseFont = true;
            this.NgayYLenh.Caption = "Ngày y lệnh";
            this.NgayYLenh.FieldName = "NGAY_YL";
            this.NgayYLenh.Name = "NgayYLenh";
            this.NgayYLenh.OptionsColumn.AllowEdit = false;
            this.NgayYLenh.Visible = true;
            this.NgayYLenh.VisibleIndex = 0;
            // 
            // TenDichVu
            // 
            this.TenDichVu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDichVu.AppearanceCell.Options.UseFont = true;
            this.TenDichVu.Caption = "Tên Dịch Vụ";
            this.TenDichVu.FieldName = "TEN_DICH_VU";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.OptionsColumn.AllowEdit = false;
            this.TenDichVu.Visible = true;
            this.TenDichVu.VisibleIndex = 1;
            this.TenDichVu.Width = 280;
            // 
            // KhoaMa
            // 
            this.KhoaMa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoaMa.AppearanceCell.Options.UseFont = true;
            this.KhoaMa.Caption = "Khoa";
            this.KhoaMa.FieldName = "MA_KHOA";
            this.KhoaMa.Name = "KhoaMa";
            this.KhoaMa.OptionsColumn.AllowEdit = false;
            this.KhoaMa.Visible = true;
            this.KhoaMa.VisibleIndex = 2;
            // 
            // BacSi
            // 
            this.BacSi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacSi.AppearanceCell.Options.UseFont = true;
            this.BacSi.Caption = "Bác sĩ";
            this.BacSi.FieldName = "MA_BAC_SI";
            this.BacSi.Name = "BacSi";
            this.BacSi.Visible = true;
            this.BacSi.VisibleIndex = 3;
            // 
            // KetQua
            // 
            this.KetQua.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetQua.AppearanceCell.Options.UseFont = true;
            this.KetQua.Caption = "Kết quả";
            this.KetQua.FieldName = "KET_QUA";
            this.KetQua.Name = "KetQua";
            this.KetQua.Visible = true;
            this.KetQua.VisibleIndex = 4;
            this.KetQua.Width = 230;
            // 
            // MaNhom
            // 
            this.MaNhom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhom.AppearanceCell.Options.UseFont = true;
            this.MaNhom.Caption = "Mã Nhóm";
            this.MaNhom.FieldName = "MA_NHOM";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.OptionsColumn.AllowEdit = false;
            this.MaNhom.Visible = true;
            this.MaNhom.VisibleIndex = 5;
            this.MaNhom.Width = 60;
            // 
            // btnXoaDVKT
            // 
            this.btnXoaDVKT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoaDVKT.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnXoaDVKT.Name = "btnXoaDVKT";
            this.btnXoaDVKT.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit1.MaxLength = 3;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(753, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 50;
            this.btnLuu.Text = "Lưu kết quả";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmKQCanLamSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 336);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gridControlDVKT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKQCanLamSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Cận Lâm Sàn";
            this.Load += new System.EventHandler(this.FrmKQCanLamSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDVKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDVKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaDVKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private DevExpress.XtraGrid.GridControl gridControlDVKT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDVKT;
        private DevExpress.XtraGrid.Columns.GridColumn NgayYLenh;
        private DevExpress.XtraGrid.Columns.GridColumn TenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn KhoaMa;
        private DevExpress.XtraGrid.Columns.GridColumn BacSi;
        private DevExpress.XtraGrid.Columns.GridColumn KetQua;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhom;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoaDVKT;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}