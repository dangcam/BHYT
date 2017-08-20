using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class KCBDAO
    {
        Connection db;
        public KCBDAO(Connection db)
        {
            this.db = db;
        }
        public DataTable DSKCB ()
        {
            return db.ExcuteQuery ("Select * From COSOKCB",
                CommandType.Text, null);
        }
        public bool ThemCoSoKCB (ref string err, KCBVO kcb)
        {
            return db.MyExecuteNonQuery ("SpThemCoSo",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA", kcb.Ma),
                new SqlParameter ("@TEN", kcb.Ten),
                new SqlParameter ("@DIACHI", kcb.DiaChi));
        }
    }
}
