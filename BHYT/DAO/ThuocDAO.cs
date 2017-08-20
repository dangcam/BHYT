using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class ThuocDAO
    {
        Connection db;
        public ThuocDAO(Connection db)
        {
            this.db = db;
        }
        public DataTable DSThuoc ()
        {
            return db.ExcuteQuery ("Select * From TIEN_THUOC Where TINH_TRANG = 1",
                CommandType.Text, null);
        }

        public DataTable DSDVKT ()
        {
            return db.ExcuteQuery ("Select * From DVKT",
                CommandType.Text, null);
        }

        public DataTable DSVTYT ()
        {
            return db.ExcuteQuery ("Select * From VTYT",
                CommandType.Text, null);
        }

        public DataTable DSTienThuoc ()
        {
            return db.ExcuteQuery ("Select * From TIEN_THUOC",
                CommandType.Text, null);
        }

        public DataTable DSDuongDung ()
        {
            return db.ExcuteQuery ("Select * From DUONG_DUNG",
                CommandType.Text, null);
        }

        public DataTable DSKhoa ()
        {
            return db.ExcuteQuery ("Select * From KHOA",
                CommandType.Text, null);
        }

        public DataTable DSNhanVien ()
        {
            return db.ExcuteQuery ("Select MA_NHANVIEN,TEN_NHANVIEN From NV_YTE",
                CommandType.Text, null);
        }

        public bool ThemThuoc (ref string err, ThuocVO thuoc)
        {
            return db.MyExecuteNonQuery ("SpThemThuoc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_NHOM", thuoc.MaNhom),
                new SqlParameter ("@MA_HOAT_CHAT", thuoc.MaHoatChat),
                new SqlParameter ("@HOAT_CHAT", thuoc.HoatChat),
                new SqlParameter ("@MA_DUONG_DUNG", thuoc.MaDuongDung),
                new SqlParameter ("@DUONG_DUNG",thuoc.DuongDung ),
                new SqlParameter ("@HAM_LUONG",thuoc.HamLuong ),
                new SqlParameter ("@TEN_THUOC", thuoc.TenThuoc),
                new SqlParameter ("@SO_DANG_KY", thuoc.SoDangKy),
                new SqlParameter ("@DONG_GOI", thuoc.DongGoi),
                new SqlParameter ("@DON_VI_TINH", thuoc.DonViTinh),
                new SqlParameter ("@DON_GIA", thuoc.DonGia),
                new SqlParameter ("@DON_GIA_TT", thuoc.DonGiaTT),
                new SqlParameter ("@SO_LUONG", thuoc.SoLuong),
                new SqlParameter ("@MA_CSKCB", thuoc.MaCSKCB),
                new SqlParameter ("@HANG_SX", thuoc.HangSX),
                new SqlParameter ("@NUOC_SX", thuoc.NuocSX),
                new SqlParameter ("@NHA_THAU", thuoc.NhaThau), 
                new SqlParameter ("@QUYET_DINH", thuoc.QuyetDinh),
                new SqlParameter ("@CONG_BO", thuoc.CongBo),
                new SqlParameter ("@MA_THUOC_BV", thuoc.MaThuocBV),
                new SqlParameter ("@LOAI_THAU", thuoc.LoaiThau),
                new SqlParameter ("@NHOM_THAU", thuoc.NhomThau),
                new SqlParameter ("@TINH_TRANG", thuoc.TinhTrang));
        }
        public bool ThemTienThuoc (ref string err, TienThuocVO thuoc)
        {
            return db.MyExecuteNonQuery ("SpThemTienThuoc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_THUOC", thuoc.MaThuoc),
                new SqlParameter ("@TEN_THUOC", thuoc.TenThuoc),
                new SqlParameter ("@HOAT_CHAT", thuoc.HoatChat),
                new SqlParameter ("@HAM_LUONG", thuoc.HamLuong),
                new SqlParameter ("@DUONG_DUNG", thuoc.DuongDung),
                new SqlParameter ("@QUY_CACH", thuoc.QuyCach),
                new SqlParameter ("@TIEUCHUAN", thuoc.TieuChuan),
                new SqlParameter ("@DON_VI_TINH", thuoc.DonViTinh),
                new SqlParameter ("@DON_GIA", thuoc.DonGia),
                new SqlParameter ("@SO_DK", thuoc.SoDK),
                new SqlParameter ("@QUYET_DINH", thuoc.QuyetDinh),
                new SqlParameter ("@NHA_SX", thuoc.NhaSX),
                new SqlParameter ("@NUOC_SX", thuoc.NuocSX),
                new SqlParameter ("@HANDUNG", thuoc.HanDung),
                new SqlParameter ("@NHOM_THUOC", thuoc.NhomThuoc),
                new SqlParameter ("@NHOM", thuoc.Nhom),
                new SqlParameter ("@TINH_TRANG", thuoc.TinhTrang));
        }
        public bool XoaThuoc (ref string err, string ma, string ten, int gia)
        {
            return db.MyExecuteNonQuery ("SpXoaThuoc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_THUOC", ma),
                new SqlParameter ("@TEN_THUOC", ten),
                new SqlParameter ("@DON_GIA", gia));
        }
        public bool SuaTinhTrangThuoc (ref string err, string ma, string ten, int gia, bool tt)
        {
            return db.MyExecuteNonQuery ("SpSuaTinhTrangThuoc",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_THUOC", ma),
                new SqlParameter ("@TEN_THUOC", ten),
                new SqlParameter ("@DON_GIA", gia),
                new SqlParameter ("@TINH_TRANG", tt));
        }
    }
}
