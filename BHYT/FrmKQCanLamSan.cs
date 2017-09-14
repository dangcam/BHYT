using BHYT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmKQCanLamSan : Form
    {
        THONGTIN_CTDAO thongtinCT;
        DataTable dt;
        public FrmKQCanLamSan(Connection db)
        {
            InitializeComponent();
            thongtinCT = new THONGTIN_CTDAO(db);
        }
        public string MaLK = null;
        public string HoTen = null;
        private void FrmKQCanLamSan_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = HoTen;
            dt = thongtinCT.DSNhomDVKT(MaLK);
            gridControlDVKT.DataSource = dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string err = "";
            foreach(DataRow dr in dt.Rows)
            {
                err = "";
                if(!thongtinCT.SuaDVKTCTCLS(ref err, dr["MA_LK"].ToString(), dr["MA_DICH_VU"].ToString(), dr["KET_QUA"].ToString()))
                {
                    MessageBox.Show("Lỗi", err);
                }
            }
        }
    }
}
