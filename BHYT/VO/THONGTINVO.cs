using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHYT.VO
{
    public class THONGTINVO
    {
        private string hoTen;
        private string ngaySinh;
        private int gioiTinh;
        private string diaChi;
        private string maThe;
        private string gtTheTu;
        private string gtTheDen;
        private string maKV;
        private string maLK;
        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public int GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string MaThe
        {
            get
            {
                return maThe;
            }

            set
            {
                maThe = value;
            }
        }

        public string GtTheTu
        {
            get
            {
                return gtTheTu;
            }

            set
            {
                gtTheTu = value;
            }
        }

        public string GtTheDen
        {
            get
            {
                return gtTheDen;
            }

            set
            {
                gtTheDen = value;
            }
        }

        public string MaKV
        {
            get
            {
                return maKV;
            }

            set
            {
                maKV = value;
            }
        }

        public string MaLK
        {
            get
            {
                return maLK;
            }

            set
            {
                maLK = value;
            }
        }
        public string MaDV
        {
            get; set;
        }
        public string ChucVu { get; set; }
        public string ToNT { get; set; }
        public string CoQuan { get; set; }
    }
}
