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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmThongKeThuoc : Form
    {
        ThongKeDAO thongke;
        public FrmThongKeThuoc (Connection db)
        {
            InitializeComponent ();
            thongke = new ThongKeDAO (db);
        }

        private void FrmThongKeThuoc_Load (object sender, EventArgs e)
        {
            dateTuNgay.Value = DateTime.Now;
            dateDenNgay.Value = DateTime.Now;
            cbLoaiKCB.SelectedIndex = 0;
        }

        private void btnXem_Click (object sender, EventArgs e)
        {
            string ngayBD = DateTime.ParseExact (dateTuNgay.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            string ngayKT = DateTime.ParseExact (dateDenNgay.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            DataTable data = thongke.DSThongTinBN (cbLoaiKCB.SelectedIndex,ngayBD, ngayKT);
            DataTable dataThuoc = null;
            if(data!=null)
            {
                System.Drawing.Font fontB = new System.Drawing.Font ("Times New Roman", 11, System.Drawing.FontStyle.Bold);
                System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 11);
                CultureInfo elGR = CultureInfo.CreateSpecificCulture ("el-GR");

                rptThongKeThuoc rpt = new rptThongKeThuoc ();
                rpt.lblNgay.Text = "Từ ngày " + dateTuNgay.Text + " đến ngày " + dateDenNgay.Text;
                rpt.xrTable.Rows.Clear ();
                XRTableRow row;
                XRTableCell cell;
                int count = 0;
                foreach(DataRow dr in data.Rows)
                {
                    count = 0;
                    dataThuoc = thongke.DSThuoc (dr["MA_LK"].ToString());
                    if(dataThuoc!=null)
                    {
                        count = dataThuoc.Rows.Count;
                    }
                    row = new XRTableRow ();

                    cell = new XRTableCell ();
                    cell.WidthF = 80;
                    cell.RowSpan = count;
                    row.Cells.Add (cell);


                    cell = new XRTableCell ();
                    cell.Text = dr["HO_TEN"].ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                    cell.WidthF = 180;
                    cell.RowSpan = count;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = dr["NGAY_SINH"].ToString ().Substring(0,4);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                    cell.WidthF = 60;
                    cell.RowSpan = count;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = dr["DIA_CHI"].ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                    cell.WidthF = 150;
                    cell.RowSpan = count;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = dr["MA_THE"].ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                    cell.WidthF = 120;
                    cell.RowSpan = count;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = dr["NGAY_VAO"].ToString ().Substring (5,2)+"/"+ dr["NGAY_VAO"].ToString ().Substring (3, 2);
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                    cell.WidthF = 80;
                    cell.RowSpan = count;
                    row.Cells.Add (cell);

                    cell = new XRTableCell ();
                    cell.Text = dr["TEN_BENH"].ToString ();
                    cell.Font = font;
                    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                    cell.WidthF = 150;
                    cell.RowSpan = count;
                    row.Cells.Add (cell);
                    for(int j=0;j<count;j++)
                    {
                        cell = new XRTableCell ();
                        cell.Text = dataThuoc.Rows[j]["TEN_THUOC"] + " - " + dataThuoc.Rows[j]["SO_LUONG"];
                        cell.Font = font;
                        cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                        cell.WidthF = 289;
                        row.Cells.Add (cell);

                        rpt.xrTable.Rows.Add (row);

                        row = new XRTableRow ();
                        cell = new XRTableCell ();
                        cell.WidthF = 80;
                        row.Cells.Add (cell);


                        cell = new XRTableCell ();
                        cell.WidthF = 180;
                        row.Cells.Add (cell);

                        cell = new XRTableCell ();
                        cell.WidthF = 60;
                        row.Cells.Add (cell);

                        cell = new XRTableCell ();
                        cell.WidthF = 150;
                        row.Cells.Add (cell);

                        cell = new XRTableCell ();
                        cell.WidthF = 120;
                        row.Cells.Add (cell);

                        cell = new XRTableCell ();
                        cell.WidthF = 80;
                        row.Cells.Add (cell);

                        cell = new XRTableCell ();
                        cell.WidthF = 150;
                        row.Cells.Add (cell);
                    }
                }

                rpt.CreateDocument ();
                rpt.ShowPreviewDialog ();
            }
        }
    }
}
