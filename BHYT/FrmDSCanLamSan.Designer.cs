﻿namespace BHYT
{
    partial class FrmDSCanLamSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDSCanLamSan));
            this.btnTim = new System.Windows.Forms.Button();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateDen = new System.Windows.Forms.DateTimePicker();
            this.dateTu = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_BN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_THE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO_TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAM_SINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY_VAO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KET_QUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MA_LK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(744, 18);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 25);
            this.btnTim.TabIndex = 91;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa Cận lâm sàn",
            "Đã Cận lâm sàn"});
            this.cbTinhTrang.Location = new System.Drawing.Point(149, 19);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(157, 24);
            this.cbTinhTrang.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 89;
            this.label11.Text = "Tình trạng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(555, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 88;
            this.label13.Text = "đến";
            // 
            // dateDen
            // 
            this.dateDen.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDen.CustomFormat = "dd/MM/yyyy";
            this.dateDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDen.Location = new System.Drawing.Point(592, 19);
            this.dateDen.Name = "dateDen";
            this.dateDen.Size = new System.Drawing.Size(129, 22);
            this.dateDen.TabIndex = 85;
            // 
            // dateTu
            // 
            this.dateTu.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTu.CustomFormat = "dd/MM/yyyy";
            this.dateTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTu.Location = new System.Drawing.Point(413, 19);
            this.dateTu.Name = "dateTu";
            this.dateTu.Size = new System.Drawing.Size(129, 22);
            this.dateTu.TabIndex = 86;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(325, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 16);
            this.label25.TabIndex = 87;
            this.label25.Text = "Ngày Y lệnh:";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 61);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(897, 383);
            this.gridControl.TabIndex = 92;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MA_BN,
            this.MA_THE,
            this.HO_TEN,
            this.NAM_SINH,
            this.NGAY_VAO,
            this.KET_QUA,
            this.MA_LK});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // STT
            // 
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 50;
            // 
            // MA_BN
            // 
            this.MA_BN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MA_BN.AppearanceCell.Options.UseFont = true;
            this.MA_BN.Caption = "Mã BN";
            this.MA_BN.FieldName = "MA_BN";
            this.MA_BN.Name = "MA_BN";
            this.MA_BN.OptionsColumn.AllowEdit = false;
            this.MA_BN.Visible = true;
            this.MA_BN.VisibleIndex = 1;
            this.MA_BN.Width = 100;
            // 
            // MA_THE
            // 
            this.MA_THE.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MA_THE.AppearanceCell.Options.UseFont = true;
            this.MA_THE.AppearanceCell.Options.UseTextOptions = true;
            this.MA_THE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MA_THE.Caption = "Mã Thẻ";
            this.MA_THE.FieldName = "MA_THE";
            this.MA_THE.Name = "MA_THE";
            this.MA_THE.OptionsColumn.AllowEdit = false;
            this.MA_THE.Visible = true;
            this.MA_THE.VisibleIndex = 2;
            this.MA_THE.Width = 140;
            // 
            // HO_TEN
            // 
            this.HO_TEN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HO_TEN.AppearanceCell.Options.UseFont = true;
            this.HO_TEN.Caption = "Họ Tên";
            this.HO_TEN.FieldName = "HO_TEN";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.OptionsColumn.AllowEdit = false;
            this.HO_TEN.Visible = true;
            this.HO_TEN.VisibleIndex = 3;
            this.HO_TEN.Width = 180;
            // 
            // NAM_SINH
            // 
            this.NAM_SINH.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAM_SINH.AppearanceCell.Options.UseFont = true;
            this.NAM_SINH.Caption = "Năm Sinh";
            this.NAM_SINH.FieldName = "NAM_SINH";
            this.NAM_SINH.Name = "NAM_SINH";
            this.NAM_SINH.OptionsColumn.AllowEdit = false;
            this.NAM_SINH.Visible = true;
            this.NAM_SINH.VisibleIndex = 4;
            this.NAM_SINH.Width = 60;
            // 
            // NGAY_VAO
            // 
            this.NGAY_VAO.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGAY_VAO.AppearanceCell.Options.UseFont = true;
            this.NGAY_VAO.Caption = "Ngày Vào";
            this.NGAY_VAO.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NGAY_VAO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NGAY_VAO.FieldName = "NGAY_VAO";
            this.NGAY_VAO.Name = "NGAY_VAO";
            this.NGAY_VAO.OptionsColumn.AllowEdit = false;
            this.NGAY_VAO.Visible = true;
            this.NGAY_VAO.VisibleIndex = 5;
            this.NGAY_VAO.Width = 80;
            // 
            // KET_QUA
            // 
            this.KET_QUA.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KET_QUA.AppearanceCell.Options.UseFont = true;
            this.KET_QUA.Caption = "Kết Quả Cận Lâm Sàn";
            this.KET_QUA.FieldName = "KET_QUA";
            this.KET_QUA.Name = "KET_QUA";
            this.KET_QUA.OptionsColumn.AllowEdit = false;
            this.KET_QUA.Visible = true;
            this.KET_QUA.VisibleIndex = 6;
            this.KET_QUA.Width = 269;
            // 
            // MA_LK
            // 
            this.MA_LK.Caption = "MA_LK";
            this.MA_LK.FieldName = "MA_LK";
            this.MA_LK.Name = "MA_LK";
            // 
            // FrmDSCanLamSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 456);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateDen);
            this.Controls.Add(this.dateTu);
            this.Controls.Add(this.label25);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDSCanLamSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Cận lâm sàn";
            this.Load += new System.EventHandler(this.FrmDSCanLamSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateDen;
        private System.Windows.Forms.DateTimePicker dateTu;
        private System.Windows.Forms.Label label25;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn MA_BN;
        private DevExpress.XtraGrid.Columns.GridColumn MA_THE;
        private DevExpress.XtraGrid.Columns.GridColumn HO_TEN;
        private DevExpress.XtraGrid.Columns.GridColumn NAM_SINH;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY_VAO;
        private DevExpress.XtraGrid.Columns.GridColumn KET_QUA;
        private DevExpress.XtraGrid.Columns.GridColumn MA_LK;
    }
}