using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHYT.VO
{
    public class DVKTVO
    {
        private string maNhom;
        private string maDVKT;
        private string tenDVKT;
        private string maGia;
        private int donGia;
        private int giaAX;
        private string quyetDinh;
        private string congBo;
        private string donViTinh = "Lần";
        public string MaNhom
        {
            get
            {
                return maNhom;
            }

            set
            {
                maNhom = value;
            }
        }

        public string MaDVKT
        {
            get
            {
                return maDVKT;
            }

            set
            {
                maDVKT = value;
            }
        }

        public string TenDVKT
        {
            get
            {
                return tenDVKT;
            }

            set
            {
                tenDVKT = value;
            }
        }

        public string MaGia
        {
            get
            {
                return maGia;
            }

            set
            {
                maGia = value;
            }
        }

        public int DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public int GiaAX
        {
            get
            {
                return giaAX;
            }

            set
            {
                giaAX = value;
            }
        }

        public string QuyetDinh
        {
            get
            {
                return quyetDinh;
            }

            set
            {
                quyetDinh = value;
            }
        }

        public string CongBo
        {
            get
            {
                return congBo;
            }

            set
            {
                congBo = value;
            }
        }

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }

            set
            {
                donViTinh = value;
            }
        }
    }
}
