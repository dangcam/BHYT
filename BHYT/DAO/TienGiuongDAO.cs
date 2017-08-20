using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class TienGiuongDAO
    {
        Connection db = null;
        public TienGiuongDAO (Connection db)
        {
            this.db = db;
        }
        public DataTable DSTienGiuong ()
        {
            return db.ExcuteQuery ("Select * From TIEN_GIUONG",
                CommandType.Text, null);
        }
        public DataTable DSKhoa ()
        {
            return db.ExcuteQuery ("Select * From KHOA",
                CommandType.Text, null);
        }
        public DataTable DSGiuong ()
        {
            return db.ExcuteQuery ("Select MA,TEN,DON_GIA,DON_VI,MA_NHOM From TIEN_GIUONG",
                CommandType.Text, null);
        }

        public DataTable DSNhanVien ()
        {
            return db.ExcuteQuery ("Select MA_NHANVIEN,TEN_NHANVIEN From NV_YTE",
                CommandType.Text, null);
        }

        public DataTable DSTienKham ()
        {
            return db.ExcuteQuery ("Select * From TIEN_KHAM",
                CommandType.Text, null);
        }

        public bool ThemTienGiuong (ref string err, TienGiuongVO tGiuong)
        {
            return db.MyExecuteNonQuery ("SpThemTienGiuong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA", tGiuong.Ma),
                new SqlParameter ("@MA_KHOA", tGiuong.MaKhoa),
                new SqlParameter ("@MA_TT37", tGiuong.MaTT37),
                new SqlParameter ("@TEN", tGiuong.Ten),
                new SqlParameter ("@DON_GIA", tGiuong.DonGia),
                new SqlParameter ("@DON_VI", tGiuong.DonVi),
                new SqlParameter ("@TU_NGAY", tGiuong.TuNgay),
                new SqlParameter ("@DEN_NGAY", tGiuong.DenNgay),
                new SqlParameter("@MA_NHOM",tGiuong.MaNhom));
        }
        public bool SuaTienGiuong (ref string err, TienGiuongVO tGiuong)
        {
            return db.MyExecuteNonQuery ("SpSuaTienGiuong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA", tGiuong.Ma),
                new SqlParameter ("@MA_KHOA", tGiuong.MaKhoa),
                new SqlParameter ("@MA_TT37", tGiuong.MaTT37),
                new SqlParameter ("@TEN", tGiuong.Ten),
                new SqlParameter ("@DON_GIA", tGiuong.DonGia),
                new SqlParameter ("@DON_VI", tGiuong.DonVi),
                new SqlParameter ("@TU_NGAY", tGiuong.TuNgay),
                new SqlParameter ("@DEN_NGAY", tGiuong.DenNgay),
                new SqlParameter ("@MA_NHOM", tGiuong.MaNhom));
        }
        public bool XoaTienGiuong (ref string err, string ma)
        {
            return db.MyExecuteNonQuery ("SpXoaTienGiuong",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA", ma));
        }
    }
}
