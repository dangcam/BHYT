using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
    class CanLamSanDAO
    {
        Connection db;
        public CanLamSanDAO(Connection db)
        {
            this.db = db;
        }
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public string Phong { get; set; }
        public string Nhom { get; set; }
        public string MauSo { get; set; }
        public DataTable DSNhomDVKT()
        {
            return db.ExcuteQuery("Select MA_NHOM,TEN_NHOM From NHOM WHERE MA_NHOM!='10' AND MA_NHOM!='13'"
                + "AND  MA_NHOM!='11' AND MA_NHOM!='14' AND MA_NHOM!='15' AND MA_NHOM!='4' AND MA_NHOM!='5' AND MA_NHOM!='6'",
                CommandType.Text, null);
        }
        public DataTable DSNhomCanLamSan()
        {
            return db.ExcuteQuery("Select * From NHOMCLS",
                CommandType.Text, null);
        }
        public DataTable DSChiDinhCanLamSan(string maLK)
        {
            return db.ExcuteQuery("Select * From getChiDinhCLS('"+maLK+"')",
                CommandType.Text, null);
        }
        public bool NhomCanLamSan(ref string err,string Action)
        {
            return db.MyExecuteNonQuery("SpNhomCanLamSan",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action", Action),
                new SqlParameter("@MaNhom", MaNhom),
                new SqlParameter("@TenNhom", TenNhom),
                new SqlParameter("@Phong", Phong),
                new SqlParameter("@NhomChinh",Nhom),
                new SqlParameter("@MauSo", MauSo));
        }
    }
}
