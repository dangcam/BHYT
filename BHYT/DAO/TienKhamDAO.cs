using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class TienKhamDAO
    {
        Connection db = null;
        public TienKhamDAO (Connection db)
        {
            this.db = db;
        }
        public DataTable NhomChiPhi (string ma)
        {
            return db.ExcuteQuery ("Select * From TIEN_KHAM",
                CommandType.Text, null);
        }

        public DataTable DSTienKham ()
        {
            return db.ExcuteQuery ("Select * From TIEN_KHAM",
                CommandType.Text, null);
        }
        public DataTable DSCongKham ()
        {
            return db.ExcuteQuery ("Select MA AS MA_DICH_VU,TEN AS TEN_DICH_VU,DON_VI AS DON_VI_TINH,DON_GIA,MA_NHOM, 1 AS SO_LUONG,DON_GIA AS THANH_TIEN From TIEN_KHAM",
                CommandType.Text, null);
        }
        public bool ThemTienKham (ref string err, TienGiuongVO tGiuong)
        {
            return db.MyExecuteNonQuery ("SpThemTienKham",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA", tGiuong.Ma),
                new SqlParameter ("@MA_CK", tGiuong.MaKhoa),
                new SqlParameter ("@MA_TT37", tGiuong.MaTT37),
                new SqlParameter ("@TEN", tGiuong.Ten),
                new SqlParameter ("@DON_GIA", tGiuong.DonGia),
                new SqlParameter ("@DON_VI", tGiuong.DonVi),
                new SqlParameter ("@TU_NGAY", tGiuong.TuNgay),
                new SqlParameter ("@DEN_NGAY", tGiuong.DenNgay),
                new SqlParameter ("@MA_NHOM", tGiuong.MaNhom));
        }
        public bool SuaTienKham (ref string err, TienGiuongVO tGiuong)
        {
            return db.MyExecuteNonQuery ("SpSuaTienKham",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA", tGiuong.Ma),
                new SqlParameter ("@MA_CK", tGiuong.MaKhoa),
                new SqlParameter ("@MA_TT37", tGiuong.MaTT37),
                new SqlParameter ("@TEN", tGiuong.Ten),
                new SqlParameter ("@DON_GIA", tGiuong.DonGia),
                new SqlParameter ("@DON_VI", tGiuong.DonVi),
                new SqlParameter ("@TU_NGAY", tGiuong.TuNgay),
                new SqlParameter ("@DEN_NGAY", tGiuong.DenNgay),
                new SqlParameter ("@MA_NHOM", tGiuong.MaNhom));
        }
        public bool XoaTienKham (ref string err, string ma)
        {
            return db.MyExecuteNonQuery ("SpXoaTienKham",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA", ma));
        }
    }
}
