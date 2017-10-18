using BHYT.DAO;
using BHYT.VO;
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
    public partial class FrmThuoc : Form
    {
        ThuocDAO thuoc;
        Connection db;
        public FrmThuoc (Connection db)
        {
            InitializeComponent ();
            thuoc = new ThuocDAO (db);
            this.db = db;
        }
        private void LoadData()
        {
            gridControl.DataSource = thuoc.DSTienThuoc ();
        }
        private void FrmThuoc_Load (object sender, EventArgs e)
        {
            LoadData ();
            lookUpDonViTinh.DataSource = thuoc.DSDuongDung ();
            lookUpDonViTinh.DisplayMember = "DUONG_DUNG";
            lookUpDonViTinh.ValueMember = "MA_DUONG_DUNG";
        }

        private void bntNhapExcel_Click (object sender, EventArgs e)
        {
            DialogResult dr = ImportExcel.openDialog ();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DataTable data = ImportExcel.OpenFile ();
                    //ThuocVO t;
                    TienThuocVO tien;
                    foreach (DataRow dtRow in data.Rows)
                    {
                        // luu vào bảng THUOC
                        //t = new ThuocVO ();
                        //t.MaHoatChat = dtRow[1].ToString ();
                        //t.HoatChat = dtRow[2].ToString ();
                        //t.MaDuongDung = dtRow[3].ToString ();
                        //t.DuongDung = dtRow[4].ToString ();
                        //t.HamLuong = dtRow[5].ToString ();
                        //t.TenThuoc= dtRow[6].ToString ();
                        //t.SoDangKy = dtRow[7].ToString ();
                        //t.DongGoi= dtRow[8].ToString ();
                        //t.DonViTinh = dtRow[9].ToString ();
                        //try
                        //{
                        //    t.DonGia = int.Parse(dtRow[10].ToString ().Replace(".",string.Empty));
                        //}
                        //catch { t.DonGia = 0; }
                        //try
                        //{
                        //    t.DonGiaTT = int.Parse (dtRow[11].ToString ().Replace (".", string.Empty));
                        //}
                        //catch { t.DonGiaTT = 0; }
                        //try
                        //{
                        //    t.SoLuong = int.Parse(dtRow[12].ToString ().Replace (".", string.Empty));
                        //}
                        //catch { t.SoLuong = 0; }
                        //t.MaCSKCB = dtRow[13].ToString ();
                        //t.HangSX = dtRow[14].ToString ();
                        //t.NuocSX = dtRow[15].ToString ();
                        //t.NhaThau = dtRow[16].ToString ();
                        //t.QuyetDinh = dtRow[17].ToString ();
                        //t.CongBo = dtRow[18].ToString ();
                        //t.MaThuocBV = dtRow[19].ToString ();
                        //t.MaNhom = dtRow[20].ToString ();
                        //t.LoaiThau = dtRow[21].ToString ();
                        //t.NhomThau = dtRow[22].ToString ();
                        // file tải từ web về, lưu vào bảng TIEN_THUOC
                        //tien = new TienThuocVO ();
                        //tien.MaThuoc = dtRow[1].ToString ();
                        //tien.TenThuoc = dtRow[2].ToString ();
                        //tien.HoatChat = dtRow[3].ToString ();
                        //tien.HamLuong = dtRow[4].ToString ();
                        //tien.DuongDung = dtRow[5].ToString ();
                        //tien.QuyCach = dtRow[6].ToString ();
                        //tien.TieuChuan = dtRow[7].ToString ();
                        //tien.DonViTinh = dtRow[8].ToString ();
                        //try
                        //{
                        //    tien.DonGia = int.Parse (dtRow[9].ToString ().Replace (",", ""));
                        //}
                        //catch { tien.DonGia = 0; }
                        //tien.SoDK = dtRow[10].ToString ();
                        //tien.QuyetDinh = dtRow[11].ToString ();
                        //tien.NhaSX = dtRow[12].ToString ();
                        //tien.NuocSX = dtRow[13].ToString ();
                        //tien.HanDung = dtRow[14].ToString ();
                        //try
                        //{
                        //    tien.NhomThuoc = dtRow[15].ToString ();
                        //}
                        //catch
                        //{
                        //    tien.NhomThuoc = "1";
                        //}
                        //try
                        //{
                        //    tien.Nhom = dtRow[16].ToString ();
                        //}
                        //catch
                        //{
                        //    tien.Nhom = "4";
                        //}
                    // file chị Trà My gửi, lưu vào bảng TIEN_THUOC
                    tien = new TienThuocVO ();
                    tien.MaThuoc = dtRow[1].ToString ();
                    tien.TenThuoc = dtRow[6].ToString ();
                    tien.HoatChat = dtRow[2].ToString ();
                    tien.HamLuong = dtRow[5].ToString ();
                    tien.DuongDung = dtRow[3].ToString ();
                    tien.QuyCach = dtRow[8].ToString ();
                    tien.TieuChuan = "";//dtRow[6].ToString ();
                    tien.DonViTinh = dtRow[9].ToString ();
                    try
                    {
                        tien.DonGia = int.Parse (dtRow[10].ToString ().Replace (",", ""));
                    }
                    catch { tien.DonGia = 0; }
                    tien.SoDK = dtRow[7].ToString ();
                    tien.QuyetDinh = dtRow[17].ToString ();
                    tien.NhaSX = dtRow[14].ToString ();
                    tien.NuocSX = dtRow[15].ToString ();
                    tien.HanDung = dtRow[18].ToString ();
                    tien.NhomThuoc = dtRow[20].ToString ();
                    tien.Nhom = "4";//dtRow[21].ToString ();
                    tien.TinhTrang = true;
                    //
                    string err = "";
                    thuoc.ThemTienThuoc (ref err, tien);
                        if(!string.IsNullOrEmpty(err))
                        {
                            MessageBox.Show (err);
                        }
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
            traloi = MessageBox.Show ("Chắc chắn bạn muốn xóa thuốc này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                try
                {
                    string ma = dr[0].ToString ();
                    string ten = dr[1].ToString ();
                    int gia = Convert.ToInt32(dr[8].ToString ());
                    if (!thuoc.XoaThuoc (ref err, ma, ten, gia))
                    {
                        MessageBox.Show (err);
                    }
                    LoadData ();
                }
                catch { }
        }

        private void btnItemXoa_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string err = "";
                DataRow dr = gridView.GetFocusedDataRow ();
                string ma = dr[0].ToString ();
                string ten = dr[1].ToString ();
                int gia = Convert.ToInt32 (dr[8].ToString ());
                if (!thuoc.XoaThuoc (ref err, ma, ten, gia))
                {
                    MessageBox.Show (err);
                    return;
                }
                (gridView.DataSource as DataView).Delete (gridView.GetFocusedDataSourceRowIndex ());
            }
            catch { }
        }

        private void gridView_RowUpdated (object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            int index = gridView.GetFocusedDataSourceRowIndex ();
            try
            {
                string err = "";
                string maThuoc = (gridView.DataSource as DataView)[index]["MA_THUOC"].ToString ();
                string tenThuoc = (gridView.DataSource as DataView)[index]["TEN_THUOC"].ToString ();
                int donGia = int.Parse ((gridView.DataSource as DataView)[index]["DON_GIA"].ToString ());
                bool tinhTrang = bool.Parse ((gridView.DataSource as DataView)[index]["TINH_TRANG"].ToString ());
                if (!thuoc.SuaTinhTrangThuoc (ref err, maThuoc, tenThuoc, donGia,tinhTrang))
                {
                    MessageBox.Show (err);
                    return;
                }
            }
            catch { }
        }

        private void btnThem_Click (object sender, EventArgs e)
        {
            FrmThemThuoc frm = new FrmThemThuoc (db);
            frm.ShowDialog ();
            LoadData ();
        }
    }
}
