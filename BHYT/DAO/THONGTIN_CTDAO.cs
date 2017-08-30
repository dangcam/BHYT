using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class THONGTIN_CTDAO
    {
        Connection db = null;
        public THONGTIN_CTDAO(Connection db)
        {
            this.db = db;
        }
        public string getMaBN (string ma)
        {
            string so = "0";
            DataTable data = db.ExcuteQuery ("Select * From getMaBN('" + ma + "')",
                CommandType.Text, null);
            try
            {
                so = data.Rows[0][0].ToString ().Substring (9, 3);
            }
            catch { }
            so = "000" + (int.Parse (so) + 1).ToString ();
            so = so.Substring (so.Length - 3, 3);
            return ma + so;
        }

        public KCBVO getCoSoKCB(string ma)
        {
            KCBVO kcb = new KCBVO ();
            DataTable data = db.ExcuteQuery ("Select * From COSOKCB Where MA = '" + ma + "'",
                CommandType.Text, null);
            if(data !=null)
            {
                foreach(DataRow dr in data.Rows)
                {
                    kcb.Ma = dr[0].ToString ();
                    kcb.Ten = dr[1].ToString ();
                    kcb.DiaChi = dr[2].ToString ();

                    return kcb;
                }
            }

            return null;
        }

        public THONGTIN_CTVO getThongTin (string maLK)
        {
            THONGTIN_CTVO thongtin = new THONGTIN_CTVO ();
            DataTable data = new DataTable ();
            data = db.ExcuteQuery ("Select * From THONGTIN_CT Where MA_LK = '" + maLK+"'",
                CommandType.Text, null);
            if (data != null)
            {
                foreach (DataRow dr in data.Rows)
                {
                    thongtin.MaLK = dr[0].ToString ();
                    thongtin.MaBN = dr[1].ToString ();
                    thongtin.HoTen = dr[2].ToString ();
                    thongtin.NgaySinh = dr[3].ToString ();
                    thongtin.GioiTinh = int.Parse(dr[4].ToString ());
                    thongtin.DiaChi = dr[5].ToString ();
                    thongtin.MaThe = dr[6].ToString ();
                    thongtin.MaDKBD = dr[7].ToString ();
                    thongtin.GtTheTu = dr[8].ToString ();
                    thongtin.GtTheDen = dr[9].ToString ();
                    thongtin.TenBenh = dr[10].ToString ();
                    thongtin.MaBenh = dr[11].ToString ();
                    thongtin.MaBenhKhac = dr[12].ToString ();
                    thongtin.MaLyDoVaoVien = int.Parse(dr[13].ToString ());
                    thongtin.MaNoiChuyen = dr[14].ToString ();
                    thongtin.MaTaiNan = int.Parse(dr[15].ToString ());
                    thongtin.NgayVao = dr[16].ToString ();
                    thongtin.NgayRa = dr[17].ToString ();
                    thongtin.SoNgayDieuTri = int.Parse (dr[18].ToString ());
                    thongtin.KetQuaDieuTri = int.Parse (dr[19].ToString ());
                    thongtin.TinhTrangRaVien = int.Parse (dr[20].ToString ());
                    thongtin.NgayThanhToan = dr[21].ToString ();
                    thongtin.MucHuong = int.Parse (dr[22].ToString ());
                    thongtin.TienThuoc = int.Parse (dr[23].ToString ());
                    thongtin.TienVTYT = int.Parse (dr[24].ToString ());
                    thongtin.TienTongChiPhi = int.Parse (dr[25].ToString ());
                    thongtin.TienBNTT = int.Parse (dr[26].ToString ());
                    thongtin.TienBHTT = int.Parse (dr[27].ToString ());
                    thongtin.TienNguonKhac = int.Parse (dr[28].ToString ());
                    thongtin.TienNgoaiDS = int.Parse (dr[29].ToString ());
                    thongtin.NamQT = dr[30].ToString ();
                    thongtin.ThangQT = dr[31].ToString ();
                    thongtin.MaLoaiKCB = Utils.ToInt(dr[32].ToString ());
                    thongtin.MaKhoa = dr[33].ToString ();
                    thongtin.MaCSKCB = dr[34].ToString ();
                    thongtin.MaKV = dr[35].ToString ();
                    thongtin.MaPTTTQT = dr[36].ToString ();
                    thongtin.CanNang = float.Parse (dr[37].ToString ());
                    thongtin.CheckOut = bool.Parse(dr[38].ToString ());
                    thongtin.Phong = ToInt(dr[39].ToString ());
                    thongtin.MaBS = dr[40].ToString ();
                    return thongtin;
                }
            }
            return null;
        }
        private int ToInt(string value, int defaultvalue = 0)
        {
            try
            {
                return int.Parse (value);
            }
            catch
            {
                return defaultvalue;
            }
        }
        public THONGTIN_CTVO getThongTinLui (string maBN)
        {
            string so = "0";
            try
            {
                so = maBN.Substring (9, 3);
            }
            catch { }
            so = "000" + (int.Parse (so) - 1).ToString ();
            so = so.Substring (so.Length - 3, 3);
            maBN = maBN.Substring (0, 9) + so;
            THONGTIN_CTVO thongtin = new THONGTIN_CTVO ();
            DataTable data = new DataTable ();
            data = db.ExcuteQuery ("Select * From THONGTIN_CT Where MA_BN = '" + maBN + "'",
               CommandType.Text, null);
            if (data != null)
            {
                foreach (DataRow dr in data.Rows)
                {
                    thongtin.MaLK = dr[0].ToString ();
                    thongtin.MaBN = dr[1].ToString ();
                    thongtin.HoTen = dr[2].ToString ();
                    thongtin.NgaySinh = dr[3].ToString ();
                    thongtin.GioiTinh = int.Parse (dr[4].ToString ());
                    thongtin.DiaChi = dr[5].ToString ();
                    thongtin.MaThe = dr[6].ToString ();
                    thongtin.MaDKBD = dr[7].ToString ();
                    thongtin.GtTheTu = dr[8].ToString ();
                    thongtin.GtTheDen = dr[9].ToString ();
                    thongtin.TenBenh = dr[10].ToString ();
                    thongtin.MaBenh = dr[11].ToString ();
                    thongtin.MaBenhKhac = dr[12].ToString ();
                    thongtin.MaLyDoVaoVien = int.Parse (dr[13].ToString ());
                    thongtin.MaNoiChuyen = dr[14].ToString ();
                    thongtin.MaTaiNan = int.Parse (dr[15].ToString ());
                    thongtin.NgayVao = dr[16].ToString ();
                    thongtin.NgayRa = dr[17].ToString ();
                    thongtin.SoNgayDieuTri = int.Parse (dr[18].ToString ());
                    thongtin.KetQuaDieuTri = int.Parse (dr[19].ToString ());
                    thongtin.TinhTrangRaVien = int.Parse (dr[20].ToString ());
                    thongtin.NgayThanhToan = dr[21].ToString ();
                    thongtin.MucHuong = int.Parse (dr[22].ToString ());
                    thongtin.TienThuoc = int.Parse (dr[23].ToString ());
                    thongtin.TienVTYT = int.Parse (dr[24].ToString ());
                    thongtin.TienTongChiPhi = int.Parse (dr[25].ToString ());
                    thongtin.TienBNTT = int.Parse (dr[26].ToString ());
                    thongtin.TienBHTT = int.Parse (dr[27].ToString ());
                    thongtin.TienNguonKhac = int.Parse (dr[28].ToString ());
                    thongtin.TienNgoaiDS = int.Parse (dr[29].ToString ());
                    thongtin.NamQT = dr[30].ToString ();
                    thongtin.ThangQT = dr[31].ToString ();
                    thongtin.MaLoaiKCB = Utils.ToInt(dr[32].ToString ());
                    thongtin.MaKhoa = dr[33].ToString ();
                    thongtin.MaCSKCB = dr[34].ToString ();
                    thongtin.MaKV = dr[35].ToString ();
                    thongtin.MaPTTTQT = dr[36].ToString ();
                    thongtin.CanNang = float.Parse (dr[37].ToString ());
                    thongtin.CheckOut = bool.Parse (dr[38].ToString ());
                    return thongtin;
                }
            }
            return null;
        }
        public THONGTIN_CTVO getThongTinTien (string maBN)
        {
            string so = "0";
            try
            {
                so = maBN.Substring (9, 3);
            }
            catch { }
            so = "000" + (int.Parse (so) + 1).ToString ();
            so = so.Substring (so.Length - 3, 3);
            maBN = maBN.Substring (0, 9) + so;
            THONGTIN_CTVO thongtin = new THONGTIN_CTVO ();
            DataTable data = new DataTable ();
            data = db.ExcuteQuery ("Select * From THONGTIN_CT Where MA_BN = '" + maBN + "'",
               CommandType.Text, null);
            if (data != null)
            {
                foreach (DataRow dr in data.Rows)
                {
                    thongtin.MaLK = dr[0].ToString ();
                    thongtin.MaBN = dr[1].ToString ();
                    thongtin.HoTen = dr[2].ToString ();
                    thongtin.NgaySinh = dr[3].ToString ();
                    thongtin.GioiTinh = int.Parse (dr[4].ToString ());
                    thongtin.DiaChi = dr[5].ToString ();
                    thongtin.MaThe = dr[6].ToString ();
                    thongtin.MaDKBD = dr[7].ToString ();
                    thongtin.GtTheTu = dr[8].ToString ();
                    thongtin.GtTheDen = dr[9].ToString ();
                    thongtin.TenBenh = dr[10].ToString ();
                    thongtin.MaBenh = dr[11].ToString ();
                    thongtin.MaBenhKhac = dr[12].ToString ();
                    thongtin.MaLyDoVaoVien = int.Parse (dr[13].ToString ());
                    thongtin.MaNoiChuyen = dr[14].ToString ();
                    thongtin.MaTaiNan = int.Parse (dr[15].ToString ());
                    thongtin.NgayVao = dr[16].ToString ();
                    thongtin.NgayRa = dr[17].ToString ();
                    thongtin.SoNgayDieuTri = int.Parse (dr[18].ToString ());
                    thongtin.KetQuaDieuTri = int.Parse (dr[19].ToString ());
                    thongtin.TinhTrangRaVien = int.Parse (dr[20].ToString ());
                    thongtin.NgayThanhToan = dr[21].ToString ();
                    thongtin.MucHuong = int.Parse (dr[22].ToString ());
                    thongtin.TienThuoc = int.Parse (dr[23].ToString ());
                    thongtin.TienVTYT = int.Parse (dr[24].ToString ());
                    thongtin.TienTongChiPhi = int.Parse (dr[25].ToString ());
                    thongtin.TienBNTT = int.Parse (dr[26].ToString ());
                    thongtin.TienBHTT = int.Parse (dr[27].ToString ());
                    thongtin.TienNguonKhac = int.Parse (dr[28].ToString ());
                    thongtin.TienNgoaiDS = int.Parse (dr[29].ToString ());
                    thongtin.NamQT = dr[30].ToString ();
                    thongtin.ThangQT = dr[31].ToString ();
                    thongtin.MaLoaiKCB = Utils.ToInt(dr[32].ToString ());
                    thongtin.MaKhoa = dr[33].ToString ();
                    thongtin.MaCSKCB = dr[34].ToString ();
                    thongtin.MaKV = dr[35].ToString ();
                    thongtin.MaPTTTQT = dr[36].ToString ();
                    thongtin.CanNang = float.Parse (dr[37].ToString ());
                    thongtin.CheckOut = bool.Parse (dr[38].ToString ());
                    return thongtin;
                }
            }
            return null;
        }
        public DataTable DSThongTinBN (string loaiKCB, string ngayBD,string ngayKT, int phong, int loaiNgay)
        {
            string sql = "";
            if(phong==0)
            {
                sql = "SELECT * FROM getThongtin('" + loaiKCB + "','" + ngayBD + "','" + ngayKT + "'," + loaiNgay + ") ORDER BY MA_BN ASC";
            }
            else
            {
                sql = "SELECT * FROM getThongtin('" + loaiKCB + "','" + ngayBD + "','" + ngayKT + "'," + loaiNgay + ") WHERE PHONG = " + phong+" ORDER BY MA_BN ASC";
            }
           
            return db.ExcuteQuery (sql,
                CommandType.Text, null);
        }
        public DataTable DSTiepNhan  (string ngayBD, string ngayKT, int phong, int tinhTrang = 0, string loaiKCB = null)
        {
            string sql = "";
            if (phong == 0)
            {
                sql = "SELECT * FROM getTiepNhan('" + ngayBD + "','" + ngayKT + "') ";
            }
            else
            {
                sql = "SELECT * FROM getTiepNhan('" + ngayBD + "','" + ngayKT + "') WHERE PHONG = " + phong+" ";
            }
            if(tinhTrang>0 || !string.IsNullOrEmpty (loaiKCB))
            {
                if(phong==0)
                {
                    sql += " WHERE ";
                }
                else
                {
                    sql += " AND ";
                }
                if (!string.IsNullOrEmpty (loaiKCB))
                {
                    sql += " MA_LOAI_KCB='"+loaiKCB+"' ";
                }
                if(tinhTrang>0)
                {
                    sql += " AND ";
                }
            }

            if (tinhTrang == 1)
            {
                sql += " MA_BENH = '' AND NGAY_RA = '' ";
            }
            if (tinhTrang == 2)
            {
                sql += " MA_BENH != '' AND NGAY_RA = '' ";
            }
            if (tinhTrang == 3)
            {
                sql += " MA_BENH != '' AND NGAY_RA != '' ";
            }
            return db.ExcuteQuery (sql,
                CommandType.Text, null);
        }
        public DataTable DSNhomDVKT (string maLK, string maNhom)
        {
            return db.ExcuteQuery ("Select * From DVKT_CT Where MA_LK = '"+maLK+"' And MA_NHOM = '"+maNhom+"'",
                CommandType.Text, null);
        }

        public DataTable DSNhomDVKT (string maLK)
        {
            return db.ExcuteQuery ("Select * From DVKT_CT Where MA_LK = '" + maLK + "' And MA_NHOM != '15' And MA_NHOM !='13' And MA_NHOM != '10'",
                CommandType.Text, null);
        }

        public DataTable DSNhanVien ()
        {
            return db.ExcuteQuery ("Select MA_NHANVIEN,TEN_NHANVIEN From NV_YTE",
                CommandType.Text, null);
        }

        public DataTable DSNhomThuoc (string maLK)
        {
            return db.ExcuteQuery ("Select * From THUOC_CT Where MA_LK = '"+maLK+"'",
                CommandType.Text, null);
        }

        public DataTable DSBenh ()
        {
            return db.ExcuteQuery ("Select MA_BENH,TEN_BENH From BENH_ICD",
                CommandType.Text, null);
        }

        public DataTable DSDuongDung ()
        {
            return db.ExcuteQuery ("Select * From DUONG_DUNG",
                CommandType.Text, null);
        }

        public DataTable DSTaiNan ()
        {
            return db.ExcuteQuery ("Select * From TAI_NAN",
                CommandType.Text, null);
        }

        public DataTable DSCoSoKCB ()
        {
            return db.ExcuteQuery ("Select * From COSOKCB",
                CommandType.Text, null);
        }

        public DataTable DSNhom ()
        {
            return db.ExcuteQuery ("Select * From NHOM order by cast(MAU_01 as float) asc",
                CommandType.Text, null);
        }
        public DataTable DSNhomCanLamSan (int id)
        {
            return db.ExcuteQuery ("Select * From DVKT Where CLS = "+id,
                CommandType.Text, null);
        }
        public bool ThemThongTinCT (ref string err, THONGTIN_CTVO thongtin)
        {
            return db.MyExecuteNonQuery ("SpThemThongTinCT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", thongtin.MaLK),
                new SqlParameter ("@MA_BN", thongtin.MaBN),
                new SqlParameter ("@HO_TEN", thongtin.HoTen),
                new SqlParameter ("@NGAY_SINH", thongtin.NgaySinh),
                new SqlParameter ("@GIOI_TINH", thongtin.GioiTinh),
                new SqlParameter ("@DIA_CHI", thongtin.DiaChi),
                new SqlParameter ("@MA_THE", thongtin.MaThe),
                new SqlParameter ("@MA_DKBD", thongtin.MaDKBD),
                new SqlParameter ("@GT_THE_TU", thongtin.GtTheTu),
                new SqlParameter ("@GT_THE_DEN", thongtin.GtTheDen),
                new SqlParameter ("@TEN_BENH", thongtin.TenBenh),
                new SqlParameter ("@MA_BENH", thongtin.MaBenh),
                new SqlParameter ("@MA_BENHKHAC", thongtin.MaBenhKhac),
                new SqlParameter ("@MA_LYDO_VVIEN", thongtin.MaLyDoVaoVien),
                new SqlParameter ("@MA_NOI_CHUYEN", thongtin.MaNoiChuyen),
                new SqlParameter ("@MA_TAI_NAN", thongtin.MaTaiNan),
                new SqlParameter ("@NGAY_VAO", thongtin.NgayVao),
                new SqlParameter ("@NGAY_RA", thongtin.NgayRa),
                new SqlParameter ("@SO_NGAY_DTRI", thongtin.SoNgayDieuTri),
                new SqlParameter ("@KET_QUA_DTRI", thongtin.KetQuaDieuTri),
                new SqlParameter ("@TINH_TRANG_RV", thongtin.TinhTrangRaVien),
                new SqlParameter ("@NGAY_TTOAN", thongtin.NgayThanhToan),
                new SqlParameter ("@MUC_HUONG", thongtin.MucHuong),
                new SqlParameter ("@T_THUOC", thongtin.TienThuoc),
                new SqlParameter ("@T_VTYT", thongtin.TienVTYT),
                new SqlParameter ("@T_TONGCHI", thongtin.TienTongChiPhi),
                new SqlParameter ("@T_BNTT", thongtin.TienBNTT),
                new SqlParameter ("@T_BHTT", thongtin.TienBHTT),
                new SqlParameter ("@T_NGUONKHAC", thongtin.TienNguonKhac),
                new SqlParameter ("@T_NGOAIDS", thongtin.TienNgoaiDS),
                new SqlParameter ("@NAM_QT", thongtin.NamQT),
                new SqlParameter ("@THANG_QT", thongtin.ThangQT),
                new SqlParameter ("@MA_LOAI_KCB", thongtin.MaLoaiKCB),
                new SqlParameter ("@MA_KHOA", thongtin.MaKhoa),
                new SqlParameter ("@MA_CSKCB", thongtin.MaCSKCB),
                new SqlParameter ("@MA_KHUVUC", thongtin.MaKV),
                new SqlParameter ("@MA_PTTTT_QT", thongtin.MaPTTTQT),
                new SqlParameter ("@CAN_NANG", thongtin.CanNang),
                new SqlParameter ("@CHECK_OUT", thongtin.CheckOut),
                new SqlParameter ("@PHONG", thongtin.Phong),
                new SqlParameter ("@MA_BS", thongtin.MaBS));
        }
        public bool XoaThongTinCT (ref string err, string maLK)
        {
            return db.MyExecuteNonQuery ("SpXoaThongTinCT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", maLK));
        }
        public bool XoaDVKTCT (ref string err, string maLK, string maDVKT)
        {
            return db.MyExecuteNonQuery ("SpXoaDVKTCT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", maLK),
                 new SqlParameter ("@MA_DICH_VU", maDVKT));
        }
        public bool XoaThuocCT (ref string err, string maLK, string maThuoc, string tenThuoc)
        {
            return db.MyExecuteNonQuery ("SpXoaThuocCT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", maLK),
                new SqlParameter ("@MA_THUOC", maThuoc),
                new SqlParameter ("@TEN_THUOC", tenThuoc));

        }
        public bool SuaCheckout(ref string err, string maLK, int c)
        {
            return db.BackUpOrRestore ("UPDATE THONGTIN_CT SET CHECK_OUT = "+c+" WHERE MA_LK = '"+maLK+"'", ref err);
        }
        public bool SuaThongTinCT (ref string err, THONGTIN_CTVO thongtin)
        {
            return db.MyExecuteNonQuery ("SpSuaThongTinCT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", thongtin.MaLK),
                new SqlParameter ("@MA_BN", thongtin.MaBN),
                new SqlParameter ("@HO_TEN", thongtin.HoTen),
                new SqlParameter ("@NGAY_SINH", thongtin.NgaySinh),
                new SqlParameter ("@GIOI_TINH", thongtin.GioiTinh),
                new SqlParameter ("@DIA_CHI", thongtin.DiaChi),
                new SqlParameter ("@MA_THE", thongtin.MaThe),
                new SqlParameter ("@MA_DKBD", thongtin.MaDKBD),
                new SqlParameter ("@GT_THE_TU", thongtin.GtTheTu),
                new SqlParameter ("@GT_THE_DEN", thongtin.GtTheDen),
                new SqlParameter ("@TEN_BENH", thongtin.TenBenh),
                new SqlParameter ("@MA_BENH", thongtin.MaBenh),
                new SqlParameter ("@MA_BENHKHAC", thongtin.MaBenhKhac),
                new SqlParameter ("@MA_LYDO_VVIEN", thongtin.MaLyDoVaoVien),
                new SqlParameter ("@MA_NOI_CHUYEN", thongtin.MaNoiChuyen),
                new SqlParameter ("@MA_TAI_NAN", thongtin.MaTaiNan),
                new SqlParameter ("@NGAY_VAO", thongtin.NgayVao),
                new SqlParameter ("@NGAY_RA", thongtin.NgayRa),
                new SqlParameter ("@SO_NGAY_DTRI", thongtin.SoNgayDieuTri),
                new SqlParameter ("@KET_QUA_DTRI", thongtin.KetQuaDieuTri),
                new SqlParameter ("@TINH_TRANG_RV", thongtin.TinhTrangRaVien),
                new SqlParameter ("@NGAY_TTOAN", thongtin.NgayThanhToan),
                new SqlParameter ("@MUC_HUONG", thongtin.MucHuong),
                new SqlParameter ("@T_THUOC", thongtin.TienThuoc),
                new SqlParameter ("@T_VTYT", thongtin.TienVTYT),
                new SqlParameter ("@T_TONGCHI", thongtin.TienTongChiPhi),
                new SqlParameter ("@T_BNTT", thongtin.TienBNTT),
                new SqlParameter ("@T_BHTT", thongtin.TienBHTT),
                new SqlParameter ("@T_NGUONKHAC", thongtin.TienNguonKhac),
                new SqlParameter ("@T_NGOAIDS", thongtin.TienNgoaiDS),
                new SqlParameter ("@NAM_QT", thongtin.NamQT),
                new SqlParameter ("@THANG_QT", thongtin.ThangQT),
                new SqlParameter ("@MA_LOAI_KCB", thongtin.MaLoaiKCB),
                new SqlParameter ("@MA_KHOA", thongtin.MaKhoa),
                new SqlParameter ("@MA_CSKCB", thongtin.MaCSKCB),
                new SqlParameter ("@MA_KHUVUC", thongtin.MaKV),
                new SqlParameter ("@MA_PTTTT_QT", thongtin.MaPTTTQT),
                new SqlParameter ("@CAN_NANG", thongtin.CanNang),
                new SqlParameter ("@CHECK_OUT", thongtin.CheckOut),
                new SqlParameter ("@PHONG", thongtin.Phong),
                new SqlParameter ("@MA_BS", thongtin.MaBS));
        }
        public bool SuaThuocCT (ref string err, Thuoc_CTVO thuoc)
        {
            return db.MyExecuteNonQuery ("SpSuaThuoc_CT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", thuoc.MaLK),
                new SqlParameter ("@MA_THUOC", thuoc.MaThuoc),
                new SqlParameter ("@TEN_THUOC", thuoc.TenThuoc),
                new SqlParameter ("@DON_VI_TINH", thuoc.DonViTinh),
                new SqlParameter ("@HAM_LUONG", thuoc.HamLuong),
                new SqlParameter ("@DUONG_DUNG", thuoc.DuongDung),
                new SqlParameter ("@LIEU_DUNG", thuoc.LieuDung),
                new SqlParameter ("@SO_DANG_KY", thuoc.SoDK),
                new SqlParameter ("@SO_LUONG", thuoc.SoLuong),
                new SqlParameter ("@DON_GIA", thuoc.DonGia),
                new SqlParameter ("@TYLE_TT", thuoc.TyLeTT),
                new SqlParameter ("@THANH_TIEN", thuoc.ThanhTien),
                new SqlParameter ("@MA_KHOA", thuoc.MaKhoa),
                new SqlParameter ("@MA_BAC_SI", thuoc.MaBacSi),
                new SqlParameter ("@MA_BENH", thuoc.MaBenh),
                new SqlParameter ("@NGAY_YL", thuoc.NgayYL),
                new SqlParameter ("@MA_PTTT", thuoc.MaPTTT),
                new SqlParameter ("@NHOM", thuoc.Nhom));
        }
        public bool ThemThuocCT (ref string err, Thuoc_CTVO thuoc)
        {
            return db.MyExecuteNonQuery ("SpThemThuoc_CT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", thuoc.MaLK),
                new SqlParameter ("@MA_THUOC", thuoc.MaThuoc),
                new SqlParameter ("@TEN_THUOC", thuoc.TenThuoc),
                new SqlParameter ("@DON_VI_TINH", thuoc.DonViTinh),
                new SqlParameter ("@HAM_LUONG", thuoc.HamLuong),
                new SqlParameter ("@DUONG_DUNG", thuoc.DuongDung),
                new SqlParameter ("@LIEU_DUNG", thuoc.LieuDung),
                new SqlParameter ("@SO_DANG_KY", thuoc.SoDK),
                new SqlParameter ("@SO_LUONG", thuoc.SoLuong),
                new SqlParameter ("@DON_GIA", thuoc.DonGia),
                new SqlParameter ("@TYLE_TT", thuoc.TyLeTT),
                new SqlParameter ("@THANH_TIEN", thuoc.ThanhTien),
                new SqlParameter ("@MA_KHOA", thuoc.MaKhoa),
                new SqlParameter ("@MA_BAC_SI", thuoc.MaBacSi),
                new SqlParameter ("@MA_BENH", thuoc.MaBenh),
                new SqlParameter ("@NGAY_YL", thuoc.NgayYL),
                new SqlParameter ("@MA_PTTT", thuoc.MaPTTT),
                new SqlParameter ("@NHOM", thuoc.Nhom));
        }
        public bool ThemDVKTCT (ref string err, DVKT_CTVO dvkt)
        {
            return db.MyExecuteNonQuery ("SpThemDVKT_CT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", dvkt.MaLK),
                new SqlParameter ("@MA_DICH_VU", dvkt.MaDichVu),
                new SqlParameter ("@MA_VAT_TU", dvkt.MaVatTu),
                new SqlParameter ("@MA_NHOM", dvkt.MaNhom),
                new SqlParameter ("@TEN_DICH_VU", dvkt.TenDichVu),
                new SqlParameter ("@DON_VI_TINH", dvkt.DonViTinh),
                new SqlParameter ("@SO_LUONG", dvkt.SoLuong),
                new SqlParameter ("@DON_GIA", dvkt.DonGia),
                new SqlParameter ("@TYLE_TT", dvkt.TyLeTT),
                new SqlParameter ("@THANH_TIEN", dvkt.ThanhTien),
                new SqlParameter ("@MA_KHOA", dvkt.MaKhoa),
                new SqlParameter ("@MA_BAC_SI", dvkt.MaBacSi),
                new SqlParameter ("@MA_BENH", dvkt.MaBenh),
                new SqlParameter ("@NGAY_YL", dvkt.NgayYLenh),
                new SqlParameter ("@NGAY_QK", dvkt.NgayQK),
                new SqlParameter ("@MA_PTTT", dvkt.MaPTTT));
        }
        public bool SuaDVKTCT (ref string err, DVKT_CTVO dvkt)
        {
            return db.MyExecuteNonQuery ("SpSuaDVKT_CT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", dvkt.MaLK),
                new SqlParameter ("@MA_DICH_VU", dvkt.MaDichVu),
                new SqlParameter ("@MA_VAT_TU", dvkt.MaVatTu),
                new SqlParameter ("@MA_NHOM", dvkt.MaNhom),
                new SqlParameter ("@TEN_DICH_VU", dvkt.TenDichVu),
                new SqlParameter ("@DON_VI_TINH", dvkt.DonViTinh),
                new SqlParameter ("@SO_LUONG", dvkt.SoLuong),
                new SqlParameter ("@DON_GIA", dvkt.DonGia),
                new SqlParameter ("@TYLE_TT", dvkt.TyLeTT),
                new SqlParameter ("@THANH_TIEN", dvkt.ThanhTien),
                new SqlParameter ("@MA_KHOA", dvkt.MaKhoa),
                new SqlParameter ("@MA_BAC_SI", dvkt.MaBacSi),
                new SqlParameter ("@MA_BENH", dvkt.MaBenh),
                new SqlParameter ("@NGAY_YL", dvkt.NgayYLenh),
                new SqlParameter ("@NGAY_QK", dvkt.NgayQK),
                new SqlParameter ("@MA_PTTT", dvkt.MaPTTT));
        }
        public bool ChuyenLoaiKCB (ref string err, string MaLK, int MaLoaiKCB,string MaKhoa)
        {
            return db.MyExecuteNonQuery ("SpChuyenLoaiKCB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", MaLK),
                new SqlParameter ("@MA_LOAI_KCB", MaLoaiKCB),
                new SqlParameter ("@MA_KHOA", MaKhoa));
        }
        public bool ChuyenPhongKCB (ref string err, string MaLK, int SoPhong)
        {
            return db.MyExecuteNonQuery ("SpChuyenPhongKCB",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_LK", MaLK),
                new SqlParameter ("@PHONG", SoPhong));
        }
    }

}
