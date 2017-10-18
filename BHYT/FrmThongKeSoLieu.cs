using BHYT.DAO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmThongKeSoLieu : Form
    {
        ThongKeDAO thongke;
        public FrmThongKeSoLieu (Connection db)
        {
            InitializeComponent ();
            thongke = new ThongKeDAO (db);
        }

        private void FrmThongKeSoLieu_Load (object sender, EventArgs e)
        {
            cbGiaiDoan.SelectedIndex = 0;
           
            cbThang.SelectedIndex = 0;
            cbQuy.SelectedIndex = 0;

            cbNam.Hide ();
            cbQuy.Hide ();
            cbThang.Hide ();

            this.cbNam.Items.Clear ();
            string[] nam = new string[30];
            int j = 0;
            for(int i =DateTime.Now.Year;i> DateTime.Now.Year-30; i--)
            {
                nam[j] = i.ToString ();
                j++;
            }
            this.cbNam.Items.AddRange (nam);
            cbNam.SelectedIndex = 0;
        }

        private void cbGiaiDoan_SelectedIndexChanged (object sender, EventArgs e)
        {
            if(cbGiaiDoan.SelectedIndex !=0)
            {
                dateDenNgay.Hide ();
                dateTuNgay.Hide ();
                cbThang.Hide ();
                cbQuy.Hide ();
                cbNam.Show ();
                if(cbGiaiDoan.SelectedIndex == 1)
                {
                    cbThang.Show ();
                }
                if(cbGiaiDoan.SelectedIndex == 2)
                {
                    cbQuy.Show ();
                }
            }
            else
            {
                cbNam.Hide ();
                cbQuy.Hide ();
                cbThang.Hide ();

                dateDenNgay.Show ();
                dateTuNgay.Show ();
            }
        }
       
        private void btnTongHop_Click (object sender, EventArgs e)
        {
            SplashScreen.Start ();
            DataTable dt = new DataTable ();
            string ngayBD;
            string ngayKT;
            if (cbGiaiDoan.SelectedIndex == 0)
            {
                 ngayBD = DateTime.ParseExact (dateTuNgay.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                 ngayKT = DateTime.ParseExact (dateDenNgay.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                dt = thongke.DSThongKe (ngayBD, ngayKT);
            }else
            if (cbGiaiDoan.SelectedIndex == 1)
            {
                 ngayBD = cbNam.SelectedItem.ToString () + cbThang.SelectedItem.ToString () + "01";
                 ngayKT = cbNam.SelectedItem + cbThang.SelectedItem.ToString () +
                    lastDay (Convert.ToInt32 (cbNam.SelectedItem), Convert.ToInt32 (cbThang.SelectedItem.ToString ()));
                dt = thongke.DSThongKe (ngayBD, ngayKT);
            }
            else
            if (cbGiaiDoan.SelectedIndex == 2)
            {
                string thangDau = "01";
                string thangCuoi = "12";
                if(cbQuy.SelectedIndex == 0)
                {
                    thangDau = "01";
                    thangCuoi = "03";
                }
                else
                    if(cbQuy.SelectedIndex == 1)
                {
                    thangDau = "04";
                    thangCuoi = "06";
                }
                else
                    if(cbQuy.SelectedIndex == 2)
                {
                    thangDau = "07";
                    thangCuoi = "09";
                }
                else
                {
                    thangDau = "10";
                    thangCuoi = "12";
                }
                 ngayBD = cbNam.SelectedItem.ToString() + thangDau + "01";
                 ngayKT = cbNam.SelectedItem.ToString() + thangCuoi + lastDay (Convert.ToInt32 (cbNam.SelectedItem), Convert.ToInt32(thangCuoi));
                dt = thongke.DSThongKe (ngayBD, ngayKT);
            }
            else
            {
                 ngayBD = cbNam.SelectedItem + "0101";
                 ngayKT = cbNam.SelectedItem + "12" + lastDay (Convert.ToInt32 (cbNam.SelectedItem), 12);
                dt = thongke.DSThongKe (ngayBD, ngayKT);
               
            }
            rptTongHopChiPhi rpt = new rptTongHopChiPhi ();
            rpt.lblNgay.Text = "Từ ngày " + ngayBD.Substring (6, 2) + "/" + ngayBD.Substring (4, 2) + "/" + ngayBD.Substring (0, 4) +
                " đến " + ngayKT.Substring (6, 2) + "/" + ngayKT.Substring (4, 2) + "/" + ngayKT.Substring (0, 4);
            rpt.lblNgayLap.Text = "Tỉnh Bình Phước, ngày "+DateTime.Now.Day + ", tháng "+DateTime.Now.Month+", năm "+DateTime.Now.Year;
            System.Drawing.Font fontB = new System.Drawing.Font ("Tahoma", 8, System.Drawing.FontStyle.Bold);
            System.Drawing.Font font = new System.Drawing.Font ("Tahoma", 8);
            CultureInfo elGR = CultureInfo.CreateSpecificCulture ("el-GR");
            XRTableRow row = new XRTableRow ();
            XRTableCell cell = new XRTableCell ();
            decimal DT = 0, TT = 0, T_TONGCHI = 0, T_THUOC = 0, T_XN = 0, T_CDHA_TDCN = 0, T_MAU = 0, T_TT_PT = 0, T_VTYT = 0,
                T_VC = 0,T_KHAM = 0, T_GIUONG = 0, T_BHTT = 0, T_BNTT = 0;
            decimal tmp = 0;
            if (dt != null)
            {
                
                foreach (DataRow dr in dt.Rows)
                {
                    row = new XRTableRow ();
                    cell = new XRTableCell ();
                    cell.Text = dr["NGAYTT"].ToString().Substring (6, 2) + "/" + dr["NGAYTT"].ToString ().Substring (4, 2) + "/" + dr["NGAYTT"].ToString ().Substring (0, 4);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    cell.WidthF = 70;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToInt32 (dr["DT"].ToString ());
                    }
                    catch { tmp = 0; }
                    DT += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 40;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToInt32 (dr["TT"].ToString ());
                    }
                    catch { tmp = 0; }
                    TT += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 40;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_TONGCHI"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_TONGCHI += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 80;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_XN"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_XN += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 60;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_CDHA_TDCN"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_CDHA_TDCN += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 60;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_THUOC"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_THUOC += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 70;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_MAU"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_MAU += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 50;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_TT_PT"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_TT_PT += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 60;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_VTYT"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_VTYT += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 60;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text ="";
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 40;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = "";
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 50;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = "";
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 50;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_KHAM"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_KHAM += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 55;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_GIUONG"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_GIUONG += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 55;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_VC"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_VC += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 50;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_BHTT"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_BHTT += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 85;
                    row.Cells.Add (cell);

                    try
                    {
                        tmp = Convert.ToDecimal (dr["T_BNTT"].ToString ());
                    }
                    catch { tmp = 0; }
                    T_BNTT += tmp;
                    cell = new XRTableCell ();
                    cell.Text = tmp.ToString ("0,0", elGR);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 75;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = "";
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                    cell.WidthF = 65;
                    row.Cells.Add (cell);

                    rpt.xrTable.Rows.Add (row);
                }
            }
            row = new XRTableRow ();
            cell = new XRTableCell ();
            cell.Text = "Tổng cộng";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = DT.ToString ();
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = TT.ToString ();
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_TONGCHI.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 80;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_XN.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 60;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_CDHA_TDCN.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 60;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_THUOC.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_MAU.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 50;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_TT_PT.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 60;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_VTYT.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 60;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "00";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "00";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 50;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "00";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 50;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_KHAM.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 55;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_GIUONG.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 55;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_VC.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 50;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_BHTT.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 85;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = T_BNTT.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 75;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "00";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 65;
            row.Cells.Add (cell);

            rpt.xrTable.Rows.Add (row);
            rpt.CreateDocument ();
            
            rpt.ShowPreviewDialog ();
            SplashScreen.Stop();

        }
        private int lastDay(int y, int m)
        {
            return DateTime.DaysInMonth (y, m);
        }
    }
}
