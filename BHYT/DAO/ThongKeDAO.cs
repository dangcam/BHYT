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
        public DataTable DSThongKeThuocSL (int soLuong, string ngayBD, string ngayKT)
        {
            return db.ExcuteQuery ("SELECT * FROM getThongKeThuoc('" + soLuong + "','" + ngayBD + "','" + ngayKT + "') ORDER BY SO_LUONG DESC",
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
