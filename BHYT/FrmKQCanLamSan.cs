using BHYT.DAO;
using BHYT.MauSo;
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
    public partial class FrmKQCanLamSan : Form
    {
        THONGTIN_CTDAO thongtinCT;
        DataView dt;
        Dictionary<string, bool> dsDVKT = new Dictionary<string, bool>();
        public FrmKQCanLamSan(Connection db)
        {
            InitializeComponent();
            thongtinCT = new THONGTIN_CTDAO(db);
            lookUpBacSi.Properties.DataSource = thongtinCT.DSNhanVien();
            lookUpBacSi.Properties.ValueMember = "MA_NHANVIEN";
            lookUpBacSi.Properties.DisplayMember = "TEN_NHANVIEN";
            lookUpDVKT.Properties.DisplayMember = "TEN_DICH_VU";
            //
            lookUpMaKhoa.Properties.DataSource = thongtinCT.DSKhoa();
            lookUpMaKhoa.Properties.DisplayMember = "TEN_KHOA";
            lookUpMaKhoa.Properties.ValueMember = "MA_KHOA";
        }
        public string MaLK { get; set; }
        public string HoTen { get; set; }
        public string YeuCau { get; set; }
        public string ChuanDoan { get; set; }
        public string CanLamSan { get; set; }
        public string NhomChinh { get; set; }
        public string MaNhomChiDinh { get; set; }
        public string MauSo { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoThe { get; set; }
        private string ketQua = "";
        private void FrmKQCanLamSan_Load(object sender, EventArgs e)
        {
            if (lookUpBacSi.ItemIndex < 0)
            {
                lookUpBacSi.ItemIndex = 0;
            }
            if (lookUpMaKhoa.ItemIndex < 0)
            {
                lookUpMaKhoa.ItemIndex = 0;
            }
            this.ActiveControl = this.lookUpDVKT;
            txtHoTen.Text = HoTen;
            txtChuanDoan.Text = this.ChuanDoan;
            txtYeuCau.Text = this.YeuCau;
            txtCanLanSan.Text = this.CanLamSan;
            dt = thongtinCT.DSDVKTCLS(this.MaLK, this.MaNhomChiDinh).AsDataView();

            lookUpDVKT.Properties.DataSource = thongtinCT.DSDVKT(this.NhomChinh);
            lookUpDVKT.Properties.DisplayMember = "TEN_DVKT";

            gridControlDVKT.DataSource = dt;
            txtSoLuong.EditValue = 1;
            txtKetQua.Text = "Bình thường";
            //
            dsDVKT.Clear();
            foreach (DataRowView drView in dt)
            {
                dsDVKT.Add(drView["MA_DICH_VU"].ToString(), false);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LuuKetQua();
        }

        private void lookUpDVKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtKetQua.Focus();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                btnChon.Focus();
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drView = (lookUpDVKT.GetSelectedDataRow() as DataRowView);
                string maDichVu = drView["MA_DVKT"].ToString();
                string tenDV = drView["TEN_DVKT"].ToString();
                foreach (DataRowView dr in (gridControlDVKT.DataSource as DataView))
                {
                    if (dr["MA_DICH_VU"].ToString() == maDichVu && dr["TEN_DICH_VU"].ToString() == tenDV)
                    {
                        MessageBox.Show("Dịch vụ đã chọn, nhập lại số lượng!");
                        return;
                    }
                }
                DataRowView drNew = (gridControlDVKT.DataSource as DataView).AddNew();
                drNew["MA_DICH_VU"] = maDichVu;
                drNew["TEN_DICH_VU"] = tenDV;
                drNew["DON_GIA"] = drView["DON_GIA"].ToString();
                drNew["DON_VI_TINH"] = drView["DON_VI_TINH"].ToString();
                drNew["MA_NHOM"] = drView["MA_NHOM"].ToString();
                drNew["MA_KHOA"] = (lookUpMaKhoa.GetSelectedDataRow() as DataRowView)[0].ToString();
                drNew["MA_BAC_SI"] = (lookUpBacSi.GetSelectedDataRow() as DataRowView)[0].ToString();
                drNew["NGAY_YL"] = DateTime.Now.ToString("yyyyMMddHHmm");
                drNew["SO_LUONG"] = txtSoLuong.Text;
                drNew["TYLE_TT"] = 100;
                drNew["THANH_TIEN"] =Utils.ToInt(txtSoLuong.Text,1) * Convert.ToDecimal(drNew["DON_GIA"]);
                drNew["KET_QUA"] = txtKetQua.Text;
                drNew["MaNhom"] = this.MaNhomChiDinh;
                lookUpDVKT.Focus();
                txtSoLuong.EditValue = 1;
                txtKetQua.Text = "Bình thường";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaDVKT_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (gridControlDVKT.DataSource as DataView).Delete(gridViewDVKT.GetFocusedDataSourceRowIndex());
        }
        private void LuuKetQua()
        {
            string err = "";
            ketQua = "";
            DVKT_CTVO dvkt;
            foreach (DataRowView drView in dt) // dịch vụ kỹ thuật
            {
                dvkt = new DVKT_CTVO();
                dvkt.MaLK = this.MaLK;
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
                dvkt.MaBenh = "";
                dvkt.KetQua = Utils.ToString(drView["KET_QUA"]);
                dvkt.MaNhomCLS = drView["MaNhom"].ToString();
                dvkt.NgayYLenh = drView["NGAY_YL"].ToString();
                dvkt.NgayQK = dvkt.NgayYLenh;
                dvkt.MaPTTT = 0;
                dvkt.MaNhomCLS = drView["MaNhom"].ToString();
                ketQua = ketQua == "" ? dvkt.KetQua : ketQua + "; "+dvkt.KetQua;
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
            List<string> keys = new List<string>(dsDVKT.Keys);
            keys = new List<string>(dsDVKT.Keys);
            foreach (var key in keys)
            {
                if (dsDVKT[key] == false)
                {
                    thongtinCT.XoaDVKTCT(ref err, this.MaLK, key);
                    dsDVKT.Remove(key);
                }
                else
                {
                    dsDVKT[key] = false;
                }
            }
        }

        private void txtKetQua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                btnChon.Focus();
            }
        }

        private void txtKetQua_Enter(object sender, EventArgs e)
        {
            txtKetQua.SelectAll();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            LuuKetQua();
            creatReport();
        }
        private void creatReport()
        {
            switch (MauSo)
            {
                case "19":
                    MauSo19();
                    break;
                case "22":
                    MauSo22();
                    break;
                case "23":
                    MauSo23();
                    break;
                case "25":
                    MauSo25();
                    break;
                case "27":
                    MauSo27();
                    break;
                case "28":
                    MauSo28();
                    break;
                case "33":
                    MauSo33();
                    break;
                case "340":
                    MauSo340();
                    break;
                case "341":
                    MauSo341();
                    break;
                case "342":
                    MauSo342();
                    break;
            }
        }
        private void MauSo19()
        {
            rptMauSo_19 rpt = new rptMauSo_19();

            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblYeuCau.Text = this.YeuCau;
            rpt.lblNgay.Text = "Ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.cellKetQua.Text = ketQua;
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo22()
        {
            rptMauSo_22 rpt = new rptMauSo_22();
            rpt.lblMauSo.Text = "MS: "+this.MauSo+"/BV-01";
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblYeuCau.Text = this.YeuCau;
            rpt.lblNgay.Text = "Ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.lblKetQua.Text = ketQua;
            rpt.lblKhoa.Text = lookUpMaKhoa.Properties.GetDisplayValueByKeyValue(lookUpMaKhoa.EditValue).ToString();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo23()
        {
            rptMauSo_23 rpt = new rptMauSo_23();
            rpt.lblMauSo.Text = "MS: " + this.MauSo + "/BV-01";
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblYeuCau.Text = this.YeuCau;
            rpt.lblNgay.Text = "Ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.lblKetQua.Text = ketQua;
            rpt.lblKhoa.Text = lookUpMaKhoa.Properties.GetDisplayValueByKeyValue(lookUpMaKhoa.EditValue).ToString();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo25()
        {
            rptMauSo_25 rpt = new rptMauSo_25();
            rpt.lblHoTenBS.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblYeuCau.Text = this.YeuCau;
            rpt.lblNgay.Text = "Ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.lblKetQua.Text = ketQua;
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo27()
        {
            rptMauSo_27 rpt = new rptMauSo_27();

            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblYeuCau.Text = this.YeuCau;
            rpt.lblNgay.Text = "Ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.cellKetQua.Text = ketQua;
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo28()
        {
            rptMauSo_28 rpt = new rptMauSo_28();
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblDiaChi.Text = this.DiaChi;
            rpt.lblSoThe.Text = this.SoThe;
            rpt.lblNgay.Text =DateTime.Now.Hour+" giờ "+DateTime.Now.Minute + " ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.lblKhoa.Text = lookUpMaKhoa.Properties.GetDisplayValueByKeyValue(lookUpMaKhoa.EditValue).ToString();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo33()
        {
            rptMauSo_33 rpt = new rptMauSo_33();
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblDiaChi.Text = this.DiaChi;
            rpt.lblSoThe.Text = this.SoThe;
            rpt.lblNgay.Text = DateTime.Now.Hour + " giờ " + DateTime.Now.Minute + " ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.lblKhoa.Text = lookUpMaKhoa.Properties.GetDisplayValueByKeyValue(lookUpMaKhoa.EditValue).ToString();
            foreach(DataRowView dr in dt)
            {
                switch(dr["MA_DICH_VU"].ToString())
                {
                    case "23.0166.1494":
                        rpt.cellUre.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0075.1494":
                        rpt.cellGluco.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0051.1494":
                        rpt.cellCrea.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0003.1494":
                        rpt.cellAcid.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0041.1506":
                        rpt.cellCholes.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0158.1506":
                        rpt.cellTrigly.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0084.1506":
                        rpt.cellHDL.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0112.1506":
                        rpt.cellLDL.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0020.1493":
                        rpt.cellAST.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0019.1493":
                        rpt.cellALT.Text = dr["KET_QUA"].ToString();
                        break;
                    case "23.0077.1518":
                        rpt.cellGGT.Text = dr["KET_QUA"].ToString();
                        break;
                }
            }
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo340()
        {
            rptMauSo_340 rpt = new rptMauSo_340();
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblDiaChi.Text = this.DiaChi;
            rpt.lblSoThe.Text = this.SoThe;
            rpt.lblNgay.Text = DateTime.Now.Hour + " giờ " + DateTime.Now.Minute + " ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.lblKhoa.Text = lookUpMaKhoa.Properties.GetDisplayValueByKeyValue(lookUpMaKhoa.EditValue).ToString();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo341()
        {
            rptMauSo_341 rpt = new rptMauSo_341();
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblDiaChi.Text = this.DiaChi;
            rpt.lblSoThe.Text = this.SoThe;
            rpt.lblNgay.Text = DateTime.Now.Hour + " giờ " + DateTime.Now.Minute + " ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.lblKhoa.Text = lookUpMaKhoa.Properties.GetDisplayValueByKeyValue(lookUpMaKhoa.EditValue).ToString();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
        private void MauSo342()
        {
            rptMauSo_342 rpt = new rptMauSo_342();
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh;
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblChuanDoan.Text = this.ChuanDoan;
            rpt.lblDiaChi.Text = this.DiaChi;
            rpt.lblSoThe.Text = this.SoThe;
            rpt.lblNgay.Text = DateTime.Now.Hour + " giờ " + DateTime.Now.Minute + " ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblHoTenBS.Text = "Họ tên: " + lookUpBacSi.Properties.GetDisplayValueByKeyValue(lookUpBacSi.EditValue);
            rpt.lblKhoa.Text = lookUpMaKhoa.Properties.GetDisplayValueByKeyValue(lookUpMaKhoa.EditValue).ToString();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}
