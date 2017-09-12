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
    public partial class FrmDSCanLamSan : Form
    {
        DataTable dt = null;
        THONGTIN_CTDAO thongtinCT = null;
        public FrmDSCanLamSan(Connection db)
        {
            InitializeComponent();
            thongtinCT = new THONGTIN_CTDAO(db);
        }

        private void FrmDSCanLamSan_Load(object sender, EventArgs e)
        {
            dateTu.Value = DateTime.Now;
            dateDen.Value = DateTime.Now;
            cbTinhTrang.SelectedIndex = 1;

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ngayBD = DateTime.ParseExact(dateTu.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string ngayKT = DateTime.ParseExact(dateDen.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            dt = thongtinCT.DSCanLamSan(ngayBD, ngayKT, cbTinhTrang.SelectedIndex);
        }
    }
}
