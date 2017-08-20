namespace BHYT
{
    partial class FrmDVKT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDVKT));
            this.bntNhapExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDVKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDVKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuyetDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CongBo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lookUpNhom = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMaDVKT = new System.Windows.Forms.TextBox();
            this.txtTenDVKT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtQuyetDinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCongBo = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bntNhapExcel
            // 
            this.bntNhapExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhapExcel.Appearance.Options.UseFont = true;
            this.bntNhapExcel.Image = ((System.Drawing.Image)(resources.GetObject("bntNhapExcel.Image")));
            this.bntNhapExcel.Location = new System.Drawing.Point(816, 12);
            this.bntNhapExcel.Name = "bntNhapExcel";
            this.bntNhapExcel.Size = new System.Drawing.Size(106, 33);
            this.bntNhapExcel.TabIndex = 11;
            this.bntNhapExcel.Text = "Nhập Excel";
            this.bntNhapExcel.Click += new System.EventHandler(this.bntNhapExcel_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Location = new System.Drawing.Point(0, 110);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(934, 411);
            this.gridControl.TabIndex = 10;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNhom,
            this.MaDVKT,
            this.TenDVKT,
            this.MaGia,
            this.DonGia,
            this.GiaAX,
            this.QuyetDinh,
            this.CongBo});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Tìm dịch vụ kỹ thuật";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.Click += new System.EventHandler(this.gridView_Click);
            // 
            // MaNhom
            // 
            this.MaNhom.Caption = "Mã Nhóm";
            this.MaNhom.FieldName = "MA_NHOM";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.OptionsColumn.AllowEdit = false;
            this.MaNhom.OptionsColumn.FixedWidth = true;
            this.MaNhom.Visible = true;
            this.MaNhom.VisibleIndex = 0;
            this.MaNhom.Width = 40;
            // 
            // MaDVKT
            // 
            this.MaDVKT.Caption = "Mã DVKT";
            this.MaDVKT.FieldName = "MA_DVKT";
            this.MaDVKT.Name = "MaDVKT";
            this.MaDVKT.OptionsColumn.AllowEdit = false;
            this.MaDVKT.OptionsColumn.FixedWidth = true;
            this.MaDVKT.Visible = true;
            this.MaDVKT.VisibleIndex = 1;
            this.MaDVKT.Width = 70;
            // 
            // TenDVKT
            // 
            this.TenDVKT.Caption = "Tên DVKT";
            this.TenDVKT.FieldName = "TEN_DVKT";
            this.TenDVKT.Name = "TenDVKT";
            this.TenDVKT.OptionsColumn.AllowEdit = false;
            this.TenDVKT.OptionsColumn.FixedWidth = true;
            this.TenDVKT.Visible = true;
            this.TenDVKT.VisibleIndex = 2;
            this.TenDVKT.Width = 200;
            // 
            // MaGia
            // 
            this.MaGia.Caption = "Mã Giá";
            this.MaGia.FieldName = "MA_GIA";
            this.MaGia.Name = "MaGia";
            this.MaGia.OptionsColumn.AllowEdit = false;
            this.MaGia.OptionsColumn.FixedWidth = true;
            this.MaGia.Visible = true;
            this.MaGia.VisibleIndex = 3;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.DisplayFormat.FormatString = "#,###";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGia.FieldName = "DON_GIA";
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowEdit = false;
            this.DonGia.OptionsColumn.FixedWidth = true;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 4;
            // 
            // GiaAX
            // 
            this.GiaAX.Caption = "Giá Ánh Xạ";
            this.GiaAX.DisplayFormat.FormatString = "#,###";
            this.GiaAX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.GiaAX.FieldName = "GIA_AX";
            this.GiaAX.Name = "GiaAX";
            this.GiaAX.OptionsColumn.AllowEdit = false;
            this.GiaAX.OptionsColumn.FixedWidth = true;
            this.GiaAX.Visible = true;
            this.GiaAX.VisibleIndex = 5;
            // 
            // QuyetDinh
            // 
            this.QuyetDinh.Caption = "Quyết Định";
            this.QuyetDinh.FieldName = "QUYET_DINH";
            this.QuyetDinh.Name = "QuyetDinh";
            this.QuyetDinh.OptionsColumn.AllowEdit = false;
            this.QuyetDinh.OptionsColumn.FixedWidth = true;
            this.QuyetDinh.Visible = true;
            this.QuyetDinh.VisibleIndex = 6;
            // 
            // CongBo
            // 
            this.CongBo.Caption = "Công Bố";
            this.CongBo.FieldName = "CONG_BO";
            this.CongBo.Name = "CongBo";
            this.CongBo.OptionsColumn.AllowEdit = false;
            this.CongBo.OptionsColumn.FixedWidth = true;
            this.CongBo.Visible = true;
            this.CongBo.VisibleIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhóm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã DVKT:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên DVKT:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lookUpNhom
            // 
            this.lookUpNhom.Location = new System.Drawing.Point(101, 10);
            this.lookUpNhom.Name = "lookUpNhom";
            this.lookUpNhom.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpNhom.Properties.Appearance.Options.UseFont = true;
            this.lookUpNhom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpNhom.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MA_NHOM", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN_NHOM", 50, "Nhóm")});
            this.lookUpNhom.Properties.NullText = "";
            this.lookUpNhom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpNhom.Size = new System.Drawing.Size(201, 22);
            this.lookUpNhom.TabIndex = 0;
            // 
            // txtMaDVKT
            // 
            this.txtMaDVKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDVKT.Location = new System.Drawing.Point(101, 41);
            this.txtMaDVKT.Name = "txtMaDVKT";
            this.txtMaDVKT.Size = new System.Drawing.Size(201, 22);
            this.txtMaDVKT.TabIndex = 1;
            // 
            // txtTenDVKT
            // 
            this.txtTenDVKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDVKT.Location = new System.Drawing.Point(101, 72);
            this.txtTenDVKT.Name = "txtTenDVKT";
            this.txtTenDVKT.Size = new System.Drawing.Size(201, 22);
            this.txtTenDVKT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn Giá:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quyết Định:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(428, 10);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(138, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtQuyetDinh
            // 
            this.txtQuyetDinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyetDinh.Location = new System.Drawing.Point(428, 41);
            this.txtQuyetDinh.Name = "txtQuyetDinh";
            this.txtQuyetDinh.Size = new System.Drawing.Size(201, 22);
            this.txtQuyetDinh.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Công Bố:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCongBo
            // 
            this.txtCongBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongBo.Location = new System.Drawing.Point(428, 72);
            this.txtCongBo.Name = "txtCongBo";
            this.txtCongBo.Size = new System.Drawing.Size(201, 22);
            this.txtCongBo.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(847, 64);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.Location = new System.Drawing.Point(653, 64);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(75, 30);
            this.btnMoi.TabIndex = 7;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(752, 64);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đơn Vị:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(653, 10);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(138, 22);
            this.txtDonViTinh.TabIndex = 4;
            // 
            // FrmDVKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 521);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtCongBo);
            this.Controls.Add(this.txtQuyetDinh);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenDVKT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaDVKT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lookUpNhom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.bntNhapExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDVKT";
            this.Text = "Danh mục Dịch vụ kỹ thuật";
            this.Load += new System.EventHandler(this.FrmDVKT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpNhom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bntNhapExcel;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn MaDVKT;
        private DevExpress.XtraGrid.Columns.GridColumn TenDVKT;
        private DevExpress.XtraGrid.Columns.GridColumn MaGia;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn GiaAX;
        private DevExpress.XtraGrid.Columns.GridColumn QuyetDinh;
        private DevExpress.XtraGrid.Columns.GridColumn CongBo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lookUpNhom;
        private System.Windows.Forms.TextBox txtMaDVKT;
        private System.Windows.Forms.TextBox txtTenDVKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtQuyetDinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCongBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonViTinh;
    }
}