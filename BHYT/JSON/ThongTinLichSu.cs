using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.JSON
{
    public class ThongTinLichSu
    {
        public ThongTinLichSu()
        {
            maKetQua = null;
        }
        public string maKetQua { get; set; }
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public string ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string maDKBD { get; set; }
        public string cqBHXH { get; set; }
        public string gtTheTu { get; set; }
        public string gtTheDen { get; set; }
        public string maKV { get; set; }
        public string ngayDu5Nam { get; set; }
        public List<LSKCB> dsLichSuKCB { get; set; }
    }
}
