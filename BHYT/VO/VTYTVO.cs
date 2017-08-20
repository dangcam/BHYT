using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHYT.VO
{
    public class VTYTVO
    {
        private string maVTY = "";
        private string tenVTYT = "";
        private string tenBV = "";
        private int donGia = 0;
        private string donViTinh = "";
        private string quyetDinh = "";
        private string congBo = "";
        private string maNhom = "";
        public VTYTVO()
        {

        }
        public string MaVTY
        {
            get
            {
                return maVTY;
            }

            set
            {
                maVTY = value;
            }
        }

        public string TenVTYT
        {
            get
            {
                return tenVTYT;
            }

            set
            {
                tenVTYT = value;
            }
        }

        public string TenBV
        {
            get
            {
                return tenBV;
            }

            set
            {
                tenBV = value;
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

        public VTYTVO (string maVTY, string tenVTYT, string tenBV, int donGia, string donViTinh, string quyetDinh, string congBo, string maNhom)
        {
            this.maVTY = maVTY;
            this.tenVTYT = tenVTYT;
            this.tenBV = tenBV;
            this.donGia = donGia;
            this.donViTinh = donViTinh;
            this.quyetDinh = quyetDinh;
            this.congBo = congBo;
            this.maNhom = maNhom;
        }
    }
}
