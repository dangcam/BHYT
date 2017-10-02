using BHYT.DAO;
using BHYT.VO;
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
    }
}
