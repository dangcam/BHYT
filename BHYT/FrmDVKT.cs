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
    public partial class FrmDVKT : Form
    {
        DVTKDAO dvkt = null;
        bool luu = false;
        public FrmDVKT (Connection db)
        {
            InitializeComponent ();
            dvkt = new DVTKDAO (db);
        }
        private void LoadData ()
        {
            gridControl.DataSource = dvkt.DSDVKT ();
        }
        private void FrmDVKT_Load (object sender, EventArgs e)
        {
            lookUpNhom.Properties.DataSource = dvkt.DSNhom ();
            lookUpNhom.Properties.DisplayMember = "TEN_NHOM";
            lookUpNhom.Properties.ValueMember = "MA_NHOM";
            lookUpNhom.ItemIndex = 0;
            LoadData ();
            btnLuu.Enabled = false;
        }

        private void bntNhapExcel_Click (object sender, EventArgs e)
        {
            DialogResult dr = ImportExcel.openDialog ();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DataTable data = ImportExcel.OpenFile ();
                    DVKTVO b = null;
                    foreach (DataRow dtRow in data.Rows)
                    {
                        b = new DVKTVO ();
                        b.MaDVKT = dtRow.ItemArray[1].ToString ();
                        b.TenDVKT = dtRow.ItemArray[2].ToString ();
                        b.MaGia = dtRow.ItemArray[3].ToString ();
                        try
                        {
                            b.DonGia = int.Parse (dtRow.ItemArray[4].ToString ().Replace (",", ""));
                        }
                        catch { b.DonGia = 0; }
                        try
                        {
                            b.GiaAX = int.Parse (dtRow.ItemArray[5].ToString ().Replace (",", ""));
                        }
                        catch { b.GiaAX = 0; }
                        b.QuyetDinh = dtRow.ItemArray[6].ToString ();
                        b.CongBo = dtRow[7].ToString ();
                        b.MaNhom = dtRow[0].ToString ();
                        b.DonViTinh = "Lần";
                        if (b.MaNhom != "13" && b.MaNhom != "15")
                        {
                            string err = "";
                            dvkt.ThemDVKT (ref err, b);
                            if (!string.IsNullOrEmpty (err))
                                MessageBox.Show (err);
                        }
                    }
                    LoadData ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void gridView_Click (object sender, EventArgs e)
        {
            try
            {
                txtMaDVKT.ReadOnly = true;
                luu = true;
                DataRow dr = gridView.GetFocusedDataRow ();
                txtMaDVKT.Text = dr["MA_DVKT"].ToString ();
                txtTenDVKT.Text = dr["TEN_DVKT"].ToString ();
                txtDonGia.Text = dr["DON_GIA"].ToString ();
                txtDonViTinh.Text = dr["DON_VI_TINH"].ToString ();
                txtQuyetDinh.Text = dr["QUYET_DINH"].ToString ();
                txtCongBo.Text = dr["CONG_BO"].ToString ();
                lookUpNhom.EditValue = dr["MA_NHOM"].ToString ();
                btnLuu.Enabled = true;
            }
            catch { }
        }

        private void btnMoi_Click (object sender, EventArgs e)
        {
            txtMaDVKT.ReadOnly = false;
            luu = false;

            txtMaDVKT.Text= "";
            txtTenDVKT.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
            txtQuyetDinh.Text = "";
            txtCongBo.Text = "";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click (object sender, EventArgs e)
        {
            if (txtMaDVKT.Text.Length == 0 || txtTenDVKT.Text.Length == 0 ||
               txtDonGia.Text.Length == 0 || txtDonViTinh.Text.Length == 0)
            {
                MessageBox.Show ("Nhập các ô còn thiếu!");
                return;
            }
            try
            {
                DVKTVO vt = new DVKTVO ();
                vt.TenDVKT = txtTenDVKT.Text;
                vt.MaDVKT = txtMaDVKT.Text;
                vt.MaNhom = lookUpNhom.EditValue.ToString();
                vt.DonGia = int.Parse (txtDonGia.Text);
                vt.DonViTinh = txtDonViTinh.Text;
                vt.QuyetDinh = txtQuyetDinh.Text;
                vt.CongBo = txtCongBo.Text;
                vt.MaGia = "";
                vt.GiaAX = vt.DonGia;
                string err = "";
                if (luu)
                {
                    if (!dvkt.SuaDVKT (ref err, vt))
                    {
                        MessageBox.Show (err);
                        return;
                    }
                    LoadData ();
                }
                else
                {
                    if (!dvkt.ThemDVKT (ref err, vt))
                    {
                        MessageBox.Show (err);
                        return;
                    }
                    LoadData ();
                }
            }
            catch
            {
                MessageBox.Show ("Dữ liệu nhập sai!");
            }
        }

        private void btnXoa_Click (object sender, EventArgs e)
        {
            DataRow dr = gridView.GetFocusedDataRow ();
            DialogResult traloi;
            string err = "";
            // Hiện hộp thoại hỏi đáp 
            traloi = MessageBox.Show ("Chắc chắn bạn muốn xóa DVKT này?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                try
                {
                    string ma = dr["MA_DVKT"].ToString ();
                    string ten = dr["TEN_DVKT"].ToString ();
                    if (!dvkt.XoaDVKT (ref err, ma, ten))
                    {
                        MessageBox.Show (err);
                    }
                    LoadData ();
                }
                catch { }
        }
    }
}
