using BHYT.DAO;
using BHYT.VO;
using DevExpress.XtraReports.UI;
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
    public partial class FrmKeDon : Form
    {
        ThuocDAO thuoc;
        DataView dvTienThuoc = new DataView ();
        DataView dvTienDVKT = new DataView ();
        DataView dvTienVTYT = new DataView ();
        DataTable dataThuoc = null, dataDVKT = null, dataVTYT = null, dataBenh = null;
        THONGTIN_CTVO thongtinBN = new THONGTIN_CTVO ();
        THONGTIN_CTDAO thongtinCT = null;
        string maBenhChinh = "";
        public string MaLienKet { get; set; }
        Dictionary<string, string> duongdung = new Dictionary<string, string> ();
        string[] gioitinh = new string[] { "Nữ", "Nam" };
        System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 11);
        Dictionary<string, bool> dsThuoc = new Dictionary<string, bool> ();
        Dictionary<string, bool> dsDVKT = new Dictionary<string, bool> ();
        public FrmKeDon (Connection db)
        {
            InitializeComponent ();
            thuoc = new ThuocDAO (db);
            thongtinCT = new THONGTIN_CTDAO (db);
            searchLookUpEditView.Appearance.FocusedRow.BackColor = Color.FromArgb (128, 255, 128);
            searchLookUpEditView.Appearance.FocusedRow.Options.UseBackColor = true;
            searchLookUpEditView.Appearance.SelectedRow.BackColor = Color.FromArgb (128, 255, 128);
            searchLookUpEditView.Appearance.SelectedRow.Options.UseBackColor = true;
            duongdung = thongtinCT.DSDuongDung ().AsEnumerable ().ToDictionary<DataRow, string, string>
                (row => row.Field<string> (0), row => row.Field<string> (1));

           
        }

        private void lookUpMaBenh_EditValueChanged (object sender, EventArgs e)
        {
            object tmp = lookUpMaBenh.GetSelectedDataRow ();
            if (tmp is DataRowView)
            {
                txtTenBenh.Text = (tmp as DataRowView)[1].ToString ();
                maBenhChinh = (tmp as DataRowView)[0].ToString ();
                txtMaBenhKhac.Text = string.Empty;
            }
            else
            {
                txtTenBenh.Text = string.Empty;
                maBenhChinh = string.Empty;
                txtMaBenhKhac.Text = string.Empty;
            }
        }

        private void lookUpMaBenh_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lookUpMaBenhKhac.Focus ();
            }
        }

        private void lookUpMaBenhKhac_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (lookUpMaBenh.GetSelectedDataRow () != null)
                {
                    object tmp = lookUpMaBenhKhac.GetSelectedDataRow ();
                    if (tmp is DataRowView)
                    {
                        if (checkMaBenh ((tmp as DataRowView)[0].ToString ()))
                        {
                            txtTenBenh.Text = txtTenBenh.Text + "; " + (tmp as DataRowView)[1].ToString ();
                            txtMaBenhKhac.Text += string.IsNullOrEmpty (txtMaBenhKhac.Text) ? (tmp as DataRowView)[0].ToString () : ("; " + (tmp as DataRowView)[0].ToString ());
                        }
                        else
                        {
                            MessageBox.Show ("Mã bệnh đã được chọn");
                        }
                    }
                }
                else
                {
                    MessageBox.Show ("Vui lòng nhập bệnh chính trước.");
                    lookUpMaBenh.Focus ();
                    return;
                }
                lookUpMaBS.Focus ();
            }
        }

        private void txtMaBenhKhac_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty (maBenhChinh))
                {
                    List<string> listMa = new List<string> ();
                    DataView dv = dataBenh.AsEnumerable ().Where (r => r.Field<string> ("MA_BENH") == maBenhChinh).AsDataView ();
                    txtTenBenh.Text = (dv[0] as DataRowView)[1].ToString ();
                    foreach (string ma in txtMaBenhKhac.Text.Split (';'))
                    {
                        if (!listMa.Contains (ma.Trim ()) && ma.Trim () != maBenhChinh && !string.IsNullOrEmpty (ma.Trim ()))
                        {
                            dv = dataBenh.AsEnumerable ().Where (r => r.Field<string> ("MA_BENH") == ma.Trim ()).AsDataView ();
                            if (dv.Count > 0)
                            {
                                txtTenBenh.Text += "; " + (dv[0] as DataRowView)[1].ToString ();
                                listMa.Add (ma.Trim ());
                            }
                        }
                    }
                    txtMaBenhKhac.Text = string.Empty;
                    foreach (string ma in listMa)
                    {
                        txtMaBenhKhac.Text += string.IsNullOrEmpty (txtMaBenhKhac.Text) ? ma : ("; " + ma);
                    }
                    lookUpMaBS.Focus ();
                    return;
                }
                else
                {
                    lookUpMaBenh.Focus ();
                }
            }
        }

        private void lookUpMaBS_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lookUpLoaiChiPhi.Focus ();
            }
        }

        private void lookUpLoaiChiPhi_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSoLuong.Focus ();
            }
        }

        private void txtNgayUong_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtLanUong.Focus ();
            }
        }

        private void txtSoLuong_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNgayUong.Focus ();
            }
        }

        private void txtLanUong_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnChon.Focus ();
            }
        }

        private void btnChon_Click (object sender, EventArgs e)
        {
            if (lookUpMaBenh.EditValue.ToString ().Length < 1)
            {
                MessageBox.Show ("Vui lòng chọn mã bệnh!");
                lookUpMaBenh.Focus ();
                return;
            }
            if (lookUpMaBS.ItemIndex < 0)
            {
                MessageBox.Show ("Vui lòng chọn bác sĩ!");
                lookUpMaBS.Focus ();
                return;
            }
            if (cbLoaiChiPhi.SelectedIndex == 0)
            {
                try
                {
                    string maDichVu = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    string tenDV = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[1].ToString ();
                    string hamLuong = (lookUpLoaiChiPhi.GetSelectedDataRow() as DataRowView)[3].ToString();
                    foreach (DataRowView dr in (gridControlThuoc.DataSource as DataView))
                    {
                        if (dr["MA_THUOC"].ToString () == maDichVu && dr["TEN_THUOC"].ToString () == tenDV && hamLuong == dr["HAM_LUONG"].ToString())
                        {
                            MessageBox.Show ("Thuốc đã chọn, nhập lại số lượng!");
                            return;
                        }
                    }
                    DataRowView drNew = (gridControlThuoc.DataSource as DataView).AddNew ();
                    drNew["MA_THUOC"] = maDichVu;
                    drNew["TEN_THUOC"] = tenDV;
                    drNew["DON_GIA"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[8].ToString ();
                    drNew["DON_VI_TINH"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[7].ToString ();
                    drNew["HAM_LUONG"] = hamLuong;
                    drNew["DUONG_DUNG"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[4].ToString ();
                    drNew["SO_DANG_KY"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[9].ToString ();
                    drNew["NHOM"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[15].ToString ();
                    drNew["MA_KHOA"] = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["MA_BAC_SI"] = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["NGAY_YL"] = dateNgayYLenh.Text;
                    drNew["SO_LUONG"] = txtSoLuong.Value;
                    drNew["TYLE_TT"] = 100;
                    drNew["THANH_TIEN"] = txtSoLuong.Value * Convert.ToDecimal (drNew["DON_GIA"]);
                    drNew["LIEU_DUNG"] = "Ngày " + duongdung[drNew["DUONG_DUNG"].ToString ()].ToLower () + " " + txtNgayUong.Text +
                        " lần, lần " + txtLanUong.Text + " " + drNew["DON_VI_TINH"].ToString ().ToLower ();

                    lookUpLoaiChiPhi.Focus ();
                    txtSoLuong.ResetText ();
                    txtLanUong.ResetText ();
                    txtNgayUong.ResetText ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
            }
            else
            if(cbLoaiChiPhi.SelectedIndex == 1)
            {
                try
                {
                    string maDichVu = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[1].ToString ();
                    string tenDV = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[2].ToString ();
                    foreach (DataRowView dr in (gridControlDVKT.DataSource as DataView))
                    {
                        if (dr["MA_DICH_VU"].ToString () == maDichVu && dr["TEN_DICH_VU"].ToString () == tenDV)
                        {
                            MessageBox.Show ("Dịch vụ đã chọn, nhập lại số lượng!");
                            return;
                        }
                    }
                    DataRowView drNew = (gridControlDVKT.DataSource as DataView).AddNew ();
                    drNew["MA_DICH_VU"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[1].ToString ();
                    drNew["TEN_DICH_VU"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[2].ToString ();
                    drNew["DON_GIA"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[4].ToString ();
                    drNew["DON_VI_TINH"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[8].ToString ();
                    drNew["MA_NHOM"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["MA_KHOA"] = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["MA_BAC_SI"] = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["NGAY_YL"] = dateNgayYLenh.Text;
                    drNew["SO_LUONG"] = txtSoLuong.Value;
                    drNew["TYLE_TT"] = 100;
                    drNew["THANH_TIEN"] = txtSoLuong.Value * Convert.ToDecimal (drNew["DON_GIA"]);

                    lookUpLoaiChiPhi.Focus ();
                    txtSoLuong.ResetText ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
            }
            else
            {
                try
                {
                    string maDichVu = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    string tenDV = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[2].ToString ();
                    foreach (DataRowView dr in (gridControlVTYT.DataSource as DataView))
                    {
                        if (dr["MA_DICH_VU"].ToString () == maDichVu && dr["TEN_DICH_VU"].ToString () == tenDV)
                        {
                            MessageBox.Show ("Vật tư đã chọn, nhập lại số lượng!");
                            return;
                        }
                    }
                    DataRowView drNew = (gridControlVTYT.DataSource as DataView).AddNew ();
                    drNew["MA_DICH_VU"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["TEN_DICH_VU"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[2].ToString ();
                    drNew["DON_GIA"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[3].ToString ();
                    drNew["DON_VI_TINH"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[4].ToString ();
                    drNew["MA_NHOM"] = (lookUpLoaiChiPhi.GetSelectedDataRow () as DataRowView)[7].ToString ();
                    drNew["MA_KHOA"] = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["MA_BAC_SI"] = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    drNew["NGAY_YL"] = dateNgayYLenh.Text;
                    drNew["SO_LUONG"] = txtSoLuong.Value;
                    drNew["TYLE_TT"] = 100;
                    drNew["THANH_TIEN"] = txtSoLuong.Value * Convert.ToDecimal (drNew["DON_GIA"]);


                    lookUpLoaiChiPhi.Focus ();
                    txtSoLuong.ResetText ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
            }
        }

        private void btnXoaThuoc_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (gridControlThuoc.DataSource as DataView).Delete (gridViewThuoc.GetFocusedDataSourceRowIndex ());
        }

        private void txtSoLuong_ValueChanged (object sender, EventArgs e)
        {
            if (txtSoLuong.Value >= 150)
            {
                MessageBox.Show ("Số lượng thuốc lớn hơn 150!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInDon_Click (object sender, EventArgs e)
        {

            createReport ();
            Luu();
        }
        private void Luu()
        {
            string err = "";
            thongtinBN.MaBS = lookUpMaBS.EditValue.ToString();
            //thongtinBN.MucHuong
            //thongtinBN.TienThuoc = t_thuoc;
            //thongtinBN.TienTongChiPhi = thongtinBN.TienVTYT + t_thuoc;
            //thongtinBN.TienBNTT
            //thongtinBN.TienBHTT
            thongtinBN.MaKhoa = (lookUpMaKhoa.GetSelectedDataRow() as DataRowView)[0].ToString();
            thongtinBN.MaBenh = maBenhChinh;
            thongtinBN.MaBenhKhac = txtMaBenhKhac.Text;
            thongtinBN.TenBenh = txtTenBenh.Text;

            thongtinCT.SuaThongTinCT(ref err, thongtinBN);// cập nhật
            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err);
            }
            Thuoc_CTVO thuoc;
            foreach (DataRowView drView in dvTienThuoc)
            {
                thuoc = new Thuoc_CTVO();
                thuoc.MaLK = thongtinBN.MaLK;
                thuoc.MaThuoc = drView["MA_THUOC"].ToString();
                thuoc.TenThuoc = drView["TEN_THUOC"].ToString();
                thuoc.DonViTinh = drView["DON_VI_TINH"].ToString();
                thuoc.HamLuong = drView["HAM_LUONG"].ToString();
                thuoc.DuongDung = drView["DUONG_DUNG"].ToString();
                thuoc.LieuDung = drView["LIEU_DUNG"].ToString();
                thuoc.SoDK = drView["SO_DANG_KY"].ToString();
                thuoc.SoLuong = Utils.ToInt(drView["SO_LUONG"].ToString());
                thuoc.DonGia = Utils.ToInt(drView["DON_GIA"].ToString());
                thuoc.TyLeTT = 100;
                thuoc.ThanhTien = Utils.ToInt(drView["THANH_TIEN"].ToString());
                thuoc.MaKhoa = drView["MA_KHOA"].ToString();
                thuoc.MaBacSi = drView["MA_BAC_SI"].ToString();
                thuoc.MaBenh = maBenhChinh + ";" + thongtinBN.MaBenhKhac;
                if (drView["NGAY_YL"].ToString().Contains("/"))
                {
                    thuoc.NgayYL = DateTime.ParseExact(drView["NGAY_YL"].ToString(), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMddHHmm");
                }
                else
                {
                    thuoc.NgayYL = drView["NGAY_YL"].ToString();
                }
                thuoc.MaPTTT = 0;
                thuoc.Nhom = drView["NHOM"].ToString();
                err = "";

                if (dsThuoc.ContainsKey(thuoc.MaThuoc + "|" + thuoc.TenThuoc + "|" + thuoc.DonGia))
                {
                    thongtinCT.SuaThuocCT(ref err, thuoc); //sửa tiền thuốc
                    dsThuoc[thuoc.MaThuoc + "|" + thuoc.TenThuoc + "|" + thuoc.DonGia] = true;
                }
                else
                {
                    thongtinCT.ThemThuocCT(ref err, thuoc);// thêm tiền thuốc
                    dsThuoc.Add(thuoc.MaThuoc + "|" + thuoc.TenThuoc + "|" + thuoc.DonGia, true);
                }
                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show(err);
                }
            }

            List<string> keys = new List<string>(dsThuoc.Keys);
            foreach (var key in keys)
            {
                err = "";
                if (dsThuoc[key] == false)
                {
                    thongtinCT.XoaThuocCT(ref err, thongtinBN.MaLK, key.Split('|')[0], key.Split('|')[1],Utils.ToInt(key.Split('|')[2]));
                    dsThuoc.Remove(key);
                }
                else
                {
                    dsThuoc[key] = false;
                }
                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show(err);
                }
            }
            //
            DVKT_CTVO dvkt;
            foreach (DataRowView drView in dvTienDVKT) // dịch vụ kỹ thuật
            {
                dvkt = new DVKT_CTVO();
                dvkt.MaLK = thongtinBN.MaLK;
                dvkt.MaDichVu = drView["MA_DICH_VU"].ToString();
                dvkt.MaVatTu = drView["MA_VAT_TU"].ToString();
                dvkt.MaNhom = drView["MA_NHOM"].ToString();
                dvkt.TenDichVu = drView["TEN_DICH_VU"].ToString();
                dvkt.DonViTinh = drView["DON_VI_TINH"].ToString();
                dvkt.SoLuong = Convert.ToInt32(drView["SO_LUONG"].ToString());
                dvkt.DonGia = Convert.ToInt32(drView["DON_GIA"].ToString());
                dvkt.TyLeTT = 100;
                dvkt.ThanhTien = Convert.ToInt32(drView["THANH_TIEN"].ToString());
                dvkt.MaKhoa = drView["MA_KHOA"].ToString();
                dvkt.MaBacSi = drView["MA_BAC_SI"].ToString();
                dvkt.MaBenh = maBenhChinh + ";" + thongtinBN.MaBenhKhac;
                dvkt.KetQua = Utils.ToString(drView["KET_QUA"]);
                dvkt.MaNhomCLS = drView["MaNhom"].ToString();
                if (drView["NGAY_YL"].ToString().Contains("/"))
                {
                    dvkt.NgayYLenh = DateTime.ParseExact(drView["NGAY_YL"].ToString(), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMddHHmm");
                }
                else
                {
                    dvkt.NgayYLenh = drView["NGAY_YL"].ToString();
                }
                dvkt.NgayQK = dvkt.NgayYLenh;
                dvkt.MaPTTT = 0;
                //
                err = "";

                if (dsDVKT.ContainsKey(dvkt.MaDichVu))
                {
                    thongtinCT.SuaDVKTCT(ref err, dvkt);
                    dsDVKT[dvkt.MaDichVu] = true;
                }
                else
                {
                    thongtinCT.ThemDVKTCT(ref err, dvkt);
                    dsDVKT.Add(dvkt.MaDichVu, true);
                    if (!string.IsNullOrEmpty(err))
                    {
                        MessageBox.Show(err);
                    }
                }
            }
            foreach (DataRowView drView in dvTienVTYT) // vật tư y tế
            {
                dvkt = new DVKT_CTVO();
                dvkt.MaLK = thongtinBN.MaLK;
                dvkt.MaDichVu = drView["MA_DICH_VU"].ToString();
                dvkt.MaVatTu = drView["MA_VAT_TU"].ToString();
                dvkt.MaNhom = drView["MA_NHOM"].ToString();
                dvkt.TenDichVu = drView["TEN_DICH_VU"].ToString();
                dvkt.DonViTinh = drView["DON_VI_TINH"].ToString();
                dvkt.SoLuong = Convert.ToInt32(drView["SO_LUONG"].ToString());
                dvkt.DonGia = Convert.ToInt32(drView["DON_GIA"].ToString());
                dvkt.TyLeTT = 100;
                dvkt.ThanhTien = Convert.ToInt32(drView["THANH_TIEN"].ToString());
                dvkt.MaKhoa = drView["MA_KHOA"].ToString();
                dvkt.MaBacSi = drView["MA_BAC_SI"].ToString();
                dvkt.MaBenh = maBenhChinh + ";" + thongtinBN.MaBenhKhac;
                if (drView["NGAY_YL"].ToString().Contains("/"))
                {
                    dvkt.NgayYLenh = DateTime.ParseExact(drView["NGAY_YL"].ToString(), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMddHHmm");
                }
                else
                {
                    dvkt.NgayYLenh = drView["NGAY_YL"].ToString();
                }
                dvkt.NgayQK = dvkt.NgayYLenh;
                dvkt.MaPTTT = 0;
                //
                err = "";

                if (dsDVKT.ContainsKey(dvkt.MaDichVu))
                {
                    thongtinCT.SuaDVKTCT(ref err, dvkt);
                    dsDVKT[dvkt.MaDichVu] = true;
                }
                else
                {
                    thongtinCT.ThemDVKTCT(ref err, dvkt);
                    dsDVKT.Add(dvkt.MaDichVu, true);
                    if (!string.IsNullOrEmpty(err))
                    {
                        MessageBox.Show(err);
                    }
                }
            }
            keys = new List<string>(dsDVKT.Keys);
            foreach (var key in keys)
            {
                if (dsDVKT[key] == false)
                {
                    thongtinCT.XoaDVKTCT(ref err, thongtinBN.MaLK, key);
                    dsDVKT.Remove(key);
                }
                else
                {
                    dsDVKT[key] = false;
                }
            }
        }
        private bool checkMaBenh (string ma)
        {
            if (ma == maBenhChinh || txtMaBenhKhac.Text.Contains (ma))
            {
                return false;
            }
            return true;
        }

        private void gridViewThuoc_CellValueChanged (object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SO_LUONG")
            {
                this.gridViewThuoc.CellValueChanged -= new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler (this.gridViewThuoc_CellValueChanged);
                int index = gridViewThuoc.GetFocusedDataSourceRowIndex ();
                try
                {
                    int soluong = int.Parse ((gridControlThuoc.DataSource as DataView)[index]["SO_LUONG"].ToString ());
                    int dongia = int.Parse ((gridControlThuoc.DataSource as DataView)[index]["DON_GIA"].ToString ());
                    (gridControlThuoc.DataSource as DataView)[index]["THANH_TIEN"] = soluong * dongia;
                }
                catch { }
                this.gridViewThuoc.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler (this.gridViewThuoc_CellValueChanged);
            }
        }

        private void btnXoaDVKT_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (gridControlDVKT.DataSource as DataView).Delete (gridViewDVKT.GetFocusedDataSourceRowIndex ());
        }

        private void btnXoaVTYT_ButtonClick (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (gridControlVTYT.DataSource as DataView).Delete (gridViewVTYT.GetFocusedDataSourceRowIndex ());
        }

        private void gridViewDVKT_CellValueChanged (object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SO_LUONG")
            {
                this.gridViewDVKT.CellValueChanged -= new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler (this.gridViewDVKT_CellValueChanged);
                int index = gridViewDVKT.GetFocusedDataSourceRowIndex ();
                try
                {
                    int soluong = int.Parse ((gridControlDVKT.DataSource as DataView)[index]["SO_LUONG"].ToString ());
                    int dongia = int.Parse ((gridControlDVKT.DataSource as DataView)[index]["DON_GIA"].ToString ());
                    (gridControlDVKT.DataSource as DataView)[index]["THANH_TIEN"] = soluong * dongia;
                }
                catch { }
                this.gridViewDVKT.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler (this.gridViewDVKT_CellValueChanged);
            }
        }

        private void gridViewVTYT_CellValueChanged (object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SO_LUONG")
            {
                this.gridViewVTYT.CellValueChanged -= new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler (this.gridViewVTYT_CellValueChanged);
                int index = gridViewVTYT.GetFocusedDataSourceRowIndex ();
                try
                {
                    int soluong = int.Parse ((gridControlVTYT.DataSource as DataView)[index]["SO_LUONG"].ToString ());
                    int dongia = int.Parse ((gridControlVTYT.DataSource as DataView)[index]["DON_GIA"].ToString ());
                    (gridControlVTYT.DataSource as DataView)[index]["THANH_TIEN"] = soluong * dongia;
                }
                catch { }
                this.gridViewVTYT.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler (this.gridViewVTYT_CellValueChanged);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luu();
        }

        private void FrmKeDon_Load (object sender, EventArgs e)
        {
            dataThuoc = thuoc.DSThuoc ();
            dataDVKT = thuoc.DSDVKT ();
            dataVTYT = thuoc.DSVTYT ();
            cbLoaiChiPhi.SelectedIndex = 0;
            if (!string.IsNullOrEmpty (MaLienKet))
            {
                thongtinBN = thongtinCT.getThongTin (MaLienKet);
                if (thongtinBN != null)
                {
                    lookUpMaKhoa.Properties.DataSource = thuoc.DSKhoa ();
                    lookUpMaKhoa.Properties.DisplayMember = "TEN_KHOA";
                    lookUpMaKhoa.Properties.ValueMember = "MA_KHOA";
                    lookUpMaKhoa.EditValue = thongtinBN.MaKhoa;

                    lookUpMaBS.Properties.DataSource = thuoc.DSNhanVien ();
                    lookUpMaBS.Properties.DisplayMember = "TEN_NHANVIEN";
                    lookUpMaBS.Properties.ValueMember = "MA_NHANVIEN";

                    dataBenh = thongtinCT.DSBenh ();

                    lookUpMaBenh.Properties.DataSource = dataBenh;
                    lookUpMaBenh.Properties.DisplayMember = "MA_BENH";
                    lookUpMaBenh.Properties.ValueMember = "MA_BENH";


                    lookUpMaBenhKhac.Properties.DataSource = dataBenh;
                    lookUpMaBenhKhac.Properties.DisplayMember = "MA_BENH";
                    lookUpMaBenhKhac.Properties.ValueMember = "MA_BENH";
                    lookUpMaBenhKhac.EditValue = null;
                    if (thongtinBN.MaBS != "")
                    {
                        lookUpMaBS.EditValue = thongtinBN.MaBS;
                    }


                    //
                    txtTenBenh.Text = thongtinBN.TenBenh;
                    txtMaBenhKhac.Text = thongtinBN.MaBenhKhac;
                    lookUpMaBenh.EditValue = thongtinBN.MaBenh;
                    txtHoTen.Text = thongtinBN.HoTen;
                    //
                    dvTienThuoc = thongtinCT.DSNhomThuoc (thongtinBN.MaLK).AsDataView ();
                    gridControlThuoc.DataSource = dvTienThuoc;
                    dvTienDVKT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK).AsDataView ();
                    gridControlDVKT.DataSource = dvTienDVKT;
                    dvTienVTYT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "10").AsDataView ();
                    gridControlVTYT.DataSource = dvTienVTYT;
                    dsThuoc.Clear ();
                    dsDVKT.Clear ();
                    
                    foreach (DataRowView drView in dvTienThuoc)
                    {

                        dsThuoc.Add (drView["MA_THUOC"].ToString () + "|" + drView["TEN_THUOC"] + "|" + drView["DON_GIA"], false);
                    }
                    foreach(DataRowView drView in dvTienDVKT)
                    {
                        dsDVKT.Add(drView["MA_DICH_VU"].ToString (), false);
                    }
                    foreach (DataRowView drView in dvTienVTYT)
                    {
                        dsDVKT.Add (drView["MA_DICH_VU"].ToString (), false);
                    }
                }
            }
            this.ActiveControl = lookUpMaBenh;
            txtSoLuong.ResetText ();
        }

        private void cbLoaiChiPhi_SelectedIndexChanged (object sender, EventArgs e)
        {
            this.searchLookUpEditView.Columns.Clear ();
            if (cbLoaiChiPhi.SelectedIndex == 0)
            {

                this.searchLookUpEditView.Columns.AddRange (new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaThuoc,
                this.gridCThuoc,
                this.HamLuong,
                this.gridCDonGia});
                this.MaThuoc.Visible = true;
                this.MaThuoc.VisibleIndex = 0;
                this.MaThuoc.Width = 40;
                this.gridCThuoc.Visible = true;
                this.gridCThuoc.VisibleIndex = 1;
                this.gridCThuoc.Width = 160;
                this.HamLuong.Visible = true;
                this.HamLuong.VisibleIndex = 2;
                this.HamLuong.Width = 60;
                this.gridCDonGia.Visible = true;
                this.gridCDonGia.VisibleIndex = 3;
                this.gridCDonGia.Width = 40;

                lookUpLoaiChiPhi.Properties.DataSource = dataThuoc;
                lookUpLoaiChiPhi.Properties.DisplayMember = "TEN_THUOC";

            }
            else
            if (cbLoaiChiPhi.SelectedIndex == 1)
            {

                this.searchLookUpEditView.Columns.AddRange (new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaDVKT,
                this.TenDVKT,
                this.gridCDonGia});
                this.MaDVKT.Visible = true;
                this.MaDVKT.VisibleIndex = 0;
                this.MaDVKT.Width = 40;
                this.TenDVKT.Visible = true;
                this.TenDVKT.VisibleIndex = 1;
                this.TenDVKT.Width = 160;
                this.gridCDonGia.Visible = true;
                this.gridCDonGia.VisibleIndex = 2;
                this.gridCDonGia.Width = 50;


                lookUpLoaiChiPhi.Properties.DataSource = dataDVKT;
                lookUpLoaiChiPhi.Properties.DisplayMember = "TEN_DVKT";
            }
            else
            {
                this.searchLookUpEditView.Columns.AddRange (new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.MaVTYT,
                this.TenVTYT,
                this.gridCDonGia,
                this.TenBV});
                this.MaVTYT.Visible = true;
                this.MaVTYT.VisibleIndex = 0;
                this.MaVTYT.Width = 40;
                this.TenVTYT.Visible = true;
                this.TenVTYT.VisibleIndex = 1;
                this.TenVTYT.Width = 160;
                this.gridCDonGia.Visible = true;
                this.gridCDonGia.VisibleIndex = 2;
                this.gridCDonGia.Width = 40;
                this.TenBV.Visible = true;
                this.TenBV.VisibleIndex = 3;
                this.TenBV.Width = 160;

                lookUpLoaiChiPhi.Properties.DataSource = dataVTYT;
                lookUpLoaiChiPhi.Properties.DisplayMember = "TEN_VTYT";
            }
        }
        private void createReport ()
        {
            string[] gioitinh = new string[] { "Nữ", "Nam" };
            rptDonThuoc rpt = new rptDonThuoc ();
            rpt.lblSoHoSo.Text = thongtinBN.MaBN;
            rpt.lblHoTen.Text = thongtinBN.HoTen;
            rpt.lblGioiTinh.Text = "Giới tính: " + gioitinh[thongtinBN.GioiTinh];
            rpt.lblNgaySinh.Text = "Năm sinh: " + Utils.ParseDate (thongtinBN.NgaySinh, true);
            rpt.lblNgheNghiep.Text = "";
            rpt.lblDiaChi.Text = thongtinBN.DiaChi;
            rpt.lblSoThe.Text = thongtinBN.MaThe;
            rpt.lblKCB.Text = thongtinBN.MaDKBD + " - " + thongtinCT.getCoSoKCB(thongtinBN.MaDKBD).Ten;
            rpt.lblHanDung.Text = Utils.ParseDate (thongtinBN.GtTheTu, true) + " đến " + Utils.ParseDate (thongtinBN.GtTheDen, true);
            rpt.lblDinhBenh.Text = txtTenBenh.Text;
            rpt.lblNgayTT.Text ="Ngày "+ DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblBacSi.Text = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[1].ToString ();
            rpt.xrTable.Rows.Clear ();
            //
            rpt.lblSoHoSo1.Text = thongtinBN.MaBN;
            rpt.lblHoTen1.Text = thongtinBN.HoTen;
            rpt.lblGioiTinh1.Text = "Giới tính: " + gioitinh[thongtinBN.GioiTinh];
            rpt.lblNgaySinh1.Text = rpt.lblNgaySinh.Text;
            rpt.lblNgheNghiep1.Text = "";
            rpt.lblDiaChi1.Text = thongtinBN.DiaChi;
            rpt.lblSoThe1.Text = thongtinBN.MaThe;
            rpt.lblKCB1.Text = rpt.lblKCB.Text;
            rpt.lblHanDung1.Text = rpt.lblHanDung.Text;
            rpt.lblDinhBenh1.Text = txtTenBenh.Text;
            rpt.lblNgayTT1.Text = rpt.lblNgayTT.Text;
            rpt.lblBacSi1.Text = rpt.lblBacSi.Text;
            rpt.xrTable1.Rows.Clear ();
            //
            try
            {
                rpt.lblCoSoKCB.Text = thongtinCT.getCoSoKCB (AppConfig.CoSoKCB).Ten.ToUpper ();
                rpt.lableCoSoKCB.Text = rpt.lblCoSoKCB.Text;
            }
            catch { }

            //
            XRTableRow row;
            XRTableCell cell;
            int i = 1;
            foreach (DataRowView drv in dvTienThuoc)
            {
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

                rpt.xrTable.Rows.Add (row);
                //
                row = new XRTableRow ();
                row.HeightF = 30;
                cell = new XRTableCell ();
                cell.WidthF = 84;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = drv["LIEU_DUNG"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 416;
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
                cell.Text = drv["LIEU_DUNG"].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 416;
                row.Cells.Add (cell);

                rpt.xrTable1.Rows.Add (row);
                //
                i++;
            }
            rpt.xrTable1 = rpt.xrTable;
            rpt.CreateDocument ();

            rpt.ShowPreviewDialog ();
        }

    }
}
