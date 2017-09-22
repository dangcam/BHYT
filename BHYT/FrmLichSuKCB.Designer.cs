namespace BHYT
{
    partial class FrmLichSuKCB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLichSuKCB));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.maHoSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maCSKCB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tuNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.denNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kqDieuTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btneditChiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin:";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.ForeColor = System.Drawing.Color.Blue;
            this.lblThongTin.Location = new System.Drawing.Point(102, 9);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(167, 19);
            this.lblThongTin.TabIndex = 1;
            this.lblThongTin.Text = "Thông tin thẻ chính xác.";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 40);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit,
            this.btneditChiTiet});
            this.gridControl.Size = new System.Drawing.Size(910, 269);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.maHoSo,
            this.maCSKCB,
            this.tuNgay,
            this.denNgay,
            this.tenBenh,
            this.tinhTrang,
            this.kqDieuTri,
            this.btnChiTiet});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView_CustomColumnDisplayText);
            // 
            // maHoSo
            // 
            this.maHoSo.Caption = "Mã hồ sơ";
            this.maHoSo.FieldName = "maHoSo";
            this.maHoSo.Name = "maHoSo";
            this.maHoSo.OptionsColumn.AllowEdit = false;
            // 
            // maCSKCB
            // 
            this.maCSKCB.Caption = "CSKCB";
            this.maCSKCB.ColumnEdit = this.repositoryItemLookUpEdit;
            this.maCSKCB.FieldName = "maCSKCB";
            this.maCSKCB.Name = "maCSKCB";
            this.maCSKCB.OptionsColumn.AllowEdit = false;
            this.maCSKCB.Visible = true;
            this.maCSKCB.VisibleIndex = 0;
            this.maCSKCB.Width = 210;
            // 
            // repositoryItemLookUpEdit
            // 
            this.repositoryItemLookUpEdit.AutoHeight = false;
            this.repositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit";
            this.repositoryItemLookUpEdit.NullText = "";
            // 
            // tuNgay
            // 
            this.tuNgay.Caption = "Từ ngày";
            this.tuNgay.FieldName = "tuNgay";
            this.tuNgay.Name = "tuNgay";
            this.tuNgay.OptionsColumn.AllowEdit = false;
            this.tuNgay.Visible = true;
            this.tuNgay.VisibleIndex = 1;
            // 
            // denNgay
            // 
            this.denNgay.Caption = "Đến ngày";
            this.denNgay.FieldName = "denNgay";
            this.denNgay.Name = "denNgay";
            this.denNgay.OptionsColumn.AllowEdit = false;
            this.denNgay.Visible = true;
            this.denNgay.VisibleIndex = 2;
            this.denNgay.Width = 68;
            // 
            // tenBenh
            // 
            this.tenBenh.Caption = "Tên bệnh";
            this.tenBenh.FieldName = "tenBenh";
            this.tenBenh.Name = "tenBenh";
            this.tenBenh.OptionsColumn.AllowEdit = false;
            this.tenBenh.Visible = true;
            this.tenBenh.VisibleIndex = 3;
            this.tenBenh.Width = 369;
            // 
            // tinhTrang
            // 
            this.tinhTrang.Caption = "Tình trạng";
            this.tinhTrang.FieldName = "tinhTrang";
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.OptionsColumn.AllowEdit = false;
            this.tinhTrang.Visible = true;
            this.tinhTrang.VisibleIndex = 4;
            this.tinhTrang.Width = 73;
            // 
            // kqDieuTri
            // 
            this.kqDieuTri.Caption = "Kết quả";
            this.kqDieuTri.FieldName = "kqDieuTri";
            this.kqDieuTri.Name = "kqDieuTri";
            this.kqDieuTri.OptionsColumn.AllowEdit = false;
            this.kqDieuTri.Visible = true;
            this.kqDieuTri.VisibleIndex = 5;
            this.kqDieuTri.Width = 63;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Caption = "#";
            this.btnChiTiet.ColumnEdit = this.btneditChiTiet;
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.OptionsColumn.FixedWidth = true;
            this.btnChiTiet.Visible = true;
            this.btnChiTiet.VisibleIndex = 6;
            this.btnChiTiet.Width = 34;
            // 
            // btneditChiTiet
            // 
            this.btneditChiTiet.AutoHeight = false;
            this.btneditChiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btneditChiTiet.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btneditChiTiet.ContextImage = ((System.Drawing.Image)(resources.GetObject("btneditChiTiet.ContextImage")));
            this.btneditChiTiet.Name = "btneditChiTiet";
            this.btneditChiTiet.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btneditChiTiet.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btneditChiTiet_ButtonClick);
            // 
            // FrmLichSuKCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 321);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLichSuKCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử Khám chữa bệnh";
            this.Load += new System.EventHandler(this.FrmLichSuKCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThongTin;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn maHoSo;
        private DevExpress.XtraGrid.Columns.GridColumn maCSKCB;
        private DevExpress.XtraGrid.Columns.GridColumn tuNgay;
        private DevExpress.XtraGrid.Columns.GridColumn denNgay;
        private DevExpress.XtraGrid.Columns.GridColumn tenBenh;
        private DevExpress.XtraGrid.Columns.GridColumn tinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn kqDieuTri;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn btnChiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btneditChiTiet;
    }
}