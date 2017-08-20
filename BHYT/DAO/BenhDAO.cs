using BHYT.VO;
using System.Data;
using System.Data.SqlClient;

namespace BHYT.DAO
{
    public class BenhDAO
    {
        Connection db = null;
        public BenhDAO(Connection db)
        {
            this.db = db;
        }
        public DataTable DSBenh ()
        {
            return db.ExcuteQuery ("Select * From BENH_ICD",
                CommandType.Text, null);
        }
        public bool ThemBenh (ref string err, BenhVO benh)
        {
            return db.MyExecuteNonQuery ("SpThemBenh",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_BENH", benh.MaBenh),
                new SqlParameter ("@TEN_BENH", benh.TenBenh),
                new SqlParameter ("@MA_LOAI", benh.MaLoai),
                new SqlParameter ("@MA_NHOM", benh.MaNhom));
        }
    }
}
