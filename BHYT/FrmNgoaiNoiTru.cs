using BHYT.DAO;
using BHYT.VO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace BHYT
{
    public partial class FrmNgoaiNoiTru : Form
    {

        #region
        KhoaDAO khoa = null;
        BHYTDAO bhyt = null;
        THONGTIN_CTDAO thongtinCT = null;
        THONGTIN_CTVO thongtinBN = new THONGTIN_CTVO ();
        THONGTINVO thongtinThe = new THONGTINVO ();
        THONGTINDAO thongtinBHYT = null;
        private string maBenhChinh = string.Empty;
        private DataTable dataBenh;
        private DataTable data;
        private DataTable dtDuongDung;

        FrmCongKhamChiTiet frmCongKham;
        FrmTienGiuongChiTiet frmTienGiuong;
        FrmThuocDVKT frmThuocDVKT;
        FrmDanhSachKCB frmDanhSach;

        public static DataView dvCongKham = new DataView ();
        public static DataView dvTienGiuong = new DataView ();
        public static DataView dvTienThuoc = new DataView ();
        public static DataView dvTienDVKT = new DataView ();
        public static DataView dvTienVTYT = new DataView ();
        Dictionary<string, bool> dsThuoc = new Dictionary<string, bool> ();
        Dictionary<string, bool> dsDVKT = new Dictionary<string, bool> ();


        Dictionary<string, string> dsNhom = new Dictionary<string, string> ();
        CultureInfo elGR = CultureInfo.CreateSpecificCulture ("el-GR");
        System.Drawing.Font fontB = new System.Drawing.Font ("Times New Roman", 10, System.Drawing.FontStyle.Bold);
        System.Drawing.Font font = new System.Drawing.Font ("Times New Roman", 10);

        private double luongCoso = (AppConfig.LuongCoBan * 0.15);
        private int t_thuoc = 0;
        private int t_vtyt = 0;
        private int t_vt = 0;

        private string maBS = string.Empty;
        public static string MaLienKet = string.Empty;
        bool loi = false;
        bool capNhat = false;
        const string filePath = "D:\\Checkout\\";

        #endregion
        public FrmNgoaiNoiTru (Connection db)
        {
            SplashScreen.Start ();
            InitializeComponent ();
            khoa = new KhoaDAO (db);
            bhyt = new BHYTDAO (db);
            thongtinCT = new THONGTIN_CTDAO (db);
            thongtinBHYT = new THONGTINDAO (db);
            frmCongKham = new FrmCongKhamChiTiet (db);
            frmTienGiuong = new FrmTienGiuongChiTiet (db);
            frmThuocDVKT = new FrmThuocDVKT (db);
            frmDanhSach = new FrmDanhSachKCB (db);


            btnXoa.Enabled = false;
        }

        private void LoadData ()
        {
            dtDuongDung = thongtinCT.DSDuongDung ();
            //
            lookUpMaKhoa.Properties.DataSource = khoa.DSKhoa ();
            lookUpMaKhoa.Properties.DisplayMember = "TEN_KHOA";
            lookUpMaKhoa.Properties.ValueMember = "MA_KHOA";
            lookUpMaKhoa.ItemIndex = 0;
            //
            lookUpMaBS.Properties.DataSource = thongtinCT.DSNhanVien ();
            lookUpMaBS.Properties.DisplayMember = "TEN_NHANVIEN";
            lookUpMaBS.Properties.ValueMember = "MA_NHANVIEN";
            //
            dataBenh = thongtinCT.DSBenh ();

            lookUpMaBenh.Properties.DataSource = dataBenh;
            lookUpMaBenh.Properties.DisplayMember = "MA_BENH";
            lookUpMaBenh.Properties.ValueMember = "MA_BENH";


            lookUpMaBenhKhac.Properties.DataSource = dataBenh;
            lookUpMaBenhKhac.Properties.DisplayMember = "MA_BENH";
            lookUpMaBenhKhac.Properties.ValueMember = "MA_BENH";

            //
            lookUpMaTaiNan.Properties.DataSource = thongtinCT.DSTaiNan ();
            lookUpMaTaiNan.Properties.DisplayMember = "TEN";
            lookUpMaTaiNan.Properties.ValueMember = "MA";
            //
            lookUpNoiChuyenDen.Properties.DataSource = thongtinCT.DSCoSoKCB ();
            lookUpNoiChuyenDen.Properties.DisplayMember = "MA";
            lookUpNoiChuyenDen.Properties.ValueMember = "MA";
            //
            cbPhong.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;
            cbLyDo.SelectedIndex = 0;
            cbKQDTri.SelectedIndex = 0;
            cbTTRaVien.SelectedIndex = 0;
            txtSoNgayDTri.Text = "1";
            cbLoaiKCB.SelectedIndex = 0;
            txtMaBN.Text = thongtinCT.getMaBN ((cbLoaiKCB.SelectedIndex + 1) + DateTime.Now.ToString ("yyyyMMdd"));

            thongtinBN.MaLK = AppConfig.CoSoKCB+"PR" + DateTime.Now.Hour.ToString ().Substring (0, 1) + DateTime.Now.Minute.ToString ().Substring (0, 1) + DateTime.Now.Millisecond.ToString ().Substring (0, 1) + txtMaBN.Text;
            lookUpMaTaiNan.ItemIndex = 0;
            //
            try
            {
                dvTienGiuong = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "15").AsDataView ();
                dvCongKham = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "13").AsDataView ();
                dvTienDVKT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK).AsDataView ();
                dvTienThuoc = thongtinCT.DSNhomThuoc (thongtinBN.MaLK).AsDataView ();
                dvTienVTYT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "10").AsDataView ();
            }
            catch { }
            //
            data = new DataTable ();
            data.Columns.Add ("NHOM_CHI_PHI", typeof (string));
            data.Columns.Add ("MA_DICH_VU", typeof (string));
            data.Columns.Add ("TEN_DICH_VU", typeof (string));
            data.Columns.Add ("DON_VI_TINH", typeof (string));
            data.Columns.Add ("SO_LUONG", typeof (int));
            data.Columns.Add ("DON_GIA", typeof (int));
            data.Columns.Add ("THANH_TIEN", typeof (int));
            data.Columns.Add ("BHYT_THANH_TOAN", typeof (int));
            data.Columns.Add ("BN_THANH_TOAN", typeof (int));

            foreach (DataRow dr in thongtinCT.DSNhom ().Rows)
            {
                dsNhom.Add (dr[0].ToString (), dr[1].ToString ());
            }
            this.ActiveControl = txtQR;
            //this.ActiveControl = txtBHYT; //version nông trường
        }
        private bool checkInput ()
        {
            if (string.IsNullOrEmpty (txtBHYT.Text) || txtBHYT.Text.Length != 15)
            {
                MessageBox.Show ("Vui lòng nhập mã thẻ (15 ký tự).");
                txtBHYT.Focus ();
                return false;
            }
            if (lookUpMaBS.ItemIndex < 0)
            {
                MessageBox.Show ("Chưa chọn bác sĩ!");
                lookUpMaBS.Focus ();
                return false;
            }
            return true;
        }
        

        private bool dateNgayVaoNgayRa_ValueChanged ()
        {
            DateTime dateVao = DateTime.ParseExact (dateNgayVao.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dateRa = DateTime.ParseExact (dateNgayRa.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            if (dateVao > dateRa)
            {
                MessageBox.Show ("Ngày vào phải <= ngày ra!");
                dateNgayVao.Focus ();
                return false;
            }
            else
            {
                TimeSpan ngayDTri = dateRa.Subtract (dateVao);
                //if (cbLoaiKCB.SelectedIndex > 0)
                //{
                //    txtSoNgayDTri.Text = (ngayDTri.Days + 2).ToString ();
                //}
                //else
                {
                    txtSoNgayDTri.Text = (ngayDTri.Days + 1).ToString ();
                }
                return true;
            }

        }

        private bool dateGTBD_KT_ValueChanged ()
        {
            try
            {
                DateTime dateBD = DateTime.ParseExact (dateGTBD.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dateKT = DateTime.ParseExact (dateGTKT.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (dateBD > dateKT)
                {
                    MessageBox.Show ("Giá trị thẻ từ phải nhỏ hơn giá trị thẻ đến!");
                    dateGTBD.Focus ();
                    return false;
                }
                if (dateBD > DateTime.Now)
                {
                    MessageBox.Show ("Giá trị thẻ từ phải nhỏ hơn ngày hiện tại!");
                    dateGTBD.Focus ();
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show ("Giá trị ngày của thẻ không đúng.");
                return false;
            }
        }

        private void lookUpMaBenh_EditValueChanged (object sender, EventArgs e)
        {
            object tmp = lookUpMaBenh.GetSelectedDataRow ();
            if (tmp is DataRowView)
            {
                txtTenBenh.Text = (tmp as DataRowView)[1].ToString ();
                maBenhChinh = (tmp as DataRowView)[0].ToString ();
                txtMaBenhKhac.Text = string.Empty;
            }
            else
            {
                txtTenBenh.Text = string.Empty;
                maBenhChinh = string.Empty;
                txtMaBenhKhac.Text = string.Empty;
            }
        }

        private bool checkMaBenh (string ma)
        {
            if (ma == maBenhChinh || txtMaBenhKhac.Text.Contains (ma))
            {
                return false;
            }
            return true;
        }

        private void txtMaBenhKhac_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty (maBenhChinh))
                {
                    List<string> listMa = new List<string> ();
                    DataView dv = dataBenh.AsEnumerable ().Where (r => r.Field<string> ("MA_BENH") == maBenhChinh).AsDataView ();
                    txtTenBenh.Text = (dv[0] as DataRowView)[1].ToString ();
                    foreach (string ma in txtMaBenhKhac.Text.Split (';'))
                    {
                        if (!listMa.Contains (ma.Trim ()) && ma.Trim () != maBenhChinh && !string.IsNullOrEmpty (ma.Trim ()))
                        {
                            dv = dataBenh.AsEnumerable ().Where (r => r.Field<string> ("MA_BENH") == ma.Trim ()).AsDataView ();
                            if (dv.Count > 0)
                            {
                                txtTenBenh.Text += "; " + (dv[0] as DataRowView)[1].ToString ();
                                listMa.Add (ma.Trim ());
                            }
                        }
                    }
                    txtMaBenhKhac.Text = string.Empty;
                    foreach (string ma in listMa)
                    {
                        txtMaBenhKhac.Text += string.IsNullOrEmpty (txtMaBenhKhac.Text) ? ma : ("; " + ma);
                    }
                    dateNgayVao.Focus ();
                    return;
                }
                else
                {
                    lookUpMaBenh.Focus ();
                }
            }
        }

        private void cbLoaiKCB_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cbLoaiKCB.SelectedIndex == 0)
            {
                btnTienGiuong.Enabled = false;
                btnCongKham.Enabled = true;
            }
            else
            {
                btnTienGiuong.Enabled = true;
                btnCongKham.Enabled = false;
            }
            if (!capNhat)
            {
                txtMaBN.Text = thongtinCT.getMaBN ((cbLoaiKCB.SelectedIndex + 1) + DateTime.Now.ToString ("yyyyMMdd"));
            }
        }

        private void btnCongKham_Click (object sender, EventArgs e)
        {
            if (checkInput ())
            {
                frmCongKham.ShowDialog ();

                reLoadData ();
            }
        }

        private void btnTienGiuong_Click (object sender, EventArgs e)
        {
            if (checkInput ())
            {
                frmTienGiuong.MaBS = lookUpMaBS.ItemIndex;
                frmTienGiuong.NgayYLenh = dateThanhToan.Text;
                frmTienGiuong.MaKhoa = lookUpMaKhoa.ItemIndex;
                frmTienGiuong.NgayDtri = txtSoNgayDTri.Text;
                frmTienGiuong.ShowDialog ();
                reLoadData ();
            }
        }

        private void btnChiPhiThuoc_Click (object sender, EventArgs e)
        {
            if (checkInput ())
            {
                frmThuocDVKT.MaBS = lookUpMaBS.ItemIndex;
                frmThuocDVKT.MaKhoa = lookUpMaKhoa.ItemIndex;
                frmThuocDVKT.DateYLenh = dateThanhToan.Text;
                frmThuocDVKT.ShowDialog ();
                reLoadData ();
            }
        }
        private void reLoadData (bool f = false)
        {
            if(f)
            {
                dsDVKT.Clear ();
                dsThuoc.Clear ();
            }
            data.Clear ();
            DataRow dr;
            double tongTien = 0;
            t_thuoc = 0;
            t_vtyt = 0;
            t_vt = 0;
            foreach (DataRowView drView in dvCongKham)
            {
                dr = data.NewRow ();
                dr["NHOM_CHI_PHI"] = dsNhom[drView["MA_NHOM"].ToString ()];
                dr["MA_DICH_VU"] = drView["MA_DICH_VU"];
                dr["TEN_DICH_VU"] = drView["TEN_DICH_VU"];
                dr["DON_VI_TINH"] = drView["DON_VI_TINH"];
                dr["SO_LUONG"] = drView["SO_LUONG"];
                dr["DON_GIA"] = drView["DON_GIA"];
                dr["THANH_TIEN"] = drView["THANH_TIEN"];
            
                t_vtyt += int.Parse (drView["THANH_TIEN"].ToString ());
                if(f)
                {
                    dsDVKT.Add (dr["MA_DICH_VU"].ToString(), false);
                    maBS = drView["MA_BAC_SI"].ToString ();
                }
                data.Rows.Add (dr);
            }
            foreach (DataRowView drView in dvTienGiuong)
            {
                dr = data.NewRow ();
                dr["NHOM_CHI_PHI"] = dsNhom[drView["MA_NHOM"].ToString ()];
                dr["MA_DICH_VU"] = drView["MA_DICH_VU"];
                dr["TEN_DICH_VU"] = drView["TEN_DICH_VU"];
                dr["DON_VI_TINH"] = drView["DON_VI_TINH"];
                dr["SO_LUONG"] = drView["SO_LUONG"];
                dr["DON_GIA"] = drView["DON_GIA"];
                dr["THANH_TIEN"] = drView["THANH_TIEN"];
                maBS = drView["MA_BAC_SI"].ToString ();
                t_vtyt += int.Parse (drView["THANH_TIEN"].ToString ());
                if (f)
                {
                    dsDVKT.Add (dr["MA_DICH_VU"].ToString (), false);
                }
                data.Rows.Add (dr);
            }

            foreach (DataRowView drView in dvTienDVKT)
            {
                dr = data.NewRow ();
                dr["NHOM_CHI_PHI"] = dsNhom[drView["MA_NHOM"].ToString ()];
                dr["MA_DICH_VU"] = drView["MA_DICH_VU"];
                dr["TEN_DICH_VU"] = drView["TEN_DICH_VU"];
                dr["DON_VI_TINH"] = drView["DON_VI_TINH"];
                dr["SO_LUONG"] = drView["SO_LUONG"];
                dr["DON_GIA"] = drView["DON_GIA"];
                dr["THANH_TIEN"] = drView["THANH_TIEN"];
                maBS = drView["MA_BAC_SI"].ToString ();
                t_vtyt += int.Parse (drView["THANH_TIEN"].ToString ());
                if (f)
                {
                    dsDVKT.Add (dr["MA_DICH_VU"].ToString (), false);
                }
                data.Rows.Add (dr);
            }
            int vt = 0;
            foreach (DataRowView drView in dvTienVTYT)
            {
                dr = data.NewRow ();
                dr["NHOM_CHI_PHI"] = dsNhom[drView["MA_NHOM"].ToString ()];
                dr["MA_DICH_VU"] = drView["MA_DICH_VU"];
                dr["TEN_DICH_VU"] = drView["TEN_DICH_VU"];
                dr["DON_VI_TINH"] = drView["DON_VI_TINH"];
                dr["SO_LUONG"] = drView["SO_LUONG"];
                dr["DON_GIA"] = drView["DON_GIA"];
                dr["THANH_TIEN"] = drView["THANH_TIEN"];
                maBS = drView["MA_BAC_SI"].ToString ();
                vt = int.Parse (drView["THANH_TIEN"].ToString ());
                t_vtyt += vt;
                t_vt += vt;
                if (f)
                {
                    dsDVKT.Add (dr["MA_DICH_VU"].ToString (), false);
                }
                data.Rows.Add (dr);
            }
            foreach (DataRowView drView in dvTienThuoc)
            {
                dr = data.NewRow ();
                dr["NHOM_CHI_PHI"] = dsNhom[drView["NHOM"].ToString ()];
                dr["MA_DICH_VU"] = drView["MA_THUOC"];
                dr["TEN_DICH_VU"] = drView["TEN_THUOC"];
                dr["DON_VI_TINH"] = drView["DON_VI_TINH"];
                dr["SO_LUONG"] = drView["SO_LUONG"];
                dr["DON_GIA"] = drView["DON_GIA"];
                dr["THANH_TIEN"] = drView["THANH_TIEN"];
                maBS = drView["MA_BAC_SI"].ToString ();
                t_thuoc += int.Parse (drView["THANH_TIEN"].ToString ());
                if (f)
                {
                    dsThuoc.Add (dr["MA_DICH_VU"].ToString () + "|" + dr["TEN_DICH_VU"], false);
                }
                data.Rows.Add (dr);
            }
            tongTien = t_thuoc + t_vtyt;
            
            txtTongTien.Text = tongTien.ToString ("0,0", elGR);
            if (tongTien < luongCoso)
            {
                thongtinBN.MucHuong = 100;
                txtTyLe.Text = "100";
            }
            else
            {
                int maSo = int.Parse (txtBHYT.Text.Substring (2, 1));
                BHYTVO bh = new BHYTVO ();
                bh = bhyt.getBHYT (maSo);
                thongtinBN.MucHuong = bh.TyLe;
                txtTyLe.Text = bh.TyLe.ToString ();
            }
            foreach (DataRow drow in data.Rows)
            {
                double thanhtien = double.Parse (drow["THANH_TIEN"].ToString ());
                double bhyttt = thanhtien * thongtinBN.MucHuong / 100;
                drow["BHYT_THANH_TOAN"] = bhyttt;
                drow["BN_THANH_TOAN"] = thanhtien - bhyttt;
            }

            double bhtt = tongTien * thongtinBN.MucHuong / 100;
            txtBHTT.Text = bhtt.ToString ("0,0", elGR);
            txtBNTT.Text = (tongTien - bhtt).ToString ("0,0", elGR);
            //
            thongtinBN.TienBHTT = Convert.ToInt32 (bhtt);
            thongtinBN.TienBNTT = Convert.ToInt32 (tongTien - bhtt);
            //
            gridControlChiTiet.DataSource = data;
            gridViewChiTiet.ExpandAllGroups ();
        }
        private bool checkLuu ()
        {
            if (string.IsNullOrEmpty (txtBHYT.Text))
            {
                MessageBox.Show ("Vui lòng nhập mã thẻ!");
                txtBHYT.Focus ();
                return false;
            }
            if(dateGTBD_KT_ValueChanged () == false)
            {
                return false;
            }
            if (string.IsNullOrEmpty (txtHoTen.Text))
            {
                MessageBox.Show ("Vui lòng nhập họ tên");
                txtHoTen.Focus ();
                return false;
            }
            if (string.IsNullOrEmpty (txtDiaChi.Text))
            {
                MessageBox.Show ("Vui lòng nhập địa chỉ");
                txtDiaChi.Focus ();
                return false;
            }
            try
            {
                DateTime date = DateTime.ParseExact (txtNgaySinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (date > DateTime.Now)
                {
                    MessageBox.Show ("Ngày sinh <= ngày hiện tại!");
                    txtNgaySinh.Focus ();
                    return false;
                }
            }
            catch
            {
                try
                {
                    DateTime date = DateTime.ParseExact (txtNgaySinh.Text, "yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    if (date.Year > DateTime.Now.Year)
                    {
                        MessageBox.Show ("Ngày sinh <= ngày hiện tại!");
                        txtNgaySinh.Focus ();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show ("Ngày sinh sai định dạng năm (yyyy)!");
                    txtNgaySinh.Focus ();
                    return false;
                }
            }
            if (lookUpMaBenh.EditValue.ToString ().Length < 1)
            {
                MessageBox.Show ("Vui lòng chọn mã bệnh!");
                lookUpMaBenh.Focus ();
                return false;
            }
            if (dateNgayVaoNgayRa_ValueChanged () == false)
            {
                return false;
            }
            return checkInput ();
        }
        private void bntMoi_Click (object sender, EventArgs e)
        {
            capNhat = false;
            t_thuoc = 0;
            t_vtyt = 0;
            t_vt = 0;
            maBenhChinh = string.Empty;
            dsThuoc.Clear ();
            dsDVKT.Clear ();

            txtMaBN.Text = thongtinCT.getMaBN ((cbLoaiKCB.SelectedIndex + 1) + DateTime.Now.ToString ("yyyyMMdd"));
         
            thongtinBN.MaLK = AppConfig.CoSoKCB + "PR" + DateTime.Now.Hour.ToString().Substring(0,1) + DateTime.Now.Minute.ToString ().Substring (0, 1) + DateTime.Now.Millisecond.ToString ().Substring (0, 1) + txtMaBN.Text;

            txtBHYT.Text = string.Empty;
            txtTenBenh.Text = string.Empty;
            txtMaBenhKhac.Text = string.Empty;
            lookUpMaBenh.ResetText ();

            txtHoTen.Text = string.Empty;
            txtTyLe.Text = string.Empty;
            txtMucHuong.Text = string.Empty;
            txtDiaChi.Text = string.Empty;

            lookUpNoiChuyenDen.ResetText ();

            dvTienGiuong = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "15").AsDataView ();
            dvCongKham = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "13").AsDataView ();
            dvTienDVKT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK).AsDataView ();
            dvTienThuoc = thongtinCT.DSNhomThuoc (thongtinBN.MaLK).AsDataView ();
            dvTienVTYT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "10").AsDataView ();

            gridControlChiTiet.DataSource = null;

            txtTongTien.Text = string.Empty;
            txtBHTT.Text = string.Empty;
            txtBNTT.Text = string.Empty;
            txtCanNang.Text = "0";
            txtSoNgayDTri.Text = "1";
            txtTyLe.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            
            dateGTBD.ResetText (); // version đi nông trường
            dateGTKT.ResetText ();
            cbKhuVuc.Text = "";
            txtDu5Nam.ResetText ();
            checkBDu5Nam.Checked = false;

            txtMaDKKCB.Text = AppConfig.CoSoKCB; // version đi nông trường
            try
            {

                txtTenBV.Text = (lookUpNoiChuyenDen.Properties.GetDataSourceRowByKeyValue (txtMaDKKCB.Text) as DataRowView)[1].ToString();
            }
            catch { }

            dateNgayVao.Text = DateTime.Now.ToString ();
            dateNgayRa.Text = DateTime.Now.ToString ();
            dateThanhToan.Text = DateTime.Now.ToString ();
            //
            btnXoa.Enabled = false;
            MaLienKet = string.Empty;

            btnTien.Enabled = false;
            btnLui.Enabled = false;
            txtQR.ReadOnly = false;
            txtQR.ResetText ();
            txtQR.Focus ();
            //txtBHYT.Text = "DN470000800"; // version nông trường
            //txtBHYT.Focus ();

        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            loi = checkLuu ();
            if (loi)
            {
                if(capNhat == false)
                {
                    txtMaBN.Text = thongtinCT.getMaBN ((cbLoaiKCB.SelectedIndex + 1) + DateTime.Now.ToString ("yyyyMMdd"));
                    thongtinBN.MaLK = AppConfig.CoSoKCB + "PR" + DateTime.Now.Hour.ToString ().Substring (0, 1) + DateTime.Now.Minute.ToString ().Substring (0, 1) + DateTime.Now.Millisecond.ToString ().Substring (0, 1) + txtMaBN.Text;
                }
                //(1) the xml declaration is recommended, but not mandatory
                XmlDocument doc = new XmlDocument ();
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration ("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore (xmlDeclaration, root);

                XmlElement checkout = doc.CreateElement (string.Empty, "CHECKOUT", string.Empty);
                doc.AppendChild (checkout);

                XmlElement thongtinchitiet = doc.CreateElement (string.Empty, "THONGTINCHITIET", string.Empty);
                checkout.AppendChild (thongtinchitiet);

                XmlElement tonghop = doc.CreateElement (string.Empty, "TONGHOP", string.Empty);
                thongtinchitiet.AppendChild (tonghop);

                XmlElement bangCTThuoc = doc.CreateElement (string.Empty, "Bang_CTTHUOC", string.Empty);
                if (dvTienThuoc.Count > 0)
                {
                    thongtinchitiet.AppendChild (bangCTThuoc);
                }

                XmlElement bangCTDichVu = doc.CreateElement (string.Empty, "Bang_CTDV", string.Empty);
                if (dvCongKham.Count > 0 || dvTienDVKT.Count > 0 || dvTienGiuong.Count > 0 || dvTienVTYT.Count > 0)
                {
                    thongtinchitiet.AppendChild (bangCTDichVu);
                }
                //
                string err = "";
                // lưu thông tin bệnh nhân
                THONGTINVO benhnhan = new THONGTINVO ();
                benhnhan.MaThe = txtBHYT.Text;
                benhnhan.HoTen = txtHoTen.Text;
                try
                {
                    benhnhan.NgaySinh = DateTime.ParseExact (txtNgaySinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                }
                catch
                {
                    benhnhan.NgaySinh = txtNgaySinh.Text;
                }
                benhnhan.GioiTinh = cbGioiTinh.SelectedIndex;
                benhnhan.DiaChi = txtDiaChi.Text;
                benhnhan.GtTheTu = DateTime.ParseExact (dateGTBD.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                benhnhan.GtTheDen = DateTime.ParseExact (dateGTKT.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                benhnhan.MaKV = cbKhuVuc.Text;
                if (thongtinBHYT.getBHYT (benhnhan.MaThe) != null)
                {
                    thongtinBHYT.SuaThongTin (ref err, benhnhan); // lưu thông tin
                }
                else
                {
                    thongtinBHYT.ThemThongTin (ref err, benhnhan);// thêm thông tin
                }
                // thông tin chi tiết bệnh nhân
                thongtinBN.MaBN = txtMaBN.Text;
                thongtinBN.HoTen = benhnhan.HoTen;
                thongtinBN.NgaySinh = benhnhan.NgaySinh;
                thongtinBN.GioiTinh = benhnhan.GioiTinh;
                thongtinBN.DiaChi = benhnhan.DiaChi;
                thongtinBN.MaThe = benhnhan.MaThe;
                thongtinBN.MaDKBD = txtMaDKKCB.Text;
                thongtinBN.GtTheTu = benhnhan.GtTheTu;
                thongtinBN.GtTheDen = benhnhan.GtTheDen;
                thongtinBN.TenBenh = txtTenBenh.Text;
                thongtinBN.MaBenh = maBenhChinh;
                thongtinBN.MaBenhKhac = txtMaBenhKhac.Text;
                thongtinBN.MaLyDoVaoVien = cbLyDo.SelectedIndex + 1;
                try
                {
                    thongtinBN.MaNoiChuyen = lookUpNoiChuyenDen.EditValue.ToString ();
                }
                catch
                {
                    thongtinBN.MaNoiChuyen = "";
                }
                thongtinBN.MaTaiNan = lookUpMaTaiNan.ItemIndex;
                thongtinBN.NgayVao = DateTime.ParseExact (dateNgayVao.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMddHHmm");
                thongtinBN.NgayRa = DateTime.ParseExact (dateNgayRa.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMddHHmm");
                thongtinBN.SoNgayDieuTri = int.Parse (txtSoNgayDTri.Text);
                thongtinBN.KetQuaDieuTri = cbKQDTri.SelectedIndex + 1;
                thongtinBN.TinhTrangRaVien = cbTTRaVien.SelectedIndex + 1;
                thongtinBN.NgayThanhToan = DateTime.ParseExact (dateThanhToan.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMddHHmm");
                //thongtinBN.MucHuong
                thongtinBN.TienThuoc = t_thuoc;
                thongtinBN.TienVTYT = t_vt;
                thongtinBN.TienTongChiPhi = t_vtyt + t_thuoc;
                //thongtinBN.TienBNTT
                //thongtinBN.TienBHTT
                thongtinBN.TienNguonKhac = 0;
                thongtinBN.TienNgoaiDS = 0;
                thongtinBN.NamQT = DateTime.ParseExact (thongtinBN.NgayThanhToan, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).Year.ToString ();
                thongtinBN.ThangQT = DateTime.ParseExact (thongtinBN.NgayThanhToan, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).Month.ToString ();
                thongtinBN.MaLoaiKCB = (cbLoaiKCB.SelectedIndex + 1);
                thongtinBN.MaKhoa = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[0].ToString ();
                thongtinBN.MaCSKCB = AppConfig.CoSoKCB;
                thongtinBN.MaKV = cbKhuVuc.Text;
                thongtinBN.MaPTTTQT = "";
                thongtinBN.Phong = cbPhong.SelectedIndex;
                thongtinBN.MaBS = lookUpMaBS.EditValue.ToString();
                try
                {
                    thongtinBN.CanNang = Convert.ToInt32 (txtCanNang.Text);
                }
                catch { thongtinBN.CanNang = 0; }
                thongtinBN.CheckOut = true;
                //
                taoBangTongHop (doc, tonghop, thongtinBN);
                // lưu thông tin
                err = "";
                if (capNhat)
                {
                    thongtinCT.SuaThongTinCT (ref err, thongtinBN);// cập nhật
                }
                else
                {
                    thongtinCT.ThemThongTinCT (ref err, thongtinBN);// thêm mới
                }
                if (!string.IsNullOrEmpty (err))
                {
                    MessageBox.Show (err);
                }
                //
                Thuoc_CTVO thuoc;
                foreach (DataRowView drView in dvTienThuoc)
                {
                    thuoc = new Thuoc_CTVO ();
                    thuoc.MaLK = thongtinBN.MaLK;
                    thuoc.MaThuoc = drView["MA_THUOC"].ToString ();
                    thuoc.TenThuoc = drView["TEN_THUOC"].ToString ();
                    thuoc.DonViTinh = drView["DON_VI_TINH"].ToString ();
                    thuoc.HamLuong = drView["HAM_LUONG"].ToString ();
                    thuoc.DuongDung = drView["DUONG_DUNG"].ToString ();
                    thuoc.LieuDung = drView["LIEU_DUNG"].ToString ();
                    thuoc.SoDK = drView["SO_DANG_KY"].ToString ();
                    thuoc.SoLuong = Convert.ToInt32 (drView["SO_LUONG"].ToString ());
                    thuoc.DonGia = Convert.ToInt32 (drView["DON_GIA"].ToString ());
                    thuoc.TyLeTT = 100;
                    thuoc.ThanhTien = Convert.ToInt32 (drView["THANH_TIEN"].ToString ());
                    thuoc.MaKhoa = drView["MA_KHOA"].ToString ();
                    thuoc.MaBacSi = drView["MA_BAC_SI"].ToString ();
                    thuoc.MaBenh = maBenhChinh + ";" + thongtinBN.MaBenhKhac;
                    if (drView["NGAY_YL"].ToString ().Contains ("/"))
                    {
                        thuoc.NgayYL = DateTime.ParseExact (drView["NGAY_YL"].ToString (), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMddHHmm");
                    }
                    else
                    {
                        thuoc.NgayYL = drView["NGAY_YL"].ToString ();
                    }
                    thuoc.MaPTTT = 0;
                    thuoc.Nhom = drView["NHOM"].ToString ();
                    err = "";
                    if (capNhat)
                    {
                        if (dsThuoc.ContainsKey (thuoc.MaThuoc + "|" + thuoc.TenThuoc))
                        {
                            thongtinCT.SuaThuocCT (ref err, thuoc); //sửa tiền thuốc
                            dsThuoc[thuoc.MaThuoc + "|" + thuoc.TenThuoc] = true;
                        }
                        else
                        {
                            thongtinCT.ThemThuocCT (ref err, thuoc);// thêm tiền thuốc
                            dsThuoc.Add (thuoc.MaThuoc+"|"+thuoc.TenThuoc, true);
                        }
                        if(!string.IsNullOrEmpty(err))
                        {
                            MessageBox.Show (err);
                        }
                    }
                    else
                    {
                        thongtinCT.ThemThuocCT (ref err, thuoc);// thêm tiền thuốc
                        dsThuoc.Add(thuoc.MaThuoc + "|" + thuoc.TenThuoc,false);
                        if (!string.IsNullOrEmpty (err))
                        {
                            MessageBox.Show (err);
                        }
                    }
                    taoBangThuoc (doc, bangCTThuoc, thuoc);
                }
                if (capNhat)
                {
                    List<string> keys = new List<string> (dsThuoc.Keys);
                    foreach (var key in keys)
                    {
                        if (dsThuoc[key] == false)
                        {
                            thongtinCT.XoaThuocCT (ref err, thongtinBN.MaLK, key.Split('|')[0], key.Split ('|')[1]);
                            dsThuoc.Remove (key);
                        }
                        else
                        {
                            dsThuoc[key] = false;
                        }
                    }
                }
                DVKT_CTVO dvkt;
                foreach (DataRowView drView in dvTienDVKT) // dịch vụ kỹ thuật
                {
                    dvkt = new DVKT_CTVO ();
                    dvkt.MaLK = thongtinBN.MaLK;
                    dvkt.MaDichVu = drView["MA_DICH_VU"].ToString ();
                    dvkt.MaVatTu = drView["MA_VAT_TU"].ToString ();
                    dvkt.MaNhom = drView["MA_NHOM"].ToString ();
                    dvkt.TenDichVu = drView["TEN_DICH_VU"].ToString ();
                    dvkt.DonViTinh = drView["DON_VI_TINH"].ToString ();
                    dvkt.SoLuong = Convert.ToInt32 (drView["SO_LUONG"].ToString ());
                    dvkt.DonGia = Convert.ToInt32 (drView["DON_GIA"].ToString ());
                    dvkt.TyLeTT = 100;
                    dvkt.ThanhTien = Convert.ToInt32 (drView["THANH_TIEN"].ToString ());
                    dvkt.MaKhoa = drView["MA_KHOA"].ToString ();
                    dvkt.MaBacSi = drView["MA_BAC_SI"].ToString ();
                    dvkt.MaBenh = maBenhChinh + ";" + thongtinBN.MaBenhKhac;
                    if (drView["NGAY_YL"].ToString ().Contains ("/"))
                    {
                        dvkt.NgayYLenh = DateTime.ParseExact (drView["NGAY_YL"].ToString (), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMddHHmm");
                    }
                    else
                    {
                        dvkt.NgayYLenh = drView["NGAY_YL"].ToString ();
                    }
                    dvkt.NgayQK = dvkt.NgayYLenh;
                    dvkt.MaPTTT = 0;
                    //
                    err = "";
                    if (capNhat)
                    {
                        if (dsDVKT.ContainsKey (dvkt.MaDichVu))
                        {
                            thongtinCT.SuaDVKTCT (ref err, dvkt);
                            dsDVKT[dvkt.MaDichVu] = true;
                        }
                        else
                        {
                            thongtinCT.ThemDVKTCT (ref err, dvkt);
                            dsDVKT.Add (dvkt.MaDichVu, true);
                            if (!string.IsNullOrEmpty (err))
                            {
                                MessageBox.Show (err);
                            }
                        }
                    }
                    else
                    {
                        thongtinCT.ThemDVKTCT (ref err, dvkt);
                        dsDVKT.Add (dvkt.MaDichVu, false);
                    }
                    taoBangDVKT (doc, bangCTDichVu, dvkt);
                }
                foreach (DataRowView drView in dvTienVTYT) // vật tư y tế
                {
                    dvkt = new DVKT_CTVO ();
                    dvkt.MaLK = thongtinBN.MaLK;
                    dvkt.MaDichVu = drView["MA_DICH_VU"].ToString ();
                    dvkt.MaVatTu = drView["MA_VAT_TU"].ToString ();
                    dvkt.MaNhom = drView["MA_NHOM"].ToString ();
                    dvkt.TenDichVu = drView["TEN_DICH_VU"].ToString ();
                    dvkt.DonViTinh = drView["DON_VI_TINH"].ToString ();
                    dvkt.SoLuong = Convert.ToInt32 (drView["SO_LUONG"].ToString ());
                    dvkt.DonGia = Convert.ToInt32 (drView["DON_GIA"].ToString ());
                    dvkt.TyLeTT = 100;
                    dvkt.ThanhTien = Convert.ToInt32 (drView["THANH_TIEN"].ToString ());
                    dvkt.MaKhoa = drView["MA_KHOA"].ToString ();
                    dvkt.MaBacSi = drView["MA_BAC_SI"].ToString ();
                    dvkt.MaBenh = maBenhChinh + ";" + thongtinBN.MaBenhKhac;
                    if (drView["NGAY_YL"].ToString ().Contains ("/"))
                    {
                        dvkt.NgayYLenh = DateTime.ParseExact (drView["NGAY_YL"].ToString (), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMddHHmm");
                    }
                    else
                    {
                        dvkt.NgayYLenh = drView["NGAY_YL"].ToString ();
                    }
                    dvkt.NgayQK = dvkt.NgayYLenh;
                    dvkt.MaPTTT = 0;
                    //
                    err = "";
                    if (capNhat)
                    {
                        if (dsDVKT.ContainsKey (dvkt.MaDichVu))
                        {
                            thongtinCT.SuaDVKTCT (ref err, dvkt);
                            dsDVKT[dvkt.MaDichVu] = true;
                        }
                        else
                        {
                            thongtinCT.ThemDVKTCT (ref err, dvkt);
                            dsDVKT.Add (dvkt.MaDichVu, true);
                            if (!string.IsNullOrEmpty (err))
                            {
                                MessageBox.Show (err);
                            }
                        }
                    }
                    else
                    {
                        thongtinCT.ThemDVKTCT (ref err, dvkt);
                        dsDVKT.Add (dvkt.MaDichVu, false);
                    }
                    taoBangDVKT (doc, bangCTDichVu, dvkt);
                }
                foreach (DataRowView drView in dvTienGiuong) // tiền giường
                {
                    dvkt = new DVKT_CTVO ();
                    dvkt.MaLK = thongtinBN.MaLK;
                    dvkt.MaDichVu = drView["MA_DICH_VU"].ToString ();
                    dvkt.MaVatTu = drView["MA_VAT_TU"].ToString ();
                    dvkt.MaNhom = drView["MA_NHOM"].ToString ();
                    dvkt.TenDichVu = drView["TEN_DICH_VU"].ToString ();
                    dvkt.DonViTinh = drView["DON_VI_TINH"].ToString ();
                    dvkt.SoLuong = Convert.ToInt32 (drView["SO_LUONG"].ToString ());
                    dvkt.DonGia = Convert.ToInt32 (drView["DON_GIA"].ToString ());
                    dvkt.TyLeTT = 100;
                    dvkt.ThanhTien = Convert.ToInt32 (drView["THANH_TIEN"].ToString ());
                    dvkt.MaKhoa = drView["MA_KHOA"].ToString ();
                    dvkt.MaBacSi = drView["MA_BAC_SI"].ToString ();
                    dvkt.MaBenh = maBenhChinh + ";" + thongtinBN.MaBenhKhac;
                    if (drView["NGAY_YL"].ToString ().Contains ("/"))
                    {
                        dvkt.NgayYLenh = DateTime.ParseExact (drView["NGAY_YL"].ToString (), "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMddHHmm");
                    }
                    else
                    {
                        dvkt.NgayYLenh = drView["NGAY_YL"].ToString ();
                    }
                    dvkt.NgayQK = dvkt.NgayYLenh;
                    dvkt.MaPTTT = 0;
                    err = "";
                    if (capNhat)
                    {
                        if (dsDVKT.ContainsKey (dvkt.MaDichVu))
                        {
                            thongtinCT.SuaDVKTCT (ref err, dvkt);
                            dsDVKT[dvkt.MaDichVu] = true;
                        }
                        else
                        {
                            thongtinCT.ThemDVKTCT (ref err, dvkt);
                            dsDVKT.Add (dvkt.MaDichVu, true);
                            if (!string.IsNullOrEmpty (err))
                            {
                                MessageBox.Show (err);
                            }
                        }
                    }
                    else
                    {
                        thongtinCT.ThemDVKTCT (ref err, dvkt);
                        dsDVKT.Add (dvkt.MaDichVu, false);
                        if (!string.IsNullOrEmpty (err))
                        {
                            MessageBox.Show (err);
                        }
                    }
                    taoBangDVKT (doc, bangCTDichVu, dvkt);
                }

                foreach (DataRowView drView in dvCongKham) // công khám
                {
                    dvkt = new DVKT_CTVO ();
                    dvkt.MaLK = thongtinBN.MaLK;
                    dvkt.MaDichVu = drView["MA_DICH_VU"].ToString ();
                    dvkt.MaVatTu = "";//drView["MA_VAT_TU"].ToString ();
                    dvkt.MaNhom = drView["MA_NHOM"].ToString ();
                    dvkt.TenDichVu = drView["TEN_DICH_VU"].ToString ();
                    dvkt.DonViTinh = drView["DON_VI_TINH"].ToString ();
                    dvkt.SoLuong = Convert.ToInt32 (drView["SO_LUONG"].ToString ());
                    dvkt.DonGia = Convert.ToInt32 (drView["DON_GIA"].ToString ());
                    dvkt.TyLeTT = 100;
                    dvkt.ThanhTien = Convert.ToInt32 (drView["THANH_TIEN"].ToString ());
                    dvkt.MaKhoa = thongtinBN.MaKhoa;
                    dvkt.MaBacSi = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[0].ToString ();
                    dvkt.MaBenh = maBenhChinh + ";" + thongtinBN.MaBenhKhac;
                    dvkt.NgayYLenh = thongtinBN.NgayVao;
                    dvkt.NgayQK = dvkt.NgayYLenh;
                    dvkt.MaPTTT = 0;
                    err = "";
                    if (capNhat)
                    {
                        if (dsDVKT.ContainsKey (dvkt.MaDichVu))
                        {
                            thongtinCT.SuaDVKTCT (ref err, dvkt);
                            dsDVKT[dvkt.MaDichVu] = true;
                        }
                        else
                        {
                            thongtinCT.ThemDVKTCT (ref err, dvkt);
                            dsDVKT.Add (dvkt.MaDichVu, true);
                            if (!string.IsNullOrEmpty (err))
                            {
                                MessageBox.Show (err);
                            }
                        }
                    }
                    else
                    {
                        thongtinCT.ThemDVKTCT (ref err, dvkt);
                        dsDVKT.Add (dvkt.MaDichVu, false);
                        if (!string.IsNullOrEmpty (err))
                        {
                            MessageBox.Show (err);
                        }
                    }
                    taoBangDVKT (doc, bangCTDichVu, dvkt);
                }
                if(capNhat)
                {
                    List<string> keys = new List<string> (dsDVKT.Keys);
                    foreach (var key in keys)
                    {
                        if (dsDVKT[key] == false)
                        {
                            thongtinCT.XoaDVKTCT (ref err, thongtinBN.MaLK, key);
                            dsDVKT.Remove (key);
                        }
                        else
                        {
                            dsDVKT[key] = false;
                        }
                    }
                }
                
                try
                {
                    if (!Directory.Exists (filePath))
                    {
                        Directory.CreateDirectory (filePath);                       
                    }
                    doc.Save (filePath + thongtinBN.MaBN + "_" + thongtinBN.MaThe + ".xml");
                }
                catch(IOException ex)
                {
                    MessageBox.Show (ex.Message);
                }
                //doc.Save (filePath + thongtinBN.MaBN + "_" + thongtinBN.MaThe + ".xml");
                capNhat = true;

                btnXoa.Enabled = true;
            }

        }

        private void btnLuuIn_Click (object sender, EventArgs e)
        {
            btnLuu_Click (null, null);
            if (loi)
            {
                createReportChiPhi ();
            }
        }
        private void createReportChiPhi(bool xem = false)
        {
            rptChiPhi rpt = new rptChiPhi ();
            rpt.DataSource = null;
            int bm = 2;
            if(thongtinBN.MaLoaiKCB == 3)
            {
                rpt.xrLabelDeMuc.Text = "BẢNG KÊ CHI PHÍ KHÁM, CHỮA BỆNH NỘI TRÚ";
                rpt.xrLabelMauSo.Text = "Mẫu số 02/BV";
                bm = 3;
            }
            else
            {
                rpt.xrLabelDeMuc.Text = "BẢNG KÊ CHI PHÍ KHÁM BỆNH, CHỮA BỆNH NGOẠI TRÚ";
                rpt.xrLabelMauSo.Text = "Mẫu số 01/BV";
                bm = 2;
            }
            rpt.xrLabelKhoa.Text = (lookUpMaKhoa.GetSelectedDataRow () as DataRowView)[1].ToString ();
            rpt.xrLabelMaSoBN.Text = thongtinBN.MaBN;
            rpt.xrLabelSoBenhAn.Text = AppConfig.CoSoKCB + thongtinBN.MaBN;
            rpt.xrLabelHoTen.Text = thongtinBN.HoTen;
            rpt.xrLabelDiaChi.Text = thongtinBN.DiaChi;
            rpt.xrLabelNgaySinh.Text = txtNgaySinh.Text;
            rpt.xrLabelMaKCBBanDau.Text = txtMaDKKCB.Text;
            rpt.xrLabelKCBBanDau.Text = txtTenBV.Text;
            rpt.lblCosoKCB.Text = (lookUpNoiChuyenDen.Properties.GetDataSourceRowByKeyValue (AppConfig.CoSoKCB) as DataRowView)[1].ToString ().ToUpper();
            if (thongtinBN.GioiTinh == 0)
            {
                rpt.xrCheckBoxNu.Checked = true;
            }
            else
            {
                rpt.xrCheckBoxNu.Checked = false;
            }
            rpt.xrCheckBoxNam.Checked = !rpt.xrCheckBoxNu.Checked;
            rpt.xrCheckBoxCBHYT.Checked = true;
            rpt.xrCheckBoxKBHYT.Checked = !rpt.xrCheckBoxCBHYT.Checked;
            if(rpt.xrCheckBoxCBHYT.Checked)
            {
                rpt.xrTableBHYT.Rows[0].Cells[0].Text = thongtinBN.MaThe.Substring (0, 2);
                rpt.xrTableBHYT.Rows[0].Cells[1].Text = thongtinBN.MaThe.Substring (2, 1);
                rpt.xrTableBHYT.Rows[0].Cells[2].Text = thongtinBN.MaThe.Substring (3, 2);
                rpt.xrTableBHYT.Rows[0].Cells[3].Text = thongtinBN.MaThe.Substring (5, 2);
                rpt.xrTableBHYT.Rows[0].Cells[4].Text = thongtinBN.MaThe.Substring (7, 3);
                rpt.xrTableBHYT.Rows[0].Cells[5].Text = thongtinBN.MaThe.Substring (10, 5);
                rpt.xrLabelGTTu.Text = dateGTBD.Text;
                rpt.xrLabelGTDen.Text = dateGTKT.Text;
            }
            else
            {
                rpt.xrTableBHYT.Rows[0].Cells[0].Text = "";
                rpt.xrTableBHYT.Rows[0].Cells[1].Text = "";
                rpt.xrTableBHYT.Rows[0].Cells[2].Text = "";
                rpt.xrTableBHYT.Rows[0].Cells[3].Text = "";
                rpt.xrTableBHYT.Rows[0].Cells[4].Text = "";
                rpt.xrTableBHYT.Rows[0].Cells[5].Text = "";
                rpt.xrLabelGTTu.Text = "";
                rpt.xrLabelGTDen.Text = "";
            }
            rpt.xrLabelDenKham.Text = dateNgayVao.Text;
            rpt.xrLabelDi.Text = dateNgayRa.Text;
            if(thongtinBN.MaLyDoVaoVien == 1)
            {
                rpt.xrCheckBoxDungTuyen.Checked = true;
                rpt.xrCheckBoxCapCuu.Checked = false;
                rpt.xrCheckBoxTraiTuyen.Checked = false;
            }
            if (thongtinBN.MaLyDoVaoVien == 2)
            {
                rpt.xrCheckBoxDungTuyen.Checked = false;
                rpt.xrCheckBoxCapCuu.Checked = true;
                rpt.xrCheckBoxTraiTuyen.Checked = false;
            }
            if (thongtinBN.MaLyDoVaoVien == 3)
            {
                rpt.xrCheckBoxDungTuyen.Checked = false;
                rpt.xrCheckBoxCapCuu.Checked = false;
                rpt.xrCheckBoxTraiTuyen.Checked = true;
                rpt.xrLabelNoiChuyenDen.Text = thongtinBN.MaNoiChuyen;
            }
            else
            {
                rpt.xrLabelNoiChuyenDen.Text = "";
            }
            rpt.xrLabelSoNgay.Text = thongtinBN.SoNgayDieuTri.ToString();
            rpt.xrLabelTenBenh.Text = thongtinBN.TenBenh;
            rpt.xrLabelMaBenh.Text = string.IsNullOrEmpty (thongtinBN.MaBenhKhac) ? thongtinBN.MaBenh : thongtinBN.MaBenh + ";" + thongtinBN.MaBenhKhac;
            try
            {
                rpt.xrLabelNgayLapHD1.Text = "Ngày " + thongtinBN.NgayThanhToan.Substring (6, 2) + " tháng " + thongtinBN.NgayThanhToan.Substring (4, 2) + " năm " + thongtinBN.NgayThanhToan.Substring (0, 4);
                //20170512  "Ngày " +DateTime.Now.Day + " tháng "+DateTime.Now.Month + " năm "+DateTime.Now.Year;
            }catch
            {
                rpt.xrLabelNgayLapHD1.Text = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            }
            rpt.xrLabelNgayLapHD2.Text = rpt.xrLabelNgayLapHD1.Text;
            DataRow[] drNhom = null;
            DataTable data = (gridControlChiTiet.DataSource as DataTable);
            foreach (DataRow dr in thongtinCT.DSNhom ().Rows)
            {
                if ( data!=null)
                {
                    drNhom = data.Select ("NHOM_CHI_PHI = '" + dr[1].ToString() + "'");
                    if (drNhom.Length > 0)
                    {
                        createNhom (drNhom.CopyToDataTable (), rpt, dr, bm);
                    }
                }
            }
            XRTableRow row = new XRTableRow ();
            XRTableCell cell = new XRTableCell ();
            cell.Text = "Tổng Cộng";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 360;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = thongtinBN.TienTongChiPhi.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 100;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = thongtinBN.TienBHTT.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 100;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "00";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = thongtinBN.TienBNTT.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 99;
            row.Cells.Add (cell);

            rpt.xrTableChiPhi.Rows.Add (row);

            rpt.xrLabelChuTongTien.Text = ChuyenSo (thongtinBN.TienTongChiPhi.ToString ());
            rpt.xrLabelChuBHTT.Text = ChuyenSo (thongtinBN.TienBHTT.ToString ());
            rpt.xrLabelChuBNTT.Text = ChuyenSo (thongtinBN.TienBNTT.ToString ());

            rpt.CreateDocument ();
            if (xem)
            {
                rpt.ShowPreviewDialog ();
            }
            else
            {
                SplashScreen.Stop ();
                rpt.PrintDialog ();
            }
            //rpt.Print ();
        }
        private void createNhom(DataTable nhomChiPhi, rptChiPhi rpt, DataRow value, int bm)
        {

            XRTableRow row = new XRTableRow ();
            XRTableCell cell = new XRTableCell ();
            cell.Text = value[bm] + ". "+value[1];
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            cell.Font = fontB;
            cell.WidthF = 749;
            row.Cells.Add (cell);
            rpt.xrTableChiPhi.Rows.Add (row);
            double thanhtien = 0;
            double tienbhtt = 0;
            double tienbntt = 0;
            for (int i =0;i<nhomChiPhi.Rows.Count;i++)
            {
                
                row = new XRTableRow ();

                cell = new XRTableCell ();
                cell.Text = nhomChiPhi.Rows[i][2].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 170;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = nhomChiPhi.Rows[i][3].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                cell.WidthF = 50;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = nhomChiPhi.Rows[i][4].ToString ();
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 60;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = Convert.ToInt32(nhomChiPhi.Rows[i][5].ToString()).ToString("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 80;
                row.Cells.Add (cell);

                int t =  Convert.ToInt32 (nhomChiPhi.Rows[i][6].ToString ());
                thanhtien += t;
                cell = new XRTableCell ();
                cell.Text = t.ToString ("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 100;
                row.Cells.Add (cell);

                t = Convert.ToInt32 (nhomChiPhi.Rows[i][7].ToString ());
                tienbhtt += t;
                cell = new XRTableCell ();
                cell.Text = t.ToString ("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 100;
                row.Cells.Add (cell);

                cell = new XRTableCell ();
                cell.Text = "00";
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 90;
                row.Cells.Add (cell);

                t = Convert.ToInt32 (nhomChiPhi.Rows[i][8].ToString ());
                tienbntt += t;
                cell = new XRTableCell ();
                cell.Text = t.ToString ("0,0", elGR);
                cell.Font = font;
                cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                cell.WidthF = 99;
                row.Cells.Add (cell);

                rpt.xrTableChiPhi.Rows.Add (row);
            }
            row = new XRTableRow ();

            cell = new XRTableCell ();
            cell.Text = "Cộng " + value[bm].ToString().Substring(0,1);
            cell.Font = font;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            cell.WidthF = 360;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = thanhtien.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 100;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = tienbhtt.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 100;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = "00";
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 90;
            row.Cells.Add (cell);

            cell = new XRTableCell ();
            cell.Text = tienbntt.ToString ("0,0", elGR);
            cell.Font = fontB;
            cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            cell.WidthF = 99;
            row.Cells.Add (cell);

            rpt.xrTableChiPhi.Rows.Add (row);
        }
        private void enableButton()
        {
            txtQR.Enabled = false;
            txtBHYT.Enabled = false;
            dateGTBD.Enabled = false;
            dateGTKT.Enabled = false;
            txtHoTen.Enabled = false;
            cbGioiTinh.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaDKKCB.Enabled = false;
            txtTenBV.Enabled = false;
            txtCanNang.Enabled = false;
            lookUpMaTaiNan.Enabled = false;
            txtDu5Nam.Enabled = false;
            lookUpNoiChuyenDen.Enabled = false;
            txtSoNgayDTri.Enabled = false;
            dateThanhToan.Enabled = false;

            cbTTRaVien.Enabled = false;
            cbKQDTri.Enabled = false;
            dateNgayVao.Enabled = false;
            dateNgayRa.Enabled = false;
            cbLoaiKCB.Enabled = false;
            cbLyDo.Enabled = false;
            cbKhuVuc.Enabled = false;
        }
        private void FrmNgoaiNoiTru_Load (object sender, EventArgs e)
        {
            LoadData ();

            //([012][1-9]|[123]0|31)/([0][1-9]|1[012])/([123][0-9][0-9][0-9]) (0[0-9]|1[0-9]|2[0-3])\:[0-5]\d

            searchLookUpEditView.Appearance.FocusedRow.BackColor = Color.FromArgb (128, 255, 128);
            searchLookUpEditView.Appearance.FocusedRow.Options.UseBackColor = true;
            searchLookUpEditView.Appearance.SelectedRow.BackColor = Color.FromArgb (128, 255, 128);
            searchLookUpEditView.Appearance.SelectedRow.Options.UseBackColor = true;
            // Phòng khám
            //enableButton ();
        }
        private void taoBangTongHop (XmlDocument doc, XmlElement tonghop, THONGTIN_CTVO thongtin)
        {
            XmlElement ma_lk = doc.CreateElement (string.Empty, "ma_lk", string.Empty);
            XmlText txt = doc.CreateTextNode (thongtin.MaLK);
            ma_lk.AppendChild (txt);
            tonghop.AppendChild (ma_lk);

            XmlElement stt = doc.CreateElement (string.Empty, "stt", string.Empty);
            stt.AppendChild (doc.CreateTextNode (thongtin.MaBN.Substring (8, 4)));
            tonghop.AppendChild (stt);

            XmlElement maBN = doc.CreateElement (string.Empty, "ma_bn", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaBN);
            maBN.AppendChild (txt);
            tonghop.AppendChild (maBN);

            XmlElement hoten = doc.CreateElement (string.Empty, "ho_ten", string.Empty);
            hoten.AppendChild (doc.CreateCDataSection (thongtin.HoTen));
            tonghop.AppendChild (hoten);

            XmlElement ngaysinh = doc.CreateElement (string.Empty, "ngay_sinh", string.Empty);
            txt = doc.CreateTextNode (thongtin.NgaySinh);
            ngaysinh.AppendChild (txt);
            tonghop.AppendChild (ngaysinh);

            XmlElement gioitinh = doc.CreateElement (string.Empty, "gioi_tinh", string.Empty);
            if(thongtin.GioiTinh == 0)
            {
                txt = doc.CreateTextNode ("2");
            }
            else
            {
                txt = doc.CreateTextNode ("1");
            }
            
            gioitinh.AppendChild (txt);
            tonghop.AppendChild (gioitinh);

            XmlElement diachi = doc.CreateElement (string.Empty, "dia_chi", string.Empty);
            diachi.AppendChild (doc.CreateCDataSection (thongtin.DiaChi));
            tonghop.AppendChild (diachi);

            XmlElement mathe = doc.CreateElement (string.Empty, "ma_the", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaThe);
            mathe.AppendChild (txt);
            tonghop.AppendChild (mathe);

            XmlElement madkbd = doc.CreateElement (string.Empty, "ma_dkbd", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaDKBD);
            madkbd.AppendChild (txt);
            tonghop.AppendChild (madkbd);

            XmlElement gtt = doc.CreateElement (string.Empty, "gt_the_tu", string.Empty);
            txt = doc.CreateTextNode (thongtin.GtTheTu);
            gtt.AppendChild (txt);
            tonghop.AppendChild (gtt);

            XmlElement gtd = doc.CreateElement (string.Empty, "gt_the_den", string.Empty);
            txt = doc.CreateTextNode (thongtin.GtTheDen);
            gtd.AppendChild (txt);
            tonghop.AppendChild (gtd);

            XmlElement tenbenh = doc.CreateElement (string.Empty, "ten_benh", string.Empty);
            tenbenh.AppendChild (doc.CreateCDataSection (thongtin.TenBenh));
            tonghop.AppendChild (tenbenh);

            XmlElement mabenh = doc.CreateElement (string.Empty, "ma_benh", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaBenh);
            mabenh.AppendChild (txt);
            tonghop.AppendChild (mabenh);

            XmlElement mabenhkhac = doc.CreateElement (string.Empty, "ma_benhkhac", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaBenhKhac);
            mabenhkhac.AppendChild (txt);
            tonghop.AppendChild (mabenhkhac);

            XmlElement MA_LYDO_VVIEN = doc.CreateElement (string.Empty, "ma_lydo_vvien", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaLyDoVaoVien.ToString ());
            MA_LYDO_VVIEN.AppendChild (txt);
            tonghop.AppendChild (MA_LYDO_VVIEN);

            XmlElement MA_NOI_CHUYEN = doc.CreateElement (string.Empty, "ma_noi_chuyen", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaNoiChuyen);
            MA_NOI_CHUYEN.AppendChild (txt);
            tonghop.AppendChild (MA_NOI_CHUYEN);

            XmlElement MA_TAI_NAN = doc.CreateElement (string.Empty, "ma_tai_nan", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaTaiNan.ToString ());
            MA_TAI_NAN.AppendChild (txt);
            tonghop.AppendChild (MA_TAI_NAN);

            XmlElement NGAY_VAO = doc.CreateElement (string.Empty, "ngay_vao", string.Empty);
            txt = doc.CreateTextNode (thongtin.NgayVao);
            NGAY_VAO.AppendChild (txt);
            tonghop.AppendChild (NGAY_VAO);

            XmlElement NGAY_RA = doc.CreateElement (string.Empty, "ngay_ra", string.Empty);
            txt = doc.CreateTextNode (thongtin.NgayRa);
            NGAY_RA.AppendChild (txt);
            tonghop.AppendChild (NGAY_RA);

            XmlElement SO_NGAY_DTRI = doc.CreateElement (string.Empty, "so_ngay_dtri", string.Empty);
            txt = doc.CreateTextNode (thongtin.SoNgayDieuTri.ToString ());
            SO_NGAY_DTRI.AppendChild (txt);
            tonghop.AppendChild (SO_NGAY_DTRI);

            XmlElement KET_QUA_DTRI = doc.CreateElement (string.Empty, "ket_qua_dtri", string.Empty);
            txt = doc.CreateTextNode (thongtin.KetQuaDieuTri.ToString ());
            KET_QUA_DTRI.AppendChild (txt);
            tonghop.AppendChild (KET_QUA_DTRI);

            XmlElement TINH_TRANG_RV = doc.CreateElement (string.Empty, "tinh_trang_rv", string.Empty);
            txt = doc.CreateTextNode (thongtin.TinhTrangRaVien.ToString ());
            TINH_TRANG_RV.AppendChild (txt);
            tonghop.AppendChild (TINH_TRANG_RV);

            XmlElement NGAY_TTOAN = doc.CreateElement (string.Empty, "ngay_ttoan", string.Empty);
            txt = doc.CreateTextNode (thongtin.NgayThanhToan);
            NGAY_TTOAN.AppendChild (txt);
            tonghop.AppendChild (NGAY_TTOAN);

            XmlElement MUC_HUONG = doc.CreateElement (string.Empty, "muc_huong", string.Empty);
            txt = doc.CreateTextNode (thongtin.MucHuong.ToString ());
            MUC_HUONG.AppendChild (txt);
            tonghop.AppendChild (MUC_HUONG);

            XmlElement T_THUOC = doc.CreateElement (string.Empty, "t_thuoc", string.Empty);
            txt = doc.CreateTextNode (thongtin.TienThuoc.ToString ());
            T_THUOC.AppendChild (txt);
            tonghop.AppendChild (T_THUOC);

            XmlElement T_VTYT = doc.CreateElement (string.Empty, "t_vtyt", string.Empty);
            txt = doc.CreateTextNode (thongtin.TienVTYT.ToString ());
            T_VTYT.AppendChild (txt);
            tonghop.AppendChild (T_VTYT);

            XmlElement T_TONGCHI = doc.CreateElement (string.Empty, "t_tongchi", string.Empty);
            txt = doc.CreateTextNode (thongtin.TienTongChiPhi.ToString ());
            T_TONGCHI.AppendChild (txt);
            tonghop.AppendChild (T_TONGCHI);

            XmlElement T_BNTT = doc.CreateElement (string.Empty, "t_bhtt", string.Empty);
            txt = doc.CreateTextNode (thongtin.TienBHTT.ToString ());
            T_BNTT.AppendChild (txt);
            tonghop.AppendChild (T_BNTT);

            XmlElement T_BHTT = doc.CreateElement (string.Empty, "t_bntt", string.Empty);
            txt = doc.CreateTextNode (thongtin.TienBNTT.ToString ());
            T_BHTT.AppendChild (txt);
            tonghop.AppendChild (T_BHTT);

            XmlElement T_NGUONKHAC = doc.CreateElement (string.Empty, "t_nguonkhac", string.Empty);
            txt = doc.CreateTextNode (thongtin.TienNguonKhac.ToString ());
            T_NGUONKHAC.AppendChild (txt);
            tonghop.AppendChild (T_NGUONKHAC);

            XmlElement T_NGOAIDS = doc.CreateElement (string.Empty, "t_ngoaids", string.Empty);
            txt = doc.CreateTextNode (thongtin.TienNgoaiDS.ToString ());
            T_NGOAIDS.AppendChild (txt);
            tonghop.AppendChild (T_NGOAIDS);

            XmlElement NAM_QT = doc.CreateElement (string.Empty, "nam_qt", string.Empty);
            txt = doc.CreateTextNode (thongtin.NamQT);
            NAM_QT.AppendChild (txt);
            tonghop.AppendChild (NAM_QT);

            XmlElement THANG_QT = doc.CreateElement (string.Empty, "thang_qt", string.Empty);
            txt = doc.CreateTextNode (thongtin.ThangQT);
            THANG_QT.AppendChild (txt);
            tonghop.AppendChild (THANG_QT);

            XmlElement MA_LOAI_KCB = doc.CreateElement (string.Empty, "ma_loai_kcb", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaLoaiKCB.ToString());
            MA_LOAI_KCB.AppendChild (txt);
            tonghop.AppendChild (MA_LOAI_KCB);

            XmlElement MA_KHOA = doc.CreateElement (string.Empty, "ma_khoa", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaKhoa);
            MA_KHOA.AppendChild (txt);
            tonghop.AppendChild (MA_KHOA);

            XmlElement MA_CSKCB = doc.CreateElement (string.Empty, "ma_cskcb", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaCSKCB);
            MA_CSKCB.AppendChild (txt);
            tonghop.AppendChild (MA_CSKCB);

            XmlElement MA_KHUVUC = doc.CreateElement (string.Empty, "ma_khuvuc", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaKV);
            MA_KHUVUC.AppendChild (txt);
            tonghop.AppendChild (MA_KHUVUC);

            XmlElement MA_PTTTT_QT = doc.CreateElement (string.Empty, "ma_pttt_qt", string.Empty);
            txt = doc.CreateTextNode (thongtin.MaPTTTQT);
            MA_PTTTT_QT.AppendChild (txt);
            tonghop.AppendChild (MA_PTTTT_QT);

            XmlElement CAN_NANG = doc.CreateElement (string.Empty, "can_nang", string.Empty);
            txt = doc.CreateTextNode (thongtin.CanNang.ToString ());
            CAN_NANG.AppendChild (txt);
            tonghop.AppendChild (CAN_NANG);
        }
        private void taoBangThuoc (XmlDocument doc, XmlElement bangthuoc, Thuoc_CTVO thuoc)
        {
            XmlElement CTTHUOC = doc.CreateElement (string.Empty, "CTTHUOC", string.Empty);
            bangthuoc.AppendChild (CTTHUOC);

            XmlElement elementThuoc = doc.CreateElement (string.Empty, "ma_lk", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.MaLK));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "stt", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode ("0"));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ma_thuoc", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.MaThuoc));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ma_nhom", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.Nhom));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ten_thuoc", string.Empty);
            elementThuoc.AppendChild (doc.CreateCDataSection (thuoc.TenThuoc));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "don_vi_tinh", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.DonViTinh));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ham_luong", string.Empty);
            elementThuoc.AppendChild (doc.CreateCDataSection (thuoc.HamLuong));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "duong_dung", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.DuongDung));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "lieu_dung", string.Empty);
            elementThuoc.AppendChild (doc.CreateCDataSection (thuoc.LieuDung));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "so_dang_ky", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.SoDK));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "so_luong", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.SoLuong.ToString ()));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "don_gia", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.DonGia.ToString ()));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "tyle_tt", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.TyLeTT.ToString ()));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "thanh_tien", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.ThanhTien.ToString ()));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ma_khoa", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.MaKhoa));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ma_bac_si", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.MaBacSi));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ma_benh", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.MaBenh));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ngay_yl", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.NgayYL));
            CTTHUOC.AppendChild (elementThuoc);

            elementThuoc = doc.CreateElement (string.Empty, "ma_pttt", string.Empty);
            elementThuoc.AppendChild (doc.CreateTextNode (thuoc.MaPTTT.ToString ()));
            CTTHUOC.AppendChild (elementThuoc);

        }
        private void taoBangDVKT (XmlDocument doc, XmlElement bangdvkt, DVKT_CTVO dvkt)
        {
            XmlElement CTDV = doc.CreateElement (string.Empty, "CTDV", string.Empty);
            bangdvkt.AppendChild (CTDV);

            XmlElement elementDVKT = doc.CreateElement (string.Empty, "ma_lk", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.MaLK));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "stt", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode ("0"));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ma_dich_vu", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.MaDichVu));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ma_vat_tu", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.MaDichVu));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ma_nhom", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.MaNhom));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ten_dich_vu", string.Empty);
            elementDVKT.AppendChild (doc.CreateCDataSection (dvkt.TenDichVu));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "don_vi_tinh", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.DonViTinh));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "so_luong", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.SoLuong.ToString()));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "don_gia", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.DonGia.ToString()));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "tyle_tt", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.TyLeTT.ToString()));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "thanh_tien", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.ThanhTien.ToString()));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ma_khoa", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.MaKhoa));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ma_bac_si", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.MaBacSi));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ma_benh", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.MaBenh));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ngay_yl", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.NgayYLenh));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ngay_kq", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.NgayQK));
            CTDV.AppendChild (elementDVKT);

            elementDVKT = doc.CreateElement (string.Empty, "ma_pttt", string.Empty);
            elementDVKT.AppendChild (doc.CreateTextNode (dvkt.MaPTTT.ToString()));
            CTDV.AppendChild (elementDVKT);
        }

        private string ChuyenSo (string number)
        {
            string[] dv = { "", "mươi", "trăm", "nghìn", "triệu", "tỉ" };
            string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string doc;
            int i, j, k, n, len, found, ddv, rd;

            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;

            i = 0;
            while (i < len)
            {
                //So chu so o hang dang duyet
                n = (len - i + 2) % 3 + 1;

                //Kiem tra so 0
                found = 0;
                for (j = 0; j < n; j++)
                {
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }
                }

                //Duyet n chu so
                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j < n; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                if (n - j == 3)
                                    doc += cs[0] + " ";
                                if (n - j == 2)
                                {
                                    if (number[i + j + 1] != '0')
                                        doc += "lẻ ";
                                    ddv = 0;
                                }
                                break;
                            case '1':
                                if (n - j == 3)
                                    doc += cs[1] + " ";
                                if (n - j == 2)
                                {
                                    doc += "mười ";
                                    ddv = 0;
                                }
                                if (n - j == 1)
                                {
                                    if (i + j == 0)
                                        k = 0;
                                    else
                                        k = i + j - 1;

                                    if (number[k] != '1' && number[k] != '0')
                                        doc += "mốt ";
                                    else
                                        doc += cs[1] + " ";
                                }
                                break;
                            case '5':
                                if (i + j == len - 1)
                                    doc += "lăm ";
                                else
                                    doc += cs[5] + " ";
                                break;
                            default:
                                doc += cs[(int) number[i + j] - 48] + " ";
                                break;
                        }

                        //Doc don vi nho
                        if (ddv == 1)
                        {
                            doc += dv[n - j - 1] + " ";
                        }
                    }
                }


                //Doc don vi lon
                if (len - i - n > 0)
                {
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k < (len - i - n) / 9; k++)
                                doc += "tỉ ";
                        rd = 0;
                    }
                    else
                        if (found != 0)
                        doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                }

                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5')
                    return cs[(int) number[0] - 48];

            return doc + "đồng";
        }

        private void btnTim_Click (object sender, EventArgs e)
        {
            MaLienKet = string.Empty;
            frmDanhSach.ShowDialog ();
            if(!string.IsNullOrEmpty(MaLienKet))
            {
                thongtinBN = thongtinCT.getThongTin (MaLienKet);
                if (thongtinBN != null)
                {
                    capNhat = true;
                    btnXoa.Enabled = true;
                    btnTien.Enabled = true;
                    btnLui.Enabled = true;
                    //
                    thongtinBN.MaLK = MaLienKet;
                    txtMaBN.Text = thongtinBN.MaBN;
                    txtBHYT.Text = thongtinBN.MaThe;

                    dvTienGiuong = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "15").AsDataView ();
                    dvCongKham = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "13").AsDataView ();
                    dvTienDVKT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK).AsDataView ();
                    dvTienThuoc = thongtinCT.DSNhomThuoc (thongtinBN.MaLK).AsDataView ();
                    dvTienVTYT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "10").AsDataView ();

                    reLoadData (true);

                    dateGTBD.Text = Utils.ParseDate (thongtinBN.GtTheTu,true);
                    dateGTKT.Text = Utils.ParseDate (thongtinBN.GtTheDen,true);
                    txtMucHuong.Text = thongtinBN.MucHuong.ToString ();
                    cbKhuVuc.Text = thongtinBN.MaKV;
                    txtHoTen.Text = thongtinBN.HoTen;
                    cbGioiTinh.SelectedIndex = thongtinBN.GioiTinh;
                    txtNgaySinh.Text = Utils.ParseDate (thongtinBN.NgaySinh,true);
                    txtDiaChi.Text = thongtinBN.DiaChi;
                    txtCanNang.Text = thongtinBN.CanNang.ToString();
                    lookUpMaKhoa.EditValue = thongtinBN.MaKhoa;
                    if (string.IsNullOrEmpty (maBS) || maBS !="")
                    {
                        lookUpMaBS.EditValue = maBS;
                    }
                    else
                    {
                        lookUpMaBS.EditValue = thongtinBN.MaBS;
                    }

                    lookUpMaTaiNan.EditValue = thongtinBN.MaTaiNan;
                    lookUpMaBenh.EditValue = thongtinBN.MaBenh;
                    txtTenBenh.Text = thongtinBN.TenBenh;
                    cbKQDTri.SelectedIndex = thongtinBN.KetQuaDieuTri - 1;
                    cbTTRaVien.SelectedIndex = thongtinBN.TinhTrangRaVien - 1;
                    txtMaBenhKhac.Text = thongtinBN.MaBenhKhac;
                    cbLyDo.SelectedIndex = thongtinBN.MaLyDoVaoVien - 1;
                    cbLoaiKCB.SelectedIndex = thongtinBN.MaLoaiKCB - 1;
                    dateNgayVao.Text = Utils.ParseDates (thongtinBN.NgayVao);
                    dateNgayRa.Text = Utils.ParseDates (thongtinBN.NgayRa);
                    dateThanhToan.Text = Utils.ParseDates (thongtinBN.NgayThanhToan);
                    txtSoNgayDTri.Text = thongtinBN.SoNgayDieuTri.ToString ();
                    txtMaDKKCB.Text = thongtinBN.MaDKBD;
                    lookUpNoiChuyenDen.EditValue = thongtinBN.MaNoiChuyen;
                    cbPhong.SelectedIndex = thongtinBN.Phong;
                    try
                    {
                        //KCBVO kcb = thongtinCT.getCoSoKCB (txtMaDKKCB.Text);
                        txtTenBV.Text = (lookUpNoiChuyenDen.Properties.GetDataSourceRowByKeyValue (txtMaDKKCB.Text) as DataRowView)[1].ToString ();
                    }
                    catch { }

                    //txtQR.ReadOnly = true;
                }
            }
        }
        private string VietHoa (string s)
        {
            if (String.IsNullOrEmpty (s))
                return s;

            string result = "";

            //lấy danh sách các từ  

            string[] words = s.Split (' ');

            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim () != "")
                {
                    if (word.Length > 1)
                        result += word.Substring (0, 1).ToUpper () + word.Substring (1) + " ";
                    else
                        result += word.ToUpper () + " ";
                }

            }
            return result.Trim ();
        }

        private void txtHoTen_Leave (object sender, EventArgs e)
        {
            txtHoTen.Text = VietHoa (txtHoTen.Text);
        }

        private void txtBHYT_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(txtBHYT.Text.Length !=15)
                {
                    MessageBox.Show ("Mã thẻ phải 15 ký tự.");
                    txtBHYT.Focus ();
                    return;
                }
                dateGTBD.Focus ();
            }
        }

        private void dateGTBD_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dateGTKT.Focus ();
            }
        }

        private void dateGTKT_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHoTen.Focus ();
            }
        }

        private void txtHoTen_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbGioiTinh.Focus ();
            }
        }

        private void cbGioiTinh_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNgaySinh.Focus ();
            }
        }

        private void txtNgaySinh_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnKiemTra.Focus ();
            }
        }

        private void lookUpMaKhoa_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lookUpMaBS.Focus ();
            }
        }

        private void txtDiaChi_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDiaChi.Text = VietHoa (txtDiaChi.Text);
                lookUpMaKhoa.Focus ();
            }
        }

        private void lookUpMaBS_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMaDKKCB.Focus ();
            }
        }

        private void lookUpMaBenh_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMaBenhKhac.Focus ();
            }
        }

        private void dateNgayVao_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dateNgayRa.Focus ();
            }
        }

        private void dateNgayRa_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnCongKham.Focus ();
            }
        }

        private void txtMaDKKCB_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                try
                {
                    txtTenBV.Text = (lookUpNoiChuyenDen.Properties.GetDataSourceRowByKeyValue (txtMaDKKCB.Text) as DataRowView)[1].ToString ();
                    lookUpMaBenh.Focus ();
                }
                catch { }
            }
        }

        private void FrmNgoaiNoiTru_KeyDown (object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.S | Keys.Control))
            {
                btnLuu_Click (null, null);
            }
            if (e.KeyData == (Keys.P | Keys.Control))
            {
                btnLuuIn_Click (null, null);
            }
            if (e.KeyData == (Keys.N | Keys.Control))
            {
                bntMoi_Click (null, null);
            }
            if (e.KeyData == (Keys.F | Keys.Control))
            {
                btnTim_Click (null, null);
            }
            if (e.KeyData == (Keys.T | Keys.Control))
            {
                btnChiPhiThuoc_Click (null, null);
            }
            if (e.KeyData == (Keys.K | Keys.Control) && btnCongKham.Enabled)
            {
                btnCongKham_Click (null, null);
            }
            if (e.KeyData == (Keys.G | Keys.Control) && btnTienGiuong.Enabled)
            {
                btnTienGiuong_Click (null, null);
            }
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show ("Chắc chắn bạn muốn xóa hồ sơ này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                if (!thongtinCT.XoaThongTinCT (ref err, thongtinBN.MaLK))
                {
                    MessageBox.Show (err);
                    return;
                }
                xoaCheckout ();
                bntMoi_Click (null, null);
            }
        }

        private void xoaCheckout()
        {
            string file = filePath + thongtinBN.MaBN + "_" + thongtinBN.MaThe + ".xml";
            if (File.Exists(file))
            {
                File.Delete (file);
            }
        }

        private void txtBHYT_TextChanged (object sender, EventArgs e)
        {
            if (txtBHYT.Text.Length == 15 && string.IsNullOrEmpty(MaLienKet))
            {
                try
                {
                    int maSo = int.Parse (txtBHYT.Text.Substring (2, 1));
                    BHYTVO bh = new BHYTVO ();
                    bh = bhyt.getBHYT (maSo);
                    string doiTuong = txtBHYT.Text.Substring (0, 2);
                    foreach (string nhom in bh.NhomDT.Split (','))
                    {
                        if (nhom.ToUpper ().Contains (doiTuong.ToUpper ()))
                        {
                            thongtinBN.MucHuong = int.Parse (bh.TyLe.ToString ());
                            txtTyLe.Text = bh.TyLe.ToString ();
                            txtMucHuong.Text = maSo.ToString ();
                            thongtinThe = thongtinBHYT.getBHYT (txtBHYT.Text,
                                DateTime.ParseExact (dateNgayVao.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd"));
                            if (thongtinThe != null)
                            {
                                // gan tri Benh nhan
                                if (!string.IsNullOrEmpty (thongtinThe.MaLK))
                                {
                                    MessageBox.Show ("Bệnh nhân này hôm nay đã khám!");
                                    txtBHYT.ResetText ();
                                    return;
                                }
                                txtHoTen.Text = thongtinThe.HoTen;
                                cbGioiTinh.SelectedIndex = thongtinThe.GioiTinh;
                                txtNgaySinh.Text = Utils.ParseDate (thongtinThe.NgaySinh, true);
                                txtDiaChi.Text = thongtinThe.DiaChi;
                                dateGTBD.Text = Utils.ParseDate (thongtinThe.GtTheTu, true);
                                dateGTKT.Text = Utils.ParseDate (thongtinThe.GtTheDen, true);
                                cbKhuVuc.Text = thongtinThe.MaKV;
                                lookUpMaBS.Focus ();
                                return;
                            }
                            dateGTBD.Focus ();
                            return;
                        }
                    }
                    MessageBox.Show ("Ba ký tự đầu mã thẻ không đúng!");
                    txtBHYT.ResetText ();
                    txtBHYT.Focus ();
                }
                catch
                {
                    MessageBox.Show ("Ba ký tự đầu mã thẻ không đúng!");
                    txtBHYT.ResetText ();
                    txtBHYT.Focus ();
                }
            }
        }

        private void lookUpMaBenhKhac_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==13)
            {
                if (lookUpMaBenh.GetSelectedDataRow () != null)
                {
                    object tmp = lookUpMaBenhKhac.GetSelectedDataRow ();
                    if (tmp is DataRowView)
                    {
                        if (checkMaBenh ((tmp as DataRowView)[0].ToString ()))
                        {
                            txtTenBenh.Text = txtTenBenh.Text + "; " + (tmp as DataRowView)[1].ToString ();
                            txtMaBenhKhac.Text += string.IsNullOrEmpty (txtMaBenhKhac.Text) ? (tmp as DataRowView)[0].ToString () : ("; " + (tmp as DataRowView)[0].ToString ());

                        }
                        else
                        {
                            MessageBox.Show ("Mã bệnh đã được chọn");
                        }
                    }
                }
                else
                {
                    MessageBox.Show ("Vui lòng nhập bệnh chính trước.");
                    lookUpMaBenh.Focus ();
                }
            }
        }

        private void btnLui_Click (object sender, EventArgs e)
        {
            if(thongtinBN != null && !string.IsNullOrEmpty(thongtinBN.MaBN))
            {
                object t = thongtinCT.getThongTinLui (thongtinBN.MaBN);
                if (t != null)
                {
                    thongtinBN = (t as THONGTIN_CTVO);
                    txtMaBN.Text = thongtinBN.MaBN;
                    txtBHYT.Text = thongtinBN.MaThe;

                    dvTienGiuong = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "15").AsDataView ();
                    dvCongKham = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "13").AsDataView ();
                    dvTienDVKT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK).AsDataView ();
                    dvTienThuoc = thongtinCT.DSNhomThuoc (thongtinBN.MaLK).AsDataView ();
                    reLoadData (true);

                    dateGTBD.Text = Utils.ParseDate (thongtinBN.GtTheTu, true);
                    dateGTKT.Text = Utils.ParseDate (thongtinBN.GtTheDen, true);
                    txtMucHuong.Text = thongtinBN.MucHuong.ToString ();
                    cbKhuVuc.Text = thongtinBN.MaKV;
                    txtHoTen.Text = thongtinBN.HoTen;
                    cbGioiTinh.SelectedIndex = thongtinBN.GioiTinh;
                    txtNgaySinh.Text = Utils.ParseDate (thongtinBN.NgaySinh, true);
                    txtDiaChi.Text = thongtinBN.DiaChi;
                    txtCanNang.Text = thongtinBN.CanNang.ToString ();
                    lookUpMaKhoa.EditValue = thongtinBN.MaKhoa;
                    lookUpMaBS.EditValue = maBS;
                    lookUpMaTaiNan.EditValue = thongtinBN.MaTaiNan;
                    lookUpMaBenh.EditValue = thongtinBN.MaBenh;
                    txtTenBenh.Text = thongtinBN.TenBenh;
                    cbKQDTri.SelectedIndex = thongtinBN.KetQuaDieuTri - 1;
                    cbTTRaVien.SelectedIndex = thongtinBN.TinhTrangRaVien - 1;
                    txtMaBenhKhac.Text = thongtinBN.MaBenhKhac;
                    cbLyDo.SelectedIndex = thongtinBN.MaLyDoVaoVien - 1;
                    cbLoaiKCB.SelectedIndex = thongtinBN.MaLoaiKCB - 1;
                    dateNgayVao.Text = Utils.ParseDates (thongtinBN.NgayVao);
                    dateNgayRa.Text = Utils.ParseDates (thongtinBN.NgayRa);
                    dateThanhToan.Text = Utils.ParseDates (thongtinBN.NgayThanhToan);
                    txtSoNgayDTri.Text = thongtinBN.SoNgayDieuTri.ToString ();
                    txtMaDKKCB.Text = thongtinBN.MaDKBD;
                    capNhat = true;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void btnTien_Click (object sender, EventArgs e)
        {
            if (thongtinBN!=null  && !string.IsNullOrEmpty (thongtinBN.MaBN))
            {
                object t = thongtinCT.getThongTinTien (thongtinBN.MaBN);
                if (t != null)
                {
                    thongtinBN = (t as THONGTIN_CTVO);
                    //thongtinBN.MaLK = MaLienKet;
                    txtMaBN.Text = thongtinBN.MaBN;
                    txtBHYT.Text = thongtinBN.MaThe;

                    dvTienGiuong = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "15").AsDataView ();
                    dvCongKham = thongtinCT.DSNhomDVKT (thongtinBN.MaLK, "13").AsDataView ();
                    dvTienDVKT = thongtinCT.DSNhomDVKT (thongtinBN.MaLK).AsDataView ();
                    dvTienThuoc = thongtinCT.DSNhomThuoc (thongtinBN.MaLK).AsDataView ();
                    reLoadData (true);

                    dateGTBD.Text = Utils.ParseDate (thongtinBN.GtTheTu, true);
                    dateGTKT.Text = Utils.ParseDate (thongtinBN.GtTheDen, true);
                    txtMucHuong.Text = thongtinBN.MucHuong.ToString ();
                    cbKhuVuc.Text = thongtinBN.MaKV;
                    txtHoTen.Text = thongtinBN.HoTen;
                    cbGioiTinh.SelectedIndex = thongtinBN.GioiTinh;
                    txtNgaySinh.Text = Utils.ParseDate (thongtinBN.NgaySinh, true);
                    txtDiaChi.Text = thongtinBN.DiaChi;
                    txtCanNang.Text = thongtinBN.CanNang.ToString ();
                    lookUpMaKhoa.EditValue = thongtinBN.MaKhoa;
                    lookUpMaBS.EditValue = maBS;
                    lookUpMaTaiNan.EditValue = thongtinBN.MaTaiNan;
                    lookUpMaBenh.EditValue = thongtinBN.MaBenh;
                    txtTenBenh.Text = thongtinBN.TenBenh;
                    cbKQDTri.SelectedIndex = thongtinBN.KetQuaDieuTri - 1;
                    cbTTRaVien.SelectedIndex = thongtinBN.TinhTrangRaVien - 1;
                    txtMaBenhKhac.Text = thongtinBN.MaBenhKhac;
                    cbLyDo.SelectedIndex = thongtinBN.MaLyDoVaoVien - 1;
                    cbLoaiKCB.SelectedIndex = thongtinBN.MaLoaiKCB - 1;
                    dateNgayVao.Text = Utils.ParseDates (thongtinBN.NgayVao);
                    dateNgayRa.Text = Utils.ParseDates (thongtinBN.NgayRa);
                    dateThanhToan.Text = Utils.ParseDates (thongtinBN.NgayThanhToan);
                    txtSoNgayDTri.Text = thongtinBN.SoNgayDieuTri.ToString ();
                    txtMaDKKCB.Text = thongtinBN.MaDKBD;
                    capNhat = true;
                    btnXoa.Enabled = true;
                }
            }
        }

        private void btnInDonThuoc_Click (object sender, EventArgs e)
        {
            try
            {
                DonThuocVO donthuoc = new DonThuocVO ();
                donthuoc.HoTen = txtHoTen.Text;
                donthuoc.SoHS = txtMaBN.Text;
                donthuoc.NamSinh = txtNgaySinh.Text;
                donthuoc.GioiTinh = cbGioiTinh.SelectedIndex;
                donthuoc.NgheNghiep = "";
                donthuoc.DiaChi = txtDiaChi.Text;
                donthuoc.SoThe = txtBHYT.Text;
                donthuoc.NoiKCB = txtMaDKKCB.Text + " - " + txtTenBV.Text;
                donthuoc.HanSuDung = dateGTBD.Text + " đến " + dateGTKT.Text;
                donthuoc.DinhBenh = txtTenBenh.Text;
                donthuoc.BacSi = (lookUpMaBS.GetSelectedDataRow () as DataRowView)[1].ToString ();
                donthuoc.NgayTT = "Ngày " + dateThanhToan.Text.Substring (0, 2) + " tháng " + dateThanhToan.Text.Substring (3, 2) + " năm " + dateThanhToan.Text.Substring (6, 4);
                FrmInDonThuoc frm = new FrmInDonThuoc (dvTienThuoc, donthuoc, dtDuongDung );
                frm.CoSoKCB = (lookUpNoiChuyenDen.Properties.GetDataSourceRowByKeyValue (AppConfig.CoSoKCB) as DataRowView)[1].ToString ();
                frm.ShowDialog ();
                btnLuu_Click (null, null);
            }
            catch
            { }
        }

        private void btnLuuXem_Click (object sender, EventArgs e)
        {
            btnLuu_Click (null, null);
            if (loi)
            {
                createReportChiPhi (true);
            }
        }

        private void dateNgayVao_Leave (object sender, EventArgs e)
        {
            DateTime dateVao = DateTime.ParseExact (dateNgayVao.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dateRa = DateTime.ParseExact (dateNgayRa.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan ngayDTri = dateRa.Subtract (dateVao);
            //if (cbLoaiKCB.SelectedIndex > 0)
            //{
            //    txtSoNgayDTri.Text = (ngayDTri.Days + 2).ToString ();
            //}
            //else
            {
                txtSoNgayDTri.Text = (ngayDTri.Days + 1).ToString ();
            }
        }

        private void FrmNgoaiNoiTru_Shown (object sender, EventArgs e)
        {
            SplashScreen.Stop ();
        }

        private void txtQR_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                kiemTraQR ();
            }
        }
        private void kiemTraQR()
        {
            if(txtQR.Text.Length>0)
            {
                string[] qr = null;
                if (txtQR.Text.Split ('~').Length > 1)
                {
                    qr = txtQR.Text.Split ('~');
                }
                if (txtQR.Text.Split ('|').Length > 1)
                {
                    qr = txtQR.Text.Split ('|');
                }
                if (qr!=null && qr.Length==15)
                {
                    txtBHYT.Text = qr[0];
                    txtHoTen.Text =Utils.HexToText(qr[1]);
                    txtNgaySinh.Text = qr[2];
                    if (int.Parse (qr[3]) == 1)
                    {
                        cbGioiTinh.SelectedIndex = 1;
                    }
                    else
                    {
                        cbGioiTinh.SelectedIndex = 0;
                    }
                    txtDiaChi.Text = Utils.HexToText(qr[4]);
                    txtMaDKKCB.Text = qr[5].Remove(2,3);
                    try
                    {
                        txtTenBV.Text = (lookUpNoiChuyenDen.Properties.GetDataSourceRowByKeyValue (txtMaDKKCB.Text) as DataRowView)[1].ToString ();
                    }
                    catch { }
                    dateGTBD.Text = qr[6];
                    dateGTKT.Text = qr[7];
                    txtDu5Nam.Text = qr[12];

                    if(qr[11] == "5")
                    {
                        cbKhuVuc.SelectedIndex = 0;
                    }
                    else
                    if (qr[11] == "6")
                    {
                        cbKhuVuc.SelectedIndex = 1;
                    }
                    else
                    if (qr[11] == "7")
                    {
                        cbKhuVuc.SelectedIndex = 2;
                    }
                    btnKiemTra.Focus ();

                    return;
                }
                else
                {
                    MessageBox.Show ("Sai mã QR!");
                    txtQR.SelectAll ();
                    txtQR.Focus ();
                }
            }
            txtBHYT.Focus ();
        }

        private async void btnKiemTra_Click (object sender, EventArgs e)
        {
            if (txtBHYT.Text.Length != 15)
            {
                MessageBox.Show ("Nhập mã thẻ (gồm 15 ký tự)!");
                txtBHYT.SelectAll ();
                txtBHYT.Focus ();
                return;
            }
            if (string.IsNullOrEmpty (txtHoTen.Text))
            {
                MessageBox.Show ("Nhập họ tên!");
                txtHoTen.SelectAll ();
                txtHoTen.Focus ();
                return ;
            }
            if (string.IsNullOrEmpty (txtNgaySinh.Text))
            {
                MessageBox.Show ("Nhập ngày sinh!");
                txtNgaySinh.SelectAll ();
                txtNgaySinh.Focus ();
                return;
            }
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>> ()
            {
                new KeyValuePair<string, string>("MaThe",txtBHYT.Text),
                new KeyValuePair<string, string>("HoTen",txtHoTen.Text),
                new KeyValuePair<string, string>("NgaySinh",txtNgaySinh.Text)
            };
            HttpContent q = new FormUrlEncodedContent (queries);
            using (HttpClient client = new HttpClient ())
            {
                try
                {
                    using (HttpResponseMessage response = await client.PostAsync ("https://gdbhyt.baohiemxahoi.gov.vn/ThongTuyenLSKCB/CheckMaThe", q))
                    {

                        if (response.IsSuccessStatusCode)
                        {

                            using (HttpContent content = response.Content)
                            {
                                //MessageBox.Show (content.Headers.ToString ());
                                string mycontent = await content.ReadAsStringAsync ();
                                int iMessage = mycontent.IndexOf ("message");
                                int iCode = mycontent.IndexOf ("code");
                                string code = mycontent.Substring (iCode + 4, iMessage - (iCode + 4));
                                code = code.Replace ("\"", "").Replace (":", "").Replace (",", "");
                                string message = mycontent.Substring (iMessage + 7);
                                StringBuilder sMessage = new StringBuilder (message);
                                sMessage = sMessage.Replace ("\"", "").Replace ("}", "").Replace ("\\u003c/b\\u003e", "").Replace ("\\u003cb\\u003e", "");
                                switch (code)
                                {
                                    case "1":
                                        hienThongTin (true, sMessage.ToString ());
                                        txtDiaChi.Focus ();
                                        break;
                                    case "2":
                                        hienThongTin (false, sMessage.ToString ());
                                        break;
                                    case "31":
                                        hienThongBao ("#DF0101", sMessage.ToString ());
                                        break;
                                    case "32":
                                        hienThongBao ("#134F5C", sMessage.ToString ());
                                        break;
                                    case "33":
                                        hienThongBao ("#BF9000", sMessage.ToString ());
                                        break;
                                    case "4":
                                        hienThongBao ("#DF0101", sMessage.ToString ());
                                        break;
                                    case "5":
                                        hienThongBao ("#DF0101", sMessage.ToString ());
                                        break;
                                    case "false":
                                        hienThongBao ("#DF0101", "Không có thông tin!");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show ("Không thể kết nối tới cổng bảo hiểm!" + response.RequestMessage);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show ("Không có kết nối internet!");
                }
            }
        }
        private void hienThongTin (bool t, string mess)
        {
            if (t)
            {
                string[] mg = mess.Split ('!');
                string thongtin = mg[1];
                try
                {
                    string[] tmp = thongtin.Split (',');

                    string hoTen = tmp[0].Trim ().Split (':')[1].Trim ();

                    if(hoTen!=txtHoTen.Text)
                    {
                        txtHoTen.Text = hoTen;
                    }

                    string ngaySinh = tmp[1].Trim ().Split (':')[1].Trim();
                    if(ngaySinh != txtNgaySinh.Text)
                    {
                        txtNgaySinh.Text = ngaySinh;
                    }
                    string gioiTinh = tmp[2].Trim ().Split (':')[1].Trim ();
                    if(gioiTinh == "Nam")
                    {
                        cbGioiTinh.SelectedIndex = 1;
                    }
                    else
                    {
                        cbGioiTinh.SelectedIndex = 0;
                    }

                }
                catch { }
                string thongtin2 = mg[2].Replace("(","").Replace(")","").Replace(".","");
                try
                {
                    string[] tmp = thongtin2.Split (';');
                    string diaChi = tmp[0].Split (':')[1].TrimStart ().TrimEnd ();
                    if(txtDiaChi.Text != diaChi)
                    {
                        txtDiaChi.Text = diaChi;
                    }
                    string noiDKKCB = tmp[1].Split (':')[1].TrimStart ().TrimEnd ();
                    if(txtMaDKKCB.Text != noiDKKCB)
                    {
                        txtMaDKKCB.Text = noiDKKCB;
                    }
                    string hanThe = tmp[2].Split (':')[1].Trim ();
                    if(dateGTBD.Text != hanThe.Split('-')[0].Trim())
                    {
                        dateGTBD.Text = hanThe.Split ('-')[0].Trim();
                    }
                    if (dateGTKT.Text != hanThe.Split ('-')[1].Trim())
                    {
                        dateGTKT.Text = hanThe.Split ('-')[1].Trim();
                    }
                }
                catch
                { }
            }
            else
            {
                string[] mg = mess.Split ('!');
                MessageBox.Show (mg[0].Replace (":", ""), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void hienThongBao (string color, string mess)
        {
            MessageBox.Show (mess.Replace (":", ""),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
