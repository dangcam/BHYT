using BHYT.VO;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmInDonThuoc : Form
    {
        private string coSoKCB;

        DataView dvThuoc;
        DonThuocVO thongtin;
        DataTable dtDuongDung;
        System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 11);

        public string CoSoKCB
        {
            get
            {
                return coSoKCB;
            }

            set
            {
                coSoKCB = value;
            }
        }

        public FrmInDonThuoc (DataView dvThuoc, DonThuocVO thongtin, DataTable dtDuongDung)
        {
            InitializeComponent ();
            this.dvThuoc = dvThuoc;
            this.thongtin = thongtin;
            this.dtDuongDung = dtDuongDung;
        }

        private void FrmInDonThuoc_Load (object sender, EventArgs e)
        {
            lookUpDuongDung.DataSource = dtDuongDung;
            lookUpDuongDung.DisplayMember = "DUONG_DUNG";
            lookUpDuongDung.ValueMember = "MA_DUONG_DUNG";
            DataTable dt = dvThuoc.ToTable ();
            dt.Columns.Add ("LAN_NGAY_DUNG", typeof (int));
            dt.Columns.Add ("LAN_DUNG", typeof (float));
            string lieudung = "";
            foreach(DataRow dr in dt.Rows)
            {
                lieudung = dr["LIEU_DUNG"].ToString ().Trim();
                if(!string.IsNullOrEmpty(lieudung) && lieudung.Contains("lần, lần"))
                {
                    try
                    {
                        dr["LAN_NGAY_DUNG"] = lieudung.Split (' ')[2];
                        dr["LAN_DUNG"] = lieudung.Split (' ')[6];
                    }
                    catch { }
                }
            }
            gridControl.DataSource = dt;
            
        }

        private void btnInDonThuoc_Click (object sender, EventArgs e)
        {
            thongtin.NgheNghiep = txtNgheNghiep.Text;
            createReport ();
        }

        private void createReport()
        {
            string[] gioitinh = new string[] { "Nữ", "Nam" };
            rptDonThuoc rpt = new rptDonThuoc ();
            rpt.lblSoHoSo.Text = thongtin.SoHS;
            rpt.lblHoTen.Text = thongtin.HoTen;
            rpt.lblGioiTinh.Text = "Giới tính: " + gioitinh[thongtin.GioiTinh];
            rpt.lblNgaySinh.Text = "Năm sinh: "+thongtin.NamSinh;
            rpt.lblNgheNghiep.Text = thongtin.NgheNghiep;
            rpt.lblDiaChi.Text = thongtin.DiaChi;
            rpt.lblSoThe.Text = thongtin.SoThe;
            rpt.lblKCB.Text = thongtin.NoiKCB;
            rpt.lblHanDung.Text = thongtin.HanSuDung;
            rpt.lblDinhBenh.Text = thongtin.DinhBenh;
            rpt.lblNgayTT.Text = thongtin.NgayTT;
            rpt.lblBacSi.Text = thongtin.BacSi;
            rpt.xrTable.Rows.Clear ();
            //
            rpt.lblSoHoSo1.Text = thongtin.SoHS;
            rpt.lblHoTen1.Text = thongtin.HoTen;
            rpt.lblGioiTinh1.Text = "Giới tính: " + gioitinh[thongtin.GioiTinh];
            rpt.lblNgaySinh1.Text = "Năm sinh: " + thongtin.NamSinh;
            rpt.lblNgheNghiep1.Text = thongtin.NgheNghiep;
            rpt.lblDiaChi1.Text = thongtin.DiaChi;
            rpt.lblSoThe1.Text = thongtin.SoThe;
            rpt.lblKCB1.Text = thongtin.NoiKCB;
            rpt.lblHanDung1.Text = thongtin.HanSuDung;
            rpt.lblDinhBenh1.Text = thongtin.DinhBenh;
            rpt.lblNgayTT1.Text = thongtin.NgayTT;
            rpt.lblBacSi1.Text = thongtin.BacSi;
            rpt.xrTable1.Rows.Clear ();
            //
            try
            {
                rpt.lblCoSoKCB.Text = CoSoKCB.ToUpper ();
                rpt.lableCoSoKCB.Text = CoSoKCB.ToUpper ();
            }
            catch { }
            
            //
            XRTableRow row;
            XRTableCell cell;
            int i = 1;
            foreach (DataRow drv in (gridControl.DataSource as DataTable).Rows)
            {
                row = new XRTableRow ();
                cell = new XRTableCell ();
                cell.Text = i+") " + drv["TEN_THUOC"];
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 314;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                if (drv["HAM_LUONG"].ToString ().Length < 10)
                {
                    cell.Text = drv["HAM_LUONG"].ToString ();
                }
                else
                {
                    int space = 0;
                    string hamLuong = drv["HAM_LUONG"].ToString ();
                    for (int j = 0;j < hamLuong.Length;j++ )
                    {
                        if(j > 11)
                        {
                            break;
                        }
                        if(hamLuong[j] == ' ')
                        {
                            space = j;
                        }
                    }
                    cell.Text = drv["HAM_LUONG"].ToString ().Substring(0,space);
                }
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 95;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = drv["SO_LUONG"].ToString () + " " + drv["DON_VI_TINH"].ToString ().ToLower();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 91;
                row.Cells.Add (cell);

                rpt.xrTable.Rows.Add (row);             
                //
                row = new XRTableRow ();
                row.HeightF = 30;
                cell = new XRTableCell ();
                cell.WidthF = 84;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = "Ngày " +(lookUpDuongDung.GetDataSourceRowByKeyValue( drv["DUONG_DUNG"].ToString()) as DataRowView)[1].ToString().ToLower()+":     " +drv["LAN_NGAY_DUNG"] ;
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 140;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = "lần, lần ";
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 75;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = drv["LAN_DUNG"] + "  " + drv["DON_VI_TINH"].ToString ().ToLower ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 201;
                row.Cells.Add (cell);

                rpt.xrTable.Rows.Add (row);

                // copy
                row = new XRTableRow ();
                cell = new XRTableCell ();
                cell.Text = i + ") " + drv["TEN_THUOC"];
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 314;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                if (drv["HAM_LUONG"].ToString ().Length < 10)
                {
                    cell.Text = drv["HAM_LUONG"].ToString ();
                }
                else
                {
                    int space = 0;
                    string hamLuong = drv["HAM_LUONG"].ToString ();
                    for (int j = 0; j < hamLuong.Length; j++)
                    {
                        if (j > 11)
                        {
                            break;
                        }
                        if (hamLuong[j] == ' ')
                        {
                            space = j;
                        }
                    }
                    cell.Text = drv["HAM_LUONG"].ToString ().Substring (0, space);
                }
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 95;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = drv["SO_LUONG"].ToString () + " " + drv["DON_VI_TINH"].ToString ().ToLower ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 91;
                row.Cells.Add (cell);

                rpt.xrTable1.Rows.Add (row);
                //
                row = new XRTableRow ();
                row.HeightF = 30;
                cell = new XRTableCell ();
                cell.WidthF = 84;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = "Ngày " + (lookUpDuongDung.GetDataSourceRowByKeyValue (drv["DUONG_DUNG"].ToString ()) as DataRowView)[1].ToString ().ToLower () + ":     " + drv["LAN_NGAY_DUNG"];
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 140;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = "lần, lần ";
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 75;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = drv["LAN_DUNG"] + "  " + drv["DON_VI_TINH"].ToString ().ToLower ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 201;
                row.Cells.Add (cell);

                rpt.xrTable1.Rows.Add (row);
                //
                i++;
            }
            //for(int j = i;j<8;j++)
            //{
            //    row = new XRTableRow ();
            //    row.HeightF = 30;
            //    cell = new XRTableCell ();
            //    cell.Text = j+ ") ";
            //    cell.Font = font;
            //    cell.WidthF = 500;
            //    row.Cells.Add (cell);

            //    rpt.xrTable.Rows.Add (row);
            //    //
            //    row = new XRTableRow ();
            //    row.HeightF = 30;
            //    cell = new XRTableCell ();
            //    cell.WidthF = 64;
            //    row.Cells.Add (cell);

            //    cell = new XRTableCell ();
            //    cell.Text = "Ngày uống";
            //    cell.Font = font;
            //    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            //    cell.WidthF = 160;
            //    row.Cells.Add (cell);

            //    cell = new XRTableCell ();
            //    cell.Text = "lần, lần ";
            //    cell.Font = font;
            //    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            //    cell.WidthF = 75;
            //    row.Cells.Add (cell);

            //    cell = new XRTableCell ();
            //    cell.Text ="";
            //    cell.Font = font;
            //    cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            //    cell.WidthF = 201;
            //    row.Cells.Add (cell);

            //    rpt.xrTable.Rows.Add (row);
            //}
            rpt.xrTable1 = rpt.xrTable;
            rpt.CreateDocument ();

            rpt.ShowPreviewDialog ();
        }

        private void FrmInDonThuoc_FormClosing (object sender, FormClosingEventArgs e)
        {
            try
            {
                DataTable dv = (gridControl.DataSource as DataTable);
                foreach(DataRow drv in dv.Rows)
                {
                    drv["LIEU_DUNG"] = "Ngày " + (lookUpDuongDung.GetDataSourceRowByKeyValue (drv["DUONG_DUNG"].ToString ()) as DataRowView)[1].ToString ().ToLower ()
                        + " " + drv["LAN_NGAY_DUNG"]
                        + " lần, lần  " + drv["LAN_DUNG"] + " " + drv["DON_VI_TINH"].ToString().ToLower();
                }
                dv.Columns.Remove ("LAN_NGAY_DUNG");
                dv.Columns.Remove ("LAN_DUNG");
                FrmNgoaiNoiTru.dvTienThuoc = dv.AsDataView();
            }
            catch { }
        }

        private void txtNgheNghiep_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                btnInDonThuoc.Focus ();
            }
        }
    }
}
