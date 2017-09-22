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
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmThongKeSoLuong : Form
    {
        ThongKeDAO thongke = null;
        public FrmThongKeSoLuong (Connection db)
        {
            InitializeComponent ();
            thongke = new ThongKeDAO (db);
        }

        private void FrmThongKeSoLuong_Load (object sender, EventArgs e)
        {
            cbGiaiDoan.SelectedIndex = 0;

            cbThang.SelectedIndex = 0;
            cbQuy.SelectedIndex = 0;
            cbTieuChi.SelectedIndex = 0;
            cbLoaiKCB.SelectedIndex = 0;

            cbNam.Hide ();
            cbQuy.Hide ();
            cbThang.Hide ();

            //

            this.cbNam.Items.Clear ();
            string[] nam = new string[30];
            int j = 0;
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 30; i--)
            {
                nam[j] = i.ToString ();
                j++;
            }
            this.cbNam.Items.AddRange (nam);
            cbNam.SelectedIndex = 0;
        }

        private void cbGiaiDoan_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cbGiaiDoan.SelectedIndex != 0)
            {
                dateDenNgay.Hide ();
                dateTuNgay.Hide ();
                cbThang.Hide ();
                cbQuy.Hide ();
                cbNam.Show ();
                if (cbGiaiDoan.SelectedIndex == 1)
                {
                    cbThang.Show ();
                }
                if (cbGiaiDoan.SelectedIndex == 2)
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
            createReport ();
        }
        private int lastDay (int y, int m)
        {
            return DateTime.DaysInMonth (y, m);
        }
        private void getData(rptThongKeSoLuong rpt)
        {
            int soLuong = 0;
            try
            {
                if (txtSoLuong.Text.Length > 3)
                {
                    txtSoLuong.Text = txtSoLuong.Text.Substring (0, 3);
                }
                soLuong = Convert.ToInt32 (txtSoLuong.Text);
            }
            catch { }
            string ngayBD;
            string ngayKT;
            if (cbGiaiDoan.SelectedIndex == 0)
            {
                ngayBD = DateTime.ParseExact (dateTuNgay.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                ngayKT = DateTime.ParseExact (dateDenNgay.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                rpt.lblNgay.Text = "Từ ngày " + ngayBD.Substring (6, 2) + "/" + ngayBD.Substring (4, 2) + "/" + ngayBD.Substring (0, 4) +
               " đến " + ngayKT.Substring (6, 2) + "/" + ngayKT.Substring (4, 2) + "/" + ngayKT.Substring (0, 4);
            }
            else
            if (cbGiaiDoan.SelectedIndex == 1)
            {
                ngayBD = cbNam.SelectedItem.ToString () + cbThang.SelectedItem.ToString () + "01";
                ngayKT = cbNam.SelectedItem + cbThang.SelectedItem.ToString () +
                   lastDay (Convert.ToInt32 (cbNam.SelectedItem), Convert.ToInt32 (cbThang.SelectedItem.ToString ()));
                rpt.lblNgay.Text = "Tháng " + cbThang.SelectedItem + " năm " + cbNam.SelectedItem.ToString ();
            }
            else
            if (cbGiaiDoan.SelectedIndex == 2)
            {
                string thangDau = "01";
                string thangCuoi = "12";
                if (cbQuy.SelectedIndex == 0)
                {
                    thangDau = "01";
                    thangCuoi = "03";
                }
                else
                    if (cbQuy.SelectedIndex == 1)
                {
                    thangDau = "04";
                    thangCuoi = "06";
                }
                else
                    if (cbQuy.SelectedIndex == 2)
                {
                    thangDau = "07";
                    thangCuoi = "09";
                }
                else
                {
                    thangDau = "10";
                    thangCuoi = "12";
                }
                ngayBD = cbNam.SelectedItem.ToString () + thangDau + "01";
                ngayKT = cbNam.SelectedItem.ToString () + thangCuoi + lastDay (Convert.ToInt32 (cbNam.SelectedItem), Convert.ToInt32 (thangCuoi));
                rpt.lblNgay.Text = "Quý " + (cbQuy.SelectedIndex + 1) + " năm " + cbNam.SelectedItem.ToString ();
            }
            else
            {
                ngayBD = cbNam.SelectedItem + "0101";
                ngayKT = cbNam.SelectedItem + "12" + lastDay (Convert.ToInt32 (cbNam.SelectedItem), 12);
                rpt.lblNgay.Text = "Năm " + cbNam.SelectedItem.ToString ();
            }
            DataTable dt = new DataTable ();
            int loai = cbTieuChi.SelectedIndex;
            switch (loai)
            {
                case 0:
                    dt = thongke.DSThongKeThuocSL (soLuong, ngayBD, ngayKT,cbLoaiKCB.SelectedIndex);
                    createThuoc (rpt, dt);
                    break;
                case 1:
                    dt = thongke.DSThongKeThuocCP (soLuong, ngayBD, ngayKT);
                    createThuoc (rpt, dt);
                    break;
                case 2:
                    dt = thongke.DSThongKeDVKTSL (soLuong, ngayBD, ngayKT);
                    createDVKT (rpt, dt);
                    break;
                case 3:
                    dt = thongke.DSThongKeDVKTCP (soLuong, ngayBD, ngayKT);
                    createDVKT (rpt, dt);
                    break;
                case 4:
                    dt = thongke.DSThongKeVTYTSL (soLuong, ngayBD, ngayKT);
                    createVTYT (rpt, dt);
                    break;
                case 5:
                    dt = thongke.DSThongKeVTYTCP (soLuong, ngayBD, ngayKT);
                    createVTYT (rpt, dt);
                    break;
            }
        }
        private void createDVKT (rptThongKeSoLuong rpt, DataTable data)
        {
            rpt.xrTable.Rows.Clear ();
            System.Drawing.Font fontB = new System.Drawing.Font ("Times New Roman", 9, System.Drawing.FontStyle.Bold);
            System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 9);
            CultureInfo elGR = CultureInfo.CreateSpecificCulture ("el-GR");
            XRTableRow row = new XRTableRow ();
            XRTableCell cell = new XRTableCell ();
            cell.Text = "STT";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "MÃ DỊCH VỤ";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 110;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "TÊN DỊCH VỤ";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 400;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "SỐ LƯỢNG";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 110;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "TỔNG CHI";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 140;
            row.Cells.Add (cell);
           
            rpt.xrTable.Rows.Add (row);
            //
            row = new XRTableRow ();
            cell = new XRTableCell ();
            cell.Text = "(1)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(2)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 110;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(3)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 400;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(4)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 110;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(5)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 140;
            row.Cells.Add (cell);

            rpt.xrTable.Rows.Add (row);
            //
            int i = 0;
            foreach(DataRow dr in data.Rows)
            {
                i++;
                row = new XRTableRow ();
                cell = new XRTableCell ();
                cell.Text = i.ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.WidthF = 40;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["MA_DICH_VU"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 110;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["TEN_DICH_VU"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 400;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["SO_LUONG"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 110;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Convert.ToDecimal (dr["THANH_TIEN"].ToString ()).ToString ("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 140;
                row.Cells.Add (cell);

                rpt.xrTable.Rows.Add (row);
            }
        }
        private void createVTYT (rptThongKeSoLuong rpt, DataTable data)
        {
            rpt.xrTable.Rows.Clear ();
            System.Drawing.Font fontB = new System.Drawing.Font ("Times New Roman", 9, System.Drawing.FontStyle.Bold);
            System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 9);
            CultureInfo elGR = CultureInfo.CreateSpecificCulture ("el-GR");
            XRTableRow row = new XRTableRow ();
            XRTableCell cell = new XRTableCell ();
            cell.Text = "STT";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "MÃ VẬT TƯ";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 110;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "TÊN VẬT TƯ";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 400;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "SỐ LƯỢNG";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 110;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "TỔNG CHI";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 140;
            row.Cells.Add (cell);

            rpt.xrTable.Rows.Add (row);
            //
            row = new XRTableRow ();
            cell = new XRTableCell ();
            cell.Text = "(1)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(2)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 110;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(3)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 400;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(4)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 110;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(5)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 140;
            row.Cells.Add (cell);

            rpt.xrTable.Rows.Add (row);
            //
            int i = 0;
            foreach (DataRow dr in data.Rows)
            {
                i++;
                row = new XRTableRow ();
                cell = new XRTableCell ();
                cell.Text = i.ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.WidthF = 40;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["MA_DICH_VU"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 110;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["TEN_DICH_VU"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 400;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["SO_LUONG"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 110;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Convert.ToDecimal (dr["THANH_TIEN"].ToString ()).ToString ("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 140;
                row.Cells.Add (cell);

                rpt.xrTable.Rows.Add (row);
            }
        }
        private void createThuoc(rptThongKeSoLuong rpt, DataTable data)
        {
            rpt.xrTable.Rows.Clear ();
            System.Drawing.Font fontB = new System.Drawing.Font ("Times New Roman", 9, System.Drawing.FontStyle.Bold);
            System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 9);
            CultureInfo elGR = CultureInfo.CreateSpecificCulture ("el-GR");
            XRTableRow row = new XRTableRow ();
            XRTableCell cell = new XRTableCell ();

            cell.Text = "STT";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "MÃ THUỐC";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 100;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "TÊN THUỐC";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 160;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "ĐƯỜNG DÙNG";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 100;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "HÀM LƯỢNG";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 150;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "SỐ ĐĂNG KÝ";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "SỐ LƯỢNG";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "TỔNG CHI";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            rpt.xrTable.Rows.Add (row);
            //
            row = new XRTableRow ();
            cell = new XRTableCell ();
            cell.Text = "(1)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 40;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(2)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 100;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(3)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 160;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(4)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 100;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(5)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 150;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(6)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(7)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 70;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "(8)";
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            rpt.xrTable.Rows.Add (row);
            int i = 0;
            if(data==null)
            {
                return;
            }
            foreach (DataRow dr in data.Rows)
            {
                i++;
                row = new XRTableRow ();
                cell = new XRTableCell ();
                cell.Text = i.ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                cell.WidthF = 40;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["MA_THUOC"].ToString();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 100;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["TEN_THUOC"].ToString();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 160;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["DUONG_DUNG"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 100;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["HAM_LUONG"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 150;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["SO_DANG_KY"].ToString();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = dr["SO_LUONG"].ToString();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 70;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Convert.ToDecimal(dr["THANH_TIEN"].ToString ()).ToString ("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                rpt.xrTable.Rows.Add (row);
            }

        }
        private void createReport()
        {
            rptThongKeSoLuong rpt = new rptThongKeSoLuong ();
            rpt.lblTieuDe.Text = cbTieuChi.SelectedItem.ToString().ToUpper ();
            
            getData (rpt);
            rpt.CreateDocument ();
            rpt.ShowPreviewDialog ();
        }
    }
}
