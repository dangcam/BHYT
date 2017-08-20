using BHYT.DAO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmDSTiepNhan : Form
    {
        FrmKeDon frmKeDon;
        DataTable dt = null;
        THONGTIN_CTDAO thongtinCT = null;
        DataRow dr = null;
        public FrmDSTiepNhan (Connection db)
        {
            InitializeComponent ();
            thongtinCT = new THONGTIN_CTDAO (db);
            frmKeDon = new FrmKeDon (db);
        }

        private void FrmDSTiepNhan_Load (object sender, EventArgs e)
        {
            cbTinhTrang.SelectedIndex = 1;
            dateTu.Value = DateTime.Now;
            dateDen.Value = DateTime.Now;
            LoadData ();
        }
        private void LoadData ()
        {
            string ngayBD = DateTime.ParseExact (dateTu.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            string ngayKT = DateTime.ParseExact (dateDen.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            dt = thongtinCT.DSTiepNhan (ngayBD, ngayKT, AppConfig.SoPhong,cbTinhTrang.SelectedIndex,"1");
            gridControl.DataSource = dt;
            if (dt != null)
            {
                lblPhongKham1.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 1").ToString ();
                lblPhongKham2.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 2").ToString ();
                lblPhongKham3.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 3").ToString ();
                lblPhongKham4.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 4").ToString ();
            }
        }
        private void btnTim_Click (object sender, EventArgs e)
        {
            LoadData ();
        }

        private void gridView_CustomColumnDisplayText (object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.VisibleIndex == 5 && !e.DisplayText.Contains ("/"))
                {
                    e.DisplayText = DateTime.ParseExact (e.DisplayText, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToString ("dd/MM/yyyy");
                }
                if ((e.Column.VisibleIndex == 6) && !e.DisplayText.Contains ("/"))
                {
                    e.DisplayText = DateTime.ParseExact (e.DisplayText, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).ToString ("dd/MM/yyyy");
                }
                if (e.Column.VisibleIndex == 4)
                {
                    if (Utils.ToInt (e.Value.ToString ()) == 0)
                    {
                        e.DisplayText = "Nữ";
                    }
                    else
                    {
                        e.DisplayText = "Nam";
                    }
                }
            }
            catch { }
        }

        private void btnChuyenNoiTru_Click (object sender, EventArgs e)
        {
            dr = gridView.GetFocusedDataRow ();
            if(dr !=null)
            {
                if(dr["NGAY_RA"].ToString().Length>0)
                {
                    XtraMessageBox.Show ("Bệnh nhân này đã ra viện!");
                    return;
                }
                DialogResult traloi;
                string err = "";
                traloi = XtraMessageBox.Show ("Chuyển bệnh nhân này sang điều trị nội trú?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    if (!thongtinCT.ChuyenLoaiKCB (ref err, dr["MA_LK"].ToString (), 3,"K03"))
                    {
                        XtraMessageBox.Show (err);
                        return;
                    }
                    LoadData ();
                }
            }
        }

        private void btnKeDonThuoc_Click (object sender, EventArgs e)
        {
            dr = gridView.GetFocusedDataRow ();
            if (dr != null)
            {
                if (dr["NGAY_RA"].ToString ().Length > 0)
                {
                    XtraMessageBox.Show ("Bệnh nhân này đã ra viện!");
                    return;
                }
                frmKeDon.MaLienKet = dr["MA_LK"].ToString ();
                frmKeDon.ShowDialog ();
            }
        }
    }
}
