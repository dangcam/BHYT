using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class THONGTINDAO
    {
        Connection db = null;
        public THONGTINDAO(Connection db)
        {
            this.db = db;
        }

        public THONGTINVO getBHYT(string maThe, string ngayvao = null)
        {
            THONGTINVO thongtin = new THONGTINVO ();
            if (ngayvao == null)
            {
                ngayvao = DateTime.Now.ToString ("yyyyMMdd");
            }
            DataTable data = db.ExcuteQuery ("Select * From getBHYT('" + maThe +"','"+ngayvao+"')",
               CommandType.Text, null);
            if (data != null && data.Rows.Count > 0)
            {
                thongtin.MaThe = data.Rows[0][0].ToString ();
                thongtin.HoTen = data.Rows[0][1].ToString ();
                thongtin.NgaySinh = data.Rows[0][2].ToString ();
                try
                {
                    thongtin.GioiTinh = int.Parse (data.Rows[0][3].ToString ());
                }
                catch { }
                thongtin.DiaChi = data.Rows[0][4].ToString ();
                thongtin.GtTheTu = data.Rows[0][5].ToString ();
                thongtin.GtTheDen = data.Rows[0][6].ToString ();
                thongtin.MaKV = data.Rows[0][7].ToString ();
                thongtin.MaLK = data.Rows[0][8].ToString ();
                return thongtin;
            }

            return null;
        }
        public bool ThemThongTin (ref string err, THONGTINVO bn)
        {
            return db.MyExecuteNonQuery ("SpThemThongTin",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_THE", bn.MaThe),
                new SqlParameter ("@HO_TEN", bn.HoTen),
                new SqlParameter ("@NGAY_SINH", bn.NgaySinh),
                new SqlParameter ("@GIOI_TINH", bn.GioiTinh),
                new SqlParameter ("@DIA_CHI", bn.DiaChi),
                new SqlParameter ("@GT_THE_TU", bn.GtTheTu),
                new SqlParameter ("@GT_THE_DEN", bn.GtTheDen),
                new SqlParameter ("@MA_KHUVUC", bn.MaKV));
        }
        public bool SuaThongTin (ref string err, THONGTINVO bn)
        {
            return db.MyExecuteNonQuery ("SpSuaThongTin",
                CommandType.StoredProcedure, ref err,
                new SqlParameter ("@MA_THE", bn.MaThe),
                new SqlParameter ("@HO_TEN", bn.HoTen),
                new SqlParameter ("@NGAY_SINH", bn.NgaySinh),
                new SqlParameter ("@GIOI_TINH", bn.GioiTinh),
                new SqlParameter ("@DIA_CHI", bn.DiaChi),
                new SqlParameter ("@GT_THE_TU", bn.GtTheTu),
                new SqlParameter ("@GT_THE_DEN", bn.GtTheDen),
                new SqlParameter ("@MA_KHUVUC", bn.MaKV));
        }
    }
}
