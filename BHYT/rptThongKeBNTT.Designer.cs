namespace BHYT
{
    partial class rptThongKeBNTT
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellMaBN = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellHoTen = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellNS = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellMH = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellST = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblLoai = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTableHeader = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTong = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable
            // 
            this.xrTable.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable.Name = "xrTable";
            this.xrTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable.SizeF = new System.Drawing.SizeF(766F, 25F);
            this.xrTable.StylePriority.UseBorders = false;
            this.xrTable.StylePriority.UseTextAlignment = false;
            this.xrTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellSTT,
            this.xrTableCellMaBN,
            this.xrTableCellHoTen,
            this.xrTableCellNS,
            this.xrTableCellMH,
            this.xrTableCellST});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCellSTT
            // 
            this.xrTableCellSTT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[STT]")});
            this.xrTableCellSTT.Name = "xrTableCellSTT";
            this.xrTableCellSTT.Text = "STT";
            this.xrTableCellSTT.Weight = 0.49999999999999994D;
            // 
            // xrTableCellMaBN
            // 
            this.xrTableCellMaBN.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MA_BN]")});
            this.xrTableCellMaBN.Name = "xrTableCellMaBN";
            this.xrTableCellMaBN.Text = "Mã BN";
            this.xrTableCellMaBN.Weight = 1.4999998474121095D;
            // 
            // xrTableCellHoTen
            // 
            this.xrTableCellHoTen.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HO_TEN]")});
            this.xrTableCellHoTen.Name = "xrTableCellHoTen";
            this.xrTableCellHoTen.StylePriority.UseTextAlignment = false;
            this.xrTableCellHoTen.Text = "Họ Tên";
            this.xrTableCellHoTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCellHoTen.Weight = 2.5D;
            // 
            // xrTableCellNS
            // 
            this.xrTableCellNS.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGAY_SINH]")});
            this.xrTableCellNS.Name = "xrTableCellNS";
            this.xrTableCellNS.Text = "Năm Sinh";
            this.xrTableCellNS.Weight = 0.8D;
            // 
            // xrTableCellMH
            // 
            this.xrTableCellMH.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MUC_HUONG]")});
            this.xrTableCellMH.Name = "xrTableCellMH";
            this.xrTableCellMH.Text = "Mức Hưởng";
            this.xrTableCellMH.Weight = 1.0000000000000002D;
            // 
            // xrTableCellST
            // 
            this.xrTableCellST.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[T_BNTT]")});
            this.xrTableCellST.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCellST.Name = "xrTableCellST";
            this.xrTableCellST.StylePriority.UseFont = false;
            this.xrTableCellST.StylePriority.UseTextAlignment = false;
            this.xrTableCellST.Text = "Số Tiền";
            this.xrTableCellST.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCellST.TextFormatString = "{0:#,###}";
            this.xrTableCellST.Weight = 1.3700001525878904D;
            // 
            // lblNgay
            // 
            this.lblNgay.LocationFloat = new DevExpress.Utils.PointFloat(302.2918F, 25F);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblNgay.SizeF = new System.Drawing.SizeF(287F, 23F);
            this.lblNgay.StylePriority.UseTextAlignment = false;
            this.lblNgay.Text = "Từ ngày 30/08/2017 đến ngày 30/08/2017";
            this.lblNgay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(230F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(435F, 25F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "THỐNG KÊ TIỀN BỆNH NHÂN THANH TOÁN";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 30F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 30F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblLoai,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1,
            this.lblNgay});
            this.ReportHeader.HeightF = 60F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblLoai
            // 
            this.lblLoai.LocationFloat = new DevExpress.Utils.PointFloat(647.0001F, 35F);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblLoai.SizeF = new System.Drawing.SizeF(120F, 23F);
            this.lblLoai.StylePriority.UseTextAlignment = false;
            this.lblLoai.Text = "lblLoai";
            this.lblLoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 1.999998F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(230F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "SỞ Y TẾ BÌNH PHƯỚC";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(230F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "BỆNH VIỆN ĐA KHOA CAO SU PHÚ RIỀNG";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableHeader});
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTableHeader
            // 
            this.xrTableHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTableHeader.Name = "xrTableHeader";
            this.xrTableHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTableHeader.SizeF = new System.Drawing.SizeF(766F, 25F);
            this.xrTableHeader.StylePriority.UseBorders = false;
            this.xrTableHeader.StylePriority.UseTextAlignment = false;
            this.xrTableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell11,
            this.xrTableCell9,
            this.xrTableCell10});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "STT";
            this.xrTableCell6.Weight = 0.49999999999999994D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Mã BN";
            this.xrTableCell7.Weight = 1.4999998474121095D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Họ Tên";
            this.xrTableCell8.Weight = 2.5D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Text = "Năm Sinh";
            this.xrTableCell11.Weight = 0.8D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "Mức Hưởng";
            this.xrTableCell9.Weight = 1.0000000000000002D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.Text = "Số Tiền";
            this.xrTableCell10.Weight = 1.3700001525878904D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.lblTong});
            this.ReportFooter.HeightF = 25F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(530.0001F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Tổng tiền:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblTong
            // 
            this.lblTong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.LocationFloat = new DevExpress.Utils.PointFloat(630.0001F, 0F);
            this.lblTong.Name = "lblTong";
            this.lblTong.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTong.SizeF = new System.Drawing.SizeF(137F, 23F);
            this.lblTong.StylePriority.UseFont = false;
            this.lblTong.StylePriority.UseTextAlignment = false;
            this.lblTong.Text = "00000";
            this.lblTong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // rptThongKeBNTT
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.Margins = new System.Drawing.Printing.Margins(30, 30, 30, 30);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "17.2";
            this.ParametersRequestBeforeShow += new System.EventHandler<DevExpress.XtraReports.Parameters.ParametersRequestEventArgs>(this.rptThongKeBNTT_ParametersRequestBeforeShow);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel lblNgay;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        public DevExpress.XtraReports.UI.XRTable xrTableHeader;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        public DevExpress.XtraReports.UI.XRTable xrTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellSTT;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellMaBN;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellHoTen;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellNS;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellMH;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellST;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel lblTong;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        public DevExpress.XtraReports.UI.XRLabel lblLoai;
    }
}
