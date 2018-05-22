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
    public partial class FrmKQKhamSucKhoe : Form
    {
        KhamSucKhoeVO khamSucKhoeVO = new KhamSucKhoeVO();
        KhamSucKhoeDAO khamSucKhoeDAO;
        DataTable dataThongTin,dataKhamSucKhoe;
        public FrmKQKhamSucKhoe()
        {
            InitializeComponent();
            khamSucKhoeDAO = new KhamSucKhoeDAO();
        }
        public string MaLienKet { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string TheBHYT { get; set; }
        public string GioiTinh { get; set; }
        public string NgayVao { get; set; }
        private void FrmKQKhamSucKhoe_Load(object sender, EventArgs e)
        {
            lookUpDonVi.Properties.DataSource = khamSucKhoeDAO.DSDonVi();
            lookUpDonVi.Properties.DisplayMember = "DONVI";
            lookUpDonVi.Properties.ValueMember = "MADV";

            dataThongTin = khamSucKhoeDAO.DSThongTinBN(TheBHYT);
            cbGioiTinh.SelectedText = this.GioiTinh == "0" ? "Nữ" : "Nam";
            txtSoThe.Text = TheBHYT;
            txtHoTen.Text = HoTen;
            txtNgayVao.Text = Utils.ParseDates(NgayVao);
            txtNgaySinh.Text = Utils.ParseDate(NamSinh, true);
            //
            if (dataThongTin != null && dataThongTin.Rows.Count > 0)
            {
                cbTo.SelectedItem = dataThongTin.Rows[0]["TO_NT"];
                cbChucVu.SelectedItem = dataThongTin.Rows[0]["CHUC_VU"];
                lookUpDonVi.EditValue = dataThongTin.Rows[0]["MADV"];
            }
            dataKhamSucKhoe = khamSucKhoeDAO.ThongTinKSK(MaLienKet);
            if (dataKhamSucKhoe != null && dataKhamSucKhoe.Rows.Count > 0)
            {
                cbLoaiKham.SelectedIndex = Utils.ToInt(dataKhamSucKhoe.Rows[0]["LOAI_KHAM"].ToString());
                txtChieuCao.Text = dataKhamSucKhoe.Rows[0]["CHIEU_CAO"].ToString();
                txtCanNang.Text = dataKhamSucKhoe.Rows[0]["CAN_NANG"].ToString();
                txtMach.Text = dataKhamSucKhoe.Rows[0]["MACH"].ToString();
                txtHuyetAp.Text = dataKhamSucKhoe.Rows[0]["HUYET_AP"].ToString();
                cbPLTheLuc.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_THELUC"].ToString();
                txtTienSuBenh.Text = dataKhamSucKhoe.Rows[0]["TIENSU_BT"].ToString();
                txtTuanHoan.Text = dataKhamSucKhoe.Rows[0]["TUAN_HOAN"].ToString();
                cbTuanHoan.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_TUANHOAN"].ToString();
                txtHoHap.Text = dataKhamSucKhoe.Rows[0]["HO_HAP"].ToString();
                cbHoHap.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_HOHAP"].ToString();
                txtTieuHoa.Text = dataKhamSucKhoe.Rows[0]["TIEU_HOA"].ToString();
                cbTieuHoa.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_TIEUHOA"].ToString();
                txtThanTNieu.Text = dataKhamSucKhoe.Rows[0]["TIET_NIEU"].ToString();
                cbThanTNieu.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_TIETNIEU"].ToString();
                txtNoiTiet.Text = dataKhamSucKhoe.Rows[0]["NOI_TIET"].ToString();
                cbNoiTiet.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_NOITIET"].ToString();
                txtCoXuongKhop.Text = dataKhamSucKhoe.Rows[0]["CO_KHOP"].ToString();
                cbCoXKhop.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_COKHOP"].ToString();
                txtThanKinh.Text = dataKhamSucKhoe.Rows[0]["THAN_KINH"].ToString();
                cbThanKinh.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_THANKINH"].ToString();
                txtTamThan.Text = dataKhamSucKhoe.Rows[0]["TAM_THAN"].ToString();
                cbTamThan.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_TAMTHAN"].ToString();
                txtKhongKinhMP.Text = dataKhamSucKhoe.Rows[0]["KKINH_MP"].ToString();
                txtKhongKinhMT.Text = dataKhamSucKhoe.Rows[0]["KKINH_MT"].ToString();
                txtCoKinhMP.Text = dataKhamSucKhoe.Rows[0]["CKINH_MP"].ToString();
                txtCoKinhMT.Text = dataKhamSucKhoe.Rows[0]["CKINH_MT"].ToString();
                txtBenhVeMat.Text = dataKhamSucKhoe.Rows[0]["BVE_MAT"].ToString();
                cbBenhVeMat.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_BVM"].ToString();
                txtNoiThuongTT.Text = dataKhamSucKhoe.Rows[0]["NTHUONG_TT"].ToString();
                txtNoiThamTT.Text = dataKhamSucKhoe.Rows[0]["NTHAM_TT"].ToString();
                txtNoiThuongTP.Text = dataKhamSucKhoe.Rows[0]["NTHUONG_TP"].ToString();
                txtNoiThamTP.Text = dataKhamSucKhoe.Rows[0]["NTHAM_TP"].ToString();
                txtBenhVeTMH.Text = dataKhamSucKhoe.Rows[0]["BENH_TMH"].ToString();
                cbBenhVeTMH.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_BENHTMH"].ToString();
                txtHamTren.Text = dataKhamSucKhoe.Rows[0]["HAM_TREN"].ToString();
                txtHamDuoi.Text = dataKhamSucKhoe.Rows[0]["HAM_DUOI"].ToString();
                txtBenhVeRMH.Text = dataKhamSucKhoe.Rows[0]["BENH_RHM"].ToString();
                cbBenhVeRHM.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_BENHRHM"].ToString();
                txtDaLieu.Text = dataKhamSucKhoe.Rows[0]["DA_LIEU"].ToString();
                cbDaLieu.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_DALIEU"].ToString();
                txtPhuKhoa.Text = dataKhamSucKhoe.Rows[0]["PHU_KHOA"].ToString();
                cbPhuKhoa.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_PHUKHOA"].ToString();
                checkDatVong.Checked = Utils.ToBool(dataKhamSucKhoe.Rows[0]["DAT_VONG"]);
                checkGynofar.Checked = Utils.ToBool(dataKhamSucKhoe.Rows[0]["GYNOFAR"]);
                checkTayGiun.Checked = Utils.ToBool(dataKhamSucKhoe.Rows[0]["TAY_GIUN"]);
                txtPap.Text = dataKhamSucKhoe.Rows[0]["PAP"].ToString();
                txtSoiTuoi.Text = dataKhamSucKhoe.Rows[0]["SOI_TUOI"].ToString();
                txtChupNhuAnh.Text = dataKhamSucKhoe.Rows[0]["CHUP_NHU_ANH"].ToString();
                txtXQTimPhoi.Text = dataKhamSucKhoe.Rows[0]["XQ_TIM_PHOI"].ToString();
                txtXQCSTL.Text = dataKhamSucKhoe.Rows[0]["XQ_CSTL"].ToString();
                txtXQKhac.Text = dataKhamSucKhoe.Rows[0]["XQ_KHAC"].ToString();
                txtSATQ.Text = dataKhamSucKhoe.Rows[0]["SA_TQ"].ToString();
                txtSATV.Text = dataKhamSucKhoe.Rows[0]["SA_TVU"].ToString();
                txtSATG.Text = dataKhamSucKhoe.Rows[0]["SA_TGIAP"].ToString();
                txtSATim.Text = dataKhamSucKhoe.Rows[0]["SA_TIM"].ToString();
                txtDoDienTim.Text = dataKhamSucKhoe.Rows[0]["DO_DIEN_TIM"].ToString();
                txtDoLoangX.Text = dataKhamSucKhoe.Rows[0]["DO_LOANGX"].ToString();
                // = dataKhamSucKhoe.Rows[0]["DO_THINHL"].ToString();
                txtNoiSoiDaDay.Text = dataKhamSucKhoe.Rows[0]["NS_DADAY"].ToString();
                txtNoiSoiDT.Text = dataKhamSucKhoe.Rows[0]["NS_DAITRANG"].ToString();
                txtNSTMH.Text = dataKhamSucKhoe.Rows[0]["NS_TMH"].ToString();
                //= dataKhamSucKhoe.Rows[0]["SINH_THIET"].ToString();
                // = dataKhamSucKhoe.Rows[0]["CHUP_CT"].ToString();
                //= dataKhamSucKhoe.Rows[0]["CHUP_MRI"].ToString();
                cbNhomMau.SelectedItem = dataKhamSucKhoe.Rows[0]["NHOM_MAU"].ToString();
                txtXNHH.Text = dataKhamSucKhoe.Rows[0]["XN_HH"].ToString();
                txtSHNT.Text = dataKhamSucKhoe.Rows[0]["SH_NT"].ToString();
                txtSinhHM.Text = dataKhamSucKhoe.Rows[0]["SINH_HM"].ToString();
                txtXNKhac.Text = dataKhamSucKhoe.Rows[0]["XN_KHAC"].ToString();
                cbPLSK.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_SK"].ToString();
                checkDieuTri.Checked = Utils.ToBool(dataKhamSucKhoe.Rows[0]["DIEU_TRI"]);
                txtKetLuan.Text = dataKhamSucKhoe.Rows[0]["KET_LUAN"].ToString();
                txtDeNghi.Text = dataKhamSucKhoe.Rows[0]["DE_NGHI"].ToString();
            }
            this.ActiveControl = txtTienSuBenh;
        }
        private void TinhIBM()
        {
            if(Utils.ToDouble(txtCanNang.Text) > 0 && Utils.ToDouble(txtChieuCao.Text)>0)
            {
                txtChiSoIBM.Text = (Utils.ToDouble(txtCanNang.Text) / 
                    (Utils.ToDouble(txtChieuCao.Text)/100 * Utils.ToDouble(txtChieuCao.Text)/100)).ToString();
            }
            else
            {
                txtChiSoIBM.Text = "";
            }
        }
        private void txtChieuCao_TextChanged(object sender, EventArgs e)
        {
            TinhIBM();
        }

        private void txtCanNang_TextChanged(object sender, EventArgs e)
        {
            TinhIBM();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            khamSucKhoeDAO.SuaThongTinKSK(ref err, txtSoThe.Text, lookUpDonVi.EditValue.ToString(),
                cbChucVu.SelectedItem.ToString(), cbTo.SelectedItem.ToString());
            // Thông tin KSK
            khamSucKhoeVO.MA_LK = MaLienKet;
            khamSucKhoeVO.LOAI_KHAM = cbLoaiKham.SelectedIndex;
            khamSucKhoeVO.CHIEU_CAO =Utils.ToInt( txtChieuCao.Text);
            khamSucKhoeVO.CAN_NANG =Utils.ToFloat( txtCanNang.Text);
            khamSucKhoeVO.MACH =Utils.ToInt( txtMach.Text);
            khamSucKhoeVO.HUYET_AP =ToStringBT( txtHuyetAp.Text);
            khamSucKhoeVO.PL_THELUC = ToStringBT(cbPLTheLuc.SelectedItem);
            khamSucKhoeVO.TIENSU_BT = ToStringBT(txtTienSuBenh.Text);
            khamSucKhoeVO.TUAN_HOAN = ToStringBT(txtTuanHoan.Text);
            khamSucKhoeVO.PL_TUANHOAN = ToStringBT(cbTuanHoan.SelectedItem);
            khamSucKhoeVO.HO_HAP = ToStringBT(txtHoHap.Text);
            khamSucKhoeVO.PL_HOHAP = ToStringBT(cbHoHap.SelectedItem);
            khamSucKhoeVO.TIEU_HOA = ToStringBT(txtTieuHoa.Text);
            khamSucKhoeVO.PL_TIEUHOA = ToStringBT(cbTieuHoa.SelectedItem);
            khamSucKhoeVO.TIET_NIEU = ToStringBT(txtThanTNieu.Text);
            khamSucKhoeVO.PL_TIETNIEU = ToStringBT(cbThanTNieu.SelectedItem);
            khamSucKhoeVO.NOI_TIET = ToStringBT(txtNoiTiet.Text);
            khamSucKhoeVO.PL_NOITIET = ToStringBT(cbNoiTiet.SelectedItem);
            khamSucKhoeVO.CO_KHOP = ToStringBT(txtCoXuongKhop.Text);
            khamSucKhoeVO.PL_COKHOP = ToStringBT(cbCoXKhop.SelectedItem);
            khamSucKhoeVO.THAN_KINH = ToStringBT(txtThanKinh.Text);
            khamSucKhoeVO.PL_THANKINH = ToStringBT(cbThanKinh.SelectedItem);
            khamSucKhoeVO.TAM_THAN = ToStringBT(txtTamThan.Text);
            khamSucKhoeVO.PL_TAMTHAN = ToStringBT(cbTamThan.SelectedItem);
            khamSucKhoeVO.KKINH_MP = ToStringBT(txtKhongKinhMP.Text);
            khamSucKhoeVO.KKINH_MT = ToStringBT(txtKhongKinhMT.Text);
            khamSucKhoeVO.CKINH_MP = ToStringBT(txtCoKinhMP.Text);
            khamSucKhoeVO.CKINH_MT = ToStringBT(txtCoKinhMT.Text);
            khamSucKhoeVO.BVE_MAT = ToStringBT(txtBenhVeMat.Text);
            khamSucKhoeVO.PL_BVM = ToStringBT(cbBenhVeMat.SelectedItem);
            khamSucKhoeVO.NTHUONG_TT =Utils.ToFloat( txtNoiThuongTT.Text);
            khamSucKhoeVO.NTHAM_TT =Utils.ToFloat( txtNoiThamTT.Text);
            khamSucKhoeVO.NTHUONG_TP =Utils.ToFloat( txtNoiThuongTP.Text);
            khamSucKhoeVO.NTHAM_TP =Utils.ToFloat( txtNoiThamTP.Text);
            khamSucKhoeVO.BENH_TMH = ToStringBT(txtBenhVeTMH.Text);
            khamSucKhoeVO.PL_BENHTMH = ToStringBT(cbBenhVeTMH.SelectedItem);
            khamSucKhoeVO.HAM_TREN = ToStringBT(txtHamTren.Text);
            khamSucKhoeVO.HAM_DUOI = ToStringBT(txtHamDuoi.Text);
            khamSucKhoeVO.BENH_RHM = ToStringBT(txtBenhVeRMH.Text);
            khamSucKhoeVO.PL_BENHRHM = ToStringBT(cbBenhVeRHM.SelectedItem);
            khamSucKhoeVO.DA_LIEU = ToStringBT(txtDaLieu.Text);
            khamSucKhoeVO.PL_DALIEU = ToStringBT(cbDaLieu.SelectedItem);
            khamSucKhoeVO.PHU_KHOA = ToStringBT(txtPhuKhoa.Text);
            khamSucKhoeVO.PL_PHUKHOA = ToStringBT(cbPhuKhoa.SelectedItem);
            khamSucKhoeVO.DAT_VONG = checkDatVong.Checked;
            khamSucKhoeVO.GYNOFAR = checkGynofar.Checked;
            khamSucKhoeVO.TAY_GIUN = checkTayGiun.Checked;
            khamSucKhoeVO.PAP = ToStringBT(txtPap.Text);
            khamSucKhoeVO.SOI_TUOI = ToStringBT(txtSoiTuoi.Text);
            khamSucKhoeVO.CHUP_NHU_ANH = ToStringBT(txtChupNhuAnh.Text);
            khamSucKhoeVO.XQ_TIM_PHOI = ToStringBT(txtXQTimPhoi.Text);
            khamSucKhoeVO.XQ_CSTL = ToStringBT(txtXQCSTL.Text);
            khamSucKhoeVO.XQ_KHAC = ToStringBT(txtXQKhac.Text);
            khamSucKhoeVO.SA_TQ = ToStringBT(txtSATQ.Text);
            khamSucKhoeVO.SA_TVU = ToStringBT(txtSATV.Text);
            khamSucKhoeVO.SA_TGIAP = ToStringBT(txtSATG.Text);
            khamSucKhoeVO.SA_TIM = ToStringBT(txtSATim.Text);
            khamSucKhoeVO.DO_DIEN_TIM = ToStringBT(txtDoDienTim.Text);
            khamSucKhoeVO.DO_LOANGX = ToStringBT(txtDoLoangX.Text);
            khamSucKhoeVO.NS_DADAY = ToStringBT(txtNoiSoiDaDay.Text);
            khamSucKhoeVO.NS_DAITRANG = ToStringBT(txtNoiSoiDT.Text);
            khamSucKhoeVO.NS_TMH = ToStringBT(txtNSTMH.Text);
            khamSucKhoeVO.NHOM_MAU = ToStringBT(cbNhomMau.SelectedItem);
            khamSucKhoeVO.XN_HH = ToStringBT(txtXNHH.Text);
            khamSucKhoeVO.SH_NT = ToStringBT(txtSHNT.Text);
            khamSucKhoeVO.SINH_HM = ToStringBT(txtSinhHM.Text);
            khamSucKhoeVO.XN_KHAC = ToStringBT(txtXNKhac.Text);
            khamSucKhoeVO.PL_SK = ToStringBT(cbPLSK.SelectedItem);
            khamSucKhoeVO.DIEU_TRI = checkDieuTri.Checked;
            khamSucKhoeVO.KET_LUAN = ToStringBT(txtKetLuan.Text);
            khamSucKhoeVO.DE_NGHI = ToStringBT(txtDeNghi.Text);

            if(!khamSucKhoeDAO.SpKhamSucKhoe(ref err,"UPDATE",khamSucKhoeVO))
            {
                MessageBox.Show(err);
            }

        }

        private void txtChieuCao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCanNang.Focus();
            }
        }

        private void txtCanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMach.Focus();
            }
        }

        private void txtMach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHuyetAp.Focus();
            }
        }

        private void txtHuyetAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbPLTheLuc.Focus();
            }
        }

        private void cbPLTheLuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTuanHoan.Focus();
            }
        }

        private void txtTuanHoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbTuanHoan.Focus();
            }
        }

        private void cbTuanHoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHoHap.Focus();
            }
        }

        private void txtHoHap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbHoHap.Focus();
            }
        }

        private void cbHoHap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTieuHoa.Focus();
            }
        }

        private void txtTieuHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbTieuHoa.Focus();
            }
        }

        private void cbTieuHoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtThanTNieu.Focus();
            }
        }

        private void txtThanTNieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbThanTNieu.Focus();
            }
        }

        private void cbThanTNieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNoiTiet.Focus();
            }
        }

        private void txtNoiTiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbNoiTiet.Focus();
            }
        }

        private void cbNoiTiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCoXuongKhop.Focus();
            }

        }

        private void txtCoXuongKhop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbCoXKhop.Focus();
            }
        }

        private void cbCoXKhop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtThanKinh.Focus();
            }
        }

        private void txtThanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbThanKinh.Focus();
            }
        }

        private void cbThanKinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTamThan.Focus();
            }
        }

        private void txtTamThan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbTamThan.Focus();
            }
        }

        private void cbTamThan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtKhongKinhMP.Focus();
            }
        }

        private void txtKhongKinhMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtKhongKinhMT.Focus();
            }
        }

        private void txtKhongKinhMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCoKinhMP.Focus();
            }
        }

        private void txtCoKinhMP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCoKinhMT.Focus();
            }
        }

        private void txtCoKinhMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtBenhVeMat.Focus();
            }
        }

        private void txtBenhVeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbBenhVeMat.Focus();
            }
        }

        private void cbBenhVeMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNoiThuongTT.Focus();
            }
        }

        private void txtNoiThuongTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNoiThamTT.Focus();
            }
        }

        private void txtNoiThamTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNoiThuongTP.Focus();
            }
        }

        private void txtNoiThuongTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNoiThamTP.Focus();
            }
        }

        private void txtNoiThamTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtBenhVeTMH.Focus();
            }
        }

        private void txtBenhVeTMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbBenhVeTMH.Focus();
            }
        }

        private void cbBenhVeTMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHamTren.Focus();
            }
        }

        private void txtHamTren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHamDuoi.Focus();
            }
        }

        private void txtHamDuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtBenhVeRMH.Focus();
            }
        }

        private void txtBenhVeRMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbBenhVeRHM.Focus();
            }
        }

        private void cbBenhVeRHM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDaLieu.Focus();
            }
        }

        private void txtDaLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbDaLieu.Focus();
            }
        }

        private void cbDaLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPhuKhoa.Focus();
            }
        }

        private void txtPhuKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbPhuKhoa.Focus();
            }
        }

        private void cbPhuKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkDatVong.Focus();
            }
        }

        private void checkDatVong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkGynofar.Focus();
            }
        }

        private void checkGynofar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkTayGiun.Focus();
            }
        }

        private void checkTayGiun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPap.Focus();
            }
        }

        private void txtPap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSoiTuoi.Focus();
            }
        }

        private void txtSoiTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtChupNhuAnh.Focus();
            }
        }

        private void txtChupNhuAnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtXQTimPhoi.Focus();
            }
        }

        private void txtXQTimPhoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtXQCSTL.Focus();
            }
        }

        private void txtXQCSTL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtXQKhac.Focus();
            }
        }

        private void txtXQKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSATQ.Focus();
            }
        }

        private void txtSATQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSATV.Focus();
            }
        }

        private void txtSATV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSATG.Focus();
            }
        }

        private void txtSATG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkDieuTri.Focus();
            }
        }

        private void checkDieuTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSATim.Focus();
            }
        }

        private void txtSATim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDoDienTim.Focus();
            }
        }

        private void txtDoDienTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDoLoangX.Focus();
            }
        }

        private void txtDoLoangX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNoiSoiDaDay.Focus();
            }
        }

        private void txtNoiSoiDaDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNoiSoiDT.Focus();
            }
        }

        private void txtNoiSoiDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNSTMH.Focus();
            }
        }

        private void txtNSTMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbNhomMau.Focus();
            }
        }

        private void cbNhomMau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtXNHH.Focus();
            }
        }

        private void txtXNHH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSHNT.Focus();
            }
        }

        private void txtSHNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSinhHM.Focus();
            }
        }

        private void txtSinhHM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtXNKhac.Focus();
            }
        }

        private void txtXNKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtKetLuan.Focus();
            }
        }



        private string ToStringBT(object str, string defaultvalue ="")
        {
            try
            {
                if (str.ToString().ToLower() == "bt")
                {
                    return "Bình thường";
                }
                else
                    return str.ToString();
            }
            catch
            {
                return defaultvalue;
            }
        }
    }
}
