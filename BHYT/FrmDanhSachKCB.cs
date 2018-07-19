using BHYT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BHYT
{
    public partial class FrmDanhSachKCB : Form
    {
        THONGTIN_CTDAO thongTinKCB;
        DataTable data;
        public FrmDanhSachKCB(Connection db)
        {
            InitializeComponent();
            thongTinKCB = new THONGTIN_CTDAO(db);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string ngayBD = DateTime.ParseExact(dateTu.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string ngayKT = DateTime.ParseExact(dateDen.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            data = thongTinKCB.DSThongTinBN((cbLoaiKCB.SelectedIndex + 1).ToString(), ngayBD, ngayKT, cbTinhTrang.SelectedIndex, cbLoaiNgay.SelectedIndex);
            gridControl.DataSource = data;
            lblTong.Text = "Tổng : " + (gridControl.DataSource as DataTable).Rows.Count;
        }

        private void FrmDanhSachKCB_Load(object sender, EventArgs e)
        {
            FrmNgoaiNoiTru.MaLienKet = string.Empty;
            cbLoaiKCB.SelectedIndex = 0;
            cbTinhTrang.SelectedIndex = 0;
            cbLoaiNgay.SelectedIndex = 0;
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.DisplayText.Length <= 4)
                return;
            if (e.Column.VisibleIndex == 3 && !e.DisplayText.Contains("/"))
            {
                e.DisplayText = DateTime.ParseExact(e.DisplayText, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToShortDateString();
            }
            if ((e.Column.VisibleIndex == 4 || e.Column.VisibleIndex == 5) && !e.DisplayText.Contains("/"))
            {
                e.DisplayText = DateTime.ParseExact(e.DisplayText, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).ToShortDateString();
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            FrmNgoaiNoiTru.MaLienKet = (gridView.GetFocusedRow() as DataRowView)[0].ToString();
            this.Close();
        }


        private void gridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                bool check = bool.Parse((gridView.GetFocusedDataRow() as DataRow)["CHECK_OUT"].ToString());
                string maLK = (gridView.GetFocusedDataRow() as DataRow)["MA_LK"].ToString();
                string err = "";
                int c = check ? 1 : 0;
                thongTinKCB.SuaCheckout(ref err, maLK, c);
            }
            catch { }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            DataTable dataDV = null, dataThuoc = null, dataTT = null;
            if (data != null && data.Rows.Count > 0)
            {
                foreach (DataRow dr in data.Rows)
                {
                    string MaLK = dr["MA_LK"].ToString();

                    dataThuoc = thongTinKCB.DSNhomThuoc(MaLK);
                    dataDV = thongTinKCB.DSDVKTChiTiet(MaLK);
                    dataTT = thongTinKCB.DSThongTinChiTiet(MaLK);
                    // tạo file xml
                    XmlDocument doc = new XmlDocument();
                    XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    XmlElement root = doc.DocumentElement;
                    doc.InsertBefore(xmlDeclaration, root);

                    XmlElement checkout = doc.CreateElement(string.Empty, "CHECKOUT", string.Empty);
                    doc.AppendChild(checkout);

                    XmlElement thongtinchitiet = doc.CreateElement(string.Empty, "THONGTINCHITIET", string.Empty);
                    checkout.AppendChild(thongtinchitiet);

                    XmlElement tonghop = doc.CreateElement(string.Empty, "TONGHOP", string.Empty);
                    thongtinchitiet.AppendChild(tonghop);

                    XmlElement bangCTThuoc = doc.CreateElement(string.Empty, "Bang_CTTHUOC", string.Empty);
                    if (dataThuoc !=null && dataThuoc.Rows.Count > 0)
                    {
                        thongtinchitiet.AppendChild(bangCTThuoc);
                        foreach (DataRow drT in dataThuoc.Rows)
                        {
                            taoBangThuoc(doc, bangCTThuoc, drT);
                        }
                    }

                    XmlElement bangCTDichVu = doc.CreateElement(string.Empty, "Bang_CTDV", string.Empty);
                    if ((dataDV !=null && dataDV.Rows.Count > 0))
                    {
                        thongtinchitiet.AppendChild(bangCTDichVu);

                        foreach (DataRow drT in dataDV.Rows)
                        {
                            taoBangDVKT(doc, bangCTDichVu, drT);
                        }
                    }
                    //
                    taoBangTongHop(doc, tonghop, dataTT.Rows[0]);
                    //

                    //
                    const string filePath = "D:\\Checkout\\";
                    try
                    {
                        if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                        }
                        doc.Save(filePath + dataTT.Rows[0]["MA_BN"] + "_" + dataTT.Rows[0]["MA_THE"] + ".xml");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void taoBangTongHop(XmlDocument doc, XmlElement tonghop, DataRow thongtin)
        {
            XmlElement ma_lk = doc.CreateElement(string.Empty, "ma_lk", string.Empty);
            XmlText txt = doc.CreateTextNode(thongtin["MA_LK"].ToString());
            ma_lk.AppendChild(txt);
            tonghop.AppendChild(ma_lk);

            XmlElement stt = doc.CreateElement(string.Empty, "stt", string.Empty);
            stt.AppendChild(doc.CreateTextNode(thongtin["MA_BN"].ToString().Substring(8, 4)));
            tonghop.AppendChild(stt);

            XmlElement maBN = doc.CreateElement(string.Empty, "ma_bn", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_BN"].ToString());
            maBN.AppendChild(txt);
            tonghop.AppendChild(maBN);

            XmlElement hoten = doc.CreateElement(string.Empty, "ho_ten", string.Empty);
            hoten.AppendChild(doc.CreateCDataSection(thongtin["HO_TEN"].ToString()));
            tonghop.AppendChild(hoten);

            XmlElement ngaysinh = doc.CreateElement(string.Empty, "ngay_sinh", string.Empty);
            txt = doc.CreateTextNode(thongtin["NGAY_SINH"].ToString());
            ngaysinh.AppendChild(txt);
            tonghop.AppendChild(ngaysinh);

            XmlElement gioitinh = doc.CreateElement(string.Empty, "gioi_tinh", string.Empty);
            if (thongtin["GIOI_TINH"].ToString() == "0")
            {
                txt = doc.CreateTextNode("2");
            }
            else
            {
                txt = doc.CreateTextNode("1");
            }

            gioitinh.AppendChild(txt);
            tonghop.AppendChild(gioitinh);

            XmlElement diachi = doc.CreateElement(string.Empty, "dia_chi", string.Empty);
            diachi.AppendChild(doc.CreateCDataSection(thongtin["DIA_CHI"].ToString()));
            tonghop.AppendChild(diachi);

            XmlElement mathe = doc.CreateElement(string.Empty, "ma_the", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_THE"].ToString());
            mathe.AppendChild(txt);
            tonghop.AppendChild(mathe);

            XmlElement madkbd = doc.CreateElement(string.Empty, "ma_dkbd", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_DKBD"].ToString());
            madkbd.AppendChild(txt);
            tonghop.AppendChild(madkbd);

            XmlElement gtt = doc.CreateElement(string.Empty, "gt_the_tu", string.Empty);
            txt = doc.CreateTextNode(thongtin["GT_THE_TU"].ToString());
            gtt.AppendChild(txt);
            tonghop.AppendChild(gtt);

            XmlElement gtd = doc.CreateElement(string.Empty, "gt_the_den", string.Empty);
            txt = doc.CreateTextNode(thongtin["GT_THE_DEN"].ToString());
            gtd.AppendChild(txt);
            tonghop.AppendChild(gtd);

            XmlElement tenbenh = doc.CreateElement(string.Empty, "ten_benh", string.Empty);
            tenbenh.AppendChild(doc.CreateCDataSection(thongtin["TEN_BENH"].ToString()));
            tonghop.AppendChild(tenbenh);

            XmlElement mabenh = doc.CreateElement(string.Empty, "ma_benh", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_BENH"].ToString());
            mabenh.AppendChild(txt);
            tonghop.AppendChild(mabenh);

            XmlElement mabenhkhac = doc.CreateElement(string.Empty, "ma_benhkhac", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_BENHKHAC"].ToString());
            mabenhkhac.AppendChild(txt);
            tonghop.AppendChild(mabenhkhac);

            XmlElement MA_LYDO_VVIEN = doc.CreateElement(string.Empty, "ma_lydo_vvien", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_LYDO_VVIEN"].ToString());
            MA_LYDO_VVIEN.AppendChild(txt);
            tonghop.AppendChild(MA_LYDO_VVIEN);

            XmlElement MA_NOI_CHUYEN = doc.CreateElement(string.Empty, "ma_noi_chuyen", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_NOI_CHUYEN"].ToString());
            MA_NOI_CHUYEN.AppendChild(txt);
            tonghop.AppendChild(MA_NOI_CHUYEN);

            XmlElement MA_TAI_NAN = doc.CreateElement(string.Empty, "ma_tai_nan", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_TAI_NAN"].ToString());
            MA_TAI_NAN.AppendChild(txt);
            tonghop.AppendChild(MA_TAI_NAN);

            XmlElement NGAY_VAO = doc.CreateElement(string.Empty, "ngay_vao", string.Empty);
            txt = doc.CreateTextNode(thongtin["NGAY_VAO"].ToString());
            NGAY_VAO.AppendChild(txt);
            tonghop.AppendChild(NGAY_VAO);

            XmlElement NGAY_RA = doc.CreateElement(string.Empty, "ngay_ra", string.Empty);
            txt = doc.CreateTextNode(thongtin["NGAY_RA"].ToString());
            NGAY_RA.AppendChild(txt);
            tonghop.AppendChild(NGAY_RA);

            XmlElement SO_NGAY_DTRI = doc.CreateElement(string.Empty, "so_ngay_dtri", string.Empty);
            txt = doc.CreateTextNode(thongtin["SO_NGAY_DTRI"].ToString());
            SO_NGAY_DTRI.AppendChild(txt);
            tonghop.AppendChild(SO_NGAY_DTRI);

            XmlElement KET_QUA_DTRI = doc.CreateElement(string.Empty, "ket_qua_dtri", string.Empty);
            txt = doc.CreateTextNode(thongtin["KET_QUA_DTRI"].ToString());
            KET_QUA_DTRI.AppendChild(txt);
            tonghop.AppendChild(KET_QUA_DTRI);

            XmlElement TINH_TRANG_RV = doc.CreateElement(string.Empty, "tinh_trang_rv", string.Empty);
            txt = doc.CreateTextNode(thongtin["TINH_TRANG_RV"].ToString());
            TINH_TRANG_RV.AppendChild(txt);
            tonghop.AppendChild(TINH_TRANG_RV);

            XmlElement NGAY_TTOAN = doc.CreateElement(string.Empty, "ngay_ttoan", string.Empty);
            txt = doc.CreateTextNode(thongtin["NGAY_TTOAN"].ToString());
            NGAY_TTOAN.AppendChild(txt);
            tonghop.AppendChild(NGAY_TTOAN);

            XmlElement MUC_HUONG = doc.CreateElement(string.Empty, "muc_huong", string.Empty);
            txt = doc.CreateTextNode(thongtin["MUC_HUONG"].ToString());
            MUC_HUONG.AppendChild(txt);
            tonghop.AppendChild(MUC_HUONG);

            XmlElement T_THUOC = doc.CreateElement(string.Empty, "t_thuoc", string.Empty);
            txt = doc.CreateTextNode(thongtin["T_THUOC"].ToString());
            T_THUOC.AppendChild(txt);
            tonghop.AppendChild(T_THUOC);

            XmlElement T_VTYT = doc.CreateElement(string.Empty, "t_vtyt", string.Empty);
            txt = doc.CreateTextNode(thongtin["T_VTYT"].ToString());
            T_VTYT.AppendChild(txt);
            tonghop.AppendChild(T_VTYT);

            XmlElement T_TONGCHI = doc.CreateElement(string.Empty, "t_tongchi", string.Empty);
            txt = doc.CreateTextNode(thongtin["T_TONGCHI"].ToString());
            T_TONGCHI.AppendChild(txt);
            tonghop.AppendChild(T_TONGCHI);

            XmlElement T_BNTT = doc.CreateElement(string.Empty, "t_bhtt", string.Empty);
            txt = doc.CreateTextNode(thongtin["T_BHTT"].ToString());
            T_BNTT.AppendChild(txt);
            tonghop.AppendChild(T_BNTT);

            XmlElement T_BHTT = doc.CreateElement(string.Empty, "t_bntt", string.Empty);
            txt = doc.CreateTextNode(thongtin["T_BNTT"].ToString());
            T_BHTT.AppendChild(txt);
            tonghop.AppendChild(T_BHTT);

            XmlElement T_NGUONKHAC = doc.CreateElement(string.Empty, "t_nguonkhac", string.Empty);
            txt = doc.CreateTextNode(thongtin["T_NGUONKHAC"].ToString());
            T_NGUONKHAC.AppendChild(txt);
            tonghop.AppendChild(T_NGUONKHAC);

            XmlElement T_NGOAIDS = doc.CreateElement(string.Empty, "t_ngoaids", string.Empty);
            txt = doc.CreateTextNode(thongtin["T_NGOAIDS"].ToString());
            T_NGOAIDS.AppendChild(txt);
            tonghop.AppendChild(T_NGOAIDS);

            XmlElement NAM_QT = doc.CreateElement(string.Empty, "nam_qt", string.Empty);
            txt = doc.CreateTextNode(thongtin["NAM_QT"].ToString());
            NAM_QT.AppendChild(txt);
            tonghop.AppendChild(NAM_QT);

            XmlElement THANG_QT = doc.CreateElement(string.Empty, "thang_qt", string.Empty);
            txt = doc.CreateTextNode(thongtin["THANG_QT"].ToString());
            THANG_QT.AppendChild(txt);
            tonghop.AppendChild(THANG_QT);

            XmlElement MA_LOAI_KCB = doc.CreateElement(string.Empty, "ma_loai_kcb", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_LOAI_KCB"].ToString());
            MA_LOAI_KCB.AppendChild(txt);
            tonghop.AppendChild(MA_LOAI_KCB);

            XmlElement MA_KHOA = doc.CreateElement(string.Empty, "ma_khoa", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_KHOA"].ToString());
            MA_KHOA.AppendChild(txt);
            tonghop.AppendChild(MA_KHOA);

            XmlElement MA_CSKCB = doc.CreateElement(string.Empty, "ma_cskcb", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_CSKCB"].ToString());
            MA_CSKCB.AppendChild(txt);
            tonghop.AppendChild(MA_CSKCB);

            XmlElement MA_KHUVUC = doc.CreateElement(string.Empty, "ma_khuvuc", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_KHUVUC"].ToString());
            MA_KHUVUC.AppendChild(txt);
            tonghop.AppendChild(MA_KHUVUC);

            XmlElement MA_PTTTT_QT = doc.CreateElement(string.Empty, "ma_pttt_qt", string.Empty);
            txt = doc.CreateTextNode(thongtin["MA_PTTTT_QT"].ToString());
            MA_PTTTT_QT.AppendChild(txt);
            tonghop.AppendChild(MA_PTTTT_QT);

            XmlElement CAN_NANG = doc.CreateElement(string.Empty, "can_nang", string.Empty);
            txt = doc.CreateTextNode(thongtin["CAN_NANG"].ToString());
            CAN_NANG.AppendChild(txt);
            tonghop.AppendChild(CAN_NANG);
        }
        private void taoBangThuoc(XmlDocument doc, XmlElement bangthuoc, DataRow thuoc)
        {
            XmlElement CTTHUOC = doc.CreateElement(string.Empty, "CTTHUOC", string.Empty);
            bangthuoc.AppendChild(CTTHUOC);

            XmlElement elementThuoc = doc.CreateElement(string.Empty, "ma_lk", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["MA_LK"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "stt", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode("0"));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ma_thuoc", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["MA_THUOC"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ma_nhom", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["NHOM"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ten_thuoc", string.Empty);
            elementThuoc.AppendChild(doc.CreateCDataSection(thuoc["TEN_THUOC"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "don_vi_tinh", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["DON_VI_TINH"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ham_luong", string.Empty);
            elementThuoc.AppendChild(doc.CreateCDataSection(thuoc["HAM_LUONG"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "duong_dung", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["DUONG_DUNG"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "lieu_dung", string.Empty);
            elementThuoc.AppendChild(doc.CreateCDataSection(thuoc["LIEU_DUNG"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "so_dang_ky", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["SO_DANG_KY"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "so_luong", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["SO_LUONG"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "don_gia", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["DON_GIA"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "tyle_tt", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["TYLE_TT"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "thanh_tien", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["THANH_TIEN"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ma_khoa", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["MA_KHOA"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ma_bac_si", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["MA_BAC_SI"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ma_benh", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["MA_BENH"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ngay_yl", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["NGAY_YL"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

            elementThuoc = doc.CreateElement(string.Empty, "ma_pttt", string.Empty);
            elementThuoc.AppendChild(doc.CreateTextNode(thuoc["MA_PTTT"].ToString()));
            CTTHUOC.AppendChild(elementThuoc);

        }
        private void taoBangDVKT(XmlDocument doc, XmlElement bangdvkt, DataRow dvkt)
        {
            XmlElement CTDV = doc.CreateElement(string.Empty, "CTDV", string.Empty);
            bangdvkt.AppendChild(CTDV);

            XmlElement elementDVKT = doc.CreateElement(string.Empty, "ma_lk", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["MA_LK"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "stt", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode("0"));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ma_dich_vu", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["MA_DICH_VU"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ma_vat_tu", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["MA_DICH_VU"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ma_nhom", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["MA_NHOM"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ten_dich_vu", string.Empty);
            elementDVKT.AppendChild(doc.CreateCDataSection(dvkt["TEN_DICH_VU"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "don_vi_tinh", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["DON_VI_TINH"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "so_luong", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["SO_LUONG"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "don_gia", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["DON_GIA"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "tyle_tt", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["TYLE_TT"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "thanh_tien", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["THANH_TIEN"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ma_khoa", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["MA_KHOA"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ma_bac_si", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["MA_BAC_SI"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ma_benh", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["MA_BENH"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ngay_yl", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["NGAY_YL"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ngay_kq", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["NGAY_QK"].ToString()));
            CTDV.AppendChild(elementDVKT);

            elementDVKT = doc.CreateElement(string.Empty, "ma_pttt", string.Empty);
            elementDVKT.AppendChild(doc.CreateTextNode(dvkt["MA_PTTT"].ToString()));
            CTDV.AppendChild(elementDVKT);
        }

    }

}
