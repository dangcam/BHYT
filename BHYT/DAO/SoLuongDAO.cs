using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
    public class SoLuongDAO
    {
        Connection db = null;
        public SoLuongDAO(Connection db)
        {
            this.db = db;
        }
        public SoLuongDAO()
        {
            this.db = new Connection();
        }
        public DataTable DSSoLuong(int nam)
        {
            return db.ExcuteQuery("Select * From SOLUONG_CBCNV,DONVI Where DONVI.MADV = SOLUONG_CBCNV.MADV And NAM = " + nam,
                CommandType.Text, null);
        }
        public DataTable DSDonVi()
        {
            return db.ExcuteQuery("Select * From DONVI",
                CommandType.Text, null);
        }
        public bool SpSoLuong(ref string err,string Action, int Nam, string MaDV, int SoLuong)
        {
            return db.MyExecuteNonQuery("SpSoLuongCBCNV",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action",Action),
                new SqlParameter("@NAM", Nam),
                new SqlParameter("@MADV", MaDV),
                new SqlParameter("@SOLUONG", SoLuong));
        }
    }
}
