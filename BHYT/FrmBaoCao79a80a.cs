using BHYT.DAO;
using DevExpress.XtraReports.UI;
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
    public partial class FrmBaoCao79a80a : Form
    {
        ThongKeDAO thongke;
        public FrmBaoCao79a80a(Connection db)
        {
            InitializeComponent();
            thongke = new ThongKeDAO(db);
        }

        private void cbGiaiDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGiaiDoan.SelectedIndex != 0)
            {
                dateDenNgay.Hide();
                dateTuNgay.Hide();
                cbThang.Hide();
                cbQuy.Hide();
                cbNam.Show();
                if (cbGiaiDoan.SelectedIndex == 1)
                {
                    cbThang.Show();
                }
                if (cbGiaiDoan.SelectedIndex == 2)
                {
                    cbQuy.Show();
                }
            }
            else
            {
                cbNam.Hide();
                cbQuy.Hide();
                cbThang.Hide();

                dateDenNgay.Show();
                dateTuNgay.Show();
            }
        }

        private void FrmBaoCao79a80a_Load(object sender, EventArgs e)
        {
            cbLoaiKCB.SelectedIndex = 0;

            cbGiaiDoan.SelectedIndex = 0;

            cbThang.SelectedIndex = 0;
            cbQuy.SelectedIndex = 0;

            cbNam.Hide();
            cbQuy.Hide();
            cbThang.Hide();

            this.cbNam.Items.Clear();
            string[] nam = new string[30];
            int j = 0;
            for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 30; i--)
            {
                nam[j] = i.ToString();
                j++;
            }
            this.cbNam.Items.AddRange(nam);
            cbNam.SelectedIndex = 0;
        }

        private void btnTongHop_Click(object sender, EventArgs e)
        {
            SplashScreen.Start();
            DataTable dt = new DataTable();
            string ngayBD;
            string ngayKT;
            if (cbGiaiDoan.SelectedIndex == 0)
            {
                ngayBD = DateTime.ParseExact(dateTuNgay.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
                ngayKT = DateTime.ParseExact(dateDenNgay.Text.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyyMMdd");
                dt = thongke.DSBaoCao(ngayBD, ngayKT, cbLoaiKCB.SelectedIndex+1);
            }
            else
            if (cbGiaiDoan.SelectedIndex == 1)
            {
                ngayBD = cbNam.SelectedItem.ToString() + cbThang.SelectedItem.ToString() + "01";
                ngayKT = cbNam.SelectedItem + cbThang.SelectedItem.ToString() +
                   lastDay(Convert.ToInt32(cbNam.SelectedItem), Convert.ToInt32(cbThang.SelectedItem.ToString()));
                dt = thongke.DSBaoCao(ngayBD, ngayKT, cbLoaiKCB.SelectedIndex+1);
            }
            else
            if (cbGiaiDoan.SelectedIndex == 2)
            {
                string thangDau = "01";
                string thangCuoi = "12";
                if (cbQuy.SelectedIndex == 0)
                {
                    thangDau = "01";
                    thangCuoi = "03";
                }
                else
                    if (cbQuy.SelectedIndex == 1)
                {
                    thangDau = "04";
                    thangCuoi = "06";
                }
                else
                    if (cbQuy.SelectedIndex == 2)
                {
                    thangDau = "07";
                    thangCuoi = "09";
                }
                else
                {
                    thangDau = "10";
                    thangCuoi = "12";
                }
                ngayBD = cbNam.SelectedItem.ToString() + thangDau + "01";
                ngayKT = cbNam.SelectedItem.ToString() + thangCuoi + lastDay(Convert.ToInt32(cbNam.SelectedItem), Convert.ToInt32(thangCuoi));
                dt = thongke.DSBaoCao(ngayBD, ngayKT, cbLoaiKCB.SelectedIndex+1);
            }
            else
            {
                ngayBD = cbNam.SelectedItem + "0101";
                ngayKT = cbNam.SelectedItem + "12" + lastDay(Convert.ToInt32(cbNam.SelectedItem), 12);
                dt = thongke.DSBaoCao(ngayBD, ngayKT, cbLoaiKCB.SelectedIndex+1);
            }
            rptBaoCao rpt = new rptBaoCao();
            if(cbLoaiKCB.SelectedIndex == 0)
            {
                rpt.lblTieuDe.Text = "DANH SÁCH NGƯỜI BỆNH BẢO HIỂM Y TẾ KHÁM CHỮA BỆNH NGOẠI TRÚ ĐỀ NGHỊ THANH TOÁN";
                rpt.xrCellTienGiuongKham.Text = "Tiền khám";
            }
            else
            {
                rpt.lblTieuDe.Text = "DANH SÁCH NGƯỜI BỆNH BẢO HIỂM Y TẾ KHÁM CHỮA BỆNH NỘI TRÚ ĐỀ NGHỊ THANH TOÁN";
                rpt.xrCellTienGiuongKham.Text = "Tiền giường";
            }
            rpt.lblNgay.Text = "Từ ngày " + dateTuNgay.Text + " đến ngày " + dateDenNgay.Text;

            rpt.DataSource = dt;
            rpt.xrCellTong.Text = Utils.ToDecimal(dt.Compute("SUM(T_TONGCHI)", "")).ToString("#,###");
            rpt.xrCellXetNghiem.Text = Utils.ToDecimal(dt.Compute("SUM(T_XN)", "")).ToString("#,###");
            rpt.xrCellThuoc.Text = Utils.ToDecimal(dt.Compute("SUM(T_THUOC)", "")).ToString("#,###");
            rpt.xrCellMau.Text = Utils.ToDecimal(dt.Compute("SUM(T_MAU)", "")).ToString("#,###");
            rpt.xrCellTTPT.Text = Utils.ToDecimal(dt.Compute("SUM(T_TT_PT)", "")).ToString("#,###");
            rpt.xrCellVTYT.Text = Utils.ToDecimal(dt.Compute("SUM(T_VTYT)", "")).ToString("#,###");
            rpt.xrCellKhamGiuong.Text = Utils.ToDecimal(dt.Compute("SUM(CONG_KHAM_GIUONG)", "")).ToString("#,###");
            rpt.xrCellVanChuyen.Text = Utils.ToDecimal(dt.Compute("SUM(T_VC)", "")).ToString("#,###");
            rpt.xrCellBHTT.Text = Utils.ToDecimal(dt.Compute("SUM(T_BHTT)", "")).ToString("#,###");
            rpt.xrCellBNTT.Text = Utils.ToDecimal(dt.Compute("SUM(T_BNTT)", "")).ToString("#,###");

            rpt.CreateDocument();
            rpt.ShowPreviewDialog();

            SplashScreen.Stop();
        }
        private int lastDay(int y, int m)
        {
            return DateTime.DaysInMonth(y, m);
        }
    }
}
