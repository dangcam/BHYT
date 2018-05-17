using BHYT.DAO;
using BHYT.VO;
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
    public partial class FrmKQKhamSucKhoe : Form
    {
        KhamSucKhoeVO khamSucKhoeVO = new KhamSucKhoeVO();
        KhamSucKhoeDAO khamSucKhoeDAO;
        DataTable dataThongTin;
        public FrmKQKhamSucKhoe()
        {
            InitializeComponent();
            khamSucKhoeDAO = new KhamSucKhoeDAO();
        }
        public string MaLienKet { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string TheBHYT { get; set; }
        public string GioiTinh { get; set; }
        private void FrmKQKhamSucKhoe_Load(object sender, EventArgs e)
        {
            dataThongTin = khamSucKhoeDAO.DSThongTinBN(TheBHYT);
            cbGioiTinh.SelectedText = this.GioiTinh == "0" ? "Nữ" : "Nam";
            txtSoThe.Text = TheBHYT;
            txtHoTen.Text = HoTen;
            txtNgaySinh.Text = NamSinh.Substring(0, 4);
        }
        private void TinhIBM()
        {
            if(Utils.ToDouble(txtCanNang.Text) > 0 && Utils.ToDouble(txtChieuCao.Text)>0)
            {
                txtChiSoIBM.Text = (Utils.ToDouble(txtCanNang.Text) / 
                    (Utils.ToDouble(txtChieuCao.Text) * Utils.ToDouble(txtChieuCao.Text))).ToString();
            }
            else
            {
                txtChiSoIBM.Text = "";
            }
        }
        private void txtChieuCao_TextChanged(object sender, EventArgs e)
        {
            TinhIBM();
        }

        private void txtCanNang_TextChanged(object sender, EventArgs e)
        {
            TinhIBM();
        }
    }
}
