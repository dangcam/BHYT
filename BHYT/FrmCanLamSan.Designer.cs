namespace BHYT
{
    partial class FrmCanLamSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCanLamSan));
            this.lookUpCanLamSan = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlDS = new DevExpress.XtraGrid.GridControl();
            this.gridViewDS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCanLamSan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpCanLamSan
            // 
            this.lookUpCanLamSan.Location = new System.Drawing.Point(103, 12);
            this.lookUpCanLamSan.Name = "lookUpCanLamSan";
            this.lookUpCanLamSan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpCanLamSan.Properties.Appearance.Options.UseFont = true;
            this.lookUpCanLamSan.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpCanLamSan.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpCanLamSan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCanLamSan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", 60, "Tên")});
            this.lookUpCanLamSan.Properties.NullText = "";
            this.lookUpCanLamSan.Size = new System.Drawing.Size(181, 22);
            this.lookUpCanLamSan.TabIndex = 0;
            this.lookUpCanLamSan.EditValueChanged += new System.EventHandler(this.lookUpCanLamSan_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cận lâm sàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(332, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(59, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(438, 12);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(212, 22);
            this.txtTen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên:";
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.Location = new System.Drawing.Point(656, 12);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(46, 23);
            this.btnMoi.TabIndex = 6;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(708, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(71, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(15, 51);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(376, 368);
            this.gridControl.TabIndex = 7;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlDS
            // 
            this.gridControlDS.Location = new System.Drawing.Point(438, 51);
            this.gridControlDS.MainView = this.gridViewDS;
            this.gridControlDS.Name = "gridControlDS";
            this.gridControlDS.Size = new System.Drawing.Size(341, 368);
            this.gridControlDS.TabIndex = 8;
            this.gridControlDS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDS});
            // 
            // gridViewDS
            // 
            this.gridViewDS.GridControl = this.gridControlDS;
            this.gridViewDS.Name = "gridViewDS";
            this.gridViewDS.OptionsFind.AlwaysVisible = true;
            this.gridViewDS.OptionsFind.FindNullPrompt = "Nhập thông tin cần tìm";
            this.gridViewDS.OptionsView.ShowGroupPanel = false;
            // 
            // btnChuyen
            // 
            this.btnChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen.Location = new System.Drawing.Point(397, 120);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(35, 33);
            this.btnChuyen.TabIndex = 9;
            this.btnChuyen.Text = ">>";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // btnTra
            // 
            this.btnTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.Location = new System.Drawing.Point(397, 159);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(35, 33);
            this.btnTra.TabIndex = 9;
            this.btnTra.Text = "<<";
            this.btnTra.UseVisualStyleBackColor = true;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // FrmCanLamSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 431);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.gridControlDS);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookUpCanLamSan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCanLamSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Cận Lâm Sàn";
            this.Load += new System.EventHandler(this.FrmCanLamSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCanLamSan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpCanLamSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnLuu;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControlDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDS;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Button btnTra;
    }
}