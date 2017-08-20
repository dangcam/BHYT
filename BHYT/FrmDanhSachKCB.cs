using BHYT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmDanhSachKCB : Form
    {
        THONGTIN_CTDAO thongTinKCB;
        public FrmDanhSachKCB (Connection db)
        {
            InitializeComponent ();
            thongTinKCB = new THONGTIN_CTDAO (db);
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            string ngayBD = DateTime.ParseExact (dateTu.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            string ngayKT = DateTime.ParseExact (dateDen.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            gridControl.DataSource = thongTinKCB.DSThongTinBN ((cbLoaiKCB.SelectedIndex + 1).ToString (), ngayBD, ngayKT,cbPhong.SelectedIndex, cbLoaiNgay.SelectedIndex);
            lblTong.Text = "Tổng : " + (gridControl.DataSource as DataTable).Rows.Count;
        }

        private void FrmDanhSachKCB_Load (object sender, EventArgs e)
        {
            FrmNgoaiNoiTru.MaLienKet = string.Empty;
            cbLoaiKCB.SelectedIndex = 0;
            cbPhong.SelectedIndex = 0;
            cbLoaiNgay.SelectedIndex = 0;
        }

        private void gridView_CustomColumnDisplayText (object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.DisplayText.Length <= 4)
                return;
            if(e.Column.VisibleIndex == 3 && !e.DisplayText.Contains("/"))
            {
                e.DisplayText = DateTime.ParseExact (e.DisplayText, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToShortDateString();
            }
            if ((e.Column.VisibleIndex == 4 || e.Column.VisibleIndex == 5) && !e.DisplayText.Contains ("/"))
            {
                e.DisplayText = DateTime.ParseExact (e.DisplayText, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).ToShortDateString ();
            }
        }

        private void gridView_DoubleClick (object sender, EventArgs e)
        {
            FrmNgoaiNoiTru.MaLienKet = (gridView.GetFocusedRow () as DataRowView)[0].ToString ();
            this.Close ();
        }

      
        private void gridView_RowUpdated (object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                bool check = bool.Parse ((gridView.GetFocusedDataRow () as DataRow)["CHECK_OUT"].ToString ());
                string maLK = (gridView.GetFocusedDataRow () as DataRow)["MA_LK"].ToString ();
                string err = "";
                int c = check ? 1 : 0;
                thongTinKCB.SuaCheckout (ref err, maLK, c);
            }
            catch { }
        }
    }
}
