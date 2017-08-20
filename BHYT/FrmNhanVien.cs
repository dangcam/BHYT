using BHYT.DAO;
using BHYT.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmNhanVien : Form
    {
        NhanVienDAO nhanvien = null;
        Connection db;
        public FrmNhanVien (Connection db)
        {
            InitializeComponent ();
            nhanvien = new NhanVienDAO (db);
            this.db = db;
        }
        private void LoadData ()
        {
            gridControl.DataSource = nhanvien.DSNhanVien ();
        }
        private void FrmNhanVien_Load (object sender, EventArgs e)
        {
            LoadData ();
        }

        private void bntNhapExcel_Click (object sender, EventArgs e)
        {
            DialogResult dr = ImportExcel.openDialog ();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DataTable data = ImportExcel.OpenFile ();
                    NhanVienVO nv;
                    foreach (DataRow dtRow in data.Rows)
                    {
                        nv = new NhanVienVO ();
                        nv.MaKhoa = dtRow[0].ToString ();
                        nv.MaNhanVien = dtRow[1].ToString ();
                        nv.TenNhanVien = dtRow[2].ToString ();
                        nv.TenVT = dtRow[3].ToString ();
                        nv.GioiTinh = int.Parse (dtRow[4].ToString ());
                        nv.NgaySinh = DateTime.ParseExact (dtRow[5].ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        nv.DiaChi = dtRow[6].ToString ();
                        nv.DienThoai = dtRow[7].ToString ();
                        nv.Email = dtRow[8].ToString ();
                        nv.HocHamHocVi = dtRow[9].ToString ();
                        nv.MaChuyeNganh = dtRow[10].ToString ();
                        nv.LoaiNV = dtRow[11].ToString ();
                        nv.ChucDanh = dtRow[12].ToString ();
                        nv.MaCCHN = dtRow[13].ToString ();
                        nv.NgayCapCCHN = DateTime.ParseExact (dtRow[14].ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        nv.NoiCapCCHN = dtRow[15].ToString ();
                        nv.TuNgay = DateTime.ParseExact (dtRow[16].ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        nv.DenNgay = DateTime.ParseExact (dtRow[17].ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        nv.VanBangCM = dtRow[18].ToString ();
                        nv.ThoiGianDK = dtRow[19].ToString ();
                        nv.KhoaBoPhan = dtRow[20].ToString ();
                        //
                        string err = "";
                        nhanvien.ThemNhanVien (ref err, nv);
                    }
                    LoadData ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DataRow dr = gridView.GetFocusedDataRow ();
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show ("Chắc chắn bạn muốn xóa hồ sơ này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                try
                {
                    string ma = dr[1].ToString ();
                    if (!nhanvien.XoaNhanVien (ref err, ma))
                    {
                        MessageBox.Show (err);
                    }
                    LoadData ();
                }
                catch { }
        }

        private void gridControl_DoubleClick (object sender, EventArgs e)
        {
            NhanVienVO nv = new NhanVienVO ();
            DataRow dr = gridView.GetFocusedDataRow ();
            nv.MaKhoa = dr[0].ToString ();
            nv.MaNhanVien = dr[1].ToString ();
            nv.TenNhanVien = dr[2].ToString ();
            nv.TenVT = dr[3].ToString ();
            nv.GioiTinh = int.Parse(dr[4].ToString ());
            nv.NgaySinh = DateTime.Parse (dr[5].ToString ());
            nv.DiaChi = dr[6].ToString ();
            nv.DienThoai = dr[7].ToString ();
            nv.Email = dr[8].ToString ();
            nv.HocHamHocVi = dr[9].ToString ();
            nv.MaChuyeNganh = dr[10].ToString ();
            nv.LoaiNV = dr[11].ToString ();
            nv.ChucDanh = dr[12].ToString ();
            nv.MaCCHN = dr[13].ToString ();
            nv.NgayCapCCHN = DateTime.Parse(dr[14].ToString ());
            nv.NoiCapCCHN = dr[15].ToString ();
            nv.TuNgay = DateTime.Parse (dr[16].ToString ());
            nv.DenNgay = DateTime.Parse (dr[17].ToString ());
            nv.VanBangCM = dr[18].ToString ();
            nv.ThoiGianDK = dr[19].ToString ();
            nv.KhoaBoPhan = dr[20].ToString ();
            FrmNV frmNV = new FrmNV (db,nv);
            frmNV.ShowDialog ();
            LoadData ();
        }

        private void btnMoi_Click (object sender, EventArgs e)
        {
            FrmNV frmNV = new FrmNV (db);
            frmNV.ShowDialog ();
            LoadData ();
        }
    }
}
