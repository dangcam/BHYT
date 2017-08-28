using BHYT.DAO;
using BHYT.VO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmKhamBHYT : Form
    {
        Connection db;
        bool them = false;
        DataTable dt = null;
        DataRow[] dr = null;
        KhoaDAO khoa = null;
        BHYTDAO bhyt = null;
        THONGTINDAO thongtinBHYT = null;
        THONGTIN_CTDAO thongtinCT = null;
        THONGTINVO thongtinThe = new THONGTINVO ();
        THONGTIN_CTVO thongtinBN = new THONGTIN_CTVO ();
        public FrmKhamBHYT (Connection db)
        {
            this.db = db;
            InitializeComponent ();
            bhyt = new BHYTDAO (db);
            thongtinBHYT = new THONGTINDAO (db);
            thongtinCT = new THONGTIN_CTDAO (db);
            khoa = new KhoaDAO (db);
        }

        private void txtQR_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kiemTraQR ();
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
        private void kiemTraQR ()
        {
            if (txtQR.Text.Length > 0)
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
                if (qr != null && qr.Length == 15)
                {
                    txtBHYT.Text = qr[0];
                    txtHoTen.Text = Utils.HexToText (qr[1]);
                    txtNgaySinh.Text = qr[2];
                    if (int.Parse (qr[3]) == 1)
                    {
                        cbGioiTinh.SelectedIndex = 1;
                    }
                    else
                    {
                        cbGioiTinh.SelectedIndex = 0;
                    }
                    txtDiaChi.Text = Utils.HexToText (qr[4]);
                    txtMaDKKCB.Text = qr[5].Remove (2, 3);
                    try
                    {
                        txtTenBV.Text = thongtinCT.getCoSoKCB (txtMaDKKCB.Text).Ten;
                    }
                    catch { }
                    dateGTBD.Text = qr[6];
                    dateGTKT.Text = qr[7];
                    txtDu5Nam.Text = qr[12];

                    if (qr[11] == "5")
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

        private void txtNgaySinh_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDiaChi.Focus ();
            }
        }

        private void txtDiaChi_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtMaDKKCB.Focus ();
            }
        }

        private void txtMaDKKCB_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenBV.Text = thongtinCT.getCoSoKCB (txtMaDKKCB.Text).Ten;
                btnKiemTra.Focus ();
            }
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
                return;
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
                                int iErro = mycontent.IndexOf ("erro");
                                int iCode = mycontent.IndexOf ("code");
                                string code = mycontent.Substring (iCode + 4, iErro - (iCode + 4));
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
                                    case "34":
                                        hienThongBao ("#DF0101", sMessage.ToString ());
                                        break;
                                    case "35":
                                        hienThongBao ("#DF0101", sMessage.ToString ());
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
                                    default:
                                        hienThongBao ("#FF0000", sMessage.ToString ());
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

                    if (hoTen != txtHoTen.Text)
                    {
                        txtHoTen.Text = hoTen;
                    }

                    string ngaySinh = tmp[1].Trim ().Split (':')[1].Trim ();
                    if (ngaySinh != txtNgaySinh.Text)
                    {
                        txtNgaySinh.Text = ngaySinh;
                    }
                    string gioiTinh = tmp[2].Trim ().Split (':')[1].Trim ();
                    if (gioiTinh == "Nam")
                    {
                        cbGioiTinh.SelectedIndex = 1;
                    }
                    else
                    {
                        cbGioiTinh.SelectedIndex = 0;
                    }

                }
                catch { }
                string thongtin2 = mg[2].Replace ("(", "").Replace (")", "").Replace (".", "");
                try
                {
                    string[] tmp = thongtin2.Split (';');
                    string diaChi = tmp[0].Split (':')[1].TrimStart ().TrimEnd ();
                    if (txtDiaChi.Text != diaChi)
                    {
                        txtDiaChi.Text = diaChi;
                    }
                    string noiDKKCB = tmp[1].Split (':')[1].TrimStart ().TrimEnd ();
                    if (txtMaDKKCB.Text != noiDKKCB)
                    {
                        txtMaDKKCB.Text = noiDKKCB;
                        txtTenBV.Text = thongtinCT.getCoSoKCB (txtMaDKKCB.Text).Ten;
                    }
                    string hanThe = tmp[2].Split (':')[1].Trim ();
                    if (dateGTBD.Text != hanThe.Split ('-')[0].Trim ())
                    {
                        dateGTBD.Text = hanThe.Split ('-')[0].Trim ();
                    }
                    if (dateGTKT.Text != hanThe.Split ('-')[1].Trim ())
                    {
                        dateGTKT.Text = hanThe.Split ('-')[1].Trim ();
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
            MessageBox.Show (mess.Replace (":", ""), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtBHYT_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtBHYT.Text.Length != 15)
                {
                    MessageBox.Show ("Mã thẻ phải 15 ký tự.");
                    txtBHYT.Focus ();
                    return;
                }
                dateGTBD.Focus ();
            }
        }

        private void txtBHYT_TextChanged (object sender, EventArgs e)
        {
            if (txtBHYT.Text.Length == 15)
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
                            thongtinThe = thongtinBHYT.getBHYT (txtBHYT.Text, DateTime.Now.ToString ("yyyyMMdd"));
                            if (thongtinThe != null)
                            {
                                // gan tri Benh nhan
                                if (!string.IsNullOrEmpty (thongtinThe.MaLK)&&them==true)
                                {
                                    MessageBox.Show ("Bệnh nhân này hôm nay đã khám!");
                                    txtBHYT.ResetText ();
                                    return;
                                }
                                if (txtQR.Text.Length == 0)
                                {
                                    txtHoTen.Text = thongtinThe.HoTen;
                                    cbGioiTinh.SelectedIndex = thongtinThe.GioiTinh;
                                    txtNgaySinh.Text = Utils.ParseDate (thongtinThe.NgaySinh, true);
                                    txtDiaChi.Text = thongtinThe.DiaChi;
                                    dateGTBD.Text = Utils.ParseDate (thongtinThe.GtTheTu, true);
                                    dateGTKT.Text = Utils.ParseDate (thongtinThe.GtTheDen, true);
                                    cbKhuVuc.Text = thongtinThe.MaKV;
                                    btnPhongKham1.Focus ();
                                }
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
        private void LoadData()
        {
            string ngayBD = DateTime.ParseExact (dateTu.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            string ngayKT = DateTime.ParseExact (dateDen.Text.ToString (), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
            dt = thongtinCT.DSTiepNhan (ngayBD, ngayKT, cbPhong.SelectedIndex);
            gridControl.DataSource = dt;
            if (dt != null)
            {
                lblPhongKham1.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 1").ToString ();
                lblPhongKham2.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 2").ToString ();
                lblPhongKham3.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 3").ToString ();
                lblPhongKham4.Text = dt.Compute ("COUNT(PHONG)", "PHONG = 4").ToString ();
            }
        }
        private void FrmKhamBHYT_Load (object sender, EventArgs e)
        {
            lookUpMaKhoa.Properties.DataSource = khoa.DSKhoa ();
            lookUpMaKhoa.Properties.DisplayMember = "TEN_KHOA";
            lookUpMaKhoa.Properties.ValueMember = "MA_KHOA";
            lookUpMaKhoa.ItemIndex = 0;

            cbPhong.SelectedIndex = 0;
            dateTu.Text = DateTime.Now.ToShortDateString();
            dateDen.Text = DateTime.Now.ToShortDateString();
            txtMaBN.Text = thongtinCT.getMaBN (1 + DateTime.Now.ToString ("yyyyMMdd"));
            thongtinBN.MaLK = AppConfig.CoSoKCB + "PR" + DateTime.Now.Hour.ToString ().Substring (0, 1) + DateTime.Now.Minute.ToString ().Substring (0, 1) + DateTime.Now.Millisecond.ToString ().Substring (0, 1) + txtMaBN.Text;
            them = true;
            LoadData ();
            txtMucHuong.Text = "100";
        }

        private void btnPhongKham1_Click (object sender, EventArgs e)
        {
            LuuThongTin (0);
        }

        private void btnPhongKham2_Click (object sender, EventArgs e)
        {
            LuuThongTin (1);
        }

        private void btnPhongKham3_Click (object sender, EventArgs e)
        {
            LuuThongTin (2);
        }

        private void btnPhongKham4_Click (object sender, EventArgs e)
        {
            LuuThongTin (3);
        }
        private bool KiemTraDauVao()
        {
            if (string.IsNullOrEmpty (txtBHYT.Text))
            {
                MessageBox.Show ("Vui lòng nhập mã thẻ!");
                txtBHYT.Focus ();
                return false;
            }
            if (dateGTBD_KT_ValueChanged () == false)
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
            if (string.IsNullOrEmpty (txtBHYT.Text) || txtBHYT.Text.Length != 15)
            {
                MessageBox.Show ("Vui lòng nhập mã thẻ (15 ký tự).");
                txtBHYT.Focus ();
                return false;
            }
            return true;
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
        private void LuuThongTin(int soPhong)
        {
            if(thongtinBN.MaBenh !=null && thongtinBN.MaBenh.Length>0)
            {
                XtraMessageBox.Show ("Bệnh nhân đã khám!!!");
                return;
            }
            if(KiemTraDauVao())
            {
                if (them == true)
                {
                    txtMaBN.Text = thongtinCT.getMaBN (1 + DateTime.Now.ToString ("yyyyMMdd"));
                    thongtinBN.MaLK = AppConfig.CoSoKCB + "PR" + DateTime.Now.Hour.ToString ().Substring (0, 1) + DateTime.Now.Minute.ToString ().Substring (0, 1) + DateTime.Now.Millisecond.ToString ().Substring (0, 1) + txtMaBN.Text;
                }
                thongtinBN.MaBN = txtMaBN.Text;
                thongtinBN.HoTen = txtHoTen.Text;
                try
                {
                    thongtinBN.NgaySinh = DateTime.ParseExact (txtNgaySinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                }
                catch
                {
                    thongtinBN.NgaySinh = txtNgaySinh.Text;
                }
                thongtinBN.GioiTinh = cbGioiTinh.SelectedIndex;
                thongtinBN.DiaChi = txtDiaChi.Text;
                thongtinBN.MaThe = txtBHYT.Text;
                thongtinBN.MaDKBD = txtMaDKKCB.Text;
                thongtinBN.GtTheTu = DateTime.ParseExact (dateGTBD.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                thongtinBN.GtTheDen = DateTime.ParseExact (dateGTKT.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString ("yyyyMMdd");
                thongtinBN.TenBenh = "";
                thongtinBN.MaBenh = "";
                thongtinBN.MaBenhKhac = "";
                thongtinBN.MaLyDoVaoVien = 1;
                thongtinBN.MaNoiChuyen = "";
                thongtinBN.MaTaiNan = 0;
                thongtinBN.NgayVao = DateTime.Now.ToString ("yyyyMMddHHmm");
                thongtinBN.NgayRa = "";
                thongtinBN.SoNgayDieuTri = 0;
                thongtinBN.KetQuaDieuTri = 1;
                thongtinBN.TinhTrangRaVien = 1;
                thongtinBN.NgayThanhToan = "";
                thongtinBN.MucHuong = Utils.ToInt(txtMucHuong.Text);
                thongtinBN.TienThuoc = 0;
                thongtinBN.TienVTYT = 0;
                thongtinBN.TienTongChiPhi = 0;
                thongtinBN.TienBHTT = 0;
                thongtinBN.TienBNTT = 0;
                thongtinBN.TienNgoaiDS = 0;
                thongtinBN.TienNguonKhac = 0;
                thongtinBN.NamQT = "";
                thongtinBN.ThangQT = "";
                thongtinBN.MaLoaiKCB = 1;
                thongtinBN.MaKhoa = lookUpMaKhoa.EditValue.ToString();
                thongtinBN.MaCSKCB = AppConfig.CoSoKCB;
                thongtinBN.MaKV = "";
                thongtinBN.MaPTTTQT = "";
                thongtinBN.CanNang = 0;
                thongtinBN.CheckOut = false;
                thongtinBN.MaBS = "";
                thongtinBN.Phong = soPhong;
                string err = "";
                if (!them)
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
                them = false;
                LoadData ();
                InSoPhieu ();
                btnMoi_Click (null, null);
            }
        }

        private void btnTim_Click (object sender, EventArgs e)
        {
            LoadData ();
        }

        private void btnMoi_Click (object sender, EventArgs e)
        {
            thongtinBN = new THONGTIN_CTVO ();
            txtMaBN.Text = thongtinCT.getMaBN (1 + DateTime.Now.ToString ("yyyyMMdd"));
            thongtinBN.MaLK = AppConfig.CoSoKCB + "PR" + DateTime.Now.Hour.ToString ().Substring (0, 1) + DateTime.Now.Minute.ToString ().Substring (0, 1) + DateTime.Now.Millisecond.ToString ().Substring (0, 1) + txtMaBN.Text;
            them = true;
            txtQR.Focus ();
            txtQR.Text = "";
            txtBHYT.Text = "";
            dateGTBD.Text = "";
            dateGTKT.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtMucHuong.Text = "100";
        }

        private void gridView_CustomColumnDisplayText (object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.VisibleIndex == 5 && !e.DisplayText.Contains ("/"))
                {
                    e.DisplayText = DateTime.ParseExact (e.DisplayText, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture).ToString ("dd/MM/yyyy");
                }
                if ((e.Column.VisibleIndex == 6) && !e.DisplayText.Contains ("/"))
                {
                    e.DisplayText = DateTime.ParseExact (e.DisplayText, "yyyyMMddHHmm", System.Globalization.CultureInfo.InvariantCulture).ToString ("dd/MM/yyyy");
                }
                if(e.Column.VisibleIndex == 4)
                {
                    if(Utils.ToInt(e.Value.ToString()) == 0)
                    {
                        e.DisplayText = "Nữ";
                    }
                    else
                    {
                        e.DisplayText = "Nam";
                    }
                }
            }
            catch { }
        }

        private void btnIn_Click (object sender, EventArgs e)
        {
            InSoPhieu ();
        }

        private void gridView_RowClick (object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            them = false;
            thongtinBN = thongtinCT.getThongTin (gridView.GetDataRow (e.RowHandle)["MA_LK"].ToString());
            if (thongtinBN != null)
            {
                txtBHYT.Text = thongtinBN.MaThe;
                txtMaBN.Text = thongtinBN.MaBN;
                txtHoTen.Text = thongtinBN.HoTen;
                cbGioiTinh.SelectedIndex = thongtinBN.GioiTinh;
                txtDiaChi.Text = thongtinBN.DiaChi;
                dateGTBD.Text = Utils.ParseDate (thongtinBN.GtTheTu, true);
                dateGTKT.Text = Utils.ParseDate (thongtinBN.GtTheDen, true);
                txtMucHuong.Text = thongtinBN.MucHuong.ToString ();
                //txtTyLe.Text = thongtinBN
                cbKhuVuc.Text = thongtinBN.MaKV;
                txtMaDKKCB.Text = thongtinBN.MaDKBD;
                txtTenBV.Text = txtTenBV.Text = thongtinCT.getCoSoKCB (txtMaDKKCB.Text).Ten;
                txtNgaySinh.Text = Utils.ParseDate (thongtinBN.NgaySinh, true);
                lookUpMaKhoa.EditValue = thongtinBN.MaKhoa;
            }
        }
        private void InSoPhieu()
        {
            if (them == false)
            {
                rptSoPhieu rpt = new rptSoPhieu ();

                rpt.lblTen.Text = thongtinBN.HoTen + " - " + thongtinBN.NgaySinh.Substring (0,4);
                dr = dt.Select ("MA_LK = '"+thongtinBN.MaLK+"'");
                rpt.lblSoTT.Text = dr[0]["STTPHONG"].ToString ().Length<2 ? "0"+ dr[0]["STTPHONG"] : dr[0]["STTPHONG"].ToString ();
                rpt.lblPhong.Text = "Phòng 0"+ dr[0]["PHONG"];
                rpt.lblNgay.Text = DateTime.Now.ToString ("HH:mm dd/MM/yyyy");

                rpt.CreateDocument ();

                rpt.PrintDialog ();
            }
            else
            {
                XtraMessageBox.Show ("Vui lòng chọn bệnh nhân!");
            }
        }

        private void label16_Click (object sender, EventArgs e)
        {

        }

     
    }
}
