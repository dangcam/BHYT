using BHYT.DAO;
using BHYT.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BHYT
{
    public partial class FrmNV : Form
    {
        NhanVienVO nv = new NhanVienVO ();
        NhanVienDAO nhanvien;
        bool luu = false;
        public FrmNV (Connection db, NhanVienVO nv = null)
        {
            InitializeComponent ();
            this.nv = nv;
            nhanvien = new NhanVienDAO (db);
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            string err = "";
            if(txtMaNV.Text.Length<1)
            {
                MessageBox.Show ("Nhập mã nhân viên y tế.");
                txtMaNV.Focus ();
                return;
            }
            if (txtTen.Text.Length < 1)
            {
                MessageBox.Show ("Nhập tên nhân viên y tế.");
                txtTen.Focus ();
                return;
            }
            nv = new NhanVienVO ();
            try
            {
                nv.MaKhoa = txtMaKhoa.Text;
                nv.MaNhanVien = txtMaNV.Text;
                nv.TenNhanVien = txtTen.Text;
                nv.TenVT = txtTenVT.Text;
                nv.GioiTinh = int.Parse (txtGioiTinh.Text);
                nv.NgaySinh = DateTime.ParseExact (dateNgaySinh.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                nv.DiaChi = txtDiaChi.Text;
                nv.DienThoai = txtDT.Text;
                nv.Email = txtEmail.Text;
                nv.HocHamHocVi = txtHocHamHocVi.Text;
                nv.KhoaBoPhan = txtKhoaBoPhan.Text;
                nv.MaChuyeNganh = txtMaChuyenNganh.Text;
                nv.LoaiNV = txtLoaiNV.Text;
                nv.ChucDanh = txtChucDanh.Text;
                nv.MaCCHN = txtMaCCHN.Text;
                nv.NgayCapCCHN = DateTime.ParseExact (dateNgayCapCCHN.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                nv.NoiCapCCHN = txtNoiCapCCHN.Text;
                nv.TuNgay = DateTime.ParseExact (dateTuNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                nv.DenNgay = DateTime.ParseExact (dateDenNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                nv.VanBangCM = txtVanBang.Text;
                nv.ThoiGianDK = txtThoiGianDK.Text;
            }
            catch
            {
                MessageBox.Show ("Nhập sai định dạng.");
                return;
            }
            if(luu)
            {
                nhanvien.SuaNhanVien (ref err, nv);
                this.Close ();
            }
            else
            {
                nhanvien.ThemNhanVien (ref err, nv);
                this.Close ();
            }
            if(!string.IsNullOrEmpty(err))
            {
                MessageBox.Show (err);
            }
        }

        private void FrmNV_Load (object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = false;
            luu = false;
            txtGioiTinh.Text = "1";
            if(nv!=null)
            {
                txtMaKhoa.Text = nv.MaKhoa;
                txtMaNV.Text = nv.MaNhanVien;
                txtTen.Text = nv.TenNhanVien;
                txtTenVT.Text = nv.TenVT;
                txtGioiTinh.Text = nv.GioiTinh.ToString();
                dateNgaySinh.Text = nv.NgaySinh.ToShortDateString();
                txtDiaChi.Text = nv.DiaChi;
                txtDT.Text = nv.DienThoai;
                txtEmail.Text = nv.Email;
                txtHocHamHocVi.Text = nv.HocHamHocVi;
                txtKhoaBoPhan.Text = nv.KhoaBoPhan;
                txtMaChuyenNganh.Text = nv.MaChuyeNganh;
                txtLoaiNV.Text = nv.LoaiNV;
                txtChucDanh.Text = nv.ChucDanh;
                txtMaCCHN.Text = nv.MaCCHN;
                dateNgayCapCCHN.Text = nv.NgayCapCCHN.ToShortDateString ();
                txtNoiCapCCHN.Text = nv.NoiCapCCHN;
                dateTuNgay.Text = nv.TuNgay.ToShortDateString ();
                dateDenNgay.Text = nv.DenNgay.ToShortDateString ();
                txtVanBang.Text = nv.VanBangCM;
                txtThoiGianDK.Text = nv.ThoiGianDK;

                txtMaNV.ReadOnly = true;
                luu = true;
            }
        }
    }
}
