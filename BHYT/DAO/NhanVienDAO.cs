using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class NhanVienDAO
    {
        Connection db = null;
        public NhanVienDAO(Connection db)
        {
            this.db = db;
        }

        public DataTable DSNhanVien ()
        {
            return db.ExcuteQuery ("Select * From NV_YTE",
                CommandType.Text, null);
        }

        public bool ThemNhanVien (ref string err, NhanVienVO nv)
        {
            return db.MyExecuteNonQuery ("SpThemNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_KHOA", nv.MaKhoa),
                new SqlParameter ("@MA_NHANVIEN", nv.MaNhanVien),
                new SqlParameter ("@TEN_NHANVIEN", nv.TenNhanVien),
                new SqlParameter ("@TEN_VIETTAT", nv.TenVT),
                new SqlParameter ("@GIOI_TINH", nv.GioiTinh),
                new SqlParameter ("@NGAY_SINH", nv.NgaySinh),
                new SqlParameter ("@DIA_CHI", nv.DiaChi),
                new SqlParameter ("@DIEN_THOAI", nv.DienThoai),
                new SqlParameter ("@EMAIL", nv.Email),
                new SqlParameter ("@HOCHAM_HOCVI", nv.HocHamHocVi),
                new SqlParameter ("@MA_CHUYENNGANH", nv.MaChuyeNganh),
                new SqlParameter ("@LOAI", nv.LoaiNV),
                new SqlParameter ("@CHUC_DANH", nv.ChucDanh),
                new SqlParameter ("@MA_CCHN", nv.MaCCHN),
                new SqlParameter ("@NGAYCAP_CCHN", nv.NgayCapCCHN),
                new SqlParameter ("@NOICAP_CCHN", nv.NoiCapCCHN),
                new SqlParameter ("@TU_NGAY", nv.TuNgay),
                new SqlParameter ("@DEN_NGAY", nv.DenNgay),
                new SqlParameter ("@VANBANGCM", nv.VanBangCM),
                new SqlParameter ("@THOIGIAN_DK", nv.ThoiGianDK),
                new SqlParameter ("@KHOA_BOPHAN", nv.KhoaBoPhan));
        }
        public bool SuaNhanVien (ref string err, NhanVienVO nv)
        {
            return db.MyExecuteNonQuery ("SpSuaNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_KHOA", nv.MaKhoa),
                new SqlParameter ("@MA_NHANVIEN", nv.MaNhanVien),
                new SqlParameter ("@TEN_NHANVIEN", nv.TenNhanVien),
                new SqlParameter ("@TEN_VIETTAT", nv.TenVT),
                new SqlParameter ("@GIOI_TINH", nv.GioiTinh),
                new SqlParameter ("@NGAY_SINH", nv.NgaySinh),
                new SqlParameter ("@DIA_CHI", nv.DiaChi),
                new SqlParameter ("@DIEN_THOAI", nv.DienThoai),
                new SqlParameter ("@EMAIL", nv.Email),
                new SqlParameter ("@HOCHAM_HOCVI", nv.HocHamHocVi),
                new SqlParameter ("@MA_CHUYENNGANH", nv.MaChuyeNganh),
                new SqlParameter ("@LOAI", nv.LoaiNV),
                new SqlParameter ("@CHUC_DANH", nv.ChucDanh),
                new SqlParameter ("@MA_CCHN", nv.MaCCHN),
                new SqlParameter ("@NGAYCAP_CCHN", nv.NgayCapCCHN),
                new SqlParameter ("@NOICAP_CCHN", nv.NoiCapCCHN),
                new SqlParameter ("@TU_NGAY", nv.TuNgay),
                new SqlParameter ("@DEN_NGAY", nv.DenNgay),
                new SqlParameter ("@VANBANGCM", nv.VanBangCM),
                new SqlParameter ("@THOIGIAN_DK", nv.ThoiGianDK),
                new SqlParameter ("@KHOA_BOPHAN", nv.KhoaBoPhan));
        }
        public bool XoaNhanVien (ref string err, string ma)
        {
            return db.MyExecuteNonQuery ("SpXoaNhanVien",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_NHANVIEN", ma));
        }
    }
}
