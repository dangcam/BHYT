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
        FrmKQCanLamSan frmCanLamSan;
        public FrmDSCanLamSan(Connection db)
        {
            InitializeComponent();
            thongtinCT = new THONGTIN_CTDAO(db);
            frmCanLamSan = new FrmKQCanLamSan(db);
        }

        private void FrmDSCanLamSan_Load(object sender, EventArgs e)
        {
            dateTu.Value = DateTime.Now;
            dateDen.Value = DateTime.Now;
            cbTinhTrang.SelectedIndex = 1;
            LoadData();
        }
        private void LoadData()
        {
            string ngayBD = DateTime.ParseExact(dateTu.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            string ngayKT = DateTime.ParseExact(dateDen.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
            dt = thongtinCT.DSCanLamSan(ngayBD, ngayKT, cbTinhTrang.SelectedIndex);
            if (dt != null)
            {
                gridControl.DataSource = dt;
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            frmCanLamSan.MaLK = (gridView.GetFocusedRow() as DataRowView)["MA_LK"].ToString();
            frmCanLamSan.HoTen = (gridView.GetFocusedRow() as DataRowView)["HO_TEN"].ToString();
            frmCanLamSan.ShowDialog();
            LoadData();
        }
    }
}
