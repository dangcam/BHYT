using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class KhoaDAO
    {
        Connection db = null;
        public KhoaDAO(Connection db)
        {
            this.db = db;
        }
        public DataTable DSKhoa ()
        {
            return db.ExcuteQuery ("Select  * From KHOA",
                CommandType.Text, null);
        }
        public bool ThemKhoa (ref string err, KhoaVO khoa)
        {
            return db.MyExecuteNonQuery ("SpThemKhoa",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_KHOA", khoa.MaKhoa),
                new SqlParameter ("@TEN_KHOA", khoa.TenKhoa),
                new SqlParameter ("@CHI_TIET", khoa.ChiTiet));
        }
        public bool XoaKhoa (ref string err, string MaKhoa)
        {
            return db.MyExecuteNonQuery ("SpXoaKhoa",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_KHOA", MaKhoa));
        }
    }
}
