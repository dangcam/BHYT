namespace BHYT
{
    partial class FrmChiDinhCLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiDinhCLS));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChuanDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YeuCau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpBacSi = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBacSi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(67, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(307, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 40);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(860, 259);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLK,
            this.MaNhom,
            this.Chon,
            this.TenNhom,
            this.ChuanDoan,
            this.YeuCau});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // MaLK
            // 
            this.MaLK.Caption = "MaLK";
            this.MaLK.FieldName = "MA_LK";
            this.MaLK.Name = "MaLK";
            // 
            // MaNhom
            // 
            this.MaNhom.Caption = "MaNhom";
            this.MaNhom.FieldName = "MaNhom";
            this.MaNhom.Name = "MaNhom";
            // 
            // Chon
            // 
            this.Chon.Caption = "Chọn";
            this.Chon.FieldName = "Chon";
            this.Chon.Name = "Chon";
            this.Chon.OptionsColumn.FixedWidth = true;
            this.Chon.Visible = true;
            this.Chon.VisibleIndex = 0;
            this.Chon.Width = 40;
            // 
            // TenNhom
            // 
            this.TenNhom.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhom.AppearanceCell.Options.UseFont = true;
            this.TenNhom.Caption = "Cận lâm sàn";
            this.TenNhom.FieldName = "TenNhom";
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.OptionsColumn.AllowEdit = false;
            this.TenNhom.Visible = true;
            this.TenNhom.VisibleIndex = 1;
            this.TenNhom.Width = 200;
            // 
            // ChuanDoan
            // 
            this.ChuanDoan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChuanDoan.AppearanceCell.Options.UseFont = true;
            this.ChuanDoan.Caption = "Chuẩn đoán";
            this.ChuanDoan.FieldName = "ChuanDoan";
            this.ChuanDoan.Name = "ChuanDoan";
            this.ChuanDoan.Visible = true;
            this.ChuanDoan.VisibleIndex = 2;
            this.ChuanDoan.Width = 200;
            // 
            // YeuCau
            // 
            this.YeuCau.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeuCau.AppearanceCell.Options.UseFont = true;
            this.YeuCau.Caption = "Yêu cầu";
            this.YeuCau.FieldName = "YeuCau";
            this.YeuCau.Name = "YeuCau";
            this.YeuCau.Visible = true;
            this.YeuCau.VisibleIndex = 3;
            this.YeuCau.Width = 305;
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(796, 11);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In phiếu";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(716, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(57, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lookUpBacSi
            // 
            this.lookUpBacSi.Location = new System.Drawing.Point(444, 12);
            this.lookUpBacSi.Name = "lookUpBacSi";
            this.lookUpBacSi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpBacSi.Properties.Appearance.Options.UseFont = true;
            this.lookUpBacSi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBacSi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MA_NHANVIEN", "Mã BS"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN_NHANVIEN", 60, "Tên BS")});
            this.lookUpBacSi.Properties.NullText = "";
            this.lookUpBacSi.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lookUpBacSi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpBacSi.Size = new System.Drawing.Size(249, 22);
            this.lookUpBacSi.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Bác sĩ:";
            // 
            // FrmChiDinhCLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 311);
            this.Controls.Add(this.lookUpBacSi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChiDinhCLS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉ định cận lâm sàn";
            this.Load += new System.EventHandler(this.FrmChiDinhCLS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBacSi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaLK;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn Chon;
        private DevExpress.XtraGrid.Columns.GridColumn TenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn ChuanDoan;
        private DevExpress.XtraGrid.Columns.GridColumn YeuCau;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LookUpEdit lookUpBacSi;
        private System.Windows.Forms.Label label6;
    }
}