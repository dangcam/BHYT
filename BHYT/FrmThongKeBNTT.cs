﻿using BHYT.DAO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmThongKeBNTT : Form
    {
        THONGTIN_CTDAO thongtin;
        public FrmThongKeBNTT (Connection db)
        {
            InitializeComponent ();
            thongtin = new THONGTIN_CTDAO (db);
        }
        private void FrmThongKeBNTT_Load (object sender, EventArgs e)
        {
            dateTuNgay.Value = DateTime.Now;
            dateDenNgay.Value = DateTime.Now;
            cbLoaiKCB.SelectedIndex = 0;
        }
        private void btnXem_Click (object sender, EventArgs e)
        {
            string ngayBD = DateTime.ParseExact (dateTuNgay.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            string ngayKT = DateTime.ParseExact (dateDenNgay.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            DataTable data = thongtin.DSThongTinBN (cbLoaiKCB.SelectedIndex, ngayBD, ngayKT);
            if(data!=null)
            {
                System.Drawing.Font fontB = new System.Drawing.Font ("Times New Roman", 11, System.Drawing.FontStyle.Bold);
                System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 11);
                CultureInfo elGR = CultureInfo.CreateSpecificCulture ("el-GR");

                rptThongKeBNTT rpt = new rptThongKeBNTT ();
                rpt.lblNgay.Text = "Từ ngày " + dateTuNgay.Text + " đến ngày " + dateDenNgay.Text;
                XRTableRow row;
                XRTableCell cell;
                int i = 0;
                decimal t = 0;
                foreach (DataRow dr in data.Rows)
                {
                    row = new XRTableRow ();
                    cell = new XRTableCell ();
                    i++;
                    cell.Text = i.ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    cell.WidthF = 50;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = dr["MA_BN"].ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    cell.WidthF = 150;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = dr["HO_TEN"].ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                    cell.WidthF = 250;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = dr["MUC_HUONG"].ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    cell.WidthF = 100;
                    row.Cells.Add (cell);

                    decimal tmp = Convert.ToDecimal (dr["T_BNTT"].ToString ());
                    t += tmp; 
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 217;
                    row.Cells.Add (cell);

                    rpt.xrTable.Rows.Add (row);
                }
                row = new XRTableRow ();

                cell = new XRTableCell ();
                cell.WidthF = 50;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = "Tổng cộng";
                cell.Font = fontB;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.WidthF = 500;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = t.ToString ("0,0", elGR);
                cell.Font = fontB;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 217;
                row.Cells.Add (cell);

                rpt.xrTable.Rows.Add (row);

                rpt.CreateDocument ();
                rpt.ShowPreviewDialog ();
            }
        }


    }
}
