using BHYT.DAO;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmDSTiepNhan : Form
    {
        FrmKeDon frmKeDon;
        FrmChiDinhCLS frmChiDinh;
        DataTable dt = null;
        THONGTIN_CTDAO thongtinCT = null;
        DataRow dr = null;
        public FrmDSTiepNhan (Connection db)
        {
            InitializeComponent ();
            thongtinCT = new THONGTIN_CTDAO (db);
            frmKeDon = new FrmKeDon (db);
            frmChiDinh = new FrmChiDinhCLS(db);
        }

        private void FrmDSTiepNhan_Load (object sender, EventArgs e)
        {
            if (AppConfig.SoPhong == 1)
                btnPhongKham1.Enabled = false;
            if (AppConfig.SoPhong == 2)
                btnPhongKham2.Enabled = false;
            if (AppConfig.SoPhong == 3)
                btnPhongKham3.Enabled = false;
            if (AppConfig.SoPhong == 4)
                btnPhongKham4.Enabled = false;
            cbTinhTrang.SelectedIndex = 1;
            dateTu.Value = DateTime.Now;
            dateDen.Value = DateTime.Now;
            LoadData ();
        }
        private void LoadData ()
        {
            string ngayBD = DateTime.ParseExact (dateTu.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            string ngayKT = DateTime.ParseExact (dateDen.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            dt = thongtinCT.DSTiepNhan (ngayBD, ngayKT, 0, cbTinhTrang.SelectedIndex, "1");

            if (dt != null)
            {
                lblPhongKham1.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 1").ToString ();
                lblPhongKham2.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 2").ToString ();
                lblPhongKham3.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 3").ToString ();
                lblPhongKham4.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 4").ToString ();
            }
            if (AppConfig.SoPhong != 0)
            {
                try
                {
                    gridControl.DataSource = dt.Select ("PHONG = " + AppConfig.SoPhong).CopyToDataTable ();
                }
                catch
                {
                    gridControl.DataSource = null;
                }
            }
            else
            {
                gridControl.DataSource = dt;
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
            if (dr != null)
            {
                if (dr["NGAY_RA"].ToString ().Length > 0)
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
                    if (!thongtinCT.ChuyenLoaiKCB (ref err, dr["MA_LK"].ToString (), 3, "K03"))
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
                LoadData ();
            }
        }

        private void btnPhongKham1_Click (object sender, EventArgs e)
        {
            ChuyenPhong (0);
        }

        private void btnPhongKham2_Click (object sender, EventArgs e)
        {
            ChuyenPhong (1);
        }

        private void btnPhongKham3_Click (object sender, EventArgs e)
        {
            ChuyenPhong (2);
        }

        private void btnPhongKham4_Click (object sender, EventArgs e)
        {
            ChuyenPhong (3);
        }
        private void ChuyenPhong (int soPhong)
        {
            DialogResult traloi;
            traloi = XtraMessageBox.Show ("Chuyển bệnh nhân này sang phòng: "+(soPhong+1), "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                dr = gridView.GetFocusedDataRow ();
                if (dr != null)
                {
                    if (dr["MA_BENH"] != null && dr["MA_BENH"].ToString ().Length > 0)
                    {
                        XtraMessageBox.Show ("Bệnh nhân đã khám!!!");
                        return;
                    }
                    string maLK = dr["MA_LK"].ToString ();
                    string err = "";
                    if (!thongtinCT.ChuyenPhongKCB (ref err, maLK, soPhong))
                    {
                        XtraMessageBox.Show (err, "Lỗi");
                        return;
                    }
                    LoadData ();
                }
            }
        }

        private void btnCanLamSan_Click(object sender, EventArgs e)
        {
            dr = gridView.GetFocusedDataRow();
            if (dr != null)
            {
                if (dr["NGAY_RA"].ToString().Length > 0)
                {
                    XtraMessageBox.Show("Bệnh nhân này đã ra viện!");
                    return;
                }
                frmChiDinh.MaLienKet = dr["MA_LK"].ToString();
                frmChiDinh.HoTen = dr["HO_TEN"].ToString();
                frmChiDinh.ShowDialog();
            }
        }
    }
}
