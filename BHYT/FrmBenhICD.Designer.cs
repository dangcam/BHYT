namespace BHYT
{
    partial class FrmBenhICD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBenhICD));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bntNhapExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Location = new System.Drawing.Point(0, 54);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(897, 437);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaBenh,
            this.TenBenh,
            this.MaLoai,
            this.MaNhom});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Tìm kiếm mã bệnh";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // MaBenh
            // 
            this.MaBenh.Caption = "Mã Bệnh";
            this.MaBenh.FieldName = "MA_BENH";
            this.MaBenh.Name = "MaBenh";
            this.MaBenh.OptionsColumn.AllowEdit = false;
            this.MaBenh.Visible = true;
            this.MaBenh.VisibleIndex = 0;
            this.MaBenh.Width = 80;
            // 
            // TenBenh
            // 
            this.TenBenh.Caption = "Tên Bệnh";
            this.TenBenh.FieldName = "TEN_BENH";
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.OptionsColumn.AllowEdit = false;
            this.TenBenh.Visible = true;
            this.TenBenh.VisibleIndex = 1;
            this.TenBenh.Width = 300;
            // 
            // MaLoai
            // 
            this.MaLoai.Caption = "Mã Loại";
            this.MaLoai.FieldName = "MA_LOAI";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.OptionsColumn.AllowEdit = false;
            this.MaLoai.Visible = true;
            this.MaLoai.VisibleIndex = 2;
            this.MaLoai.Width = 70;
            // 
            // MaNhom
            // 
            this.MaNhom.Caption = "Mã Nhóm";
            this.MaNhom.FieldName = "MA_NHOM";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.OptionsColumn.AllowEdit = false;
            this.MaNhom.Visible = true;
            this.MaNhom.VisibleIndex = 3;
            this.MaNhom.Width = 70;
            // 
            // bntNhapExcel
            // 
            this.bntNhapExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhapExcel.Appearance.Options.UseFont = true;
            this.bntNhapExcel.Image = ((System.Drawing.Image)(resources.GetObject("bntNhapExcel.Image")));
            this.bntNhapExcel.Location = new System.Drawing.Point(779, 12);
            this.bntNhapExcel.Name = "bntNhapExcel";
            this.bntNhapExcel.Size = new System.Drawing.Size(106, 33);
            this.bntNhapExcel.TabIndex = 2;
            this.bntNhapExcel.Text = "Nhập Excel";
            this.bntNhapExcel.Click += new System.EventHandler(this.bntNhapExcel_Click);
            // 
            // FrmBenhICD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 491);
            this.Controls.Add(this.bntNhapExcel);
            this.Controls.Add(this.gridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBenhICD";
            this.Text = "Danh mục bệnh ICD";
            this.Load += new System.EventHandler(this.FrmBenhICD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaBenh;
        private DevExpress.XtraGrid.Columns.GridColumn TenBenh;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhom;
        private DevExpress.XtraEditors.SimpleButton bntNhapExcel;
    }
}