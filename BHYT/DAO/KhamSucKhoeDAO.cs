using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
    public class KhamSucKhoeDAO
    {
        Connection db;
        public KhamSucKhoeDAO()
        {
            this.db = new Connection();
        }
        public KhamSucKhoeDAO(Connection db)
        {
            this.db = db;
        }
        public DataTable DSThongTinBN(string MaThe)
        {
            return db.ExcuteQuery("Select * From THONGTIN Where MA_THE ='"+MaThe+"'",
                CommandType.Text, null);
        }
        public DataTable ThongTinKSK(string MaLK)
        {
            return db.ExcuteQuery("Select * From KHAM_SUC_KHOE Where MA_LK ='" + MaLK + "'",
                CommandType.Text, null);
        }
        public DataTable DSDonVi()
        {
            return db.ExcuteQuery("Select  * From DONVI",
                CommandType.Text, null);
        }
        public bool SpKhamSucKhoe(ref string err, string Action, KhamSucKhoeVO ksk)
        {
            return db.MyExecuteNonQuery("SpKhamSucKhoe",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@Action", Action),
                new SqlParameter("@MA_LK", ksk.MA_LK),
                new SqlParameter("@LOAI_KHAM", ksk.LOAI_KHAM),
                new SqlParameter("@CHIEU_CAO", ksk.CHIEU_CAO),
                new SqlParameter("@CAN_NANG", ksk.CAN_NANG),
                new SqlParameter("@MACH", ksk.MACH),
                new SqlParameter("@HUYET_AP", ksk.HUYET_AP),
                new SqlParameter("@PL_THELUC", ksk.PL_THELUC),
                new SqlParameter("@TIENSU_BT", ksk.TIENSU_BT),
                new SqlParameter("@TUAN_HOAN", ksk.TUAN_HOAN),
                new SqlParameter("@PL_TUANHOAN", ksk.PL_TUANHOAN),
                new SqlParameter("@HO_HAP", ksk.HO_HAP),
                new SqlParameter("@PL_HOHAP", ksk.PL_HOHAP),
                new SqlParameter("@TIEU_HOA", ksk.TIEU_HOA),
                new SqlParameter("@PL_TIEUHOA", ksk.PL_TIEUHOA),
                new SqlParameter("@TIET_NIEU", ksk.TIET_NIEU),
                new SqlParameter("@PL_TIETNIEU", ksk.PL_TIETNIEU),
                new SqlParameter("@NOI_TIET", ksk.NOI_TIET),
                new SqlParameter("@PL_NOITIET", ksk.PL_NOITIET),
                new SqlParameter("@CO_KHOP", ksk.CO_KHOP),
                new SqlParameter("@PL_COKHOP", ksk.PL_COKHOP),
                new SqlParameter("@THAN_KINH", ksk.THAN_KINH),
                new SqlParameter("@PL_THANKINH", ksk.PL_THANKINH),
                new SqlParameter("@TAM_THAN", ksk.TAM_THAN),
                new SqlParameter("@PL_TAMTHAN", ksk.PL_TAMTHAN),
                new SqlParameter("@KKINH_MP", ksk.KKINH_MP),
                new SqlParameter("@KKINH_MT", ksk.KKINH_MT),
                new SqlParameter("@CKINH_MP", ksk.CKINH_MP),
                new SqlParameter("@CKINH_MT", ksk.CKINH_MT),
                new SqlParameter("@BVE_MAT", ksk.BVE_MAT),
                new SqlParameter("@PL_BVM", ksk.PL_BVM),
                new SqlParameter("@NTHUONG_TT", ksk.NTHUONG_TT),
                new SqlParameter("@NTHAM_TT", ksk.NTHAM_TT),
                new SqlParameter("@NTHUONG_TP", ksk.NTHUONG_TP),
                new SqlParameter("@NTHAM_TP", ksk.NTHAM_TP),
                new SqlParameter("@BENH_TMH", ksk.BENH_TMH),
                new SqlParameter("@PL_BENHTMH", ksk.PL_BENHTMH),
                new SqlParameter("@HAM_TREN", ksk.HAM_TREN),
                new SqlParameter("@HAM_DUOI", ksk.HAM_DUOI),
                new SqlParameter("@BENH_RHM", ksk.BENH_RHM),
                new SqlParameter("@PL_BENHRHM", ksk.PL_BENHRHM),
                new SqlParameter("@DA_LIEU", ksk.DA_LIEU),
                new SqlParameter("@PL_DALIEU", ksk.PL_DALIEU),
                new SqlParameter("@PHU_KHOA", ksk.PHU_KHOA),
                new SqlParameter("@PL_PHUKHOA", ksk.PL_PHUKHOA),
                new SqlParameter("@DAT_VONG", ksk.DAT_VONG),
                new SqlParameter("@GYNOFAR", ksk.GYNOFAR),
                new SqlParameter("@TAY_GIUN", ksk.TAY_GIUN),
                new SqlParameter("@PAP", ksk.PAP),
                new SqlParameter("@SOI_TUOI", ksk.SOI_TUOI),
                new SqlParameter("@CHUP_NHU_ANH", ksk.CHUP_NHU_ANH),
                new SqlParameter("@XQ_TIM_PHOI", ksk.XQ_TIM_PHOI),
                new SqlParameter("@XQ_CSTL", ksk.XQ_CSTL),
                new SqlParameter("@XQ_KHAC", ksk.XQ_KHAC),
                new SqlParameter("@SA_TQ", ksk.SA_TQ),
                new SqlParameter("@SA_TVU", ksk.SA_TVU),
                new SqlParameter("@SA_TGIAP", ksk.SA_TGIAP),
                new SqlParameter("@SA_TIM", ksk.SA_TIM),
                new SqlParameter("@DO_DIEN_TIM", ksk.DO_DIEN_TIM),
                new SqlParameter("@DO_LOANGX", ksk.DO_LOANGX),
                new SqlParameter("@DO_THINHL", ksk.DO_THINHL),
                new SqlParameter("@NS_DADAY", ksk.NS_DADAY),
                new SqlParameter("@NS_DAITRANG", ksk.NS_DAITRANG),
                new SqlParameter("@NS_TMH", ksk.NS_TMH),
                new SqlParameter("@SINH_THIET", ksk.SINH_THIET),
                new SqlParameter("@CHUP_CT", ksk.CHUP_CT),
                new SqlParameter("@CHUP_MRI", ksk.CHUP_MRI),
                new SqlParameter("@NHOM_MAU", ksk.NHOM_MAU),
                new SqlParameter("@XN_HH", ksk.XN_HH),
                new SqlParameter("@SH_NT", ksk.SH_NT),
                new SqlParameter("@SINH_HM", ksk.SINH_HM),
                new SqlParameter("@XN_KHAC", ksk.XN_KHAC),
                new SqlParameter("@PL_SK", ksk.PL_SK),
                new SqlParameter("@DIEU_TRI", ksk.DIEU_TRI),
                new SqlParameter("@KET_LUAN", ksk.KET_LUAN),
                new SqlParameter("@DE_NGHI", ksk.DE_NGHI));
        }
        public bool SuaThongTinKSK(ref string err, string MaThe, string MaDV, string ChucVu,string ToNT)
        {
            return db.MyExecuteNonQuery("SpSuaThongTinKSK",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MA_THE", MaThe),
                 new SqlParameter("@MADV", MaDV),
                new SqlParameter("@CHUC_VU", ChucVu),
                new SqlParameter("@TO_NT", ToNT));
        }
    }
}
