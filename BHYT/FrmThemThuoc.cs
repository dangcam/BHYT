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
    public partial class FrmThemThuoc : Form
    {
        ThuocDAO tienthuoc;
        public FrmThemThuoc (Connection db)
        {
            InitializeComponent ();
            tienthuoc = new ThuocDAO (db);
        }

        private void FrmThemThuoc_Load (object sender, EventArgs e)
        {
            cbLoaiThuoc.SelectedIndex = 0;
            lookUpDuongDung.Properties.DataSource = tienthuoc.DSDuongDung ();
            lookUpDuongDung.Properties.ValueMember = "MA_DUONG_DUNG";
            lookUpDuongDung.Properties.DisplayMember = "DUONG_DUNG";
            lookUpDuongDung.ItemIndex = 0;

        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            if(txtMaThuoc.Text.Length == 0)
            {
                MessageBox.Show ("Nhập mã thuốc!");
                txtMaThuoc.Focus ();
                return;
            }
            if (txtTenThuoc.Text.Length == 0)
            {
                MessageBox.Show ("Nhập tên thuốc!");
                txtTenThuoc.Focus ();
                return;
            }
            if (txtDonGia.Text.Length == 0)
            {
                MessageBox.Show ("Nhập giá thuốc!");
                txtDonGia.Focus ();
                return;
            }
            if (txtDonViTinh.Text.Length == 0)
            {
                MessageBox.Show ("Nhập đơn vị tính thuốc!");
                txtDonViTinh.Focus ();
                return;
            }
            if (txtHamLuong.Text.Length == 0)
            {
                MessageBox.Show ("Nhập hàm lượng!");
                txtHamLuong.Focus ();
                return;
            }
           
            TienThuocVO thuoc = new TienThuocVO ();
            try
            {
                thuoc.MaThuoc = txtMaThuoc.Text;
                thuoc.TenThuoc = txtTenThuoc.Text;
                thuoc.HoatChat = txtHoatChat.Text;
                thuoc.HamLuong = txtHamLuong.Text;
                thuoc.DuongDung = lookUpDuongDung.EditValue.ToString();
                thuoc.QuyCach = txtQuyCach.Text;
                thuoc.TieuChuan = txtTieuChuan.Text;
                thuoc.DonViTinh = txtDonViTinh.Text;
                thuoc.DonGia = int.Parse (txtDonGia.Text);
                thuoc.SoDK = txtSoDK.Text;
                thuoc.QuyetDinh = txtQuyetDinh.Text;
                thuoc.NhaSX = txtNhaSX.Text;
                thuoc.NuocSX = txtNuocSX.Text;
                thuoc.HanDung = txtHanDung.Text;
                thuoc.NhomThuoc = (cbLoaiThuoc.SelectedIndex + 1).ToString ();
                thuoc.Nhom = "4";
                thuoc.TinhTrang = true;

                string err = "";
                if (!tienthuoc.ThemTienThuoc (ref err, thuoc))
                {
                    MessageBox.Show (err);
                    return;
                }
                this.Close ();
            }
            catch {
                MessageBox.Show ("Kiểm tra lại các trường đã nhập");
                txtDonGia.SelectAll ();
                txtDonGia.Focus ();
            }
        }
    }
}
