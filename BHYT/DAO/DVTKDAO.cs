using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class DVTKDAO
    {
        Connection db = null;
        public DVTKDAO(Connection db)
        {
            this.db = db;
        }
        public DataTable DSDVKT ()
        {
            return db.ExcuteQuery ("Select * From DVKT",
                CommandType.Text, null);
        }

        public DataTable DSCanLamSan ()
        {
            return db.ExcuteQuery ("Select MA_DVKT,TEN_DVKT,MA_NHOM From DVKT WHERE CLS IS NULL",
                CommandType.Text, null);
        }

        public DataTable DSCanLamSan (string id)
        {
            return db.ExcuteQuery ("Select MA_DVKT,TEN_DVKT,MA_NHOM From DVKT WHERE CLS = '" + id+"'",
                CommandType.Text, null);
        }
        public DataTable DSCLS ()
        {
            return db.ExcuteQuery ("Select * From NHOMCLS",
                CommandType.Text, null);
        }

        public bool ThemDVKT (ref string err, DVKTVO dvkt)
        {
            return db.MyExecuteNonQuery ("SpThemDVKT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_NHOM", dvkt.MaNhom),
                new SqlParameter ("@MA_DVKT", dvkt.MaDVKT),
                new SqlParameter ("@TEN_DVKT", dvkt.TenDVKT),
                new SqlParameter ("@MA_GIA", dvkt.MaGia),
                new SqlParameter ("@DON_GIA", dvkt.DonGia),
                new SqlParameter ("@GIA_AX", dvkt.GiaAX),
                new SqlParameter ("@QUYET_DINH", dvkt.QuyetDinh),
                new SqlParameter ("@CONG_BO",dvkt.CongBo),
                new SqlParameter ("@DON_VI_TINH", dvkt.DonViTinh));
        }
        public bool SuaDVKT (ref string err, DVKTVO dvkt)
        {
            return db.MyExecuteNonQuery ("SpSuaDVKT",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_NHOM", dvkt.MaNhom),
                new SqlParameter ("@MA_DVKT", dvkt.MaDVKT),
                new SqlParameter ("@TEN_DVKT", dvkt.TenDVKT),
                new SqlParameter ("@MA_GIA", dvkt.MaGia),
                new SqlParameter ("@DON_GIA", dvkt.DonGia),
                new SqlParameter ("@GIA_AX", dvkt.GiaAX),
                new SqlParameter ("@QUYET_DINH", dvkt.QuyetDinh),
                new SqlParameter ("@CONG_BO", dvkt.CongBo),
                new SqlParameter ("@DON_VI_TINH", dvkt.DonViTinh));
        }
        public bool XoaDVKT (ref string err, string ma, string ten)
        {
            return db.BackUpOrRestore ("delete DVKT where MA_DVKT = '"+ma+"' and TEN_DVKT = N'"+ten+"'", ref err);
        }

        public DataTable DSNhom ()
        {
            return db.ExcuteQuery ("Select * From NHOM Where MA_NHOM = '1' OR MA_NHOM = '2' OR MA_NHOM = '3' OR MA_NHOM = '7' " +
                "OR MA_NHOM = '8' OR MA_NHOM = '9' OR MA_NHOM = '12' ",
                CommandType.Text, null);
        }
        public bool ThemCanLamSan (ref string err,string ten)
        {
            return db.MyExecuteNonQuery ("SpThemCanLamSan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@TEN",ten));
        }
        public bool SuaCanLamSan (ref string err,int id, string ten)
        {
            return db.MyExecuteNonQuery ("SpSuaCanLamSan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@ID", id),
                new SqlParameter ("@TEN", ten));
        }
        public bool SuaDVKTCLS (ref string err, string maDVKT, string cls)
        {
            return db.MyExecuteNonQuery ("SpSuaDVKTCLS",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_DVKT", maDVKT),
                new SqlParameter ("@CLS", cls));
        }
    }
}
