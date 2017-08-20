using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BHYT.VO
{
    public class BHYTVO
    {
        private int maSo;
        private string nhomDT;
        private int tyLe;
        private string ten;

        public int MaSo
        {
            get
            {
                return maSo;
            }

            set
            {
                maSo = value;
            }
        }

        public string NhomDT
        {
            get
            {
                return nhomDT;
            }

            set
            {
                nhomDT = value;
            }
        }

        public int TyLe
        {
            get
            {
                return tyLe;
            }

            set
            {
                tyLe = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }
    }
}
