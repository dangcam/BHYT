using BHYT.DAO;
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
    public partial class FrmBaoCaoKSK : Form
    {
        BaoCaoKSK baoCaoKSK;
        public FrmBaoCaoKSK()
        {
            InitializeComponent();
            baoCaoKSK = new BaoCaoKSK();
        }

        private void FrmBaoCaoKSK_Load(object sender, EventArgs e)
        {
            dateDenNgay.DateTime = DateTime.Now;
            dateTuNgay.DateTime = DateTime.Now;
            cbNam.Properties.Items.Clear();
            for(int i = DateTime.Now.Year-5;i<DateTime.Now.Year+5;i++)
            {
                cbNam.Properties.Items.Add(i);
            }
            cbNam.SelectedIndex = 5;
            this.ActiveControl = lookUpDonVi;
            lookUpDonVi.Properties.DataSource = baoCaoKSK.DSDonVi();
            lookUpDonVi.Properties.DisplayMember = "DONVI";
            lookUpDonVi.Properties.ValueMember = "MADV";
            //
            cbCanLamSan.Properties.Items.Clear();
            cbCanLamSan.Properties.Items.Add("Đo điện tim");//DO_DIEN_TIM
            cbCanLamSan.Properties.Items.Add("Đo loãng xương");//DO_LOANGX
            cbCanLamSan.Properties.Items.Add("Khám phụ khoa");//PHU_KHOA
            cbCanLamSan.Properties.Items.Add("Nội soi dạ dày");// NS_DADAY
            cbCanLamSan.Properties.Items.Add("Siêu âm tim");//SA_TIM
            cbCanLamSan.Properties.Items.Add("Siêu âm tổng quát");//SA_TQ
            cbCanLamSan.Properties.Items.Add("Sinh hóa máu");//SINH_HM
            cbCanLamSan.Properties.Items.Add("Sinh hóa nước tiểu");//SH_NT
            cbCanLamSan.Properties.Items.Add("Tẩy giun");//TAY_GIUN bool
            cbCanLamSan.Properties.Items.Add("X-Quang tim phổi");// XQ_TIM_PHOI
            cbCanLamSan.SelectedIndex = 0;
            cbPhanLoai.SelectedIndex = 0;
        }

        private void btnTHDonViTheoNam_Click(object sender, EventArgs e)
        {
            string madonvi =Utils.ToString( lookUpDonVi.EditValue);
            //int loaiKham = cbPhanLoai.SelectedIndex;
            string sql = "";
            if(cbPhanLoai.SelectedIndex ==0)
            {
                // 1 là phân loại
            }
            else
            {
                // 2 là tầm soát
                rptChiTietKhamTamSoat rpt = new rptChiTietKhamTamSoat();
                sql = "select HO_TEN,NAM,NU,MADV,"+
                        "ROW_NUMBER() OVER(ORDER BY MADV, HO_TEN ASC) AS STT," +
                        "(CASE WHEN LEN(XQ_TIM_PHOI) > 0 THEN 1 END) as XQuang," +
                        "(CASE WHEN LEN(SA_TQ) > 0 THEN 1 END) as SATQ," +
                        "(CASE WHEN LEN(SA_TIM) > 0 THEN 1 END ) as SATim," +
                        "(CASE WHEN LEN(DO_DIEN_TIM) > 0 THEN 1 END) as ECG," +
                        "(CASE WHEN LEN(DO_LOANGX) > 0 THEN 1 END) as DoLoangXuong," +
                        "(CASE WHEN LEN(NS_DADAY) > 0 THEN 1 END) as NSDaDay," +
                        "(CASE WHEN LEN(SH_NT) > 0 THEN 1 END) as NuocTieu," +
                        "(CASE WHEN LEN(SINH_HM) > 0 THEN 1 END) as Mau," +
                        "(CASE WHEN LEN(PHU_KHOA) > 0 THEN 1 END) as PhuKhoa," +
                        "(CASE WHEN DAT_VONG = 1 THEN 1 END) as DatVong," +
                        "(CASE WHEN PL_SK = 'I' THEN 1 END) as PhanLoaiI," +
                        "(CASE WHEN PL_SK = 'II' THEN 1 END) as PhanLoaiII," +
                        "(CASE WHEN PL_SK = 'III' THEN 1 END) as PhanLoaiIII," +
                        "(CASE WHEN PL_SK = 'VI' THEN 1 END) as PhanLoaiVI," +
                        "(CASE WHEN DIEU_TRI = 1 THEN 1 END) as DieuTri," +
                        "DE_NGHI " +
                        "from KHAM_SUC_KHOE," +
                        "(select MA_LK, THONGTIN_CT.HO_TEN," +
                        "    SUBSTRING(MADV, 4, len(MADV) - 3) as MADV," +
                        "    (CASE WHEN THONGTIN_CT.GIOI_TINH = 0 THEN SUBSTRING(THONGTIN_CT.NGAY_SINH,1,4)END) as NU," +
                        "	(CASE WHEN THONGTIN_CT.GIOI_TINH = 1 THEN SUBSTRING(THONGTIN_CT.NGAY_SINH,1,4)END) as NAM " +
                        "from THONGTIN_CT, THONGTIN " +
                        "where THONGTIN_CT.MA_THE = THONGTIN.MA_THE and MADV is not null " +
                        "and(CAST(SUBSTRING(NGAY_VAO, 1, 8) AS DATE) " +
                        "between '" + dateTuNgay.DateTime.ToString("MM-dd-yyyy") + "' and '" + dateDenNgay.DateTime.ToString("MM-dd-yyyy") + "'))" +
                        "as TT " +
                        "Where KHAM_SUC_KHOE.MA_LK = TT.MA_LK " +
                        "and LOAI_KHAM = 2";
                rpt.DataSource = baoCaoKSK.BCCanLamSanTungDonVi(sql);
                //
                rpt.ShowPreviewDialog();
            }
        }

        private void btnBCCLStungDonvi_Click(object sender, EventArgs e)
        {
            //
            rptBCCanLamSanKSKDonVi rpt = new rptBCCanLamSanKSKDonVi();
            rpt.xrlblTuNgayDenNgay.Text = "Từ ngày " + dateTuNgay.DateTime.ToString("dd/MM/yyyy") +
                " đến ngày " + dateDenNgay.DateTime.ToString("dd/MM/yyyy");
            rpt.xrlblNgayThangNam.Text = "Ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.xrlblTieuDe.Text = "DANH SÁCH " + cbCanLamSan.SelectedItem.ToString().ToUpper() + " - " +
                lookUpDonVi.Properties.GetDisplayValueByKeyValue(lookUpDonVi.EditValue);
            string sql = ",HO_TEN,SUBSTRING(NGAY_SINH,1,4)NGAY_SINH,NGAY_VAO,TO_NT,ROW_NUMBER() OVER(ORDER BY NGAY_VAO,HO_TEN ASC) AS STT from KHAM_SUC_KHOE, " +
                            "(select MA_LK, THONGTIN_CT.HO_TEN, THONGTIN_CT.NGAY_SINH, CAST(SUBSTRING(NGAY_VAO, 1, 8) AS DATE)NGAY_VAO, TO_NT, MADV from THONGTIN_CT, THONGTIN " +
                            "where THONGTIN_CT.MA_THE = THONGTIN.MA_THE " +
                            "and(CAST(SUBSTRING(NGAY_VAO, 1, 8) AS DATE) between " +
                            "'"+dateTuNgay.DateTime.ToString("MM-dd-yyyy")+ "' and '" + dateDenNgay.DateTime.ToString("MM-dd-yyyy") + "') and MADV = '"+lookUpDonVi.EditValue+"') THONGTIN_CT " +
                            "where KHAM_SUC_KHOE.MA_LK = THONGTIN_CT.MA_LK " +
                            "and ";
            //
            string canlamsan = "";
            switch (cbCanLamSan.SelectedIndex)
            {
                case 0:
                    //DO_DIEN_TIM
                    sql = "Select DO_DIEN_TIM as KETQUA" + sql+ "LEN(DO_DIEN_TIM)>0";
                    canlamsan = "LEN(DO_DIEN_TIM)>0";
                    break;
                case 1:
                    //DO_LOANGX
                    sql = "Select DO_LOANGX as KETQUA" + sql + "LEN(DO_LOANGX)>0";
                    canlamsan = "LEN(DO_LOANGX)>0";
                    break;
                case 2:
                    //PHU_KHOA
                    sql = "Select PHU_KHOA as KETQUA" + sql + "LEN(PHU_KHOA)>0";
                    canlamsan = "LEN(PHU_KHOA)>0";
                    break;
                case 3:
                    // NS_DADAY
                    sql = "Select NS_DADAY as KETQUA" + sql + "LEN(NS_DADAY)>0";
                    canlamsan = "LEN(NS_DADAY)>0";
                    break;
                case 4:
                    //SA_TIM
                    sql = "Select SA_TIM as KETQUA" + sql + "LEN(SA_TIM)>0";
                    canlamsan = "LEN(SA_TIM)>0";
                    break;
                case 5:
                    //SA_TQ
                    sql = "Select SA_TQ as KETQUA" + sql + "LEN(SA_TQ)>0";
                    canlamsan = "LEN(SA_TQ)>0";
                    break;
                case 6:
                    //SINH_HM
                    sql = "Select SINH_HM as KETQUA" + sql + "LEN(SINH_HM)>0";
                    canlamsan = "LEN(SINH_HM)>0";
                    break;
                case 7:
                    //SH_NT
                    sql = "Select SH_NT as KETQUA" + sql + "LEN(SH_NT)>0";
                    canlamsan = "LEN(SH_NT)>0";
                    break;
                case 8:
                    //TAY_GIUN bool
                    sql = "Select '' as KETQUA" + sql + "TAY_GIUN = 1";
                    canlamsan = "TAY_GIUN = 1";
                    break;
                default:
                    // XQ_TIM_PHOI
                    sql = "Select XQ_TIM_PHOI as KETQUA" + sql + "LEN(XQ_TIM_PHOI)>0";
                    canlamsan = "LEN(XQ_TIM_PHOI)>0";
                    break;
            }
            //
            rpt.DataSource = baoCaoKSK.BCCanLamSanTungDonVi(sql);
            //
            rpt.ShowPreviewDialog();
        }

        private void btnBCTongHopCLSnhieuDonvi_Click(object sender, EventArgs e)
        {
            //
            rptBCCanLamSanKSK rpt = new rptBCCanLamSanKSK();
            rpt.xrlblTuNgayDenNgay.Text = "Từ ngày " + dateTuNgay.DateTime.ToString("dd/MM/yyyy") +
                " đến ngày " + dateDenNgay.DateTime.ToString("dd/MM/yyyy");
            rpt.xrlblNgayThangNam.Text = "Ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.xrlblTieuDe.Text = "DANH SÁCH " + cbCanLamSan.SelectedItem.ToString().ToUpper();
            string sql = ",HO_TEN,SUBSTRING(NGAY_SINH,1,4)NGAY_SINH,NGAY_VAO,TO_NT,SUBSTRING(MADV, 4, Len(MADV)-3) as MADV," +
                "ROW_NUMBER() OVER(ORDER BY MADV,NGAY_VAO,HO_TEN ASC) AS STT from KHAM_SUC_KHOE, " +
                            "(select MA_LK, THONGTIN_CT.HO_TEN, THONGTIN_CT.NGAY_SINH, CAST(SUBSTRING(NGAY_VAO, 1, 8) AS DATE)NGAY_VAO, TO_NT,MADV from THONGTIN_CT, THONGTIN " +
                            "where THONGTIN_CT.MA_THE = THONGTIN.MA_THE " +
                            "and(CAST(SUBSTRING(NGAY_VAO, 1, 8) AS DATE) between " +
                            "'" + dateTuNgay.DateTime.ToString("MM-dd-yyyy") + "' and '" + dateDenNgay.DateTime.ToString("MM-dd-yyyy") + "')) THONGTIN_CT " +
                            "where KHAM_SUC_KHOE.MA_LK = THONGTIN_CT.MA_LK " +
                            "and ";
            //
            string canlamsan = "";
            switch (cbCanLamSan.SelectedIndex)
            {
                case 0:
                    //DO_DIEN_TIM
                    sql = "Select DO_DIEN_TIM as KETQUA" + sql + "LEN(DO_DIEN_TIM)>0";
                    canlamsan = "LEN(DO_DIEN_TIM)>0";
                    break;
                case 1:
                    //DO_LOANGX
                    sql = "Select DO_LOANGX as KETQUA" + sql + "LEN(DO_LOANGX)>0";
                    canlamsan = "LEN(DO_LOANGX)>0";
                    break;
                case 2:
                    //PHU_KHOA
                    sql = "Select PHU_KHOA as KETQUA" + sql + "LEN(PHU_KHOA)>0";
                    canlamsan = "LEN(PHU_KHOA)>0";
                    break;
                case 3:
                    // NS_DADAY
                    sql = "Select NS_DADAY as KETQUA" + sql + "LEN(NS_DADAY)>0";
                    canlamsan = "LEN(NS_DADAY)>0";
                    break;
                case 4:
                    //SA_TIM
                    sql = "Select SA_TIM as KETQUA" + sql + "LEN(SA_TIM)>0";
                    canlamsan = "LEN(SA_TIM)>0";
                    break;
                case 5:
                    //SA_TQ
                    sql = "Select SA_TQ as KETQUA" + sql + "LEN(SA_TQ)>0";
                    canlamsan = "LEN(SA_TQ)>0";
                    break;
                case 6:
                    //SINH_HM
                    sql = "Select SINH_HM as KETQUA" + sql + "LEN(SINH_HM)>0";
                    canlamsan = "LEN(SINH_HM)>0";
                    break;
                case 7:
                    //SH_NT
                    sql = "Select SH_NT as KETQUA" + sql + "LEN(SH_NT)>0";
                    canlamsan = "LEN(SH_NT)>0";
                    break;
                case 8:
                    //TAY_GIUN bool
                    sql = "Select '' as KETQUA" + sql + "TAY_GIUN = 1";
                    canlamsan = "TAY_GIUN = 1";
                    break;
                default:
                    // XQ_TIM_PHOI
                    sql = "Select XQ_TIM_PHOI as KETQUA" + sql + "LEN(XQ_TIM_PHOI)>0";
                    canlamsan = "LEN(XQ_TIM_PHOI)>0";
                    break;
            }
            //
            rpt.DataSource = baoCaoKSK.BCCanLamSanTungDonVi(sql);
            //
            rpt.ShowPreviewDialog();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaySoLuong();
        }

        private void lookUpDonVi_EditValueChanged(object sender, EventArgs e)
        {
            LaySoLuong();
        }
        private void LaySoLuong()
        {
            txtSoLuongNam.Text = "0";
            if(cbNam.SelectedIndex >= 0 && lookUpDonVi.EditValue !=null)
            {
                int nam = Utils.ToInt(cbNam.SelectedItem.ToString());
                string madonvi = lookUpDonVi.EditValue.ToString();
                DataTable dt = baoCaoKSK.LaySoLuong(nam, madonvi);
                if(dt!=null && dt.Rows.Count>0)
                {
                    txtSoLuongNam.Text = dt.Rows[0]["SOLUONG"].ToString();
                }
            }
        }

        private void btnBCTongHopCLSnhieuDonvi_Click_1(object sender, EventArgs e)
        {
            rptBCTongHopCanLamSan rpt = new rptBCTongHopCanLamSan();
            rpt.xrlblTuNgayDenNgay.Text = "Từ ngày " + dateTuNgay.DateTime.ToString("dd/MM/yyyy") +
                " đến ngày " + dateDenNgay.DateTime.ToString("dd/MM/yyyy");
            rpt.xrlblNgayThangNam.Text = "Ngày " + DateTime.Now.Day + " tháng " +
                DateTime.Now.Month + " năm " + DateTime.Now.Year;
            string sql = "select ROW_NUMBER() OVER(ORDER BY DONVI ASC) AS STT," +
                        "DONVI,COUNT(KHAM_SUC_KHOE.MA_LK) as TongSo," +
                        "SUM(CASE WHEN GIOI_TINH = 0 THEN 1 END ) as Nu,"+
                     "SUM(CASE WHEN LEN(XQ_TIM_PHOI) > 0 THEN 1 END) as XQuang," +
                     "SUM(CASE WHEN LEN(SA_TQ) > 0 THEN 1 END) as SATQ," +
                     "SUM(CASE WHEN LEN(SA_TIM) > 0 THEN 1 END ) as SATim,"+
                     "SUM(CASE WHEN LEN(DO_DIEN_TIM) > 0 THEN 1 END) as ECG," +
                     "SUM(CASE WHEN LEN(DO_LOANGX) > 0 THEN 1 END) as DoLoangXuong," +
                     "SUM(CASE WHEN LEN(NS_DADAY) > 0 THEN 1 END) as NSDaDay," +
                     "SUM(CASE WHEN LEN(SH_NT) > 0 THEN 1 END) as NuocTieu," +
                     "SUM(CASE WHEN LEN(SINH_HM) > 0 THEN 1 END) as Mau," +
                     "SUM(CASE WHEN TAY_GIUN = 1 THEN 1 END) as TayGiun," +
                     "SUM(CASE WHEN LEN(PHU_KHOA) > 0 THEN 1 END) as PhuKhoa," +
                     "SUM(CASE WHEN DAT_VONG = 1 THEN 1 END) as DatVong," +
                     "SUM(CASE WHEN GYNOFAR = 1 THEN 1 END) as Gynofar," +
                     "SUM(CASE WHEN PL_SK = 'I' THEN 1 END) as PhanLoaiI," +
                     "SUM(CASE WHEN PL_SK = 'II' THEN 1 END) as PhanLoaiII," +
                     "SUM(CASE WHEN PL_SK = 'III' THEN 1 END) as PhanLoaiIII," +
                     "SUM(CASE WHEN PL_SK = 'VI' THEN 1 END) as PhanLoaiVI," +
                     "SUM(CASE WHEN DIEU_TRI = 1 THEN 1 END) as DieuTri " +
                    "from KHAM_SUC_KHOE," +
                    "(Select MA_LK, DONVI, NGAY_VAO, GIOI_TINH from THONGTIN_CT," +
                        "(select MA_THE, DONVI from THONGTIN, DONVI where THONGTIN.MADV = DONVI.MADV) as THONGTIN " +
                        "where THONGTIN_CT.MA_THE = THONGTIN.MA_THE)THONGTIN_CT " +
                    "where KHAM_SUC_KHOE.MA_LK = THONGTIN_CT.MA_LK and " +
                    "(CAST(SUBSTRING(THONGTIN_CT.NGAY_VAO, 1, 8) AS DATE) between '" + dateTuNgay.DateTime.ToString("MM-dd-yyyy") +
                    "' and '" + dateDenNgay.DateTime.ToString("MM-dd-yyyy") + "') " +
                    "group by DONVI";
            rpt.DataSource = baoCaoKSK.BCCanLamSanTungDonVi(sql);
            rpt.ShowPreviewDialog();
        }

        private void btnTHTungDonVi_Click(object sender, EventArgs e)
        {

        }
    }
}
