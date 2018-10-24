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
    public partial class FrmKQKhamSucKhoe : Form
    {
        KhamSucKhoeVO khamSucKhoeVO = new KhamSucKhoeVO();
        KhamSucKhoeDAO khamSucKhoeDAO;
        DataTable dataThongTin,dataKhamSucKhoe;
        bool them = false;
        System.Drawing.Font fontB = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Bold);
        System.Drawing.Font font = new System.Drawing.Font("Times New Roman", 12);
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
        public string DiaChi { get; set; }
        private void FrmKQKhamSucKhoe_Load(object sender, EventArgs e)
        {
            if (cbBacSi.SelectedIndex < 0)
                cbBacSi.SelectedIndex = 0;
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
                //cbChucVu.SelectedItem = dataThongTin.Rows[0]["CHUC_VU"];
                txtChucVu.Text = dataThongTin.Rows[0]["CHUC_VU"].ToString();
                lookUpDonVi.EditValue = dataThongTin.Rows[0]["MADV"];
            }
            
            dataKhamSucKhoe = khamSucKhoeDAO.ThongTinKSK(MaLienKet);
            if (dataKhamSucKhoe != null && dataKhamSucKhoe.Rows.Count > 0)
            {
                them = false;

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
                txtAntiHBs.Text = dataKhamSucKhoe.Rows[0]["ANTI_HBS"].ToString();//
                txtAntiHCV.Text = dataKhamSucKhoe.Rows[0]["ANTI_HCV"].ToString();
                txtCA125.Text = dataKhamSucKhoe.Rows[0]["CA125"].ToString();
                txtCA153.Text = dataKhamSucKhoe.Rows[0]["CA153"].ToString();
                txtAFP.Text = dataKhamSucKhoe.Rows[0]["AFP"].ToString();
                txtCEA.Text = dataKhamSucKhoe.Rows[0]["CEA"].ToString();
                txtPSA.Text = dataKhamSucKhoe.Rows[0]["PSA"].ToString();
                cbPLSK.SelectedItem = dataKhamSucKhoe.Rows[0]["PL_SK"].ToString();
                checkDieuTri.Checked = Utils.ToBool(dataKhamSucKhoe.Rows[0]["DIEU_TRI"]);
                txtKetLuan.Text = dataKhamSucKhoe.Rows[0]["KET_LUAN"].ToString();
                txtDeNghi.Text = dataKhamSucKhoe.Rows[0]["DE_NGHI"].ToString();
            }
            else
            {
                them = true;
            }
            this.ActiveControl = txtTienSuBenh;
        }
        private void TinhIBM()
        {
            if(Utils.ToDouble(txtCanNang.Text) > 0 && Utils.ToDouble(txtChieuCao.Text)>0)
            {
                txtChiSoIBM.Text =Math.Round( (Utils.ToDouble(txtCanNang.Text) / 
                    (Utils.ToDouble(txtChieuCao.Text)/100 * Utils.ToDouble(txtChieuCao.Text)/100))).ToString();
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
            string ngaySinh = "";
            try
            {
                ngaySinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            }
            catch
            {
                ngaySinh = txtNgaySinh.Text;
            }
            string err = "";
            khamSucKhoeDAO.SuaThongTinKSK(ref err, txtSoThe.Text, lookUpDonVi.EditValue.ToString(),// cbChucVu.SelectedItem.ToString()
               txtChucVu.Text, cbTo.SelectedItem.ToString(),txtHoTen.Text,cbGioiTinh.SelectedIndex,ngaySinh);
            // Thông tin KSK
            khamSucKhoeVO.MA_LK = MaLienKet;
            khamSucKhoeVO.LOAI_KHAM = cbLoaiKham.SelectedIndex;
            khamSucKhoeVO.CHIEU_CAO = Utils.ToInt(txtChieuCao.Text);
            khamSucKhoeVO.CAN_NANG = Utils.ToFloat(txtCanNang.Text);
            khamSucKhoeVO.MACH = Utils.ToInt(txtMach.Text);
            khamSucKhoeVO.HUYET_AP = ToStringBT(txtHuyetAp.Text);
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
            khamSucKhoeVO.NTHUONG_TT = Utils.ToFloat(txtNoiThuongTT.Text);
            khamSucKhoeVO.NTHAM_TT = Utils.ToFloat(txtNoiThamTT.Text);
            khamSucKhoeVO.NTHUONG_TP = Utils.ToFloat(txtNoiThuongTP.Text);
            khamSucKhoeVO.NTHAM_TP = Utils.ToFloat(txtNoiThamTP.Text);
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
            khamSucKhoeVO.ANTI_HBS = ToStringBT(txtAntiHBs.Text);
            khamSucKhoeVO.ANTI_HCV = ToStringBT(txtAntiHCV.Text);
            khamSucKhoeVO.CA125 = ToStringBT(txtCA125.Text);
            khamSucKhoeVO.CA153 = ToStringBT(txtCA153.Text);
            khamSucKhoeVO.AFP = ToStringBT(txtAFP.Text);
            khamSucKhoeVO.CEA = ToStringBT(txtCEA.Text);
            khamSucKhoeVO.PSA = ToStringBT(txtPSA.Text);
            khamSucKhoeVO.PL_SK = ToStringBT(cbPLSK.SelectedItem);
            khamSucKhoeVO.DIEU_TRI = checkDieuTri.Checked;
            khamSucKhoeVO.KET_LUAN = ToStringBT(txtKetLuan.Text);
            khamSucKhoeVO.DE_NGHI = ToStringBT(txtDeNghi.Text);
            khamSucKhoeVO.KET_QUA = ToStringBT(txtDieuKien.Text);

            if (!them)
            {
                if (!khamSucKhoeDAO.SpKhamSucKhoe(ref err, "UPDATE", khamSucKhoeVO))
                {
                    MessageBox.Show(err);
                }
            }
            else
            if (!khamSucKhoeDAO.SpKhamSucKhoe(ref err, "INSERT", khamSucKhoeVO))
            {
                MessageBox.Show(err);
            }
            them = false;

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
                txtAntiHBs.Focus();
            }
        }

        private void txtXNKhac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAntiHCV.Focus();
            }
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            // in bìa với 2 trang kết quả
            rptKQKhamSucKhoe rpt = new rptKQKhamSucKhoe();
            rpt.xrlblHoTen.Text = txtHoTen.Text.ToUpper();           
            rpt.xrlblNgaySinh.Text = (txtNgaySinh.Text);
            rpt.xrlblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.xrlblCoQuan.Text = lookUpDonVi.Properties.GetDisplayValueByKeyValue(lookUpDonVi.EditValue).ToString()
                + " - " + dataThongTin.Rows[0]["CO_QUAN"].ToString();
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.xrlblNgayThangNam.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            //rpt.xrlblNgayThangNam.Text = Utils.ParseDates(NgayVao, "Phú Riềng, ngày dd, tháng MM, năm yyyy");
            rpt.xrlblDiaChi.Text = this.DiaChi;
            rpt.xrlblHoKhau.Text = this.DiaChi;
            rpt.xrlblNgheNghiep.Text = txtChucVu.Text;// Utils.ToString(cbChucVu.SelectedItem);
            // trang 2
            rpt.xrlblTienSuBenhTat.Text = txtTienSuBenh.Text;
            rpt.xrlblCanNang.Text = txtCanNang.Text;
            rpt.xrlblChieuCao.Text = txtChieuCao.Text;
            rpt.xrlblChiSoBMI.Text = txtChiSoIBM.Text;
            rpt.xrlblHuyetAp.Text = txtHuyetAp.Text;
            rpt.xrlblMach.Text = txtMach.Text;
            rpt.xrlblPhanLoaiTL.Text = Utils.ToString(cbPLTheLuc.SelectedItem);
            //
            rpt.xrtabTuanHoan.Text = ToStringBT(txtTuanHoan.Text);
            rpt.xrtabPLTuanHoan.Text = Utils.ToString(cbTuanHoan.SelectedItem);
            rpt.xrtabHoHap.Text = ToStringBT(txtHoHap.Text);
            rpt.xrtabPLHoHap.Text = Utils.ToString(cbHoHap.SelectedItem);
            rpt.xrtabTieuHoa.Text = ToStringBT(txtTieuHoa.Text);
            rpt.xrtabPLTieuHoa.Text = Utils.ToString(cbTieuHoa.SelectedItem);
            rpt.xrtabThanTieuNieu.Text = ToStringBT(txtThanTNieu.Text);
            rpt.xrtabPLThanTietNieu.Text = Utils.ToString(cbThanTNieu.SelectedItem);
            rpt.xrtabNoiTiet.Text = ToStringBT(txtNoiTiet.Text);
            rpt.xrtabPLNoiTiet.Text = Utils.ToString(cbNoiTiet.SelectedItem);
            rpt.xrtabCoXuongKhop.Text = ToStringBT(txtCoXuongKhop.Text);
            rpt.xrtabPLCoXuongKhop.Text = Utils.ToString(cbCoXKhop.SelectedItem);
            rpt.xrtabThanKinh.Text = ToStringBT(txtThanKinh.Text);
            rpt.xrPLThanKinh.Text = Utils.ToString(cbThanKinh.SelectedItem);
            rpt.xrtabTamThan.Text = ToStringBT(txtTamThan.Text);
            rpt.xrtabPLTamThan.Text = Utils.ToString(cbTamThan.SelectedItem);
            // benh ve mat
            rpt.xrtabKhongKinhMP.Text =ToStringBT( txtKhongKinhMP.Text);
            rpt.xrtabKhongKinhMT.Text = txtKhongKinhMT.Text;
            rpt.xrCoKinhMP.Text = txtCoKinhMP.Text;
            rpt.xrCoKinhMT.Text = txtCoKinhMT.Text;
            rpt.xrtabBenhVeMat.Text = ToStringBT(txtBenhVeMat.Text);
            rpt.xrtabPLBenhVeMat.Text = Utils.ToString(cbBenhVeMat.SelectedItem);
            // tai mui hong
            rpt.xrtabNoiThuongTT.Text = txtNoiThuongTT.Text;
            rpt.xrtabNoiThamTT.Text = txtNoiThamTT.Text;
            rpt.xrtabNoiThuongTP.Text = txtNoiThuongTP.Text;
            rpt.xrtabNoiThamTP.Text = txtNoiThamTP.Text;
            rpt.xrtabBenhTaiMuiHong.Text = ToStringBT(txtBenhVeTMH.Text);
            rpt.xrtabPLTaiMuiHong.Text = Utils.ToString(cbBenhVeTMH.SelectedItem);
            // rang ham mat
            rpt.xrtabHamDuoi.Text = txtHamDuoi.Text;
            rpt.xrtabHamTren.Text = txtHamTren.Text;
            rpt.xrtabPLBenhRHM.Text = Utils.ToString(cbBenhVeRHM.SelectedItem);
            rpt.xrtabBenhRHM.Text = ToStringBT(txtBenhVeRMH.Text);
            // da lieu
            rpt.xrtabDaLieu.Text = ToStringBT(txtDaLieu.Text);
            rpt.xrtabPLDaLieu.Text = Utils.ToString(cbDaLieu.SelectedItem);
            // phu khoa
            rpt.xrtabPLSanPhuKhoa.Text = Utils.ToString(cbPhuKhoa.SelectedItem);
            rpt.xrtabSanPhuKhoa.Text = ToStringBT(txtPhuKhoa.Text);
            //
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            rptTTKhamSucKhoe rpt = new rptTTKhamSucKhoe();
            //cbTo.SelectedItem = dataThongTin.Rows[0]["TO_NT"];
            //cbChucVu.SelectedItem = dataThongTin.Rows[0]["CHUC_VU"];
            //lookUpDonVi.EditValue = dataThongTin.Rows[0]["MADV"];
            rpt.xrlblHoTen.Text = txtHoTen.Text;
            rpt.xrlblBHYT.Text = txtSoThe.Text;
            rpt.xrlblNgaySinh.Text = (txtNgaySinh.Text);
            rpt.xrlblChucVu.Text = txtChucVu.Text;//Utils.ToString( cbChucVu.SelectedItem);
            rpt.xrlblCoQuan.Text = dataThongTin.Rows[0]["CO_QUAN"].ToString();
            rpt.xrlblLoaiKham.Text = Utils.ToString(cbLoaiKham.SelectedItem);
            rpt.xrlblNgayKham.Text = Utils.ParseDates(NgayVao,"dd/MM/yyyy");
            rpt.xrlblDonVi.Text =lookUpDonVi.Properties.GetDisplayValueByKeyValue(lookUpDonVi.EditValue).ToString();
            rpt.xrlblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnCanLamSan_Click(object sender, EventArgs e)
        {
            rptCanLamSangKSK rpt = new rptCanLamSangKSK();
            int temp = 0;
            if(!string.IsNullOrEmpty(txtPap.Text))
            {
                rpt.xrtabPap.Text =ToStringBT(txtPap.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowPap);
            }
            //
            if (!string.IsNullOrEmpty(txtSoiTuoi.Text))
            {
                rpt.xrtabSoiTuoi.Text = ToStringBT(txtSoiTuoi.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowSoiTuoi);
            }
            //
            if (!string.IsNullOrEmpty(txtChupNhuAnh.Text))
            {
                rpt.xrtabChupNhuAnh.Text = ToStringBT(txtChupNhuAnh.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowChupNhuAnh);
            }
            //
            if (!string.IsNullOrEmpty(txtXQTimPhoi.Text))
            {
                rpt.xrtabXQuangTimPhoi.Text = ToStringBT(txtXQTimPhoi.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowXQuangTimPhoi);
            }
            //
            if (!string.IsNullOrEmpty(txtXQCSTL.Text))
            {
                rpt.xrtabXQuangCSTL.Text = ToStringBT(txtXQCSTL.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowXQuangCSTL);
            }
            //
            if (!string.IsNullOrEmpty(txtXQKhac.Text))
            {
                rpt.xrXQuangKhac.Text = ToStringBT(txtXQKhac.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowXQuangKhac);
            }
            //
            if (!string.IsNullOrEmpty(txtSATQ.Text))
            {
                rpt.xrtabSATongQuat.Text = ToStringBT(txtSATQ.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowSATongQuat);
            }
            //
            if (!string.IsNullOrEmpty(txtSATV.Text))
            {
                rpt.xrtabSATuyenVu.Text = ToStringBT(txtSATV.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowSATuyenVu);
            }
            //
            if (!string.IsNullOrEmpty(txtSATG.Text))
            {
                rpt.xrtabSATuyenGiap.Text = ToStringBT(txtSATG.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowSATuyenGiap);
            }
            //
            if (!string.IsNullOrEmpty(txtSATim.Text))
            {
                rpt.xrtabSATim.Text = ToStringBT(txtSATim.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowSATim);
            }
            //
            if (!string.IsNullOrEmpty(txtDoDienTim.Text))
            {
                rpt.xrtabDoDienTim.Text = ToStringBT(txtDoDienTim.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowDoDienTim);
            }
            //
            if (!string.IsNullOrEmpty(txtDoLoangX.Text))
            {
                rpt.xrtabDoLoangXuong.Text = ToStringBT(txtDoLoangX.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowDoLoangXuong);
            }
            // 
            if (!string.IsNullOrEmpty(txtNoiSoiDaDay.Text))
            {
                rpt.xrtabNSDaDay.Text = ToStringBT(txtNoiSoiDaDay.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowNSDaDay);
            }
            //
            if (!string.IsNullOrEmpty(txtNoiSoiDT.Text))
            {
                rpt.xrtabNSDaiTrang.Text = ToStringBT(txtNoiSoiDT.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowNSDaiTrang);
            }
            //
            if (!string.IsNullOrEmpty(txtNSTMH.Text))
            {
                rpt.xrtabNSTMH.Text = ToStringBT(txtNSTMH.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowNSTMH);
            }
            //
            if (!string.IsNullOrEmpty(Utils.ToString(cbNhomMau.SelectedItem)))
            {
                rpt.xrtabNhomMau.Text = Utils.ToString(cbNhomMau.SelectedItem);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowNhomMau);
            }
            //
            if (!string.IsNullOrEmpty(txtXNHH.Text))
            {
                rpt.xrXNHuyetHoc.Text = ToStringBT(txtXNHH.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowXNHuyetHoc);
            }
            //
            if (!string.IsNullOrEmpty(txtSHNT.Text))
            {
                rpt.xrtabSHNuocTieu.Text = ToStringBT(txtSHNT.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowSHNuocTieu);
            }
            //
            if (!string.IsNullOrEmpty(txtSinhHM.Text))
            {
                rpt.xrtabSHMau.Text = ToStringBT(txtSinhHM.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowSHMau);
            }
            // 
            if (!string.IsNullOrEmpty(txtAntiHBs.Text))
            {
                rpt.xrtabAntiHBs.Text = ToStringBT(txtAntiHBs.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowAntiHBs);
            }
            // 
            if (!string.IsNullOrEmpty(txtAntiHCV.Text))
            {
                rpt.xrtabAntiHCV.Text = ToStringBT(txtAntiHCV.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowAntiHCV);
            }
            // 
            if (!string.IsNullOrEmpty(txtCA125.Text))
            {
                rpt.xrtabCA125.Text = ToStringBT(txtCA125.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowCA125);
            }
            // 
            if (!string.IsNullOrEmpty(txtCA153.Text))
            {
                rpt.xrTabCA153.Text = ToStringBT(txtCA153.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowCA153);
            }
            // 
            if (!string.IsNullOrEmpty(txtAFP.Text))
            {
                rpt.xrTabAFP.Text = ToStringBT(txtAFP.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowAFP);
            }
            // 
            if (!string.IsNullOrEmpty(txtCEA.Text))
            {
                rpt.xrTabCEA.Text = ToStringBT(txtCEA.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowCEA);
            }
            // 
            if (!string.IsNullOrEmpty(txtPSA.Text))
            {
                rpt.xrTabPSA.Text = ToStringBT(txtPSA.Text);
                temp++;
            }
            else
            {
                rpt.xrTable.DeleteRow(rpt.xrrowPSA);
            }
            // 
         
            rpt.Detail.HeightF = ( 60 + temp * 30);
            //rpt.xrTable.WidthF = 722;
            //rpt.xrTable.AdjustSize();
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.xrlblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.xrlblDeNghi.Text = txtDeNghi.Text;
            rpt.xrlblPhanLoaiSK.Text = Utils.ToString(cbPLSK.SelectedItem);
            rpt.xrlblCacBenhNeuCo.Text = txtKetLuan.Text;
            rpt.xrlblDieuKien.Text = txtDieuKien.Text; // thêm
            //rpt.xrlblBacSi.Text = cbBacSi.SelectedItem.ToString();
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnInXQTimPhoi_Click(object sender, EventArgs e)
        {
            rptMauSo_19 rpt = new rptMauSo_19();

            rpt.lblHoTen.Text = txtHoTen.Text;
            //rpt.lblBHYT.Text = txtSoThe.Text;
            rpt.lblNamSinh.Text = (txtNgaySinh.Text);
            rpt.xrlblDiaChi.Text = this.DiaChi;
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.xrlblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.cellYeuCau.Text = "X-Quang Tim Phổi";
            rpt.cellKetQua.Text =ToStringBT( txtXQTimPhoi.Text);
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnXQCSTL_Click(object sender, EventArgs e)
        {
            rptMauSo_19 rpt = new rptMauSo_19();
            rpt.lblHoTen.Text = txtHoTen.Text;
            //rpt.lblBHYT.Text = txtSoThe.Text;
            rpt.lblNamSinh.Text = (txtNgaySinh.Text);
            rpt.xrlblDiaChi.Text = this.DiaChi;
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.xrlblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.cellYeuCau.Text = "X-Quang Cột Sống Thắt Lưng";
            rpt.cellKetQua.Text = ToStringBT(txtXQCSTL.Text);
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnXQKhac_Click(object sender, EventArgs e)
        {
            rptMauSo_19 rpt = new rptMauSo_19();
            rpt.lblHoTen.Text = txtHoTen.Text;
            //rpt.lblBHYT.Text = txtSoThe.Text;
            rpt.lblNamSinh.Text = (txtNgaySinh.Text);
            rpt.xrlblDiaChi.Text = this.DiaChi;
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.xrlblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.cellYeuCau.Text = "X-Quang Khác";
            rpt.cellKetQua.Text = ToStringBT(txtXQKhac.Text);
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnDoDienTim_Click(object sender, EventArgs e)
        {
            rptMauSo_23 rpt = new rptMauSo_23();
            rpt.lblHoTen.Text = txtHoTen.Text;
            rpt.lblSoThe.Text = txtSoThe.Text;
            rpt.lblNamSinh.Text = (txtNgaySinh.Text);
            rpt.lblDiaChi.Text = this.DiaChi;
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.lblKetQua.Text = ToStringBT(txtDoDienTim.Text);
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnDoLoangX_Click(object sender, EventArgs e)
        {
            rptMauSo_27 rpt = new rptMauSo_27();
            rpt.lblHoTen.Text = txtHoTen.Text;
            //rpt.lblSoThe.Text = txtSoThe.Text;
            rpt.lblNamSinh.Text = (txtNgaySinh.Text);
            //rpt.lblDiaChi.Text = this.DiaChi;
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            rpt.cellKetQua.Text = ToStringBT(txtDoLoangX.Text);
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnXNHH_Click(object sender, EventArgs e)
        {
            rptMauSo_28 rpt = new rptMauSo_28();
            rpt.lblHoTen.Text = txtHoTen.Text;
            rpt.lblSoThe.Text = txtSoThe.Text;
            rpt.lblNamSinh.Text = (txtNgaySinh.Text);
            rpt.lblDiaChi.Text = this.DiaChi;
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            //rpt.cellKetQua.Text = ToStringBT(txtDoLoangX.Text);
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnSHNT_Click(object sender, EventArgs e)
        {
            rptMauSo_340 rpt = new rptMauSo_340();
            rpt.lblHoTen.Text = txtHoTen.Text;
            rpt.lblSoThe.Text = txtSoThe.Text;
            rpt.lblNamSinh.Text = (txtNgaySinh.Text);
            rpt.lblDiaChi.Text = this.DiaChi;
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            //rpt.cellKetQua.Text = ToStringBT(txtDoLoangX.Text);
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnSHM_Click(object sender, EventArgs e)
        {
            rptMauSo_33 rpt = new rptMauSo_33();
            rpt.lblHoTen.Text = txtHoTen.Text;
            rpt.lblSoThe.Text = txtSoThe.Text;
            rpt.lblNamSinh.Text = (txtNgaySinh.Text);
            rpt.lblDiaChi.Text = this.DiaChi;
            DateTime date = Utils.ParseDate(NgayVao);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
            //rpt.cellKetQua.Text = ToStringBT(txtDoLoangX.Text);
            rpt.CreateDocument();
            rpt.ShowRibbonPreviewDialog();
        }

        private void btnKeDon_Click(object sender, EventArgs e)
        {
            Connection db = new Connection();
            FrmKeDon frmKeDon = new FrmKeDon(db);
            if (MaLienKet != null)
            {
                frmKeDon.MaLienKet = MaLienKet;
                frmKeDon.ShowDialog();
                //LoadData();
            }
        }

        private void btnSHMFile_Click(object sender, EventArgs e)
        {
            
            //
            //
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "E:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog.OpenFile()) != null)
                    {
                        //
                        rptMauSo_33File rpt = new rptMauSo_33File();
                        rpt.lblHoTen.Text = txtHoTen.Text;
                        rpt.lblSoThe.Text = txtSoThe.Text;
                        rpt.lblNamSinh.Text = (txtNgaySinh.Text);
                        rpt.lblDiaChi.Text = this.DiaChi;
                        DateTime date = Utils.ParseDate(NgayVao);
                        rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
                        rpt.lblNgay.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
                        rpt.lblNgay2.Text = "Phú Riềng, ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year;
                        //rpt.cellKetQua.Text = ToStringBT(txtDoLoangX.Text);
                        XRTableRow row;
                        XRTableCell cell;
                        
                        //
                        string file = openFileDialog.FileName;
                        string[] database = System.IO.File.ReadAllLines(file, Encoding.GetEncoding("ISO-8859-1"));

                        for(int i = 1;i<database.Length;i++)
                        {
                            row = new XRTableRow();
                            //item.Replace('µ', 'u');
                            string[] items = database[i].Split('\t');

                            cell = new XRTableCell();
                            cell.Text = items[2];
                            cell.Font = font;
                            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                            cell.WidthF = 250;
                            cell.HeightF = 30;
                            row.Cells.Add(cell);

                            cell = new XRTableCell();
                            cell.Text = items[6];
                            cell.Font = font;
                            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                            cell.WidthF = 200;
                            cell.HeightF = 30;
                            row.Cells.Add(cell);

                            cell = new XRTableCell();
                            cell.Text = items[4];
                            if (items[5].Length > 0)
                                cell.Font = fontB;
                            else
                                cell.Font = font;
                            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                            cell.WidthF = 210;
                            cell.HeightF = 30;
                            row.Cells.Add(cell);

                            //row.HeightF = 30;
                            rpt.xrTable.Rows.Add(row);
                        }
                        //rpt.xrTable.HeightF = 30 * (database.Length - 1);
                        rpt.CreateDocument();
                        rpt.ShowRibbonPreviewDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message );
                }
            }
            //
        }

        private void txtAntiHCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCA125.Focus();
            }
        }

        private void txtCA125_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCA153.Focus();
            }
        }

        private void txtCA153_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAFP.Focus();
            }
        }

        private void txtAFP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCEA.Focus();
            }
        }

        private void txtCEA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPSA.Focus();
            }
        }

        private void txtPSA_KeyPress(object sender, KeyPressEventArgs e)
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
