using BHYT.DAO;
using BHYT.MauSo;
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
    public partial class FrmChiDinhCLS : Form
    {
        DataTable data;
        CanLamSanDAO canlamsan;
        public string MaLienKet { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string TheBHYT { get; set; }
        public string GioiTinh { get; set; }
        public FrmChiDinhCLS(Connection db)
        {
            InitializeComponent();
            canlamsan = new CanLamSanDAO(db);
        }

        private void FrmChiDinhCLS_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = HoTen;
            data = canlamsan.DSChiDinhCanLamSan(MaLienKet);
            gridControl.DataSource = data;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Luu(true);
        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name == "Chon")
            {
                bool chon = Utils.ToBool(e.Value);
                canlamsan.MaNhom = gridView.GetRowCellValue(e.RowHandle, gridView.Columns["MaNhom"]).ToString();
                canlamsan.MaLK = MaLienKet;
                string err = "";
                if(chon == true)
                {
                    if(!canlamsan.CanLamSan_CT(ref err, "INSERT"))
                    {
                        MessageBox.Show(err, "Lỗi");
                    }
                }
                else
                {
                    if(!canlamsan.CanLamSan_CT(ref err,"DELETE"))
                    {
                        MessageBox.Show(err, "Lỗi");
                    }
                }
            }
        }
        private void Luu(bool report = false)
        {
            foreach (DataRow dr in data.Rows)
            {
                if(Utils.ToBool(dr["Chon"]))
                {
                    string err = "";
                    canlamsan.MaLK = MaLienKet;
                    canlamsan.MaNhom = dr["MaNhom"].ToString();
                    canlamsan.YeuCau = dr["YeuCau"].ToString();
                    canlamsan.ChuanDoan = dr["ChuanDoan"].ToString();
                    canlamsan.MauSo = dr["MauSo"].ToString();
                    canlamsan.TenNhom = dr["TenNhom"].ToString();
                    if(!canlamsan.CanLamSan_CT(ref err,"UPDATE"))
                    {
                        MessageBox.Show(err, "Lỗi");
                        return;
                    }
                    taoPhieu();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luu();
        }
        private void taoPhieu()
        {
            rptPhieuYeuCau rpt = new rptPhieuYeuCau();
            rpt.lblHoTen.Text = this.HoTen;
            rpt.lblNamSinh.Text = this.NamSinh.Substring(0, 4);
            rpt.lblGioiTinh.Text = this.GioiTinh == "0" ? "Nữ" : "Nam";
            rpt.lblMauSo.Text = "MS:"+canlamsan.MauSo+"/BV-01";
            rpt.lblDiaChi.Text = this.DiaChi;
            rpt.lblSoThe.Text = this.TheBHYT;
            rpt.lblChuanDoan.Text = canlamsan.ChuanDoan;
            rpt.xrTableCellYeuCau.Text = canlamsan.YeuCau;
            rpt.lblNgayThang.Text = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            rpt.lblPhieu.Text ="PHIẾU "+ canlamsan.TenNhom.ToUpper();
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }
    }
}
