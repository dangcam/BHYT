using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
    public class BaoCaoKSK
    {
        Connection db;
        public BaoCaoKSK()
        {
            this.db = new Connection();
        }
        public DataTable DSDonVi()
        {
            return db.ExcuteQuery("Select * From DONVI",
                CommandType.Text, null);
        }
        public DataTable LaySoLuong(int nam, string maDonVi)
        {
            return db.ExcuteQuery("Select * From SOLUONG_CBCNV where NAM = "+nam+" and MADV = '"+maDonVi+"'",
                CommandType.Text, null);
        }
        public DataTable BCCanLamSanTungDonVi(string sql)
        {
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }
    }
}
