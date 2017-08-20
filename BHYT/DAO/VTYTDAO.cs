using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class VTYTDAO
    {
        Connection db;
        public VTYTDAO(Connection db)
        {
            this.db = db;
        }
        public DataTable DSVTYT ()
        {
            return db.ExcuteQuery ("Select * From VTYT",
                CommandType.Text, null);
        }

        public bool ThemVTYT (ref string err, VTYTVO vtyt)
        {
            return db.MyExecuteNonQuery ("SpThemVTYT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_VTYT", vtyt.MaVTY),
                new SqlParameter ("@TEN_VTYT", vtyt.TenVTYT),
                new SqlParameter ("@TEN_BV", vtyt.TenBV),
                new SqlParameter ("@DON_GIA", vtyt.DonGia),
                new SqlParameter ("@DON_VI_TINH", vtyt.DonViTinh),
                new SqlParameter ("@QUYET_DINH", vtyt.QuyetDinh),
                new SqlParameter ("@CONG_BO", vtyt.CongBo),
                new SqlParameter ("@MA_NHOM", vtyt.MaNhom));
        }
        public bool SuaVTYT (ref string err, VTYTVO vtyt)
        {
            return db.MyExecuteNonQuery ("SpSuaVTYT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_VTYT", vtyt.MaVTY),
                new SqlParameter ("@TEN_VTYT", vtyt.TenVTYT),
                new SqlParameter ("@TEN_BV", vtyt.TenBV),
                new SqlParameter ("@DON_GIA", vtyt.DonGia),
                new SqlParameter ("@DON_VI_TINH", vtyt.DonViTinh),
                new SqlParameter ("@QUYET_DINH", vtyt.QuyetDinh),
                new SqlParameter ("@CONG_BO", vtyt.CongBo),
                new SqlParameter ("@MA_NHOM", vtyt.MaNhom));
        }
        public bool XoaVTYT (ref string err, string ma, string ten, string tenBV)
        {
            return db.MyExecuteNonQuery ("SpXoaVTYT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_VTYT",ma),
                new SqlParameter ("@TEN_VTYT",ten),
                new SqlParameter ("@TEN_BV", tenBV));
        }
    }
}
