using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class ThongKeDAO
    {
        Connection db;
        public ThongKeDAO(Connection db)
        {
            this.db = db;
        }
        public DataTable DSThongKe (string ngayBD, string ngayKT)
        {
            return db.ExcuteQuery ("SELECT * FROM getThongKe('" + ngayBD + "','" + ngayKT + "')",
                CommandType.Text, null);
        }
        public DataTable DSThongTinBN (int loaiKCB, string ngayBD, string ngayKT)
        {
            string sql = "";
            if (loaiKCB == 0)
            {
                sql = "SELECT * FROM getThongTinBN('" + ngayBD + "','" + ngayKT + "') ORDER BY MA_BN ASC";
            }
            else
            {
                sql = "SELECT * FROM getThongTinBN('" + ngayBD + "','" + ngayKT + "') WHERE MA_LOAI_KCB = " + loaiKCB + " ORDER BY MA_BN ASC";
            }
            return db.ExcuteQuery (sql,
                CommandType.Text, null);
        }
        public DataTable DSVienPhi(int loaiKCB, string ngayBD, string ngayKT)
        {
            string sql = "";
            sql = "EXEC SpgetVienPhi "+ loaiKCB +" ,'" + ngayBD + "','" + ngayKT + "'";
            return db.ExcuteQuery(sql,
                CommandType.Text, null);
        }

        public DataTable DSThuoc (string maLK)
        {
            return db.ExcuteQuery ("Select TEN_THUOC,SO_LUONG From THUOC_CT Where MA_LK = '" + maLK + "'",
                 CommandType.Text, null);
        }
        public DataTable DSThongKeThuocSL (int soLuong, string ngayBD, string ngayKT, int loaiKCB)
        {
            string sql = "SELECT * FROM getThongKeThuoc('" + soLuong + "','" + ngayBD + "','" + ngayKT + "') ";
            if(loaiKCB!=0)
            {
                sql += " WHERE MA_LOAI_KCB=" + loaiKCB;
            }
            sql += " ORDER BY SO_LUONG DESC";
            return db.ExcuteQuery (sql,
                CommandType.Text, null);
        }
        public DataTable DSThongKeThuocCP (int soLuong, string ngayBD, string ngayKT)
        {
            return db.ExcuteQuery ("SELECT * FROM getThongKeThuoc('" + soLuong + "','" + ngayBD + "','" + ngayKT + "') ORDER BY THANH_TIEN DESC",
                CommandType.Text, null);
        }
        public DataTable DSThongKeDVKTSL (int soLuong, string ngayBD, string ngayKT)
        {
            return db.ExcuteQuery ("SELECT * FROM getThongKeDVKT('" + soLuong + "','" + ngayBD + "','" + ngayKT + "') ORDER BY SO_LUONG DESC",
                CommandType.Text, null);
        }
        public DataTable DSThongKeDVKTCP (int soLuong, string ngayBD, string ngayKT)
        {
            return db.ExcuteQuery ("SELECT * FROM getThongKeDVKT('" + soLuong + "','" + ngayBD + "','" + ngayKT + "') ORDER BY THANH_TIEN DESC",
                CommandType.Text, null);
        }
        public DataTable DSThongKeVTYTSL (int soLuong, string ngayBD, string ngayKT)
        {
            return db.ExcuteQuery ("SELECT * FROM getThongKeVTYT('" + soLuong + "','" + ngayBD + "','" + ngayKT + "') ORDER BY SO_LUONG DESC",
                CommandType.Text, null);
        }
        public DataTable DSThongKeVTYTCP (int soLuong, string ngayBD, string ngayKT)
        {
            return db.ExcuteQuery ("SELECT * FROM getThongKeVTYT('" + soLuong + "','" + ngayBD + "','" + ngayKT + "') ORDER BY THANH_TIEN DESC",
                CommandType.Text, null);
        }
    }
}
