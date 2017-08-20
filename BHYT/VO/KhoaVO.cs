using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHYT.VO
{
    public class KhoaVO
    {
        private string maKhoa;
        private string tenKhoa;
        private string chiTiet;

        public string MaKhoa
        {
            get
            {
                return maKhoa;
            }

            set
            {
                maKhoa = value;
            }
        }

        public string TenKhoa
        {
            get
            {
                return tenKhoa;
            }

            set
            {
                tenKhoa = value;
            }
        }

        public string ChiTiet
        {
            get
            {
                return chiTiet;
            }

            set
            {
                chiTiet = value;
            }
        }
    }
}
